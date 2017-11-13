<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BatchEditing.aspx.cs" Inherits="Editing_BatchEditing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
    <table class="OptionsTable BottomMargin">
    <tr><td>
        <dx:ASPxLabel ID="EditModeLabel" runat="server" Text="Edit mode:" AssociatedControlID="EditModeCombo" />
    </td><td>
        <dx:ASPxComboBox runat="server" ID="EditModeCombo" AutoPostBack="true" SelectedIndex="0">
            <Items>
                <dx:ListEditItem Value="Cell" />
                <dx:ListEditItem Value="Card" />
            </Items>
        </dx:ASPxComboBox>
    </td></tr><tr><td>
        <dx:ASPxLabel ID="StartEditActionLabel" runat="server" Text="Start edit action:" AssociatedControlID="StartEditActionCombo" />
    </td><td>
        <dx:ASPxComboBox runat="server" ID="StartEditActionCombo" AutoPostBack="true" SelectedIndex="2">
            <Items>
                <dx:ListEditItem Value="Click" />
                <dx:ListEditItem Value="DblClick" />
                <dx:ListEditItem Value="FocusedCellClick" />
            </Items>
        </dx:ASPxComboBox>
    </td></tr><tr><td>
        <dx:ASPxLabel ID="HighlightDeletedRowsLabel" runat="server" Text="Highlight deleted cards:" AssociatedControlID="cbHighlightDeletedCards" />
    </td><td>
        <dx:ASPxCheckBox runat="server" ID="cbHighlightDeletedCards" AutoPostBack="true" Checked="true" />
    </td></tr>
    </table>
    <br />
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="DemoDataSource1" ClientInstanceName="CardView" KeyFieldName="ProductID" Width="100%">
        <Columns>
            <dx:CardViewTextColumn FieldName="ProductName">
                <PropertiesTextEdit>
                    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" />
                </PropertiesTextEdit>
            </dx:CardViewTextColumn>
            <dx:CardViewComboBoxColumn FieldName="CategoryID" Caption="Category Name">
                <PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32" ValueField="CategoryID" TextField="CategoryName" />
            </dx:CardViewComboBoxColumn>
            <dx:CardViewTextColumn FieldName="QuantityPerUnit" />
            <dx:CardViewSpinEditColumn FieldName="UnitPrice">
                <PropertiesSpinEdit DisplayFormatString="c">
                    <ValidationSettings RequiredField-IsRequired="true" Display="Dynamic" />
                </PropertiesSpinEdit>
            </dx:CardViewSpinEditColumn>
            <dx:CardViewSpinEditColumn FieldName="UnitsInStock" />
            <dx:CardViewCheckColumn FieldName="Discontinued" />
        </Columns>
        <CardLayoutProperties>
            <Items>
                <dx:CardViewCommandLayoutItem ShowNewButton="true" ShowDeleteButton="true" HorizontalAlign="Right" />
                <dx:CardViewColumnLayoutItem ColumnName="ProductName" />
                <dx:CardViewColumnLayoutItem ColumnName="CategoryID" />
                <dx:CardViewColumnLayoutItem ColumnName="QuantityPerUnit" />
                <dx:CardViewColumnLayoutItem ColumnName="UnitPrice" />
                <dx:CardViewColumnLayoutItem ColumnName="UnitsInStock" />
                <dx:CardViewColumnLayoutItem ColumnName="Discontinued" />
            </Items>
        </CardLayoutProperties>
        <SettingsEditing Mode="Batch" />
        <SettingsPager>
            <SettingsTableLayout RowsPerPage="2" />
        </SettingsPager>
    </dx:ASPxCardView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" Include="Category" EnableDelete="true" EnableInsert="true" EnableUpdate="true" />
    <ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"></ef:EntityDataSource>
</asp:Content>
