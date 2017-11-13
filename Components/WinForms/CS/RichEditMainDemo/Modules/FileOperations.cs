using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class FileOperationsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public FileOperationsModule() {
            InitializeComponent();
            RtfLoadHelper.Load("CharacterFormatting.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
