﻿<%@ Page Language="C#" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="ChampionsLeagueStatistics.aspx.cs" Inherits="ChampionsLeagueStatistics" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
    <dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1"
        DashboardSource="<%# typeof(ChampionsLeagueStatisticsDashboard) %>" AllowExportDashboardItems="True"
        FullscreenMode="True" ColorScheme="dark" OnMasterFilterDefaultValues="OnMasterFilterDefaultValues" />
</asp:Content>