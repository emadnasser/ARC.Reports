using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Drawing;
using System.Collections.Generic;
using ARC.Reports.DataModel;
using ARC.Reports.Classes.Enums;

namespace ARC.Reports.Pages
{
    public partial class BrokerageMetrics : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            IsAutorized();

            //string id = Request.LogonUserIdentity.Name.Trim();

            //if (!Roles.GetRolesForUser(id).Contains("BrokerageMetrics"))
            //{
            //    if (!Roles.GetRolesForUser(id).Contains("Admins"))
            //    {
            //        Server.Transfer("~/Public/Unauthorized.aspx");
            //    }
            //}
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ASPxGridView0.DataSource = SData.BrokerageMetricsYearly();
                ASPxGridView0.DataBind();

                ASPxGridView1.DataSource = SData.BrokerageMetricsMonthly();
                ASPxGridView1.DataBind();
            }
            catch
            {
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            ASPxGridView0.Columns.RemoveAt(0);
            ASPxGridView0.Columns[0].Visible = true;

            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            GetData();

            gridExport_1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        private void IsAutorized()
        {
            var myUser = DataAccess.GetUser(User.Identity.Name);

            if (myUser != null)
            {
                if (!myUser.Roles.Any(x => x.RoleName == RoleType.BrokerageMetrics.ToString()))
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