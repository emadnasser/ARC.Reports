<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UnboundsFields.aspx.cs"
    Inherits="UnboundFieldsDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                Sales Person Format:
            </td>
            <td>
                <dx:ASPxComboBox ID="salesPersonFormat" runat="server" AutoPostBack="True" OnSelectedIndexChanged="salesPersonFormat_SelectedIndexChanged"
                    SelectedIndex="0" ValueType="System.String">
                    <Items>
                        <dx:ListEditItem Text="First Name + Last Name" Value="{0} {1}" />
                        <dx:ListEditItem Text="Last Name + First Name" Value="{1} {0}" />
                        <dx:ListEditItem Text="Last Name" Value="{1}" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                Order Amount Rule:
            </td>
            <td>
                <dx:ASPxComboBox ID="orderAmountRule" runat="server" AutoPostBack="True" OnSelectedIndexChanged="salesPersonFormat_SelectedIndexChanged"
                    SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Value="1" Text="with Discount" />
                        <dx:ListEditItem Value="2" Text="without Discount" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
        OnCustomUnboundFieldData="pivotGrid_CustomUnboundFieldData" OnCustomCellDisplayText="pivotGrid_CustomCellDisplayText"
        Width="100%">
        <Fields>
            <dx:PivotGridField ID="fieldSalesPerson" Area="RowArea" AreaIndex="0" Caption="Sales Person"
                FieldName="" SummaryDisplayType="AbsoluteVariation" UnboundType="String" />
            <dx:PivotGridField ID="fieldOrderDate" Area="RowArea" AreaIndex="1" Caption="Quarter"
                FieldName="OrderDate" GroupInterval="DateQuarter" ValueFormat-FormatString="Qtr {0}"
                ValueFormat-FormatType="Numeric" />
            <dx:PivotGridField ID="fieldExtended_Price" Area="FilterArea" AreaIndex="0" Caption="Extended_Price"
                FieldName="Extended_Price"/>
            <dx:PivotGridField ID="fieldOrderAmount" Area="DataArea" AreaIndex="0" Caption="Order Amount"
                FieldName="" UnboundType="Decimal" />
            <dx:PivotGridField ID="fieldPercent" Area="DataArea" AreaIndex="1" Caption="Percent of OrderTotal"
                FieldName="" />
            <dx:PivotGridField ID="fieldBonusAmount" Area="DataArea" AreaIndex="2" Caption="Bonus Amount"
                FieldName="" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>
