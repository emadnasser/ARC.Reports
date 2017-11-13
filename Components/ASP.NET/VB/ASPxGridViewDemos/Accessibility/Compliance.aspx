<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Compliance.aspx.vb" Inherits="Accessibility_Compliance" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" runat="server" ClientInstanceName="grid" DataSourceID="ProducstDataSource"
		KeyFieldName="ProductID" AutoGenerateColumns="false" Caption="Products" Width="100%" AccessibilityCompliant="true">
		<Columns>
			<dx:GridViewCommandColumn ShowSelectCheckbox="true" SelectAllCheckboxMode="AllPages" Width="50" />
			<dx:GridViewDataTextColumn FieldName="ProductName" Width="200" />
			<dx:GridViewDataComboBoxColumn Caption="Category Name" FieldName="CategoryID" Width="100">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueField="CategoryID" ValueType="System.Int32"
					TextField="CategoryName" DropDownStyle="DropDownList">
				</PropertiesComboBox>
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsOnOrder" Width="100" />
			<dx:GridViewDataCheckColumn FieldName="Discontinued" Width="100" />
			<dx:GridViewDataProgressBarColumn FieldName="ReorderLevel" Width="100" />
			<dx:GridViewDataDateColumn FieldName="UnboundDate" UnboundType="DateTime" Caption="Order Date"
				UnboundExpression="AddMonths(AddDays(Today(), [ReorderLevel]), -1)" Width="100" />
		</Columns>
		<Settings ShowFilterRow="true" ShowFilterRowMenu="true" />
		<SettingsPager>
			<AllButton Visible="true" />
			<FirstPageButton Visible="true" />
			<LastPageButton Visible="true" />
			<PageSizeItemSettings Visible="true" />
		</SettingsPager>
	</dx:ASPxGridView>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<ef:EntityDataSource runat="server" ID="ProducstDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" />
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>