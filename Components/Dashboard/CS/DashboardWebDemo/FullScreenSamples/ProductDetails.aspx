<%@ Page Language="C#" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(ProductDetailsDashboard) %>" AllowExportDashboardItems="True"
        FullScreenMode="True" ColorScheme="dark" OnConfigureDataConnection="OnViewerConfigureDataConnection" OnDashboardLoaded="OnViewerDashboardLoaded" />
</asp:Content>
