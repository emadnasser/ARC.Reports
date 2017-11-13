﻿<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfTextExtraction.aspx.vb" Inherits="PdfTextExtraction" %>
<%@ Reference Control="~/UserControls/PdfResultsViewer.ascx" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<script type="text/javascript">
		function UploaderFileUploadComplete(e) {
			if (e.isValid)
				CallbackPanel.PerformCallback();
			else {
				loadingPanel.Hide();
				alert("File size exceeds the maximum allowed size.");
			}
		}
		function BeginPopupCallback() {
			popup.PerformCallback();
			loadingPanel.Show();
		}
		function EndPopupCallback() {
			loadingPanel.Hide();
			popup.Show();
			popup.UpdatePosition();
		}
	</script>
	<dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s, e) { loadingPanel.Hide(); }" />
	</dx:ASPxGlobalEvents>
	<dx:ASPxPopupControl ID="txtPopup" runat="server" ClientInstanceName="popup" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" 
		CloseAction="CloseButton" Modal="True" Width="600px" HeaderText="Text Extraction" OnWindowCallback="OnCallback" SettingsLoadingPanel-Enabled="false">
		<ClientSideEvents EndCallback="function(s, e) { EndPopupCallback(); }" />
		<ContentCollection>
			<dx:PopupControlContentControl ID="popupContentControl" runat="server" />
		</ContentCollection>
		<ContentStyle HorizontalAlign="Center" />
	</dx:ASPxPopupControl>
	<dx:ASPxRoundPanel runat="server" ShowHeader="true" HeaderText="Demo options" Width="100%">
		<PanelCollection>
			<dx:PanelContent>
				<table class="OptionsTable">
					<tr>
						<td>
							<dx:ASPxLabel ID="lblSelectDocument" runat="server" Text="Select document: " />
						</td>
						<td>
							<div style="vertical-align:middle;">
								<dx:ASPxUploadControl ID="uploadControl" ClientInstanceName="uploader" runat="server" FileInputSpacing="0" 
													  UploadMode="Standard" OnFileUploadComplete="OnFileUploadComplete" ShowClearFileSelectionButton="false" Height="25px">
									<ValidationSettings MaxFileSize="10485760" AllowedFileExtensions=".pdf" MaxFileSizeErrorText="" />
									<TextBoxStyle CssClass="CustomTextBox" />
									<BrowseButton Text="Open..." />
									<ClientSideEvents TextChanged="function(s, e) { uploader.UploadFile(); }" FileUploadComplete="function(s, e) { UploaderFileUploadComplete(e); }"
													  FilesUploadStart="function(s, e) { loadingPanel.ShowInElementByID(CallbackPanel.GetMainElement().id); }" />
								</dx:ASPxUploadControl>
							</div>
						</td>
						<td class="middle">
							<dx:ASPxButton ID="btnExtractText" runat="server" Text="Extract text..." AutoPostBack="false" Height="25px">
								<ClientSideEvents Click="function(s, e) { BeginPopupCallback(); }" />
							</dx:ASPxButton>
						</td>
					</tr>
					<tr>
						<td colspan="3" style="text-align:center">
							<dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 10 MB" Font-Size="8pt" />
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<br />
	<dx:PdfPageViewer id="pdfPageViewer" runat="server"/>
	<dx:ASPxLoadingPanel id="loadingPanel" ClientInstanceName="loadingPanel" runat="server" />
</asp:Content>