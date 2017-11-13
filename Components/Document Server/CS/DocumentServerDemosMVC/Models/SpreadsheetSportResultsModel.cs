using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetSportResultsModel : SpreadsheetModelBase {
        public SpreadsheetSportResultsModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = false;
            PreviewModel.PreviewDocumentAction = "PreviewSportResults";
        }
    }
}
