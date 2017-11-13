using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ViewsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ViewsModule() {
            InitializeComponent();
            ChildRibbon.SelectedPage = ChildRibbon.Pages["View"];
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
    }
}
