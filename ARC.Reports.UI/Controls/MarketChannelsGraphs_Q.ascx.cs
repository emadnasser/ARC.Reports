using ARC.Reports.DAL;
using ARC.Reports.DAL.Entities;
using DevExpress.Web;
using System;
using System.Collections.Generic;

namespace ARC.Reports.Controls
{
    public partial class MarketChannelsGraphs_Q : System.Web.UI.UserControl
    {
        public int MarketType { get; set; }

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
                List<MarketShareGraphs> y = new List<MarketShareGraphs>();

                if (MarketType == 0)
                {
                    x = SData.MarketShareGraphsChannelsMarketShare(0, 2);
                    y = SData.MarketShareGraphsChannelsTradeShare(0, 2);
                }
                else
                {
                    x = SData.MarketShareGraphsChannelsMarketShare(1, 2);
                    y = SData.MarketShareGraphsChannelsTradeShare(1, 2);
                }

                WebChartControl_0.DataSource = x;
                WebChartControl_1.DataSource = y;

                WebChartControl_0.DataBind();
                WebChartControl_1.DataBind();
            }
            catch
            {
            }
        }
    }
}