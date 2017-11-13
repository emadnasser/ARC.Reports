Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Xml
Imports DevExpress.Utils
Imports DevExpress.Web
Imports System.Collections.Generic

Partial Public Class UserControls_ActionToolbar
	Inherits System.Web.UI.UserControl

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SearchBoxSpacer.Visible = IsSearchBoxVisible()
		SearchBox.Visible = SearchBoxSpacer.Visible

		ActionMenuDataSource.XPath = String.Format("Pages/{0}/Item", Utils.CurrentPageName)
		InfoMenu.ShowPopOutImages = DefaultBoolean.False
		ActionMenu.ShowPopOutImages = InfoMenu.ShowPopOutImages
	End Sub

	Protected Sub ActionMenu_ItemDataBound(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		Dim itemHierarchyData As IHierarchyData = CType(e.Item.DataItem, IHierarchyData)
		Dim element = CType(itemHierarchyData.Item, XmlElement)

		Dim classAttr = element.Attributes("SpriteClassName")
		If classAttr IsNot Nothing Then
			e.Item.Image.SpriteProperties.CssClass = classAttr.Value
		End If

		If e.Item.Parent Is e.Item.Menu.RootItem Then
			e.Item.ClientVisible = False
		End If
	End Sub

	Protected Sub InfoMenu_OnItemDataBound(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		Dim itemHierarchyData As IHierarchyData = CType(e.Item.DataItem, IHierarchyData)
		Dim element = CType(itemHierarchyData.Item, XmlElement)

		Dim classAttr = element.Attributes("SpriteClassName")
		If classAttr IsNot Nothing Then
			e.Item.Image.SpriteProperties.CssClass = classAttr.Value
		End If

		If e.Item.Parent.Name = "theme" AndAlso e.Item.Name Is Utils.CurrentTheme Then
			e.Item.Selected = True
		End If

		If e.Item.Name = "print" Then
			Dim url = GetPrintItemNavigationUrl()
			If String.IsNullOrEmpty(url) Then
				e.Item.Visible = False
			Else
				e.Item.NavigateUrl = url
			End If
		End If
		If e.Item.Name = "DownloadTrial" Then
			e.Item.NavigateUrl = AssemblyInfo.DXLinkTrial
		End If
		If e.Item.Name = "BuyNow" Then
			e.Item.NavigateUrl = AssemblyInfo.DXLinkBuyNowASP
		End If
	End Sub

	Protected Function GetPrintItemNavigationUrl() As String
		Select Case Utils.CurrentPageName
			Case "mail"
				Return "../PrintMails.aspx"
			Case "calendar"
				Return "../PrintSchedule.aspx"
			Case "contacts"
				Return "../PrintContacts.aspx"
		End Select
		Return String.Empty
	End Function

	Protected Function IsSearchBoxVisible() As Boolean
		Select Case Utils.CurrentPageName
			Case "mail", "contacts", "feeds"
				Return True
		End Select
		Return False
	End Function
End Class
