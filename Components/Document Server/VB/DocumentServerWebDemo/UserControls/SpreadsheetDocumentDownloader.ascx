<%@ Control Language="vb" AutoEventWireup="true" CodeFile="SpreadsheetDocumentDownloader.ascx.vb"
	Inherits="UserControls_SpreadsheetDocumentDownloader" %>
<table class="OptionsTable" style="float: right">
	<tr>
		<td>
			<dx:ASPxLabel ID="lblDownloadType" runat="server" Text="File&nbsp;Type: " AssociatedControlID="cbDownloadType">
			</dx:ASPxLabel>
		</td>
		<td>
			<dx:ASPxComboBox ID="cbDownloadType" runat="server" ValueType="System.Int32" SelectedIndex="0"
				ClientInstanceName="cbDownloadType" Width="215px">
				<Items>
					<dx:ListEditItem Text="Excel Workbook (*.xlsx)" Value="1" />
					<dx:ListEditItem Text="Excel 97-2003 Workbook (*.xls)" Value="2" />
					<dx:ListEditItem Text="Comma delimited (*.csv)" Value="3" />
					<dx:ListEditItem Text="PDF (*.pdf)" Value="4" />
				</Items>
			</dx:ASPxComboBox>
		</td>
<%
   If Inline Then
%>
		<td style="padding-right:0;">
			<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Download" OnClick="btnDownload_Click" />
		</td>
<%
   End If
%>
	</tr>
<%
   If (Not Inline) Then
%>
	<tr>
		<td colspan="2" style="text-align: right">
			<dx:ASPxButton ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
		</td>
	</tr>
<%
   End If
%>
</table>