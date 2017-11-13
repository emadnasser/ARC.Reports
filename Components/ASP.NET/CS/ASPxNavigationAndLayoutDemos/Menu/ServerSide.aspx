<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ServerSide.aspx.cs"
    Inherits="Menu_ServerSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxMenu ID="ASPxMenu1" runat="server" OnItemClick="ASPxMenu1_ItemClick" Orientation="Horizontal"
        AllowSelectItem="True" AutoPostBack="True">
        <Items>
            <dx:MenuItem Text="Jan" Name="january">
                <Items>
                    <dx:MenuItem Text="New Year's Day" Name="ny">
                    </dx:MenuItem>
                    <dx:MenuItem Name="luther" Text="Brthd of M.L.King">
                    </dx:MenuItem>
                    <dx:MenuItem Name="inauguration" Text="Inauguration Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Text="Feb" Name="february">
                <Items>
                    <dx:MenuItem Name="groundhog" Text="Groundhog Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="lincoln" Text="Lincoln's Brthd">
                    </dx:MenuItem>
                    <dx:MenuItem Name="valentine" Text="Valentine's Day">
                    </dx:MenuItem>
                    <dx:MenuItem Text="Washington's Brthd" Name="washington">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Text="Mar" Name="march">
                <Items>
                    <dx:MenuItem Text="Inauguration Day" Name="inaugurationMarch">
                    </dx:MenuItem>
                    <dx:MenuItem Name="patrick" Text="St. Patrick's Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="april" Text="Apr">
                <Items>
                    <dx:MenuItem Name="fools" Text="April Fools's Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="earth" Text="Earth Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="assistants" Text="Adm. Assistants' Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="arbor" Text="Arbor Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Text="May" Name="may">
                <Items>
                    <dx:MenuItem Text="Armed Forces Day" Name="armed">
                    </dx:MenuItem>
                    <dx:MenuItem Text="Memorial Day" Name="memorial">
                    </dx:MenuItem>
                    <dx:MenuItem Name="mothers" Text="Mothers' Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="june" Text="Jun">
                <Items>
                    <dx:MenuItem Name="flag" Text="Flag Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="fathers" Text="Fathers' Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="july" Text="Jul">
                <Items>
                    <dx:MenuItem Name="independence" Text="Independ. Day (US)">
                    </dx:MenuItem>
                    <dx:MenuItem Name="parents" Text="Parents' Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="september" Text="Sep">
                <Items>
                    <dx:MenuItem Name="labor" Text="Labor Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="grandparents" Text="Grandparents' Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="october" Text="Oct">
                <Items>
                    <dx:MenuItem Name="columbus" Text="Columbus Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="nations" Text="United Nations Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="halloween" Text="Halloween">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="november" Text="Nov">
                <Items>
                    <dx:MenuItem Name="election" Text="Election Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="veterans" Text="Veterans Day">
                    </dx:MenuItem>
                    <dx:MenuItem Name="thanksgiving" Text="Thanksgiving Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
            <dx:MenuItem Name="december" Text="Dec">
                <Items>
                    <dx:MenuItem Name="christmas" Text="Christmas Day">
                    </dx:MenuItem>
                </Items>
            </dx:MenuItem>
        </Items>
    </dx:ASPxMenu>
    <table class="OptionsTable" style="margin: 16px 0;">
        <tr>
            <td>
                <dx:ASPxLabel runat="server" Text="Choose item:" ID="lblItems" />
            </td>
            <td>
                <dx:ASPxComboBox AutoPostBack="true" Width="140px" ID="ddlItems" runat="server" CssClass="DemoEdit"
                    OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <dx:ASPxCheckBox AutoPostBack="true" ID="cbEnable" Checked="true" runat="server"
                    OnCheckedChanged="cbEnable_CheckedChanged" Text="Enable" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <dx:ASPxCheckBox AutoPostBack="true" ID="cbVisible" Checked="true" runat="server"
                    OnCheckedChanged="cbVisible_CheckedChanged" Text="Visible" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <dx:ASPxCheckBox AutoPostBack="true" ID="cbSelect" runat="server" OnCheckedChanged="cbSelect_CheckedChanged"
                    Text="Selected" />
            </td>
        </tr>
    </table>
    <dx:ServerEventMonitor runat="server" ID="EventMonitor" EventNames="ItemClick" />
</asp:Content>
