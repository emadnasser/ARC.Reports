using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class RichEditDemoFindAndReplace : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            RichEditDemoUtils.HideFileTab(DemoRichEdit);
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"TextWithImages.rtf"));
        }
    }
}
