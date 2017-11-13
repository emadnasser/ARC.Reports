<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="FileManager_Features" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .OptionsTable
        {
            float: left;
            margin: 0 30px 30px 0;
        }
        .OptionsTable > tbody > tr > td.titleCell
        {
            padding: 12px 0 8px;
            white-space: nowrap;
            font-weight: bold;
        }    
        .OptionsTable > tbody > tr > td.cmbCell
        {
            padding-left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div>
        <table class="OptionsTable">
            <tr>
                <td class="titleCell">
                    Editing Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowMove" runat="server" AutoPostBack="True" Checked="True" Text="AllowMove" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowDelete" runat="server" AutoPostBack="True" Checked="True" Text="AllowDelete" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowRename" runat="server" AutoPostBack="True" Checked="True" Text="AllowRename" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowCreate" runat="server" AutoPostBack="True" Checked="True" Text="AllowCreate" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowCopy" runat="server" AutoPostBack="True" Checked="True" Text="AllowCopy" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowDownload" runat="server" AutoPostBack="True" Checked="True" Text="AllowDownload" />
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td class="titleCell">
                    Toolbar Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowPath" runat="server" AutoPostBack="True" Checked="True" Text="ShowPath" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowFilterBox" runat="server" AutoPostBack="True" Checked="True" Text="ShowFilterBox" />
                </td>
            </tr>
            <tr>
                <td class="titleCell">
                    Breadcrumbs Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbBreadcrumbsVisible" runat="server" AutoPostBack="True" Checked="True" Text="Visible" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbBreadcrumbsShowParentFolderButton" runat="server" AutoPostBack="True" Checked="True" Text="ShowParentFolderButton" />
                </td>
            </tr>
            <tr>
                <td class="cmbCell">
                    <dx:ASPxLabel ID="lblBreadcrumbsPosition" EnableViewState="False" runat="server" Text="Position:" AssociatedControlID="cbBreadcrumbsPosition" />
                </td>
            </tr>
            <tr>
                <td class="cmbCell">
                    <dx:ASPxComboBox ID="cmbBreadcrumbsPosition" runat="server" SelectedIndex="0" AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Top" Text="Top" />
                            <dx:ListEditItem Value="Bottom" Text="Bottom" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td class="titleCell">
                    Upload Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbUploadEnabled" runat="server" AutoPostBack="True" Checked="True" Text="Enabled" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbUploadMultiSelect" runat="server" AutoPostBack="True" Checked="True" Text="EnableMultiSelect" />
                </td>
            </tr>
            <tr>
                <td class="titleCell">
                    File List Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbFileListShowFolders" runat="server" AutoPostBack="True" Checked="True" Text="ShowFolders" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbFileListShowParentFolder" runat="server" AutoPostBack="True" Checked="True" Text="ShowParentFolder" />
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td class="titleCell">
                    Folder Settings:
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbFoldersVisible" runat="server" AutoPostBack="True" Checked="True" Text="Visible" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbFoldersEnableCallBacks" runat="server" AutoPostBack="True" Checked="True" Text="EnableCallBacks" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowFolderIcons" runat="server" AutoPostBack="True" Checked="True" Text="ShowFolderIcons" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbShowLockedFolderIcons" runat="server" AutoPostBack="True" Checked="True" Text="ShowLockedFolderIcons" />
                </td>
            </tr>
        </table>
        <b class="Clear"></b>
    </div>
    <b class="Clear"></b>
    <dx:ASPxFileManager ID="fileManager" runat="server" OnFolderCreating="fileManager_FolderCreating"
        OnItemDeleting="fileManager_ItemDeleting" OnItemMoving="fileManager_ItemMoving"
        OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading" OnItemCopying="fileManager_ItemCopying">
        <Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
            AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf"
            InitialFolder="Images\Employees" />
        <SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" AllowCopy="true" AllowDownload="true" />
        <SettingsPermissions>
            <AccessRules>
                <dx:FileManagerFolderAccessRule Path="System" Edit="Deny" />
            </AccessRules>
        </SettingsPermissions>
        <SettingsFileList ShowFolders="true" ShowParentFolder="true" />
        <SettingsBreadcrumbs Visible="true" ShowParentFolderButton="true" Position="Top" />
        <SettingsUpload UseAdvancedUploadMode="true">
            <AdvancedModeSettings EnableMultiSelect="true" />
        </SettingsUpload>
    </dx:ASPxFileManager>
    <br />
    <p class="Note">
        <b>Allowed Extensions</b>: .jpg, .jpeg, .gif, .rtf, .txt, .avi, .png, .mp3, .xml,
        .doc, .pdf
    </p>
</asp:Content>
