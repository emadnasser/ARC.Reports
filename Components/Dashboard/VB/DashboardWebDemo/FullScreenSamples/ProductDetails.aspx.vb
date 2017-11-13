Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters

Partial Public Class ProductDetails
	Inherits Page
	Protected Sub OnViewerConfigureDataConnection(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs)
		Dim parameters As XmlFileConnectionParameters = TryCast(e.ConnectionParameters, XmlFileConnectionParameters)
		parameters.FileName = Server.MapPath("~\App_Data\DashboardProductDetails.xml")
	End Sub

	Protected Sub OnViewerDashboardLoaded(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.DashboardLoadedWebEventArgs)
		Dim applicationPath As String = Request.ApplicationPath.TrimEnd("/"c) & "/"
		Dim primaryImage As BoundImageDashboardItem = TryCast(e.Dashboard.Items("primaryImage"), BoundImageDashboardItem)
		If primaryImage IsNot Nothing Then
			primaryImage.UriPattern = applicationPath & "Content/ProductDetailsImages/{0}.jpg"
		End If
		Dim secondaryImage As BoundImageDashboardItem = TryCast(e.Dashboard.Items("secondaryImage"), BoundImageDashboardItem)
		If secondaryImage IsNot Nothing Then
			secondaryImage.UriPattern = applicationPath & "Content/ProductDetailsImages/{0} Secondary.jpg"
		End If
	End Sub
End Class
