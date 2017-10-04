﻿using ARC.Reports.DAL;
using ARC.Reports.DAL.Entities;
using DevExpress.Web;
using System;
using System.Collections.Generic;


namespace ARC.Reports.Controls
{
    public partial class MarketShareGraphs_H : System.Web.UI.UserControl
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

                if (MarketType == 0)
                {
                    x = SData.MarketShareGraphs(0, 1);
                }
                else
                {
                    x = SData.MarketShareGraphs(1, 1);
                }

                WebChartControl0.DataSource = x;
                WebChartControl0.DataBind();
            }
            catch
            {
            }
        }
    }
}