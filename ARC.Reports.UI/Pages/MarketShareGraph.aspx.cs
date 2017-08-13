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
using ARC.Reports.DAL.Entities;

namespace ARC.Reports.Pages
{
    public partial class MarketShareGraph : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            string id = Request.LogonUserIdentity.Name.Trim();

            if (!Roles.GetRolesForUser(id).Contains("Graphs"))
            {
                if (!Roles.GetRolesForUser(id).Contains("Admins"))
                {
                    Server.Transfer("~/Public/Unauthorized.aspx");
                }
            }

            //if (!Page.IsPostBack)
            //{
            //}
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Page.IsPostBack)
            GetData();
        }

        protected void ASPxPageControl1_TabClick(object source, TabControlCancelEventArgs e)
        {
            try
            {
                //if (Session["ActiveTabIndex"] != null)
                //    e.Tab.Index = (int)Session["ActiveTabIndex"];
                //else
                //    Session["ActiveTabIndex"] = e.Tab.Index;

                //GetData(e.Tab.Index);
            }
            catch
            {
            }
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
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
                ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

                List<MarketShareGraphs> x0 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> x1 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> x2 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> x3 = new List<MarketShareGraphs>();

                List<MarketShareGraphs> y0 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> y1 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> y2 = new List<MarketShareGraphs>();
                List<MarketShareGraphs> y3 = new List<MarketShareGraphs>();

                if (myOption.SelectedIndex == 0)
                {
                    MarketShareGraphs_H_0.MarketType = 0;
                    MarketShareGraphs_H_1.MarketType = 1;
                    MarketShareGraphs_H_0.Visible = true;
                    MarketShareGraphs_H_1.Visible = true;

                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 1)
                {
                    MarketShareGraphs_D_0.MarketType = 0;
                    MarketShareGraphs_D_1.MarketType = 1;
                    MarketShareGraphs_D_0.Visible = true;
                    MarketShareGraphs_D_1.Visible = true;

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 2)
                {
                    MarketShareGraphs_M_0.MarketType = 0;
                    MarketShareGraphs_M_1.MarketType = 1;
                    MarketShareGraphs_M_0.Visible = true;
                    MarketShareGraphs_M_1.Visible = true;

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 3)
                {
                    MarketShareGraphs_Y_0.MarketType = 0;
                    MarketShareGraphs_Y_1.MarketType = 1;
                    MarketShareGraphs_Y_0.Visible = true;
                    MarketShareGraphs_Y_1.Visible = true;

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;
                }
            }
            catch
            {
            }
        }
    }
}