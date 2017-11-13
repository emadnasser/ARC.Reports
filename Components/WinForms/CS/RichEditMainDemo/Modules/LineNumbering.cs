using System;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class LineNumberingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public LineNumberingModule() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("LineNumbering.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
            ribbonControl1.SelectedPage = pageLayoutRibbonPage1;
        }
    }
}
