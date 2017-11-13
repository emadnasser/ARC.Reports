<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerReports.aspx.cs"
    Inherits="CustomerReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="BottomMargin">
        <tr>
            <td>
                <dx:ASPxRadioButtonList ID="tblDemoKind" runat="server" AutoPostBack="true" RepeatDirection="Horizontal"
                    OnSelectedIndexChanged="tblDemoKind_SelectedIndexChanged" Border-BorderStyle="None">
                    <Items>
                        <dx:ListEditItem Value="0" Text="Customers" Selected="True" />
                        <dx:ListEditItem Value="1" Text="Products(Filtering)" />
                        <dx:ListEditItem Value="2" Text="Top 2 Products" />
                        <dx:ListEditItem Value="3" Text="Top 10 Customers" />
                    </Items>
                </dx:ASPxRadioButtonList>
                <asp:Panel ID="filterPanel" runat="server" Visible="false">
                    <table class="OptionsTable" style="margin-left: 14px">
                        <tr>
                            <td>
                                <label>
                                    Filter by: Year</label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="filterYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="filterYear_SelectedIndexChanged"
                                    SelectedIndex="0" ValueType="System.String" Width="60px">
                                    <Items>
                                        <dx:ListEditItem Value="-1" Text="All" />
                                        <dx:ListEditItem Value="1996" Text="1996" />
                                        <dx:ListEditItem Value="1997" Text="1997" />
                                        <dx:ListEditItem Value="1998" Text="1998" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label>
                                    Quarter</label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="filterQuarter" runat="server" AutoPostBack="True" OnSelectedIndexChanged="filterYear_SelectedIndexChanged"
                                    SelectedIndex="0" ValueType="System.String" Width="60px">
                                    <Items>
                                        <dx:ListEditItem Value="-1" Text="All" />
                                        <dx:ListEditItem Value="1" Text="Qtr 1" />
                                        <dx:ListEditItem Value="2" Text="Qtr 2" />
                                        <dx:ListEditItem Value="3" Text="Qtr 3" />
                                        <dx:ListEditItem Value="4" Text="Qtr 4" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="CustomerReportsDataSource"
        Width="830px">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="CompanyName" ID="fieldCompanyName"
                Caption="Customer" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="OrderDate" ID="fieldOrderDate0"
                Caption="Year" GroupInterval="DateYear" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="OrderDate" ID="fieldOrderDate1"
                Caption="Quarter" GroupInterval="DateQuarter" ValueFormat-FormatType="Numeric" ValueFormat-FormatString="Qtr {0}" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductAmount" ID="fieldProductAmount"
                Caption="Product Amount" />
            <dx:PivotGridField AreaIndex="0" FieldName="ProductName" ID="fieldProductName"
                Caption="Product Name" />
        </Fields>
        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
    </dx:ASPxPivotGrid>
    <ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>
