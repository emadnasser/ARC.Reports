<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SingleTotals.aspx.cs"
    Inherits="SingleTotalsDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                Field:
            </td>
            <td>
                <dx:ASPxComboBox ID="ddlField" runat="server" AutoPostBack="true" Width="120" OnSelectedIndexChanged="ddlField_SelectedIndexChanged"
                    SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Unit Price" Value="0" />
                        <dx:ListEditItem Text="Quantity" Value="1" />
                        <dx:ListEditItem Text="Discount" Value="2" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowColumnGrandTotals" runat="server" AutoPostBack="true" Text="ShowColumnGrandTotals" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowRowGrandTotals" runat="server" AutoPostBack="true" Text="ShowRowGrandTotals" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowGrandTotalsForSingleValues" runat="server" AutoPostBack="true" Text="ShowGrandTotalsForSingleValues" />
            </td>
        </tr>
        <tr>
            <td>
                Summary Type:
            </td>
            <td>
                <dx:ASPxComboBox ID="ddlSummaryType" runat="server" AutoPostBack="true" Width="120"
                    OnSelectedIndexChanged="ddlSummaryType_SelectedIndexChanged" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowColumnTotals" runat="server" AutoPostBack="true" Text="ShowColumnTotals" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowRowTotals" runat="server" AutoPostBack="true" Text="ShowRowTotals" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowTotalsForSingleValues" runat="server" AutoPostBack="true" Text="ShowTotalsForSingleValues" />
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
        Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category Name" FieldName="CategoryName"
                ID="fieldCategoryName" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product Name" FieldName="ProductName"
                ID="fieldProductName" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" Caption="Year" FieldName="OrderDate"
                ID="fieldOrderDate0" GroupInterval="DateYear" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="2" Caption="Quarter" FieldName="OrderDate"
                ID="fieldOrderDate1" GroupInterval="DateQuarter" ValueFormat-FormatString="Qtr {0}" ValueFormat-FormatType="Numeric" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Unit Price" FieldName="UnitPrice"
                ID="fieldUnitPrice" SummaryType="Max">
                <HeaderStyle ForeColor="Blue" />
            </dx:PivotGridField>
            <dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Quantity" FieldName="Quantity"
                ID="fieldQuantity">
                <HeaderStyle ForeColor="Blue" />
            </dx:PivotGridField>
            <dx:PivotGridField Area="DataArea" AreaIndex="2" Caption="Discount" FieldName="Discount"
                ID="fieldDiscount" SummaryType="Average" CellFormat-FormatString="p" CellFormat-FormatType="Numeric">
                <HeaderStyle ForeColor="Blue" />
            </dx:PivotGridField>
        </Fields>
        <OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>
