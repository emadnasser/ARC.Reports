using ARC.Reports.Classes.Enums;
using ARC.Reports.DataModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARC.Reports.Pages
{
    public partial class SummaryCommission : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            IsAutorized();

            //string id = Request.LogonUserIdentity.Name.Trim();

            //if (!Roles.GetRolesForUser(id).Contains("SummaryCommission"))
            //{
            //    if (!Roles.GetRolesForUser(id).Contains("Admins"))
            //    {
            //        Server.Transfer("~/Public/Unauthorized.aspx");
            //    }
            //}
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
            //var report = new Reports.SummaryCommission();
            //report.RequestParameters = false;
            //report.AfterPrint += report_AfterPrint;
            //report.CreateDocument(true);
            //ASPxDocumentViewer.Report = report;
        }

        private void IsAutorized()
        {
            var myUser = DataAccess.GetUser(User.Identity.Name);

            if (myUser != null)
            {
                if (!myUser.Roles.Any(x => x.RoleName == RoleType.SummaryCommission.ToString()))
                {
                    if (!myUser.Roles.Any(x => x.RoleName == RoleType.ReportsAdmins.ToString()))
                    {
                        Server.Transfer("~/Public/Unauthorized.aspx");
                    }
                }
            }
            else
            {
                Server.Transfer("~/Public/Unauthorized.aspx");
            }
        }
    }
}