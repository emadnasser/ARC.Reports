using System;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;

public partial class WebSpecificFeatures_Thumbnails : System.Web.UI.Page {
    public class ThumbnailsFiller : BookmarkFillerBase<Control> {
        public static void FillThumbnails(ASPxPanel panel, ASPxDocumentViewer documentViewer) {
            new ThumbnailsFiller(documentViewer).Fill(panel);
        }

        protected override Document Document {
            get {
                var printingSystem = documentViewer.Report.PrintingSystem;
                if(printingSystem.PageCount == 0) {
                    documentViewer.Report.CreateDocument();
                }
                return printingSystem.Document;
            }
        }

        ASPxDocumentViewer documentViewer;

        ThumbnailsFiller(ASPxDocumentViewer documentViewer)
            : base(documentViewer.ClientID) {
            this.documentViewer = documentViewer;
        }

        protected override Control FillNode(Control parent, BookmarkNode bookmarkNode, string navigationScript) {
            ASPxPanel aspxPanel = parent as ASPxPanel;
            if(aspxPanel != null) {
                PlaceHolder holder = new PlaceHolder();
                aspxPanel.Controls.Add(holder);
                return holder;
            }

            ImageBrick imageBrick = Document.GetBrick(bookmarkNode) as ImageBrick;
            if(imageBrick != null) {
                string fileName = bookmarkNode.Text + ".png";
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/Thumbnails/" + fileName);
                if(!Directory.Exists(Path.GetDirectoryName(filePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                try {
                    if(!File.Exists(filePath))
                        imageBrick.Image.Save(filePath, ImageFormat.Png);
                } catch(System.Runtime.InteropServices.ExternalException) { }

                Image image = new Image();
                image.BorderColor = imageBrick.BorderColor;
                image.BorderWidth = new Unit(imageBrick.BorderWidth, UnitType.Pixel);
                image.AlternateText = bookmarkNode.Text;
                image.ImageUrl = new Uri(parent.Page.Request.Url, "ThumbnailsImageHandler.ashx?img=" + System.Web.HttpUtility.UrlEncode(fileName)).ToString();
                image.Width = new Unit(imageBrick.Image.Width / 2, UnitType.Pixel);
                image.Height = new Unit(imageBrick.Image.Height / 2, UnitType.Pixel);

                LiteralControl fullName = new LiteralControl();
                fullName.Text = bookmarkNode.Text;

                HtmlAnchor anchor = new HtmlAnchor();
                anchor.HRef = "javascript:void(" + navigationScript + ")";
                anchor.Controls.Add(image);
                anchor.Controls.Add(new LiteralControl("<br />"));
                anchor.Controls.Add(fullName);

                WebControl div = new WebControl(HtmlTextWriterTag.Div);
                div.Style["margin-left"] = "10px";
                div.Style["margin-top"] = "10px";
                div.Style["margin-bottom"] = "20px";
                div.Style["text-align"] = "center";
                div.Controls.Add(anchor);

                parent.Controls.Add(div);
            }
            return null;
        }
    }

    protected void Page_Init(object sender, EventArgs e) {
        var report = new XtraReportsDemos.ShrinkGrow.Report {
            PaperKind = PaperKind.A5,
            Landscape = true
        };
        report.Margins.Left = 90;
        report.Margins.Right = 85;
        report.xrPictureBox1.BeforePrint += xrPictureBox1_BeforePrint;
        documentViewer.Report = report;
    }

    protected override void OnPreRender(EventArgs e) {
        ThumbnailsFiller.FillThumbnails(Panel1, documentViewer);
        base.OnPreRender(e);
    }

    void xrPictureBox1_BeforePrint(object sender, PrintEventArgs e) {
        var picture = (XRPictureBox)sender;
        var report = picture.RootReport;
        picture.Bookmark = report.GetCurrentColumnValue<string>("FirstName") + " " + report.GetCurrentColumnValue<string>("LastName");
    }
}
