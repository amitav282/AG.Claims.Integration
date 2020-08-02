using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AG.Claims.Common
{
    public class RestAuthMgr : ServiceAuthorizationManager
    {
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            var authHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
            if (authHeader != null && (authHeader != string.Empty) && authHeader.StartsWith("Basic"))
            {
                string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                string usernamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedUsernamePassword));

                int seperatorIndex = usernamePassword.IndexOf(':');

                var username = usernamePassword.Substring(0, seperatorIndex);
                var password = usernamePassword.Substring(seperatorIndex + 1);
                if (CheckIfuserAuthenticated(username, password))
                {
                    return true;
                }
            }           
            return false;
        }

        private bool CheckIfuserAuthenticated(string username, string password)
        {
            if (username == ConfigurationManager.AppSettings["UserName"] && password == ConfigurationManager.AppSettings["Password"])
            {
                return true;
            }
            return false;
        }
    }
}
