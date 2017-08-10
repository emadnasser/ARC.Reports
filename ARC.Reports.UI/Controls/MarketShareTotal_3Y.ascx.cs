using ARC.Reports.DAL;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Linq;
using System.Web.Security;

namespace ARC.Reports.Controls
{
    public partial class MarketShareTotal_3Y : System.Web.UI.UserControl
    {
        public string Date { get; set; }
        public int MarketType { get; set; }

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

            gridExport_4.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        private void GetData()
        {
            try
            {
                ASPxGridView8.Columns["_1"].Caption = (DateTime.Now.Year - 3).ToString();
                ASPxGridView8.Columns["_2"].Caption = (DateTime.Now.Year - 2).ToString();
                ASPxGridView8.Columns["_3"].Caption = (DateTime.Now.Year - 1).ToString();

                if (MarketType == 0)
                {
                    ASPxGridView8.DataSource = SData.MarketShareTotal_Y(0);
                }
                else if (MarketType == 1)
                {
                    ASPxGridView8.DataSource = SData.MarketShareTotal_Y(1);
                }

                ASPxGridView8.DataBind();
            }
            catch
            {
            }
        }
    }
}