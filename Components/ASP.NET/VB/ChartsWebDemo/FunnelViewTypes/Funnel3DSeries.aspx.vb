Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class Funnel3DSeries
	Inherits ChartBasePage
	Private isLoading As Boolean = False

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Label() As FunnelSeriesLabel
		Get
			Return CType(Series.Label, Funnel3DSeriesLabel)
		End Get
	End Property
	Private ReadOnly Property View() As Funnel3DSeriesView
		Get
			Return CType(Series.View, Funnel3DSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Try
			isLoading = True
			If (Not IsPostBack) Then
				cbShowLabels.Checked = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
				ComboBoxHelper.PrepareComboBox(cbLabelPosition, FunnelSeriesLabelPosition.Right)
				cbHeightToWidthRatio.Items.AddRange(New Double() { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 })
				cbHeightToWidthRatio.SelectedIndex = 4
				If Series IsNot Nothing AndAlso Series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Series.Label.TextPattern)) Then
					cbValueAsPercent.Checked = Series.Label.TextPattern.Contains("VP")
				End If
				spinPointDistance.Value = View.PointDistance
				spinHoleRadius.Value = View.HoleRadiusPercent
			End If
		Finally
			isLoading = False
		End Try
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback1(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "LabelPosition" Then
			PerformLabelPositionAction()
		ElseIf e.Parameter = "ValueAsPercent" Then
			PerformValueAsPercentAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "HeightToWidthRatio" Then
			PerformHeightToWidthRatioAction()
		ElseIf e.Parameter = "PointDistance" Then
			PerformPointDistanceAction()
		ElseIf e.Parameter = "HoleRadius" Then
			PerformHoleRadiusAction()
		End If

	End Sub
	Private Sub PerformLabelPositionAction()
		If isLoading Then
			Return
		End If
		Dim position As FunnelSeriesLabelPosition = CType(ComboBoxHelper.GetSelectedItem(cbLabelPosition, GetType(FunnelSeriesLabelPosition)), FunnelSeriesLabelPosition)
		Label.Position = position
	End Sub
	Private Sub PerformValueAsPercentAction()
		If isLoading Then
			Return
		End If
		Series.Label.TextPattern = If(cbValueAsPercent.Checked, "{A}: {VP:P0}", "{A}: {V:F1}")
	End Sub
	Private Sub PerformShowLabelsAction()
		If isLoading Then
			Return
		End If
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub PerformHeightToWidthRatioAction()
		If isLoading Then
			Return
		End If
		View.HeightToWidthRatio = Convert.ToDouble(cbHeightToWidthRatio.SelectedItem.Value)
	End Sub
	Private Sub PerformPointDistanceAction()
		If isLoading Then
			Return
		End If
		View.PointDistance = Convert.ToInt32(spinPointDistance.Value)
	End Sub
	Private Sub PerformHoleRadiusAction()
		If isLoading Then
			Return
		End If
		View.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.Value)
	End Sub
End Class
