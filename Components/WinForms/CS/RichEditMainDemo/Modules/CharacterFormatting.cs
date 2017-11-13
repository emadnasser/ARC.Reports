using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class CharacterFormattingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public CharacterFormattingModule() {
            InitializeComponent();
            RtfLoadHelper.Load("CharacterFormatting.rtf", richEditControl);
            richEditControl.Focus();
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
