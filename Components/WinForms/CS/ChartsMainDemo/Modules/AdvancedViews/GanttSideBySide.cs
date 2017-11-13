using System;
using DevExpress.Utils;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	public partial class GanttSideBySideDemo : ChartDemoBase2D {
		ChartControl chart;
        protected override DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.False; } }
        public override ChartControl ChartControl { get { return chart; } }

		public GanttSideBySideDemo() {
			InitializeComponent();
		}

		protected override void InitControls() {
			base.InitControls();            
			ShowLabels = false;
		}
		protected override DXPopupMenu ConstructPopupMenu(object obj, ChartControl chartControl) {
			return DXMenuHelper.ConstructSideBySideGanttMenu(obj, chartControl);
		}
    }
}

