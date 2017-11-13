Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class Pager_Example
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RegisterRequiresControlState(ASPxPager1)
	End Sub
	Protected Sub ASPxPager1_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		MultiView1.ActiveViewIndex = (TryCast(sender, ASPxPager)).PageIndex
	End Sub
End Class
