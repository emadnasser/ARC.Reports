<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Export.aspx.vb"
	Inherits="RichEdit_Export" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.OptionsTable > tbody > tr > td
		{
			height: 45px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
		// <![CDATA[
		function Uploader_TextChanged() {
			uploader.UploadFile();
		}
		function Uploader_FileUploadComplete(s, e) {
			if (e.callbackData == "" || e.callbackData == null)
				return;
			lblCurrentDocument.SetText(e.callbackData);
		}
		// ]]> 
	</script>
	<table style="width: 100%;">
		<tr>
			<td style="width: 50%;vertical-align: top;">
				<dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Upload">
					<PanelCollection>
						<dx:PanelContent ID="PanelContent1" runat="server">
							<table class="OptionsTable">
								<tr>
									<td class="note">
										<dx:ASPxLabel ID="lblNote" runat="server" Text="Maximum file size: 1 MB. Files accepted: rtf, doc, docx, txt, mht, odt, xml, epub, html.">
										</dx:ASPxLabel>
									</td>
								</tr>
								<tr>
									<td>
										<dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" UploadMode="Advanced"
											OnFileUploadComplete="ASPxUploadControl1_FileUploadComplete" ClientInstanceName="uploader"
											NullText="Click here to browse files...">
											<ValidationSettings MaxFileSize="1048576" AllowedFileExtensions=".rtf,.doc,.docx,.txt,.mht,.odt,.xml,.epub">
											</ValidationSettings>
											<ClientSideEvents TextChanged="function(s, e) { Uploader_TextChanged(); }" FileUploadComplete="function(s, e) {Uploader_FileUploadComplete(s,e); }" />
										</dx:ASPxUploadControl>
									</td>
								</tr>
							</table>
						</dx:PanelContent>
					</PanelCollection>
				</dx:ASPxRoundPanel>
			</td>
			<td style="width: 50%;">
				<dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" Width="100%" HeaderText="Export">
					<PanelCollection>
						<dx:PanelContent ID="PanelContent2" runat="server">
							<table class="OptionsTable">
								<tr>
									<td>
										<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="File to export: " ClientInstanceName="lblCurrentDocument">
										</dx:ASPxLabel>
									</td>
									<td>
										<dx:ASPxLabel ID="lblCurrentDocument" runat="server" Text="" ClientInstanceName="lblCurrentDocument">
										</dx:ASPxLabel>
									</td>
								</tr>
								<tr>
									<td>
										<dx:ASPxLabel ID="lblDownloadType" runat="server" Text="File&nbsp;Type: " AssociatedControlID="cbDownloadType"
											Style="margin-right: 7px;">
										</dx:ASPxLabel>
									</td>
									<td>
										<dx:ASPxComboBox ID="cbDownloadType" runat="server" ValueType="System.Int32" SelectedIndex="0"
											ClientInstanceName="cbDownloadType" Width="215px" Style="margin-right: 9px;">
											<Items>
												<dx:ListEditItem Text="Rich Text Format (*.rtf)" Value="1" />
												<dx:ListEditItem Text="Microsoft Word Document (*.doc)" Value="2" />
												<dx:ListEditItem Text="Word 2007 Document (*.docx)" Value="3" />
												<dx:ListEditItem Text="Portable Document Format (*.pdf)" Value="4" />
												<dx:ListEditItem Text="Text Files (*.txt)" Value="5" />
												<dx:ListEditItem Text="Web Archive, single file (*.mht)" Value="6" />
												<dx:ListEditItem Text="OpenDocument Text Document (*.odt)" Value="7" />
												<dx:ListEditItem Text="Word XML Document (*.xml)" Value="8" />
												<dx:ListEditItem Text="Electronic Publication (*.epub)" Value="9" />
												<dx:ListEditItem Text="HTML page (*.html)" Value="10" />
											</Items>
										</dx:ASPxComboBox>
									</td>
									<td>
										<dx:ASPxButton ID="btnDownload" runat="server" Text="Download" OnClick="OnBtnExportClick" />
									</td>
								</tr>
							</table>
						</dx:PanelContent>
					</PanelCollection>
				</dx:ASPxRoundPanel>
			</td>
		</tr>
	</table>
</asp:Content>