using System;
using AG.Claims.Audatex;
using AG.Claims.Common;

namespace AG.Claims.XactConnect
{
    public class AudatexService : IAudatexService
    {
        #region Public Methods
        /// <summary>
        /// Called by Audatex to upload response xml's and attachments for a claim
        /// </summary>
        /// <param name="audatexInput"></param>
        /// <returns></returns>
        public AudatexResponse UploadAudatexResponse(string audatexInput)
        {
            AudatexResponse response = new AudatexResponse();
            AudatexRequest audatexRequest = new AudatexRequest();
            try
            {
                Log.CreateLog($"Input received from Audatex : ", Level.Info);
                if (!string.IsNullOrEmpty(audatexInput))
                {
                    string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(audatexInput);
                    if (!string.IsNullOrEmpty(deserialzedObject))
                    {
                        Log.CreateLog($"Input String Value {deserialzedObject}", Level.Info);
                        Log.CreateLog($"Calling Claims Wcf service to create file note for Audatex starts : ", Level.Info);
                        response = audatexRequest.UploadAudatexResponse(audatexInput);
                    }
                    else
                    {
                        return ThrowCustomErrorMessage("Input string is Not in the Correct Format : ");
                    }
                }
                else
                {
                    return ThrowCustomErrorMessage("Input string is Null or Empty : ");
                }
            }
            catch (Exception ex)
            {
                WriteError(ex, response, "Some error has occurred. Kindly retry");
            }
            return response;
        }
        /// <summary>
        /// Called by Claims Application to send Assignment Request to Audatex
        /// </summary>
        /// <param name="audatexInput"></param>
        /// <returns></returns>
        public AudatexResponse SendAsignmentRequest(Integration.Types.AssignmentAddRq audatexInput)
        {
            AudatexResponse response = new AudatexResponse();
            AudatexRequest audatexRequest = new AudatexRequest();
            try
            {
                Log.CreateLog($"Initiating Audatex Call : ", Level.Info);
                string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(audatexInput);
                Log.CreateLog($"Input String Value {deserialzedObject}", Level.Info);
                if (audatexInput != null)
                {
                    response = audatexRequest.SendEstimationToVendor(audatexInput);
                }
                else
                {
                    return ThrowCustomErrorMessage("Input object is null : ");
                }
            }
            catch (Exception ex)
            {
                WriteError(ex, response, "Some error has occurred. Kindly retry");
            }
            return response;
        }
        #endregion
        #region Private Method
        /// <summary>
        /// Error Handling Method
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="response"></param>
        /// <param name="customMessage"></param>
        private void WriteError(Exception ex, AudatexResponse response, string customMessage)
        {
            if (ex is CommonException)
            {
                response.Response = customMessage;
            }
            else
            {
                Log.CreateLog(ex);
                response.Response = ex.Message;
            }
            response.Status = "Failure";
        }
        /// <summary>
        /// Returns Custom Error Message
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>AudatexResponse object</returns>
        private AudatexResponse ThrowCustomErrorMessage(string msg)
        {
            AudatexResponse response = new AudatexResponse();
            response.Message = msg;
            response.Status = "Failure";
            response.Response = msg;
            return response;
        }
        #endregion
    }
}
