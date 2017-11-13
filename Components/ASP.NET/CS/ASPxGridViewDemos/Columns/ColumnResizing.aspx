<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ColumnResizing.aspx.cs"
    Inherits="Columns_ColumnResizing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>Column resizing mode: </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="ddlResizingMode" AutoPostBack="true" SelectedIndex="1">
                    <Items>
                        <dx:ListEditItem Value="Disabled" />
                        <dx:ListEditItem Value="NextColumn" />
                        <dx:ListEditItem Value="Control" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>Resizing visualization: </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="ddlResizingVisualization" AutoPostBack="true" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Value="Live" />
                        <dx:ListEditItem Value="Postponed" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
    </table>
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
        KeyFieldName="CustomerID" Width="600">
        <Columns>
            <dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" Width="100" />
            <dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" Width="200" />
            <dx:GridViewDataColumn FieldName="City" VisibleIndex="3" Width="100" />
            <dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" Width="70" />
            <dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
        </Columns>
        <SettingsBehavior AllowEllipsisInText="true" />
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>
