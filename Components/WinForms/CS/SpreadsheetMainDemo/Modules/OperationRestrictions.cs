using System;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Docs.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class OperationRestrictionsModule : SpreadsheetRibbonTutorialControlBase {
        public OperationRestrictionsModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OperationRestrictions_template.xlsx"), DocumentFormat.Xlsx);

            propertyGridControl1.SelectedObject = new BehaviorOptionsProvider(spreadsheetControl1.Options.Behavior);
            propertyGridControl1.RowHeaderWidth = 110;
            propertyGridControl1.OptionsView.ShowRootCategories = false;
            propertyGridControl1.ExpandAllRows();
            InitializeZoomFactors();
        }

        void InitializeZoomFactors() {
            spreadsheetControl1.Options.Behavior.MaxZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MaxZoomFactorDefault;
            spreadsheetControl1.Options.Behavior.MinZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MinZoomFactorDefault;
        }

        #region Events
        void edtReadOnly_CheckedChanged(object sender, EventArgs e) {
            spreadsheetControl1.ReadOnly = ((CheckEdit)sender).Checked;
        }
        #endregion
    }
    
}
