<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PivotGridAndChart.aspx.vb"
	Inherits="DataBinding_PivotGridAndChart" %>
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
	<dx:ASPxDocumentViewer runat="server" ID="documentViewer" Width="1200px" EnableViewState="False">
		<StylesSplitter SidePaneWidth="240px" />
	</dx:ASPxDocumentViewer>
<%
	   ElseIf IsHTML5Viewer Then
%>
	<dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" Height="770px" EnableViewState="False" />
<%
	   ElseIf IsMobileViewer Then
%>
	<dx:MobileEmulator ID="mobileEmulator" runat="server" />
<%
	   End If
%>
</asp:Content>