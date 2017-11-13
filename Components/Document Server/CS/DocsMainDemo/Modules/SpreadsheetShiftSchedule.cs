using System.Drawing;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetShiftScheduleModule : SpreadsheetTutorialControl {
        public SpreadsheetShiftScheduleModule() {
            InitializeComponent();
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
        }

        protected override string DefaultFileName { get { return "ShiftSchedule"; } }

        public override IWorkbook CreateBook() {
            InitializePreviewControl();
            ShiftScheduleGenerator generator = new ShiftScheduleGenerator(DefaultCulture);
            return generator.Generate();
        }

        void InitializePreviewControl() {
            SpreadsheetTutorialPanel.Location = Point.Empty;
        }

    }

}
