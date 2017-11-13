Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Collections.Generic
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
Imports System.Diagnostics
Imports System.Data

Partial Public Class MovingAveragePage
	Inherits ChartBasePage
	Private ReadOnly Property AxisX() As Axis
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisX
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property MovingAverageIndicators() As List(Of MovingAverage)
		Get
			If WebChartControl1.Series.Count = 0 Then
				Return Nothing
			End If
			Dim view As XYDiagram2DSeriesViewBase = TryCast(WebChartControl1.Series(0).View, XYDiagram2DSeriesViewBase)
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

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ComboBoxHelper.PrepareComboBox(cmbType, New String() { "Simple", "Exponential", "Weighted", "Triangular", "Triple Exponential (TEMA)" })
			ComboBoxHelper.PrepareComboBox(cmbKind, New String() { "Moving Average", "Envelope", "Moving Average And Envelope" })
			spnPointsCount.MaxValue = (CType(chartDataSource.Select(), DataView)).Table.Rows.Count
			If MovingAverageIndicators.Count > 0 Then
				If MovingAverageIndicators(0) IsNot Nothing Then
					cmbKind.SelectedIndex = CInt(Fix(MovingAverageIndicators(0).Kind))
					spnPointsCount.Value = MovingAverageIndicators(0).PointsCount
					spnEnvelopePercent.Value = MovingAverageIndicators(0).EnvelopePercent
				End If
			End If
			SetVisibleIndicator()
		End If
		Dim enableEnvelopePercent As Boolean = CStr(cmbKind.Value) = "Envelope" OrElse CStr(cmbKind.Value) = "Moving Average And Envelope"
		lblEnvelopePercent.ClientEnabled = enableEnvelopePercent
		spnEnvelopePercent.ClientEnabled = enableEnvelopePercent
	End Sub
	Private Sub SetVisibleIndicator()
		Select Case CStr(cmbType.Value)
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
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "Type" Then
			 PerformTypeAction()
		ElseIf e.Parameter = "Kind" Then
			 PerformKindAction()
		ElseIf e.Parameter = "PointsCount" Then
			 PerformPointsCountAction()
		ElseIf e.Parameter = "EnvelopePercent" Then
			 PerformEnvelopePercentAction()
		End If
	End Sub
	Private Sub PerformTypeAction()
		SetVisibleIndicator()
	End Sub
	Private Sub PerformKindAction()
		For Each indicator As MovingAverage In MovingAverageIndicators
			indicator.Kind = CType(cmbKind.SelectedIndex, MovingAverageKind)
		Next indicator
	End Sub
	Private Sub PerformPointsCountAction()
		For Each indicator As MovingAverage In MovingAverageIndicators
			indicator.PointsCount = Convert.ToInt32(spnPointsCount.Value)
		Next indicator
	End Sub
	Private Sub PerformEnvelopePercentAction()
		For Each indicator As MovingAverage In MovingAverageIndicators
			indicator.EnvelopePercent = Convert.ToDouble(spnEnvelopePercent.Value)
		Next indicator
	End Sub
End Class
