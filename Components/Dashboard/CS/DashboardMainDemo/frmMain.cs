using System;
using DevExpress.DashboardWin;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;
using DevExpress.Utils;

namespace DashboardMainDemo {
    public partial class frmMain : RibbonMainForm {
        public frmMain() {
            InitializeComponent();
        }
        protected override bool IsAllowAboutModule { get { return false; } }
        protected override string DemoName { 
            get { return string.Format("Dashboard Features Demo ({0} code)", DemoHelper.GetLanguageString(typeof(frmMain).Assembly)); } 
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.Show(name, group, caption, RibbonMenuManager);
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DashboardMainDemo.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowAbout() {
            DashboardDesigner.About();
        }
    }
}
