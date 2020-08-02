using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Reflection;
using Newtonsoft.Json;
using AG.Claims.Common;
using AG.Claims.Integration.Types;
using Renci.SshNet;
using System.Linq;
using System.Net;

namespace AG.Claims.ClueDataExchange
{

    public class ClueDataExchange
    {

        /// <summary>
        /// To calculate the length of numeric field
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int IntLength(int propValue)
        {
            if (propValue < 0)
                return (int)Math.Floor(Math.Log10(-(propValue))) + 2;
            if (propValue == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(propValue)) + 1;

        }

        /// <summary>
        /// To manipulate integrer value
        /// </summary>
        /// <param name="clueDataProp"></param>
        /// <param name="clueDTO"></param>
        /// <returns></returns>
        private string ManipulateInteger(PropertyInfo clueDataProp, AGClaimClueDataExchangeDTO clueDTO)
        {

            if (clueDataProp.PropertyType == typeof(Int32))
            {
                var padlength = (clueDataProp.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute).PadLength;

                var actualLength = IntLength(Convert.ToInt32(clueDataProp.GetValue(clueDTO)));
                int diffLength = padlength - actualLength;
                if (diffLength > 0)
                    return clueDataProp.GetValue(clueDTO).ToString().PadLeft(padlength, '0');

                else
                    return clueDataProp.GetValue(clueDTO).ToString().Remove(padlength, -(diffLength));


            }
            return string.Empty;
        }
        /// <summary>
        /// To manipulate string value
        /// </summary>
        /// <param name="clueDataProp"></param>
        /// <param name="clueDTO"></param>
        /// <param name="punctuation"></param>
        /// <returns></returns>
        private string ManipulateString(PropertyInfo clueDataProp, AGClaimClueDataExchangeDTO clueDTO, string punctuation)
        {

            if (clueDataProp.PropertyType == typeof(string))
            {

                var clueValue = clueDataProp.GetValue(clueDTO) == null ? string.Empty : clueDataProp.GetValue(clueDTO).ToString();
                clueValue = Regex.Replace(clueValue, punctuation, " ");
                var padlength = (clueDataProp.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute).PadLength;
                var actualLength = clueValue.Length;
                int diffLength = padlength - actualLength;

                if (diffLength > 0)
                {
                    return clueValue.ToString().PadRight(padlength, ' ').ToUpper();
                }
                else
                    return clueValue.ToString().Remove(padlength, -(diffLength)).ToUpper();
            }
            return string.Empty;
        }
        /// <summary>
        /// To manipulate datetime value 
        /// </summary>
        /// <param name="clueDataProp"></param>
        /// <param name="clueDTO"></param>
        /// <returns></returns>
        private string ManipulateDate(PropertyInfo clueDataProp, AGClaimClueDataExchangeDTO clueDTO)
        {
            if (clueDataProp.PropertyType == typeof(DateTime))
            {
                var dateProp = Convert.ToDateTime(clueDataProp.GetValue(clueDTO)) == DateTime.MinValue ? string.Empty : Convert.ToDateTime(clueDataProp.GetValue(clueDTO)).ToString("MMddyyyy");
                var padLength = (clueDataProp.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute).PadLength;


                return dateProp.PadLeft(padLength, '0');


            }
            return string.Empty;
        }
        /// <summary>
        /// To manipulate header fields
        /// </summary>
        /// <param name="head"></param>
        /// <param name="lastBatchExec"></param>
        /// <param name="objHeader"></param>
        /// <returns></returns>
        private string ManipulateHeader(PropertyInfo head, DateTime lastBatchExec, ClueHeader objHeader)
        {
            var padLength = (head.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute).PadLength;

            if (head.Name == "ReportingBeginDate")
            {
                if (lastBatchExec == DateTime.MinValue)
                    return string.Empty.PadLeft(padLength, '0');
                else
                    return string.Format("{0}{1}", (lastBatchExec.Year / 100) , lastBatchExec.ToString("yyMMdd"));
            }
            else if (head.Name == "RestartBlockNumber")
                return head.GetValue(objHeader).ToString().PadLeft(padLength, '0');

            else
                return head.GetValue(objHeader).ToString().PadRight(padLength, ' ');

        }
        /// <summary>
        /// To manipulate trailer field
        /// </summary>
        /// <param name="trailer"></param>
        /// <param name="objTrailer"></param>
        /// <param name="counter"></param>
        /// <returns></returns>
        private string ManipulateTrailer(PropertyInfo trailer, ClueTrailer objTrailer, int counter)
        {
            var padLength = (trailer.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute).PadLength;
            if (trailer.Name == "TotalRecords")
            {
                return counter.ToString().PadLeft(padLength, '0');
            }
            else
                return trailer.GetValue(objTrailer).ToString().PadRight(padLength, ' ');
        }

        /// <summary>
        /// To create the flat file with claim records
        /// </summary>
        /// <param name="clueDTO"></param>
        /// <param name="clueHeader"></param>
        /// <param name="clueTrailer"></param>
        /// <param name="punctuation"></param>
        /// <param name="dtLastBatchExec"></param>
        /// <returns></returns>
        private string WriteClueData(List<AGClaimClueDataExchangeDTO> clueDTO, ClueHeader clueHeader, ClueTrailer clueTrailer, string punctuation, DateTime dtLastBatchExec)
        {
            int counter = 0;
            string clueFilePath = string.Empty;
            string sharedPath = ConfigurationManager.AppSettings["SharedPath"];
            using (new WindowsImpersonator($@"{sharedPath}", new NetworkCredential()
            {
                UserName = ConfigurationManager.AppSettings["SharedPathUserName"],
                Password = ConfigurationManager.AppSettings["SharedPathPassword"]
            }))
            {
                clueFilePath = sharedPath + ConfigurationManager.AppSettings["ClueDataPath"] +
                "clue_history_anchgen1_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";           
                using (StreamWriter sw = new StreamWriter(clueFilePath))
                {
                    Log.CreateLog("Writing Header details into the file:", Level.Info);
                    foreach (var head in clueHeader.GetType().GetProperties())
                    {
                        sw.Write(ManipulateHeader(head, dtLastBatchExec, clueHeader));
                    }
                    sw.WriteLine();

                    if (clueDTO != null)
                    {
                        Log.CreateLog("Total Number of Clue Records:" + clueDTO.Count, Level.Info);
                        foreach (var clueData in clueDTO)
                        {
                            foreach (var clueDataProp in clueData.GetType().GetProperties())
                            {
                                var clueDataPropValue = string.Empty;

                                if ((clueDataPropValue = ManipulateInteger(clueDataProp, clueData)) == string.Empty)

                                    if ((clueDataPropValue = ManipulateString(clueDataProp, clueData, punctuation)) == string.Empty)

                                        clueDataPropValue = ManipulateDate(clueDataProp, clueData);
                                Log.CreateLog("Writing Clue data into the file:" + clueDataPropValue, Level.Debug);
                                sw.Write(clueDataPropValue);
                            }
                            sw.WriteLine();

                            counter++;
                        }
                    }
                    Log.CreateLog("Writing Trailer details into the file:", Level.Info);
                    foreach (var footer in clueTrailer.GetType().GetProperties())
                    {
                        sw.Write(ManipulateTrailer(footer, clueTrailer, counter));
                    }
                    sw.WriteLine();
                }
            }
            return clueFilePath;
        }

        /// <summary>
        /// To read the Clueconfig json file and pass the field values to WriteClueData method
        /// </summary>
        /// <param name="clueData"></param>
        /// <param name="dtLastBatchExec"></param>
        /// <returns></returns>
        public string ProcessClueData(List<AGClaimClueDataExchangeDTO> clueData, DateTime dtLastBatchExec)
        {
            var jsonFilePath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "ClueConfig.json";
            var json = File.ReadAllText(jsonFilePath);
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            return WriteClueData(clueData, (obj.Header.ToObject<ClueHeader>() as ClueHeader), (obj.Trailer.ToObject<ClueTrailer>() as ClueTrailer), obj.Punctuation.ToString(), dtLastBatchExec);
        }
        /// <summary>
        /// To upload Clue file in SFTP
        /// </summary>
        /// <param name="filePath"></param>        
        public void UploadSftpFile(string clueFile, string sftpConfKey)
        {
            Log.CreateLog($"Uploading file to SFTP shared path", Level.Info);
            string[] sftpDetails = ConfigurationManager.AppSettings[sftpConfKey].Split(',');

            Dictionary<string, string> sftpList = sftpDetails.ToDictionary(s => s.Split(':')[0], s => s.Split(':')[1]);
            var ftpUrl = sftpList.ContainsKey("SFTPUrl") ? sftpList["SFTPUrl"] : string.Empty;
            var userName = sftpList.ContainsKey("SFTPUserName") ? sftpList["SFTPUserName"] : string.Empty;
            var password = sftpList.ContainsKey("SFTPPassword") ? sftpList["SFTPPassword"] : string.Empty;
            var port = sftpList.ContainsKey("SFTPPort") ? sftpList["SFTPPort"] : string.Empty;
            var ftpDirectory = sftpList.ContainsKey("SFTPDirectory") ? sftpList["SFTPDirectory"] : string.Empty;

             
            FileInfo file = new FileInfo(clueFile);
            var uploadFile = file.FullName;
            using (SftpClient sftpClient = new SftpClient(ftpUrl, Convert.ToInt32(port), userName, password))
            {
                sftpClient.Connect();
                if (sftpClient.IsConnected)
                {
                    Log.CreateLog($"SFTP Client is connected to:" + ftpUrl, Level.Info);
                    var fileStream = new FileStream(uploadFile, FileMode.Open);
                    if (fileStream != null)
                    {
                        if (!string.IsNullOrEmpty(ftpDirectory))
                        {
                            sftpClient.UploadFile(fileStream, ftpDirectory + "/" + file.Name, null);
                        }
                        else
                        {
                            sftpClient.UploadFile(fileStream, "/" + file.Name, null);
                        }
                        Log.CreateLog($"Clue file is uploaded to:" + ftpUrl, Level.Info);
                        sftpClient.Disconnect();
                        sftpClient.Dispose();
                    }
                }
            }


        }
    }
}
