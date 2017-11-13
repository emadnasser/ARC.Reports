<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="VirtualScrolling.aspx.cs" 
    Inherits="FileManager_VirtualScrolling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div class="OptionsCell">
        <dx:ASPxComboBox ID="ViewModeComboBox" runat="server" SelectedIndex="0" AutoPostBack="True" Caption="View Mode" Width="120px">
            <Items>
                <dx:ListEditItem Value="Thumbnails" Text="Thumbnails" />
                <dx:ListEditItem Value="Details" Text="Details" />
            </Items>
        </dx:ASPxComboBox>
    </div>
    <div class="OptionsCell OptionsRightMarign">
        <dx:ASPxComboBox ID="PageSizeComboBox" runat="server" SelectedIndex="2" AutoPostBack="True" Caption="Page Size" Width="120px">
            <Items>
                <dx:ListEditItem Value="50" Text="50" />
                <dx:ListEditItem Value="100" Text="100" />
                <dx:ListEditItem Value="300" Text="300" />
                <dx:ListEditItem Value="500" Text="500" />
            </Items>
        </dx:ASPxComboBox>
    </div>
    <div class="NewLine"></div>
    <dx:ASPxFileManager ID="FileManager" runat="server" Width="100%" OnFolderCreating="FileManager_FolderCreating"
        OnItemDeleting="FileManager_ItemDeleting" OnItemMoving="FileManager_ItemMoving"
        OnItemRenaming="FileManager_ItemRenaming" OnFileUploading="FileManager_FileUploading" OnItemCopying="FileManager_ItemCopying">
        <Settings RootFolder="~/Content/FileManager/VirtualScrolling/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
            AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.png,.doc,.pdf,.xls,.xlsx"
            InitialFolder="Projects (1000)" />
        <SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" AllowCopy="true" AllowDownload="true" />
        <SettingsFileList />
        <SettingsUpload UseAdvancedUploadMode="true">
            <AdvancedModeSettings EnableMultiSelect="true" />
        </SettingsUpload>
    </dx:ASPxFileManager>
    <br />
    <p class="Note">
        <b>Allowed Extensions</b>: .jpg, .jpeg, .gif, .rtf, .txt, .png, .doc, .pdf, .xls, .xlsx
    </p>
</asp:Content>
