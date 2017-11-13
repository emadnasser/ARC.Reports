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
    public partial class SpreadsheetEmployeeInformationModule : SpreadsheetTutorialControl {
        public SpreadsheetEmployeeInformationModule() {
            InitializeComponent();
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }

        protected override string DefaultFileName { get { return "EmployeeInformation"; } }

        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            EmployeeInformationDocumentGenerator generator = new EmployeeInformationDocumentGenerator(DefaultCulture);
            return generator.Generate(DemoUtils.GetRelativePath("EmployeeInformation_template.xlsx"));
        }

        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }
    }
}
