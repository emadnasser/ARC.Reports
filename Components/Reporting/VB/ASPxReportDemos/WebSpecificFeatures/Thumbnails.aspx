<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Thumbnails.aspx.vb"
	Inherits="WebSpecificFeatures_Thumbnails" %>
<asp:Content ID="ContentHead" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/Thumbnails.css")%>" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxDocumentViewer ID="documentViewer" Width="700px" CssClass="float_left" runat="server" EnableViewState="False">
		<SettingsSplitter SidePaneVisible="False" />
		<StylesReportViewer>
			<BookmarkSelectionBorder BorderStyle="None" />
		</StylesReportViewer>
	</dx:ASPxDocumentViewer>
	<dx:ASPxPanel ID="Panel1" Width="135px" Height="518px" ScrollBars="Auto"
				  CssClass="right_panel float_left"
				  runat="server" EnableTheming="False" />
</asp:Content>