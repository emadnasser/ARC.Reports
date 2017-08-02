using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARC.Reports.Pages
{
    public partial class MarketShareTotals2 : System.Web.UI.Page
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
            if (!Page.IsPostBack)
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

                GetData(e.Tab.Index);
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

        private void GetData(int pIndex = 0)
        {
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
                ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;
                Label lblDate = ASPxPageControl1.FindControl("lblDate") as Label;
                
                if (myOption.SelectedIndex == 0)
                {
                    MarketShareTotal_0MD1.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_0MD1.MarketType = pIndex;

                    dateEdit.Visible = true;
                    lblDate.Visible = true;
                }
                else if (myOption.SelectedIndex == 1)
                {
                    MarketShareTotal_1MM.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_1MM.MarketType = pIndex;

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                }
                else if (myOption.SelectedIndex == 2)
                {
                    MarketShareTotal_2MQ.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_2MQ.MarketType = pIndex;

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                }
                else if (myOption.SelectedIndex == 3)
                {
                    MarketShareTotal_3MY.Date = dateEdit.Date.ToShortDateString();
                    MarketShareTotal_3MY.MarketType = pIndex;

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                }
            }
            catch
            {
            }
        }
    }
}