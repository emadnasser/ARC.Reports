<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TabbedMenu.aspx.cs"
    Inherits="Menu_TabbedMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 236px;">
        <table>
            <tr>
                <td>
                    <div class="TabbedMenuSideBorders Spacer">
                    </div>
                </td>
                <td>
                    <div class="TabbedMenuTableSide">
                    </div>
                </td>
                <td>
                    <dx:ASPxMenu EnableTheming="False" ID="ASPxMenu1" CssClass="TabbedMenu" runat="server"
                        AppearAfter="0" DataSourceID="XmlDataSource1" ItemSpacing="0px" SeparatorHeight="28px"
                        SeparatorWidth="1px" ShowSubMenuShadow="False" BorderBetweenItemAndSubMenu="HideRootOnly"
                        AutoPostBack="True" SyncSelectionMode="None" 
                        ClientInstanceName="tabbedMenu" AllowSelectItem="True" SelectParentItem="True">
                        <ItemStyle CssClass="rootItem">
                            <HoverStyle CssClass="rootItemHover">
                            </HoverStyle>
                            <SelectedStyle CssClass="rootItemSelected">
                            </SelectedStyle>
                        </ItemStyle>
                        <RootItemSubMenuOffset X="-1" Y="-2" FirstItemX="-1" FirstItemY="-2" LastItemX="-1"
                            LastItemY="-2" />
                        <SubMenuStyle GutterWidth="0px" ItemSpacing="0px" CssClass="TabbedMenuSubMenu">
                        </SubMenuStyle>
                        <SubMenuItemStyle CssClass="subItem">
                            <HoverStyle CssClass="subItemHover">
                            </HoverStyle>
                        </SubMenuItemStyle>
                        <VerticalPopOutImage Height="5px" Url="~/Menu/Images/TabbedMenu/ItemArrow.gif" Width="4px" />
                        <ItemSubMenuOffset X="-1" Y="-2" FirstItemY="-3" LastItemY="-2" />
                        <RootItemTextTemplate>
                            <div class="dx-tm">
                                <table>
                                    <tr>
                                        <th class="WhiteBorderRight">
                                            <dx:ASPxLabel ID="lblText" runat="server" EnableTheming="False" CssClass="rootText"
                                                Text='<%# Eval("Text") %>' />
                                        </th>
                                    </tr>
                                </table>
                            </div>
                        </RootItemTextTemplate>
                    </dx:ASPxMenu>
                </td>
                <td>
                    <div class="TabbedMenuSideBorders Spacer">
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Menu/TabbedMenu.xml"
        XPath="/mainmenu/item" />
</asp:Content>
