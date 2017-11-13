using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetShiftScheduleModel : SpreadsheetModelBase {
        public SpreadsheetShiftScheduleModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewShiftSchedule";
        }
    }
}
