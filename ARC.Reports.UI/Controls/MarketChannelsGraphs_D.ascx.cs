﻿using ARC.Reports.DAL;
using ARC.Reports.DAL.Entities;
using DevExpress.Web;
using System;
using System.Collections.Generic;

namespace ARC.Reports.Controls
{
    public partial class MarketChannelsGraphs_D : System.Web.UI.UserControl
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
                    x = SData.MarketShareGraphsChannels_D_MT(0);
                    y = SData.MarketShareGraphsChannels_D_MS(0);
                }
                else
                {
                    x = SData.MarketShareGraphsChannels_D_MT(1);
                    y = SData.MarketShareGraphsChannels_D_MS(1);
                }

                WebChartControl.DataSource = x;
                WebChartControl.DataBind();

                WebChartControl1.DataSource = y;
                WebChartControl1.DataBind();
            }
            catch
            {
            }
        }
    }
}