using System;
using DevExpress.XtraSpreadsheet.Demos;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class AutoFilterModule : SpreadsheetRibbonTutorialControlBase {
        public AutoFilterModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("AutoFilter_template.xlsx"));
        }

        #region Properties
        protected internal override RibbonPage SelectedRibbonPage { get { return dataRibbonPage1; } }
        #endregion
    }
}
