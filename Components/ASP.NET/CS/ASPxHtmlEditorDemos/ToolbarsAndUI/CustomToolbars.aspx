<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomToolbars.aspx.cs"
    Inherits="Features_CustomToolbars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="cbToolbar" runat="server" AutoPostBack="true" Width="150px"
        SelectedIndex="0" ValueType="System.String" OnValueChanged="cbToolbar_ValueChanged" Caption="Select toolbars">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Text="Custom" Value="Custom" />
            <dx:ListEditItem Text="Standard" Value="Standard" />
        </Items>
    </dx:ASPxComboBox>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor"
        Height="370px">
        <SettingsDialogs>
            <InsertImageDialog>
                <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                    <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
                    </ValidationSettings>
                </SettingsImageUpload>
            </InsertImageDialog>
        </SettingsDialogs>
    </dx:ASPxHtmlEditor>
</asp:Content>
