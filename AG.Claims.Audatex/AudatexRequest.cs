using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Data;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using AG.Claims.Common;
using AG.Claims.Integration.Types;
using AG.Claims.Audatex.AudatexOutbound;

namespace AG.Claims.Audatex
{
    public class AudatexRequest
    {
        /// <summary>
        /// Sends the data from service to Audatex
        /// </summary>
        /// <param name="audatexDetails"></param>
        /// <returns>AudatexResponse object</returns>
        public AudatexResponse SendEstimationToVendor(Integration.Types.AssignmentAddRq audatexDetails)
        {
            AudatexResponse resp = new AudatexResponse();
            AudatexOutbound.AudatexB2BFNOLServiceClient serviceClient = new AudatexOutbound.AudatexB2BFNOLServiceClient();
            AudatexOutbound.AssignmentAddRs response = new AudatexOutbound.AssignmentAddRs();
            string errorMessage = string.Empty;
            string errorCode = string.Empty;
            try
            {
                response = serviceClient.AddFnol(CreateXML(audatexDetails));
                if (response != null)
                {
                    string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(response);
                    Log.CreateLog($"Received Audatex Response string is :-  {deserialzedObject}", Level.Info);
                    if (response.applicationStatusField != null)
                    {
                        if (response.applicationStatusField.applicationStatusCodeField.ToString() == "Reject")
                        {
                            foreach (ApplicationStatusTypeApplicationError error in response.applicationStatusField.applicationErrorField)
                            {
                                errorMessage = errorMessage + error.errorDescField + " ,";
                                errorCode = errorCode + error.errorCodeField + " ,";
                            }
                            if (!string.IsNullOrEmpty(errorMessage))
                            {
                                errorMessage = errorMessage.Remove(errorMessage.Length - 1);
                                errorCode = errorCode.Remove(errorCode.Length - 1);
                            }
                            string reqId = audatexDetails.RqUID;
                            reqId = reqId.Replace("-", "");
                            reqId = reqId.Substring(0, 16);
                            resp.Response = string.Format("Audatex Request failed with error : {0} for Request ID :{1} ", errorMessage, reqId);
                            resp.Message = errorCode;
                            resp.Status = "Failure";
                            Log.CreateLog($"Audatex Request failed with error : {resp.Response} for Request ID :{reqId} ", Level.Info);
                        }
                        else
                        {
                            resp.Response = audatexDetails.RqUID;
                            resp.Status = "Success";
                            resp.Message = response.applicationStatusField.applicationStatusCodeField.ToString();
                            Log.CreateLog($"Audatex Request successful :- ", Level.Info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return resp;
        }
        /// <summary>
        /// Uploads the Response xml's from Audatex to FileNote
        /// </summary>
        /// <param name="audatexDetails"></param>
        /// <returns>AudatexResponse object</returns>
        public AudatexResponse UploadAudatexResponse(string audatexDetails)
        {
            AudatexResponse response = new AudatexResponse();
            AG_AudatexInboundDTO inboundDetail = new AG_AudatexInboundDTO();
            AudatexInboundAttachmentDetail attachmentDetail = null;
            string claimNumber = string.Empty;
            string reqID = string.Empty;
            string subject = string.Empty;
            string inputAttachment = string.Empty;
            string attachmentType = string.Empty;
            string attachmentFileName = string.Empty;
            string attachmentFileType = string.Empty;
            string embeddedAttachment = null;
            int totalDocs = 0;
            int currentDoc = 0;
            try
            {
                if (!string.IsNullOrEmpty(audatexDetails))
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(audatexDetails);
                    XmlNodeList nodeListReqId = xml.GetElementsByTagName("RqUID");
                    XmlNodeList nodeListClaimNumber = xml.GetElementsByTagName("ClaimNum");
                    XmlNodeList nodeListCurrentDoc = xml.GetElementsByTagName("CurrentDoc");
                    XmlNodeList nodeListTotalDocs = xml.GetElementsByTagName("TotalDocs");
                    XmlNodeList nodeListAttachmentType = xml.GetElementsByTagName("AttachmentType");
                    XmlNodeList nodeListAttachmentFileName = xml.GetElementsByTagName("AttachmentFileName");
                    XmlNodeList nodeListAttachmentFileType = xml.GetElementsByTagName("AttachmentFileType");
                    XmlNodeList nodeListEmbeddedAttachment = xml.GetElementsByTagName("EmbeddedAttachment");
                    foreach (XmlNode node in nodeListReqId)
                    {
                        reqID = node.InnerText;

                    }
                    reqID = reqID.Replace("-", "");
                    reqID = reqID.Substring(0, 16);
                    foreach (XmlNode node in nodeListClaimNumber)
                    {
                        claimNumber = node.InnerText.Substring(0, 11);
                    }
                    if (string.IsNullOrEmpty(reqID))
                    {
                        Log.CreateLog($"Audatex Input Request ID is empty : ", Level.Info);
                        throw new CommonException("Audatex Input Request ID is empty : ");
                    }
                    if (string.IsNullOrEmpty(claimNumber))
                    {
                        Log.CreateLog($"Audatex Input Claim Number is empty : ", Level.Info);
                        throw new CommonException("Audatex Input Claim Number is empty : ");
                    }
                    foreach (XmlNode node in nodeListCurrentDoc)
                    {
                        currentDoc = Convert.ToInt16(node.InnerText);
                    }
                    foreach (XmlNode node in nodeListTotalDocs)
                    {
                        totalDocs = Convert.ToInt16(node.InnerText);
                    }
                    foreach (XmlNode node in nodeListAttachmentType)
                    {
                        attachmentType = node.InnerText;
                    }
                    foreach (XmlNode node in nodeListAttachmentFileName)
                    {
                        attachmentFileName = node.InnerText;
                    }
                    foreach (XmlNode node in nodeListAttachmentFileType)
                    {
                        attachmentFileType = node.InnerText;
                    }
                    foreach (XmlNode node in nodeListEmbeddedAttachment)
                    {
                        embeddedAttachment = node.InnerText;
                    }

                    if (audatexDetails.Contains("VehicleDamageEstimateAddRq"))
                    {
                        subject = "Damage Estimate";
                    }
                    else if (audatexDetails.Contains("ValuationReportAddRq"))
                    {
                        subject = "Valuation";
                    }
                    else if (audatexDetails.Contains("AttachmentAddRq"))
                    {
                        subject = "Attachment";
                    }

                    inboundDetail.ClaimID = claimNumber;
                    inboundDetail.Subject = "Vehicle Estimate/Valuation";
                    inboundDetail.Text = string.Format("Audatex Response for {0} with Request ID {1}", subject, reqID);
                    inboundDetail.ImageData = embeddedAttachment;

                    string attachment = string.Empty;
                    attachmentDetail = CreateAttachment(claimNumber, reqID, subject, currentDoc, totalDocs, attachmentType, attachmentFileName, attachmentFileType, embeddedAttachment, audatexDetails);
                    int result = InsertRecordAndCheckForCount(ref attachment, attachmentDetail);
                    if (subject != "Attachment")
                    {
                        if (string.IsNullOrEmpty(embeddedAttachment))
                        {
                            byte[] xmlInput = Encoding.UTF8.GetBytes(audatexDetails);
                            inboundDetail.ImageData = Convert.ToBase64String(xmlInput);
                            inboundDetail.AttachmentType = "xml";
                        }
                        else
                            inboundDetail.AttachmentType = "pdf";
                        CreateFileNote(response, reqID, inboundDetail);
                        inboundDetail.ImageData = string.Empty;
                        inboundDetail.AttachmentType = string.Empty;
                    }                    
                    if (string.IsNullOrEmpty(attachment))
                    {
                        if (result == 0)
                        {
                            return new AudatexResponse { Status = "Success", Message = string.Format("Record saved to database, for claim number {0} and for {1} with Request ID {2}: ", attachmentDetail.ClaimNumber, attachmentDetail.DocumentType, attachmentDetail.ReqId) };
                        }
                        else if (result == -101)
                        {
                            return new AudatexResponse { Status = "Failure", Message = string.Format("Insert to Database Failed, for claim number {0} and for {1} with Request ID {2}: ", attachmentDetail.ClaimNumber, attachmentDetail.DocumentType, attachmentDetail.ReqId) };
                        }
                    }
                    else
                    {
                        inboundDetail.AttachmentType = "pdf";
                        inboundDetail.Text = string.Format("Audatex Response for {0} with Request ID {1}", "Attachments", reqID);
                        inboundDetail.ImageData = attachment;
                        CreateFileNote(response, reqID, inboundDetail);
                    }

                }
                else
                {
                    Log.CreateLog($"Audatex Input string is not valid : ", Level.Info);
                    throw new CommonException("Audatex Input string is not valid : ");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return response;
        }
        #region Private Methods
        /// <summary>
        /// CCreates the attachment object from xml when the input type is of Estimate and Valuation 
        /// </summary>
        /// <param name="estimateReturn"></param>
        /// <param name="inputReceived"></param>
        /// <returns>AudatexInboundAttachmentDetail object</returns>
        private AudatexInboundAttachmentDetail CreateAttachment(string claimNumber, string reqId, string subject, int currentDoc, int totalDocs, string attachmentType, string attachmentFileName, string attachmentFileType, string embeddedAttachment,string inputXml)
        {
            AudatexInboundAttachmentDetail attachmentDetail = new AudatexInboundAttachmentDetail();

            attachmentDetail.ClaimNumber = claimNumber;
            attachmentDetail.ReqId = reqId;
            attachmentDetail.CurrentDoc = currentDoc;
            attachmentDetail.TotalDocs = totalDocs;
            if (!string.IsNullOrEmpty(attachmentFileType))
                attachmentDetail.DocumentFileType = attachmentFileType;
            else
                attachmentDetail.DocumentFileType = subject;
            if (!string.IsNullOrEmpty(attachmentFileName))
                attachmentDetail.DocumentFileName = attachmentFileName;
            else
                attachmentDetail.DocumentFileName = subject;
            if (subject=="Attachment")
                attachmentDetail.DocumentType = attachmentType;
            else
                attachmentDetail.DocumentType = "Xml"; 
            if (!string.IsNullOrEmpty(embeddedAttachment))
                attachmentDetail.DocumentContent = Convert.FromBase64String(embeddedAttachment);
            else
                attachmentDetail.DocumentContent = Encoding.UTF8.GetBytes(inputXml);
            attachmentDetail.FilenoteCreated = 0;
            return attachmentDetail;
        }
        /// <summary>
        /// Calls the wcf service to create filenote in claims
        /// </summary>
        /// <param name="response"></param>
        /// <param name="reqID"></param>
        /// <param name="inboundDetail"></param>
        private void CreateFileNote(AudatexResponse response, string reqID, AG_AudatexInboundDTO inboundDetail)
        {
            string output = UploadInboundRequest(inboundDetail);
            if (output.Contains("Success"))
            {
                response.Message = "File Note Created with attachment";
                response.Status = "Success";
                Log.CreateLog($"File Note created successfully for claim ID {inboundDetail.ClaimID} and for {inboundDetail.Subject} with Request ID {reqID}: ", Level.Info);
            }
            else if (output.Contains("Error"))
            {
                throw new CommonException(output);
            }

        }
        /// <summary>
        /// Inserts entry into table and checks for the no of records inserted
        /// </summary>
        /// <param name="inboundDetail"></param>
        /// <param name="attachmentDetail"></param>
        /// <returns></returns>
        private int InsertRecordAndCheckForCount(ref string image, AudatexInboundAttachmentDetail attachmentDetail)
        {
            int result = InsertAttachmentToTable(attachmentDetail);
            if (result != 0 && result != -101)
            {
                List<AudatexInboundAttachmentDetail> attachmentDetails = GetAttachmentFromTable(attachmentDetail.ClaimNumber, attachmentDetail.ReqId);
                image = CreateStringFromAttachment(attachmentDetails);
            }
            return result;
        }
       
        /// <summary>
        /// Inserts the intermediate attachments to table
        /// </summary>
        /// <param name="attachmentDetail"></param>
        /// <returns>Integer value</returns>
        private int InsertAttachmentToTable(AudatexInboundAttachmentDetail attachmentDetail)
        {

            DapperRepository dbody = new DapperRepository();
            Log.CreateLog("Insert Audatex Input Attachment Request into table", Level.Info);
            var response = dbody.ExecuteScalar(CommandType.StoredProcedure, @"AG_INSERT_AUDATEXINBOUNDREQUEST",
                 new
                 {
                     ClaimNumber = attachmentDetail.ClaimNumber,
                     ReqId = attachmentDetail.ReqId,
                     DocumentType = attachmentDetail.DocumentType,
                     DocumentFileName = attachmentDetail.DocumentFileName,
                     DocumentFileType = attachmentDetail.DocumentFileType,
                     DocumentContent = attachmentDetail.DocumentContent,
                     TotalDocs = attachmentDetail.TotalDocs,
                     CurrentDoc = attachmentDetail.CurrentDoc,
                     FilenoteCreated = attachmentDetail.FilenoteCreated,
                 });
            if (Convert.ToInt16(response) != -101)
            {
                Log.CreateLog($"Record saved to database, for claim number { attachmentDetail.ClaimNumber } and for { attachmentDetail.DocumentType} with Request ID { attachmentDetail.ReqId}: ", Level.Info);
            }
            else
            {
                Log.CreateLog($"Error Occured Record Not Saved, for claim number { attachmentDetail.ClaimNumber } and for { attachmentDetail.DocumentType} with Request ID { attachmentDetail.ReqId}: ", Level.Info);
            }
            return Convert.ToInt16(response);
        }
        /// <summary>
        /// Gets all the attchments from the table for which FileNote will be created
        /// </summary>
        /// <param name="estimateReturn"></param>
        /// <returns>List of AudatexInboundAttachmentDetail object</returns>
        private List<AudatexInboundAttachmentDetail> GetAttachmentFromTable(string claimNumber, string ReqId)
        {
            DapperRepository dapperRepo = new DapperRepository();
            string selectQuery = null;
            Log.CreateLog("Audatex: Getting Audatex Inbound Attachments based on ReqID", Level.Info);
            selectQuery = "AG_SELECT_AUDATEXINBOUNDREQUESTBYREQUESTID";
            try
            {
                return dapperRepo.GetItems<AudatexInboundAttachmentDetail>(CommandType.StoredProcedure, selectQuery, new
                {
                    ClaimNumber = claimNumber,
                    ReqId = ReqId
                }) as List<AudatexInboundAttachmentDetail>;
            }
            finally
            {
                dapperRepo = null;
                selectQuery = null;
            }
        }
        /// <summary>
        /// Creates one base 64 encoded string for all attachments 
        /// </summary>
        /// <param name="attachmentDetail"></param>
        /// <returns>base 64 encoded string </returns>
        private string CreateStringFromAttachment(List<AudatexInboundAttachmentDetail> attachmentDetail)
        {
            MemoryStream pdfStream = null;
            PdfDocument inboundPdf = null;
            byte[] combinedContents = null;
            PdfDocument combinedOutput = new PdfDocument();
            if (attachmentDetail.Count > 0)
            {
                foreach (AudatexInboundAttachmentDetail attachment in attachmentDetail)
                {
                    if (attachment.DocumentFileType.ToLower().Contains("pdf"))
                    {
                        pdfStream = new MemoryStream(attachment.DocumentContent);
                        inboundPdf = PdfReader.Open(pdfStream, PdfDocumentOpenMode.Import);
                        int pdfPageCount = inboundPdf.PageCount;
                        for (int i = 0; i < pdfPageCount; i++)
                        {
                            PdfPage page = inboundPdf.Pages[i];
                            page = combinedOutput.AddPage(page);
                        }
                    }
                    else if (attachment.DocumentFileType.ToLower().Contains("jpeg") || attachment.DocumentFileType.ToLower().Contains("jpg") || attachment.DocumentFileType.ToLower().Contains("gif") || attachment.DocumentFileType.ToLower().Contains("tiff")
                        || attachment.DocumentFileType.ToLower().Contains("png") || attachment.DocumentFileType.ToLower().Contains("bmp"))
                    {
                        PdfPage page = new PdfPage();
                        byte[] imageBytes = attachment.DocumentContent;
                        TypeConverter tc = TypeDescriptor.GetConverter(typeof(System.Drawing.Bitmap));
                        Bitmap img = (Bitmap)tc.ConvertFrom(imageBytes);
                        XImage ximg = XImage.FromGdiPlusImage(img);
                        combinedOutput.Pages.Add(page);
                        XGraphics xg = XGraphics.FromPdfPage(page);
                        xg.DrawImage(ximg, 0, 0, page.Width, page.Height);
                        ximg.Dispose();
                        xg.Dispose();
                    }
                }
                if (combinedOutput.PageCount > 0)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        combinedOutput.Save(stream, true);
                        combinedContents = stream.ToArray();
                    }
                }
            }
            if (combinedContents != null)
                return Convert.ToBase64String(combinedContents);
            else
                return string.Empty;
        }
        /// <summary>
        /// Converts the input object to xml string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CreateXML(Integration.Types.AssignmentAddRq audatexDetails)
        {
            XmlDocument xmlDoc = new XmlDocument();   //Represents an XML document, 
                                                      // Initializes a new instance of the XmlDocument class.          
            XmlSerializer xmlSerializer = new XmlSerializer(audatexDetails.GetType());
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "http://www.cieca.com/BMS");
            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, audatexDetails, ns);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.Load(xmlStream);
                Log.CreateLog($"Request Xml String :-   {xmlDoc.InnerXml}", Level.Info);
                return xmlDoc.InnerXml;
            }
        }
        /// <summary>
        /// Calls the claims wcf service to upload image data to filenote
        /// </summary>
        /// <param name="checkDetails"></param>
        /// <returns>string</returns>
        private string UploadInboundRequest(AG_AudatexInboundDTO audatexDetails)
        {
            AG_Audatex.AG_AudatexClient audatex = new AG_Audatex.AG_AudatexClient();
            return audatex.UploadAudatexResponse(audatexDetails);
        }
        #endregion
    }
}
