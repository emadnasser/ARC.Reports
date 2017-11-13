<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomThumbnails.aspx.vb" Inherits="FileManager_CustomThumbnails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFileManager ID="fileManager" runat="server" OnCustomThumbnail="fileManager_CustomThumbnail">
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
			AllowedFileExtensions=".jpg,.rtf,.txt,.avi,.png,.mp3,.xml" InitialFolder="Music" />
		<SettingsUpload Enabled="false"></SettingsUpload>
	</dx:ASPxFileManager>
	<br />
</asp:Content>