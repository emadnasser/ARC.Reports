<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.vb"
	Inherits="FileManager_ClientSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFileManager ID="fileManager" runat="server" OnFolderCreating="fileManager_FolderCreating"  
		OnItemDeleting="fileManager_ItemDeleting" OnItemMoving="fileManager_ItemMoving" 
		OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading">
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
			AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf" />
		<SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" AllowDownload="true" />
		<ClientSideEvents Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init') }" ItemMoving="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemMoving') }"
			ItemMoved="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemMoved') }" ItemRenaming="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemRenaming') }"
			ItemRenamed="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemRenamed') }" ItemDeleting="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemDeleting') }"
			ItemDeleted="function(s, e) { DXEventMonitor.Trace(s, e, 'ItemDeleted') }" FilesUploading="function(s, e) { DXEventMonitor.Trace(s, e, 'FilesUploading') }"
			FileUploaded="function(s, e) { DXEventMonitor.Trace(s, e, 'FileUploaded') }"
			FolderCreating="function(s, e) { DXEventMonitor.Trace(s, e, 'FolderCreating') }"
			FolderCreated="function(s, e) { DXEventMonitor.Trace(s, e, 'FolderCreated') }"
			ErrorOccurred="function(s, e) { DXEventMonitor.Trace(s, e, 'ErrorOccurred') }"
			SelectedFileChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectedFileChanged') }"
			CurrentFolderChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'CurrentFolderChanged') }"
			SelectedFileOpened="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectedFileOpened') }"
			FileDownloading="function(s, e) { DXEventMonitor.Trace(s, e, 'FileDownloading') }" />
	</dx:ASPxFileManager>
	<br />
	<p class="Note">
		<strong>Allowed Extensions</strong>: .jpg, .jpeg, .gif, .rtf, .txt, .avi, .png, .mp3, .xml, .doc, .pdf
	</p>
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init, ItemMoving, ItemMoved, ItemRenaming,
		ItemRenamed, ItemDeleting, ItemDeleted, FilesUploading, FileUploaded, FolderCreating, FolderCreated,
		ErrorOccurred, SelectedFileChanged, SelectedFileOpened, CurrentFolderChanged, FileDownloading" EventLogHeight="300" />
</asp:Content>