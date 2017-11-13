Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts

Partial Public Class Bar3DStackedSideBySideSeries
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
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
			rbSex.Checked = True
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Private Sub PerformPerspectiveAngleAction()
		Diagram.PerspectiveAngle = ComboBoxHelper.GetSelectedPerspectiveAngle(cbPerspectiveAngle)
	End Sub
	Private Sub PerformZoomPercentAction()
		Diagram.ZoomPercent = Convert.ToInt32(cbZoomPercent.SelectedItem.Text)
	End Sub
	Protected Sub WebChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		For Each series As Series In WebChartControl1.Series
			Dim view As ISupportStackedGroup = TryCast(series.View, ISupportStackedGroup)
			Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
			If view IsNot Nothing Then
				view.StackedGroup = If(rbSex.Checked, genderAge.Gender, genderAge.Age)
			End If
		Next series
	End Sub
End Class
