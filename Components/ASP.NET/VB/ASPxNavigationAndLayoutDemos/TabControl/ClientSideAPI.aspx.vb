Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class TabControl_ClientSideAPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		cbTabs.Items.Clear()
		For Each tabPage As TabPage In PageControl.TabPages
			cbTabs.Items.Add(New ListEditItem(tabPage.Text, tabPage.Name))
		Next tabPage
	End Sub
End Class
