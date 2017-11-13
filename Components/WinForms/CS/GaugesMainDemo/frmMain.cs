using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Utils.Frames;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool showOutdated = true;
        public frmMain(string[] arguments)
            : base(arguments) {
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            foreach(string name in arguments)
                if(name == "-demo") showOutdated = false;
        }
        protected override string DemoName { get { return "The XtraGauge Suite by DevExpress (C# code)"; } }
        protected override string ProductName { get { return "XtraGauges"; } }
        protected override void ShowAbout() {
            GaugeControl.About();
        }
        protected override void SetFormParam() {
            //this.accordionControl1.Parent.Width = 210;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraGauges.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new GaugesRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated);
        }
    }
}
