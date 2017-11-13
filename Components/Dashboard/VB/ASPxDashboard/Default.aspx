<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Dashboard.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link rel="icon" type="image/png" href="Content/favicon.ico" />
	<title>Web Dashboard - ASP.NET Dashboard Demo | DevExpress</title>
	<link href="Content/styles.css" rel="stylesheet" />
	<script src="Content/scripts.js" type="text/javascript"></script>
</head>
<body>
	<script type="text/html" id="dx-dshd-form-new-disallowed">
		<div class="dx-dshd-form-new-disallowed-message">
			A corresponding data provider is not installed.
			<br/>
			To create a new Dashboard, do one of the following:
			<br/>
			<br/>
			Install SQL Server Express or SQL Server Express LocalDB on your computer.
			<br/>
			or
			<br/>
			Specify the server name within connection strings in the Web.config file and run the demo again.
		</div>
	</script>
	<form id="form1" runat="server">
		<div class = "content">
			 <dx:ASPxDashboard ID="ASPxWebDashboard1" runat="server" 
					ClientInstanceName = "clientDashboardDesigner1"
					Height = "100%"
					WorkingMode = "Viewer"
					AllowExportDashboardItems ="True"
					IncludeDashboardIdToUrl = "True"
					IncludeDashboardStateToUrl = "True"
					OnDashboardLoading ="OnDashboardLoading"
					OnConfigureDataConnection="OnConfigureDataConnection"
					OnDataLoading="OnDataLoading"
				>
				<ClientSideEvents  
					CustomizeMenuItems="onCustomizeMenuItems"       
					BeforeRender ="onBeforeRender"             
				 />
			</dx:ASPxDashboard>
		</div>
	</form>
</body>
</html>