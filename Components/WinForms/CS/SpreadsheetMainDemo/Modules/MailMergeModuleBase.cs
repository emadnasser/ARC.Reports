using System;
using System.Globalization;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeModuleBase : SpreadSheetTutorialControlBase {
        SpreadsheetControl spreadsheetControl1;
        IWorkbook book;
        CultureInfo culture;

        protected MailMergeModuleBase() {
            this.culture = DefaultCulture;
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = culture;
            ribbonPageDemoGroup.Visible = ShowHideCommentsItem;
            spreadsheetDockManager1.ForceInitialize();
            filteringDockPanel.Visibility = ShowFilterPanel ? DockVisibility.Visible : DockVisibility.Hidden;
            mailMergeParametersDockPanel.Visibility = ShowParametersPanel ? DockVisibility.Visible : DockVisibility.Hidden;
            spreadsheetControl1.BeginUpdate();
            book = spreadsheetControl1.Document;
            LoadTemplate(spreadsheetControl1);
            LoadData(book);
            spreadsheetControl1.CreateCommand(Commands.SpreadsheetCommandId.MailMergeShowRanges).Execute();
            spreadsheetControl1.Document.History.Clear();
            spreadsheetControl1.EndUpdate();
        }
        protected virtual bool ShowHideCommentsItem { get { return true; } }
        protected virtual bool ShowFilterPanel { get { return true; } }
        protected virtual bool ShowParametersPanel { get { return false; } }
        protected bool ShowSalesManagers { get { return checkEdit0.Checked; } }
        protected bool ShowInsideSalesCoordinators { get { return checkEdit1.Checked; } }
        protected bool ShowSalesRepresentatives { get { return checkEdit2.Checked; } }
        protected override void DoShow() {
            ribbonControl1.SelectedPage = mailMergeRibbonPage1;
            spreadsheetBarController1.Control.Focus();
            
            base.DoShow();
        }
        private void hideCommentsCheckItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            HideComments(book, !hideCommentsCheckItem.Checked);
        }
        private void checkEdit_CheckedChanged(object sender, System.EventArgs e) {
            ChangeFilter(book);
        }

        protected virtual void LoadTemplate(SpreadsheetControl spreadsheetControl) {
        }
        protected virtual void LoadData(IWorkbook book) {
        }
        protected virtual void ChangeFilter(IWorkbook book) {
            throw new NotImplementedException();
        }
        protected virtual void HideComments(IWorkbook book, bool visible) {
            throw new NotImplementedException();
        }
    }
}
