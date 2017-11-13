using System;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class DisplayPatterns : ChartBasePage {
    static readonly string[] SeriesLabelPatternItems = new string[] { "{V:## ##0.0}", "{A}", "{V}", "{A}: {V}", "{S}" };
    static readonly string[] LegendPatternItems = new string[] { "{A}", "{V}", "{A}: {V}", "{S}" };
    static readonly string[] AxisXPatternItems = new string[] { "{A}", "Country: {A}" };
    static readonly string[] AxisYPatternItems = new string[] { "{V:#,0}", "{V}" };

    SeriesLabelBase Label { get { return WebChartControl1.Series[0].Label; } }
    Series Series { get { return WebChartControl1.Series[0]; } }
    AxisBase AxisX { get { return ((XYDiagram)WebChartControl1.Diagram).AxisX; } }
    AxisBase AxisY { get { return ((XYDiagram)WebChartControl1.Diagram).AxisY; } }


    void InitControls() {
        ComboBoxHelper.PrepareComboBox(cbSeriesLabels, SeriesLabelPatternItems);
        ComboBoxHelper.PrepareComboBox(cbLegend, LegendPatternItems);
        ComboBoxHelper.PrepareComboBox(cbAxisX, AxisXPatternItems);
        ComboBoxHelper.PrepareComboBox(cbAxisY, AxisYPatternItems);
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack) {
            Label.TextPattern = cbSeriesLabels.Text;
            Series.LegendTextPattern = cbLegend.Text;
            AxisX.Label.TextPattern = cbAxisX.Text;
            AxisY.Label.TextPattern = cbAxisY.Text;
        }
        else {
            InitControls();
        }
    }
    protected void callbackPanel_Callback(object source, CallbackEventArgsBase e) {
        switch (e.Parameter) {
            case "label":
                Label.TextPattern = cbSeriesLabels.Text;
                break;
            case "legend":
                Series.LegendTextPattern = cbLegend.Text;
                break;
            case "axisx":
                AxisX.Label.TextPattern = cbAxisX.Text;
                break;
            case "axisy":
                AxisY.Label.TextPattern = cbAxisY.Text;
                break;
        }
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}
