using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetBreakevenAnalysisModel : SpreadsheetModelBase {
        public SpreadsheetBreakevenAnalysisModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewBreakevenAnalysis";
        }
    }
}
