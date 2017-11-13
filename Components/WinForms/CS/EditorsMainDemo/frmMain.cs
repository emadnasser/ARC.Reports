using DevExpress.Utils;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Native;
using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.XtraEditors.Demos {
    public partial class frmMain : RibbonMainForm {
        protected override string DemoName { get { return "The XtraEditors Suite Demo (C# code)"; } }
        protected override string ProductName { get { return "XtraEditors"; } }
        public frmMain() {
			InitializeComponent();
		}
		protected override void SetFormParam() {
            accordionControl1.Parent.Width = 220;
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraEditors.Demos.AppIcon.ico", typeof(frmMain).Assembly);
		}
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void ShowAbout() {
            BaseEdit.About();
        }
	}
}
