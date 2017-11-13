Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class SecondaryAxes
	Inherits ChartBasePage
	Private Const SecondaryPostfixX As String = " (Secondary Axis X)"
	Private Const SecondaryPostfixY As String = " (Secondary Axis Y)"
	Private Const PrimaryPostfixX As String = " (Primary Axis X)"
	Private Const PrimaryPostfixY As String = " (Primary Axis Y)"
	Private Const PrimarySeriesName As String = "Series 1"
	Private Const SecondarySeriesName As String = "Series 2"
	Private Const LineChart As Integer = 0
	Private Const BarChart As Integer = 1
	Private Const PrimaryAxis As Integer = 0
	Private Const SecondaryAxis As Integer = 1

	Private ReadOnly Property Diagram() As XYDiagram
		Get
			Return CType(WebChartControl1.Diagram, XYDiagram)
		End Get
	End Property
	Private ReadOnly Property SecondaryAxisX() As SecondaryAxisX
		Get
			Return If(Diagram.SecondaryAxesX.Count > 0, Diagram.SecondaryAxesX(0), Nothing)
		End Get
	End Property
	Private ReadOnly Property SecondaryAxisY() As SecondaryAxisY
		Get
			Return If(Diagram.SecondaryAxesY.Count > 0, Diagram.SecondaryAxesY(0), Nothing)
		End Get
	End Property
	Private ReadOnly Property PrimarySeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName(PrimarySeriesName)
		End Get
	End Property
	Private ReadOnly Property SecondarySeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName(SecondarySeriesName)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			InitializeStartState()
			cbShowLabels.Checked = WebChartControl1.Series(0).LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareChartTypeComboBox(cbChartType)
			ComboBoxHelper.PrepareSeriesAxisXComboBox(cbSeriesAxisX)
			ComboBoxHelper.PrepareSeriesAxisYComboBox(cbSeriesAxisY)
		End If
	End Sub
	Private Sub AttachSecondaryAxisX()
		If SecondaryAxisX Is Nothing Then
			Return
		End If
		SecondaryAxisX.Visibility = DefaultBoolean.True
		CType(SecondarySeries.View, XYDiagramSeriesViewBase).AxisX = SecondaryAxisX
		SecondaryAxisX.Title.Text = SecondarySeriesName & SecondaryPostfixX
		Diagram.AxisX.Title.Text = PrimarySeriesName & PrimaryPostfixX
	End Sub
	Private Sub AttachSecondaryAxisY()
		If SecondaryAxisY Is Nothing Then
			Return
		End If
		SecondaryAxisY.Visibility = DefaultBoolean.True
		CType(SecondarySeries.View, XYDiagramSeriesViewBase).AxisY = SecondaryAxisY
		SecondaryAxisY.Title.Text = SecondarySeriesName & SecondaryPostfixY
		Diagram.AxisY.Title.Text = PrimarySeriesName & PrimaryPostfixY
	End Sub
	Private Sub DetachSecondaryAxisX()
		SecondaryAxisX.Visibility = DefaultBoolean.False
		CType(SecondarySeries.View, XYDiagramSeriesViewBase).AxisX = Diagram.AxisX
		Diagram.AxisX.Title.Text = PrimarySeriesName & ", " & SecondarySeriesName & PrimaryPostfixX
	End Sub
	Private Sub DetachSecondaryAxisY()
		SecondaryAxisY.Visibility = DefaultBoolean.False
		CType(SecondarySeries.View, XYDiagramSeriesViewBase).AxisY = Diagram.AxisY
		Diagram.AxisY.Title.Text = PrimarySeriesName & ", " & SecondarySeriesName & PrimaryPostfixY
	End Sub
	Private Sub InitializeStartState()
		Diagram.SecondaryAxesX.Add(New SecondaryAxisX("axisX"))
		Diagram.SecondaryAxesY.Add(New SecondaryAxisY("axisY"))
		SecondaryAxisX.Title.Visibility = DefaultBoolean.True
		SecondaryAxisY.Title.Visibility = DefaultBoolean.True
		DetachSecondaryAxisX()
		AttachSecondaryAxisY()
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformShowAxisXAction()
		If cbSeriesAxisX.SelectedIndex = PrimaryAxis Then
			DetachSecondaryAxisX()
		ElseIf cbSeriesAxisX.SelectedIndex = SecondaryAxis Then
			AttachSecondaryAxisX()
		End If
	End Sub
	Private Sub PerformShowAxisYAction()
		If cbSeriesAxisY.SelectedIndex = PrimaryAxis Then
			DetachSecondaryAxisY()
		ElseIf cbSeriesAxisY.SelectedIndex = SecondaryAxis Then
			AttachSecondaryAxisY()
		End If
	End Sub
	Private Sub PerformChangeChartTypeAction()
		Dim viewType As ViewType = GetCurrentViewType()
		For Each series As Series In WebChartControl1.Series
			series.ChangeView(viewType)
		Next series
	End Sub
	Private Function GetCurrentViewType() As ViewType
		If cbChartType.SelectedIndex = LineChart Then
			Return ViewType.Line
		End If
		If cbChartType.SelectedIndex = BarChart Then
			Return ViewType.Bar
		End If
		Return ViewType.Line
	End Function
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		Select Case e.Parameter
			Case "ShowLabels"
				PerformShowLabelsAction()
			Case "ChangeChartType"
				PerformChangeChartTypeAction()
			Case "ChangeSeriesTwoAxisX"
				PerformShowAxisXAction()
			Case "ChangeSeriesTwoAxisY"
				PerformShowAxisYAction()
		End Select
	End Sub
End Class
