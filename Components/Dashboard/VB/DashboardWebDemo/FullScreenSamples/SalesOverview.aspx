<%@ Page Language="vb" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="SalesOverview.aspx.vb" Inherits="SalesOverview" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1" 
		DashboardSource="<%#GetType(SalesOverviewDashboard)%>" AllowExportDashboardItems="True"
		FullScreenMode="True" ColorScheme="dark" />
</asp:Content>