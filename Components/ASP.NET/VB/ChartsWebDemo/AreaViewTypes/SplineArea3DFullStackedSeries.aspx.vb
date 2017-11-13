Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Partial Public Class SplineArea3DFullStackedSeries
	Inherits ChartBasePage
	Private ReadOnly Property Diagram() As Diagram3D
		Get
			Return CType(WebChartControl1.Diagram, Diagram3D)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Dim series As SeriesBase = WebChartControl1.SeriesTemplate
			cbShowLabels.Checked = series.LabelsVisibility <> DevExpress.Utils.DefaultBoolean.False
			ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle)
			ComboBoxHelper.PrepareTransparencyComboBox(cbTransparency, (CType(series.View, FullStackedSplineArea3DSeriesView)).Transparency)
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "Transparency" Then
			PerformTransparencyAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub PerformTransparencyAction()
		Dim transparency As Byte = Convert.ToByte(cbTransparency.SelectedItem.Text)
		CType(WebChartControl1.SeriesTemplate.View, FullStackedSplineArea3DSeriesView).Transparency = transparency
	End Sub
	Private Sub PerformPerspectiveAngleAction()
		Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle)
	End Sub
	Private Sub PerformZoomPercentAction()
		Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text)
	End Sub
End Class
