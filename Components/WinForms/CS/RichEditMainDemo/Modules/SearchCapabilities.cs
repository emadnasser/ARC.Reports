using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SearchCapabilitiesModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public SearchCapabilitiesModule() {
            InitializeComponent();
            RtfLoadHelper.Load("Search.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
