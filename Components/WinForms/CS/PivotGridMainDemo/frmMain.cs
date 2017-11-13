using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using System;
using System.Windows.Forms;
using DevExpress.Utils.About;

namespace DevExpress.XtraPivotGrid.Demos {
    public class frmMain : RibbonMainForm {
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName { get { return "XtraPivotGrid"; } }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption, Control notePanel) {
            DemosInfo.Show(name, group, caption, notePanel, RibbonMenuManager as PivotGridRibbonMenuManager);
        }
        protected override string DemoName { get { return "XtraPivotGrid Features Demo (" + DemoHelper.GetLanguageString(typeof(frmMain).Assembly) + " code)"; } }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new PivotGridRibbonMenuManager(this);
        }
        protected override void ShowAbout() {
            PivotGridControl.About();
        }
    }
}
