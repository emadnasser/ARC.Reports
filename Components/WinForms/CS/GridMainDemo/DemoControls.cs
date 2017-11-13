using System;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.LookAndFeel;
using DevExpress.ActiveDemos;
using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Export;
using System.Data;
using DevExpress.Export;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;

namespace DevExpress.XtraGrid.Demos {
	public class GridRibbonMenuManager : RibbonMenuManager {
        BaseView view = null;
        XtraGridBlending blending = null;
        BarSubItem bsiViewOptions, bsiSelectionOptions;
        BarCheckItem bciAlphaBlendingUsing;
        BarButtonItem bbiAlphaBlendingAdjustment;
        DevExpress.XtraGrid.Design.XAppearances xapp = null;
        public GridRibbonMenuManager(RibbonMainForm form) : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
            CreateBlendingMenu(form.ReservGroup2, form.Ribbon);
        }
        void CreateBlendingMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = Properties.Resources.AlphaBlending;
            bciAlphaBlendingUsing = new CheckBarItem(Manager, Properties.Resources.UsingString, new ItemClickEventHandler(miUsing_Click));
            bbiAlphaBlendingAdjustment = new ButtonBarItem(Manager, Properties.Resources.Adjustment, new ItemClickEventHandler(miAdjustment_Click));
            bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraGrid.Demos.Images.Blending.png", typeof(frmMain).Assembly);
            ribbonPageGroup.ItemLinks.Add(bciAlphaBlendingUsing);
            ribbonPageGroup.ItemLinks.Add(bbiAlphaBlendingAdjustment);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = Properties.Resources.Options;
            bsiViewOptions = new BarSubItem();
            bsiSelectionOptions = new BarSubItem();
            bsiViewOptions.Caption = Properties.Resources.ViewOptions;
            bsiSelectionOptions.Caption = Properties.Resources.SelectionOptions;
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            MainFormHelper.SetBarButtonImage(bsiSelectionOptions, "LayoutOptions");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonControl.Items.Add(bsiSelectionOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiSelectionOptions);
        }
        public DevExpress.XtraGrid.Design.XAppearances XAppearances {
            get {
                if(xapp == null)
                    xapp = new DevExpress.XtraGrid.Design.XAppearances("System", true);
                return xapp;
            }
        }
        public void RefreshOptionsMenu(BaseView view) {
            GridOptionsView ov = new GridOptionsView();
            
            ShowReservGroup1(view != null);
            this.view = view;
            LookAndFeelMenu.ClearOptionItems(Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiSelectionOptions, SelectionOptions, new ItemClickEventHandler(miSelectionViewOptions_Click), Manager);
        }
        private object ViewOptions {
            get {
                if(view is GridView) return ((GridView)view).OptionsView;
                if(view is CardView) return ((CardView)view).OptionsView;
                return null;
            }
        }
        private object SelectionOptions {
            get {
                if(view is GridView) return ((GridView)view).OptionsSelection;
                return null;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(view != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), ViewOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
        void miSelectionViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(view != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), SelectionOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiSelectionOptions, SelectionOptions);
            }
        }
        public void InitBlendingMenu(XtraGridBlending blending) {
            this.blending = blending;
            ShowReservGroup2(blending != null);
            if(blending != null) {
                bciAlphaBlendingUsing.Checked = blending.Enabled;
                bbiAlphaBlendingAdjustment.Enabled = blending.Enabled;
            }
        }
        private void miUsing_Click(object sender, ItemClickEventArgs e) {
            Application.DoEvents();
            CheckBarItem item = e.Item as CheckBarItem;
            if(blending != null && item != null) {
                blending.Enabled = item.Checked;
                bbiAlphaBlendingAdjustment.Enabled = item.Checked;
            }
        }
        private void miAdjustment_Click(object sender, ItemClickEventArgs e) {
            if(blending != null) {
                blending.ShowDialog();
            }
        }
    }
	public class TutorialControl : DevExpress.DXperience.Demos.TutorialControlBase {
        public GridRibbonMenuManager GridRibbonMenuManager { get { return RibbonMenuManager as GridRibbonMenuManager; } } 
		protected override void SetControlManager(Control ctrl, BarManager manager) {
			DevExpress.XtraGrid.GridControl grid = ctrl as DevExpress.XtraGrid.GridControl;
			if(grid != null) grid.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
		}
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions { get { return ExportView != null; } }
	    public override bool AllowGenerateReport { get { return true; } }
	    public virtual BaseView ExportView { get { return null;}}
		public virtual bool ShowViewOptions { get { return false;}}
		protected virtual PaintView[] PaintViews { get { return null;}} 
        #region Active Demo
        ActiveDemoResults fActiveDemoResults = null;
        private ActiveDemo fActiveDemo = null;
        public override void RunActiveDemo() {
            if(IsActiveDemo) return;
            ActiveDemoResults.Clear();
            fActiveDemo = CreateActiveDemo();
            RunGridActiveDemo(fActiveDemo as ActiveGridDemo);
            ActiveActionsCancelMode cancelMode = fActiveDemo.Actions.CancelMode;
            fActiveDemo.Dispose();
            fActiveDemo = null;
            if(cancelMode == ActiveActionsCancelMode.UnknownTopWindow)
                System.Windows.Forms.MessageBox.Show(Properties.Resources.ActiveDemoWarning); //TODO
            if(cancelMode == ActiveActionsCancelMode.UserCancel)
                System.Windows.Forms.MessageBox.Show(Properties.Resources.ActiveDemoCanceled);
        }
        public bool IsActiveDemo { get { return fActiveDemo != null; } }
        protected virtual ActiveDemo CreateActiveDemo() {
            return new ActiveDemo();
        }
        protected ActiveDemoResults ActiveDemoResults {
            get {
                if(fActiveDemoResults == null) fActiveDemoResults = new ActiveDemoResults(this);
                return fActiveDemoResults;
            }
        }
        protected virtual void RunGridActiveDemo(ActiveGridDemo fActiveDemo) { }
        protected override void OnVisibleChanged(object sender, EventArgs e) {
            if(fActiveDemoResults != null)
                if(!this.Visible) ActiveDemoResults.Hide();
            base.OnVisibleChanged(sender, e);
        }
        #endregion
        #region InitData
        protected virtual void InitNWindData() {
            string DBFileName = string.Empty;

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != string.Empty) {
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName);
            }
        }
        protected internal virtual void UpdateRibbonItems() { }
        protected virtual void InitVehiclesData() {
            string DBFileName = string.Empty;

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Vehicles.mdb");
            if(DBFileName != string.Empty) {
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName);
            }
        }
        protected virtual void InitMDBData(string connectionString) {
        }
        protected virtual void InitXMLData(string dataFileName) {
        }
        protected virtual DataSet NWindDataSet() {
            string DBFileName = string.Empty;
            DataSet ds = new DataSet();

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != string.Empty) {
                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName, ds);
            }
            return ds;
        }
        protected virtual void InitMDBData(string connectionString, DataSet ds) {
        }
        protected virtual void InitXMLData(string dataFileName, DataSet ds) {
        }
        protected virtual void InitIssueListData(dsIssueList ds) {
            string DBFileName = string.Empty;

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\IssueList.mdb");
            if(DBFileName != string.Empty) {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Departments", con);
                SetWaitDialogCaption(Properties.Resources.LoadingDepartments);
                oleDbDataAdapter.Fill(ds.Departments);
                oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Users", con);
                SetWaitDialogCaption(Properties.Resources.LoadingUsers);
                oleDbDataAdapter.Fill(ds.Users);
                oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Projects", con);
                SetWaitDialogCaption(Properties.Resources.LoadingProjects);
                oleDbDataAdapter.Fill(ds.Projects);
                oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Items", con);
                SetWaitDialogCaption(Properties.Resources.LoadingItems);
                oleDbDataAdapter.Fill(ds.Items);
            }
        }
        protected virtual void InitXMLData(DataSet ds) {
        }
        protected virtual void InitCustomersPaymentData(dsContacts ds) {
            string DBFileName = string.Empty;

            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Contacts.mdb");
            if(DBFileName != string.Empty) {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                System.Data.OleDb.OleDbDataAdapter oleDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM CustomersPayment", con);

                SetWaitDialogCaption(Properties.Resources.LoadingCustomerPayment);
                oleDBAdapter.Fill(ds.CustomersPayment);
            }
        } 
        #endregion
        #region Print and Export

	    protected override void ExportToCore(String filename, string ext) {
	        if(ExportView == null) return;
	        Cursor currentCursor = Cursor.Current;
	        Cursor.Current = Cursors.WaitCursor;
	        if(ext == "rtf") ExportView.ExportToRtf(filename);
	        if(ext == "pdf") ExportView.ExportToPdf(filename);
	        if(ext == "mht") ExportView.ExportToMht(filename);
	        if(ext == "html") ExportView.ExportToHtml(filename);
	        if(ext == "txt") ExportView.ExportToText(filename);
	        if(ext == "xls") ExportToXls(filename);
	        if(ext == "xlsx") ExportToXlsx(filename);
	        Cursor.Current = currentCursor;
	    }
	    void ExportToXlsx(string filename) {
	        var options = new XlsxExportOptionsEx();
	        options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
	        ExportView.ExportToXlsx(filename, options);
	    }
	    void ExportToXls(string filename) {
	        var options = new XlsExportOptionsEx();
	        options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
	        ExportView.ExportToXls(filename, options);
	    }
	    protected override void ExportToPDF() {
            ExportTo("pdf", Properties.Resources.PDFFilter);
        }
        protected override void ExportToHTML() {
            ExportTo("html", Properties.Resources.HTMLFilter);
        }
        protected override void ExportToMHT() {
            ExportTo("mht", Properties.Resources.MHTFilter);
        }
        protected override void ExportToXLS() {
            ExportTo("xls", Properties.Resources.XLSFilter);
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", Properties.Resources.XLSXFilter);
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", Properties.Resources.RTFFilter);
        }
        protected override void ExportToText() {
            ExportTo("txt", Properties.Resources.TextFilter);
        }
        protected override void PrintPreview() {
            if(this.ExportView != null && this.ExportView.GridControl != null) {
                ExportView.PrintInitialize += ExportView_PrintInitialize;
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportView.GridControl.ShowRibbonPrintPreview();
                else this.ExportView.GridControl.ShowPrintPreview();
                ExportView.PrintInitialize -= ExportView_PrintInitialize;
            }
        }
	    protected override void GenerateReport() {
            XtraReport report = ReportGenerator.GenerateReport(ExportView);
            report.ShowRibbonDesignerDialog();
	    }

	    void ExportView_PrintInitialize(object sender, PrintInitializeEventArgs e) {
            PageHeaderFooter phf = e.Link.PageHeaderFooter as PageHeaderFooter;

            //// Clear the PageHeaderFooter's contents.
            //phf.Header.Content.Clear();

            //// Add custom information to the link's header.
            //phf.Header.Content.AddRange(new string[] { "", TutorialName, ""});
            //phf.Header.Font = new System.Drawing.Font(phf.Header.Font.FontFamily, 16);
            //phf.Header.LineAlignment = BrickAlignment.Near;


            phf.Footer.Content.Clear();
            phf.Footer.Content.AddRange(new string[] { "", "", "[Page # of Pages #]"});
            phf.Footer.LineAlignment = BrickAlignment.Far;

            e.Link.RtfReportHeader = @"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " + TutorialName + @"\par}\xd\x\a";
        }
        #endregion
    }
    public class PaintView {
        BaseView fView = null;
        string fAppearanceName = "";
        public PaintView(BaseView fView, string fAppearanceName) {
            this.fView = fView;
            this.fAppearanceName = fAppearanceName;
        }

        public BaseView View { get { return fView; } }
        public string AppearanceName { get { return fAppearanceName; } }
    }
}
