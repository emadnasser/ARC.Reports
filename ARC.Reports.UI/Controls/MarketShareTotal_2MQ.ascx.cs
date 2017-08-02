using ARC.Reports.DAL;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Linq;
using System.Web.Security;

namespace ARC.Reports.Controls
{
    public partial class MarketShareTotal_2MQ : System.Web.UI.UserControl
    {
        public string Date { get; set; }
        public int MarketType { get; set; }

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
            var myData = SData.Rep_007Get(DateTime.Now.Year, 0);

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
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s5" && myData.Count > 4)
            {
                e.TotalValue = myData[4].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s6" && myData.Count > 5)
            {
                e.TotalValue = myData[5].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s7" && myData.Count > 6)
            {
                e.TotalValue = myData[6].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s8" && myData.Count > 7)
            {
                e.TotalValue = myData[7].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s9" && myData.Count > 8)
            {
                e.TotalValue = myData[8].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s10" && myData.Count > 9)
            {
                e.TotalValue = myData[9].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s11" && myData.Count > 10)
            {
                e.TotalValue = myData[10].MarketShare;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s12" && myData.Count > 11)
            {
                e.TotalValue = myData[11].MarketShare;
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
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t5" && myData.Count > 4)
            {
                e.TotalValue = myData[4].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t6" && myData.Count > 5)
            {
                e.TotalValue = myData[5].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t7" && myData.Count > 6)
            {
                e.TotalValue = myData[6].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t8" && myData.Count > 7)
            {
                e.TotalValue = myData[7].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t9" && myData.Count > 8)
            {
                e.TotalValue = myData[8].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t10" && myData.Count > 9)
            {
                e.TotalValue = myData[9].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t11" && myData.Count > 10)
            {
                e.TotalValue = myData[10].MarketTrades;
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t12" && myData.Count > 11)
            {
                e.TotalValue = myData[11].MarketTrades;
            }

            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s13")
            {
                e.TotalValue = myData[myData.Count - 1].MarketShare;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketShare_13";
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t13")
            {
                e.TotalValue = myData[myData.Count - 1].MarketTrades;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketTrades_13";
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
                    ASPxGridView6.DataSource = SData.Rep_005Get(DateTime.Now.Year, 0);
                }
                else if (MarketType == 1)
                {
                    ASPxGridView6.DataSource = SData.Rep_005Get(DateTime.Now.Year, 1);
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