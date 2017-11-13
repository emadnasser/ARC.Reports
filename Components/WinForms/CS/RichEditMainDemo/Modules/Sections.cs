using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SectionsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public SectionsModule() {
            InitializeComponent();
            RtfLoadHelper.Load("Sections.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
