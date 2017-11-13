using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using DevExpress.Utils;

public partial class EmptyPoints : ChartBasePage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareViewTypeComboBox(cbViewType);
        }
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void UpdateAxes(AxisBase axisX, AxisBase axisY, SeriesViewBase view) {
        axisX.Label.TextPattern = "{A:m}";
        if (IsFullStackedView(view)) {
            axisY.Label.TextPattern = "{V:P0}";
        }
        else
            axisY.Label.TextPattern = "{V:G}";
    }
    void UpdateSeries(Series series) {
        if (IsFullStackedView(series.View)) {
            series.Label.TextPattern = "{VP:P0}";
        }
        else
            series.Label.TextPattern = "{V:G}";
        ISupportTransparency supportTransparency = series.View as ISupportTransparency;
        if (supportTransparency != null)
            if  ((series.View is AreaSeriesView) || (series.View is Area3DSeriesView))
                supportTransparency.Transparency = 135;
            else
                supportTransparency.Transparency = 0;
    }
    void PerformViewTypeAction() {
        ViewType viewType = ViewType.Line;
        switch ((string)cbViewType.SelectedItem.Text) {
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
        foreach (Series series in WebChartControl1.Series) {
            series.ChangeView(viewType);
            UpdateSeries(series);
        }
        Diagram3D diagram = WebChartControl1.Diagram as Diagram3D;
        if (diagram != null) {
            diagram.ZoomPercent = 120;
            XYDiagram3D xyDiagram3D = diagram as XYDiagram3D;
            if (xyDiagram3D != null)
                UpdateAxes(xyDiagram3D.AxisX, xyDiagram3D.AxisY, WebChartControl1.Series[0].View);
        }
        else {
            XYDiagram xyDiagram = WebChartControl1.Diagram as XYDiagram;
            if (xyDiagram != null)
                UpdateAxes(xyDiagram.AxisX, xyDiagram.AxisY, WebChartControl1.Series[0].View);
        }
    }
    bool IsFullStackedView(SeriesViewBase view) {
        return view is FullStackedAreaSeriesView || view is FullStackedArea3DSeriesView ||
            view is FullStackedSplineAreaSeriesView || view is FullStackedSplineArea3DSeriesView ||
            view is FullStackedLineSeriesView || view is FullStackedLine3DSeriesView;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ViewType")
            PerformViewTypeAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
}
