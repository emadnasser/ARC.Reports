using System;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	public partial class EmptyPointsDemo : ChartDemoBase {
		ChartControl chart;

		public override ChartControl ChartControl { get { return chart; } }

		public EmptyPointsDemo() {
			InitializeComponent();
		}

        bool IsFullStackedView(SeriesViewBase view) {
            return view is FullStackedAreaSeriesView || view is FullStackedArea3DSeriesView ||
                view is FullStackedSplineAreaSeriesView || view is FullStackedSplineArea3DSeriesView ||
                view is FullStackedLineSeriesView || view is FullStackedLine3DSeriesView;
        }
        void UpdateAxesLabelsPattern(AxisLabel axisXLabel, AxisLabel axisYLabel, SeriesViewBase view) {
            axisXLabel.TextPattern = "{A:m}";
            if (IsFullStackedView(view))
                axisYLabel.TextPattern = "{V:P0}";
            else
                axisYLabel.TextPattern = "{V:G}";
        }
        void UpdateSeries(Series series) {
            if (IsFullStackedView(series.View))
                series.Label.TextPattern = "{VP:P0}";
            else
                series.Label.TextPattern = "{V:G2}";
            ISupportTransparency supportTransparency = series.View as ISupportTransparency;
            if (supportTransparency != null)
                if  ((series.View is AreaSeriesView) || (series.View is Area3DSeriesView))
                    supportTransparency.Transparency = 135;
                else
                    supportTransparency.Transparency = 0;
        }
        void comboBoxEditViewType_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType viewType = ViewType.Line;
            switch (comboBoxEditViewType.SelectedItem.ToString()) {
                case "Lines":
                    viewType = ViewType.Line;
                    break;
                case "Stacked Lines":
                    viewType = ViewType.StackedLine;
                    break;
                case "Full-Stacked Lines":
                    viewType = ViewType.FullStackedLine;
                    break;
                case "Step Lines":
                    viewType = ViewType.StepLine;
                    break;
                case "Areas":
                    viewType = ViewType.Area;
                    break;
                case "Stacked Areas":
                    viewType = ViewType.StackedArea;
                    break;
                case "Full-Stacked Areas":
                    viewType = ViewType.FullStackedArea;
                    break;
                case "Step Areas":
                    viewType = ViewType.StepArea;
                    break;
                case "3D Lines":
                    viewType = ViewType.Line3D;
                    break;
                case "3D Stacked Lines":
                    viewType = ViewType.StackedLine3D;
                    break;
                case "3D Full-Stacked Lines":
                    viewType = ViewType.FullStackedLine3D;
                    break;
                case "3D Step Lines":
                    viewType = ViewType.StepLine3D;
                    break;
                case "3D Areas":
                    viewType = ViewType.Area3D;
                    break;
                case "3D Stacked Areas":
                    viewType = ViewType.StackedArea3D;
                    break;
                case "3D Full-Stacked Areas":
                    viewType = ViewType.FullStackedArea3D;
                    break;
                case "3D Step Areas":
                    viewType = ViewType.StepArea3D;
                    break;
                case "Spline":
                    viewType = ViewType.Spline;
                    break;
                case "Spline Area":
                    viewType = ViewType.SplineArea;
                    break;
                case "Stacked Spline":
                    viewType = ViewType.StackedSplineArea;
                    break;
                case "Full-Stacked Spline":
                    viewType = ViewType.FullStackedSplineArea;
                    break;
                case "Spline 3D":
                    viewType = ViewType.Spline3D;
                    break;
                case "Spline Area 3D":
                    viewType = ViewType.SplineArea3D;
                    break;
                case "Stacked Spline 3D":
                    viewType = ViewType.StackedSplineArea3D;
                    break;
                case "Full-Stacked Spline 3D":
                    viewType = ViewType.FullStackedSplineArea3D;
                    break;
            }
            foreach (Series series in chart.Series) {
                series.ChangeView(viewType);
                UpdateSeries(series);
            }
            Diagram3D diagram = chart.Diagram as Diagram3D;
            if(diagram != null) {
                diagram.ZoomPercent = 120;
                diagram.RuntimeRotation = true;
                diagram.RuntimeScrolling = true;
                diagram.RuntimeZooming = true;
                XYDiagram3D xyDiagram3D = diagram as XYDiagram3D;
                if (xyDiagram3D != null)
                    UpdateAxesLabelsPattern(xyDiagram3D.AxisX.Label, xyDiagram3D.AxisY.Label, chart.Series[0].View);
            }
            else {
                XYDiagram xyDiagram = chart.Diagram as XYDiagram;
                if (xyDiagram != null)
                    UpdateAxesLabelsPattern(xyDiagram.AxisX.Label, xyDiagram.AxisY.Label, chart.Series[0].View);
            }
            ChartControl.Animate();          
        }
    }
}
