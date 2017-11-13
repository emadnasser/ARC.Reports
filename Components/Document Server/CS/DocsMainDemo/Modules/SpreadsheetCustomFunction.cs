using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetCustomFunctionModule : SpreadsheetTutorialControl {
        public SpreadsheetCustomFunctionModule() {
            InitializeComponent();
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }

        protected override string DefaultFileName { get { return "CustomFunction"; } }

        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            CustomFunctionDocumentGenerator generator = new CustomFunctionDocumentGenerator(DefaultCulture);
            return generator.Generate();
        }

        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
    }
}
