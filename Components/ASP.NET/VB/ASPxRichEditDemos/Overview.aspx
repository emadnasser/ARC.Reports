<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.vb" Inherits="Overview" %>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="server">
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="631px" ActiveTabIndex="0"
		ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
	</dx:ASPxRichEdit>
</asp:Content>