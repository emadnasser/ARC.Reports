using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.About;

namespace DevExpress.XtraTreeList.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            //this.navBarControl1.Parent.Width = 200;
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraTreeList.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName { get { return "The XtraTreeList Suite by DevExpress (C# code)"; } }
        protected override string ProductName { get { return "XtraTreeList"; } }
        protected override void ShowAbout() {
            TreeList.About();
        }

        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new TreeListRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager as TreeListRibbonMenuManager);
        }

        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, true, DevExpress.XtraNavBar.NavBarImage.Large);
        }
    }
}
