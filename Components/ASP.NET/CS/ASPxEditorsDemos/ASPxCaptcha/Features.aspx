<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="ASPxCaptcha_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxCaptcha ID="Captcha" runat="server">
        <ValidationSettings SetFocusOnError="true" ErrorDisplayMode="Text" />
    </dx:ASPxCaptcha>
    <div class="TopPadding">
        <dx:ASPxButton ID="btnSubmit" runat="server" Text="Submit" UseSubmitBehavior="true"
            AutoPostBack="true">
        </dx:ASPxButton>
    </div>
    <div style="float: left; margin-top: 32px;">
        <div>
            <b>Challenge image:</b>
        </div>
        <table class="OptionsTable TopMargin" style="margin-left: 16px">
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblFontFamily" AssociatedControlID="cbFontFamily" runat="server"
                        Text="Font family:" />
                </td>
                <td>
                    <dx:ASPxComboBox ID="cbFontFamily" runat="server" Width="170px" ValueType="System.String">
                        <Items>
                            <dx:ListEditItem Value="Times New Roman" />
                            <dx:ListEditItem Value="Courier New" />
                            <dx:ListEditItem Value="Georgia" />
                            <dx:ListEditItem Value="Tahoma" />
                            <dx:ListEditItem Value="Verdana" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblForegroundColor" runat="server" AssociatedControlID="ceForegroundColor"
                        Text="Foreground color:" />
                </td>
                <td>
                    <dx:ASPxColorEdit ID="ceForegroundColor" runat="server" Width="170px" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblBackgroundColor" runat="server" AssociatedControlID="ceBackgroundColor"
                        Text="Background color:" />
                </td>
                <td>
                    <dx:ASPxColorEdit ID="ceBackgroundColor" runat="server" Width="170px" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblBorderColor" runat="server" Text="Border color:"
                        AssociatedControlID="ceBorderColor" />
                </td>
                <td>
                    <dx:ASPxColorEdit ID="ceBorderColor" runat="server" Width="170px" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblBorderWidth" runat="server" Text="Border width:" AssociatedControlID="seBorderWidth" />
                </td>
                <td>
                    <dx:ASPxSpinEdit ID="seBorderWidth" Width="60px" runat="server" MaxValue="10" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxButton ID="btnApply" CssClass="DemoButton" runat="server" Text="Apply" Width="70px"
                        OnClick="btnApply_Click"/>
                </td>
            </tr>
        </table>
    </div>
    <div style="float:left; margin-top: 32px; padding-left: 32px">
        <div>
            <b>Behavior:</b>
        </div>
        <table class="OptionsTable TopMargin" style="margin-left: 16px">
            <tr>
                <td class="NoWrap">
                    <dx:ASPxLabel ID="lblCharacterSet" AssociatedControlID="tbCharacterSet" runat="server"
                        Text="Character set:" />
                </td>
                <td>
                    <dx:ASPxTextBox ID="tbCharacterSet" runat="server" Width="200px" MaxLength="50">
                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                            <RegularExpression ValidationExpression="([^\s])*" ErrorText="A character set cannot contain white spaces" />
                            <RequiredField IsRequired="True" ErrorText="A character set is required" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblCodeLength" AssociatedControlID="seCodeLength" runat="server"
                        Text="Code length:" />
                </td>
                <td>
                    <dx:ASPxSpinEdit ID="seCodeLength" Width="60px" runat="server" MinValue="3" MaxValue="7" />
                </td>
            </tr>
        </table>
        <div style="margin-top:10px;">
            <b>ValidationSettings:</b>
            <table class="OptionsTable TopMargin" style="margin-left: 16px">
                <tr>
                    <td>
                        <dx:ASPxLabel EnableViewState="False" ID="lblSetFocusOnError" runat="server" Text="SetFocusOnError:"
                            AssociatedControlID="chbSetFocusOnError" />
                    </td>
                    <td>
                        <dx:ASPxCheckBox ID="chbSetFocusOnError" runat="server" Checked="true" Width="170px" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
