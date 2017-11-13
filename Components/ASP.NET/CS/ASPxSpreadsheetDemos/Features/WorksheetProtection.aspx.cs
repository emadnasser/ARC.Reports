using System;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Features_WorksheetProtection : OfficeDemoPage {
    const string Password = "123";

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            SpreadsheetDemoUtils.HideFileTab(Spreadsheet);
            var filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "Protection.xlsx");
            Spreadsheet.Open(filePath);
        }
    }

    protected void CallbackPanel_Callback(object sender, EventArgs e) {
        SelectedItemCollection selectedItems = ProtectionOptionsList.SelectedItems;
        WorksheetProtectionPermissions selectedPermissions = WorksheetProtectionPermissions.SelectLockedCells | WorksheetProtectionPermissions.SelectUnlockedCells;
        foreach (ListEditItem item in selectedItems)
            selectedPermissions |= (WorksheetProtectionPermissions)Enum.Parse(typeof(WorksheetProtectionPermissions), item.Value.ToString());
        UnprotectAllWorksheets(Password);
        ProtectAllWorksheets(Password, selectedPermissions);
    }

    protected void ProtectAllWorksheets(string password, WorksheetProtectionPermissions permissions) {
        foreach (Worksheet worksheet in Spreadsheet.Document.Worksheets)
            worksheet.Protect(password, permissions);
    }

    protected void UnprotectAllWorksheets(string password) {
        foreach (Worksheet worksheet in Spreadsheet.Document.Worksheets)
            if (worksheet.IsProtected)
                worksheet.Unprotect(password);
    }
}
