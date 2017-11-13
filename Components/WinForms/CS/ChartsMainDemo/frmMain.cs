using System;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Frames;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos {
    public partial class frmMain : RibbonMainForm {
        new internal BarSubItem ExportToImageExButton { get { return base.ExportToImageExButton; } }
        protected override string DemoName { get { return "XtraCharts Features Demo"; } }
        protected override string ProductName { get { return "XtraCharts"; } }
        
        public frmMain() {
			InitializeComponent();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
		}

        void Default_StyleChanged(object sender, EventArgs e) {
            if (RibbonMenuManager != null)
                ((ChartRibbonMenuManager)RibbonMenuManager).UpdateMenu();
        }

        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new ChartRibbonMenuManager(this);
        }        
		protected override void SetFormParam() {
            accordionControl1.Parent.Width = 220;
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraCharts.Demos.AppIcon.ico", typeof(frmMain).Assembly);
		}
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            TutorialControl currentModule = DemosInfo.DoShowModule(name, group, caption, RibbonMenuManager as ChartRibbonMenuManager);
            if (currentModule != null) {
                ((ChartRibbonMenuManager)RibbonMenuManager).CurrentModule = currentModule;
                ((ChartRibbonMenuManager)RibbonMenuManager).UpdateMenu();
                ChartDemoBase chartDemoModule = currentModule as ChartDemoBase;
                if (chartDemoModule != null && chartDemoModule.ChartControl != null && chartDemoModule.AnimateChartControlOnDemoAppear)
                    chartDemoModule.ChartControl.Animate();
            }
        }
        protected override void ShowAbout() {
            ChartControl.About();
        }
	}
}
