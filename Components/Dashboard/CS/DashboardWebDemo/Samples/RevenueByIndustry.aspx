<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RevenueByIndustry.aspx.cs" Inherits="RevenueByIndustry" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(RevenueByIndustryDashboard) %>" AllowExportDashboardItems="True"
        Width="100%" Height="800px" ColorScheme="light.compact" />
</asp:Content>
