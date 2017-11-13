Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class FunnelSeries
	Inherits ChartBasePage
	Private loading As Boolean = False

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Label() As FunnelSeriesLabel
		Get
			Return CType(Series.Label, FunnelSeriesLabel)
		End Get
	End Property
	Private ReadOnly Property View() As FunnelSeriesView
		Get
			Return CType(Series.View, FunnelSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Try
				loading = True
				cbShowLabels.Checked = Series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
				ComboBoxHelper.PrepareComboBox(cbLabelPosition, FunnelSeriesLabelPosition.Right)
				ComboBoxHelper.PrepareComboBox(cbHeightToWidthRatio, New Double() { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 }, View.HeightToWidthRatio)
				If Series IsNot Nothing AndAlso Series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Series.Label.TextPattern)) Then
					cbValueAsPercent.Checked = Series.Label.TextPattern.Contains("VP")
				End If
				cbHeightToWidthRatioAuto.Checked = View.HeightToWidthRatioAuto
				cbHeightToWidthRatio.ClientEnabled = Not View.HeightToWidthRatioAuto
				cbAlignToCenter.Checked = View.AlignToCenter
				spinPointDistance.Value = View.PointDistance
			Finally
				loading = False
			End Try
		End If
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
		lblHeightToWidthRatio.ClientEnabled = Not cbHeightToWidthRatioAuto.Checked
		cbHeightToWidthRatio.ClientEnabled = Not cbHeightToWidthRatioAuto.Checked
	End Sub
	Private Sub PerformLabelPositionAction()
		If loading Then
			Return
		End If
		Dim position As FunnelSeriesLabelPosition = CType(ComboBoxHelper.GetSelectedItem(cbLabelPosition, GetType(FunnelSeriesLabelPosition)), FunnelSeriesLabelPosition)
		Label.Position = position
	End Sub
	Private Sub PerformValueAsPercentAction()
		If loading Then
			Return
		End If
		Series.Label.TextPattern = If(cbValueAsPercent.Checked, "{A}: {VP:P0}", "{A}: {V:F1}")
	End Sub
	Private Sub PerformShowLabelsAction()
		If loading Then
			Return
		End If
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformAlignToCenterAction()
		If loading Then
			Return
		End If
		View.AlignToCenter = cbAlignToCenter.Checked
	End Sub
	Private Sub PerformHeightToWidthRatioAutoAction()
		If loading Then
			Return
		End If
		View.HeightToWidthRatioAuto = cbHeightToWidthRatioAuto.Checked
	End Sub
	Private Sub PerformHeightToWidthRatioAction()
		If loading Then
			Return
		End If
		View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem.Value)
	End Sub
	Private Sub PerformPointDistanceAction()
		If loading Then
			Return
		End If
		View.PointDistance = Convert.ToInt32(spinPointDistance.Value)
	End Sub
	Protected Sub WebChartControl1_CustomCallback1(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "LabelPosition" Then
			PerformLabelPositionAction()
		ElseIf e.Parameter = "ValueAsPercent" Then
			PerformValueAsPercentAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "AlignToCenter" Then
			PerformAlignToCenterAction()
		ElseIf e.Parameter = "HeightToWidthRatioAuto" Then
			PerformHeightToWidthRatioAutoAction()
		ElseIf e.Parameter = "HeightToWidthRatio" Then
			PerformHeightToWidthRatioAction()
		ElseIf e.Parameter = "PointDistance" Then
			PerformPointDistanceAction()
		End If

	End Sub
End Class
