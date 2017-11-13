<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ServerSide.aspx.cs"
    Inherits="TabControl_ServerSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <style type="text/css">
        <%= CssCode %>
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="height: 120px;">
        <div style="float: left; width: 70%; margin-right: 2%;">
            <dx:ASPxPageControl Width="100%" ID="ASPxPageControl1" runat="server" ActiveTabIndex="0"
                AutoPostBack="True" OnActiveTabChanged="ASPxPageControl1_ActiveTabChanged" OnActiveTabChanging="ASPxPageControl1_ActiveTabChanging"
                EnableHierarchyRecreation="True">
                <Paddings Padding="0" />
                <TabPages>
                    <dx:TabPage Name="html" Text="HTML">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <code id="HtmlCodeHolder" runat="server"></code>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Name="css" Text="CSS">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <code id="CssCodeHolder" runat="server"></code>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Name="preview" Text="Preview">
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl3" runat="server">
                                <%= HtmlCode %>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
            </dx:ASPxPageControl>
        </div>
        <div style="float: left">
            <table class="OptionsTable">
                <tr>
                    <td>
                        <dx:ASPxLabel ID="Label5" EnableViewState="false" runat="server" Text="Choose page:" AssociatedControlID="ddlTabs" />
                    </td>
                    <td>
                        <dx:ASPxComboBox AutoPostBack="true" ID="ddlTabs" runat="server" Width="70px"
                            OnSelectedIndexChanged="ddlTabs_SelectedIndexChanged" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <dx:ASPxCheckBox AutoPostBack="true" ID="cbEnable" Checked="true" runat="server"
                            OnCheckedChanged="cbEnable_CheckedChanged" Text="Enable" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <dx:ASPxCheckBox AutoPostBack="true" ID="cbVisible" Checked="true" runat="server"
                            OnCheckedChanged="cbVisible_CheckedChanged" Text="Visible" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <dx:ASPxCheckBox AutoPostBack="true" ID="cbActive" Checked="true" runat="server"
                            OnCheckedChanged="cbActive_CheckedChanged" Text="Active" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <dx:ServerEventMonitor runat="server" ID="EventMonitor" EventNames="ActiveTabChanging ActiveTabChanged" EventLogWidth="540" />
</asp:Content>
