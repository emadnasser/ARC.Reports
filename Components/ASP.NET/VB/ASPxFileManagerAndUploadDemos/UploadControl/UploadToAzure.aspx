<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UploadToAzure.aspx.vb"
	Inherits="UploadControl_UploadToAzure" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.uploadContainer
		{
			float: left;
			margin-right: 80px;
		}
		.contentFooter
		{
			clear: both;
			padding-top: 20px;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function onFileUploadComplete(s, e) {
			if(e.callbackData) {
				var fileData = e.callbackData.split('|');
				var fileName = fileData[0],
					fileUrl = fileData[1],
					fileSize = fileData[2];
				DXUploadedFilesContainer.AddFile(fileName, fileUrl, fileSize);
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div id="MainContainer" runat="server">
		<div class="uploadContainer">
			<dx:ASPxUploadControl ID="UploadControl" runat="server" ClientInstanceName="UploadControl" Width="320"
				NullText="Click here to browse files..." UploadMode="Advanced" UploadStorage="Azure" FileUploadMode="OnPageLoad"
				ShowUploadButton="True" ShowProgressPanel="True" OnFileUploadComplete="UploadControl_FileUploadComplete">
				<AzureSettings AccountName="UploadAzureAccount" ContainerName="uploadcontroldemo" />
				<AdvancedModeSettings EnableMultiSelect="True" EnableFileList="True" EnableDragAndDrop="True" />
				<ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg,.jpeg,.gif,.png">
				</ValidationSettings>
				<ClientSideEvents FilesUploadStart="function(s, e) { DXUploadedFilesContainer.Clear(); }"
								  FileUploadComplete="onFileUploadComplete" />
			</dx:ASPxUploadControl>
			<br /><br />
			<p class="note">
				<dx:ASPxLabel ID="AllowedFileExtensionsLabel" runat="server" Text="Allowed file extensions: .jpg, .jpeg, .gif, .png." Font-Size="8pt">
				</dx:ASPxLabel>
				<br />
				<dx:ASPxLabel ID="MaxFileSizeLabel" runat="server" Text="Maximum file size: 4 MB." Font-Size="8pt">
				</dx:ASPxLabel>
			</p>
		</div>
		<div>
			<dx:UploadedFilesContainer ID="FileContainer" runat="server" Width="380" Height="180" 
				NameColumnWidth="240" SizeColumnWidth="70" HeaderText="Uploaded files" UseExtendedPopup="True" />
		</div>
		<div class="contentFooter">
			<p class="Note">
				<b>Note</b>: All files uploaded to this demo will be automatically deleted in 5 minutes.
			</p>
		</div>
	</div>
</asp:Content>