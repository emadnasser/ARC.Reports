<%@ Page Language="C#" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="EUTradeOverview.aspx.cs" Inherits="EUTradeOverview" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
    <script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/EUTradeOverview.js") %>"></script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(EUTradeOverviewDashboard) %>" AllowExportDashboardItems="True" FullscreenMode="True" ColorScheme="dark" 
        ClientSideEvents-ItemWidgetCreated="function(s, e) { setPieInsidePosition(s, e); }"
        ClientSideEvents-ItemWidgetUpdated="function(s, e) { setPieInsidePosition(s, e); }" />
</asp:Content>
