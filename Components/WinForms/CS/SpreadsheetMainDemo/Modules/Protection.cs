using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class ProtectionModule : SpreadsheetRibbonTutorialControlBase {
        public ProtectionModule() {
            InitializeComponent();
            InitializeWorkbook();
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return reviewRibbonPage1; } }
        #endregion

        void InitializeWorkbook() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            workbook.LoadDocument(DemoUtils.GetRelativePath("SimpleMonthlyBudget.xlsx"));
        }
    }
}
