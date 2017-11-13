using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Utils.Frames;
using DevExpress.XtraEditors;

namespace DevExpress.XtraNavBar.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool showOutdated = false;
        public frmMain(string[] arguments) : base(arguments) {
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
        }
        protected override string DemoName { get { return "The XtraNavBar Suite Demo (C# code)"; } }
        protected override string ProductName { get { return "XtraNavBar"; } }
        protected override void ShowAbout() {
            NavBarControl.About();
        }
        protected override void SetFormParam() {
            this.MinimumSize = new Size(800, 600);
            this.Icon = ResourceImageHelper.CreateIconFromResources("NavBarMainDemo.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated);
        }
    }
}
