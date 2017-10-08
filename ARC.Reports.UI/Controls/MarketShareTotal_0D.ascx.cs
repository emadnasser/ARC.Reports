using ARC.Reports.DAL;
using ARC.Reports.DAL.Entities;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Security;

namespace ARC.Reports.Controls
{
    public partial class MarketShareTotal_0D : System.Web.UI.UserControl
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

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();

            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        private void GetData()
        {
            try
            {
                var lst_2 = new List<MarketShareTotal_D_Totals>();

                if (MarketType == 0)
                {
                    ASPxGridView0.DataSource = SData.MarketShareTotal_D(0, Date);
                    lst_2 = SData.MarketShareTotal_D_Totals(0, 0, Date);
                    ASPxGridView2.DataSource = SData.MarketShareTotal_D_Totals(0, 1, Date);
                }
                else if (MarketType == 1)
                {
                    ASPxGridView0.DataSource = SData.MarketShareTotal_D(1, Date);
                    lst_2 = SData.MarketShareTotal_D_Totals(1, 0, Date);
                    ASPxGridView2.DataSource = SData.MarketShareTotal_D_Totals(1, 1, Date);
                }

                if (Convert.ToDouble(lst_2[0].DiffDayPer) >= 0)
                    ASPxGridView1.Columns[4].CellStyle.ForeColor = Color.Green;
                else if (Convert.ToDouble(lst_2[0].DiffDayPer) < 0)
                    ASPxGridView1.Columns[4].CellStyle.ForeColor = Color.Red;

                ASPxGridView1.DataSource = lst_2;

                ASPxGridView0.DataBind();
                ASPxGridView1.DataBind();
                ASPxGridView2.DataBind();
            }
            catch
            {
            }
        }
    }
}