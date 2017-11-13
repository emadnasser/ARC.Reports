<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="RightToLeft.aspx.vb" Inherits="Common_RightToLeft" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div dir="rtl" style="text-align: right">
		<dx:ASPxFileManager ID="fileManager" RightToLeft="True" runat="server" OnFolderCreating="fileManager_FolderCreating"
		OnItemDeleting="fileManager_ItemDeleting" OnItemMoving="fileManager_ItemMoving"
		OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading">
			<SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" />
			<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
				AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf"
				InitialFolder="Images\Employees" />
			<SettingsUpload UseAdvancedUploadMode="true">
				<AdvancedModeSettings EnableMultiSelect="true" />
			</SettingsUpload>
		</dx:ASPxFileManager>
	</div>
	<script type="text/javascript">
		if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
			document.body.style.width = (document.body.offsetWidth - 1) + "px";
	</script>
</asp:Content>