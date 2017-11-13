namespace DevExpress.Web.Demos {
    public class SpreadsheetModelBase {
        public SpreadsheetModelBase() {
            PreviewModel = new SpreadsheetPreviewModel();
            PreviewModel.OwnerPropertyName = "PreviewModel";
        }
        public int ExportToDocumentType { get; set; }
        public SpreadsheetPreviewModel PreviewModel { get; internal set; }
    }
    public class SourceCodeTreeModel {
        public string ExamplePath { get; set; }
    }
}
