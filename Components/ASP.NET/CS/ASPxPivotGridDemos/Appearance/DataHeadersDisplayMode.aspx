<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataHeadersDisplayMode.aspx.cs"
    Inherits="Appearance_DataHeadersDisplayMode" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable BottomMargin">
        <tr>
            <td>
                Data Headers Display Mode:
            </td>
            <td>
                <dx:ASPxComboBox ID="ddlDataHeadersStyle" runat="server" AutoPostBack="True" Width="100px"
                    SelectedIndex="1">
                    <Items>
                        <dx:ListEditItem Text="Default" Value="0" />
                        <dx:ListEditItem Text="Popup" Value="1" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                Data Headers Popup Min Count:
            </td>
            <td>
                <dx:ASPxSpinEdit ID="seDataHeadersLimit" runat="server" AutoPostBack="True" 
                    Number="3" MaxValue="10" Width="100px" />
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" ClientInstanceName="pivotGrid" DataSourceID="CustomerReportsDataSource"
        Width="100%" Height="116px">
        <Fields>
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year" FieldName="OrderDate"
                ID="fieldOrderDate" GroupInterval="DateYear" UnboundFieldName="UnboundColumn1" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Product Amount" FieldName="ProductAmount"
                ID="fieldProductAmount" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="ProductName"
                ID="fieldProductName" />
            <dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Product Amount (min)" FieldName="ProductAmount"
                ID="fieldProductAmount0" SummaryType="Min" />
            <dx:PivotGridField Area="DataArea" AreaIndex="2" Caption="Product Amount (average)"
                FieldName="ProductAmount" ID="fieldProductAmount1" SummaryType="Average" />
            <dx:PivotGridField Area="DataArea" AreaIndex="3" Caption="Product Amount (count)"
                FieldName="ProductAmount" ID="fieldProductAmount2" SummaryType="Count" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource ID="CustomerReportsDataSource" runat="server" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>
