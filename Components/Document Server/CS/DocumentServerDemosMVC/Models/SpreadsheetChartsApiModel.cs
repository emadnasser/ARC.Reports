using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetChartsApiModel : SpreadsheetModelBase {
        public SpreadsheetChartsApiModel() {
            SourceCodeTreeModel = new SourceCodeTreeModel();
            SourceCodeTreeModel.ExamplePath = "~/Content/ApiExampleCode/Charts";
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewChartsApi";
        }
        public string CSCode { get; set; }
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public SourceCodeTreeModel SourceCodeTreeModel { get; set; }
    }
}
