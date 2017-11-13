<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DocumentManagement.aspx.vb" Inherits="Features_DocumentManagement" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<script type="text/javascript">
		function OnExceptionOccurred(s, e) {
			e.handled = true;
			alert(e.message);
			window.location.reload();
		}
	</script>
	<div style="padding-bottom:5px;">
		<label>Click the <b>Open</b> button in the <b>Common</b> group within the <b>File</b> tab to open the document browser.</label>
	</div>
	<dx:ASPxSpreadsheet ID="Spreadsheet" runat="server" Width="100%" Height="700px" ActiveTabIndex="0" ShowConfirmOnLosingChanges="false">
		<ClientSideEvents CallbackError="OnExceptionOccurred"></ClientSideEvents>
	</dx:ASPxSpreadsheet>
</asp:Content>