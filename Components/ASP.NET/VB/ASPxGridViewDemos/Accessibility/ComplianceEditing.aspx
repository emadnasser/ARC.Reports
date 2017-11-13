<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ComplianceEditing.aspx.vb" Inherits="Accessibility_ComplianceEditing" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxRadioButtonList runat="server" ID="rblEditMode" AutoPostBack="true" ValueType="System.Int32"
		Caption="Edit Mode" RepeatColumns="2" OnSelectedIndexChanged="rblEditMode_SelectedIndexChanged">
		<Border BorderWidth="0px" />
		<Items>
			<dx:ListEditItem Text="Batch" Value="0" Selected="true"/>
			<dx:ListEditItem Text="EditForm" Value="1"/>
		</Items>
	</dx:ASPxRadioButtonList>
	<br />
	<dx:ASPxGridView ID="grid" runat="server" ClientInstanceName="grid" DataSourceID="DemoDataSource1"
		KeyFieldName="ProductID" AutoGenerateColumns="false" Caption="Products" Width="100%" AccessibilityCompliant="true">
		<Columns>
			<dx:GridViewCommandColumn ShowEditButton="true" Width="50" />
			<dx:GridViewDataTextColumn FieldName="ProductName" Width="200">
				<SettingsHeaderFilter Mode="CheckedList"/>
			</dx:GridViewDataTextColumn>
			<dx:GridViewDataComboBoxColumn Caption="Category Name" FieldName="CategoryID" Width="150">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueField="CategoryID" ValueType="System.Int32"
					TextField="CategoryName" DropDownStyle="DropDownList">
				</PropertiesComboBox>
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsOnOrder" Width="100">
				<SettingsHeaderFilter Mode="CheckedList"/>
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataCheckColumn FieldName="Discontinued" Width="100" />
			<dx:GridViewDataProgressBarColumn FieldName="ReorderLevel" Width="100" />
			<dx:GridViewDataDateColumn FieldName="UnboundDate" UnboundType="DateTime" Caption="Order Date"
				UnboundExpression="AddMonths(AddDays(Today(), [ReorderLevel]), -1)" Width="100" />
		</Columns>
		<Settings VerticalScrollBarMode="Visible" ShowHeaderFilterButton="true" VerticalScrollableHeight="300" />
		<SettingsEditing Mode="Batch">
			<BatchEditSettings EditMode="Cell" />
		</SettingsEditing>
		<SettingsPager PageSize="20">
			<AllButton Visible="true" />
			<FirstPageButton Visible="true" />
			<LastPageButton Visible="true" />
			<PageSizeItemSettings Visible="true" Items="10,20,50" ShowAllItem="true"/>
		</SettingsPager>
	</dx:ASPxGridView>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EnableUpdate="True" EntitySetName="Products" />
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>