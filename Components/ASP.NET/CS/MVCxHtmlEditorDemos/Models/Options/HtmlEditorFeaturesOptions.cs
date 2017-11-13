using DevExpress.Utils;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class HtmlEditorFeaturesDemoOptions {
        public HtmlEditorFeaturesDemoOptions() {
            UpdateDeprecatedElements = true;
            UpdateBoldItalic = true;
            EnterMode = HtmlEditorEnterMode.P;
            AllowContextMenu = DefaultBoolean.True;
            AllowDesignView = true;
            AllowHtmlView = true;
            AllowPreview = true;
            AllowIdAttributes = true;
            AllowStyleAttributes = true;
            ResourcePathMode = ResourcePathMode.NotSet;
            AllowCustomColorsInColorPickers = true;
            AllowEditFullDocument = false;
            AllowedDocumentType = ASPxHtmlEditor.AllowedDocumentType.XHTML;
        }

        public bool AllowScripts { get; set; }
        public bool AllowIFrames { get; set; }
        public bool AllowFormElements { get; set; }
        public bool AllowIdAttributes { get; set; }
        public bool AllowStyleAttributes { get; set; }
        public bool AllowCustomColorsInColorPickers { get; set; }
        public bool UpdateDeprecatedElements { get; set; }
        public bool UpdateBoldItalic { get; set; }
        public ResourcePathMode ResourcePathMode { get; set; }
        public bool AllowEditFullDocument { get; set; }
        public HtmlEditorEnterMode EnterMode { get; set; }
        public DefaultBoolean AllowContextMenu { get; set; }
        public AllowedDocumentType AllowedDocumentType { get; set; }
        public bool AllowDesignView { get; set; }
        public bool AllowHtmlView { get; set; }
        public bool AllowPreview { get; set; }
        public HtmlEditorView ActiveView { get { return HtmlEditorExtension.GetActiveView("FeaturesHtml"); } }
    }
}
