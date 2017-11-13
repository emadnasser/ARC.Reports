<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="KeyboardSupport.aspx.cs"
    Inherits="Accessibility_KeyboardSupport" %>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="margin-bottom: 16px">
        Press <b>CTRL</b> + <b>SHIFT</b> + <b>G</b> to activate the grid
    </div>
    <dx:ASPxGridView runat="server" ID="grid" AutoGenerateColumns="False" DataSourceID="ProductsDataSource"
        KeyFieldName="ProductID" Width="100%" KeyboardSupport="true" AccessKey="G">
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0" ShowSelectCheckbox="True" />
            <dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="2" />
            <dx:GridViewDataComboBoxColumn FieldName="CategoryID" VisibleIndex="3" Caption="Category"
                GroupIndex="0">
                <PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32" ValueField="CategoryID"
                    TextField="CategoryName" />
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="4">
                <PropertiesTextEdit DisplayFormatString="{0:C}" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowGroupPanel="true" />
        <SettingsBehavior AutoExpandAllGroups="true" AllowSelectByRowClick="true" />
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" 
        Select="it.CategoryName, it.CategoryID" />
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" 
        Select="it.ProductID, it.ProductName, it.CategoryID, it.UnitPrice" />
</asp:Content>
