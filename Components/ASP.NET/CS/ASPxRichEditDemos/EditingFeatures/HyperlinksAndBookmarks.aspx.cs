using System;
using System.IO;
using DevExpress.Web.Demos;
using DevExpress.XtraRichEdit;

public partial class EditingFeatures_HyperlinksAndBookmarks : OfficeDemoPage
{
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            RichEditDemoUtils.HideFileTab(DemoRichEdit);
            DemoRichEdit.Open(Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, @"Hyperlinks.rtf"));
        }

        DemoRichEdit.Settings.Bookmarks.Visibility = chShowBookmarks.Checked ? RichEditBookmarkVisibility.Visible : RichEditBookmarkVisibility.Hidden;
        DemoRichEdit.Settings.Bookmarks.Color = ColorEdit.Color;
    }
    protected void DemoRichEdit_PreRender(object sender, EventArgs e) {
        DemoRichEdit.Focus();
    }
}
