using System;
using AG.Claims.ATP;
using AG.Claims.ATP.DataContract;
using AG.Claims.Common;
using AG.Claims.Integration.Types;


namespace AG.Claims.XactConnect
{

    public class ATPService : IATP
    {
        /// <summary>
        /// Sends the data from Activity to the ATP class
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns>ResponseDetails class as an object</returns>
        public ResponseDetails SendDataToATP(Assignment inputAssignment)
        {
            ATP.ATP atpDetail = new ATP.ATP();
            ResponseDetails response = new ResponseDetails();
            try
            {
                string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(inputAssignment);
                Log.CreateLog($"Initiating ATP Call", Level.Info);
                Log.CreateLog($"Input String Value {deserialzedObject}", Level.Info);
                return atpDetail.InitiateATPCall(inputAssignment);
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
        private void WriteError(Exception ex, ResponseDetails response, string customMessage)
        {
            if (ex is CommonException)
            {

                response.Response = ex.Message;
            }
            else
            {
                Log.CreateLog(ex);
                response.Response = ex.Message;

            }
            response.Error = "Failure";
            response.StockNumber = "Error";
        }

    }

}
