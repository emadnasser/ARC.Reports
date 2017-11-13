<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="DashboardViewer.aspx.vb" Inherits="FinancialDemo.Tablet.DashboardViewer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<span  id = "Content" runat="server"  >            
	<dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
		DashboardTheme="Dark" FullscreenMode="True" 
		onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection" 
		ondashboardloading="ASPxDashboardViewer1_DashboardLoading"
		AllowExportDashboardItems="True"
		RegisterJQuery="True">
	</dx:ASPxDashboardViewer>
	</span>
	</form>
</body>
</html>