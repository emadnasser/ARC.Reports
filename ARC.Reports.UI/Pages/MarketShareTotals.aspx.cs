using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;
using System.Web.UI.WebControls;
using System.Web.UI;

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

                //ASPxComboBox ASPxComboBoxYears = ASPxPageControl1.FindControl("ASPxComboBoxYears") as ASPxComboBox;
                //ASPxComboBoxYears.Items.Add("", 0);
                //ASPxComboBoxYears.Items.Add("", 0);
                //ASPxComboBoxYears.Items.Add("", 0);
                //ASPxComboBoxYears.Items.Add("", 0);

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
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;
                ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;
                Label lblDate = ASPxPageControl1.FindControl("lblDate") as Label;

                if (myOption.SelectedIndex == 0)
                {
                    ASPxGridView0.DataSource = SData.Rep_002Get(0, dateEdit.Date.ToShortDateString());
                    ASPxGridView0.DataBind();

                    ASPxGridView1.DataSource = SData.Rep_002Get(1, dateEdit.Date.ToShortDateString());
                    ASPxGridView1.DataBind();

                    dateEdit.Visible = true;
                    lblDate.Visible = true;
                    ASPxGridView0.Visible = true;
                    ASPxGridView1.Visible = true;
                    ASPxGridView6.Visible = false;
                    ASPxGridView7.Visible = false;
                    ASPxGridView8.Visible = false;
                    ASPxGridView9.Visible = false;
                    pnlLastGrids_1.Visible = true;
                    pnlLastGrids_2.Visible = true;
                    ASPxTimer2.Enabled = false;
                    ASPxTimer3.Enabled = false;
                    ASPxTimer1.Enabled = true;
                }
                else if (myOption.SelectedIndex == 1)
                {
                    var myData_1 = SData.Rep_003Get(DateTime.Now.Year, 0);

                    double? sumMarketShare_11 = myData_1.Sum(x => x.MarketShare_1);
                    double? sumMarketShare_12 = myData_1.Sum(x => x.MarketShare_2);
                    double? sumMarketShare_13 = myData_1.Sum(x => x.MarketShare_3);
                    double? sumMarketShare_14 = myData_1.Sum(x => x.MarketShare_4);
                    double? sumMarketShare_15 = myData_1.Sum(x => x.MarketShare_5);
                    double? sumMarketShare_16 = myData_1.Sum(x => x.MarketShare_6);
                    double? sumMarketShare_17 = myData_1.Sum(x => x.MarketShare_7);
                    double? sumMarketShare_18 = myData_1.Sum(x => x.MarketShare_8);
                    double? sumMarketShare_19 = myData_1.Sum(x => x.MarketShare_9);
                    double? sumMarketShare_110 = myData_1.Sum(x => x.MarketShare_10);
                    double? sumMarketShare_111 = myData_1.Sum(x => x.MarketShare_11);
                    double? sumMarketShare_112 = myData_1.Sum(x => x.MarketShare_12);

                    double? sumMarketTrades_11 = myData_1.Sum(x => x.MarketTrades_1);
                    double? sumMarketTrades_12 = myData_1.Sum(x => x.MarketTrades_2);
                    double? sumMarketTrades_13 = myData_1.Sum(x => x.MarketTrades_3);
                    double? sumMarketTrades_14 = myData_1.Sum(x => x.MarketTrades_4);
                    double? sumMarketTrades_15 = myData_1.Sum(x => x.MarketTrades_5);
                    double? sumMarketTrades_16 = myData_1.Sum(x => x.MarketTrades_6);
                    double? sumMarketTrades_17 = myData_1.Sum(x => x.MarketTrades_7);
                    double? sumMarketTrades_18 = myData_1.Sum(x => x.MarketTrades_8);
                    double? sumMarketTrades_19 = myData_1.Sum(x => x.MarketTrades_9);
                    double? sumMarketTrades_110 = myData_1.Sum(x => x.MarketTrades_10);
                    double? sumMarketTrades_111 = myData_1.Sum(x => x.MarketTrades_11);
                    double? sumMarketTrades_112 = myData_1.Sum(x => x.MarketTrades_12);

                    myData_1.Add(new DAL.Entities.Rep_0012()
                    {
                        Channel = "Average",
                        MarketShare_1 = sumMarketShare_11,
                        MarketShare_2 = sumMarketShare_12,
                        MarketShare_3 = sumMarketShare_13,
                        MarketShare_4 = sumMarketShare_14,
                        MarketShare_5 = sumMarketShare_15,
                        MarketShare_6 = sumMarketShare_16,
                        MarketShare_7 = sumMarketShare_17,
                        MarketShare_8 = sumMarketShare_18,
                        MarketShare_9 = sumMarketShare_19,
                        MarketShare_10 = sumMarketShare_110,
                        MarketShare_11 = sumMarketShare_111,
                        MarketShare_12 = sumMarketShare_112,

                        MarketTrades_1 = sumMarketTrades_11,
                        MarketTrades_2 = sumMarketTrades_12,
                        MarketTrades_3 = sumMarketTrades_13,
                        MarketTrades_4 = sumMarketTrades_14,
                        MarketTrades_5 = sumMarketTrades_15,
                        MarketTrades_6 = sumMarketTrades_16,
                        MarketTrades_7 = sumMarketTrades_17,
                        MarketTrades_8 = sumMarketTrades_18,
                        MarketTrades_9 = sumMarketTrades_19,
                        MarketTrades_10 = sumMarketTrades_110,
                        MarketTrades_11 = sumMarketTrades_111,
                        MarketTrades_12 = sumMarketTrades_112,

                    });

                    ASPxGridView6.Columns["_1"].Caption = "Jan";
                    ASPxGridView6.Columns["_2"].Caption = "Feb";
                    ASPxGridView6.Columns["_3"].Caption = "Mar";
                    ASPxGridView6.Columns["_4"].Caption = "Apr";

                    ASPxGridView6.DataSource = myData_1;
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

                    var myData_2 = SData.Rep_003Get(DateTime.Now.Year, 1);

                    double? sumMarketShare_21 = myData_2.Sum(x => x.MarketShare_1);
                    double? sumMarketShare_22 = myData_2.Sum(x => x.MarketShare_2);
                    double? sumMarketShare_23 = myData_2.Sum(x => x.MarketShare_3);
                    double? sumMarketShare_24 = myData_2.Sum(x => x.MarketShare_4);
                    double? sumMarketShare_25 = myData_2.Sum(x => x.MarketShare_5);
                    double? sumMarketShare_26 = myData_2.Sum(x => x.MarketShare_6);
                    double? sumMarketShare_27 = myData_2.Sum(x => x.MarketShare_7);
                    double? sumMarketShare_28 = myData_2.Sum(x => x.MarketShare_8);
                    double? sumMarketShare_29 = myData_2.Sum(x => x.MarketShare_9);
                    double? sumMarketShare_210 = myData_2.Sum(x => x.MarketShare_10);
                    double? sumMarketShare_211 = myData_2.Sum(x => x.MarketShare_11);
                    double? sumMarketShare_212 = myData_2.Sum(x => x.MarketShare_12);

                    double? sumMarketTrades_21 = myData_2.Sum(x => x.MarketTrades_1);
                    double? sumMarketTrades_22 = myData_2.Sum(x => x.MarketTrades_2);
                    double? sumMarketTrades_23 = myData_2.Sum(x => x.MarketTrades_3);
                    double? sumMarketTrades_24 = myData_2.Sum(x => x.MarketTrades_4);
                    double? sumMarketTrades_25 = myData_2.Sum(x => x.MarketTrades_5);
                    double? sumMarketTrades_26 = myData_2.Sum(x => x.MarketTrades_6);
                    double? sumMarketTrades_27 = myData_2.Sum(x => x.MarketTrades_7);
                    double? sumMarketTrades_28 = myData_2.Sum(x => x.MarketTrades_8);
                    double? sumMarketTrades_29 = myData_2.Sum(x => x.MarketTrades_9);
                    double? sumMarketTrades_210 = myData_2.Sum(x => x.MarketTrades_10);
                    double? sumMarketTrades_211 = myData_2.Sum(x => x.MarketTrades_11);
                    double? sumMarketTrades_212 = myData_2.Sum(x => x.MarketTrades_12);

                    myData_2.Add(new DAL.Entities.Rep_0012()
                    {
                        Channel = "Average",
                        MarketShare_1 = sumMarketShare_21,
                        MarketShare_2 = sumMarketShare_22,
                        MarketShare_3 = sumMarketShare_23,
                        MarketShare_4 = sumMarketShare_24,
                        MarketShare_5 = sumMarketShare_25,
                        MarketShare_6 = sumMarketShare_26,
                        MarketShare_7 = sumMarketShare_27,
                        MarketShare_8 = sumMarketShare_28,
                        MarketShare_9 = sumMarketShare_29,
                        MarketShare_10 = sumMarketShare_210,
                        MarketShare_11 = sumMarketShare_211,
                        MarketShare_12 = sumMarketShare_212,

                        MarketTrades_1 = sumMarketTrades_21,
                        MarketTrades_2 = sumMarketTrades_22,
                        MarketTrades_3 = sumMarketTrades_23,
                        MarketTrades_4 = sumMarketTrades_24,
                        MarketTrades_5 = sumMarketTrades_25,
                        MarketTrades_6 = sumMarketTrades_26,
                        MarketTrades_7 = sumMarketTrades_27,
                        MarketTrades_8 = sumMarketTrades_28,
                        MarketTrades_9 = sumMarketTrades_29,
                        MarketTrades_10 = sumMarketTrades_210,
                        MarketTrades_11 = sumMarketTrades_211,
                        MarketTrades_12 = sumMarketTrades_212,

                    });

                    ASPxGridView7.Columns["_1"].Caption = "Jan";
                    ASPxGridView7.Columns["_2"].Caption = "Feb";
                    ASPxGridView7.Columns["_3"].Caption = "Mar";
                    ASPxGridView7.Columns["_4"].Caption = "Apr";

                    ASPxGridView7.DataSource = myData_2;
                    ASPxGridView7.DataBind();

                    if (ASPxGridView7.Columns.Count >= 12)
                    {
                        var month = DateTime.Now.Month;

                        for (int i = month; i < 13; i++)
                        {
                            ASPxGridView7.Columns.RemoveAt(month);
                        }

                        if (month > 9)
                            ASPxGridView7.Settings.HorizontalScrollBarMode = ScrollBarMode.Visible;
                    }

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    ASPxGridView6.Visible = true;
                    ASPxGridView7.Visible = true;
                    ASPxGridView0.Visible = false;
                    ASPxGridView1.Visible = false;
                    ASPxGridView8.Visible = false;
                    ASPxGridView9.Visible = false;
                    pnlLastGrids_1.Visible = false;
                    pnlLastGrids_2.Visible = false;
                    ASPxTimer1.Enabled = false;
                    ASPxTimer3.Enabled = false;
                    ASPxTimer2.Enabled = true;
                }
                else if (myOption.SelectedIndex == 2)
                {
                    var myData_1 = SData.Rep_005Get(DateTime.Now.Year, 0);

                    double? sumMarketShare_11 = myData_1.Sum(x => x.MarketShare_1);
                    double? sumMarketShare_12 = myData_1.Sum(x => x.MarketShare_2);
                    double? sumMarketShare_13 = myData_1.Sum(x => x.MarketShare_3);
                    double? sumMarketShare_14 = myData_1.Sum(x => x.MarketShare_4);

                    double? sumMarketTrades_11 = myData_1.Sum(x => x.MarketTrades_1);
                    double? sumMarketTrades_12 = myData_1.Sum(x => x.MarketTrades_2);
                    double? sumMarketTrades_13 = myData_1.Sum(x => x.MarketTrades_3);
                    double? sumMarketTrades_14 = myData_1.Sum(x => x.MarketTrades_4);

                    myData_1.Add(new DAL.Entities.Rep_0012()
                    {
                        Channel = "Average",
                        MarketShare_1 = sumMarketShare_11,
                        MarketShare_2 = sumMarketShare_12,
                        MarketShare_3 = sumMarketShare_13,
                        MarketShare_4 = sumMarketShare_14,

                        MarketTrades_1 = sumMarketTrades_11,
                        MarketTrades_2 = sumMarketTrades_12,
                        MarketTrades_3 = sumMarketTrades_13,
                        MarketTrades_4 = sumMarketTrades_14,

                    });

                    ASPxGridView6.Columns["_1"].Caption = "1st";
                    ASPxGridView6.Columns["_2"].Caption = "2nd";
                    ASPxGridView6.Columns["_3"].Caption = "3rd";
                    ASPxGridView6.Columns["_4"].Caption = "4th";

                    ASPxGridView6.DataSource = myData_1;
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

                    var myData_2 = SData.Rep_005Get(DateTime.Now.Year, 1);

                    double? sumMarketShare_21 = myData_2.Sum(x => x.MarketShare_1);
                    double? sumMarketShare_22 = myData_2.Sum(x => x.MarketShare_2);
                    double? sumMarketShare_23 = myData_2.Sum(x => x.MarketShare_3);
                    double? sumMarketShare_24 = myData_2.Sum(x => x.MarketShare_4);

                    double? sumMarketTrades_21 = myData_2.Sum(x => x.MarketTrades_1);
                    double? sumMarketTrades_22 = myData_2.Sum(x => x.MarketTrades_2);
                    double? sumMarketTrades_23 = myData_2.Sum(x => x.MarketTrades_3);
                    double? sumMarketTrades_24 = myData_2.Sum(x => x.MarketTrades_4);

                    myData_2.Add(new DAL.Entities.Rep_0012()
                    {
                        Channel = "Average",
                        MarketShare_1 = sumMarketShare_21,
                        MarketShare_2 = sumMarketShare_22,
                        MarketShare_3 = sumMarketShare_23,
                        MarketShare_4 = sumMarketShare_24,

                        MarketTrades_1 = sumMarketTrades_21,
                        MarketTrades_2 = sumMarketTrades_22,
                        MarketTrades_3 = sumMarketTrades_23,
                        MarketTrades_4 = sumMarketTrades_24,
                    });

                    ASPxGridView7.Columns["_1"].Caption = "1st";
                    ASPxGridView7.Columns["_2"].Caption = "2nd";
                    ASPxGridView7.Columns["_3"].Caption = "3rd";
                    ASPxGridView7.Columns["_4"].Caption = "4th";

                    ASPxGridView7.DataSource = myData_2;
                    ASPxGridView7.DataBind();

                    if (ASPxGridView7.Columns.Count >= 12)
                    {
                        var month = DateTime.Now.Month;

                        for (int i = month; i < 13; i++)
                        {
                            ASPxGridView7.Columns.RemoveAt(month);
                        }

                        if (month > 9)
                            ASPxGridView7.Settings.HorizontalScrollBarMode = ScrollBarMode.Visible;
                    }

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    ASPxGridView6.Visible = true;
                    ASPxGridView7.Visible = true;
                    ASPxGridView0.Visible = false;
                    ASPxGridView1.Visible = false;
                    ASPxGridView8.Visible = false;
                    ASPxGridView9.Visible = false;
                    pnlLastGrids_1.Visible = false;
                    pnlLastGrids_2.Visible = false;
                    ASPxTimer1.Enabled = false;
                    ASPxTimer3.Enabled = false;
                    ASPxTimer2.Enabled = true;
                }
                else if (myOption.SelectedIndex == 3)
                {
                    ASPxGridView8.Columns["_1"].Caption = (DateTime.Now.Year - 3).ToString();
                    ASPxGridView8.Columns["_2"].Caption = (DateTime.Now.Year - 2).ToString();
                    ASPxGridView8.Columns["_3"].Caption = (DateTime.Now.Year - 1).ToString();
                    var myData = SData.Rep_004Get(0);

                    double? sumMarketShare_1 = myData.Sum(x => x.MarketShare_1);
                    double? sumMarketShare_2 = myData.Sum(x => x.MarketShare_2);
                    double? sumMarketShare_3 = myData.Sum(x => x.MarketShare_3);

                    double? sumMarketTrades_1 = myData.Sum(x => x.MarketTrades_1);
                    double? sumMarketTrades_2 = myData.Sum(x => x.MarketTrades_2);
                    double? sumMarketTrades_3 = myData.Sum(x => x.MarketTrades_3);

                    myData.Add(new DAL.Entities.Rep_0013()
                    {
                        Channel = "Average",
                        MarketShare_1 = sumMarketShare_1,
                        MarketShare_2 = sumMarketShare_2,
                        MarketShare_3 = sumMarketShare_3,
                        MarketTrades_1 = sumMarketTrades_1,
                        MarketTrades_2 = sumMarketTrades_2,
                        MarketTrades_3 = sumMarketTrades_3,

                    });

                    ASPxGridView8.DataSource = myData;
                    ASPxGridView8.DataBind();

                    ASPxGridView9.Columns["_1"].Caption = (DateTime.Now.Year - 3).ToString();
                    ASPxGridView9.Columns["_2"].Caption = (DateTime.Now.Year - 2).ToString();
                    ASPxGridView9.Columns["_3"].Caption = (DateTime.Now.Year - 1).ToString();
                    ASPxGridView9.DataSource = SData.Rep_004Get(1);
                    ASPxGridView9.DataBind();

                    dateEdit.Visible = false;
                    lblDate.Visible = false;
                    ASPxGridView6.Visible = false;
                    ASPxGridView7.Visible = false;
                    ASPxGridView0.Visible = false;
                    ASPxGridView1.Visible = false;
                    ASPxGridView8.Visible = true;
                    ASPxGridView9.Visible = true;
                    pnlLastGrids_1.Visible = false;
                    pnlLastGrids_2.Visible = false;
                    ASPxTimer1.Enabled = false;
                    ASPxTimer2.Enabled = false;
                    ASPxTimer3.Enabled = true;
                }

                ASPxGridView2.DataSource = SData.Rep_0011aGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView2.DataBind();
                ASPxGridView4.DataSource = SData.Rep_0011bGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView4.DataBind();

                ASPxGridView3.DataSource = SData.Rep_0011aGet(1, dateEdit.Date.ToShortDateString());
                ASPxGridView3.DataBind();
                ASPxGridView5.DataSource = SData.Rep_0011bGet(1, dateEdit.Date.ToShortDateString());
                ASPxGridView5.DataBind();
            }
            catch
            {
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();

            ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

            if (myOption.SelectedIndex == 0)
            {
                gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 1)
            {
                gridExport_2.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 2)
            {
                //gridExport_2.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 3)
            {
                gridExport_4.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
        }

        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            GetData();

            ASPxComboBox myOption = ASPxPageControl1.FindControl("myOption") as ASPxComboBox;

            if (myOption.SelectedIndex == 0)
            {
                gridExport_1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 1)
            {
                gridExport_3.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 2)
            {
                //gridExport_5.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 3)
            {
                gridExport_5.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
        }

        protected void myOption_ValueChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}