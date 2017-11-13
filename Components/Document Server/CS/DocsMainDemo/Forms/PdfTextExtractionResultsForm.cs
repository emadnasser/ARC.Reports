using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
	public partial class PdfTextExtractionResultsForm : XtraForm {
		public PdfTextExtractionResultsForm() {
			InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", typeof(frmMain).Assembly);
            CenterToParent();
		}
        public void SetText(string text) {
            memoEdit.Text = text;        
        }
	}
}
