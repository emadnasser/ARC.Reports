<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Office2003.ascx.cs" Inherits="Menu_Toolbars_Office2003" %>
<table>
    <tr>
        <td style="height: 2px; background-image: url('../Menu/Images/Toolbars/Office2003/MiddleTop.gif');
            border-top-left-radius: 2px;">
        </td>
        <td style="width: 13px; height: 2px; background-image: url('../Menu/Images/Toolbars/Office2003/TopRightCorner.gif')">
        </td>
    </tr>
    <tr>
        <td style="background-image: url('../Menu/Images/Toolbars/Office2003/Background.gif');
            padding-left: 2px;">
            <dx:ASPxMenu SkinID="None" ID="ASPxMenu1" runat="server" CssClass="tbOffice2003"
                SeparatorCssClass="tbSeparator" ItemSpacing="1px" ShowAsToolbar="true">
                <ItemStyle CssClass="tbItem">
                    <HoverStyle CssClass="tbItemHover">
                    </HoverStyle>
                    <CheckedStyle CssClass="tbItemChecked">
                    </CheckedStyle>
                </ItemStyle>
                <ItemImage Height="16px" Width="16px" />
                <SeparatorPaddings Padding="0" />
                <Items>
                    <dx:MenuItem Text="">
                        <Image Url="~/Menu/Images/ToolBars/Office2003/ButtonNew.png" />
                    </dx:MenuItem>
                    <dx:MenuItem Text="">
                        <Image Url="~/Menu/Images/ToolBars/Office2003/ButtonEdit.png" />
                    </dx:MenuItem>
                    <dx:MenuItem Text="">
                        <Image Url="~/Menu/Images/ToolBars/Office2003/ButtonOpen.png" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Bold" BeginGroup="True" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonBold.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Italic" Checked="True" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonItalic.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Underline" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonUnderline.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Align" BeginGroup="True" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonLeft.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Align" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonCenter.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Align" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonRight.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem GroupName="Align" Checked="True" Text="">
                        <Image Width="17px" Height="16px" Url="~/Menu/Images/ToolBars/Office2003/ButtonJustify.gif" />
                    </dx:MenuItem>
                    <dx:MenuItem Text="" BeginGroup="True">
                        <Template>
                            <span style="white-space: nowrap;">
                                <label for="tbSearch" class="tbOffice2003InputLabel">
                                    Search:</label><input id="tbSearch" type="text" class="tbOffice2003Input" maxlength="256" /></span></Template>
                    </dx:MenuItem>
                    <dx:MenuItem Text="">
                        <Image Url="~/Menu/Images/ToolBars/Office2003/ButtonSearch.png" />
                    </dx:MenuItem>
                    <dx:MenuItem BeginGroup="True" Text="">
                        <Image Url="~/Menu/Images/ToolBars/Office2003/ButtonPrintPreview.png" />
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>
        </td>
        <td style="background-image: url('../Menu/Images/Toolbars/Office2003/MiddleRight.gif')">
        </td>
    </tr>
    <tr>
        <td style="height: 2px; background-image: url('../Menu/Images/Toolbars/Office2003/MiddleBottom.gif');
            border-bottom-left-radius: 2px;">
        </td>
        <td style="width: 13px; height: 2px; background-image: url('../Menu/Images/Toolbars/Office2003/BottomRightCorner.gif')">
        </td>
    </tr>
</table>
