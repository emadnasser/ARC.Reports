Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts

Partial Public Class StepLine3DSeries
	Inherits ChartBasePage
	Private ReadOnly Property Diagram() As Diagram3D
		Get
			Return CType(WebChartControl1.Diagram, Diagram3D)
		End Get
	End Property
	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property View() As StepLine3DSeriesView
		Get
			Return CType(Series.View, StepLine3DSeriesView)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
			cbInvertStep.Checked = View.InvertedStep
			ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle)
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "InvertStep" Then
			PerformInvertStepAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub PerformInvertStepAction()
		View.InvertedStep = cbInvertStep.Checked
	End Sub
	Private Sub PerformPerspectiveAngleAction()
		Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle)
	End Sub
	Private Sub PerformZoomPercentAction()
		Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text)
	End Sub
End Class


