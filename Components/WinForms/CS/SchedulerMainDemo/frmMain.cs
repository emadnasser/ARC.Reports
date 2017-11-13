using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraSpellChecker;

namespace DevExpress.XtraScheduler.Demos {

    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
		public frmMain() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
        }

        #region Properties
        protected override string DemoName { get { return "XtraScheduler Main Demo (" + DemoUtils.GetLanguageString() + " code)"; } }
        #endregion

        protected override void ShowAbout() {
            SchedulerControl.About();
        }
        protected override string ProductName { get { return "XtraScheduler"; } }
		protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", typeof(frmMain).Assembly);
		}
		protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.DoShowModule(name, groupControl, caption, RibbonMenuManager as SchedulerRibbonMenuManager);
		}

        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new SchedulerRibbonMenuManager(this);
        }

		private void frmMain_Load(object sender, EventArgs e) {
			CultureInfo culture = CultureInfo.InvariantCulture;
			sharedDictionaryStorage.Dictionaries.Clear();
			SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetFileRelativePath("american.xlg"), DemoUtils.GetFileRelativePath("english.aff"), culture);
			dictionary.AlphabetPath = DemoUtils.GetFileRelativePath("EnglishAlphabet.txt");
			sharedDictionaryStorage.Dictionaries.Add(dictionary);
			SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetFileRelativePath("CustomEnglish.dic"), culture);
			sharedDictionaryStorage.Dictionaries.Add(customDictionary);
		}
	}

    public class CheckBarItemWithPrintColorSchema : CheckBarItem {
        PrintColorSchema printColorSchema;
        public CheckBarItemWithPrintColorSchema(BarManager manager, string text, ItemClickEventHandler handler, PrintColorSchema printColorSchema)
            : base(manager, text, handler) {
            this.printColorSchema = printColorSchema;
        }
        public PrintColorSchema PrintColorSchema { get { return printColorSchema; } }
    }
    
    public interface IDemoSchedulerReport {        
        void UpdateActiveReport();
    }

    public class SchedulerRibbonMenuManager : RibbonMenuManager {
        #region Fields
        SchedulerControl fSchedulerControl;
        IDemoSchedulerReport fSchedulerReport;

        BarButtonItem bbiPageSetup;
        BarButtonItem bbiLoadPageSetup;
        BarButtonItem bbiSavePageSetup;

        BarSubItem bsiReports;
        BarItem cbiPrintColorSchemaBW;
        BarItem cbiPrintColorSchemaGS;
        BarItem cbiPrintColorSchemaFC; 
        #endregion

        public SchedulerRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreatePageSetupMenu(form);
            CreateReportsMenu(form);
            EnableReportsMenu();
        }

        #region Properties
        public SchedulerControl SchedulerControl { get { return fSchedulerControl; } set { fSchedulerControl = value; } }
        public IDemoSchedulerReport SchedulerReport {
            get { return fSchedulerReport; }
            set {
                fSchedulerReport = value;
                EnableReportsMenu();
            }
        }
        #endregion

        protected internal virtual void EnableReportsMenu() {
            ShowReservGroup1(SchedulerReport != null);
        }
        protected internal virtual void CreatePageSetupMenu(RibbonMainForm form) {
            bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup", bbiPageSetup_Click);
            RibbonControl ribbon = form.Ribbon;
            RibbonPageGroup printExportGroup = form.PrintExportGroup;
            AddBarItemInRibbon(ribbon, printExportGroup, bbiPageSetup, true);
            bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup", bbiLoadPageSetup_Click);
            AddBarItemInRibbon(ribbon, printExportGroup, bbiLoadPageSetup);
            bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup", bbiSavePageSetup_Click);
            AddBarItemInRibbon(ribbon, printExportGroup, bbiSavePageSetup);
        }
        protected internal virtual BarButtonItem CreateButtonItem(string caption, string imageName, ItemClickEventHandler clickHandler) {
            BarButtonItem item = new BarButtonItem(this.Manager, caption);
            MainFormHelper.SetBarButtonImage(item, imageName);
            //bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraScheduler.Demos.Images.Blending.png", typeof(frmMain).Assembly);
            item.ItemClick += clickHandler;
            return item;
        }
        protected internal virtual void AddBarItemInRibbon(RibbonControl ribbon, RibbonPageGroup group, BarItem item) {
            AddBarItemInRibbon(ribbon, group, item, false);
        }
        void AddBarItemInRibbon(RibbonControl ribbon, RibbonPageGroup group, BarItem item, bool beginGroup) {
            ribbon.Items.Add(item);
            group.ItemLinks.Add(item, beginGroup);
        }
        void bbiPageSetup_Click(object sender, ItemClickEventArgs e) {
            try {
                SchedulerControl.ShowPrintOptionsForm();
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        void bbiLoadPageSetup_Click(object sender, ItemClickEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            try {
                dlg.CheckPathExists = true;
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                SchedulerControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }

            finally {
                dlg.Dispose();
            }
        }
        void bbiSavePageSetup_Click(object sender, ItemClickEventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            try {
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                SchedulerControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                dlg.Dispose();
            }
        }

        protected internal virtual void CreateReportsMenu(RibbonMainForm form) {
            bsiReports = new BarSubItem(this.Manager, "Print Color Schemas");
            bsiReports.Popup += OnPopupReports;
            MainFormHelper.SetBarButtonImage(bsiReports, "PrintColorSchemas");
            RibbonControl ribbon = form.Ribbon;

            RibbonPageGroup reportsGroup = form.ReservGroup1;
            reportsGroup.Text = "Reports";
            AddBarItemInRibbon(ribbon, reportsGroup, bsiReports);

            cbiPrintColorSchemaFC = new CheckBarItemWithPrintColorSchema(this.Manager, "Full Color", cbiPrintColorSchema_Click, PrintColorSchema.FullColor);
            cbiPrintColorSchemaGS = new CheckBarItemWithPrintColorSchema(this.Manager, "Grayscale", cbiPrintColorSchema_Click, PrintColorSchema.GrayScale);
            cbiPrintColorSchemaBW = new CheckBarItemWithPrintColorSchema(this.Manager, "Black And White", cbiPrintColorSchema_Click, PrintColorSchema.BlackAndWhite);

            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaFC);
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaGS);
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaBW);
        }
        protected internal virtual void AddCheckBarItemInSubItem(RibbonControl ribbon, BarSubItem subItem, BarItem item) {
            ribbon.Items.Add(item);
            subItem.ItemLinks.Add(item);
        }
        void OnPopupReports(object sender, EventArgs e) {
            BarSubItem items = sender as BarSubItem;
            if (items == null)
                return;
            foreach (BarItemLink item in items.ItemLinks) {
                CheckBarItemWithPrintColorSchema aItem = item.Item as CheckBarItemWithPrintColorSchema;
                if (aItem != null)
                    aItem.Checked = aItem.PrintColorSchema.Equals(DemoUtils.ReportPrintColorSchema);
            }
        }
        void cbiPrintColorSchema_Click(object sender, ItemClickEventArgs e) {
            CheckBarItemWithPrintColorSchema schemaItem = (CheckBarItemWithPrintColorSchema)e.Item;
            if (SchedulerReport != null) {
                DemoUtils.ReportPrintColorSchema = schemaItem.PrintColorSchema;
                SchedulerReport.UpdateActiveReport();
            }
        }
	}
}


