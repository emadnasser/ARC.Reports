using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Snap;
using DevExpress.Utils.About;

namespace SnapDemos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            InitializeComponent();
        }
        protected override string DemoName { get { return "Snap Features Demo (" + DemoHelper.GetLanguageString(typeof(frmMain).Assembly) + " code)"; } }
        protected override string ProductName { get { return "SnapForWin"; } }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.Show(name, group, caption, RibbonMenuManager);
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("SnapDemos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowAbout() {
            SnapControl.About();
        }
        protected override bool IsAllowAboutModule { get { return false; } }
    }
}
