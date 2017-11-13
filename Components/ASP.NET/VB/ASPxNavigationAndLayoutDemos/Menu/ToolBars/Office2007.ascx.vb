Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Xml
Imports DevExpress.Web

Partial Public Class Menu_Toolbars_Office2007
	Inherits UserControl

	Protected Sub ASPxMenu1_ItemDataBound(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		If e.Item.Depth <> 0 Then
			Return
		End If
		Dim itemHierarchyData As IHierarchyData = (TryCast(e.Item.DataItem, IHierarchyData))
		Dim ucItemTemplate As Control = LoadControl("Office2007Children.ascx")
		e.Item.Template = TryCast(ucItemTemplate, ITemplate)
		DataBindUserControl(itemHierarchyData, ucItemTemplate)
	End Sub

	Protected Sub DataBindUserControl(ByVal itemHierarchyData As IHierarchyData, ByVal userControl As Control)
		Dim xmlElement As XmlElement = TryCast(itemHierarchyData.Item, XmlElement)

		Dim rPanel As ASPxRoundPanel = TryCast(userControl.FindControl("rpRibbon"), ASPxRoundPanel)
		If rPanel Is Nothing Then
			Return
		End If

		Dim menu As ASPxMenu = TryCast(rPanel.FindControl("mRibbonChilds"), ASPxMenu)
		If menu Is Nothing Then
			Return
		End If


		Dim headerText As Label = TryCast(rPanel.FindControl("lblWatch"), Label)
		If headerText IsNot Nothing Then
			headerText.Text = If(xmlElement.Attributes("Text") IsNot Nothing, xmlElement.Attributes("Text").Value, "")
		End If

		Dim ds As XmlDataSource = TryCast(userControl.FindControl("XmlDataSource1"), XmlDataSource)
		If ds IsNot Nothing Then
			ds.XPath = itemHierarchyData.Path & "/*"
		End If
	End Sub
End Class
