using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.Web.Demos;

public partial class ServerSideFunctionality_CellValueChanged : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            var templatePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "CellValueChanged.xlsx");
            var documentId = DocumentIdGenerator.GenerateDocumentId();
            Spreadsheet.Open(documentId, DocumentFormat.Xlsx, () => File.ReadAllBytes(templatePath));
        }
    }
}
