using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using DevExpress.XtraBars;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting.Control;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetTutorialControl : TutorialControlBase, IDXMenuManager {
        #region Static
        public static string GetSaveFileName(string defaulName) {
            return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName);
        }
        public static string GetSaveFileName(string filter, string defaulName) {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = filter;
            sfDialog.FileName = defaulName;
            if(sfDialog.ShowDialog() != DialogResult.OK)
                return null;
            return sfDialog.FileName;
        }
        public static void ShowFile(string fileName, TutorialControlBase control) {
            if(!File.Exists(fileName))
                return;
            DialogResult dResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dResult == DialogResult.Yes)
                Process.Start(fileName);
        }
        #endregion
        #region Fields
        LookAndFeelMenu menu;
        IDXMenuManager fMenuManager;
        PanelControl spreadsheetTutorialPanel;
        CultureInfo defaultCulture = new CultureInfo("en-US");
        #endregion

        public SpreadsheetTutorialControl() {
            InitializeComponent();
            this.fitToPageCheckEdit.CheckedChanged += new EventHandler(this.fitToPageCheckEdit_CheckedChanged);
            CanShowBorders = true;
        }

        #region Properties
        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set {
                if(menu == value)
                    return;
                this.menu = value;
            }
        }
        public IDXMenuManager MenuManager {
            get { return fMenuManager; }
            set { fMenuManager = value; }
        }
        public virtual bool ShowOptions { get { return false; } }
        protected virtual string DefaultFileName { get { return ""; } }
        protected virtual string DefaultSaveFileFilter { get { return "Excel Workbook(*.xlsx)|*.xlsx|Excel 97-2003 Workbook(*.xls)|*.xls|CSV (Comma delimited)(*.csv)|*.csv|PDF(*.pdf)|*.pdf"; } }
        protected PanelControl SpreadsheetTutorialPanel { get { return spreadsheetTutorialPanel; } }
        protected CheckEdit FitToPageCheckEdit { get { return fitToPageCheckEdit; } }
        protected bool CanShowBorders {
            get {
                return this.spreadsheetPreview1.CanShowBorders;
            }
            set {
                this.spreadsheetPreview1.CanShowBorders = value;
            }
        }
        public CultureInfo DefaultCulture { get { return defaultCulture; } }
        #endregion

        protected virtual IWorkbook CreateEmptyBook() {
            IWorkbook book = new Workbook();
            book.Options.Culture = DefaultCulture;
            return book;
        }
        public virtual IWorkbook CreateBook() {
            return CreateEmptyBook();
        }
        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) {
            return this;
        }
        void IDXMenuManager.DisposeManager() {
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            BaseEdit be = ctrl as BaseEdit;
            if(be != null)
                be.MenuManager = manager;
        }
        #region Print and Export
        protected void RefreshPreview() {
            IWorkbook book = CreateBook();
            book.Worksheets[0].PrintOptions.FitToPage = fitToPageCheckEdit.Checked;
            this.spreadsheetPreview1.Workbook = book;
            this.spreadsheetPreview1.UpdatePreview();
        }
        #endregion

        void saveButton_Click(object sender, EventArgs e) {
            string fileName = GetSaveFileName(DefaultSaveFileFilter, DefaultFileName);
            IWorkbook book = CreateBook();
            if(!string.IsNullOrEmpty(fileName)) {
                string ext = Path.GetExtension(fileName);
                if(ext == ".xls")
                    book.SaveDocument(fileName, DocumentFormat.Xls);
                else if(ext == ".csv")
                    book.SaveDocument(fileName, DocumentFormat.Csv);
                else if(ext == ".pdf")
                    book.ExportToPdf(fileName);
                else
                    book.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
            ShowFile(fileName, this);
        }
        void fitToPageCheckEdit_CheckedChanged(object sender, EventArgs e) {
            RefreshPreview();
        }
    }
}
