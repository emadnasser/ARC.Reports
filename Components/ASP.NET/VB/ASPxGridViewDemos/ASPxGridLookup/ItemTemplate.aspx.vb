Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxGridLookup_ItemTemplate
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		GridLookup.GridView.Width = 300
		AddHandler GridLookup.GridView.DataBound, AddressOf GridView_DataBound
		AddHandler GridLookup.GridView.BeforeGetCallbackResult, AddressOf GridView_BeforeGetCallbackResult
	End Sub
	Protected Sub GridView_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		GridLookup.GridView.Settings.VerticalScrollBarMode = If(GridLookup.GridView.VisibleRowCount <= 2, ScrollBarMode.Hidden, ScrollBarMode.Visible)
	End Sub

	Private Sub GridView_BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
		GridLookup.GridView.DataBind()
	End Sub
End Class
