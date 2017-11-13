<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Compliance.aspx.vb" Inherits="Accessibility_Compliance" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="EmployeesDataSource" Width="100%" KeyFieldName="EmployeeID" AccessibilityCompliant="true">
		<Settings ShowHeaderPanel="false"/>
		<SettingsBehavior AllowSelectByCardClick="true" />
		<SettingsPager>
			<AllButton Visible="true" />
			<FirstPageButton Visible="true" />
			<LastPageButton Visible="true" />
			<SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
		</SettingsPager>
		<CardLayoutProperties ColCount="2">
			<Items>
				<dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" />
				<dx:CardViewLayoutGroup ShowCaption="False" VerticalAlign="Middle" GroupBoxDecoration="None">
					<Items>
						<dx:CardViewCommandLayoutItem ShowSelectCheckbox="true" HorizontalAlign="Right" />
						<dx:CardViewColumnLayoutItem ColumnName="FirstName" />
						<dx:CardViewColumnLayoutItem ColumnName="LastName" />
						<dx:CardViewColumnLayoutItem ColumnName="Title" />
					</Items>
				</dx:CardViewLayoutGroup>
			</Items>
			<Styles LayoutItem-Caption-Font-Bold="true" />
		</CardLayoutProperties>
		<Columns>
			<dx:CardViewBinaryImageColumn FieldName="Photo">
				<PropertiesBinaryImage ImageWidth="150px" ImageHeight="150px" />
			</dx:CardViewBinaryImageColumn>
			<dx:CardViewColumn FieldName="FirstName" />
			<dx:CardViewColumn FieldName="LastName" />
			<dx:CardViewColumn FieldName="Title" />
		</Columns>
	</dx:ASPxCardView>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>