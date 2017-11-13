﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DropboxProvider.aspx.cs" Inherits="FileManager_DropboxProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div runat="server" id="MainContent">
        <dx:ASPxFileManager ID="FileManager" runat="server" ProviderType="Dropbox" OnCloudProviderRequest="FileManager_OnCloudProviderRequest"
            OnFolderCreating="fileManager_FolderCreating" OnItemDeleting="fileManager_ItemDeleting" OnItemMoving="fileManager_ItemMoving"
            OnItemRenaming="fileManager_ItemRenaming" OnFileUploading="fileManager_FileUploading" OnItemCopying="fileManager_ItemCopying">
            <Settings ThumbnailFolder="~\Thumb\" RootFolder="~\" />
            <ClientSideEvents EndCallback="function() { callbackPanel.PerformCallback(); }" Init="function() { callbackPanel.PerformCallback(); }" />
            <SettingsEditing AllowCopy="true" AllowCreate="true" AllowDelete="true" AllowDownload="true" AllowMove="true" AllowRename="true" />
            <SettingsDropbox AccountName="FileManagerDropboxAccount" />
        </dx:ASPxFileManager>
        <br />
        <dx:ASPxCallbackPanel ID="CallbackPanel" runat="server" ClientInstanceName="callbackPanel">
            <PanelCollection>
                <dx:PanelContent>
                    <dx:CloudProviderRequestMonitor runat="server" ID="EventMonitor" />
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>
    </div>
</asp:Content>