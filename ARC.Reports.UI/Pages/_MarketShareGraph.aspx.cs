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
    public partial class _MarketShareGraph : System.Web.UI.Page
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
                    x0 = SData.MarketShareGraphs(0, 1);
                    y0 = SData.MarketShareGraphs(1, 1);

                    //if (pIndex == 0)
                    //{
                    WebChartControl1.Visible = false;
                    WebChartControl2.Visible = false;
                    WebChartControl3.Visible = false;

                    WebChartControl0.Visible = true;
                    //}
                    //else if(pIndex == 1)
                    //{
                    WebChartControl4.Visible = false;
                    WebChartControl5.Visible = false;
                    WebChartControl6.Visible = false;

                    WebChartControl8.Visible = true;
                    //}
                }
                else if (myOption.SelectedIndex == 1)
                {
                    x1 = SData.MarketShareGraphs(0, 2);
                    y1 = SData.MarketShareGraphs(1, 2);

                    //if (pIndex == 0)
                    //{
                    WebChartControl0.Visible = false;
                    WebChartControl2.Visible = false;
                    WebChartControl3.Visible = false;

                    WebChartControl1.Visible = true;
                    //}
                    //else if(pIndex == 1)
                    //{
                    WebChartControl8.Visible = false;
                    WebChartControl5.Visible = false;
                    WebChartControl6.Visible = false;

                    WebChartControl4.Visible = true;
                    //}
                }
                else if (myOption.SelectedIndex == 2)
                {
                    x2 = SData.MarketShareGraphs(0, 3);
                    y2 = SData.MarketShareGraphs(1, 3);

                    //if (pIndex == 0)
                    //{
                    WebChartControl1.Visible = false;
                    WebChartControl3.Visible = false;
                    WebChartControl0.Visible = false;

                    WebChartControl2.Visible = true;
                    //}
                    //else if (pIndex == 1)
                    //{
                    WebChartControl4.Visible = false;
                    WebChartControl6.Visible = false;
                    WebChartControl8.Visible = false;

                    WebChartControl5.Visible = true;
                    //}
                }
                else if (myOption.SelectedIndex == 3)
                {
                    x3 = SData.MarketShareGraphs(0, 4);
                    y3 = SData.MarketShareGraphs(1, 4);

                    //if (pIndex == 0)
                    //{
                    WebChartControl1.Visible = false;
                    WebChartControl2.Visible = false;
                    WebChartControl0.Visible = false;

                    WebChartControl3.Visible = true;
                    //}
                    //else if (pIndex == 1)
                    //{
                    WebChartControl4.Visible = false;
                    WebChartControl5.Visible = false;
                    WebChartControl8.Visible = false;

                    WebChartControl6.Visible = true;
                    //}
                }

                WebChartControl0.DataSource = x0;
                WebChartControl1.DataSource = x1;
                WebChartControl2.DataSource = x2;
                WebChartControl3.DataSource = x3;
                WebChartControl1.DataBind();
                WebChartControl2.DataBind();
                WebChartControl3.DataBind();
                WebChartControl0.DataBind();

                WebChartControl8.DataSource = y0;
                WebChartControl4.DataSource = y1;
                WebChartControl5.DataSource = y2;
                WebChartControl6.DataSource = y3;
                WebChartControl4.DataBind();
                WebChartControl5.DataBind();
                WebChartControl6.DataBind();
                WebChartControl8.DataBind();

            }
            catch
            {
            }
        }

        protected void WebChartControl0_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e)
        {
            GetData();
        }
    }
}