<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditModes.aspx.cs" Inherits="Editing_EditModes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="EditModeComboBox" runat="server" AutoPostBack="true" Caption="Edit Mode:" SelectedIndex="0">
        <Items>
            <dx:ListEditItem Value="EditForm" />
            <dx:ListEditItem Value="PopupEditForm" />
        </Items>
    </dx:ASPxComboBox>
    <br />
    <dx:ASPxCardView ID="CardView" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="EmployeeID" EnableCardsCache="false" Width="700">
        <SettingsPager>
            <SettingsTableLayout ColumnCount="1" RowsPerPage="2" />
        </SettingsPager>
        <Columns>
            <dx:CardViewBinaryImageColumn FieldName="Photo">
                <PropertiesBinaryImage ImageHeight="175px">
                    <EditingSettings Enabled="true" UploadSettings-UploadValidationSettings-MaxFileSize="4194304" />
                </PropertiesBinaryImage>
            </dx:CardViewBinaryImageColumn>
            <dx:CardViewTextColumn FieldName="FirstName" />
            <dx:CardViewTextColumn FieldName="LastName" />
            <dx:CardViewTextColumn FieldName="Title" Caption="Position" />
            <dx:CardViewTextColumn FieldName="HomePhone" />
            <dx:CardViewDateColumn FieldName="HireDate" />
            <dx:CardViewDateColumn FieldName="BirthDate" />
            <dx:CardViewMemoColumn FieldName="Notes" PropertiesMemoEdit-Height="80" />
        </Columns>
        <CardLayoutProperties ColCount="3">
            <Items>
                <dx:CardViewCommandLayoutItem ShowEditButton="true" ColSpan="3" HorizontalAlign="Right" />
                <dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" ColSpan="1" RowSpan="4"></dx:CardViewColumnLayoutItem>
                <dx:CardViewColumnLayoutItem ColumnName="FirstName" />
                <dx:CardViewColumnLayoutItem ColumnName="LastName" />
                <dx:CardViewColumnLayoutItem ColumnName="Title" />
                <dx:CardViewColumnLayoutItem ColumnName="HomePhone" />
                <dx:CardViewColumnLayoutItem ColumnName="HireDate" />
                <dx:CardViewColumnLayoutItem ColumnName="BirthDate" />
                <dx:CardViewColumnLayoutItem ColumnName="Notes" CaptionSettings-Location="Top" VerticalAlign="Top" ColSpan="2" />
                <dx:EditModeCommandLayoutItem HorizontalAlign="Right" ColSpan="3" />
            </Items>
        </CardLayoutProperties>
    </dx:ASPxCardView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="EmployeesDataSource"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" EnableDelete="true" EnableInsert="true" EnableUpdate="true" />
</asp:Content>
