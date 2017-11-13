<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="TabControl_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 60%; margin-right: 2%">
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0" EnableHierarchyRecreation="True">
            <TabPages >
                <dx:TabPage Text="London">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <dx:ASPxImage runat="server" ID="Image1" ImageUrl="~/TabControl/Images/(London)-Tower-Bridge.jpg"  Width="400" Height="260"/>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="New-York">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <dx:ASPxImage runat="server" ID="Image2" ImageUrl="~/TabControl/Images/(New-York)-Brooklyn-Bridge.jpg"  Width="400" Height="260"/>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Tokyo">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            <dx:ASPxImage runat="server" ID="Image3" ImageUrl="~/TabControl/Images/(Tokyo)-Tokyo-Tower.jpg" Width="400"  Height="260" />
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
    <div style="float: left;">
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxLabel ID="lblTabAlign" runat="server" Text="TabAlign:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlTabAlign" runat="server" CssClass="DemoEdit"
                        Width="80px" AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Left" Text="Left" />
                            <dx:ListEditItem Value="Center" Text="Center" />
                            <dx:ListEditItem Value="Right" Text="Right" />
                            <dx:ListEditItem Value="Justify" Text="Justify" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
            <tr>
                <td >
                    <dx:ASPxLabel ID="lblTabPosition" runat="server" Text="TabPosition:" />
                </td>
                <td>
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlTabPosition" runat="server" CssClass="DemoEdit"
                        Width="80px" AutoPostBack="True">
                        <Items>
                            <dx:ListEditItem Value="Top" Text="Top" />
                            <dx:ListEditItem Value="Bottom" Text="Bottom" />
                            <dx:ListEditItem Value="Left" Text="Left" />
                            <dx:ListEditItem Value="Right" Text="Right" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td >
                    <dx:ASPxLabel ID="lblActivateTabPageAction" runat="server" Text="ActivateTabPageAction:" />
                </td>
                <td >
                    <dx:ASPxComboBox SelectedIndex="0" ID="ddlActivateTabPageAction" runat="server" AutoPostBack="True"
                        Width="100px">
                        <Items>
                            <dx:ListEditItem Value="Click" Text="Click" />
                            <dx:ListEditItem Value="MouseOver" Text="MouseOver" />
                        </Items>
                    </dx:ASPxComboBox>
                </td>
            </tr>
        </table>
        <table class="OptionsTable">
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbAutoPostBack" runat="server" AutoPostBack="True" CssClass="DemoCheckBox" />
                </td>
                <td >
                    <dx:ASPxLabel ID="lblAutoPostBack" runat="server" AssociatedControlID="cbAutoPostBack"
                        Text="AutoPostBack" />
                </td>
            </tr>
            <tr>
                <td>
                    <dx:ASPxCheckBox ID="cbEnableHotTrack" runat="server" AutoPostBack="True" Checked="True"
                        CssClass="DemoCheckBox" />
                </td>
                <td >
                    <dx:ASPxLabel ID="lblEnableHotTrack" runat="server" AssociatedControlID="cbEnableHotTrack"
                        Text="EnableHotTrack" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
