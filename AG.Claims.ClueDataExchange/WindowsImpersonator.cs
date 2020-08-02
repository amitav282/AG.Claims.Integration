using System;
using System.Net;
using System.Runtime.InteropServices;

namespace AG.Common
{
    public class WindowsImpersonator : IDisposable
    {
        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource, string password, string username, int flags);

        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags, bool force);

        readonly string _networkName;
        public WindowsImpersonator(string networkName, NetworkCredential networkCredential)
        {
            _networkName = networkName;

            const int ResourceScopeGlobalNetwork = 2;
            const int ResourceTypeDisk = 1;
            const int DisplayTypeShare = 0x03;

            var netResource = new NetResource
            {
                Scope = ResourceScopeGlobalNetwork,
                ResourceType = ResourceTypeDisk,
                DisplayType = DisplayTypeShare,
                RemoteName = networkName
            };

            var isAuthenticated = WNetAddConnection2(netResource, networkCredential.Password, networkCredential.UserName, 0);

            if (isAuthenticated != 0)
            {
                throw new FileNetCustomException($"Unable to Authenticate User: {networkCredential.UserName} {isAuthenticated} {networkName}");
            }

        }
        ~WindowsImpersonator()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                WNetCancelConnection2(_networkName, 0, true);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class NetResource
    {
        public int Scope { get; set; }
        public int ResourceType { get; set; }
        public int DisplayType { get; set; }
        public int Usage { get; set; }
        public string LocalName { get; set; }
        public string RemoteName { get; set; }
        public string Comment { get; set; }
        public string Provider { get; set; }
    }
}
