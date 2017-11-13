<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="Menu_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 20%; margin-right: 2%;">
        <dx:ASPxNavBar ID="nbMain" runat="server" AllowSelectItem="True" EnableAnimation="True"
            Width="100%">
            <GroupHeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
            <Groups>
                <dx:NavBarGroup Text="Small Items">
                    <Items>
                        <dx:NavBarItem Text="Scheduler">
                            <Image Height="16px" Url="~/NavBar/Images/BO_Scheduler.png" Width="16px" />
                        </dx:NavBarItem>
                        <dx:NavBarItem Text="Clients">
                            <Image Height="16px" Url="~/NavBar/Images/BO_Organizations.png" Width="16px" />
                        </dx:NavBarItem>
                        <dx:NavBarItem Text="Users">
                            <Image Height="16px" Url="~/NavBar/Images/BO_Users.png" Width="16px" />
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
                <dx:NavBarGroup ItemImagePosition="Top" Text="Large Items">
                    <ContentStyle>
                        <Paddings PaddingBottom="1px" PaddingTop="1px" />
                    </ContentStyle>
                    <ItemStyle HorizontalAlign="Center" />
                    <Items>
                        <dx:NavBarItem Text="Notes">
                            <Image Height="32px" Url="~/NavBar/Images/BO_Notes_Large.png" Width="32px" />
                        </dx:NavBarItem>
                        <dx:NavBarItem Text="Reports">
                            <Image Height="32px" Url="~/NavBar/Images/BO_Reports_Large.png" Width="32px" />
                        </dx:NavBarItem>
                    </Items>
                </dx:NavBarGroup>
            </Groups>
        </dx:ASPxNavBar>
    </div>
    <div style="float: left;">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowExpanding" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="AllowExpanding" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAllowSelectItem" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Checked="True" Text="AllowSelectItem" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAutoPostBack" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Text="AutoPostBack" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAutoCollapse" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
                        Text="AutoCollapse" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbEnableHotTrack" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="EnableHotTrack" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbEnableAnimation" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" Text="EnableAnimation" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
