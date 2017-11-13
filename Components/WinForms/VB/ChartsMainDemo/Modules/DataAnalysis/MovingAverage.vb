Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class MovingAverageDemo
		Inherits ChartDemoBase2D
		Private WithEvents chart As ChartControl

		Private ReadOnly Property MovingAverageIndicators() As List(Of MovingAverage)
			Get
				If Series Is Nothing Then
					Return Nothing
				End If
				Dim view As XYDiagram2DSeriesViewBase = TryCast(Series.View, XYDiagram2DSeriesViewBase)
				If view Is Nothing Then
					Return Nothing
				End If
				Dim movingAverageIndicators_Renamed As New List(Of MovingAverage)()
				For Each indicator As Indicator In view.Indicators
					Dim movingAverage As MovingAverage = TryCast(indicator, MovingAverage)
					If movingAverage IsNot Nothing Then
						movingAverageIndicators_Renamed.Add(movingAverage)
					End If
				Next indicator
				If movingAverageIndicators_Renamed IsNot Nothing Then
					Return movingAverageIndicators_Renamed
				End If
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Private ReadOnly Property Series() As Series
			Get
				Return If(ChartControl.Series.Count > 0, ChartControl.Series(0), Nothing)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SetVisibleIndicator()
			If MovingAverageIndicators Is Nothing Then
				Return
			End If
			Select Case CStr(cbType.SelectedItem)
				Case "Simple"
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is SimpleMovingAverage
					Next indicator
				Case "Exponential"
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is ExponentialMovingAverage
					Next indicator
				Case "Weighted"
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is WeightedMovingAverage
					Next indicator
				Case "Triangular"
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is TriangularMovingAverage
					Next indicator
				Case "Triple Exponential (TEMA)"
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is TripleExponentialMovingAverageTema
					Next indicator
				Case Else
					For Each indicator As MovingAverage In MovingAverageIndicators
						indicator.Visible = TypeOf indicator Is SimpleMovingAverage
					Next indicator
			End Select
		End Sub
		Private Sub cbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbType.SelectedIndexChanged
			SetVisibleIndicator()
		End Sub
		Private Sub spnPointsCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnPointsCount.EditValueChanged
			If MovingAverageIndicators Is Nothing Then
				Return
			End If
			For Each indicator As MovingAverage In MovingAverageIndicators
				indicator.PointsCount = Convert.ToInt32(spnPointsCount.EditValue)
			Next indicator
		End Sub
		Private Sub cbKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbKind.SelectedIndexChanged
			If MovingAverageIndicators Is Nothing Then
				Return
			End If
			For Each indicator As MovingAverage In MovingAverageIndicators
				indicator.Kind = CType(cbKind.SelectedIndex, MovingAverageKind)
			Next indicator
			UpdateControls()
		End Sub
		Private Sub spnEnvelopPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spnEnvelopPercent.EditValueChanged
			If MovingAverageIndicators Is Nothing Then
				Return
			End If
			For Each indicator As MovingAverage In MovingAverageIndicators
				indicator.EnvelopePercent = Convert.ToDouble(spnEnvelopPercent.EditValue)
			Next indicator
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			If Series IsNot Nothing AndAlso Series.Points.Count > 0 Then
				spnPointsCount.Properties.MaxValue = Series.Points.Count
				If MovingAverageIndicators.Count > 0 Then
					If MovingAverageIndicators(0) IsNot Nothing Then
						cbKind.SelectedIndex = CInt(Fix(MovingAverageIndicators(0).Kind))
						spnPointsCount.EditValue = MovingAverageIndicators(0).PointsCount
						spnEnvelopPercent.EditValue = MovingAverageIndicators(0).EnvelopePercent
					End If
				End If
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			Series.DataSource = MarketPrices.GetGoogleStockPrices()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			SetVisibleIndicator()
			Dim enableEnvelopPercent As Boolean = cbKind.SelectedItem.ToString() <> "Moving Average"
			lblEnvelopPercent.Enabled = enableEnvelopPercent
			spnEnvelopPercent.Enabled = enableEnvelopPercent
		End Sub

		Private Sub lblKind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblKind.Click

		End Sub
	End Class
End Namespace
