Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.Web.ASPxGauges.Base
Imports DevExpress.Web.ASPxGauges.Gauges.Circular
Imports DevExpress.XtraGauges.Core.Model

Partial Public Class CircularGaugesPage
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) Then
			GetGaugeScale(Me.gControl_Page1, 0, 0).Value = CSng(Me.value1.Number)
			GetGaugeScale(Me.gControl_Page2, 0, 0).Value = CSng(Me.value2.Number)
			GetGaugeScale(Me.gControl_Page3, 0, 0).Value = CSng(Me.value3.Number)
			GetGaugeScale(Me.gControl_Page4, 0, 0).Value = CSng(Me.value4.Number)
		End If
	End Sub
	Protected Sub OnGauge1CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As ArcScaleComponent = GetGaugeScale(Me.gControl_Page1, 0, 0)
		scale.BeginUpdate()
		scale.Logarithmic = logarithmicScale.Checked
		If scale.IsLogarithmic = True Then
			scale.MaxValue = 100
		End If
		scale.Value = CSng(value1.Number)
		scale.RadiusX = CSng(radius.Number)
		scale.RadiusY = CSng(radius.Number)
		scale.StartAngle = CSng(startAngle.Number)
		scale.EndAngle = CSng(endAngle.Number)
		scale.MajorTickmark.TextOrientation = CType(CInt(Fix(textOrientation.Value)), LabelOrientation)
		scale.MajorTickmark.TextOffset = CSng(textOffset.Number)
		scale.MajorTickCount = CInt(Fix(majorTickCountEdit.Number))
		scale.MinorTickCount = CInt(Fix(minorTickCountEdit.Number))
		scale.MajorTickmark.ShapeOffset = CSng(majorTickOffset.Number)
		scale.MinorTickmark.ShapeOffset = CSng(minorTickOffset.Number)
		scale.EndUpdate()
	End Sub
	Protected Sub OnGauge2CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As ArcScaleComponent = GetGaugeScale(Me.gControl_Page2, 0, 0)
		Dim range As ArcScaleRangeBarComponent = GetGaugeRangeBar(Me.gControl_Page2, 0, 0)
		Dim marker As ArcScaleMarkerComponent = GetGaugeMarker(Me.gControl_Page2, 0, 0)
		scale.Value = CSng(value2.Number)
		range.BeginUpdate()
		range.AnchorValue = CSng(anchorValue.Number)
		range.StartOffset = CSng(startOffset.Number)
		range.EndOffset = CSng(endOffset.Number)
		range.EndUpdate()
		marker.BeginUpdate()
		marker.ShapeOffset = CSng(markerOffset.Number)
		marker.ShapeType = CType(CInt(Fix(markerShape.SelectedIndex)), MarkerPointerShapeType)
		marker.EndUpdate()
	End Sub
	Protected Sub OnGauge3CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As ArcScaleComponent = GetGaugeScale(Me.gControl_Page3, 0, 0)
		Dim needle As ArcScaleNeedleComponent = GetGaugeNeedle(Me.gControl_Page3, 0, 0)
		scale.Value = CSng(value3.Number)
		needle.StartOffset = CSng(needleStartOffset.Number)
		needle.EndOffset = CSng(needleEndOffset.Number)
	End Sub
	Protected Sub OnGauge4CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As ArcScaleComponent = GetGaugeScale(Me.gControl_Page4, 0, 0)
		scale.Value = CSng(value4.Number)
	End Sub
	Private Function GetGaugeScale(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal scaleIndex As Integer) As ArcScaleComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ICircularGauge)).Scales(scaleIndex)
	End Function
	Private Function GetGaugeRangeBar(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal rangeBarIndex As Integer) As ArcScaleRangeBarComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ICircularGauge)).RangeBars(rangeBarIndex)
	End Function
	Private Function GetGaugeMarker(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal markerIndex As Integer) As ArcScaleMarkerComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ICircularGauge)).Markers(markerIndex)
	End Function
	Private Function GetGaugeNeedle(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal needleIndex As Integer) As ArcScaleNeedleComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ICircularGauge)).Needles(needleIndex)
	End Function
End Class
