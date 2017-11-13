<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DetailsViewMode.aspx.cs" 
    Inherits="FileManager_GridViewMode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable OptionsBottomMargin">
        <tr>
            <td>
                <dx:ASPxCheckBox ID="allowColumnResize" runat="server" AutoPostBack="True" Text="AllowColumnResize" Checked="true" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="allowColumnDragDrop" runat="server" AutoPostBack="True" Text="AllowColumnDragDrop" Checked="true" />    
            </td>
            <td>
                <dx:ASPxCheckBox ID="allowColumnSort" runat="server" AutoPostBack="True" Text="AllowColumnSort" Checked="true" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="showHeaderFilterButton" runat="server" AutoPostBack="True" Text="ShowHeaderFilterButton" />
            </td>
        </tr>
    </table>
    <dx:ASPxFileManager ID="fileManager" runat="server" DataSourceID="LinqDataSource">
        <Settings ThumbnailFolder="~/Content/FileManager/Thumbnails" InitialFolder="Leonardo Da Vinci\1471 - 1480" />
        <SettingsDataSource KeyFieldName="Id" ParentKeyFieldName="ParentID" NameFieldName="Name" IsFolderFieldName="IsFolder" 
            FileBinaryContentFieldName="Data" LastWriteTimeFieldName="LastWriteTime" />
        <SettingsFileList View="Details">
            <DetailsViewSettings AllowColumnResize="true" AllowColumnDragDrop="true" AllowColumnSort="true" ShowHeaderFilterButton="false" />
        </SettingsFileList>
        <SettingsUpload Enabled="false" />
    </dx:ASPxFileManager>
    <ef:EntityDataSource ID="LinqDataSource" runat="server" ContextTypeName="ArtsDBContext" EntitySetName="Arts" StoreOriginalValuesInViewState="false">
    </ef:EntityDataSource>
</asp:Content>
