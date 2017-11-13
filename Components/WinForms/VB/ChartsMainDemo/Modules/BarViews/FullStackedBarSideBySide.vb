Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class FullStackedBarSideBySideDemo
		Inherits ChartDemoBase2D

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			radioGroup.SelectedIndex = 0
			checkValueAsPercent.Checked = True
		End Sub

		Private Sub radioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup.SelectedIndexChanged
			ChartControl.RefreshData()
		End Sub
		Private Sub checkValueAsPercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkValueAsPercent.CheckedChanged
			For Each series As Series In Me.chart.Series
				Dim view As FullStackedBarSeriesView = TryCast(series.View, FullStackedBarSeriesView)
				If view IsNot Nothing Then
					series.Label.TextPattern = If(Me.checkValueAsPercent.Checked, "{VP:P0}", "{V:0,,.00}")
				End If
			Next series
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			For Each series As Series In ChartControl.Series
				Dim view As ISupportStackedGroup = TryCast(series.View, ISupportStackedGroup)
				Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
				If view IsNot Nothing Then
					view.StackedGroup = If(radioGroup.SelectedIndex = 0, genderAge.Gender, genderAge.Age)
				End If
			Next series
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ChartControl.DataSource = AgeStructure.GetDataByAgeAndGender()
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Me.checkValueAsPercent.Enabled = ShowLabels
		End Sub

	End Class
End Namespace
