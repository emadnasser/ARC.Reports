<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShiftSchedule.aspx.vb"
	Inherits="Spreadsheet_ShiftSchedule" %>
<%@ Register Src="~/UserControls/WorkbookPreviewControl.ascx" TagPrefix="dx" TagName="Preview" %>
<%@ Register Src="~/UserControls/SpreadsheetDocumentDownloader.ascx" TagPrefix="dx" TagName="DocumentDownloader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function UpdatePreview() {
			clientPreviewControl.Update(params);
		}
	// ]]> 
	</script>
	<dx:DocumentDownloader runat="server" ID="DocumentDownloader" OnRequestWorkbook="OnDocumentDownloaderRequestWorkbook" Inline="true" />
	<br />
	<dx:Preview runat="server" ID="previewControl" ClientInstanceName="clientPreviewControl" />
</asp:Content>
<asp:Content ID="Content2" runat="server" 
	contentplaceholderid="CustomHeadHolder">
	<style type="text/css">
		.style1
		{
			width: 158px;
		}
		.column2Style
		{
			padding-right:40px !important;
			margin-right:10px;
			width: 400px;
		}
	</style>
</asp:Content>