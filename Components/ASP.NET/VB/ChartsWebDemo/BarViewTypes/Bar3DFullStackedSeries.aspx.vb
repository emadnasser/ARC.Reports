Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Partial Public Class Bar3DFullStackedSeries
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
			cbShowFacet.Checked = (CType(series.View, Bar3DSeriesView)).ShowFacet
			If series IsNot Nothing AndAlso series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(series.Label.TextPattern)) Then
				cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP")
			End If
			ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle)
			ComboBoxHelper.PrepareTransparencyComboBox(cbTransparency, (CType(series.View, Bar3DSeriesView)).Transparency)
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
			ComboBoxHelper.PrepareBar3DModelComboBox(cb3DModel)
		End If

		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ValueAsPercent" Then
			PerformValueAsPercentAction()
		ElseIf e.Parameter = "Transparency" Then
			PerformTransparencyAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "ShowFacet" Then
			PerformShowFacetAction()
		ElseIf e.Parameter = "Bar3DModel" Then
			PerformBar3DModelAction()
		End If
	End Sub
	Private Sub PerformShowFacetAction()
		CType(WebChartControl1.SeriesTemplate.View, Bar3DSeriesView).ShowFacet = cbShowFacet.Checked
	End Sub
	Private Sub PerformBar3DModelAction()
		Dim model As Bar3DModel = CType(cb3DModel.SelectedIndex, Bar3DModel)
		CType(WebChartControl1.SeriesTemplate.View, Bar3DSeriesView).Model = model
	End Sub
	Private Sub PerformValueAsPercentAction()
		Dim labeltextPattern As String = If(cbValueAsPercent.Checked, "{VP:P0}", "{V:F1}K")
		WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern
	End Sub
	Private Sub PerformTransparencyAction()
		Dim transparency As Byte = Convert.ToByte(cbTransparency.SelectedItem.Text)
		CType(WebChartControl1.SeriesTemplate.View, Bar3DSeriesView).Transparency = transparency
	End Sub
	Private Sub PerformPerspectiveAngleAction()
		Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle)
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub PerformZoomPercentAction()
		Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text)
	End Sub
End Class
