using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class BulletsAndNumberingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public BulletsAndNumberingModule() {
            InitializeComponent();
            RtfLoadHelper.Load("BulletsAndNumbering.rtf", richEditControl);
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
