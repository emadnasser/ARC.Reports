using System;
using ARC.Reports.DAL;
using DevExpress.Web;
using System.Web.Security;
using System.Linq;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.Export;

namespace ARC.Reports
{
    public partial class MarketShareDetails : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            string id = Request.LogonUserIdentity.Name.Trim();

            if (!Roles.GetRolesForUser(id).Contains("R_002"))
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
            try
            {
                ASPxDateEdit dateEdit = ASPxPageControl1.FindControl("dateEdit") as ASPxDateEdit;

                ASPxGridView0.DataSource = SData.Rep_001Get(0, dateEdit.Date.ToShortDateString());
                ASPxGridView0.DataBind();

                ASPxGridView2.DataSource = SData.Rep_0011aGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView2.DataBind();

                ASPxGridView4.DataSource = SData.Rep_0011bGet(0, dateEdit.Date.ToShortDateString());
                ASPxGridView4.DataBind();
                
                ASPxGridView1.DataSource = SData.Rep_001Get(1, dateEdit.Date.ToShortDateString());
                ASPxGridView1.DataBind();

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