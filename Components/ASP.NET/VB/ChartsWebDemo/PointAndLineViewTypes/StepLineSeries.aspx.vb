Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts

Partial Public Class StepLineSeries
	Inherits ChartBasePage
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property View() As StepLineSeriesView
		Get
			Return CType(Series.View, StepLineSeriesView)
		End Get
	End Property
	Private ReadOnly Property Label() As PointSeriesLabel
		Get
			Return CType(Series.Label, PointSeriesLabel)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
			ComboBoxHelper.PrepareLabelAngleComboBox(cbLabelAngle, Label.Angle)
			ComboBoxHelper.PrepareMarkerKindComboBox(cbMarkerKind, View.PointMarkerOptions.Kind, View.PointMarkerOptions.StarPointCount)
			ComboBoxHelper.PrepareMarkerSizeComboBox(cbMarkerSize, View.PointMarkerOptions.Size)
		End If
		lblLabelAngle.ClientEnabled = cbShowLabels.Checked
		cbLabelAngle.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub PerformLabelAngleAction()
		Label.Angle = Convert.ToInt32(cbLabelAngle.SelectedItem.Text)
	End Sub
	Private Sub PerformMarkerKindAction()
		Dim item As MarkerKindItem = ComboBoxHelper.GetSelectedMarkerKindItem(cbMarkerKind)
		Dim pointCount As Integer = 0
		Dim starItem As StarMarkerKindItem = TryCast(item, StarMarkerKindItem)
		If starItem IsNot Nothing Then
			pointCount = starItem.PointCount
		End If
		For Each series As Series In WebChartControl1.Series
			Dim view As PointSeriesView = CType(series.View, PointSeriesView)
			view.PointMarkerOptions.Kind = item.MarkerKind
			If pointCount <> 0 Then
				view.PointMarkerOptions.StarPointCount = pointCount
			End If
		Next series
	End Sub
	Private Sub PerformMarkerSizeAction()
		View.PointMarkerOptions.Size = Convert.ToInt32(cbMarkerSize.SelectedItem.Text)
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "LabelAngle" Then
			PerformLabelAngleAction()
		ElseIf e.Parameter = "MarkerKind" Then
			PerformMarkerKindAction()
		ElseIf e.Parameter = "MarkerSize" Then
			PerformMarkerSizeAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
