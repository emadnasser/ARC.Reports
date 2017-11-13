<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="EnableCallbacks.aspx.vb" Inherits="TreeView_EnableCallbacks" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxTreeView ID="treeView" runat="server" EnableCallBacks="true" EnableHotTrack="false"
		DataSourceID="SiteMapDataSource">
	</dx:ASPxTreeView>
	<dx:ASPxSiteMapDataSource ID="SiteMapDataSource" runat="server" SiteMapFileName="~/App_Data/SiteMap/Feature.sitemap" />
</asp:Content>