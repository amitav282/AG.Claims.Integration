using AFS.AEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFS.Arch;
using AFS.Claims.Desktop.BusinessComps;
using AFS.Claims.Desktop.Types;
using AFS.Claims.FNOL.Types.FNOL;
using AFS.Party.BusinessComps;
using AFS.Party.Types;
using AFS.Claims.Desktop.Types.Participant;
using System.Net;
using System.IO;


namespace AG.Claims.Common
{
    class ActivityATP : ILogicActivity
    {

        // This activity is created to track Claim File Type change date in Claim Folder

        public void Execute(Dictionary<string, object> activityInputs, int localeId, DateTime effectiveDate)
        {
            try
            {

                if (AFS.Arch.AEF.Context.IsInContext("ScheduledSupplierAppointmentsDTO"))
                {
                    System.Uri uri = new System.Uri("http://localhost/RestService/EmployeeService.svc/");
                    //ServiceConsumer serviceConsumer = new ServiceConsumer();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
       

    }


}
