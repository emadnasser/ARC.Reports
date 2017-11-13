<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataItem.aspx.cs" Inherits="Templates_DataItem" %>
<asp:Content ID="ContentStyle" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .categoryProduct {
            background-color: #F0F0F0;
            margin-right: 5px;
            margin-bottom: 5px;
            padding: 4px;
            display: inline-block;
            border: 1px solid #ACACAC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="CategoriesDataSource" KeyFieldName="CategoryID" Width="100%">
        <Rows>
            <dx:VerticalGridBinaryImageRow FieldName="Picture">
                <PropertiesBinaryImage ImageHeight="150" />
                <RecordStyle HorizontalAlign="Center" />
            </dx:VerticalGridBinaryImageRow>
            <dx:VerticalGridDataRow FieldName="CategoryName" />
            <dx:VerticalGridDataRow FieldName="Description" />
            <dx:VerticalGridDataRow Caption="Products" RecordStyle-VerticalAlign="Top">
                <DataItemTemplate>
                    <%# GetProductsHtml(Container) %>
                </DataItemTemplate>
            </dx:VerticalGridDataRow>
        </Rows>
        <Settings HeaderAreaWidth="120" RecordWidth="260" HorizontalScrollBarMode="Visible" />
    </dx:ASPxVerticalGrid>
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"></ef:EntityDataSource>
</asp:Content>
