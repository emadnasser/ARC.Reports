Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.Web.ASPxGauges.Base
Imports DevExpress.Web.ASPxGauges.Gauges.Linear
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.Web.Demos

Partial Public Class LinearGaugePage
	Inherits Page
	Private Sub SetEditorsWidth()
		Dim width As Integer = If(Utils.IsLargeTheme, 145, 100)
		majorTickCountEdit.Width = width
		minorTickCountEdit.Width = width
		majorTickOffset.Width = width
		minorTickOffset.Width = width
		textOffset.Width = width
		textOrientation.Width = width
		value1.Width = width
		logarithmicScale.Width = width
		value2.Width = width
		anchorValue.Width = width
		startOffset.Width = width
		endOffset.Width = width
		markerOffset.Width = width
		markerShape.Width = width
		value3.Width = width
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SetEditorsWidth()
		If (Not IsCallback) Then
			GetGaugeScale(Me.gControl_Page1, 0, 0).Value = CSng(value1.Number)
			GetGaugeScale(Me.gControl_Page2, 0, 0).Value = CSng(value2.Number)
			GetGaugeScale(Me.gControl_Page3, 0, 0).Value = CSng(value3.Number)
		End If
	End Sub
	Protected Sub OnGauge1CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As LinearScaleComponent = GetGaugeScale(Me.gControl_Page1, 0, 0)
		scale.BeginUpdate()
		scale.Logarithmic = logarithmicScale.Checked
		If scale.IsLogarithmic = True Then
			scale.MaxValue = 100
		End If
		scale.Value = CSng(value1.Number)
		scale.MajorTickmark.TextOrientation = CType(CInt(Fix(textOrientation.Value)), LabelOrientation)
		scale.MajorTickmark.TextOffset = CSng(textOffset.Number)
		scale.MajorTickCount = CInt(Fix(majorTickCountEdit.Number))
		scale.MinorTickCount = CInt(Fix(minorTickCountEdit.Number))
		scale.MajorTickmark.ShapeOffset = CSng(majorTickOffset.Number)
		scale.MinorTickmark.ShapeOffset = CSng(minorTickOffset.Number)
		scale.EndUpdate()
	End Sub
	Protected Sub OnGauge2CustomCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim scale As LinearScaleComponent = GetGaugeScale(Me.gControl_Page2, 0, 0)
		Dim range As LinearScaleRangeBarComponent = GetGaugeRangeBar(Me.gControl_Page2, 0, 0)
		Dim marker As LinearScaleMarkerComponent = GetGaugeMarker(Me.gControl_Page2, 0, 0)
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
		Dim scale As LinearScaleComponent = GetGaugeScale(Me.gControl_Page3, 0, 0)
		scale.Value = CSng(value3.Number)
	End Sub
	Private Function GetGaugeScale(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal scaleIndex As Integer) As LinearScaleComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ILinearGauge)).Scales(scaleIndex)
	End Function
	Private Function GetGaugeRangeBar(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal rangeBarIndex As Integer) As LinearScaleRangeBarComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ILinearGauge)).RangeBars(rangeBarIndex)
	End Function
	Private Function GetGaugeMarker(ByVal gaugeControl As ASPxGaugeControl, ByVal gaugeIndex As Integer, ByVal markerIndex As Integer) As LinearScaleMarkerComponent
		Return (CType(gaugeControl.Gauges(gaugeIndex), ILinearGauge)).Markers(markerIndex)
	End Function
End Class
