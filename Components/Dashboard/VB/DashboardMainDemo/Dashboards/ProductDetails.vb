Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters

Namespace DashboardMainDemo.Dashboards
	Partial Public Class ProductDetails
		Inherits Dashboard
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub ProductDetails_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs) Handles MyBase.ConfigureDataConnection
			Dim parameters As XmlFileConnectionParameters = TryCast(e.ConnectionParameters, XmlFileConnectionParameters)
			parameters.FileName = DataLoader.GetProductDetailsXmlDataSource()
		End Sub

		Private Sub ProductDetails_DashboardLoading(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DashboardLoading
			Dim primaryImage As BoundImageDashboardItem = TryCast(Me.Items("primaryImage"), BoundImageDashboardItem)
			If primaryImage IsNot Nothing Then
				primaryImage.UriPattern = DataLoader.GetImagesFolder() & "\{0}.jpg"
			End If
			Dim secondaryImage As BoundImageDashboardItem = TryCast(Me.Items("secondaryImage"), BoundImageDashboardItem)
			If secondaryImage IsNot Nothing Then
				secondaryImage.UriPattern = DataLoader.GetImagesFolder() & "\{0} Secondary.jpg"
			End If
		End Sub
	End Class
End Namespace
