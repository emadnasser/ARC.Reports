Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class SeriesTitles
	Inherits ChartBasePage
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = WebChartControl1.SeriesTemplate.LabelsVisibility <> DefaultBoolean.False
			ComboBoxHelper.PreparePieViewTypeComboBox(cbViewType)
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		WebChartControl1.SeriesTemplate.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformViewTypeAction()
		Dim viewType As ViewType
		Select Case cbViewType.SelectedItem.Text
			Case "Pie 3D"
				viewType = ViewType.Pie3D
			Case "Doughnut"
				viewType = ViewType.Doughnut
			Case "Doughnut 3D"
				viewType = ViewType.Doughnut3D
			Case Else
				viewType = ViewType.Pie
		End Select
		WebChartControl1.SeriesTemplate.ChangeView(viewType)
		Dim diagram As Diagram3D = TryCast(WebChartControl1.Diagram, Diagram3D)
		If diagram IsNot Nothing Then
			diagram.RuntimeRotation = True
			diagram.RuntimeScrolling = True
			diagram.RuntimeZooming = True
		End If
	End Sub
	Protected Sub WebChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
		If WebChartControl1.Series.Count > 0 AndAlso (Not ReferenceEquals(WebChartControl1.Series(0), e.Series)) Then
			e.LegendText = ""
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "ViewType" Then
			PerformViewTypeAction()
		End If
	End Sub
End Class
