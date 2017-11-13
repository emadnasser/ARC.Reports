<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PdfPasswordProtection.aspx.cs"
    Inherits="PdfPasswordProtection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel"
        runat="server">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table>
                    <tr>
                        <td style="border: solid; border-width: thin">
                            <img Width="540" runat="server" alt="Page" id="pageImage" style="vertical-align:middle" />
                        </td>
                        <td style="vertical-align: top; padding-left: 30px">
                            <dx:ASPxRoundPanel ID="roundPanel1" runat="server" ShowHeader="true" HeaderText="Demo options"
                                Width="100%">
                                <PanelCollection>
                                    <dx:PanelContent>
                                        <table class="OptionsTable">
                                            <tr>
                                                <td style="padding-right: 30px; padding-left: 30px">
                                                    <dx:ASPxLabel ID="lblOwnerPassword" runat="server" Text="Owner password:" Wrap="False" Width="100%" />
                                                </td>
                                                <td>
                                                    <dx:ASPxTextBox ID="tbOwnerPassword" runat="server" Password="true" Text="" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right: 30px; padding-left: 30px">
                                                    <dx:ASPxLabel ID="lblUserPassword" runat="server" Text="User password:" Wrap="False" Width="100%" />
                                                </td>
                                                <td>
                                                    <dx:ASPxTextBox ID="tbUserPassword" runat="server" Password="true" Text="" />
                                                </td>
                                            </tr>
                                            <tr >
                                                <td style="padding-right: 30px; padding-left: 30px; padding-top: 22px;">
                                                    <dx:ASPxLabel  runat="server" Text="Printing:" Wrap="False" Width="100%" />
                                                </td>
                                                <td style="padding-top: 22px;">
                                                    <dx:ASPxComboBox ID="cbAllowPrinting" runat="server" ValueType="System.Int32" SelectedIndex="2">
                                                        <Items>
                                                            <dx:ListEditItem Value="0" Text="Not allowed" />
                                                            <dx:ListEditItem Value="1" Text="Low quality" />
                                                            <dx:ListEditItem Value="2" Text="Allowed" />
                                                        </Items>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right: 30px; padding-left: 30px;">
                                                    <dx:ASPxLabel  runat="server" Text="Data extraction:" Wrap="False" Width="100%" />
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbAllowExtraction" runat="server" ValueType="System.Int32" SelectedIndex="2">
                                                        <Items>
                                                            <dx:ListEditItem Value="0" Text="Not allowed" />
                                                            <dx:ListEditItem Value="1" Text="Accessibility" />
                                                            <dx:ListEditItem Value="2" Text="Allowed" />
                                                        </Items>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right: 30px; padding-left: 30px;">
                                                    <dx:ASPxLabel  runat="server" Text="Modification:" Wrap="False" Width="100%" />
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbAllowModification" runat="server" ValueType="System.Int32" SelectedIndex="2">
                                                        <Items>
                                                            <dx:ListEditItem Value="0" Text="Not allowed" />
                                                            <dx:ListEditItem Value="1" Text="Document assembling" />
                                                            <dx:ListEditItem Value="2" Text="Allowed" />
                                                        </Items>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-right: 30px; padding-left: 30px;">
                                                    <dx:ASPxLabel  runat="server" Text="Interactivity:" Wrap="False" Width="100%" />
                                                </td>
                                                <td>
                                                    <dx:ASPxComboBox ID="cbAllowInteractivity" runat="server" ValueType="System.Int32" SelectedIndex="2">
                                                        <Items>
                                                            <dx:ListEditItem Value="0" Text="Not allowed" />
                                                            <dx:ListEditItem Value="1" Text="Form filling and signing" />
                                                            <dx:ListEditItem Value="2" Text="Allowed" />
                                                        </Items>
                                                    </dx:ASPxComboBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                                <td style="padding-top: 22px;">
                                                    <dx:ASPxButton ID="btnEncrypt" runat="server" Text="Protect and Download" AutoPostBack="False" ClientInstanceName="btnEncrypt" Height="25px" Width="100%"
                                                        OnClick="OnProtectButtonClick">
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </dx:PanelContent>
                                </PanelCollection>
                            </dx:ASPxRoundPanel>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
