<%@ Page Language="vb" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.vb" Inherits="ProductDetails" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
		DashboardSource="<%#GetType(ProductDetailsDashboard)%>" AllowExportDashboardItems="True"
		FullScreenMode="True" ColorScheme="dark" OnConfigureDataConnection="OnViewerConfigureDataConnection" OnDashboardLoaded="OnViewerDashboardLoaded" />
</asp:Content>