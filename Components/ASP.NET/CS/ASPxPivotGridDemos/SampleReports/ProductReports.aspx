<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductReports.aspx.cs"
    Inherits="ProductReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="BottomMargin">
        <tr>
            <td>
                <dx:ASPxRadioButtonList ID="tblDemoKind" runat="server" AutoPostBack="True" RepeatDirection="Horizontal"
                    RepeatColumns="3" OnSelectedIndexChanged="tblDemoKind_SelectedIndexChanged" Border-BorderStyle="None">
                    <Items>
                        <dx:ListEditItem Value="0" Text="Category Sales" Selected="True" />
                        <dx:ListEditItem Value="1" Text="Interval Grouping" />
                        <dx:ListEditItem Value="2" Text="Average Sales" />
                        <dx:ListEditItem Value="3" Text="Product Sales" />
                        <dx:ListEditItem Value="4" Text="Multiple Subtotals" />
                        <dx:ListEditItem Value="5" Text="Top 3 Products" />
                    </Items>
                </dx:ASPxRadioButtonList>
            </td>
            <td style="padding: 3px 0 0 10px;; vertical-align: top">
                <asp:Panel ID="pnlIntervalGrouping" runat="server" Visible="False">
                    <table class="OptionsTable">
                        <tr>
                            <td>
                                <label>
                                    Grouping Layout:</label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="ddlIntervalGrouping" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlIntervalGrouping_SelectedIndexChanged"
                                    SelectedIndex="0" ValueType="System.String" Width="180px">
                                    <Items>
                                        <dx:ListEditItem Text="by Years" Value="0" />
                                        <dx:ListEditItem Text="by Quarters" Value="1" />
                                        <dx:ListEditItem Text="by Months" Value="2" />
                                        <dx:ListEditItem Text="by Years, Quarters, Months" Value="3" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td style="padding: 6px 0 0 10px; vertical-align: top">
                <table>
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="cbProductSales" runat="server" AutoPostBack="True" Text="Show Categories"
                                OnCheckedChanged="cbProductSales_CheckedChanged" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxCheckBox ID="cbShowOthers" runat="server" AutoPostBack="True" Text="Show Others Rows"
                                OnCheckedChanged="cbShowOthers_CheckedChanged" Visible="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="ProductReportsDataSource"
        Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CategoryName" Caption="Category Name"
                ID="Category">
                <CustomTotals>
                    <dx:PivotGridCustomTotal SummaryType="Average" />
                    <dx:PivotGridCustomTotal />
                    <dx:PivotGridCustomTotal SummaryType="Min" />
                    <dx:PivotGridCustomTotal SummaryType="Max" />
                </CustomTotals>
            </dx:PivotGridField>
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="ShippedDate" Caption="Shipped Year"
                GroupInterval="DateYear" ID="Year" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="2" FieldName="ShippedDate" Caption="Shipped Quarter"
                GroupInterval="DateQuarter" ID="Quarter" ValueFormat-FormatString="Qtr {0}" ValueFormat-FormatType="Numeric" />
            <dx:PivotGridField Area="DataArea" AreaIndex="3" FieldName="ProductSales" Caption="Product Sales"
                ID="Sales" />
            <dx:PivotGridField Area="FilterArea" AreaIndex="4" FieldName="ProductName" Caption="Product Name"
                ID="Product" />
            <dx:PivotGridField Area="FilterArea" AreaIndex="1" Caption="Shipped Month" FieldName="ShippedDate"
                GroupInterval="DateMonth" Visible="False" ID="Month" />
            <dx:PivotGridField ID="AvgSale" Area="DataArea" AreaIndex="1" Caption="Average Sale"
                FieldName="ProductSales" SummaryType="Average" Visible="False" />
            <dx:PivotGridField ID="MinSale" Area="DataArea" AreaIndex="2" Caption="Min Sale"
                FieldName="ProductSales" SummaryType="Min" Visible="False" />
        </Fields>
        <OptionsPager RowsPerPage="20" />
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="ProductReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="ProductReports" />
</asp:Content>
