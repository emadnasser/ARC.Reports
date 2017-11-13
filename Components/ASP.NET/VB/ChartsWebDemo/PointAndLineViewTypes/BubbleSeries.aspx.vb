Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class BubbleSeries
	Inherits ChartBasePage
	Private ReadOnly Property View() As BubbleSeriesView
		Get
			Return CType(WebChartControl1.Series(0).View, BubbleSeriesView)
		End Get
	End Property
	Private ReadOnly Property Label() As BubbleSeriesLabel
		Get
			Return CType(WebChartControl1.Series(0).Label, BubbleSeriesLabel)
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Private Sub UpdateChart()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
		Label.Position = CType(cbLabelPosition.SelectedIndex, PointLabelPosition)
		Dim maxSize As Double = Convert.ToDouble(speMaxBubbleSize.Value)
		If maxSize > View.MinSize Then
			View.MaxSize = maxSize
		Else
			speMaxBubbleSize.Value = View.MaxSize
		End If
		Dim minSize As Double = Convert.ToDouble(speMinBubbleSize.Value)
		If minSize < View.MaxSize Then
			View.MinSize = minSize
		Else
			speMinBubbleSize.Value = View.MinSize
		End If
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		View.BubbleMarkerOptions.Kind = item.MarkerKind
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			View.BubbleMarkerOptions.StarPointCount = starItem.PointCount
		End If
		View.Transparency = Convert.ToByte(cbTransparency.Value)
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			cbLabelPosition.SelectedIndex = CInt(Fix(Label.Position))
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.BubbleMarkerOptions.Kind, View.BubbleMarkerOptions.StarPointCount)
		Else
			UpdateChart()
		End If
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
		e.LegendText = (CType(e.SeriesPoint.Tag, BubbleDataItem)).Title
	End Sub
	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		UpdateChart()
		cbLabelPosition.ClientEnabled = Series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
		lblLabelPosition.ClientEnabled = cbLabelPosition.ClientEnabled
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
