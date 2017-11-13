Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.PieDoughnutViews
	Partial Public Class NestedDoughnutDemo
		Inherits ChartDemoBase2D
		Private WithEvents chart As ChartControl
		Private ReadOnly Property SeriesTemplate() As SeriesBase
			Get
				Return ChartControl.SeriesTemplate
			End Get
		End Property
		Private ReadOnly Property SeriesTemplateView() As NestedDoughnutSeriesView
			Get
				Return (CType(SeriesTemplate.View, NestedDoughnutSeriesView))
			End Get
		End Property
		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			ChartControl.DataSource = AgeStructure.GetPopulationAgeStructure()
		End Sub

		Private Sub spinHoleRadius_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinHoleRadius.EditValueChanged
			SeriesTemplateView.HoleRadiusPercent = Convert.ToInt32(spinHoleRadius.EditValue)
		End Sub
		Private Sub comboInnerIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbInnerIndent.EditValueChanged
			SeriesTemplateView.InnerIndent = Convert.ToDouble(cbInnerIndent.EditValue)
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			Dim chart As ChartControl = CType(sender, ChartControl)
			If chart.Series.Count > 0 Then
				chart.Series(0).ShowInLegend = True
				For Each series As Series In chart.Series
					Dim nestedView As NestedDoughnutSeriesView = TryCast(series.View, NestedDoughnutSeriesView)
					Dim population As AgePopulation = TryCast(series.Points(0).Tag, AgePopulation)
					If population IsNot Nothing AndAlso nestedView IsNot Nothing Then
						Dim name As String = population.Name
						nestedView.Group = name
						nestedView.Titles.Clear()
						nestedView.Titles.Add(New SeriesTitle() With {.Text = name})
					End If
				Next series
			End If
			chart.Animate()
		End Sub
		Private Sub radioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup.SelectedIndexChanged
			chart.BeginInit()
			Try
				If radioGroup.SelectedIndex = 0 Then
					GroupBySex()
				Else
					GroupByAge()
				End If
			Finally
				chart.EndInit()
			End Try
		End Sub
		Private Sub GroupByAge()
			ChartControl.SeriesDataMember = "CountryAgeKey"
			Dim argumentDataMember As String = "Gender"
			ChartControl.Titles(0).Text = "Population: " & argumentDataMember & " Structure"
			ChartControl.SeriesTemplate.ToolTipHintDataMember = "Age"
			ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember
		End Sub
		Private Sub GroupBySex()
			ChartControl.SeriesDataMember = "CountryGenderKey"
			Dim argumentDataMember As String = "Age"
			ChartControl.Titles(0).Text = "Population: " & argumentDataMember & " Structure"
			ChartControl.SeriesTemplate.ToolTipHintDataMember = "Gender"
			ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			spinHoleRadius.EditValue = SeriesTemplateView.HoleRadiusPercent
			cbInnerIndent.EditValue = SeriesTemplateView.InnerIndent
		End Sub
	End Class
End Namespace
