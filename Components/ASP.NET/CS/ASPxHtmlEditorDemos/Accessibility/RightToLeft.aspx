<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RightToLeft.aspx.cs" Inherits="Accessibility_RightToLeft" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor"
        Height="350px" RightToLeft="True">
        <SettingsDialogs>
            <InsertImageDialog>
                <SettingsImageSelector Enabled="true">
                    <CommonSettings RootFolder="~/Content/FileManager/Images" ThumbnailFolder="~/Content/FileManager/Thumbnails" InitialFolder="Employees" />
                </SettingsImageSelector>
                <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                    <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
                    </ValidationSettings>
                </SettingsImageUpload>
            </InsertImageDialog>
        </SettingsDialogs>
        <Settings>
            <SettingsHtmlView Mode="Simple" />
        </Settings>
    </dx:ASPxHtmlEditor>
</asp:Content>
