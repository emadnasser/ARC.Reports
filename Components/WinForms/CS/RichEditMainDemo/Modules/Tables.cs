using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class TablesModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public TablesModule() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("ActiveCustomers.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
