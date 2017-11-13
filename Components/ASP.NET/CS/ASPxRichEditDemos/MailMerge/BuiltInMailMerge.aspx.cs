using System;
using System.IO;

public partial class RichEditDemoBuiltInMailMerge : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            DemoRichEdit.WorkDirectory = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "MailMergeResults");
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"MailMergeTemplate.docx"));
            DemoRichEdit.ViewMergedData = true;
        }
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
