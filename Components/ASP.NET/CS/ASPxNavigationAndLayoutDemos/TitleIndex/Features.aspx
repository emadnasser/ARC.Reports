<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="TitleIndex_IndexPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable">
        <tr>
            <td>
                <dx:ASPxCheckBox ID="cbCategorized" runat="server" AutoPostBack="True" CssClass="DemoCheckBox" Text="Categorized" />
            </td>
            <td class="LeftPadding">
                <dx:ASPxLabel ID="lblBehavior" runat="server" Text="IndexPanel.Behavior:" AssociatedControlID="ddlBehavior" />
            </td>
            <td>
                <dx:ASPxComboBox SelectedIndex="1" ID="ddlBehavior" runat="server" AutoPostBack="True" Width="100px">
                    <Items>
                        <dx:ListEditItem Text="Navigation" Value="Navigation" />
                        <dx:ListEditItem Text="Filtering" Value="Filtering" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <dx:ASPxCheckBox ID="cbShowBackToTop" runat="server" AutoPostBack="True" CssClass="DemoCheckBox" Text="ShowBackToTop"/>
            </td>
            <td class="LeftPadding">
                <dx:ASPxLabel ID="lblPostion" runat="server" Text="IndexPanel.Position:" AssociatedControlID="ddlPosition" />
            </td>
            <td>
                <dx:ASPxComboBox SelectedIndex="0" ID="ddlPosition" runat="server" AutoPostBack="True" Width="100px">
                    <Items>
                        <dx:ListEditItem Text="Top" Value="Top" />
                        <dx:ListEditItem Text="Bottom" Value="Bottom" />
                        <dx:ListEditItem Text="TopAndBottom" Value="TopAndBottom" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td class="LeftPadding">
                <dx:ASPxLabel ID="Label1" runat="server" CssClass="DemoEditLabel" Text="ColumnCount:"
                    AssociatedControlID="tbColumnCount" />
            </td>
            <td>
                <dx:ASPxTextBox ID="tbColumnCount" runat="server" Width="100px" Text="2"/>
            </td>
            <td>
                <dx:ASPxButton ID="Button1" CssClass="DemoButton" runat="server" Text="Apply" Width="70px"
                    OnClick="btnApply_Click" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td class="LeftPadding" colspan="3">
                <dx:ASPxLabel ID="lblColumnCountError" runat="server" Text="ColumnCount value isn't valid"
                    ForeColor="Red" Visible="False" />
            </td>
        </tr>
    </table>
    <dx:ASPxTitleIndex ID="ASPxTitleIndex1" runat="server" DataSourceID="CountryLocationsDataSource"
        Width="100%">
        <FilterBox Visible="False" />
        <Columns>
            <dx:TitleIndexColumn />
            <dx:TitleIndexColumn />
        </Columns>
        <GroupContentStyle ItemSpacing="2px">
        </GroupContentStyle>
        <IndexPanel Behavior="Filtering" />
    </dx:ASPxTitleIndex>
    <ef:EntityDataSource ID="CountryLocationsDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="CountryLocations" />
</asp:Content>
