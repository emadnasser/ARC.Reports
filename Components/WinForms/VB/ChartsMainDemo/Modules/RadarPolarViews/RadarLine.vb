Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarLineDemo
		Inherits RadarDemoBase
		Private WithEvents chart As ChartControl

		Protected Overrides Property ShowMarkers() As Boolean
			Get
				Return If(Me.seriesSelected IsNot Nothing AndAlso TypeOf seriesSelected.View Is RadarLineSeriesView, (CType(seriesSelected.View, RadarLineSeriesView)).MarkerVisibility <> DefaultBoolean.False, MyBase.ShowMarkers)
			End Get
			Set(ByVal value As Boolean)
				If Me.seriesSelected Is Nothing AndAlso Not(TypeOf seriesSelected.View Is RadarLineSeriesView) Then
					Return
				End If
				CType(Me.seriesSelected.View, RadarLineSeriesView).MarkerVisibility = If(value, DefaultBoolean.True, DefaultBoolean.False)
			End Set
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEditShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditShowMarkers.CheckedChanged
			If seriesSelected Is Nothing Then
				Return
			End If
			Dim view As RadarLineSeriesView = TryCast(seriesSelected.View, RadarLineSeriesView)
			If view IsNot Nothing Then
				view.MarkerVisibility = If(checkEditShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
			End If
			UpdateControls()
		End Sub
		Private Sub chart_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chart.VisibleChanged
			If Me.chart.Series.Count > 0 Then
				chart.SetObjectSelection(Me.chart.Series(0))
			End If
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If seriesSelected Is Nothing Then
				checkEditShowMarkers.Checked = False
				checkEditShowMarkers.Enabled = False
			Else
				Dim view As RadarLineSeriesView = TryCast(seriesSelected.View, RadarLineSeriesView)
				If view IsNot Nothing Then
					checkEditShowMarkers.Enabled = True
					checkEditShowMarkers.Checked = view.MarkerVisibility <> DefaultBoolean.False
					EnableMarkerControls(checkEditShowMarkers.Checked)
				End If
			End If
		End Sub
	End Class
End Namespace
