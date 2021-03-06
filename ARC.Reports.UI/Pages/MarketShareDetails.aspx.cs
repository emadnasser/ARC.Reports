﻿using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;
using System.Drawing;
using ARC.Reports.DataModel;
using ARC.Reports.Classes.Enums;

namespace ARC.Reports.Pages
{
    public partial class MarketShareDetails : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            IsAutorized();

            //string id = Request.LogonUserIdentity.Name.Trim();

            //if (!Roles.GetRolesForUser(id).Contains("R_002"))
            //{
            //    if (!Roles.GetRolesForUser(id).Contains("Admins"))
            //    {
            //        Server.Transfer("~/Public/Unauthorized.aspx");
            //    }
            //}

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
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;

                ASPxGridView0.DataSource = SData.MarketShareDetail(0, dateEdit.Date.ToShortDateString());
                ASPxGridView0.DataBind();

                var lst = SData.MarketShareTotal_D_Totals(0, 0, dateEdit.Date.ToShortDateString());

                if (Convert.ToDouble(lst[0].DiffDayPer) >= 0)
                    ASPxGridView2.Columns[4].CellStyle.ForeColor = Color.Green;
                else if (Convert.ToDouble(lst[0].DiffDayPer) < 0)
                    ASPxGridView2.Columns[4].CellStyle.ForeColor = Color.Red;

                ASPxGridView2.DataSource = lst;
                ASPxGridView2.DataBind();

                ASPxGridView4.DataSource = SData.MarketShareTotal_D_Totals(0, 1, dateEdit.Date.ToShortDateString());
                ASPxGridView4.DataBind();

                ASPxGridView1.DataSource = SData.MarketShareDetail(1, dateEdit.Date.ToShortDateString());
                ASPxGridView1.DataBind();

                var lst_3 = SData.MarketShareTotal_D_Totals(1, 0, dateEdit.Date.ToShortDateString());

                if (Convert.ToDouble(lst_3[0].DiffDayPer) >= 0)
                    ASPxGridView3.Columns[4].CellStyle.ForeColor = Color.Green;
                else if (Convert.ToDouble(lst_3[0].DiffDayPer) < 0)
                    ASPxGridView3.Columns[4].CellStyle.ForeColor = Color.Red;

                ASPxGridView3.DataSource = lst_3;
                ASPxGridView3.DataBind();
                ASPxGridView5.DataSource = SData.MarketShareTotal_D_Totals(1, 1, dateEdit.Date.ToShortDateString());
                ASPxGridView5.DataBind();
            }
            catch
            {
            }
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_0.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });

            //gridExport_0.WritePdfToResponse();
            //gridExport_1.WritePdfToResponse();
            //gridExport_2.WritePdfToResponse();
            //gridExport_3.WritePdfToResponse();

            //PrintingSystem ps = new PrintingSystem();

            //PrintableComponentLink link1 = new PrintableComponentLink(ps);
            //link1.Component = gridExport_0;

            //PrintableComponentLink link2 = new PrintableComponentLink(ps);
            //link2.Component = gridExport_2;

            //CompositeLink compositeLink = new CompositeLink(ps);
            //compositeLink.Links.AddRange(new object[] { link1, link2 });

            //compositeLink.CreateDocument();
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    compositeLink.PrintingSystem.ExportToXlsx(stream);
            //    WriteToResponse("filename", true, "xlsx", stream);
            //}
            //ps.Dispose();
        }

        protected void ASPxButton2_Click(object sender, EventArgs e)
        {
            GetData();
            gridExport_1.WriteXlsxToResponse(new XlsxExportOptionsEx { ExportType = ExportType.WYSIWYG });
        }

        private void IsAutorized()
        {
            var myUser = DataAccess.GetUser(User.Identity.Name);

            if (myUser != null)
            {
                if (!myUser.Roles.Any(x => x.RoleName == RoleType.R_002.ToString()))
                {
                    if (!myUser.Roles.Any(x => x.RoleName == RoleType.ReportsAdmins.ToString()))
                    {
                        Server.Transfer("~/Public/Unauthorized.aspx");
                    }
                }
            }
            else
            {
                Server.Transfer("~/Public/Unauthorized.aspx");
            }
        }

        //void WriteToResponse(string fileName, bool saveAsFile, string fileFormat, MemoryStream stream)
        //{
        //    if (Page == null || Page.Response == null)
        //        return;
        //    string disposition = saveAsFile ? "attachment" : "inline";
        //    Page.Response.Clear();
        //    Page.Response.Buffer = false;
        //    Page.Response.AppendHeader("Content-Type", string.Format("application/{0}", fileFormat));
        //    Page.Response.AppendHeader("Content-Transfer-Encoding", "binary");
        //    Page.Response.AppendHeader("Content-Disposition",
        //        string.Format("{0}; filename={1}.{2}", disposition, fileName, fileFormat));
        //    Page.Response.BinaryWrite(stream.GetBuffer());
        //    Page.Response.End();
        //}
    }
}