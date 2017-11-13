Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.SessionState
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraCharts.Web
Imports DevExpress.XtraCharts.Web.Designer

Partial Public Class ChartDesignerPage
	Inherits System.Web.UI.Page
	Private Shared Function LoadChartFromSession(ByVal session As HttpSessionState) As WebChartControl
		Dim layoutXml = CStr(session("ChartLayout"))
		If layoutXml Is Nothing Then
			Return Nothing
		End If
		Dim chart = New WebChartControl()
		chart.LoadFromXml(layoutXml)
		Return chart
	End Function

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Header.Title = "Chart Designer"
		If (Not IsPostBack) Then
			Dim chart As WebChartControl = LoadChartFromSession(Session)
			If chart Is Nothing Then
				Response.Redirect("~/Miscellaneous/ChartDesigner.aspx")
			End If
			chart.Width = CType(Session("ChartWidth"), Unit)
			chart.Height = CType(Session("ChartHeight"), Unit)
			Me.chartDesigner.OpenChart(chart)
		End If

	End Sub

	Protected Sub chartDesigner_SaveChartLayout(ByVal sender As Object, ByVal e As SaveChartLayoutEventArgs)
		Session("ChartLayout") = e.ChartLayoutXml
		ASPxWebControl.RedirectOnCallback("~/Miscellaneous/ChartDesigner.aspx")
	End Sub
End Class
