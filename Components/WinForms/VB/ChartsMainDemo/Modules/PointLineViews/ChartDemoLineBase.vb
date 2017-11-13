Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class ChartDemoLineBase
		Inherits PointDemoBase
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEditShowMarkers_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditShowMarkers.CheckedChanged
			For Each series As Series In ProcessedSeries
				If series IsNot Nothing Then
					Dim view As LineSeriesView = TryCast(series.View, LineSeriesView)
					If view IsNot Nothing Then
						view.MarkerVisibility = If(checkEditShowMarkers.Checked, DefaultBoolean.True, DefaultBoolean.False)
					End If
				End If
			Next series
			UpdateControls()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			Dim view As LineSeriesView = If(seriesSelected IsNot Nothing, TryCast(seriesSelected.View, LineSeriesView), Nothing)
			If view Is Nothing Then
				checkEditShowMarkers.Checked = False
				checkEditShowMarkers.Enabled = False
				Return
			End If
			checkEditShowMarkers.Enabled = True
			checkEditShowMarkers.Checked = view.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
			EnableMarkerControls(checkEditShowMarkers.Checked)
		End Sub
	End Class
End Namespace
