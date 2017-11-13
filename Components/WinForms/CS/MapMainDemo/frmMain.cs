using System;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.Utils.About;
using System.Windows.Forms;
using DevExpress.XtraMap.Native;

namespace DevExpress.XtraMap.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            InitializeComponent();
        }

        #region Properties
        new internal BarSubItem ExportToImageExButton { get { return base.ExportToImageExButton; } }
        protected override string DemoName { get { return "Map Control Main Demo (C# code)"; } }
        #endregion

        protected override void WndProc(ref Message msg) {
            if(OverlapFlickeringSolver.ShouldDoWndProc(msg))
                base.WndProc(ref msg);
        }
        protected override void ShowAbout() {
            MapControl.About();
        }        
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraMap.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName { get { return "XtraMap"; } }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new MapRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel, DevExpress.Utils.Frames.ApplicationCaption caption) {
            DemosInfo.DoShowModule(name, groupControl, caption, RibbonMenuManager as MapRibbonMenuManager);
        }

        private void frmMain_Load(object sender, EventArgs e) {
        }
    }
    public class MapRibbonMenuManager : RibbonMenuManager {
        public MapRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            //CreatePageSetupMenu(form);
            //CreateReportsMenu(form);
            //EnableReportsMenu();
        }

        //protected internal virtual void CreatePageSetupMenu(RibbonMainForm form) {
        //    bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup", bbiPageSetup_Click);
        //    RibbonControl ribbon = form.Ribbon;
        //    RibbonPageGroup printExportGroup = form.PrintExportGroup;
        //    AddBarItemInRibbon(ribbon, printExportGroup, bbiPageSetup, true);
        //    bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup", bbiLoadPageSetup_Click);
        //    AddBarItemInRibbon(ribbon, printExportGroup, bbiLoadPageSetup);
        //    bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup", bbiSavePageSetup_Click);
        //    AddBarItemInRibbon(ribbon, printExportGroup, bbiSavePageSetup);
        //}
    }
}
