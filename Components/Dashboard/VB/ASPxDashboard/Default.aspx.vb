Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Script.Serialization
Imports System.Web.SessionState
Imports System.Web.UI.WebControls
Imports System.Xml.Linq

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Private ReadOnly Property WorkingMode() As WorkingMode
		Get
			Dim workingModeString As String = Me.Request.QueryString("mode")
			If (Not String.IsNullOrEmpty(workingModeString)) AndAlso workingModeString = "designer" Then
				Return WorkingMode.Designer
			End If
			Return WorkingMode.Viewer
		End Get
	End Property

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		ASPxWebDashboard1.JSProperties("cpIsSqlExpressInstalled") = DevExpress.Internal.DbEngineDetector.IsSqlExpressInstalled OrElse DevExpress.Internal.DbEngineDetector.IsLocalDbInstalled
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsCallback) AndAlso (Not IsPostBack) Then
			ASPxWebDashboard1.WorkingMode = WorkingMode
		End If

		Dim dashboardStorage As DashboardInMemoryStorage = TryCast(Session("DashboardStorage"), DashboardInMemoryStorage)
		' Uncomment this line to use the App_Data/Dashboards folder to store dashboards.
		'DashboardFileStorage dashboardStorage = new DashboardFileStorage(@"~/App_Data/Dashboards");
		ASPxWebDashboard1.SetDashboardStorage(dashboardStorage)

		Dim dataSourceStorage As New DataSourceInMemoryStorage()
		dataSourceStorage.RegisterDataSource(DataSourceGenerator.CreateNWindDataSource().SaveToXml())
		ASPxWebDashboard1.SetDataSourceStorage(dataSourceStorage)
		ASPxWebDashboard1.SetConnectionStringsProvider(New ConnectionStringsProvider())
	End Sub

	Protected Sub OnConfigureDataConnection(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.ConfigureDataConnectionWebEventArgs)
		If e.ConnectionName = "DashboardProductDetailsConnection" Then
			Dim parameters As New DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters()
			parameters.FileName = DashboardMainDemo.DataLoader.GetProductDetailsXmlDataSource()
			e.ConnectionParameters = parameters
		End If
	End Sub
	Protected Sub OnDataLoading(ByVal sender As Object, ByVal e As DevExpress.DashboardWeb.DataLoadingWebEventArgs)
		DashboardMainDemo.DataLoader.LoadData(e)
	End Sub

	Protected Sub OnDashboardLoading(ByVal sender As Object, ByVal e As DashboardLoadingWebEventArgs)
		Dim httpContext As HttpContext = HttpContext.Current
		If e.DashboardId = "ProductDetails" AndAlso httpContext IsNot Nothing Then
			Dim dashboard As New Dashboard()
			dashboard.LoadFromXDocument(e.DashboardXml)
			Dim applicationPath As String = httpContext.Request.ApplicationPath.TrimEnd("/"c) & "/"
			Dim primaryImage As BoundImageDashboardItem = TryCast(dashboard.Items("primaryImage"), BoundImageDashboardItem)
			If primaryImage IsNot Nothing Then
				primaryImage.UriPattern = applicationPath & "Content/ProductDetailsImages/{0}.jpg"
			End If
			Dim secondaryImage As BoundImageDashboardItem = TryCast(dashboard.Items("secondaryImage"), BoundImageDashboardItem)
			If secondaryImage IsNot Nothing Then
				secondaryImage.UriPattern = applicationPath & "Content/ProductDetailsImages/{0} Secondary.jpg"
			End If
			e.DashboardXml = dashboard.SaveToXDocument()
		End If
	End Sub
End Class
