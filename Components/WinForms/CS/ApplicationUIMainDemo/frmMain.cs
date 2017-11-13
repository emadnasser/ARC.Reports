namespace DevExpress.ApplicationUI.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.ApplicationUI.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName { 
            get { return "Application UI Layout Controls Demo (C# code)"; } 
        }
        protected override string ProductName { 
            get { return "ApplicationUI"; } 
        }
        protected override void ShowAbout() {
            DevExpress.XtraBars.Docking2010.DocumentManager.About();
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DevExpress.DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, true, DevExpress.XtraNavBar.NavBarImage.Large);
        }
    }
}
