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
using System.Drawing;
using System.Collections.Generic;

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
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
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
                    ASPxGridView6.Columns["_1"].Caption = "Jan";
                    ASPxGridView6.Columns["_2"].Caption = "Feb";
                    ASPxGridView6.Columns["_3"].Caption = "Mar";
                    ASPxGridView6.Columns["_4"].Caption = "Apr";
                    ASPxGridView6.Columns["_13"].Caption = DateTime.Now.ToString("MMM");

                    ASPxGridView6.DataSource = SData.Rep_003Get(DateTime.Now.Year, 0);
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

                    ASPxGridView7.Columns["_1"].Caption = "Jan";
                    ASPxGridView7.Columns["_2"].Caption = "Feb";
                    ASPxGridView7.Columns["_3"].Caption = "Mar";
                    ASPxGridView7.Columns["_4"].Caption = "Apr";
                    ASPxGridView7.Columns["_13"].Caption = DateTime.Now.ToString("MMM");

                    ASPxGridView7.DataSource = SData.Rep_003Get(DateTime.Now.Year, 1);
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
                    ASPxGridView6.Columns["_1"].Caption = "1st";
                    ASPxGridView6.Columns["_2"].Caption = "2nd";
                    ASPxGridView6.Columns["_3"].Caption = "3rd";
                    ASPxGridView6.Columns["_4"].Caption = "4th";

                    ASPxGridView6.DataSource = SData.Rep_005Get(DateTime.Now.Year, 0);
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

                    ASPxGridView7.Columns["_1"].Caption = "1st";
                    ASPxGridView7.Columns["_2"].Caption = "2nd";
                    ASPxGridView7.Columns["_3"].Caption = "3rd";
                    ASPxGridView7.Columns["_4"].Caption = "4th";

                    ASPxGridView7.DataSource = SData.Rep_005Get(DateTime.Now.Year, 1);
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

                    ASPxGridView8.DataSource = SData.Rep_004Get(0);
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

                var lst_2 = SData.Rep_0011aGet(0, dateEdit.Date.ToShortDateString());

                if (Convert.ToDouble(lst_2[0].DiffDayPer) >= 0)
                    ASPxGridView2.Columns[4].CellStyle.ForeColor = Color.Green;
                else if (Convert.ToDouble(lst_2[0].DiffDayPer) < 0)
                    ASPxGridView2.Columns[4].CellStyle.ForeColor = Color.Red;

                ASPxGridView2.DataSource = lst_2;
                ASPxGridView2.DataBind();

                ASPxGridView4.DataSource = SData.Rep_0011bGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView4.DataBind();

                var lst_3 = SData.Rep_0011aGet(1, dateEdit.Date.ToShortDateString());

                if (Convert.ToDouble(lst_3[0].DiffDayPer) >= 0)
                    ASPxGridView3.Columns[4].CellStyle.ForeColor = Color.Green;
                else if (Convert.ToDouble(lst_3[0].DiffDayPer) < 0)
                    ASPxGridView3.Columns[4].CellStyle.ForeColor = Color.Red;

                ASPxGridView3.DataSource = lst_3;
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
                gridExport_2.FileName = "Market Share Totals Main - Monthly";
                gridExport_2.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 2)
            {
                gridExport_2.FileName = "Market Share Totals Main - Quarterly";
                gridExport_2.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
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
                gridExport_3.FileName = "Market Share Totals Nomu - Monthly";
                gridExport_3.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
            }
            else if (myOption.SelectedIndex == 2)
            {
                gridExport_3.FileName = "Market Share Totals Nomu - Quarterly";
                gridExport_3.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
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

        protected void ASPxGridView6_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            var myData = SData.Rep_007Get(DateTime.Now.Year, 0);

            var sumLst = SData.Rep_008Get(0, DateTime.Now.Year.ToString());
            myData.Add(new DAL.Entities.Rep_007()
            {
                MarketShare = sumLst.MarketShare,
                MarketTrades = sumLst.MarketTrades,
            });

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
            //if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s13" && myData.Count > 12)
            //{
            //    e.TotalValue = myData[12].MarketShare;
            //}
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
            //if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t13" && myData.Count > 12)
            //{
            //    e.TotalValue = myData[12].MarketTrades;
            //}

            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s13")
            {
                //((ASPxSummaryItem)e.Item).SummaryType = DevExpress.Data.SummaryItemType.Sum;
                e.TotalValue = myData[myData.Count - 1].MarketShare;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketShare_13";
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t13")
            {
                //((ASPxSummaryItem)e.Item).SummaryType = DevExpress.Data.SummaryItemType.Sum;
                e.TotalValue = myData[myData.Count - 1].MarketTrades;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketTrades_13";
            }
        }

        protected void ASPxGridView7_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            var myData = SData.Rep_007Get(DateTime.Now.Year, 1);

            var sumLst = SData.Rep_008Get(1, DateTime.Now.Year.ToString());
            myData.Add(new DAL.Entities.Rep_007()
            {
                MarketShare = sumLst.MarketShare,
                MarketTrades = sumLst.MarketTrades,
            });

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
            //if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s13" && myData.Count > 12)
            //{
            //    e.TotalValue = myData[12].MarketShare;
            //}
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
            //if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t13" && myData.Count > 12)
            //{
            //    e.TotalValue = myData[12].MarketTrades;
            //}

            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_s13")
            {
                //((ASPxSummaryItem)e.Item).SummaryType = DevExpress.Data.SummaryItemType.Sum;
                e.TotalValue = myData[myData.Count - 1].MarketShare;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketShare_13";
            }
            if (((ASPxSummaryItem)e.Item).FieldName == "Sm_t13")
            {
                //((ASPxSummaryItem)e.Item).SummaryType = DevExpress.Data.SummaryItemType.Sum;
                e.TotalValue = myData[myData.Count - 1].MarketTrades;
                ((ASPxSummaryItem)e.Item).ShowInColumn = "MarketTrades_13";
            }
        }
    }
}