<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Overview.aspx.vb"
	Inherits="FileManager_Overview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
	<dx:ASPxFileManager ID="ASPxFileManager1" runat="server" Height="360px" OnFolderCreating="fileManager_FolderCreating" OnItemDeleting="fileManager_ItemDeleting" 
		OnItemMoving="fileManager_ItemMoving" OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading">
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails" InitialFolder="Images\Product icons"/>
		<Styles>
			<FolderContainer Width="190px">
			</FolderContainer>
		</Styles>
		<SettingsFileList>
			<ThumbnailsViewSettings ThumbnailWidth="50" ThumbnailHeight="50" />
		</SettingsFileList>
		<SettingsToolbar ShowFilterBox="false" />
	</dx:ASPxFileManager>
</asp:Content>