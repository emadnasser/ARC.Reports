<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TableReport.aspx.vb"
	Inherits="ReportTypes_TableReport" %>
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
	<dx:ASPxDocumentViewer runat="server" ID="documentViewer" OnCustomizeParameterEditors="documentViewer_CustomizeParameterEditors" EnableViewState="False" />
<%
	   ElseIf IsHTML5Viewer Then
%>
	<dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" />
	<script>
		if(webDocumentViewer) {
			webDocumentViewer.CustomizeParameterEditors.AddHandler(function(_, e) {
				if(e.parameter.name === 'OrderIdParameter') {
					e.info.editor = { header: 'param-order-id' };
				} else if(e.parameter.name === 'MaxRowCountParameter') {
					e.info.editor = { header: 'param-rows-count' };
				}
			});
		}
	</script>
	<script type="text/html" id="param-order-id">
		<div data-bind="dxNumberBox: { value: value, showSpinButtons: true, min: 10248, max: 11077 }"></div>
	</script>
	<script type="text/html" id="param-rows-count">
		<div data-bind="dxNumberBox: { value: value, showSpinButtons: true, min: 1, max: 13 }"></div>
	</script>
<%
	   ElseIf IsMobileViewer Then
%>
	<dx:MobileEmulator ID="mobileEmulator" runat="server" />
<%
	   End If
%>
</asp:Content>