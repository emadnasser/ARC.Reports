using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.About;

namespace DevExpress.XtraLayout.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            //this.navBarControl1.Parent.Width = 176;
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraLayout.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName { get { return "The XtraLayout Control by DevExpress (C# code)"; } }
        protected override string ProductName { get { return "XtraLayoutControl"; } }
        protected override void ShowAbout() {
            LayoutControl.About();
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, true, NavBarImage.Large);
        }

    }
}
