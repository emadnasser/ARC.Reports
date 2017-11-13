using System;

using DevExpress.Utils;

using DevExpress.XtraSpellChecker;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.About;


namespace DevExpress.XtraRichEdit.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        #region Properties
        protected override string DemoName { get { return "XtraRichEdit Main Demo (C# code)"; } }
        #endregion

        protected override void ShowAbout() {
            RichEditControl.About();
        }
        protected override string ProductName { get { return "XtraRichEdit"; } }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResources("DevExpress.XtraRichEdit.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new RichEditRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, groupControl, caption, RibbonMenuManager as RichEditRibbonMenuManager);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            CultureInfo culture = CultureInfo.InvariantCulture;
            sharedDictionaryStorage.Dictionaries.Clear();
            SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), culture);
            dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt");
            sharedDictionaryStorage.Dictionaries.Add(dictionary);
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), culture);
            sharedDictionaryStorage.Dictionaries.Add(customDictionary);
        }
    }

    public class RichEditRibbonMenuManager : RibbonMenuManager {
        RichEditControl fRichEditControl;

        //BarItem miPageSetup;
        //BarItem miLoadPageSetup;
        //BarItem miSavePageSetup;

        //BarItem miPrintPreview;
        //BarItem miPrint;
        //BarSubItem miPrintExport;

        public RichEditRibbonMenuManager(RibbonMainForm form)
            : base(form) {

            //miPageSetup = CreateButtonItem("P&age Setup...", new ItemClickEventHandler(miPageSetup_Click));
            //miLoadPageSetup = CreateButtonItem("&Load page setup...", new ItemClickEventHandler(miLoadPageSetup_Click));
            //miSavePageSetup = CreateButtonItem("&Save page setup...", new ItemClickEventHandler(miSavePageSetup_Click));

            //miPrintPreview = CreateButtonItem("&Print Preview", new ItemClickEventHandler(miPrintPreview_Click));
            //miPrint = CreateButtonItem("P&rint...", new ItemClickEventHandler(miPrint_Click));

            //miPrintExport = new BarSubItem(manager, "&Print and Export");
            ////miPrintExport.ItemLinks.Add(miPageSetup);
            ////miPrintExport.ItemLinks.Add(miLoadPageSetup);
            ////miPrintExport.ItemLinks.Add(miSavePageSetup);


            //miPrintExport.ItemLinks.Add(miPrintPreview).BeginGroup = true;
            //miPrintExport.ItemLinks.Add(miPrint);
            //EnablePrintMenu();


            //miFeatures.Caption = "XtraRichEdit Features";
            //miAboutProduct.Caption = "About &XtraRichEdit";

            //AddItems();
        }

        public RichEditControl RichEditControl {
            get { return fRichEditControl; }
            set {
                fRichEditControl = value;
                //EnablePrintMenu();
            }
        }

        //protected override void AddItems() {
        //    if (miPrintExport == null)
        //        return;

        //    MainMenu.ItemLinks.Add(miLookAndFeel);
        //    MainMenu.ItemLinks.Add(miView);
        //    MainMenu.ItemLinks.Add(miPrintExport);
        //    MainMenu.ItemLinks.Add(miHelp);
        //    InitLookAndFeelMenu();
        //}

        //void EnablePrintMenu() {
        //    if (miPrintExport != null)
        //        miPrintExport.Enabled = (RichEditControl != null);
        //}
        //BarItem CreateButtonItem(string caption, ItemClickEventHandler clickHandler) {
        //    BarButtonItem item = new BarButtonItem(this.manager, caption);
        //    item.ItemClick += clickHandler;
        //    return item;
        //}
        //private void miLoadPageSetup_Click(object sender, ItemClickEventArgs e) {
            /*
            OpenFileDialog dlg = new OpenFileDialog();
            try {
                dlg.CheckPathExists = true;
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                RichEditControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }

            finally {
                dlg.Dispose();
            }
            */
        //}

        //private void miSavePageSetup_Click(object sender, ItemClickEventArgs e) {
            /*
            SaveFileDialog dlg = new SaveFileDialog();
            try {
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                RichEditControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                dlg.Dispose();
            }
            */
        //}

        //private void miPageSetup_Click(object sender, ItemClickEventArgs e) {
            /*
            try {
                RichEditControl.ShowPrintOptionsForm();
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
            */
        //}
        //private void miPrintPreview_Click(object sender, ItemClickEventArgs e) {
        //    try {
        //        RichEditControl.ShowPrintPreview();
        //    }
        //    catch (Exception ex) {
        //        XtraMessageBox.Show(ex.Message, Application.ProductName);
        //    }
        //}
        //private void miPrint_Click(object sender, ItemClickEventArgs e) {
        //    RichEditControl.ShowPrintDialog();
        //}
        //protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
        //    System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraRichEdit");
        //}
        //protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
        //    DevExpress.Utils.About.AboutForm.Show(typeof(DevExpress.XtraRichEdit.RichEditControl), DevExpress.Utils.About.ProductKind.XtraRichEdit, DevExpress.Utils.About.ProductInfoStage.Registered);
        //}
    }
}
