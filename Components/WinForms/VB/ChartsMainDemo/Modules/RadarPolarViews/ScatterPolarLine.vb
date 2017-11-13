Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class ScatterPolarLineDemo
		Inherits RadarPolarDemoBase
		Private chart As ChartControl

		Private ReadOnly Property PolarSeries() As Series
			Get
				Return Me.seriesSelected
			End Get
		End Property
		Private ReadOnly Property PolarSeriesView() As ScatterPolarLineSeriesView
			Get
				Return If(PolarSeries IsNot Nothing, TryCast(PolarSeries.View, ScatterPolarLineSeriesView), Nothing)
			End Get
		End Property

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides Property ShowMarkers() As Boolean
			Get
				Return If(PolarSeriesView IsNot Nothing, PolarSeriesView.MarkerVisibility <> DefaultBoolean.False, MyBase.ShowMarkers)
			End Get
			Set(ByVal value As Boolean)
				If PolarSeriesView IsNot Nothing Then
					PolarSeriesView.MarkerVisibility = If(value, DefaultBoolean.True, DefaultBoolean.False)
				End If
			End Set
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			SetSeriesSelected()
			Me.comboBoxEditFunctionType.SelectedIndex = 0
		End Sub

		Private Sub SetSeriesSelected()
			Me.seriesSelected = If(chart.Series.Count > 0, chart.Series(0), Nothing)
		End Sub
		Private Sub checkEditShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMarkers.CheckedChanged
			ShowMarkers = checkEditShowMarkers.Checked
			UpdateControls()
		End Sub
		Private Sub comboBoxEditFunctionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditFunctionType.SelectedIndexChanged
			PolarSeries.Points.Clear()
			Dim functionCalculator As New DegreeScatterFunctionCalculator()
			Dim points() As SeriesPoint = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunctionType.SelectedIndex)
			PolarSeries.Points.AddRange(points)
			ChartControl.Animate()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			SetSeriesSelected()
			checkEditShowMarkers.Enabled = True
			If PolarSeriesView IsNot Nothing Then
				checkEditShowMarkers.Checked = PolarSeriesView.MarkerVisibility <> DefaultBoolean.False
			End If
			EnableMarkerControls(checkEditShowMarkers.Checked)
		End Sub
	End Class
End Namespace
