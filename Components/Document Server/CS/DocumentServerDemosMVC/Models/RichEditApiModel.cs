using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class RichEditApiModel : RichEditModelBase {
        public RichEditApiModel() {
            PreviewModel.PreviewDocumentAction = "PreviewApi";
            SourceCodeTreeModel = new Demos.SourceCodeTreeModel();
            SourceCodeTreeModel.ExamplePath = "~/Content/RichEditApiExampleCode";
        }

        public string CSCode { get; set; }
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public SourceCodeTreeModel SourceCodeTreeModel { get; set; }
    }        
}
