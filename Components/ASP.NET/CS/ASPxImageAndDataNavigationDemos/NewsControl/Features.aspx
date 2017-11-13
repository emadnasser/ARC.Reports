<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="NewsControl_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 650px; margin-right: 16px">
        <dx:ASPxNewsControl Width="100%" DataSourceID="XmlDataSource1" ID="newsControl" EnableViewState="False"
            runat="server" NavigateUrlFormatString="javascript:void('{0}');">
            <ItemSettings ShowImageAsLink="True" MaxLength="120" TailText="Details">
            </ItemSettings>
            <PagerSettings CurrentPageNumberFormat="{0}" NumericButtonCount="5">
                <NextPageButton Visible="True">
                </NextPageButton>
                <PrevPageButton Visible="True">
                </PrevPageButton>
            </PagerSettings>
        </dx:ASPxNewsControl>
    </div>
    <div style="float: left; width: 300px; margin-right: -300px">
        <table class="OptionsTable">
            <tr>
                <td colspan="2" style="padding: 0 0 8px">
                    <b>Pager settings</b>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblEllipsisMode" runat="server" Text="EllipsisMode:" AssociatedControlID="ddlEllipsisMode" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="1" ID="ddlEllipsisMode" runat="server" AutoPostBack="True"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Value="None" Text="None" />
                            <dx:ListEditItem Value="InsideNumeric" Text="InsideNumeric" />
                            <dx:ListEditItem Value="OutsideNumeric" Text="OutsideNumeric" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblPosition" runat="server" Text="Position:" AssociatedControlID="ddlPosition" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlPosition" runat="server" AutoPostBack="True"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Value="Bottom" Text="Bottom" />
                            <dx:ListEditItem Value="Top" Text="Top" />
                            <dx:ListEditItem Value="TopAndBottom" Text="TopAndBottom" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowDisabledButtons" runat="server" Text="ShowDisabledButtons:"
                        AssociatedControlID="cbShowDisabledButtons" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowDisabledButtons" runat="server" Checked="True" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowNumericButtons" runat="server" Text="ShowNumericButtons:"
                        AssociatedControlID="cbShowNumericButtons" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowNumericButtons" runat="server" Checked="True" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowSeparators" runat="server" Text="ShowSeparators:" AssociatedControlID="cbShowSeparators" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowSeparators" runat="server" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowPageSizeItem" runat="server" Text="ShowPageSizeItem:"
                        AssociatedControlID="cbShowPageSizeItem" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowPageSizeItem" runat="server" Checked="True" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblPageSizeItemPosition" runat="server" Text="PageSizeItem position:" AssociatedControlID="ddlPageSizeItemPosition" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="1" ID="ddlPageSizeItemPosition" runat="server" AutoPostBack="True"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Value="Left" Text="Left" />
                            <dx:ListEditItem Value="Right" Text="Right" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblEndlessPagerMode" runat="server" Text="EndlessPagingMode:"
                        AssociatedControlID="cbEndlessPagerMode" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="cbEndlessPagerMode" runat="server" AutoPostBack="True"
                        Width="120px">
                        <Items>
                            <dx:ListEditItem Text="Disabled" Value="Disabled" />
                            <dx:ListEditItem Text="OnClick" Value="OnClick"/>
                            <dx:ListEditItem Text="OnScroll" Value="OnScroll" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td colspan="2" style="padding: 12px 0 8px">
                    <b>Behavior</b>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowBackToTop" runat="server" Text="ShowBackToTop" AssociatedControlID="cbShowBackToTop" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowBackToTop" runat="server" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowContentAsLink" runat="server" Text="ShowContentAsLink:"
                        AssociatedControlID="cbShowContentAsLink" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowContentAsLink" runat="server" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowContentInToolTip" runat="server" Text="ShowContentInToolTip:"
                        AssociatedControlID="cbShowContentInToolTip" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowContentInToolTip" runat="server" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblShowHeaderAsLink" runat="server" Text="ShowHeaderAsLink:" AssociatedControlID="cbShowHeaderAsLink" />
                </td>
                <td>
                    <dx:ASPxCheckBox ID="cbShowHeaderAsLink" runat="server" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="Label1" runat="server" Text="ShowImageAsLink:" AssociatedControlID="cbShowImageAsLink" />
                </td>
                <td>
                    <dx:ASPxCheckBox Checked="True" ID="cbShowImageAsLink" runat="server" AutoPostBack="True" />
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td colspan="2" style="padding: 12px 0 8px">
                    <b>Layout</b>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblDateHorizontalPosition" runat="server" Text="DateHorizontalPosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlDateHorizontalPosition" runat="server"
                        AutoPostBack="True" Width="140px">
                        <Items>
                            <dx:ListEditItem Value="Left" Text="Left" />
                            <dx:ListEditItem Value="Right" Text="Right" />
                            <dx:ListEditItem Value="OutsideLeft" Text="OutsideLeft" />
                            <dx:ListEditItem Value="OutsideRight" Text="OutsideRight" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblDateVerticalPosition" runat="server" Text="DateVerticalPosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="2" ID="ddlDateVerticalPosition" runat="server" AutoPostBack="True"
                        Width="140px">
                        <Items>
                            <dx:ListEditItem Value="Top" Text="Top" />
                            <dx:ListEditItem Value="Header" Text="Header" />
                            <dx:ListEditItem Value="BelowHeader" Text="BelowHeader" />
                            <dx:ListEditItem Value="Bottom" Text="Bottom" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblImagePosition" runat="server" Text="ImagePosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlImagePosition" runat="server" AutoPostBack="True"
                        Width="140px">
                        <Items>
                            <dx:ListEditItem Text="Left" Value="Left" />
                            <dx:ListEditItem Text="Right" Value="Right" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblTailImagePosition" runat="server" Text="TailImagePosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="1" ID="ddlTailImagePosition" runat="server" AutoPostBack="True"
                        Width="140px">
                        <Items>
                            <dx:ListEditItem Value="BeforeTailText" Text="BeforeTailText" />
                            <dx:ListEditItem Value="AfterTailText" Text="AfterTailText" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblTailPosition" runat="server" Text="TailPosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="2" ID="ddlTailPosition" runat="server" AutoPostBack="True"
                        Width="140px">
                        <Items>
                            <dx:ListEditItem Value="Inline" Text="Inline" />
                            <dx:ListEditItem Value="NewLine" Text="NewLine" />
                            <dx:ListEditItem Value="KeepWithLastWord" Text="KeepWithLastWord" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxLabel EnableViewState="False" ID="lblMaxLength" runat="server" Text="MaxLength:"
                        AssociatedControlID="tbMaxLength" />
                </td>
                <td style="padding-left: 0px;">
                    <table class="OptionsTable" style="width: 100%;">
                        <tr>
                            <td>
                                <dx:ASPxTextBox ID="tbMaxLength" runat="server" CssClass="DemoEdit" Width="68px"
                                    Height="24px" Text="120" />
                            </td>
                            <td>
                                <dx:ASPxButton ID="Button1" runat="server" Text="Apply" OnClick="Button1_Click" Height="24px" Width="65px">
                                    <Paddings PaddingBottom="0px" PaddingTop="0px" />
                                </dx:ASPxButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <dx:ASPxLabel EnableViewState="False" ID="lblMaxLengthError" runat="server" Font-Size="9px"
                        ForeColor="Red" Text="MaxLength value isn't valid" Visible="False" />
                </td>
            </tr>
        </table>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NewsControl/OnThisDay.xml"
        TransformFile="~/App_Data/NewsControl/RSS.xslt" XPath="//item" />
</asp:Content>
