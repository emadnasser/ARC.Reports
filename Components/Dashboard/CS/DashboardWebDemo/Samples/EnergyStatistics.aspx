<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EnergyStatistics.aspx.cs" Inherits="EnergyStatistics" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(EnergyStatisticsDashboard) %>" AllowExportDashboardItems="True"
        Width="100%" Height="800px" ColorScheme="light.compact" />
</asp:Content>