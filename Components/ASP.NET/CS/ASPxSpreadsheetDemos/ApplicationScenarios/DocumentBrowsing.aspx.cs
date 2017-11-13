using System;
using System.IO;
using System.Linq;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class ApplicationScenarios_DocumentBrowsing : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        SpreadsheetDemoUtils.HideFileTab(Spreadsheet);

        if(!IsPostBack) {
            Spreadsheet.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath;
            FileManager.Settings.RootFolder = DirectoryManagmentUtils.DocumentBrowsingFolderPath;
            FileManagerFile file = FileManager.SelectedFolder.GetFiles().FirstOrDefault();
            if(file != null) {
                FileManager.SelectedFile = file;
                Spreadsheet.Open(file.FullName);
            }
        }
        if(Spreadsheet.WorkDirectory != DirectoryManagmentUtils.DocumentBrowsingFolderPath)
            DirectoryManagmentUtils.AssertTimeout();
    }
    protected void Spreadsheet_Callback(object source, CallbackEventArgsBase e) {
        if(FileManager.SelectedFile != null)
            Spreadsheet.Open(FileManager.SelectedFile.FullName);
    }
    protected void FileManager_FileUploading(object sender, FileManagerFileUploadEventArgs e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }
}
