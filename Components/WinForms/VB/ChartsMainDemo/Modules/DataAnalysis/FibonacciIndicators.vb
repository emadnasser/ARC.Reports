Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class FibonacciIndicatorsDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property FibonacciIndicator() As FibonacciIndicator
			Get
				If chart.Series.Count = 0 Then
					Return Nothing
				End If
				Dim view As XYDiagram2DSeriesViewBase = TryCast(chart.Series(0).View, XYDiagram2DSeriesViewBase)
				If view Is Nothing Then
					Return Nothing
				End If
				For Each indicator As Indicator In view.Indicators
					Dim fibIndicator As FibonacciIndicator = TryCast(indicator, FibonacciIndicator)
					If fibIndicator IsNot Nothing Then
						Return fibIndicator
					End If
				Next indicator
				Return Nothing
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			UpdateControls()
		End Sub

		Private Sub cbeKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeKind.SelectedIndexChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.Kind = CType(cbeKind.SelectedIndex, FibonacciIndicatorKind)
				UpdateControls()
			End If
		End Sub
		Private Sub cheLevel0_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheLevel0.CheckedChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.ShowLevel0 = cheLevel0.Checked
			End If
		End Sub
		Private Sub cheLevel100_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheLevel100.CheckedChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.ShowLevel100 = cheLevel100.Checked
			End If
		End Sub
		Private Sub cheLevel23_6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheLevel23_6.CheckedChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.ShowLevel23_6 = cheLevel23_6.Checked
			End If
		End Sub
		Private Sub cheLevel76_4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheLevel76_4.CheckedChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.ShowLevel76_4 = cheLevel76_4.Checked
			End If
		End Sub
		Private Sub cheAdditionalLevels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheAdditionalLevels.CheckedChanged
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				fibIndicator.ShowAdditionalLevels = cheAdditionalLevels.Checked
			End If
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ChartControl.Series(0).DataSource = MarketPrices.GetAppleStockPrices()
		End Sub
		Public Overrides Sub UpdateControls()
			Dim fibIndicator As FibonacciIndicator = FibonacciIndicator
			If fibIndicator IsNot Nothing Then
				cbeKind.SelectedIndex = CInt(Fix(fibIndicator.Kind))
				Select Case fibIndicator.Kind
					Case FibonacciIndicatorKind.FibonacciArcs
						cheLevel0.Checked = False
						cheLevel0.Enabled = False
						cheLevel100.Enabled = True
						cheLevel100.Checked = fibIndicator.ShowLevel100
						cheAdditionalLevels.Checked = False
						cheAdditionalLevels.Enabled = False
					Case FibonacciIndicatorKind.FibonacciFans
						cheLevel0.Checked = fibIndicator.ShowLevel0
						cheLevel0.Enabled = True
						cheLevel100.Checked = False
						cheLevel100.Enabled = False
						cheAdditionalLevels.Checked = False
						cheAdditionalLevels.Enabled = False
					Case FibonacciIndicatorKind.FibonacciRetracement
						cheLevel0.Checked = fibIndicator.ShowLevel0
						cheLevel0.Checked = True
						cheLevel0.Enabled = False
						cheLevel100.Checked = True
						cheLevel100.Enabled = False
						cheAdditionalLevels.Enabled = True
						cheAdditionalLevels.Checked = fibIndicator.ShowAdditionalLevels
				End Select
				cheLevel23_6.Checked = fibIndicator.ShowLevel23_6
				cheLevel76_4.Checked = fibIndicator.ShowLevel76_4
			End If
		End Sub
	End Class
End Namespace
