using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetEmployeeInformationModel : SpreadsheetModelBase {
        public SpreadsheetEmployeeInformationModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = false;
            PreviewModel.PreviewDocumentAction = "PreviewEmployeeInformation";
        }
    }
}
