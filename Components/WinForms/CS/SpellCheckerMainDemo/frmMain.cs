using System;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraSpellChecker.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain()
            : base() {
        }

        #region Properties
        protected override string DemoName { get { return "XtraSpellChecker Features Demo (C# code)"; } }
        #endregion

        protected override void SetFormParam() {
            this.MinimumSize = new System.Drawing.Size(600, 500);
            //this.accordionControl1.Parent.Width = 176;
            this.Icon = ResourceImageHelper.CreateIconFromResources("DevExpress.XtraSpellChecker.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName { get { return "XtraSpellChecker"; } }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new SpellCheckerRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager as SpellCheckerRibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText, true, NavBarImage.Small);
        }
        protected override void ShowAbout() {
            SpellChecker.About();
        }
    }
}
