﻿<%@ Page Language="vb" MasterPageFile="FullScreen.master" AutoEventWireup="true" CodeFile="RevenueAnalysis.aspx.vb" Inherits="RevenueAnalysis" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxDashboardViewer runat="server" ID="dashboardViewer1" 
		DashboardSource="<%#GetType(RevenueAnalysisDashboard)%>" AllowExportDashboardItems="True"
		FullScreenMode="True" ColorScheme="dark" />
</asp:Content>