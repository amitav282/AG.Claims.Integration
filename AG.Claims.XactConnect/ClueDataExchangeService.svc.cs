using System;
using AG.Claims.ClueDataExchange;
using AG.Claims.Integration.Types;
using AG.Claims.Common;

namespace AG.Claims.XactConnect
{

    public class ClueDataExchangeService : IClueDataExchange
    {
        /// <summary>
        /// Send the data from Activity to the ClueDataExchange Class
        /// </summary>
        /// <param name="clueDTOs"></param>
        public Response SendDataToClue(ClueDTOs clueDTOs)
        {

            try
            {
                Log.CreateLog($"Writing Claims data into file: "+ ServiceConsumer.ToJson<ClueDTOs>(clueDTOs), Level.Info);
                ClueDataExchange.ClueDataExchange clueDetails = new ClueDataExchange.ClueDataExchange();
                var clueFilePath = clueDetails.ProcessClueData(clueDTOs.AGClaimClueDataExchangeDTOs, clueDTOs.LastBatchExecDate);
                clueDetails.UploadSftpFile(clueFilePath, "ClueDataExchange");
                return new Response
                {
                    Message = "Successfully created Clue file",
                    Status = "Success"
                };
            }
            catch (Exception ex)
            {
                Log.CreateLog(ex);
                return new Response
                {
                    Message = "Unable to generate Clue file",
                    Status = "Fail"
                };
            }

        }

    }
}
