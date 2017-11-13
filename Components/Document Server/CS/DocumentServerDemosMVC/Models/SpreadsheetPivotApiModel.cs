using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetPivotApiModel : SpreadsheetModelBase {
        public SpreadsheetPivotApiModel() {
            SourceCodeTreeModel = new SourceCodeTreeModel();
            SourceCodeTreeModel.ExamplePath = "~/Content/ApiExampleCode/Pivots";
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewPivotApi";
        }
        public string CSCode { get; set; }
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public SourceCodeTreeModel SourceCodeTreeModel { get; set; }
    }
}
