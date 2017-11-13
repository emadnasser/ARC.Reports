using DevExpress.XtraBars.Ribbon;
using System;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SpreadsheetRibbonTutorialControlBase : SpreadSheetTutorialControlBase {
        public SpreadsheetRibbonTutorialControlBase() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;

            SubscribeEvents();
        }

        #region Properties
        protected internal virtual RibbonPage SelectedRibbonPage { get { return homeRibbonPage1; } }
        #endregion

        protected internal virtual void SubscribeEvents() {
            spreadsheetControl1.CellEndEdit += spreadsheetControl1_CellEndEditOverride;
            spreadsheetControl1.CellValueChanged += spreadsheetControl1_CellValueChangedOverride;
        }

        protected virtual void spreadsheetControl1_CellValueChangedOverride(object sender, SpreadsheetCellEventArgs e) { }
        protected virtual void spreadsheetControl1_CellEndEditOverride(object sender, SpreadsheetCellValidatingEventArgs e) { }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RibbonPage selectedPage = SelectedRibbonPage;
            if(selectedPage != null)
                ribbonControl1.SelectedPage = selectedPage;
        }
    }
}
