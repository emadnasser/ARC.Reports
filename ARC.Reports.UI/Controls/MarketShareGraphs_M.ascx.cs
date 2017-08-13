using ARC.Reports.DAL;
using ARC.Reports.DAL.Entities;
using DevExpress.Web;
using System;
using System.Collections.Generic;

namespace ARC.Reports.Controls
{
    public partial class MarketShareGraphs_M : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Page.IsPostBack)
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
                List<MarketShareGraphs> x = new List<MarketShareGraphs>();

                x = SData.MarketShareGraphs(0, 3);

                WebChartControl2.DataSource = x;
                WebChartControl2.DataBind();
            }
            catch
            {
            }
        }
    }
}