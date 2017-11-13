using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;

namespace DevExpress.XtraSpreadsheet.Demos {

    public partial class PivotTableModule : SpreadsheetRibbonTutorialControlBase {
        public PivotTableModule() {
            InitializeComponent();
        }

        #region Properties
        IWorkbook Workbook { get { return spreadsheetControl1.Document; } }
        protected internal override RibbonPage SelectedRibbonPage {
            get {
                this.pivotTableToolsRibbonPageCategory1.Visible = true;
                this.pivotTableAnalyzeRibbonPage1.Visible = true;
                return this.pivotTableAnalyzeRibbonPage1;
            }
        }
        #endregion

        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            ApplyOptions();
            InitializeWorkbook();
        }

        void InitializeWorkbook() {
            Workbook.LoadDocument(DemoUtils.GetRelativePath("PivotTableDemoTemplate.xlsx"));
        }
        void ApplyOptions() {
            SpreadsheetPivotTableFieldListOptions pivotTableFieldListOptions = spreadsheetControl1.Options.PivotTableFieldList;
            pivotTableFieldListOptions.StartPosition = SpreadsheetPivotTableFieldListStartPosition.ManualSpreadsheetControl;
            pivotTableFieldListOptions.StartSize = new Size(306, 601);
            double width = spreadsheetControl1.Width - pivotTableFieldListOptions.StartSize.Width * (spreadsheetControl1.DpiX / 96.0);
            pivotTableFieldListOptions.StartLocation = new Point((int)width, 0);
        }

        protected override void DoShow() {
            base.DoShow();
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet["C3"];
        }

        protected override void DoHide() {
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet["A1"];
            base.DoHide();
        }
    }
}
