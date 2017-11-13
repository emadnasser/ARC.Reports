Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web

Partial Public Class TitleIndex_Grouping
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim groupingField As String = HttpContext.Current.Request.QueryString("gfield")
		Dim activeTabIndex As Integer = 1
		If (Not String.IsNullOrEmpty(groupingField)) Then
			activeTabIndex = ASPxTabControl1.Tabs.IndexOfName(groupingField)
		End If
		If activeTabIndex >= 1 Then
			ASPxTitleIndex1.GroupHeaderFormatString = "{0} ({1})"
		End If
		ASPxTabControl1.ActiveTabIndex = If(activeTabIndex > 0, activeTabIndex, 0)
		ASPxTitleIndex1.GroupingField = ASPxTabControl1.ActiveTab.Name
	End Sub
End Class
