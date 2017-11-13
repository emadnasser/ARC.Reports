<%@ Application Language="vb" %>

<script runat="server">

	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
		DevExpress.Utils.UrlAccessSecurityLevelSetting.RegisterCustomBaseDirectories(HttpContext.Current.Server.MapPath("~/Content/ProductDetailsImages"))
		Dim storage As New DevExpress.DashboardWeb.DashboardInMemoryStorage()
		RegisterDashboard(storage, "SalesOverview")
		RegisterDashboard(storage, "SalesPerformance")
		RegisterDashboard(storage, "SalesDetails")
		RegisterDashboard(storage, "RevenueAnalysis")
		RegisterDashboard(storage, "HumanResources")
		RegisterDashboard(storage, "CustomerSupport")
		RegisterDashboard(storage, "RevenueByIndustry")
		RegisterDashboard(storage, "EnergyConsumption")
		RegisterDashboard(storage, "EnergyStatistics")
		RegisterDashboard(storage, "WebsiteStatistics")
		RegisterDashboard(storage, "ChampionsLeagueStatistics")
		RegisterDashboard(storage, "ProductDetails")
		RegisterDashboard(storage, "EUTradeOverview")
		HttpContext.Current.Session("DashboardStorage") = storage
	End Sub
	Sub RegisterDashboard(ByVal storage As DevExpress.DashboardWeb.DashboardInMemoryStorage, ByVal dashboardId As String)
		Dim dashboardLocalPath As String = Server.MapPath(String.Format("~/App_Data/Dashboards/{0}.xml", dashboardId))
		storage.RegisterDashboard(dashboardId, XDocument.Load(dashboardLocalPath))
	End Sub


</script>