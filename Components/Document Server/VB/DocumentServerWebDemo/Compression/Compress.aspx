﻿<%@ Page Language="vb" MasterPageFile="~/Site.master"  AutoEventWireup="true" CodeFile="Compress.aspx.vb" Inherits="Compression_Compress" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.groupBox
		{
			margin: 5px 0px;
			border: solid 1px gray;
			width: 480px;
		}
		.groupBox legend
		{
			margin-left: 20px;
		}
		.groupBox .fileContainer
		{
			height: 200px;
			padding: 5px 10px;
			overflow: auto;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript">
		// <![CDATA[
		var fileNumber = 0;
		var fileName = "";
		var startDate = null;
		function Uploader_OnFileUploadStart() {
			startDate = new Date();
			ClearProgressInfo();
			ClearFileContainer();
			pcProgress.Show();
		}
		function Uploader_OnFileUploadComplete(e) {
			if (e.callbackData != "")
				AddFileToContainer(e.callbackData);
		}
		function Uploader_OnFilesUploadComplete(e) {
			UpdateUploadButton();
			pcProgress.Hide();
		}
		function AddFileToContainer(callbackData) {
			var data = callbackData.split('|');
			var file = data[0];
			var url = data[1];
			var link = document.createElement('A');
			ASPx.Attr.SetAttribute(link, "target", "_blank");
			ASPx.Attr.SetAttribute(link, "href", url);
			link.innerHTML = file;
			var fileContainer = document.getElementById("fileContainer");
			fileContainer.appendChild(link);
			fileContainer.appendChild(document.createElement('BR'));
		}
		function UpdateUploadButton() {
			btnUpload.SetEnabled(uploader.GetText(0) != "");
		}
		// Progress Dialog
		function ClearFileContainer() {
			document.getElementById("fileContainer").innerHTML = "";
		}
		function SetCurrentFileUploadingProgress(fileName, uploadedLength, fileLength) {
			lblFileName.SetText("Current File Progress: " + fileName);
			lblFileName.GetMainElement().title = fileName;
			lblCurrentUploadedFileLength.SetText(GetContentLengthString(uploadedLength) + " / " + GetContentLengthString(fileLength));
		}
		function SetTotalUploadingProgress(number, count, uploadedLength, totalLength) {
			lblUploadedFiles.SetText("Total Progress: " + number + ' of ' + count + " file(s)");
			lblUploadedFileLength.SetText(GetContentLengthString(uploadedLength) + " / " + GetContentLengthString(totalLength));
		}
		function ProgressChanged(args) {
			if (!pcProgress.IsVisible())
				return;
			if (args.currentFileName != fileName) {
				fileName = args.currentFileName;
				fileNumber++;
			}
			SetCurrentFileUploadingProgress(args.currentFileName, args.currentFileUploadedContentLength, args.currentFileContentLength);
			progress1.SetPosition(args.currentFileProgress);
			SetTotalUploadingProgress(fileNumber, args.fileCount, args.uploadedContentLength, args.totalContentLength);
			progress2.SetPosition(args.progress);
			UpdateProgressStatus(args.uploadedContentLength, args.totalContentLength);
		}
		function ClearProgressInfo() {
			SetCurrentFileUploadingProgress("", 0, 0);
			progress1.SetPosition(0);
			SetTotalUploadingProgress(0, 0, 0, 0);
			progress2.SetPosition(0);
			lblProgressStatus.SetText('Elapsed time: 00:00:00 &ensp; Estimated time: 00:00:00 &ensp; Speed: ' + GetContentLengthString(0) + '/s');
			fileNumber = 0;
			fileName = "";
		}
		function UpdateProgressStatus(uploadedLength, totalLength) {
			var currentDate = new Date();
			var elapsedDateMilliseconds = currentDate - startDate;
			var speed = uploadedLength / (elapsedDateMilliseconds / 1000);
			var elapsedDate = new Date(elapsedDateMilliseconds);
			var elapsedTime = GetTimeString(elapsedDate);
			var estimatedMilliseconds = Math.floor((totalLength - uploadedLength) / speed) * 1000;
			var estimatedDate = new Date(estimatedMilliseconds);
			var estimatedTime = GetTimeString(estimatedDate);
			var speed = uploadedLength / (elapsedDateMilliseconds / 1000);
			lblProgressStatus.SetText('Elapsed time: ' + elapsedTime + ' &ensp; Estimated time: ' + estimatedTime + ' &ensp; Speed: ' + GetContentLengthString(speed) + '/s');
		}
		function GetContentLengthString(contentLength) {
			var sizeDimensions = ['bytes', 'KB', 'MB', 'GB', 'TB'];
			var index = 0;
			var length = contentLength;
			var postfix = sizeDimensions[index];
			while (length > 1024) {
				length = length / 1024;
				postfix = sizeDimensions[++index];
			}
			var numberRegExpPattern = /[-+]?[0-9]*(?:\.|\,)[0-9]{0,2}|[0-9]{0,2}/;
			var results = numberRegExpPattern.exec(length);
			length = results ? results[0] : Math.floor(length);
			return length.toString() + ' ' + postfix;
		}
		function GetTimeString(date) {
			var timeRegExpPattern = /\d{1,2}:\d{1,2}:\d{1,2}/;
			var results = timeRegExpPattern.exec(date.toUTCString());
			return results ? results[0] : "00:00:00";
		}
		// ]]>
	</script>
	<table style="width: 480px;" class="OptionsTable">
		<tr>
			<td class="NoWrap">
				<dx:ASPxLabel ID="lblSelectMultipleFiles" runat="server" Text="Select Multiple Files:"></dx:ASPxLabel>
			</td><td style="width: 100%;">
				<dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" ClientInstanceName="uploader" Width="100%" UploadMode="Advanced"
					NullText="Click here to browse files..." OnFileUploadComplete="UploadControl_FileUploadComplete" OnFilesUploadComplete="UploadControl_FilesUploadComplete">
					<AdvancedModeSettings EnableMultiSelect="True" />
					<ClientSideEvents FilesUploadStart="function(s, e) { Uploader_OnFileUploadStart(); }"
									  FileUploadComplete="function(s, e) { Uploader_OnFileUploadComplete(e); }"
									  FilesUploadComplete="function(s, e) { Uploader_OnFilesUploadComplete(e); }"
									  UploadingProgressChanged="function(s, e) { ProgressChanged(e); }"
									  TextChanged="function(s, e) { UpdateUploadButton(); }" />
					<ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg,.jpeg,.jpe,.gif,.rtf,.txt,.doc,.docx">
					</ValidationSettings>
				</dx:ASPxUploadControl>
			</td>
		</tr><tr>
			<td></td>
			<td class="note">
				<dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 4 MB" Font-Size="8pt">
				</dx:ASPxLabel>
			</td>
		</tr><tr>
			<td colspan="2" class="TopPadding" style="text-align: center;">
				<dx:ASPxButton ID="btnUpload" runat="server" AutoPostBack="False" Text="Upload" ClientInstanceName="btnUpload"
					Width="100px" ClientEnabled="False">
					<ClientSideEvents Click="function(s, e) { uploader.Upload(); }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<fieldset class="groupBox">
		<legend>Uploaded Files</legend>
		<div id="fileContainer" class="fileContainer"></div>
	</fieldset>
	<p class="Note">
		<b>Note</b>: All files uploaded to this demo will be automatically deleted in 5 minutes.
	</p>
	<br/>
	<dx:ASPxButton runat="server" ID="btnCompress" Text="Compress Files and Download" OnClick="OnBtnCompressClick"></dx:ASPxButton>
	<dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="pcProgress" Modal="True" HeaderText="Uploading"
		PopupAnimationType="None" CloseAction="None" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="460px"
		AllowDragging="true" ShowPageScrollbarWhenModal="True" ShowCloseButton="False" ShowFooter="True">
		<ContentCollection>
			<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" SupportsDisabledAttribute="True">
				<table style="width: 100%;">
					<tr><td style="width: 100%;">
						<div style="overflow: hidden; width: 280px;">
							<dx:ASPxLabel ID="lblFileName" runat="server" ClientInstanceName="lblFileName" Text=""
								Wrap="False"></dx:ASPxLabel>
						</div>
					</td><td class="NoWrap" style="text-align: right;">
						<dx:ASPxLabel ID="lblCurrentUploadedFileLength" runat="server" ClientInstanceName="lblCurrentUploadedFileLength"
							Text="" Wrap="False"></dx:ASPxLabel>
					</td></tr>
					<tr><td colspan="2" class="TopPadding" >
						<dx:ASPxProgressBar ID="ASPxProgressBar1" runat="server" Height="21px" Width="100%"
							ClientInstanceName="progress1"></dx:ASPxProgressBar>
					</td></tr>
					<tr><td colspan="2">
						<div class="Spacer" style="height: 12px;"></div>
					</td></tr>
					<tr><td style="width: 100%;">
						<dx:ASPxLabel ID="lblUploadedFiles" runat="server" ClientInstanceName="lblUploadedFiles" Text=""
							Wrap="False"></dx:ASPxLabel>
					</td><td class="NoWrap" style="text-align: right;">
						<dx:ASPxLabel ID="lblUploadedFileLength" runat="server" ClientInstanceName="lblUploadedFileLength"
							Text="" Wrap="False"></dx:ASPxLabel>
					</td></tr>
					<tr><td colspan="2" class="TopPadding" >
						<dx:ASPxProgressBar ID="ASPxProgressBar2" runat="server" CssClass="BottomMargin" Height="21px" Width="100%"
							ClientInstanceName="progress2"></dx:ASPxProgressBar>
					</td></tr>
					<tr><td colspan="2">
						<div class="Spacer" style="height: 12px;"></div>
					</td></tr>
					<tr><td colspan="2">
						<dx:ASPxLabel ID="lblProgressStatus" runat="server" ClientInstanceName="lblProgressStatus" Text=""
							Wrap="False"></dx:ASPxLabel>
					</td></tr>
				</table>
			</dx:PopupControlContentControl>
		</ContentCollection>
		<FooterTemplate>
			<table style="width: 100%;"><tr><td style="text-align: right;">
				<dx:ASPxButton ID="btnCancel" runat="server" AutoPostBack="False" Text="Cancel" ClientInstanceName="btnCancel" Width="100px">
					<ClientSideEvents Click="function(s, e) { uploader.Cancel(); }" />
				</dx:ASPxButton>
			</td></tr></table>
		</FooterTemplate>
		<FooterStyle><Paddings Padding="5px" PaddingRight="10px" /></FooterStyle>
	</dx:ASPxPopupControl>
</asp:Content>