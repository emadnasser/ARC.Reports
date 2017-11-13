using System;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class FibonacciIndicators : ChartBasePage {
    const string fibonacciIndicatorName = "FibonacciIndicator";

    FibonacciIndicator FibonacciIndicator { get { return (FibonacciIndicator)((XYDiagramSeriesViewBase)WebChartControl1.Series[0].View).Indicators[0]; } }

    void UpdateCheckedState() {
        switch(FibonacciIndicator.Kind) {
            case FibonacciIndicatorKind.FibonacciArcs:
                chbLevel0.Checked = false;
                chbLevel100.Checked = FibonacciIndicator.ShowLevel100;
                chbAdditionalLevels.Checked = false;
                break;
            case FibonacciIndicatorKind.FibonacciFans:
                chbLevel0.Checked = FibonacciIndicator.ShowLevel0;
                chbLevel100.Checked = false;
                chbAdditionalLevels.Checked = false;
                break;
            case FibonacciIndicatorKind.FibonacciRetracement:
                chbLevel0.Checked = FibonacciIndicator.ShowLevel0;
                chbLevel0.Checked = true;
                chbLevel100.Checked = true;
                chbAdditionalLevels.Checked = FibonacciIndicator.ShowAdditionalLevels;
                break;
        }
        chbLevel23_6.Checked = FibonacciIndicator.ShowLevel23_6;
        chbLevel76_4.Checked = FibonacciIndicator.ShowLevel76_4;
    }
    void UpdateEnabledState() {
        switch(FibonacciIndicator.Kind) {
            case FibonacciIndicatorKind.FibonacciArcs:
                chbLevel0.ClientEnabled = false;
                chbLevel100.ClientEnabled = true;
                chbAdditionalLevels.ClientEnabled = false;
                break;
            case FibonacciIndicatorKind.FibonacciFans:
                chbLevel0.ClientEnabled = true;
                chbLevel100.ClientEnabled = false;
                chbAdditionalLevels.ClientEnabled = false;
                break;
            case FibonacciIndicatorKind.FibonacciRetracement:
                chbLevel0.ClientEnabled = false;
                chbLevel100.ClientEnabled = false;
                chbAdditionalLevels.ClientEnabled = true;
                break;
        }
    }
    void SetFibonacciIndicator() {
        FibonacciIndicator indicator = Session[fibonacciIndicatorName] as FibonacciIndicator;
        if (indicator != null)
            FibonacciIndicator.Assign(indicator);
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack)
            SetFibonacciIndicator();
        else {
            Session[fibonacciIndicatorName] = FibonacciIndicator;
            UpdateCheckedState();
        }
        UpdateEnabledState();
    }
    protected void callbackPanel_Callback(object source, CallbackEventArgsBase e) {
        switch (e.Parameter) {
            case "Kind":
                FibonacciIndicator.Kind = (FibonacciIndicatorKind)ComboBoxHelper.GetSelectedItem(cmbKind, typeof(FibonacciIndicatorKind));
                break;
            case "0":
                FibonacciIndicator.ShowLevel0 = chbLevel0.Checked;
                break;
            case "100":
                FibonacciIndicator.ShowLevel100 = chbLevel100.Checked;
                break;
            case "23.6":
                FibonacciIndicator.ShowLevel23_6 = chbLevel23_6.Checked;
                break;
            case "76.4":
                FibonacciIndicator.ShowLevel76_4 = chbLevel76_4.Checked;
                break;
            case "Additional":
                FibonacciIndicator.ShowAdditionalLevels = chbAdditionalLevels.Checked;
                break;
        }
        Session[fibonacciIndicatorName] = FibonacciIndicator;
        UpdateCheckedState();
        UpdateEnabledState();
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}
