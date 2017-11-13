<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EUTradeOverview.aspx.vb" Inherits="EUTradeOverview"  %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
	<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/EUTradeOverview.js")%>"></script>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
		DashboardSource="<%#GetType(EUTradeOverviewDashboard)%>" AllowExportDashboardItems="True" Width="100%" Height="800px" ColorScheme="light.compact" 
		ClientSideEvents-ItemWidgetCreated="function(s, e) { setPieInsidePosition(s, e); }"
		ClientSideEvents-ItemWidgetUpdated="function(s, e) { setPieInsidePosition(s, e); }" />
</asp:Content>