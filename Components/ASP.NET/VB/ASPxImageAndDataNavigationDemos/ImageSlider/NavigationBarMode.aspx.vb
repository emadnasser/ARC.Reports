Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class ImageSlider_NavigationBarMode
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ImageSlider.SettingsNavigationBar.VisibleItemsCount = Convert.ToInt32(ddlItemCount.Value)
	End Sub
End Class
