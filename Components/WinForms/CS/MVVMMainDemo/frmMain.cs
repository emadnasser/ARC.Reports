namespace DevExpress.MVVM.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.MVVM.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName {
            get { return "MVVM"; }
        }
        protected override string DemoName { 
            get { return "Application Infrastructural MVVM Pattern Demo (C# code)"; } 
        }
        protected override void ShowAbout() {
            DevExpress.Utils.MVVM.MVVMContext.About();
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DevExpress.DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, true, DevExpress.XtraNavBar.NavBarImage.Large);
        }
    }
}
