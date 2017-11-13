using DevExpress.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;

namespace DevExpress.XtraTreeMap.Demos {
    public class frmMain : RibbonMainForm {
        protected override string DemoName { get { return "XtraTreeMap Features Demo (C# code)"; } }
        protected override string ProductName { get { return "XtraTreeMap"; } }

        protected override void ShowAbout() {
            TreeMapControl.About();
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraTreeMap.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.DoShowModule(name, group, caption, RibbonMenuManager);
        }
    }    
}
