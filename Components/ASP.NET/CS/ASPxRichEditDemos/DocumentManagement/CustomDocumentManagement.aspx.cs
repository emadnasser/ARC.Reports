using System;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class RichEditDemoCustomDocumentManagement : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            FileManager.Settings.RootFolder = DirectoryManagmentUtils.DocumentBrowsingFolderPath;
            FileManagerFile file = FileManager.SelectedFolder.GetFiles().FirstOrDefault();
            if(file != null) {
                FileManager.SelectedFile = file;
                DemoRichEdit.Open(file.FullName);
            }
        }
    }
    protected void DemoRichEdit_Callback(object sender, CallbackEventArgsBase e) {
        if(FileManager.SelectedFile != null)
            DemoRichEdit.Open(FileManager.SelectedFile.FullName);
    }
    protected void FileManager_FileUploading(object sender, FileManagerFileUploadEventArgs e) {
        e.Cancel = Utils.IsSiteMode;
        e.ErrorText = Utils.GetReadOnlyMessageText();
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
    protected void FileManager_Load(object sender, EventArgs e) {
        if(FileManager.Settings.RootFolder != DirectoryManagmentUtils.DocumentBrowsingFolderPath)
            DirectoryManagmentUtils.AssertTimeout();
    }
}
