<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scrolling.aspx.cs" Inherits="PagingAndScrolling_Scrolling" %>
<asp:Content ID="Header" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .item {
            position: relative;
        }
        .item-image {
            opacity: 0.2;
            padding-top: 0;
            padding-bottom: 0;
        }
        .items-info {
            display: block;
            position: absolute;
            top: 0;
            bottom: 0;
            left: 0;
            right: 0;
            color: black !important;
        }
        .dxflCaptionCellSys span {
            color: rgb(46, 46, 46) !important;
            font-weight: 700;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="ProductsDataSource" EnableCardsCache="false" Width="100%">
        <Columns>
            <dx:CardViewTextColumn FieldName="ProductName" />
            <dx:CardViewTextColumn FieldName="UnitPrice">
                <PropertiesTextEdit DisplayFormatString="c" />
            </dx:CardViewTextColumn>
            <dx:CardViewTextColumn FieldName="QuantityPerUnit" />
            <dx:CardViewCheckColumn FieldName="Discontinued" />
            <dx:CardViewTextColumn FieldName="Category.CategoryName" />
            <dx:CardViewBinaryImageColumn FieldName="Category.Picture">
                <PropertiesBinaryImage>
                    <ExportImageSettings Width="240" Height="150" />
                </PropertiesBinaryImage>
            </dx:CardViewBinaryImageColumn>
        </Columns>
        <CardLayoutProperties>
            <Items>
                <dx:CardViewLayoutGroup GroupBoxDecoration="None" CssClass="item">
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="Category.Picture" ShowCaption="False" CssClass="item-image" />
                        <dx:CardViewLayoutGroup GroupBoxDecoration="None" CssClass="items-info">
                            <Items>
                                <dx:EmptyLayoutItem />
                                <dx:CardViewColumnLayoutItem ColumnName="ProductName" />
                                <dx:CardViewColumnLayoutItem ColumnName="UnitPrice" />
                                <dx:CardViewColumnLayoutItem ColumnName="QuantityPerUnit" />
                                <dx:CardViewColumnLayoutItem ColumnName="Discontinued" />
                            </Items>
                        </dx:CardViewLayoutGroup>
                    </Items>
                </dx:CardViewLayoutGroup>
            </Items>
        </CardLayoutProperties>
        <Settings VerticalScrollBarMode="Visible" VerticalScrollableHeight="600" />
        <SettingsPager SettingsTableLayout-RowsPerPage="6" />
        <Styles>
            <Card BackColor="White" />
        </Styles>
    </dx:ASPxCardView>
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category" ContextTypeName="NorthwindContext" EntitySetName="Products" />
</asp:Content>
