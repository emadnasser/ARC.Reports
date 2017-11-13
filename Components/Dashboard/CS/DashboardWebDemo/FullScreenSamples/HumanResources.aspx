<%@ Page Language="C#" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="HumanResources.aspx.cs" Inherits="HumanResources" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">    
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1" 
        DashboardSource="<%# typeof(HumanResourcesDashboard) %>" AllowExportDashboardItems="True"
        FullscreenMode="True" ColorScheme="dark" />
</asp:Content>
