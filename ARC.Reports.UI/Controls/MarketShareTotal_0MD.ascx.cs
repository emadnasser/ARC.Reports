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
    public partial class MarketShareTotal_0MD : System.Web.UI.UserControl
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

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();

            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        private void GetData()
        {
            try
            {
                var lst_2 = new List<Rep_0011>();

                if (MarketType == 1)
                {
                    ASPxGridView0.DataSource = SData.Rep_002Get(0, Date);
                    lst_2 = SData.Rep_0011aGet(0, Date);
                    ASPxGridView2.DataSource = SData.Rep_0011bGet(0, Date);
                }
                else if (MarketType == 0)
                {
                    ASPxGridView0.DataSource = SData.Rep_002Get(1, Date);
                    lst_2 = SData.Rep_0011aGet(1, Date);
                    ASPxGridView2.DataSource = SData.Rep_0011bGet(1, Date);
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