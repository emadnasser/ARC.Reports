<%@ Page Language="vb" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="HumanResources.aspx.vb" Inherits="HumanResources" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1" 
		DashboardSource="<%#GetType(HumanResourcesDashboard)%>" AllowExportDashboardItems="True"
		FullscreenMode="True" ColorScheme="dark" />
</asp:Content>