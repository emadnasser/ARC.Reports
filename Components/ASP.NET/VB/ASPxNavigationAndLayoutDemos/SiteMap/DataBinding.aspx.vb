Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Web

Partial Public Class SiteMap_DataBinding
	Inherits Page
	Private ReadOnly Property CurrentSiteMapProvider() As String
		Get
			Return ddlSiteMapProvider.SelectedItem.Value.ToString()
		End Get
	End Property

	Private ReadOnly Property CurrentStartingNodeUrl() As String
		Get
			Return ddlStartingNodeUrl.SelectedItem.Value.ToString()
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) OrElse ASPxSiteMapDataSource1.SiteMapProvider <> CurrentSiteMapProvider Then
			ASPxSiteMapDataSource1.SiteMapProvider = CurrentSiteMapProvider
			ddlStartingNodeUrl.Items.Clear()
			ddlStartingNodeUrl.Items.Add(New ListEditItem(" ", ""))
			ddlStartingNodeUrl.SelectedIndex = 0
			For Each node As SiteMapNode In ASPxSiteMapDataSource1.Provider.RootNode.ChildNodes
				ddlStartingNodeUrl.Items.Add(New ListEditItem(node.Title, node.Url))
			Next node
		End If
		ASPxSiteMapDataSource1.StartingNodeUrl = CurrentStartingNodeUrl
		ASPxSiteMapDataSource1.ShowStartingNode = cbShowStartingNode.Checked
	End Sub
End Class
