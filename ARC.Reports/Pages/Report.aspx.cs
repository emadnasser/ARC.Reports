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

            ASPxGridView0.DataSource = SData.Rep_001Get(0);
            ASPxGridView0.DataBind();

            ASPxGridView1.DataSource = SData.Rep_001Get(1);
            ASPxGridView1.DataBind();

            ASPxGridView2.DataSource = SData.Rep_0011Get(0);
            ASPxGridView2.DataBind();

            ASPxGridView3.DataSource = SData.Rep_0011Get(1);
            ASPxGridView3.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxPageControl1_TabClick(object source, TabControlCancelEventArgs e)
        {
            if (Session["ActiveTabIndex"] != null)
                ASPxPageControl1.ActiveTabIndex = (int)Session["ActiveTabIndex"];
            else
                Session["ActiveTabIndex"] = ASPxPageControl1.ActiveTabIndex;
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            ASPxGridView0.DataBind();
            ASPxGridView1.DataBind();
            ASPxGridView2.DataBind();
            ASPxGridView3.DataBind();
        }
    }
}
