using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.About;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraVerticalGrid.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName { get { return "The XtraVerticalGrid Suite by DevExpress (C# code)"; } }
        protected override string ProductName { get { return "XtraVerticalGrid"; } }
        protected override void ShowAbout() {
            VGridControl.About();
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new VGridRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager as VGridRibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, true, DevExpress.XtraNavBar.NavBarImage.Large);
        }
    }
}
