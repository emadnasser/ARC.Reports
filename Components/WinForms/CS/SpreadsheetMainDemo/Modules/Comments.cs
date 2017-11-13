using System;
using DevExpress.XtraSpreadsheet.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CommentsModule : SpreadsheetRibbonTutorialControlBase {
        public CommentsModule() {
            InitializeComponent();

            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Comments_template.xlsx"), DocumentFormat.Xlsx);
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return reviewRibbonPage1; } }
        #endregion
    }
}
