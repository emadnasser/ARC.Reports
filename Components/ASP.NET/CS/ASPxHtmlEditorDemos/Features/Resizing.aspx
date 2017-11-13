<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Resizing.aspx.cs"
    Inherits="Features_Resizing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable OptionsBottomMargin">
        <tr>
            <td colspan="9" class="BottomPadding">
                <dx:ASPxCheckBox runat="server" ID="cbAllowResize" Text="AllowResize" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="ASPxLabel2" Text="MinWidth:" AssociatedControlID="seMinWidth">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxSpinEdit ID="seMinWidth" runat="server" Number="0" Width="70px"
                    Increment="10" MinValue="200" MaxValue="600">
                </dx:ASPxSpinEdit>
            </td>
            <td class="LeftPadding">
                <dx:ASPxLabel runat="server" ID="ASPxLabel5" Text="MaxWidth:" AssociatedControlID="seMaxWidth">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxSpinEdit ID="seMaxWidth" runat="server" Number="0" Width="70px"
                    Increment="10" MinValue="600" MaxValue="1000">
                </dx:ASPxSpinEdit>
            </td>
            <td class="LeftPadding">
                <dx:ASPxLabel runat="server" ID="ASPxLabel6" Text="MinHeight:" AssociatedControlID="seMinHeight">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxSpinEdit ID="seMinHeight" runat="server" Number="0" Width="70px"
                    Increment="10" MinValue="200" MaxValue="600">
                </dx:ASPxSpinEdit>
            </td>
            <td class="LeftPadding">
                <dx:ASPxLabel runat="server" ID="ASPxLabel7" Text="MaxHeight:" AssociatedControlID="seMaxHeight">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxSpinEdit ID="seMaxHeight" runat="server" Number="0" Width="70px"
                    Increment="10" MinValue="600" MaxValue="800">
                </dx:ASPxSpinEdit>
            </td>
            <td class="LeftPadding">
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Apply">
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Width="850px" Height="370px">
        <SettingsResize AllowResize="true" MinWidth="400" MaxWidth="800" MinHeight="300"
            MaxHeight="700" />
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
