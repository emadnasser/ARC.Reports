using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class SecondaryAxes : ChartBasePage {
    const string SecondaryPostfixX = " (Secondary Axis X)";
    const string SecondaryPostfixY = " (Secondary Axis Y)";
    const string PrimaryPostfixX = " (Primary Axis X)";
    const string PrimaryPostfixY = " (Primary Axis Y)";
    const string PrimarySeriesName = "Series 1";
    const string SecondarySeriesName = "Series 2";
    const int LineChart = 0;
    const int BarChart = 1;
    const int PrimaryAxis = 0;
    const int SecondaryAxis = 1;

    XYDiagram Diagram { get { return (XYDiagram)WebChartControl1.Diagram; } }
    SecondaryAxisX SecondaryAxisX { get { return Diagram.SecondaryAxesX.Count > 0 ? Diagram.SecondaryAxesX[0] : null; } }
    SecondaryAxisY SecondaryAxisY { get { return Diagram.SecondaryAxesY.Count > 0 ? Diagram.SecondaryAxesY[0] : null; } }
    Series PrimarySeries { get { return WebChartControl1.GetSeriesByName(PrimarySeriesName); } }
    Series SecondarySeries { get { return WebChartControl1.GetSeriesByName(SecondarySeriesName); } }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            InitializeStartState();
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareChartTypeComboBox(cbChartType);
            ComboBoxHelper.PrepareSeriesAxisXComboBox(cbSeriesAxisX);
            ComboBoxHelper.PrepareSeriesAxisYComboBox(cbSeriesAxisY);
        }
    }
    void AttachSecondaryAxisX() {
        if(SecondaryAxisX == null)
            return;
        SecondaryAxisX.Visibility = DefaultBoolean.True;
        ((XYDiagramSeriesViewBase)SecondarySeries.View).AxisX = SecondaryAxisX;
        SecondaryAxisX.Title.Text = SecondarySeriesName + SecondaryPostfixX;
        Diagram.AxisX.Title.Text = PrimarySeriesName + PrimaryPostfixX;
    }
    void AttachSecondaryAxisY() {
        if(SecondaryAxisY == null)
            return;       
        SecondaryAxisY.Visibility = DefaultBoolean.True;
        ((XYDiagramSeriesViewBase)SecondarySeries.View).AxisY = SecondaryAxisY;
        SecondaryAxisY.Title.Text = SecondarySeriesName + SecondaryPostfixY;
        Diagram.AxisY.Title.Text = PrimarySeriesName + PrimaryPostfixY;
    }
    void DetachSecondaryAxisX() {
        SecondaryAxisX.Visibility = DefaultBoolean.False;
        ((XYDiagramSeriesViewBase)SecondarySeries.View).AxisX = Diagram.AxisX;
        Diagram.AxisX.Title.Text = PrimarySeriesName + ", " + SecondarySeriesName + PrimaryPostfixX;
    }
    void DetachSecondaryAxisY() {
        SecondaryAxisY.Visibility = DefaultBoolean.False;
        ((XYDiagramSeriesViewBase)SecondarySeries.View).AxisY = Diagram.AxisY;
        Diagram.AxisY.Title.Text = PrimarySeriesName + ", " + SecondarySeriesName + PrimaryPostfixY;
    }
    void InitializeStartState() {
        Diagram.SecondaryAxesX.Add(new SecondaryAxisX("axisX"));
        Diagram.SecondaryAxesY.Add(new SecondaryAxisY("axisY"));
        SecondaryAxisX.Title.Visibility = DefaultBoolean.True;
        SecondaryAxisY.Title.Visibility = DefaultBoolean.True;
        DetachSecondaryAxisX();
        AttachSecondaryAxisY();
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    void PerformShowAxisXAction() {
        if (cbSeriesAxisX.SelectedIndex == PrimaryAxis)
            DetachSecondaryAxisX();
        else if (cbSeriesAxisX.SelectedIndex == SecondaryAxis)
            AttachSecondaryAxisX();        
    }
    void PerformShowAxisYAction() {
        if (cbSeriesAxisY.SelectedIndex == PrimaryAxis)
            DetachSecondaryAxisY();
        else if (cbSeriesAxisY.SelectedIndex == SecondaryAxis)
            AttachSecondaryAxisY();
    }    
    void PerformChangeChartTypeAction() {
        ViewType viewType = GetCurrentViewType();
        foreach(Series series in WebChartControl1.Series)
            series.ChangeView(viewType);
    }
    ViewType GetCurrentViewType() {
        if (cbChartType.SelectedIndex == LineChart)
            return ViewType.Line;
        if (cbChartType.SelectedIndex == BarChart)
            return ViewType.Bar;
        return ViewType.Line;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        switch (e.Parameter) {
            case "ShowLabels":
                PerformShowLabelsAction();
                break;
            case "ChangeChartType":
                PerformChangeChartTypeAction();
                break;
            case "ChangeSeriesTwoAxisX":
                PerformShowAxisXAction();
                break;
            case "ChangeSeriesTwoAxisY":
                PerformShowAxisYAction();
                break;
        }
    }
}
