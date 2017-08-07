using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            GetData();
        }

        protected void ASPxPageControl1_TabClick(object source, TabControlCancelEventArgs e)
        {
            try
            {
                //if (Session["ActiveTabIndex"] != null)
                //    ASPxPageControl1.ActiveTabIndex = (int)Session["ActiveTabIndex"];
                //else
                //    Session["ActiveTabIndex"] = ASPxPageControl1.ActiveTabIndex;

                GetData();
            }
            catch
            {
            }
        }

        protected void dateEdit_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        protected void myOption_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
                ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;
                Label lblDate = ASPxPageControl1.FindControl("lblDate") as Label;

                if (myOption.SelectedIndex == 0)
                {
                    MarketShareTotal_0D.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_0D1.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_0D.MarketType = 0;
                    MarketShareTotal_0D1.MarketType = 1;
                    MarketShareTotal_0D.Visible = true;
                    MarketShareTotal_0D1.Visible = true;

                    dateEdit.Visible = true;
                    lblDate.Visible = true;
                    MarketShareTotal_1M.Visible = false;
                    MarketShareTotal_1M1.Visible = false;
                    MarketShareTotal_2Q.Visible = false;
                    MarketShareTotal_2Q1.Visible = false;
                    MarketShareTotal_3Y.Visible = false;
                    MarketShareTotal_3Y1.Visible = false;
                }
                else if (myOption.SelectedIndex == 1)
                {
                    MarketShareTotal_1M.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_1M1.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_1M.MarketType = 0;
                    MarketShareTotal_1M1.MarketType = 1;

                    MarketShareTotal_1M.Visible = true;
                    MarketShareTotal_1M1.Visible = true;
                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    MarketShareTotal_0D.Visible = false;
                    MarketShareTotal_0D1.Visible = false;
                    MarketShareTotal_2Q.Visible = false;
                    MarketShareTotal_2Q1.Visible = false;
                    MarketShareTotal_3Y.Visible = false;
                    MarketShareTotal_3Y1.Visible = false;
                }
                else if (myOption.SelectedIndex == 2)
                {
                    MarketShareTotal_2Q.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_2Q1.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_2Q.MarketType = 0;
                    MarketShareTotal_2Q1.MarketType = 1;
                    MarketShareTotal_2Q.Visible = true;
                    MarketShareTotal_2Q1.Visible = true;

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    MarketShareTotal_0D.Visible = false;
                    MarketShareTotal_0D1.Visible = false;
                    MarketShareTotal_1M.Visible = false;
                    MarketShareTotal_1M1.Visible = false;
                    MarketShareTotal_3Y.Visible = false;
                    MarketShareTotal_3Y1.Visible = false;
                }
                else if (myOption.SelectedIndex == 3)
                {
                    MarketShareTotal_3Y.Visible = true;
                    MarketShareTotal_3Y1.Visible = true;
                    MarketShareTotal_3Y.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_3Y1.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_3Y.MarketType = 0;
                    MarketShareTotal_3Y1.MarketType = 1;

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    MarketShareTotal_0D.Visible = false;
                    MarketShareTotal_0D1.Visible = false;
                    MarketShareTotal_1M.Visible = false;
                    MarketShareTotal_1M1.Visible = false;
                    MarketShareTotal_2Q.Visible = false;
                    MarketShareTotal_2Q1.Visible = false;
                }
            }
            catch
            {
            }
        }
    }
}