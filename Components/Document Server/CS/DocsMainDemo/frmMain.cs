using System;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.Utils.About;
using DevExpress.DemoData.Model;
using System.Linq;

namespace DevExpress.Docs.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            InitializeComponent();
        }

        #region Properties
        protected override string ProductName { get { return "DocumentServerForWin"; } }
        protected override string DemoName { get { return "Docs Main Demo (" + DemoUtils.GetLanguageString() + " code)"; } }
        protected override bool ShowPanelDescription { get { return ModulesInfo.Instance.CurrentModuleBase.Description != ""; } }
        #endregion

        protected override Product GetProduct() { return Repository.DocsPlatform.Products.First(p => p.Name == ProductName); }
        protected override void ShowAbout() {
            DevExpress.Utils.About.AboutHelper.Show(ProductKind.DXperienceWin, new ProductStringInfo("DevExpress Universal", ".NET Document Server"));
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new DocsRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.DoShowModule(name, groupControl, caption, RibbonMenuManager as DocsRibbonMenuManager);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            //CultureInfo culture = CultureInfo.InvariantCulture;
            //sharedDictionaryStorage.Dictionaries.Clear();
            //SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), culture);
            //dictionary.AlphabetPath = DemoUtils.GetRelativePath("EnglishAlphabet.txt");
            //sharedDictionaryStorage.Dictionaries.Add(dictionary);
            //SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), culture);
            //sharedDictionaryStorage.Dictionaries.Add(customDictionary);
        }
        protected override void FillNavBar() {
            base.FillNavBar();
        }
    }

    public class DocsRibbonMenuManager : RibbonMenuManager {
        public DocsRibbonMenuManager(RibbonMainForm form)
            : base(form) {
        }
    }
}
