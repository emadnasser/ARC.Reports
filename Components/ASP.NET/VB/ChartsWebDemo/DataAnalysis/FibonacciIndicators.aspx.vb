Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class FibonacciIndicators
	Inherits ChartBasePage
	Private Const fibonacciIndicatorName As String = "FibonacciIndicator"

	Private ReadOnly Property FibonacciIndicator() As FibonacciIndicator
		Get
			Return CType((CType(WebChartControl1.Series(0).View, XYDiagramSeriesViewBase)).Indicators(0), FibonacciIndicator)
		End Get
	End Property

	Private Sub UpdateCheckedState()
		Select Case FibonacciIndicator.Kind
			Case FibonacciIndicatorKind.FibonacciArcs
				chbLevel0.Checked = False
				chbLevel100.Checked = FibonacciIndicator.ShowLevel100
				chbAdditionalLevels.Checked = False
			Case FibonacciIndicatorKind.FibonacciFans
				chbLevel0.Checked = FibonacciIndicator.ShowLevel0
				chbLevel100.Checked = False
				chbAdditionalLevels.Checked = False
			Case FibonacciIndicatorKind.FibonacciRetracement
				chbLevel0.Checked = FibonacciIndicator.ShowLevel0
				chbLevel0.Checked = True
				chbLevel100.Checked = True
				chbAdditionalLevels.Checked = FibonacciIndicator.ShowAdditionalLevels
		End Select
		chbLevel23_6.Checked = FibonacciIndicator.ShowLevel23_6
		chbLevel76_4.Checked = FibonacciIndicator.ShowLevel76_4
	End Sub
	Private Sub UpdateEnabledState()
		Select Case FibonacciIndicator.Kind
			Case FibonacciIndicatorKind.FibonacciArcs
				chbLevel0.ClientEnabled = False
				chbLevel100.ClientEnabled = True
				chbAdditionalLevels.ClientEnabled = False
			Case FibonacciIndicatorKind.FibonacciFans
				chbLevel0.ClientEnabled = True
				chbLevel100.ClientEnabled = False
				chbAdditionalLevels.ClientEnabled = False
			Case FibonacciIndicatorKind.FibonacciRetracement
				chbLevel0.ClientEnabled = False
				chbLevel100.ClientEnabled = False
				chbAdditionalLevels.ClientEnabled = True
		End Select
	End Sub
	Private Sub SetFibonacciIndicator()
		Dim indicator As FibonacciIndicator = TryCast(Session(fibonacciIndicatorName), FibonacciIndicator)
		If indicator IsNot Nothing Then
			FibonacciIndicator.Assign(indicator)
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			SetFibonacciIndicator()
		Else
			Session(fibonacciIndicatorName) = FibonacciIndicator
			UpdateCheckedState()
		End If
		UpdateEnabledState()
	End Sub
	Protected Sub callbackPanel_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Select Case e.Parameter
			Case "Kind"
				FibonacciIndicator.Kind = CType(ComboBoxHelper.GetSelectedItem(cmbKind, GetType(FibonacciIndicatorKind)), FibonacciIndicatorKind)
			Case "0"
				FibonacciIndicator.ShowLevel0 = chbLevel0.Checked
			Case "100"
				FibonacciIndicator.ShowLevel100 = chbLevel100.Checked
			Case "23.6"
				FibonacciIndicator.ShowLevel23_6 = chbLevel23_6.Checked
			Case "76.4"
				FibonacciIndicator.ShowLevel76_4 = chbLevel76_4.Checked
			Case "Additional"
				FibonacciIndicator.ShowAdditionalLevels = chbAdditionalLevels.Checked
		End Select
		Session(fibonacciIndicatorName) = FibonacciIndicator
		UpdateCheckedState()
		UpdateEnabledState()
	End Sub
	Public Overrides Function FindWebChartControl() As WebChartControl
		Return WebChartControl1
	End Function
End Class
