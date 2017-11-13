using System;
using System.Collections.Generic;
using DevExpress.Web;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class BubbleSeries : ChartBasePage {
    BubbleSeriesView View { get { return (BubbleSeriesView)WebChartControl1.Series[0].View; } }
    BubbleSeriesLabel Label { get { return (BubbleSeriesLabel)WebChartControl1.Series[0].Label; } }
    Series Series { get { return WebChartControl1.Series[0]; } }

    void UpdateChart() {
        Series.LabelsVisibility = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        WebChartControl1.ToolTipEnabled = cbShowLabels.Checked ? DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
        Label.Position = (PointLabelPosition)cbLabelPosition.SelectedIndex;
        double maxSize = Convert.ToDouble(speMaxBubbleSize.Value);
        if (maxSize > View.MinSize)
            View.MaxSize = maxSize;
        else
            speMaxBubbleSize.Value = View.MaxSize;
        double minSize = Convert.ToDouble(speMinBubbleSize.Value);
        if (minSize < View.MaxSize)
            View.MinSize = minSize;
        else
            speMinBubbleSize.Value = View.MinSize;
        MarkerKindItem item = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind);
        View.BubbleMarkerOptions.Kind = item.MarkerKind;
        StarMarkerKindItem starItem = item as StarMarkerKindItem;
        if (starItem != null)
            View.BubbleMarkerOptions.StarPointCount = starItem.PointCount;
        View.Transparency = Convert.ToByte(cbTransparency.Value);
    }
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = Series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
            cbLabelPosition.SelectedIndex = (int)Label.Position;
            ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.BubbleMarkerOptions.Kind, View.BubbleMarkerOptions.StarPointCount);
        }
        else
            UpdateChart();
        lblLabelPosition.ClientEnabled = cbShowLabels.Checked;
        cbLabelPosition.ClientEnabled = cbShowLabels.Checked;
    }
    protected void WebChartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        e.LegendText = ((BubbleDataItem)e.SeriesPoint.Tag).Title;
    }
    protected void callbackPanel_Callback(object source, CallbackEventArgsBase e) {
        UpdateChart();
        lblLabelPosition.ClientEnabled = cbLabelPosition.ClientEnabled = Series.LabelsVisibility == DevExpress.Utils.DefaultBoolean.True;
    }
    public override WebChartControl FindWebChartControl() {
        return WebChartControl1;
    }
}
