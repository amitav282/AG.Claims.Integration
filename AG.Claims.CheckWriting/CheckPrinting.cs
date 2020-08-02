using System.Linq;
using AG.Claims.Common;
using AG.Claims.Integration.Types;

namespace AG.Claims.CheckWriting
{
    public class CheckPrinting
    {
        /// <summary>
        /// Gets the list of payments 
        /// </summary>
        /// <returns>ChequeResponse</returns>
        public ChequeResponse GetPaymentDetails()
        {
            ChequeResponse response = new ChequeResponse();
            string checkstatus = string.Empty;
            Log.CreateLog($"Call to Common Service to Get Payment Details ", Level.Info);
            response.CheckDetail = GetChequeDetails();
            if (response.CheckDetail == null || response.CheckDetail.Count() == 0)
            {
                Log.CreateLog("No Records Available", Level.Info);
                throw new CommonException("No Records Available");
            }
            else
            {
                response.Message = "Payment Details Received";
                response.Status = "Success";
            }
            return response;
        }

        /// <summary>
        /// Updates the check number for the payment
        /// </summary>
        /// <param name="checkDetails"></param>
        /// <returns></returns>
        public ChequeResponse UpdateCheckNumber(AG_ClaimCheckWritingDTO[] checkDetails)
        {
            ChequeResponse response = new ChequeResponse();
            Log.CreateLog($"Call to Service to Update Check Number based on Payment ID ", Level.Info);
            string output = UpdateChequeDetails(checkDetails);
            if (output.Contains("Success"))
            {
                response.Message = output;
                response.Status = "Success";
            }
            else if (output.Contains("Error"))
            {
                throw new CommonException(output);
            }
            return response;
        }

        /// <summary>
        /// Gets the array of Payment Details Object
        /// </summary>
        /// <returns>AG_ClaimCheckWritingDTO[]</returns>
        public AG_ClaimCheckWritingDTO[] GetChequeDetails()
        {
            AG_Common.AG_CommonClient common = new AG_Common.AG_CommonClient();
            return common.GetCheckPrintingInformation();
        }
        /// <summary>
        /// Updates the Check Number based on payment ID
        /// </summary>
        /// <param name="checkDetails"></param>
        /// <returns>string</returns>
        public string UpdateChequeDetails(AG_ClaimCheckWritingDTO[] checkDetails)
        {
            AG_Common.AG_CommonClient common = new AG_Common.AG_CommonClient();
            return common.UpdateCheckDetail(checkDetails);
        }
    }
}
