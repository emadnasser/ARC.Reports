<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GlobalCustomFunctions.aspx.vb" Inherits="ServerSideFunctionality_GlobalCustomFunctions" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
	<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/StartEditFormula.js")%>"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
			<ClientSideEvents EndSynchronization="function (s, e) { StartSpreadsheetCellEditing(s); }" />
	</dx:ASPxSpreadsheet>
</asp:Content>