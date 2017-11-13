using System;

namespace DevExpress.Web.Demos {
    public class SpreadsheetXLExportApiModel {
        public SpreadsheetXLExportApiModel() {
            SourceCodeTreeModel = new SourceCodeTreeModel();
            SourceCodeTreeModel.ExamplePath = "~/Content/ApiExampleCode/XLExport";
        }

        public string CSCode { get; set; }
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public bool IsXLSButtonEnabled { get; set; }
        public bool IsCSVButtonEnabled { get; set; }
        public SourceCodeTreeModel SourceCodeTreeModel { get; set; }
    }
}
