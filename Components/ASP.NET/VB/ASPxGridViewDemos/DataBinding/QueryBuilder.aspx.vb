Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports DevExpress.XtraReports.Web
Imports System
Imports System.Web.UI

Partial Public Class DataBinding_QueryBuilder
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Header.Title = Utils.GetCurrentDemoPageTitle()
		If (Not IsPostBack) Then
			queryBuilder.OpenConnection(QueryBuilderHelper.NorthwindConnectionParameters, QueryBuilderHelper.LoadQuery(Session))
		End If
		QueryBuilderHelper.HideTooltip(Session)
	End Sub
	Protected Sub queryBuilder_SaveQuery(ByVal sender As Object, ByVal e As SaveQueryEventArgs)
		QueryBuilderHelper.SaveQuery(e.SelectStatement, e.ResultQuery, Session)
		ASPxWebControl.RedirectOnCallback("~/DataBinding/QueryBuilderControl.aspx")
	End Sub
End Class
