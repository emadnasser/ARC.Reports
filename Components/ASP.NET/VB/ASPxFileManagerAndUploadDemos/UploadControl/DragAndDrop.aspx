<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DragAndDrop.aspx.vb" Inherits="UploadControl_DragAndDrop" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link rel="stylesheet" type="text/css" href="../Content/UploadControl/DragAndDrop.css">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function onUploadControlFileUploadComplete(s, e) {
			if(e.isValid)
				document.getElementById("uploadedImage").src = "UploadImages/" + e.callbackData;
			setElementVisible("uploadedImage", e.isValid);
		}
		function onImageLoad() {
			var externalDropZone = document.getElementById("externalDropZone");
			var uploadedImage = document.getElementById("uploadedImage");
			uploadedImage.style.left = (externalDropZone.clientWidth - uploadedImage.width) / 2 + "px";
			uploadedImage.style.top = (externalDropZone.clientHeight - uploadedImage.height) / 2 + "px";
			setElementVisible("dragZone", false);
		}
		function setElementVisible(elementId, visible) {
			document.getElementById(elementId).className = visible ? "" : "hidden";
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<%--start highlighted block--%>
	<div id="externalDropZone" class="dropZoneExternal">
		<div id="dragZone">
			<span class="dragZoneText">Drag an image here</span>
		</div>
		<img id="uploadedImage" src="#" class="hidden" alt="" onload="onImageLoad()" />
		<div id="dropZone" class="hidden">
			<span class="dropZoneText">Drop an image here</span>
		</div>
	</div>
	<%--end highlighted block--%>
	<dx:ASPxUploadControl ID="UploadControl" ClientInstanceName="UploadControl" runat="server" UploadMode="Auto" AutoStartUpload="True" Width="350" 
		ShowProgressPanel="True" CssClass="uploadControl" DialogTriggerID="externalDropZone" OnFileUploadComplete="UploadControl_FileUploadComplete" >
		<AdvancedModeSettings EnableDragAndDrop="True" EnableFileList="False" EnableMultiSelect="False" ExternalDropZoneID="externalDropZone" DropZoneText="" />
		<ValidationSettings MaxFileSize="4194304" AllowedFileExtensions=".jpg, .jpeg, .gif, .png" ErrorStyle-CssClass="validationMessage" />
		<BrowseButton Text="Select an image for upload..." />
		<DropZoneStyle CssClass="uploadControlDropZone" />
		<ProgressBarStyle CssClass="uploadControlProgressBar" />
		<ClientSideEvents 
			DropZoneEnter="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', true); }" 
			DropZoneLeave="function(s, e) { if(e.dropZone.id == 'externalDropZone') setElementVisible('dropZone', false); }" 
			FileUploadComplete="onUploadControlFileUploadComplete">
		</ClientSideEvents>
	</dx:ASPxUploadControl>
	<br />
	<dx:ASPxLabel runat="server" Text="You can upload JPG, GIF, or PNG file."></dx:ASPxLabel>
	<br />
	<dx:ASPxLabel runat="server" Text="Maximum file size is 4MB."></dx:ASPxLabel>
	<div class="Note">
		<p><b>Note.</b>&nbsp;The drag and drop functionality requires the end-user's browser to support HTML5 technology. It means that it works in modern browsers only: IE10+, Safari 6+, Firefox 4+, Google Chrome, and Opera 12+.</p>
		<p>All files uploaded to this demo will be automatically deleted in 5 minutes.</p>
	</div>
</asp:Content>