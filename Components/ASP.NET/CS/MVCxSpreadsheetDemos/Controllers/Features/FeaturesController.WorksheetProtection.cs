using System;
using System.Web.Mvc;
using DevExpress.Spreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        const string Password = "123";

        public ActionResult WorksheetProtection() {
            return DemoView("WorksheetProtection");
        }
        public ActionResult WorksheetProtectionCallbackPanelPartial() {
            WorksheetProtectionPermissions selectedPermissions = WorksheetProtectionPermissions.SelectLockedCells | WorksheetProtectionPermissions.SelectUnlockedCells;
            if (!string.IsNullOrEmpty(Request.Params["SelectedValues"])) {
                string[] selectedItems = Request.Params["SelectedValues"].Split(new char[] { ',' });                
                foreach (string item in selectedItems)
                    selectedPermissions |= (WorksheetProtectionPermissions)Enum.Parse(typeof(WorksheetProtectionPermissions), item);
            }
            UnprotectAllWorksheets(Password);
            ProtectAllWorksheets(Password, selectedPermissions);

            return PartialView("WorksheetProtectionCallbackPanelPartial");
        }
        public ActionResult WorksheetProtectionSpreadsheetPartial() {
            return PartialView("WorksheetProtectionSpreadsheetPartial");
        }
        protected void ProtectAllWorksheets(string password, WorksheetProtectionPermissions permissions) {
            foreach (Worksheet worksheet in SpreadsheetExtension.GetCurrentDocument("Spreadsheet").Worksheets)
                worksheet.Protect(password, permissions);
        }

        protected void UnprotectAllWorksheets(string password) {
            foreach (Worksheet worksheet in SpreadsheetExtension.GetCurrentDocument("Spreadsheet").Worksheets)
                if (worksheet.IsProtected)
                    worksheet.Unprotect(password);
        }
    }
}
