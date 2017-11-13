<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BindingToDatabase.aspx.cs" 
    Inherits="FileManager_BindingToDatabase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxFileManager ID="fileManager" runat="server" DataSourceID="ArtsDataSource">
        <Settings ThumbnailFolder="~/Content/FileManager/Thumbnails" InitialFolder="Salvador Dali\1936 - 1945" />
        <SettingsFileList>
            <ThumbnailsViewSettings ThumbnailWidth="100" ThumbnailHeight="100" />
        </SettingsFileList>
        <SettingsDataSource KeyFieldName="Id" ParentKeyFieldName="ParentID" NameFieldName="Name" IsFolderFieldName="IsFolder" FileBinaryContentFieldName="Data" LastWriteTimeFieldName="LastWriteTime" />
        <SettingsUpload Enabled="false"></SettingsUpload>
    </dx:ASPxFileManager>
    <ef:EntityDataSource ID="ArtsDataSource" runat="server" ContextTypeName="ArtsDBContext" EntitySetName="Arts" StoreOriginalValuesInViewState="false">
    </ef:EntityDataSource>
</asp:Content>
