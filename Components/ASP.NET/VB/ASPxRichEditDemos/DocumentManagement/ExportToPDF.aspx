<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExportToPDF.aspx.vb"
	Inherits="RichEditDemoExportToPDF" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<div style="padding-bottom: 10px;">
		<dx:ASPxButton ID="ExportButton" runat="server" Text="Export to PDF" OnClick="ExportButton_Click">
			<image iconid="export_exporttopdf_32x32">
			</image>
		</dx:ASPxButton>
	</div>
	<dx:ASPxRichEdit ID="DemoRichEdit" runat="server" Width="100%"
		ActiveTabIndex="0" ShowConfirmOnLosingChanges="false" OnPreRender="DemoRichEdit_PreRender">
	</dx:ASPxRichEdit>
</asp:Content>