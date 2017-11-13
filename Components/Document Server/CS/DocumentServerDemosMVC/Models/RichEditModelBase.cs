using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class RichEditModelBase {
        public RichEditModelBase() {
            PreviewModel = new RichEditPreviewModel();
            PreviewModel.OwnerPropertyName = "PreviewModel";
        }

        public int ExportToDocumentType { get; set; }
        public RichEditPreviewModel PreviewModel { get; internal set; }
    }
    public class RichEditPreviewModel {
        public string OwnerPropertyName { get; set; }
        public bool CanShowOnlyFirstWorksheet { get; set; }
        public string PreviewDocumentAction { get; set; }
        //public IWorkbook Workbook { get; set; }
    }   
}
