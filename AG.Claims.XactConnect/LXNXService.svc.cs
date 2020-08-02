using System;
using AG.Claims.Common;
using AG.Claims.LXNX;
using AG.Claims.Integration.Types;

namespace AG.Claims.XactConnect
{
    public class LXNXService : ILXNX
    {
        /// <summary>
        /// Sends the data from DCT View to the LXNX class
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns>ResponseDetails class as an object</returns>
        public LXNXResponse SendAssignmentRequest(order input)
        {
            LXNX.LXNX lxnxDetails = new LXNX.LXNX();
            LXNXResponse response = new LXNXResponse();
            try
            {
                string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(input);
                Log.CreateLog($"Initiating LXNX Call", Level.Info);
                Log.CreateLog($"Input String Value {deserialzedObject}", Level.Info);
                return lxnxDetails.SendAssignmentRequest(input);
            }

            catch (Exception ex)
            {
                WriteError(ex, response, "Some error has occurred. Kindly retry");
            }
            return response;
        }
        /// <summary>
        /// Error Handling Method
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="response"></param>
        /// <param name="customMessage"></param>
        private void WriteError(Exception ex, LXNXResponse response, string customMessage)
        {
            if (ex is CommonException)
            {

                response.LXResponse = ex.Message;
            }
            else
            {
                Log.CreateLog(ex);
                response.LXResponse = ex.Message;

            }
            response.Message = "Failure";
            response.Status = "Error";
        }
    }
}
