using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;

namespace ARC.Reports.Pages
{
    public partial class MarketShareTotals : System.Web.UI.Page
    {
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

            if (!Page.IsPostBack)
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
                dateEdit.Date = DateTime.Today;

                GetData();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxPageControl1_TabClick(object source, TabControlCancelEventArgs e)
        {
            try
            {
                if (Session["ActiveTabIndex"] != null)
                    ASPxPageControl1.ActiveTabIndex = (int)Session["ActiveTabIndex"];
                else
                    Session["ActiveTabIndex"] = ASPxPageControl1.ActiveTabIndex;
            }
            catch
            {
            }
        }

        protected void ASPxGridViews_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            GetData();
        }

        protected void dateEdit_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            //try
            //{
            ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
            ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

            if (myOption.SelectedIndex == 0)
            {
                ASPxGridView0.DataSource = SData.Rep_002Get(0, dateEdit.Date.ToShortDateString());
                ASPxGridView0.DataBind();

                ASPxGridView1.DataSource = SData.Rep_002Get(1, dateEdit.Date.ToShortDateString());
                ASPxGridView1.DataBind();
            }
            //else if (myOption.SelectedIndex == 1)
            //{
            var Lst = SData.Rep_003Get(2017, 0);

            //var xxxx = Lst=> xxxx.
            double? sum = Lst.Sum(x => x.MarketShare_12);

            if (sum == 0)
                //Lst.RemoveAt(Lst[0].MarketShare_12);
                ;
            //foreach (var x in Lst)
            //{
            //    var xx = x.MarketShare_1

            //        + x.MarketShare_2 + x.MarketShare_3 + x.MarketShare_4 + x.MarketShare_5 +
            //        x.MarketShare_6 + x.MarketShare_7 + x.MarketShare_8 + x.MarketShare_9 + x.MarketShare_10 + 
            //        x.MarketShare_11 + x.MarketShare_12;

            //    var xxx = x.MarketTrades_1 + x.MarketTrades_2 + x.MarketTrades_3 + x.MarketTrades_4 + x.MarketTrades_5 + 
            //        x.MarketTrades_6 + x.MarketTrades_7 + x.MarketTrades_8 + x.MarketTrades_9 + x.MarketTrades_10 +
            //        x.MarketTrades_11 + x.MarketTrades_12;

            //    if (xx == 0)
            //        Lst.RemoveAt(x);
            //}

            var xxxxx = SData.Rep_003Get(2017, 0);

            ASPxGridView6.DataSource = xxxxx;

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

            //ASPxGridView7.DataSource = SData.Rep_003Get(2017, 1);
            //ASPxGridView7.DataBind();
            //}
            //else if (myOption.SelectedIndex == 2)
            //{
            //ASPxGridView20.DataSource = SData.Rep_002Get(0, dateEdit.Date.ToShortDateString());
            //ASPxGridView20.DataBind();

            //ASPxGridView12.DataSource = SData.Rep_002Get(1, dateEdit.Date.ToShortDateString());
            //ASPxGridView12.DataBind();
            //}

            ASPxGridView2.DataSource = SData.Rep_0011aGet(0, dateEdit.Date.ToShortDateString());
            ASPxGridView2.DataBind();
            ASPxGridView4.DataSource = SData.Rep_0011bGet(0, dateEdit.Date.ToShortDateString());
            ASPxGridView4.DataBind();



            ASPxGridView3.DataSource = SData.Rep_0011aGet(1, dateEdit.Date.ToShortDateString());
            ASPxGridView3.DataBind();
            ASPxGridView5.DataSource = SData.Rep_0011bGet(1, dateEdit.Date.ToShortDateString());
            ASPxGridView5.DataBind();
            //}
            //catch
            //{
            //}
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        protected void myOption_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}