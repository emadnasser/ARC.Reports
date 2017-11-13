using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class Summarization : ChartBasePage {
    static SeriesPoint[] CalcStdDev(Series series, object argument, string[] functionArguments, DataSourceValues[] values, object[] colors) {
        double[] amount = new double[values.Length];
        double sum = 0.0;
        for (int i = 0; i < values.Length; i++) {
            amount[i] = Convert.ToDouble(values[i][functionArguments[0]]);
            sum += amount[i];
        }
        double averageAmount = sum / values.Length;
        double standardDeviationSquareSum = 0.0;
        for (int i = 0; i < values.Length; i++) {
            double deviation = amount[i] - averageAmount;
            standardDeviationSquareSum += deviation * deviation;
        }
        return new SeriesPoint[] { new SeriesPoint(argument, Math.Sqrt(standardDeviationSquareSum / values.Length)) };
    }

    protected void Page_Load(object sender, EventArgs e) {
        RegisterSummaryFunction();
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControl1.Series[0].LabelsVisibility == DefaultBoolean.True;
            ComboBoxHelper.PrepareSummaryFunctionsComboBox(cbSummaryFunction);
            cbSummaryFunction.SelectedIndex = 0;
            PerformSummaryFunctionAction();
        }
    }
    void RegisterSummaryFunction() {
        SummaryFunctionArgumentDescription argumentDescription = new SummaryFunctionArgumentDescription("Argument", ScaleType.Numerical);
        WebChartControl1.RegisterSummaryFunction("STDDEV", "STDDEV", 1, new SummaryFunctionArgumentDescription[] { argumentDescription }, CalcStdDev);
    }
    void PerformSummaryFunctionAction() {
        string functionName = cbSummaryFunction.SelectedItem.Text;
        int suffixIndex = functionName.IndexOf(" (Custom)");
        if (suffixIndex >= 0)
            functionName = functionName.Substring(0, suffixIndex);
        switch (functionName) {
            case "SUM":
                WebChartControl1.Titles[0].Text = "Sales Volume";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Volume (USD)";
                break;
            case "MIN":
                WebChartControl1.Titles[0].Text = "Minimal Order Amount";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Amount (USD)";
                break;
            case "MAX":
                WebChartControl1.Titles[0].Text = "Maximal Order Amount";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Amount (USD)";
                break;
            case "AVERAGE":
                WebChartControl1.Titles[0].Text = "Average Order Amount";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Amount (USD)";
                break;
            case "COUNT":
                WebChartControl1.Titles[0].Text = "Overall Orders Count";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Count";
                break;
            case "STDDEV":
                WebChartControl1.Titles[0].Text = "Standard Deviation from Average Order Amout";
                ((XYDiagram)WebChartControl1.Diagram).AxisY.Title.Text = "Deviation (USD)";
                break;
        }
        if (functionName == "COUNT")
            WebChartControl1.Series[0].SummaryFunction = functionName + "()";
        else
            WebChartControl1.Series[0].SummaryFunction = functionName + "([Sum])";
    }
    void PerformShowLabelsAction() {
        foreach (Series series in WebChartControl1.Series)
            series.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        WebChartControl1.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
    }
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        if (e.Parameter == "SummaryFunction")
            PerformSummaryFunctionAction();
        else if (e.Parameter == "ShowLabels")
            PerformShowLabelsAction();
    }
    protected void WebChartControl1_CallbackStateLoad(object sender, CallbackStateLoadEventArgs e) {
        RegisterSummaryFunction();
    }
}
