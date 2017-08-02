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

            //if (!Roles.GetRolesForUser(id).Contains("R_001"))
            //{
            //    if (!Roles.GetRolesForUser(id).Contains("Admins"))
            //    {
            //        Server.Transfer("~/Public/Unauthorized.aspx");
            //    }
            //}

            //if (!Page.IsPostBack)
            //{
            //    ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
            //    dateEdit.Date = DateTime.Today;
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
            //try
            //{
            ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

            List<Rep_0018> x1 = new List<Rep_0018>();
            List<Rep_0018> x2 = new List<Rep_0018>();
            List<Rep_0018> x3 = new List<Rep_0018>();

            List<Rep_0018> y1 = new List<Rep_0018>();
            List<Rep_0018> y2 = new List<Rep_0018>();
            List<Rep_0018> y3 = new List<Rep_0018>();

            if (myOption.SelectedIndex == 0)
            {
                x1 = SData.Rep_0011a_Graph_Get(0, 1);
                y1 = SData.Rep_0011a_Graph_Get(1, 1);

                //if (pIndex == 0)
                //{
                    WebChartControl2.Visible = false;
                    WebChartControl3.Visible = false;

                    WebChartControl1.Visible = true;
                //}
                //else if(pIndex == 1)
                //{
                    WebChartControl5.Visible = false;
                    WebChartControl6.Visible = false;

                    WebChartControl4.Visible = true;
                //}
            }
            else if (myOption.SelectedIndex == 1)
            {
                x2 = SData.Rep_0011a_Graph_Get(0, 2);
                y2 = SData.Rep_0011a_Graph_Get(1, 2);

                //if (pIndex == 0)
                //{
                    WebChartControl1.Visible = false;
                    WebChartControl3.Visible = false;

                    WebChartControl2.Visible = true;
                //}
                //else if (pIndex == 1)
                //{
                    WebChartControl4.Visible = false;
                    WebChartControl6.Visible = false;

                    WebChartControl5.Visible = true;
                //}
            }
            else if (myOption.SelectedIndex == 2)
            {
                x3 = SData.Rep_0011a_Graph_Get(0, 3);
                y3 = SData.Rep_0011a_Graph_Get(1, 3);

                //if (pIndex == 0)
                //{
                    WebChartControl1.Visible = false;
                    WebChartControl2.Visible = false;

                    WebChartControl3.Visible = true;
                //}
                //else if (pIndex == 1)
                //{
                    WebChartControl4.Visible = false;
                    WebChartControl5.Visible = false;

                    WebChartControl6.Visible = true;
                //}
            }

            WebChartControl1.DataSource = x1;
            WebChartControl2.DataSource = x2;
            WebChartControl3.DataSource = x3;
            WebChartControl1.DataBind();
            WebChartControl2.DataBind();
            WebChartControl3.DataBind();

            WebChartControl4.DataSource = y1;
            WebChartControl5.DataSource = y2;
            WebChartControl6.DataSource = y3;
            WebChartControl4.DataBind();
            WebChartControl5.DataBind();
            WebChartControl6.DataBind();

            //}
            //catch
            //{
            //}
        }


    }
}