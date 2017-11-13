Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class PointDemo
		Inherits PointDemoBase
		Private WithEvents simpleButtonRandom As SimpleButton

		Protected WithEvents chart As ChartControl

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitSeries()
			If chart.Series.Count > 2 AndAlso chart.Series(0).View.GetType().Equals(GetType(PointSeriesView)) Then
				Dim random As New Random()
				Me.chart.Series(0).Points.Clear()
				Me.chart.Series(0).Points.AddRange(RandomPointCalculator.Calculate(random, 20, 1, 8, 5, 12))
				Me.chart.Series(1).Points.Clear()
				Me.chart.Series(1).Points.AddRange(RandomPointCalculator.Calculate(random, 20, 9, 16, 1, 8))
				Me.chart.Series(2).Points.Clear()
				Me.chart.Series(2).Points.AddRange(RandomPointCalculator.Calculate(random, 20, 6, 13, 14, 21))
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
		End Sub
		Private Sub UpdateLabelAngleComboBox(ByVal seriesLabel As PointSeriesLabel)
			comboBoxEditLabelAngle.Enabled = ShowLabels AndAlso seriesLabel.Position = PointLabelPosition.Outside
		End Sub
		Private Sub simpleButtonRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRandom.Click
			InitSeries()
			ChartControl.Animate()
		End Sub
		Private Sub chart_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.VisibleChanged
			InitSeries()
		End Sub
		Private Sub cbeLabelPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeLabelPosition.SelectedIndexChanged
			If cbeLabelPosition.SelectedIndex = -1 OrElse chart.Series.Count = 0 OrElse seriesSelected Is Nothing Then
				Return
			End If
			Dim label As PointSeriesLabel = TryCast(seriesSelected.Label, PointSeriesLabel)
			If label IsNot Nothing Then
				label.Position = CType(cbeLabelPosition.SelectedIndex, PointLabelPosition)
				UpdateLabelAngleComboBox(label)
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			cbeLabelPosition.SelectedIndex = CInt(Fix((CType(chart.Series(0).Label, PointSeriesLabel)).Position))
		End Sub
		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If seriesSelected Is Nothing Then
				cbeLabelPosition.SelectedIndex = -1
				cbeLabelPosition.Enabled = False
			Else
				lblLabelPosition.Enabled = ShowLabels
				cbeLabelPosition.Enabled = lblLabelPosition.Enabled
				Dim label As PointSeriesLabel = TryCast(seriesSelected.Label, PointSeriesLabel)
				If label IsNot Nothing Then
					cbeLabelPosition.SelectedIndex = CInt(Fix(label.Position))
					UpdateLabelAngleComboBox(label)
				End If
			End If
		End Sub
	End Class
End Namespace

