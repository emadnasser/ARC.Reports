<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Ellipsis.aspx.cs" Inherits="Ellipsis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox ID="EnableEllipsisCheckBox" runat="server" Text="Enable Ellipsis in text" AutoPostBack="true" Checked="true" />
    <br />
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="EmployeesDataSource" EnableCardsCache="false" Width="100%">
        <Columns>
            <dx:CardViewBinaryImageColumn FieldName="Photo" />
            <dx:CardViewTextColumn FieldName="FullName" Caption="Name" UnboundType="String" UnboundExpression="Concat([FirstName], ' ', [LastName])" />
            <dx:CardViewTextColumn FieldName="Title" />
            <dx:CardViewDateColumn FieldName="HireDate" />
            <dx:CardViewTextColumn FieldName="FullAddress" Caption="Address" UnboundType="String" UnboundExpression="Concat([Address], ', ', [City], ', ', [Country])" />
            <dx:CardViewTextColumn FieldName="HomePhone" />
            <dx:CardViewTextColumn FieldName="Notes" />
        </Columns>
        <CardLayoutProperties ColCount="2">
            <Items>
                <dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" RowSpan="7" />
                <dx:CardViewColumnLayoutItem ColumnName="FullName" />
                <dx:CardViewColumnLayoutItem ColumnName="Title" />
                <dx:CardViewColumnLayoutItem ColumnName="HireDate" />
                <dx:CardViewColumnLayoutItem ColumnName="FullAddress" />
                <dx:CardViewColumnLayoutItem ColumnName="HomePhone" />
                <dx:CardViewColumnLayoutItem ColumnName="Notes" />
            </Items>
        </CardLayoutProperties>
        <SettingsPager>
            <SettingsTableLayout ColumnCount="2" />
        </SettingsPager>
    </dx:ASPxCardView>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees"/>
</asp:Content>
