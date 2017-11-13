using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ParagraphFormattingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ParagraphFormattingModule() {
            InitializeComponent();
            RtfLoadHelper.Load("ParagraphFormatting.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
