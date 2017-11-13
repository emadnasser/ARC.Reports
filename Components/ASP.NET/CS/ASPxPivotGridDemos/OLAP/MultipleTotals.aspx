<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultipleTotals.aspx.cs"
    Inherits="OLAP_CustomTotals" AspCompat="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td colspan="3">
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Select Totals to Show:" Font-Bold="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxCheckBox ID="average" runat="server" Text="Average" Checked="True" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="min" runat="server" Text="Min" Checked="True" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="sum" runat="server" Text="Sum" Checked="True" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxCheckBox ID="count" runat="server" Text="Count" Checked="True" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="stdev" runat="server" Text="StdDev" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="var" runat="server" Text="Var" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxCheckBox ID="max" runat="server" Text="Max" Checked="True" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="stdevp" runat="server" Text="StdDevp" AutoPostBack="True" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="varp" runat="server" Text="Varp" AutoPostBack="True" />
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" CustomizationFieldsLeft="600" CustomizationFieldsTop="400"
        ClientInstanceName="pivotGrid" CssClass="dxpgControl" OnDataBound="pivotGrid_DataBound" Width="100%"
        OLAPConnectionString="<%$ ConnectionStrings:NorthwindCubeFileConnection %>" >
        <Fields>
            <dx:PivotGridField ID="field0" Area="RowArea" AreaIndex="0" Caption="Category Name"
                FieldName="[Categories].[Category Name].[Category Name]" TotalsVisibility="CustomTotals" />
            <dx:PivotGridField ID="field1" Area="FilterArea" AreaIndex="0" Caption="City" FieldName="[Customers].[City].[City]" />
            <dx:PivotGridField ID="field2" Area="FilterArea" AreaIndex="0" Caption="Country"
                FieldName="[Customers].[Country].[Country]" />
            <dx:PivotGridField ID="field3" Area="RowArea" AreaIndex="1" Caption="Products" FieldName="[Products].[Products].[Products]" />
            <dx:PivotGridField ID="field4" Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="[Measures].[Quantity]"
                TotalCellFormat-FormatString="f2" TotalCellFormat-FormatType="Numeric" />
            <dx:PivotGridField ID="field5" Area="DataArea" AreaIndex="1" Caption="Discount" FieldName="[Measures].[Discount]"
                TotalCellFormat-FormatString="f2" TotalCellFormat-FormatType="Numeric" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
</asp:Content>
