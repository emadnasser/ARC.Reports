using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Localization;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class DocLoadingModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public DocLoadingModule() {
            InitializeComponent();
            DocLoadHelper.Load("DocLoading.doc", richEditControl);
            new RichEditDocLoadingDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }

    public class RichEditDocLoadingDemoExceptionsHandler : RichEditDemoExceptionsHandler {
        public RichEditDocLoadingDemoExceptionsHandler(RichEditControl control)
            : base(control) { }

        protected override void OnRichEditControlUnhandledException(object sender, RichEditUnhandledExceptionEventArgs e) {
            try {
                base.OnRichEditControlUnhandledException(sender, e);
            }
            catch (InvalidOperationException ex) {
                if (ex.Message == XtraRichEditLocalizer.GetString(XtraRichEditStringId.Msg_MagicNumberNotFound) || ex.Message == XtraRichEditLocalizer.GetString(XtraRichEditStringId.Msg_UnsupportedDocVersion)){
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
                else
                    throw ex;
            }
        }
    }
}
