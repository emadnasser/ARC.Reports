Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraCharts

Partial Public Class Bar3DFullStackedSideBySideSeries
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
			If series IsNot Nothing AndAlso series.Label IsNot Nothing AndAlso (Not String.IsNullOrEmpty(series.Label.TextPattern)) Then
				cbValueAsPercent.Checked = series.Label.TextPattern.Contains("VP")
			End If
			ComboBoxHelper.PreparePerspectiveAngleComboBox(cbPerspectiveAngle)
			ComboBoxHelper.PrepareZoomPercentComboBox(cbZoomPercent, Diagram.ZoomPercent)
			rbSex.Checked = True
		End If

		cbValueAsPercent.ClientEnabled = cbShowLabels.Checked
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Web.CustomCallbackEventArgs)
		If e.Parameter = "ValueAsPercent" Then
			PerformValueAsPercentAction()
		ElseIf e.Parameter = "PerspectiveAngle" Then
			PerformPerspectiveAngleAction()
		ElseIf e.Parameter = "ZoomPercent" Then
			PerformZoomPercentAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
	Private Sub PerformValueAsPercentAction()
		Dim labeltextPattern As String = If(cbValueAsPercent.Checked, "{VP:P0}", "{V:0,,.00}")
		WebChartControl1.SeriesTemplate.Label.TextPattern = labeltextPattern
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
