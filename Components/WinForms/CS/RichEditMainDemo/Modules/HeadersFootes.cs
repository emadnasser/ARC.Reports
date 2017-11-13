using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HeadersFootersModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public HeadersFootersModule() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("HeadersFooters.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
