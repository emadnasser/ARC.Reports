using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class StatisticFunctionsModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook workbook;
       
        public StatisticFunctionsModule() {
            InitializeComponent();
            InitializeWorkbook();
            this.spreadsheetControl1.Document.History.Clear();
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return formulasRibbonPage1; } }
        #endregion

        #region Sample workbook initialization
        void InitializeWorkbook() {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("TrendlineAnalysis_template.xlsx"));
        }
        #endregion
    }
}
