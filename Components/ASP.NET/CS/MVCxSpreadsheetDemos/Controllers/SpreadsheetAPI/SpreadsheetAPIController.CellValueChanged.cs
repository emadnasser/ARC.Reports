using System.Web.Mvc;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController {
        public ActionResult CellValueChanged() {
            SpreadsheetDocument document = new SpreadsheetDocument("CellValueChanged.xlsx", DocumentFormat.Xlsx);
            return DemoView("CellValueChanged", document);
        }

        public ActionResult CellValueChangedPartial(SpreadsheetDocument document) {
            return PartialView("CellValueChangedPartial", document);
        }
    }
}
