Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class ErrorBars
	Inherits ChartBasePage
	Private ReadOnly indicatorColor As Color = Color.Black

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Private Sub SetDirection()
		Dim selectedDirection As String = CStr(cmbDirection.SelectedItem.Value)
		Dim view As XYDiagram2DSeriesViewBase = CType(WebChartControl1.Series(0).View, XYDiagram2DSeriesViewBase)
		Dim indicator = CType(view.Indicators(0), DevExpress.XtraCharts.ErrorBars)
		Select Case selectedDirection
			Case ""
				Return
			Case "Both"
				indicator.Direction = ErrorBarDirection.Both
			Case "Minus"
				indicator.Direction = ErrorBarDirection.Minus
			Case "Plus"
				indicator.Direction = ErrorBarDirection.Plus
			Case Else
				Throw New Exception(String.Format("The {0} error bar direction is unknown.", selectedDirection))
		End Select
	End Sub
	Private Sub SetEndStyle()
		Dim selectedStyle As String = CStr(cmbEndStyle.SelectedItem.Value)
		Dim view As XYDiagram2DSeriesViewBase = CType(WebChartControl1.Series(0).View, XYDiagram2DSeriesViewBase)
		If view.Indicators.Count = 0 Then
			Return
		End If
		Dim indicator = CType(view.Indicators(0), DevExpress.XtraCharts.ErrorBars)
		Select Case selectedStyle
			Case ""
				Return
			Case "Cap"
				indicator.EndStyle = ErrorBarEndStyle.Cap
			Case "No Cap"
				indicator.EndStyle = ErrorBarEndStyle.NoCap
			Case Else
				Throw New Exception(String.Format("The {0} error bar end style is unknown.", selectedStyle))
		End Select
	End Sub
	Private Sub SetSeriesView()
		Dim selectedViewString As String = CStr(cmbSeriesView.SelectedItem.Value)
		Select Case selectedViewString
			Case ""
				Return
			Case "Bar"
				WebChartControl1.Series(0).ChangeView(ViewType.Bar)
			Case "Point"
				WebChartControl1.Series(0).ChangeView(ViewType.Point)
			Case Else
				Throw New Exception(String.Format("The {0} series view is unknown.", selectedViewString))
		End Select
	End Sub
	Private Sub CreateIndicator()
		Dim selectedErrorBarKind As String = CStr(cmbKind.SelectedItem.Value)
		Dim view As XYDiagram2DSeriesViewBase = CType(WebChartControl1.Series(0).View, XYDiagram2DSeriesViewBase)
		view.Indicators.Clear()
		Select Case selectedErrorBarKind
			Case ""
				Return
			Case "Fixed Values"
				view.Indicators.Add(New FixedValueErrorBars() With {.NegativeError = 1, .PositiveError = 3, .Color = Me.indicatorColor})
			Case "Percentage"
				view.Indicators.Add(New PercentageErrorBars() With {.Percent = 10, .Color = Me.indicatorColor})
			Case "Standard Deviation"
				view.Indicators.Add(New StandardDeviationErrorBars() With {.Multiplier = 1, .Color = Me.indicatorColor})
			Case "Standard Error"
				view.Indicators.Add(New StandardErrorBars() With {.Color = Me.indicatorColor})
			Case "Data Source"
				view.Indicators.Add(New DataSourceBasedErrorBars() With {.NegativeErrorDataMember = "NegativeError", .PositiveErrorDataMember = "PositiveError", .Color = Me.indicatorColor})
				WebChartControl1.RefreshData()
			Case Else
				Throw New Exception(String.Format("The {0} error bar kind is unknown.", selectedErrorBarKind))
		End Select
		SetDirection()
		SetEndStyle()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SetSeriesView()
			CreateIndicator()
			SetEndStyle()
			SetDirection()
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ChangeSeriesView" Then
			SetSeriesView()
		ElseIf e.Parameter = "ChangeErrorBarsKind" Then
			CreateIndicator()
		ElseIf e.Parameter = "ChangeEndStyle" Then
			SetEndStyle()
		ElseIf e.Parameter = "ChangeErrorBarsDirection" Then
			SetDirection()
		End If
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
