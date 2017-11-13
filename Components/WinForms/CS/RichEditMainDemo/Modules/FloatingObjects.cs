using System;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class FloatingObjectsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public FloatingObjectsModule() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("FloatingObjects.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
            ribbonControl1.SelectedPage = homeRibbonPage1;
        }

    }
}
