using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetApiModel : SpreadsheetModelBase {
        public SpreadsheetApiModel() {
            SourceCodeTreeModel = new SourceCodeTreeModel();
            SourceCodeTreeModel.ExamplePath = "~/Content/ApiExampleCode";
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewApi";
        }
        public string CSCode { get; set; }
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public SourceCodeTreeModel SourceCodeTreeModel { get; set; }
    }
}
