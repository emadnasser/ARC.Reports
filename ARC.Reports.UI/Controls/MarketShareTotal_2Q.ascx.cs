using ARC.Reports.DAL;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Linq;
using System.Web.Security;

namespace ARC.Reports.Controls
{
    public partial class MarketShareTotal_2Q : System.Web.UI.UserControl
    {
        public string Date { get; set; }
        public int MarketType { get; set; }

        public void ON()
        {
            ASPxTimer.Enabled = true;
        }

        public void OFF()
        {
            ASPxTimer.Enabled = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            GetData();
        }

        protected void dateEdit_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();

            gridExport_2.FileName = "Market Share Totals Main - Quarterly";
            gridExport_2.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        protected void ASPxGridView6_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            var myData = SData.MarketShareAVG(DateTime.Now.Year, MarketType);

            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s1" && myData.Count > 0)
            {
                e.TotalValue = myData[0].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s2" && myData.Count > 1)
            {
                e.TotalValue = myData[1].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s3" && myData.Count > 2)
            {
                e.TotalValue = myData[2].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s4" && myData.Count > 3)
            {
                e.TotalValue = myData[3].MarketShare;
            }

            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t1" && myData.Count > 0)
            {
                e.TotalValue = myData[0].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t2" && myData.Count > 1)
            {
                e.TotalValue = myData[1].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t3" && myData.Count > 2)
            {
                e.TotalValue = myData[2].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t4" && myData.Count > 3)
            {
                e.TotalValue = myData[3].MarketTrades;
            }
        }

        private void GetData()
        {
            try
            {
                ASPxGridView6.Columns["_1"].Caption = "1st";
                ASPxGridView6.Columns["_2"].Caption = "2nd";
                ASPxGridView6.Columns["_3"].Caption = "3rd";
                ASPxGridView6.Columns["_4"].Caption = "4th";

                if (MarketType == 0)
                {
                    ASPxGridView6.DataSource = SData.MarketShareTotal_Q(DateTime.Now.Year, 0);
                }
                else if (MarketType == 1)
                {
                    ASPxGridView6.DataSource = SData.MarketShareTotal_Q(DateTime.Now.Year, 1);
                }

                ASPxGridView6.DataBind();

                if (ASPxGridView6.Columns.Count >= 12)
                {
                    var month = DateTime.Now.Month;

                    for (int i = month; i < 13; i++)
                    {
                        ASPxGridView6.Columns.RemoveAt(month);
                    }

                    if (month > 9)
                        ASPxGridView6.Settings.HorizontalScrollBarMode = ScrollBarMode.Visible;
                }
            }
            catch
            {
            }
        }
    }
}