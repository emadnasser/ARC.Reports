<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.vb" Inherits="Overview" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
  <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
		DashboardSource="<%#GetType(OverviewDashboard)%>" 
		Width="550px" Height="500px" ColorScheme="light.compact" />
</asp:Content>