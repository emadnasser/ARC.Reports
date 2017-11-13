<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BinaryImageColumnEditing.aspx.vb" Inherits="GridEditing_BinaryImageColumnEditing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="GridView" DataSourceID="DemoDataSource1" KeyFieldName="EmployeeID" EnableRowsCache="false" Width="100%" runat="server">
		<Columns>
			<dx:GridViewCommandColumn ShowEditButton="true" />
			<dx:GridViewDataBinaryImageColumn FieldName="Photo">
				<PropertiesBinaryImage ImageHeight="170px" ImageWidth="160px">
					<EditingSettings Enabled="true" UploadSettings-UploadValidationSettings-MaxFileSize="4194304"/>     
				</PropertiesBinaryImage>
			</dx:GridViewDataBinaryImageColumn>
			<dx:GridViewDataTextColumn FieldName="FirstName" />
			<dx:GridViewDataTextColumn FieldName="LastName" />
			<dx:GridViewDataTextColumn FieldName="Title" Caption="Position"/>
			<dx:GridViewDataTextColumn FieldName="HomePhone" />
			<dx:GridViewDataDateColumn FieldName="HireDate" />
			<dx:GridViewDataDateColumn FieldName="BirthDate" />
		</Columns>
		<SettingsPager PageSize="3"></SettingsPager>
		<SettingsEditing UseFormLayout="True" Mode="EditForm" EditFormColumnCount="3"></SettingsEditing>
		<EditFormLayoutProperties ColCount="3">
			<Items>
				<dx:GridViewColumnLayoutItem ColumnName="Photo" RowSpan="4" ShowCaption="False" HelpText="You can upload JPG, GIF or PNG file. Maximum fils size is 4MB." Width="180px"/>
				<dx:GridViewColumnLayoutItem ColumnName="FirstName"/>
				<dx:GridViewColumnLayoutItem ColumnName="LastName"/>
				<dx:GridViewColumnLayoutItem ColumnName="Title" Caption="Position"/>
				<dx:GridViewColumnLayoutItem ColumnName="HomePhone" />
				<dx:GridViewColumnLayoutItem ColumnName="HireDate" />
				<dx:GridViewColumnLayoutItem ColumnName="BirthDate" />
				<dx:EmptyLayoutItem/>
				<dx:EditModeCommandLayoutItem ShowCancelButton="true" ShowUpdateButton="true" HorizontalAlign="Right" />
			</Items>
		</EditFormLayoutProperties>
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="EmployeesDataSource"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" EnableInsert="true" EnableUpdate="true" />
</asp:Content>