using System;
using System.IO;

public partial class RichEditDemoLoadAndSave : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            DemoRichEdit.WorkDirectory = DirectoryManagmentUtils.DocumentBrowsingFolderPath;
        }
        if(DemoRichEdit.WorkDirectory != DirectoryManagmentUtils.DocumentBrowsingFolderPath)
            DirectoryManagmentUtils.AssertTimeout();
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
