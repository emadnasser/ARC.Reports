using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetCustomFunctionModel : SpreadsheetModelBase {
        public SpreadsheetCustomFunctionModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewCustomFunction";
        }
    }
}
