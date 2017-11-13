using DevExpress.Web.ASPxHtmlEditor;

namespace DevExpress.Web.Demos {
    public class HtmlEditorHtmlHighlightingDemoOptions {
        public HtmlEditorHtmlHighlightingDemoOptions() {
            ShowCollapseTagButtons = true;
            ShowLineNumbers = true;
            HighlightActiveLine = true;
            HighlightMatchingTags = true;
            EnableTagAutoClosing = true;
            EnableAutoCompletion = true;
            Mode = HtmlEditorHtmlEditingMode.Advanced;
        }
        public bool ShowCollapseTagButtons { get; set; }
        public bool ShowLineNumbers { get; set; }
        public bool HighlightActiveLine { get; set; }
        public bool HighlightMatchingTags { get; set; }
        public bool EnableTagAutoClosing { get; set; }
        public bool EnableAutoCompletion { get; set; }
        public HtmlEditorHtmlEditingMode Mode { get; set; }
    }
}
