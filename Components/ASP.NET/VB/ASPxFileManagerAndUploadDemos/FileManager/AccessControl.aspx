<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AccessControl.aspx.vb"
	Inherits="FileManager_AccessControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRadioButtonList ID="rblRole" runat="server" AutoPostBack="true" SelectedIndex="0" Border-BorderWidth="0" OnValueChanged="rblRole_ValueChanged"
		Caption="Current Role">
		<CaptionSettings Position="Top"/>
		<CaptionStyle Font-Bold="true"></CaptionStyle>
		<CaptionCellStyle Paddings-PaddingTop="0"></CaptionCellStyle>
		<RootStyle CssClass="OptionsBottomMargin"></RootStyle>
		<Items>
			<dx:ListEditItem Text="Default User" Value="" Selected="True" />
			<dx:ListEditItem Text="Document Manager" Value="DocumentManager" />
			<dx:ListEditItem Text="Media Moderator" Value="MediaModerator" />
			<dx:ListEditItem Text="Administrator" Value="Administrator" />
		</Items>
	</dx:ASPxRadioButtonList>
	<dx:ASPxFileManager ID="FileManager" runat="server" OnFolderCreating="fileManager_FolderCreating" OnItemDeleting="fileManager_ItemDeleting" 
		OnItemMoving="fileManager_ItemMoving" OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading" OnCustomThumbnail="fileManager_CustomThumbnail">
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
			AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf" />
		<SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" />
		<SettingsPermissions>
			<AccessRules>
				<dx:FileManagerFolderAccessRule Path="" Edit="Deny" />
				<dx:FileManagerFileAccessRule Path="*.xml" Edit="Deny" />
				<dx:FileManagerFolderAccessRule Path="System" Browse="Deny" />

				<dx:FileManagerFolderAccessRule Path="Documents" Role="DocumentManager" EditContents="Allow" />

				<dx:FileManagerFolderAccessRule Path="" Role="MediaModerator" Upload="Deny" />
				<dx:FileManagerFolderAccessRule Path="Music" Role="MediaModerator" EditContents="Allow" Upload="Allow" />
				<dx:FileManagerFolderAccessRule Path="Video" Role="MediaModerator" EditContents="Allow" Upload="Allow" />

				<dx:FileManagerFolderAccessRule Role="Administrator" Edit="Allow" Browse="Allow" />
			</AccessRules>
		</SettingsPermissions>
	</dx:ASPxFileManager>
	<br />
	<p class="Note">
		<strong>Allowed Extensions</strong>: .jpg, .jpeg, .gif, .rtf, .txt, .avi, .png, .mp3, .xml, .doc, .pdf
	</p>
</asp:Content>