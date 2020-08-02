using System;
using AG.Claims.Common;
using AG.Claims.Integration.Types;
using AG.Claims.IVAuto;


namespace AG.Claims.XactConnect
{

    public class IVAutoService : IIVAuto
    {
        /// <summary>
        ///  Sends the data from Activity to the IV Auto class
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns>IVAutoResponse class as an object</returns>
        public IVAutoResponse SendDataToIVAUTO(AssignmentIVAuto inputAssignment)
        {
            IVAUTO autoDetail = new IVAUTO();
            IVAutoResponse response = new IVAutoResponse();
            try
            {
                string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(inputAssignment);
                Log.CreateLog($"Initiating IV AUTO Call", Level.Info);
                Log.CreateLog($"Input String Value {deserialzedObject}", Level.Info);
                return autoDetail.AssignmentIVAuto(inputAssignment);
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
        private void WriteError(Exception ex, IVAutoResponse response, string customMessage)
        {
            if (ex is CommonException)
            {

                response.Message = ex.Message;
            }
            else
            {
                Log.CreateLog(ex);
                response.Message = ex.Message;

            }
            response.Status = "Failure";
            response.StockNumber = "Error";
        }
    }
}
