<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"%>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxSiteMapControl ID="ASPxSiteMapControl1" runat="server" DataSourceID="ASPxSiteMapDataSource1">
	</dx:ASPxSiteMapControl>
	<dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/App_Data/SiteMap/Overview.sitemap" />
</asp:Content>