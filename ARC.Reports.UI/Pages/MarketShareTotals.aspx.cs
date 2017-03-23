using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;

namespace ARC.Reports.Pages
{
    public partial class MarketShareTotals : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            string id = Request.LogonUserIdentity.Name.Trim();

            if (!Roles.GetRolesForUser(id).Contains("R_001"))
            {
                if (!Roles.GetRolesForUser(id).Contains("Admins"))
                {
                    Server.Transfer("~/Public/Unauthorized.aspx");
                }
            }

            if (!Page.IsPostBack)
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
                dateEdit.Date = DateTime.Today;

                GetData();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxPageControl1_TabClick(object source, TabControlCancelEventArgs e)
        {
            try
            {
                if (Session["ActiveTabIndex"] != null)
                    ASPxPageControl1.ActiveTabIndex = (int)Session["ActiveTabIndex"];
                else
                    Session["ActiveTabIndex"] = ASPxPageControl1.ActiveTabIndex;
            }
            catch
            {
            }
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            GetData();
        }

        protected void dateEdit_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;

                ASPxGridView0.DataSource = SData.Rep_002Get(0, dateEdit.Date.ToShortDateString());
                ASPxGridView0.DataBind();
                ASPxGridView2.DataSource = SData.Rep_0011aGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView2.DataBind();
                ASPxGridView4.DataSource = SData.Rep_0011bGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView4.DataBind();


                ASPxGridView1.DataSource = SData.Rep_002Get(1, dateEdit.Date.ToShortDateString());
                ASPxGridView1.DataBind();
                ASPxGridView3.DataSource = SData.Rep_0011aGet(1, dateEdit.Date.ToShortDateString());
                ASPxGridView3.DataBind();
                ASPxGridView5.DataSource = SData.Rep_0011bGet(1, dateEdit.Date.ToShortDateString());
                ASPxGridView5.DataBind();
            }
            catch
            {
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }
    }
}