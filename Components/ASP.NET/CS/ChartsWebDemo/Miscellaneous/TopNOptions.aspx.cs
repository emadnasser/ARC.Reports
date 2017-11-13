using System;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class TopNOptions : ChartBasePage {
    const string optionsKey = "Options";
    const string labelVisibleKey = "LabelVisible";
    const string minValueKey = "Min";
    const string maxValueKey = "Max";
    const string valueKey = "Value";

    Series Series { get { return WebChartControl1.Series[0]; } }
    DevExpress.XtraCharts.TopNOptions Options { get { return Series.TopNOptions; } }
    SeriesLabelBase Label { get { return Series.Label; } }

    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
    void SaveState() {
        Session[optionsKey] = Options;
        Session[labelVisibleKey] = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
    }
    void LoadState() {
        var options = (DevExpress.XtraCharts.TopNOptions)Session[optionsKey];
        if (options != null)
            Options.Assign(options);
        Series.LabelsVisibility = (bool)Session[labelVisibleKey] ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack)
            LoadState();
        else {
            cbMode.Value = Options.Mode;
            SaveState();
            UpdateControls();
        }
        UpdateEnabledState();
        UpdateValueLabel();
    }
    protected void seEditValueInit(object sender, EventArgs e) {
        ASPxSpinEdit spinEdit = sender as ASPxSpinEdit;
        if (spinEdit != null && IsPostBack) {
            spinEdit.MinValue = Convert.ToDecimal(Session[minValueKey]);
            spinEdit.MaxValue = Convert.ToDecimal(Session[maxValueKey]);
        }
    }

    protected void callbackPanel_Callback(object source, DevExpress.Web.CallbackEventArgsBase e) {
        switch (e.Parameter) {
            case "Mode":
                Options.Mode = (TopNMode)ComboBoxHelper.GetSelectedItem(cbMode, typeof(TopNMode));
                break;
            case "Value":
                if (editValueHiddenField.Contains(valueKey)) {
                    object value = editValueHiddenField.Get(valueKey);
                    switch (Options.Mode) {
                        case TopNMode.Count:
                            Options.Count = Convert.ToInt32(value);
                            break;
                        case TopNMode.ThresholdValue:
                            Options.ThresholdValue = Convert.ToDouble(value);
                            break;
                        case TopNMode.ThresholdPercent:
                            Options.ThresholdPercent = Convert.ToDouble(value);
                            break;
                    }
                }
                break;
            case "ShowOthers":
                Options.ShowOthers = cbShowOthers.Checked;
                break;
            case "OthersArgument":
                Options.OthersArgument = (string)txtOthersArgument.Value;
                break;
            case "Label":
                Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
                break;
        }
        SaveState();
        UpdateControls();
        UpdateEnabledState();
    }
    void UpdateControls() {
        switch (Options.Mode) {
            case TopNMode.Count:
                editValue.NumberType = DevExpress.Web.SpinEditNumberType.Integer;
                editValue.Value = Options.Count;
                editValue.MinValue = 1;
                editValue.MaxValue = 20;
                editValue.Increment = 1;
                break;
            case TopNMode.ThresholdValue:
                editValue.NumberType = DevExpress.Web.SpinEditNumberType.Float;
                editValue.Value = Options.ThresholdValue;
                editValue.MinValue = 2000;
                editValue.MaxValue = 20000;
                editValue.Increment = 500;
                break;
            case TopNMode.ThresholdPercent:
                editValue.NumberType = DevExpress.Web.SpinEditNumberType.Float;
                editValue.Value = Options.ThresholdPercent;
                editValue.MinValue = new decimal(1.5);
                editValue.MaxValue = 100;
                editValue.Increment = new decimal(0.1);
                break;
            default:
                lblValue.Enabled = false;
                editValue.Enabled = false;
                return;
        }
        Session[minValueKey] = editValue.MinValue;
        Session[maxValueKey] = editValue.MaxValue;
        cbShowOthers.Checked = Options.ShowOthers;
        txtOthersArgument.Value = String.IsNullOrEmpty(Options.OthersArgument) ? "Others" : Options.OthersArgument;
        cbShowLabels.Checked = Series.LabelsVisibility != DevExpress.Utils.DefaultBoolean.False;
    }
    void UpdateEnabledState() {
        lblOthersArgument.ClientEnabled = Options.ShowOthers;
        txtOthersArgument.ClientEnabled = Options.ShowOthers;
    }
    void UpdateValueLabel() {
        lblValue.Text = cbMode.Text + ":";
    }
}
