using System;
using System.IO;
using DevExpress.Web.Demos;

public partial class RichEditDemoSpellChecking : OfficeDemoPage {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            RichEditDemoUtils.HideFileTab(DemoRichEdit);
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"SpellChecking.docx"));
        }
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
