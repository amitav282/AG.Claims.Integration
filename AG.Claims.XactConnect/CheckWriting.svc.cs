using System;
using System.Reflection;
using AG.Claims.CheckWriting;
using AG.Claims.Common;
using AG.Claims.Integration.Types;

namespace AG.Claims.XactConnect
{
    public class CheckWriting : ICheckWriting
    {
        #region Public Method
        /// <summary>
        /// This method is called from the CWA. This methods gets the Payment Details
        /// </summary>
        /// <returns>ChequeResponse</returns>
        public ChequeResponse GetCheckPrintingInformation()
        {
            CheckPrinting checkPrinting = new CheckPrinting();
            ChequeResponse response = new ChequeResponse();
            try
            {
                Log.CreateLog($"Getting Payment Detail List Starts", Level.Info);
                response = checkPrinting.GetPaymentDetails();
                //Comment when we are moving to production
                //WriteData(response);
            }

            catch (Exception ex)
            {
                WriteError(ex, response, "Some error has occurred. Kindly retry");
            }
            return response;
        }
        public ChequeResponse UpdateCheckDetail(AG_ClaimCheckWritingDTO[] checkDetail)
        {
            CheckPrinting checkPrinting = new CheckPrinting();
            ChequeResponse response = new ChequeResponse();
            Log.CreateLog($"Update Check Detail Starts", Level.Info);
            try
            {
                return checkPrinting.UpdateCheckNumber(checkDetail);
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
        private void WriteError(Exception ex, ChequeResponse response, string customMessage)
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
            response.CheckDetail = null;
        }
        /// <summary>
        /// Takes a object and creates a string with the property Names
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ConvertObjectToString(object input)
        {
            string data = string.Empty;
            if (input == null) return data;
            Type t = input.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo prp in props)
            {
                object value = prp.GetValue(input, new object[] { });
                data = data + prp.Name + "=" + value + "&";
            }
            return data.Remove(data.Length - 1);
        }
        private void WriteData(ChequeResponse response)
        {
            if (response.CheckDetail != null && response.Status.Contains("Success"))
                foreach (AG_ClaimCheckWritingDTO check in response.CheckDetail)
                {
                    System.Web.HttpContext.Current.Response.Write(ConvertObjectToString(check));
                    System.Web.HttpContext.Current.Response.Write("< br />");
                }
        }
        #endregion
    }
}
