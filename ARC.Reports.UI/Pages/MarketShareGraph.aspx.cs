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

        protected void Type_ValueChanged(object sender, EventArgs e)
        {
            ASPxComboBox Type = ASPxPageControl1.FindControl("Type") as ASPxComboBox;
            ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

            if (Type.SelectedIndex == 2)
            {
                myOption.Items.RemoveAt(0);
                myOption.SelectedIndex = 0;
            }
            else
            {
                if(myOption.Items.Count == 3)
                    myOption.Items.Insert(0, new ListEditItem() { Index = 0, Text = "1 Day", Selected = true, Value = 0 });
            }
            GetData();
        }

        private void GetData()
        {
            try
            {
                ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;
                ASPxComboBox Type = ASPxPageControl1.FindControl("Type") as ASPxComboBox;

                if (myOption.SelectedIndex == 0)
                {
                    if (Type.SelectedIndex == 0)
                    {
                        MarketShareGraphs_H_0.MarketType = 0;
                        MarketShareGraphs_H_1.MarketType = 1;
                        MarketShareGraphs_H_0.Visible = true;
                        MarketShareGraphs_H_1.Visible = true;

                        MarketTradeGraphs_H_0.Visible = false;
                        MarketTradeGraphs_H_1.Visible = false;
                    }
                    else if (Type.SelectedIndex == 1)
                    {
                        MarketTradeGraphs_H_0.MarketType = 0;
                        MarketTradeGraphs_H_1.MarketType = 1;
                        MarketTradeGraphs_H_0.Visible = true;
                        MarketTradeGraphs_H_1.Visible = true;

                        MarketShareGraphs_H_0.Visible = false;
                        MarketShareGraphs_H_1.Visible = false;
                    }
                    else
                    {
                    }

                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;

                    MarketTradeGraphs_D_0.Visible = false;
                    MarketTradeGraphs_M_0.Visible = false;
                    MarketTradeGraphs_Y_0.Visible = false;
                    MarketTradeGraphs_D_1.Visible = false;
                    MarketTradeGraphs_M_1.Visible = false;
                    MarketTradeGraphs_Y_1.Visible = false;

                    MarketChannelsGraphs_D_0.Visible = false;
                    MarketChannelsGraphs_D_1.Visible = false;
                    MarketChannelsGraphs_M_0.Visible = false;
                    MarketChannelsGraphs_M_1.Visible = false;
                    MarketChannelsGraphs_Y_0.Visible = false;
                    MarketChannelsGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 1)
                {

                    if (Type.SelectedIndex == 0)
                    {
                        MarketShareGraphs_D_0.MarketType = 0;
                        MarketShareGraphs_D_1.MarketType = 1;
                        MarketShareGraphs_D_0.Visible = true;
                        MarketShareGraphs_D_1.Visible = true;

                        MarketTradeGraphs_D_0.Visible = false;
                        MarketTradeGraphs_D_1.Visible = false;
                    }
                    else if (Type.SelectedIndex == 1)
                    {
                        MarketTradeGraphs_D_0.MarketType = 0;
                        MarketTradeGraphs_D_1.MarketType = 1;
                        MarketTradeGraphs_D_0.Visible = true;
                        MarketTradeGraphs_D_1.Visible = true;

                        MarketShareGraphs_D_0.Visible = false;
                        MarketShareGraphs_D_1.Visible = false;
                    }
                    else
                    {
                        MarketChannelsGraphs_D_0.MarketType = 0;
                        MarketChannelsGraphs_D_1.MarketType = 1;
                        MarketChannelsGraphs_D_0.Visible = true;
                        MarketChannelsGraphs_D_1.Visible = true;

                        MarketShareGraphs_D_0.Visible = false;
                        MarketShareGraphs_D_1.Visible = false;
                        MarketTradeGraphs_D_0.Visible = false;
                        MarketTradeGraphs_D_1.Visible = false;
                    }

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;

                    MarketTradeGraphs_H_0.Visible = false;
                    MarketTradeGraphs_M_0.Visible = false;
                    MarketTradeGraphs_Y_0.Visible = false;
                    MarketTradeGraphs_H_1.Visible = false;
                    MarketTradeGraphs_M_1.Visible = false;
                    MarketTradeGraphs_Y_1.Visible = false;

                    MarketChannelsGraphs_M_0.Visible = false;
                    MarketChannelsGraphs_M_1.Visible = false;
                    MarketChannelsGraphs_Y_0.Visible = false;
                    MarketChannelsGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 2)
                {
                    if (Type.SelectedIndex == 0)
                    {
                        MarketShareGraphs_M_0.MarketType = 0;
                        MarketShareGraphs_M_1.MarketType = 1;
                        MarketShareGraphs_M_0.Visible = true;
                        MarketShareGraphs_M_1.Visible = true;

                        MarketTradeGraphs_M_0.Visible = false;
                        MarketTradeGraphs_M_1.Visible = false;
                    }
                    else if (Type.SelectedIndex == 1)
                    {
                        MarketTradeGraphs_M_0.MarketType = 0;
                        MarketTradeGraphs_M_1.MarketType = 1;
                        MarketTradeGraphs_M_0.Visible = true;
                        MarketTradeGraphs_M_1.Visible = true;

                        MarketShareGraphs_M_0.Visible = false;
                        MarketShareGraphs_M_1.Visible = false;
                    }
                    else
                    {
                        MarketChannelsGraphs_M_0.MarketType = 0;
                        MarketChannelsGraphs_M_1.MarketType = 1;
                        MarketChannelsGraphs_M_0.Visible = true;
                        MarketChannelsGraphs_M_1.Visible = true;

                        MarketShareGraphs_M_0.Visible = false;
                        MarketShareGraphs_M_1.Visible = false;
                        MarketTradeGraphs_M_0.Visible = false;
                        MarketTradeGraphs_M_1.Visible = false;
                    }

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_Y_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_Y_1.Visible = false;

                    MarketTradeGraphs_H_0.Visible = false;
                    MarketTradeGraphs_D_0.Visible = false;
                    MarketTradeGraphs_Y_0.Visible = false;
                    MarketTradeGraphs_H_1.Visible = false;
                    MarketTradeGraphs_D_1.Visible = false;
                    MarketTradeGraphs_Y_1.Visible = false;

                    MarketChannelsGraphs_D_0.Visible = false;
                    MarketChannelsGraphs_D_1.Visible = false;
                    MarketChannelsGraphs_Y_0.Visible = false;
                    MarketChannelsGraphs_Y_1.Visible = false;
                }
                else if (myOption.SelectedIndex == 3)
                {
                    if (Type.SelectedIndex == 0)
                    {
                        MarketShareGraphs_Y_0.MarketType = 0;
                        MarketShareGraphs_Y_1.MarketType = 1;
                        MarketShareGraphs_Y_0.Visible = true;
                        MarketShareGraphs_Y_1.Visible = true;

                        MarketTradeGraphs_Y_0.Visible = false;
                        MarketTradeGraphs_Y_1.Visible = false;
                    }
                    else if (Type.SelectedIndex == 1)
                    {
                        MarketTradeGraphs_Y_0.MarketType = 0;
                        MarketTradeGraphs_Y_1.MarketType = 1;
                        MarketTradeGraphs_Y_0.Visible = true;
                        MarketTradeGraphs_Y_1.Visible = true;

                        MarketShareGraphs_Y_0.Visible = false;
                        MarketShareGraphs_Y_1.Visible = false;
                    }
                    else
                    {
                        MarketChannelsGraphs_Y_0.MarketType = 0;
                        MarketChannelsGraphs_Y_1.MarketType = 1;
                        MarketChannelsGraphs_Y_0.Visible = true;
                        MarketChannelsGraphs_Y_1.Visible = true;

                        MarketShareGraphs_Y_0.Visible = false;
                        MarketShareGraphs_Y_1.Visible = false;
                        MarketTradeGraphs_Y_0.Visible = false;
                        MarketTradeGraphs_Y_1.Visible = false;
                    }

                    MarketShareGraphs_H_0.Visible = false;
                    MarketShareGraphs_D_0.Visible = false;
                    MarketShareGraphs_M_0.Visible = false;
                    MarketShareGraphs_H_1.Visible = false;
                    MarketShareGraphs_D_1.Visible = false;
                    MarketShareGraphs_M_1.Visible = false;

                    MarketTradeGraphs_H_0.Visible = false;
                    MarketTradeGraphs_D_0.Visible = false;
                    MarketTradeGraphs_M_0.Visible = false;
                    MarketTradeGraphs_H_1.Visible = false;
                    MarketTradeGraphs_D_1.Visible = false;
                    MarketTradeGraphs_M_1.Visible = false;

                    MarketChannelsGraphs_D_0.Visible = false;
                    MarketChannelsGraphs_D_1.Visible = false;
                    MarketChannelsGraphs_M_0.Visible = false;
                    MarketChannelsGraphs_M_1.Visible = false;
                }
            }
            catch
            {
            }
        }
    }
}