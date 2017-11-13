<%@ Page Language="C#" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="SalesDetails.aspx.cs" Inherits="SalesDetails" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
    <script type="text/javascript" src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/SalesDetailsData.js") %>"></script>
    <script type="text/javascript" src="<%= Page.ResolveClientUrl("~/Scripts/SalesDetailsPopup.js") %>"></script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1" ClientInstanceName="dashboardViewer1"
        DashboardSource="<%# typeof(SalesDetailsDashboard) %>" AllowExportDashboardItems="True"
        FullScreenMode="True" ColorScheme="dark"
        CalculateHiddenTotals="True"
        ClientSideEvents-ItemClick="function(s, e) { onItemClick(s, e); }"
        ClientSideEvents-ItemVisualInteractivity="function(s, e) { 
            if(e.ItemName == 'cardSalesByProduct') { 
                e.SetTargetAxes([DashboardDataAxisNames.DefaultAxis]);
                e.EnableHighlighting(true); 
            } 
        }"
        ClientSideEvents-Init="function(s, e) { initPopup(); }" />
</asp:Content>
