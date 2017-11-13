using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class BreakevenAnalysisModule : SpreadsheetRibbonTutorialControlBase {
        public BreakevenAnalysisModule() {
            InitializeComponent();
            InitializeWorkbook();
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return insertRibbonPage1; } }
        #endregion

        void InitializeWorkbook() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("BreakevenAnalysis.xlsx"));
        }
    }
}
