using DevExpress.Web.Office;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

public partial class RichEditDemoMailMergeViaDocumentServer : OfficeDemoPage {
    const string documentId = "mailMergeDocId";

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback) {
            RichEditDocumentServer documentServer = new RichEditDocumentServer();
            documentServer.LoadDocument(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"MailMergeTemplate.docx"));
            documentServer.Options.MailMerge.DataSource = GetData();

            using(MemoryStream stream = new MemoryStream()) {
                documentServer.MailMerge(stream, DocumentFormat.OpenXml);
                stream.Position = 0;
                DocumentManager.CloseDocument(documentId);
                DemoRichEdit.Open(documentId, DocumentFormat.OpenXml, () => {
                    return stream;
                });
            }
        }
    }
    IEnumerable<Employees> GetData() {
        var context = new NorthwindDataContextExt();
        return context.Employees.Where(employee => employee.City == cmbCity.Value.ToString());
    }
}
