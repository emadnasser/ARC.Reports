Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Partial Public Class Doughnut3DSeries
	Inherits ChartBasePage
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Label() As Pie3DSeriesLabel
		Get
			Return CType(Series.Label, Pie3DSeriesLabel)
		End Get
	End Property
	Private ReadOnly Property View() As Doughnut3DSeriesView
		Get
			Return CType(Series.View, Doughnut3DSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
			If Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Label.TextPattern)) Then
				cbValueAsPercent.Checked = Label.TextPattern.Contains("VP")
			End If
			ComboBoxHelper.PreparePieLabelsComboBox(cbLabelPosition)
			ComboBoxHelper.PrepareExplodedPointsComboBox(cbExplodedPoints, Series.Points, False)
			ComboBoxHelper.PrepareDoughnutHolePercentComboBox(cbHoleRadius)
			cbLabelPosition.SelectedIndex = 3
		End If
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "LabelPosition" Then
			PerformLabelPositionAction()
		ElseIf e.Parameter = "ValueAsPercent" Then
			PerformValueAsPercentAction()
		ElseIf e.Parameter = "ExplodedPoints" Then
			PerformExplodedPointsAction()
		ElseIf e.Parameter = "HoleRadius" Then
			PerformHoleRadiusAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
	Private Sub PerformLabelPositionAction()
		Label.Position = CType(ComboBoxHelper.GetSelectedItem(cbLabelPosition, GetType(PieSeriesLabelPosition)), PieSeriesLabelPosition)
	End Sub
	Private Sub PerformValueAsPercentAction()
		Label.TextPattern = If(cbValueAsPercent.Checked, "{A}: {VP:P0}", "{A}: {V:F1}")
	End Sub
	Private Sub PerformExplodedPointsAction()
		ComboBoxHelper.ApplySelectedExplodingMode(cbExplodedPoints, View)
	End Sub
	Private Sub PerformHoleRadiusAction()
		View.HoleRadiusPercent = ComboBoxHelper.GetSelectedDoughnutHolePercent(cbHoleRadius)
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
End Class
