<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
  <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(OverviewDashboard) %>" 
        Width="550px" Height="500px" ColorScheme="light.compact" />
</asp:Content>
