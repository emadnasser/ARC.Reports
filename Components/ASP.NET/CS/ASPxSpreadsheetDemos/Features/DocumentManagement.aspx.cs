using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class Features_DocumentManagement : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            Spreadsheet.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath;
            Spreadsheet.SettingsDocumentSelector.UploadSettings.Enabled = !Utils.IsSiteMode;
            var filePath = Path.Combine(Spreadsheet.WorkDirectory, "BreakevenAnalysis.xlsx");
            Spreadsheet.Open(filePath);
        }
        if(Spreadsheet.WorkDirectory != DirectoryManagmentUtils.DocumentBrowsingFolderPath)
            DirectoryManagmentUtils.AssertTimeout();
    }
}
