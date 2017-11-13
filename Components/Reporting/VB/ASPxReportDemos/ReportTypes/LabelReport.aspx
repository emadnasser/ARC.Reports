<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LabelReport.aspx.vb"
	Inherits="ReportTypes_Label" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/RunDesignerButton.css")%>" />
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/ViewerSelector.css")%>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
	<dx:ViewerSelector ID="viewerSelector" runat="server" />
	<dx:ShowDesignerButton ID="showDesignerButton" runat="server" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
<%
	   If IsASPViewer Then
%>
	<dx:ASPxDocumentViewer runat="server" ID="documentViewer" Height="460px" EnableViewState="False">
		<StylesReportViewer BookmarkSelectionBorder-BorderStyle="None" />
		<StylesSplitter SidePaneWidth="277px" />
	</dx:ASPxDocumentViewer>
<%
	   ElseIf IsHTML5Viewer Then
%>
	<dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" Height="560px" />
<%
	   ElseIf IsMobileViewer Then
%>
	<dx:MobileEmulator ID="mobileEmulator" runat="server" />
<%
	   End If
%>
</asp:Content>