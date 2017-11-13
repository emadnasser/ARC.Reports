Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class DoughnutSeries
	Inherits ChartBasePage
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property Label() As DoughnutSeriesLabel
		Get
			Return CType(Series.Label, DoughnutSeriesLabel)
		End Get
	End Property
	Private ReadOnly Property View() As DoughnutSeriesView
		Get
			Return CType(Series.View, DoughnutSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
			If Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(Label.TextPattern)) Then
				cbValueAsPercent.Checked = Label.TextPattern.Contains("VP")
			End If
			ComboBoxHelper.PreparePieLabelsComboBox(cbLabelPosition)
			ComboBoxHelper.PrepareExplodedPointsComboBox(cbExplodedPoints, Series.Points, True)
			ComboBoxHelper.PrepareDoughnutHolePercentComboBox(cbHoleRadius)
			cbLabelPosition.SelectedIndex = 3
		End If
		lblLabelPosition.ClientEnabled = cbShowLabels.Checked
		cbLabelPosition.ClientEnabled = cbShowLabels.Checked
	End Sub
	Private Sub PerformLabelPositionAction()
		Dim position As PieSeriesLabelPosition = CType(ComboBoxHelper.GetSelectedItem(cbLabelPosition, GetType(PieSeriesLabelPosition)), PieSeriesLabelPosition)
		Label.Position = position
		Label.TextColor = If((position.Equals(PieSeriesLabelPosition.Outside) OrElse position.Equals(PieSeriesLabelPosition.TwoColumns)), Color.Empty, Color.Black)
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
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Protected Sub WebChartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
		Dim series As Series = TryCast(e.Object, Series)
		If series IsNot Nothing Then
			Dim explodedPoints As ExplodedSeriesPointCollection = (CType(series.View, PieSeriesViewBase)).ExplodedPoints
			Dim point As SeriesPoint = CType(e.AdditionalObject, SeriesPoint)
			explodedPoints.ToggleExplodedState(point)
		End If
		e.Cancel = series Is Nothing
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
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
End Class
