using System;
using System.Configuration;
using AG.Claims.Integration.Types;
using AG.Claims.Common;

namespace AG.Claims.IVAuto
{
    public class IVAUTO
    {
        /// <summary>
        /// Initiates the call to IVAUTO
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns>IVAutoResponse class as an object</returns>
        public IVAutoResponse AssignmentIVAuto(AssignmentIVAuto inputAssignment)
        {
            IVAutoResponse response = new IVAutoResponse();
            DataServiceClient client = new DataServiceClient();
            client.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["IVAutoUserName"].ToString();
            client.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["IVAutoPassword"].ToString();
            PG_AssignmentInfo assign = new PG_AssignmentInfo();
            if (inputAssignment != null)
            {
                assign.ClaimNumber = inputAssignment.ClaimNumber;
                if (inputAssignment.CoverageType == "Comprehensive")
                    assign.CoverageType = PG_Enums_CoverageTypes.Comp;
                else if (inputAssignment.CoverageType == "Collision")
                    assign.CoverageType = PG_Enums_CoverageTypes.Collision;
                else
                    assign.CoverageType = PG_Enums_CoverageTypes.Other;
                assign.InsuranceAdjuster = inputAssignment.InsuranceAdjuster;
                assign.InsuranceOffice = inputAssignment.InsuranceOffice;
                if (inputAssignment.CauseOfLoss == "Comprehensive")
                {
                    assign.LossCause = PG_Enums_LossCauseTypes.Other;
                }
                else if (inputAssignment.CauseOfLoss == "Collision")
                {
                    assign.LossCause = PG_Enums_LossCauseTypes.Collision;
                }
                else if (inputAssignment.CauseOfLoss == "Theft")
                {
                    assign.LossCause = PG_Enums_LossCauseTypes.Theft_Repo;
                }
                else
                {
                    assign.LossCause = PG_Enums_LossCauseTypes.Other;
                }
                if (!string.IsNullOrEmpty(inputAssignment.DateOfLoss))
                    assign.LossDate = DateTime.Parse(inputAssignment.DateOfLoss);
                else assign.LossDate = DateTime.MinValue;
                assign.OwnerDetails = new PG_OwnerInfo();
                assign.OwnerDetails.AddressLine1 = inputAssignment.InsuredAddress1;
                assign.OwnerDetails.AddressLine2 = inputAssignment.InsuredAddress2;
                assign.OwnerDetails.City = inputAssignment.InsuredCity;
                assign.OwnerDetails.EmailId = inputAssignment.InsuredEmail;
                assign.OwnerDetails.FirstName = inputAssignment.InsuredFirstName;
                assign.OwnerDetails.HomePhone = !string.IsNullOrEmpty(inputAssignment.InsuredHomePhone) ? string.Format("{0:(###) ###-####}", long.Parse(inputAssignment.InsuredHomePhone)) : "(000) 000-0000";
                assign.OwnerDetails.LastName = inputAssignment.InsuredLastName;
                assign.OwnerDetails.MobileNo = !string.IsNullOrEmpty(inputAssignment.InsuredMobileNumber) ? string.Format("{0:(###) ###-####}", long.Parse(inputAssignment.InsuredMobileNumber)) : "(000) 000-0000";
                assign.OwnerDetails.State = inputAssignment.InsuredState;
                assign.OwnerDetails.WorkPhone = !string.IsNullOrEmpty(inputAssignment.InsuredWorkPhone) ? string.Format("{0:(###) ###-####}", long.Parse(inputAssignment.InsuredWorkPhone)) : "(000) 000-0000";
                if (!string.IsNullOrEmpty(inputAssignment.InsuredZip))
                    assign.OwnerDetails.ZipCode = Convert.ToInt32(inputAssignment.InsuredZip.Split('-')[0].Trim());
                else
                    assign.OwnerDetails.ZipCode = 0;
                assign.PickupLocationDetails = new PG_LocationInfo();
                assign.PickupLocationDetails.AddressLine1 = inputAssignment.PickUpLocationAddress1;
                assign.PickupLocationDetails.AddressLine2 = inputAssignment.PickUpLocationAddress2;
                assign.PickupLocationDetails.City = inputAssignment.PickUpLocationCity;
                assign.PickupLocationDetails.ContactPerson = inputAssignment.PickUpLocationContactPerson;
                assign.PickupLocationDetails.LocationName = inputAssignment.PickUpLocationName;
                assign.PickupLocationDetails.PhoneNo = !string.IsNullOrEmpty(inputAssignment.PickUpLocationPhone) ? string.Format("{0:(###) ###-####}", long.Parse(inputAssignment.PickUpLocationPhone)) : "(000) 000-0000";
                assign.PickupLocationDetails.State = inputAssignment.PickUpLocationState;
                if (!string.IsNullOrEmpty(inputAssignment.PickUpLocationZip))
                    assign.PickupLocationDetails.ZipCode = Convert.ToInt32(inputAssignment.PickUpLocationZip.Split('-')[0].Trim());
                else
                    assign.PickupLocationDetails.ZipCode = 0;
                assign.VehicleDetails = new PG_VehicleInfo();
                assign.VehicleDetails.VIN = inputAssignment.Vin;
                assign.VehicleDetails.Make = inputAssignment.Make;
                assign.VehicleDetails.Model = inputAssignment.Model;
                assign.VehicleDetails.Year = Convert.ToInt32(inputAssignment.Year);
            }
            PG_ResponseData res = client.SaveAssignment(assign);
            string deserialzedObject = Newtonsoft.Json.JsonConvert.SerializeObject(res);
            Log.CreateLog($"Received IVAuto Response string is :-  {deserialzedObject}", Level.Info);
            if (res.ErrorCode == 0)
            {
                response.Message = "Appointment is scheduled";
                response.StockNumber = Convert.ToString(res.Result.Assignment.StockNo);
                response.Status = "Success";
            }
            else
            {
                response.Message = res.ErrorMessage;
                response.StockNumber = Convert.ToString(res.ErrorCode);
                response.Status = "Failure";
            }
            return response;
        }
    }
}
