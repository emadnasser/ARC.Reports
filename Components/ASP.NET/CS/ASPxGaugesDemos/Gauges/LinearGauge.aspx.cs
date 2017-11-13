using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxGauges;
using DevExpress.Web.ASPxGauges.Base;
using DevExpress.Web.ASPxGauges.Gauges.Linear;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.Web.Demos;

public partial class LinearGaugePage : Page {
    private void SetEditorsWidth() {
        int width = Utils.IsLargeTheme ? 145 : 100;
        majorTickCountEdit.Width = width;
        minorTickCountEdit.Width = width;
        majorTickOffset.Width = width;
        minorTickOffset.Width = width;
        textOffset.Width = width;
        textOrientation.Width = width;
        value1.Width = width;
        logarithmicScale.Width = width;
        value2.Width = width;
        anchorValue.Width = width;
        startOffset.Width = width;
        endOffset.Width = width;
        markerOffset.Width = width;
        markerShape.Width = width;
        value3.Width = width;
    }

    protected void Page_Load(object sender, EventArgs e) {
        SetEditorsWidth();
        if (!IsCallback) {
            GetGaugeScale(this.gControl_Page1, 0, 0).Value = (float)value1.Number;
            GetGaugeScale(this.gControl_Page2, 0, 0).Value = (float)value2.Number;
            GetGaugeScale(this.gControl_Page3, 0, 0).Value = (float)value3.Number;
        }
    }
    protected void OnGauge1CustomCallback(object source, CallbackEventArgsBase e) {
        LinearScaleComponent scale = GetGaugeScale(this.gControl_Page1, 0, 0);
        scale.BeginUpdate();
        scale.Logarithmic = logarithmicScale.Checked;
        if(scale.IsLogarithmic == true)
            scale.MaxValue = 100;
        scale.Value = (float)value1.Number;
        scale.MajorTickmark.TextOrientation = (LabelOrientation)(int)textOrientation.Value;
        scale.MajorTickmark.TextOffset = (float)textOffset.Number;
        scale.MajorTickCount = (int)majorTickCountEdit.Number;
        scale.MinorTickCount = (int)minorTickCountEdit.Number;
        scale.MajorTickmark.ShapeOffset = (float)majorTickOffset.Number;
        scale.MinorTickmark.ShapeOffset = (float)minorTickOffset.Number;
        scale.EndUpdate();
    }
    protected void OnGauge2CustomCallback(object source, CallbackEventArgsBase e) {
        LinearScaleComponent scale = GetGaugeScale(this.gControl_Page2, 0, 0);
        LinearScaleRangeBarComponent range = GetGaugeRangeBar(this.gControl_Page2, 0, 0);
        LinearScaleMarkerComponent marker = GetGaugeMarker(this.gControl_Page2, 0, 0);
        scale.Value = (float)value2.Number;
        range.BeginUpdate();
        range.AnchorValue = (float)anchorValue.Number;
        range.StartOffset = (float)startOffset.Number;
        range.EndOffset = (float)endOffset.Number;
        range.EndUpdate();
        marker.BeginUpdate();
        marker.ShapeOffset = (float)markerOffset.Number;
        marker.ShapeType = (MarkerPointerShapeType)(int)markerShape.SelectedIndex;
        marker.EndUpdate();
    }
    protected void OnGauge3CustomCallback(object source, CallbackEventArgsBase e) {
        LinearScaleComponent scale = GetGaugeScale(this.gControl_Page3, 0, 0);
        scale.Value = (float)value3.Number;
    }
    LinearScaleComponent GetGaugeScale(ASPxGaugeControl gaugeControl, int gaugeIndex, int scaleIndex) {
        return ((ILinearGauge)gaugeControl.Gauges[gaugeIndex]).Scales[scaleIndex];
    }
    LinearScaleRangeBarComponent GetGaugeRangeBar(ASPxGaugeControl gaugeControl, int gaugeIndex, int rangeBarIndex) {
        return ((ILinearGauge)gaugeControl.Gauges[gaugeIndex]).RangeBars[rangeBarIndex];
    }
    LinearScaleMarkerComponent GetGaugeMarker(ASPxGaugeControl gaugeControl, int gaugeIndex, int markerIndex) {
        return ((ILinearGauge)gaugeControl.Gauges[gaugeIndex]).Markers[markerIndex];
    }
}
