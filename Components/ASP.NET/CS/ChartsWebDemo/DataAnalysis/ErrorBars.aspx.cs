using System;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class ErrorBars : ChartBasePage {
    readonly Color indicatorColor = Color.Black;

    Series Series { get { return WebChartControl1.Series[0]; } }

    void SetDirection() {
        string selectedDirection = (string)cmbDirection.SelectedItem.Value;
        XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)WebChartControl1.Series[0].View;
        var indicator = (DevExpress.XtraCharts.ErrorBars)view.Indicators[0];
        switch (selectedDirection) {
            case "":
                return;
            case "Both":
                indicator.Direction = ErrorBarDirection.Both;
                break;
            case "Minus":
                indicator.Direction = ErrorBarDirection.Minus;
                break;
            case "Plus":
                indicator.Direction = ErrorBarDirection.Plus;
                break;
            default:
                throw new Exception(string.Format("The {0} error bar direction is unknown.", selectedDirection));
        }
    }
    void SetEndStyle() {
        string selectedStyle = (string)cmbEndStyle.SelectedItem.Value;
        XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)WebChartControl1.Series[0].View;
        if (view.Indicators.Count == 0)
            return;
        var indicator = (DevExpress.XtraCharts.ErrorBars)view.Indicators[0];
        switch (selectedStyle) {
            case "":
                return;
            case "Cap":
                indicator.EndStyle = ErrorBarEndStyle.Cap;
                break;
            case "No Cap":
                indicator.EndStyle = ErrorBarEndStyle.NoCap;
                break;
            default:
                throw new Exception(string.Format("The {0} error bar end style is unknown.", selectedStyle));
        }
    }
    void SetSeriesView() {
        string selectedViewString = (string)cmbSeriesView.SelectedItem.Value;
        switch (selectedViewString) {
            case "":
                return;
            case "Bar":
                WebChartControl1.Series[0].ChangeView(ViewType.Bar);
                break;
            case "Point":
                WebChartControl1.Series[0].ChangeView(ViewType.Point);
                break;
            default:
                throw new Exception(string.Format("The {0} series view is unknown.", selectedViewString));
        }
    }
    void CreateIndicator() {
        string selectedErrorBarKind = (string)cmbKind.SelectedItem.Value;
        XYDiagram2DSeriesViewBase view = (XYDiagram2DSeriesViewBase)WebChartControl1.Series[0].View;
        view.Indicators.Clear();
        switch (selectedErrorBarKind) {
            case "":
                return;
            case "Fixed Values":
                view.Indicators.Add(new FixedValueErrorBars() { NegativeError = 1, PositiveError = 3, Color = this.indicatorColor });
                break;
            case "Percentage":
                view.Indicators.Add(new PercentageErrorBars() { Percent = 10, Color = this.indicatorColor });
                break;
            case "Standard Deviation":
                view.Indicators.Add(new StandardDeviationErrorBars() { Multiplier = 1, Color = this.indicatorColor });
                break;
            case "Standard Error":
                view.Indicators.Add(new StandardErrorBars() { Color = this.indicatorColor });
                break;
            case "Data Source":
                view.Indicators.Add(new DataSourceBasedErrorBars() { NegativeErrorDataMember = "NegativeError", PositiveErrorDataMember = "PositiveError", Color = this.indicatorColor });
                WebChartControl1.RefreshData();
                break;
            default:
                throw new Exception(string.Format("The {0} error bar kind is unknown.", selectedErrorBarKind));
        }
        SetDirection();
        SetEndStyle();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            SetSeriesView();
            CreateIndicator();
            SetEndStyle();
            SetDirection();
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "ChangeSeriesView")
            SetSeriesView();
        else if (e.Parameter == "ChangeErrorBarsKind")
            CreateIndicator();
        else if (e.Parameter == "ChangeEndStyle")
            SetEndStyle();
        else if (e.Parameter == "ChangeErrorBarsDirection")
            SetDirection();
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}
