using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HyperlinksModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public HyperlinksModule() {
            InitializeComponent();

            OpenXmlLoadHelper.Load("Hyperlinks.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
            UpdateBookmarkVisibility();
            UpdateBookmarkColor();
            InsertLinksInDocument();
        }

        private void InsertLinksInDocument() {
            Document doc = richEditControl.Document;
            DocumentRange[] foundRanges = doc.FindAll("DevExpress WinForms Rich Text Editor", SearchOptions.CaseSensitive);
            if (foundRanges.Length > 0) {
                Hyperlink hlink = doc.Hyperlinks.Create(foundRanges[0]);
                hlink.NavigateUri = "https://www.devexpress.com/Products/NET/Controls/WinForms/rich_editor/";
            }

            Bookmark bm = doc.Bookmarks.Create(doc.Range.Start, 1, "Top");
            doc.Paragraphs.Append();
            DocumentRange lastRange = doc.AppendText("To the Top");
            Hyperlink hlinkBookmark = doc.Hyperlinks.Create(lastRange);
            hlinkBookmark.Anchor = "Top";
        }
        private void chkShowBookmarks_CheckedChanged(object sender, EventArgs e) {
            UpdateBookmarkVisibility();
        }
        private void colorEdit1_ColorChanged(object sender, EventArgs e) {
            UpdateBookmarkColor();
        }
        private void UpdateBookmarkVisibility() {
            this.richEditControl.Options.Bookmarks.Visibility = chkShowBookmarks.Checked ? RichEditBookmarkVisibility.Visible : RichEditBookmarkVisibility.Hidden;
        }
        private void UpdateBookmarkColor() {
            this.richEditControl.Options.Bookmarks.Color = colorEdit1.Color;
        }
        private void chkShowToolTip_CheckedChanged(object sender, EventArgs e) {
            this.richEditControl.Options.Hyperlinks.ShowToolTip = chkShowToolTip.Checked;
        }
        private void chkCtrl_CheckedChanged(object sender, EventArgs e) {
            if (chkCtrl.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Control;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Control;
        }
        private void chkAlt_CheckedChanged(object sender, EventArgs e) {
            if (chkAlt.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Alt;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Alt;
        }
        private void chkShift_CheckedChanged(object sender, EventArgs e) {
            if (chkShift.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Shift;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Shift;
        }
    }
}
