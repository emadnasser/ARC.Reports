Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Web

Partial Public Class ScaleBreaks
	Inherits ChartBasePage
	Private ReadOnly Property AxisY() As Axis
		Get
			Return (CType(WebChartControl1.Diagram, XYDiagram)).AxisY
		End Get
	End Property
	Private ReadOnly Property Breaks() As ScaleBreakCollection
		Get
			Return AxisY.ScaleBreaks
		End Get
	End Property
	Private ReadOnly Property Options() As ScaleBreakOptions
		Get
			Return AxisY.ScaleBreakOptions
		End Get
	End Property
	Private ReadOnly Property Label() As SeriesLabelBase
		Get
			Return WebChartControl1.Series(0).Label
		End Get
	End Property
	Private ReadOnly Property AutoScaleBreaks() As AutoScaleBreaks
		Get
			Return AxisY.AutoScaleBreaks
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			chbShowLabels.Checked = Series.LabelsVisibility = DefaultBoolean.True
			chbShowScaleBreaks.Checked = AutoScaleBreaks.Enabled
			ComboBoxHelper.PrepareComboBox(cbStyle, Options.Style)
			spnSize.Value = Options.SizeInPixels
			spnMaxCount.Value = AutoScaleBreaks.MaxCount
			ceColor.Color = Options.Color
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "ShowScaleBreaks" Then
			PerformShowScaleBreaksAction()
		ElseIf e.Parameter = "ChangeStyle" Then
			PerformChangeStyleAction()
		ElseIf e.Parameter = "ChangeSize" Then
			PerformChangeSizeAction()
		ElseIf e.Parameter = "ChangeColor" Then
			PerformChangeColorAction()
		ElseIf e.Parameter = "ResetColor" Then
			PerformResetColorAction()
		ElseIf e.Parameter = "ChangeMaxCount" Then
			PerformChangeMaxCountAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(chbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(chbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformShowScaleBreaksAction()
		AutoScaleBreaks.Enabled = chbShowScaleBreaks.Checked
	End Sub
	Private Sub PerformChangeStyleAction()
		Options.Style = CType(ComboBoxHelper.GetSelectedItem(cbStyle, GetType(ScaleBreakStyle)), ScaleBreakStyle)
	End Sub
	Private Sub PerformChangeSizeAction()
		Options.SizeInPixels = Convert.ToInt32(spnSize.Value)
	End Sub
	Private Sub PerformChangeColorAction()
		Options.Color = ceColor.Color
	End Sub
	Private Sub PerformResetColorAction()
		Options.Color = Color.Empty
	End Sub
	Private Sub PerformChangeMaxCountAction()
		AutoScaleBreaks.MaxCount = Convert.ToInt32(spnMaxCount.Value)
	End Sub
End Class
