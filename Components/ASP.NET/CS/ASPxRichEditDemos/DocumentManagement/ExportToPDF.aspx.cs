using System;
using System.IO;
using DevExpress.Web.Internal;
using DevExpress.Web.Demos;

public partial class RichEditDemoExportToPDF : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            RichEditDemoUtils.HideFileTab(DemoRichEdit);
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"pdfExample.docx"));
        }
    }
    protected void ExportButton_Click(object sender, EventArgs e) {
        using(MemoryStream stream = new MemoryStream()) {
            DemoRichEdit.ExportToPdf(stream);
            HttpUtils.WriteFileToResponse(this.Page, stream, "ExportedDocument", true, "pdf");
        }
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
