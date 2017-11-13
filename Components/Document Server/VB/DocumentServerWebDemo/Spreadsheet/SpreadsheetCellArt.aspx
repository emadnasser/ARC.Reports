<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpreadsheetCellArt.aspx.vb"
	Inherits="SpreadSheet_SpreadsheetCellArt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function Uploader_TextChanged() {
			uploader.UploadFile();
		}
		function Uploader_FileUploadComplete(s, e) {
			if (e.callbackData == "" || e.callbackData == null)
				return;
			imagePreview.SetImageUrl(e.callbackData);
		}
	// ]]> 
	</script>
	<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblSelectImage" runat="server" Text="Select image: ">
							</dx:ASPxLabel>
						</td>
						<td>
							<dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" UploadMode="Advanced" OnFileUploadComplete="ASPxUploadControl1_FileUploadComplete"
								ClientInstanceName="uploader" NullText="Click here to browse files...">
								<ValidationSettings MaxFileSize="1048576" AllowedFileExtensions=".jpg,.jpeg,.jpe,.gif,.png">
								</ValidationSettings>
								<ClientSideEvents TextChanged="function(s, e) { Uploader_TextChanged(); }" FileUploadComplete="function(s, e) {Uploader_FileUploadComplete(s,e); }" />
							</dx:ASPxUploadControl>
						</td>
						<td style="vertical-align: baseline;">
							<dx:ASPxButton ID="btnExport" runat="server" Text="Export to XLSX" OnClick="OnBtnExportClick" />
						</td>
					</tr>
					<tr>
						<td>
						</td>
						<td class="note">
							<dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 1 MB" Font-Size="8pt">
							</dx:ASPxLabel>
						</td>
						<td>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:ASPxImage runat="server" ID="imagePreview" ClientInstanceName="imagePreview"
		ImageUrl="~/Spreadsheet/SpreadsheetCellArt.aspx?previewImage">
	</dx:ASPxImage>    
</asp:Content>