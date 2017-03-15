using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;

namespace ARC.Reports
{
    public partial class Report : System.Web.UI.Page
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
                ASPxGridView0.DataSource = SData.Rep_001Get(0, dateEdit.Date.ToShortDateString());
                ASPxGridView0.DataBind();

                ASPxGridView1.DataSource = SData.Rep_001Get(1, dateEdit.Date.ToShortDateString());
                ASPxGridView1.DataBind();

                ASPxGridView2.DataSource = SData.Rep_0011Get(0, dateEdit.Date.ToShortDateString());
                ASPxGridView2.DataBind();

                ASPxGridView3.DataSource = SData.Rep_0011Get(1, dateEdit.Date.ToShortDateString());
                ASPxGridView3.DataBind();
            }
            catch
            {
            }
        }
    }
}
