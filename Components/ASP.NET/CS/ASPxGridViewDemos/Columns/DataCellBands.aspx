<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="DataCellBands.aspx.cs" Inherits="Columns_DataCellBands" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <dx:ASPxComboBox ID="ColumnMoveMode" Caption="ColumnMoveMode" runat="server" ValueType="DevExpress.Web.GridColumnMoveMode" AutoPostBack="true" >
        <Items>
            <dx:ListEditItem Value="AmongSiblings" />
            <dx:ListEditItem Value="ThroughHierarchy" Selected="true" />
        </Items>
    </dx:ASPxComboBox>
    <br />
    <dx:ASPxGridView ID="Grid" runat="server" DataSourceID="HomesDataSource" Width="100%">
        <Columns>
            <dx:GridViewDataImageColumn FieldName="PhotoUrl" Caption="Photo" CellRowSpan="3">
                <PropertiesImage ImageWidth="220" />
            </dx:GridViewDataImageColumn>
            <dx:GridViewDataColumn FieldName="Address">
                <Columns>
                    <dx:GridViewDataColumn FieldName="Features">
                        <Columns>
                            <dx:GridViewDataColumn FieldName="Beds" />
                            <dx:GridViewDataColumn FieldName="Baths" />
                            <dx:GridViewDataColumn FieldName="HouseSize" />
                            <dx:GridViewDataColumn FieldName="YearBuilt" CellStyle-HorizontalAlign="Right" />
                        </Columns>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataSpinEditColumn FieldName="Price">
                        <PropertiesSpinEdit DisplayFormatString="c0" />
                        <CellStyle CssClass="price-cell" />
                    </dx:GridViewDataSpinEditColumn>
                </Columns>
                <CellStyle CssClass="address-cell" />
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsPager PageSize="3" />
        <Styles>
            <Header HorizontalAlign="Center" />
        </Styles>
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="HomesDataSource" runat="server" SelectMethod="SelectHomes" TypeName="HomesDataProvider" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .price-cell {
            font-size: 1.6em;
            font-weight: 600;
            text-align: center;
            padding-top: 0 !important;
        }
        .address-cell {
            font-size: 1.3em;
            font-weight: 600;
        }
    </style>
</asp:Content>
