using DevExpress.Utils;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Utils.About;
using DevExpress.Xpo.Demos.Properties;
using DevExpress.DemoData.Core;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.Xpo.Demos {
    public partial class frmMain : RibbonMainForm, IWhatsThisProvider {
        public const string DemoNameConst = "Tutorial examples for the " + AssemblyInfo.SRAssemblyXpo;
        protected override string DemoName { get { return DemoNameConst; } }
        protected bool fHintVisible = true;
        FormTutorialInfo ftInfo = new FormTutorialInfo();
        ButtonBarItem fbbiWizard;
        public ButtonBarItem bbiWizard { get { return fbbiWizard; } }

        public frmMain() {
            InitializeComponent();
            ftInfo.SourceFileComment = "//";
            ftInfo.SourceFileType = SourceFileType.CS;
            pnlCaption.ShowLogo(false);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            RibbonMenuManager mng = new RibbonMenuManager(this);
            ReservGroup1.Text = "What's this?";
            fbbiWizard = new ButtonBarItem(Manager, string.Empty, new ItemClickEventHandler(bbiWizard_Click));
            ReservGroup1.ItemLinks.Add(bbiWizard);
            SetWhatsThisButtonActive();
            this.Resize += new System.EventHandler(this.MainTutorialForm_Resize);
            return mng;
        }
        protected override void SetFormParam() {
            accordionControl1.Parent.Width = 320;
            Icon = Resources.AppIcon;
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            TutorialsInfo.ShowModule(name, group, caption, RibbonMenuManager);

        }
        protected override void FillNavBar() {
            base.FillNavBar();
            TutorialRegistration.Register();
            //foreach(AccordionControlElement nbg in accordionControl1.Elements) {
            //    nbg.Hint = nbg.Text;
            //}
        }

        protected override void ShowAbout() {
            AboutHelper.Show(ProductKind.XPO, new ProductStringInfoWin(ProductInfoHelper.WinXPO));
        }

        public void EnableService(bool val) {
            accordionControl1.Enabled = val;            
            foreach(BarItem item in Manager.Items)
                if(!item.Equals(bbiWizard))
                    item.Enabled = val;
            if(val) {            
                SetWhatsThisButtonActive();
            } else {                
                SetWhatsThisButtonNotActive();
            }
        }

        protected override bool AllowNavBarFilter { get { return false; } }

        void SetWhatsThisButtonActive() {
            bbiWizard.BeginUpdate();
            bbiWizard.Caption = "Show code...";
            bbiWizard.Glyph = Resources.Wizard_16x16;
            bbiWizard.LargeGlyph = Resources.ShowCode_32x32;
            bbiWizard.EndUpdate();
        }

        void SetWhatsThisButtonNotActive() {
            bbiWizard.BeginUpdate();
            bbiWizard.Caption = "Stop";
            bbiWizard.Glyph = Resources.Wizard_16x16;
            bbiWizard.LargeGlyph = Resources.ShowCode_32x32;
            bbiWizard.EndUpdate();
        }

        void bbiWizard_Click(object sender, ItemClickEventArgs e) {
            TutorialControl tc = ModulesInfo.Instance.CurrentModuleBase.TModule as TutorialControl;
            if(tc != null) tc.ShowWhatsThis();            
        }

        private void MainTutorialForm_Resize(object sender, System.EventArgs e) {
            TutorialControl tc = ModulesInfo.Instance.CurrentModuleBase.TModule as TutorialControl;
            if(tc != null) tc.DisableWhatsThis();
        }

        #region IWhatsThisProvider Members

        UserControl IWhatsThisProvider.CurrentModule {
            get { return (UserControl)ModulesInfo.Instance.CurrentModuleBase.TModule; }
        }

        ImageShaderBase IWhatsThisProvider.CurrentShader {
            get { return new ImageShaderDisable(); }
        }

        bool IWhatsThisProvider.HintVisible {
            get { return fHintVisible; }
            set { fHintVisible = value; }
        }

        FormTutorialInfo IWhatsThisProvider.TutorialInfo {
            get { return ftInfo; }
        }
        #endregion

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            WebDevServerHelper.CloseWebServers();
        }
    }
}
