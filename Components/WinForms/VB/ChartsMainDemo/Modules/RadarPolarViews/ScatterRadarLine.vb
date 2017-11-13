Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class ScatterRadarLineDemo
		Inherits RadarPolarDemoBase
		Private chart As ChartControl

		Private ReadOnly Property RadarSeries() As Series
			Get
				Return Me.seriesSelected
			End Get
		End Property
		Private ReadOnly Property RadarSeriesView() As ScatterRadarLineSeriesView
			Get
				Return If(RadarSeries IsNot Nothing, TryCast(RadarSeries.View, ScatterRadarLineSeriesView), Nothing)
			End Get
		End Property

		Protected Overrides ReadOnly Property SeriesSelection() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides Property ShowMarkers() As Boolean
			Get
				Return If(RadarSeriesView IsNot Nothing, RadarSeriesView.MarkerVisibility <> DefaultBoolean.False, MyBase.ShowMarkers)
			End Get
			Set(ByVal value As Boolean)
				If RadarSeriesView IsNot Nothing Then
					RadarSeriesView.MarkerVisibility = If(value, DefaultBoolean.True, DefaultBoolean.False)
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
			RadarSeries.Points.Clear()
			Dim functionCalculator As New RadianScatterFunctionCalculator()
			Dim points() As SeriesPoint = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunctionType.SelectedIndex)
			RadarSeries.Points.AddRange(points)
			ChartControl.Animate()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			SetSeriesSelected()
			checkEditShowMarkers.Enabled = True
			If RadarSeriesView IsNot Nothing Then
				checkEditShowMarkers.Checked = RadarSeriesView.MarkerVisibility <> DefaultBoolean.False
			End If
			EnableMarkerControls(checkEditShowMarkers.Checked)
		End Sub
	End Class
End Namespace
