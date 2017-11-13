<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FilterRow.aspx.vb" Inherits="Filtering_FilterRow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxLabel ID="filterRowModeLabel" runat="server" Text="FilterRowMode:" AssociatedControlID="filterRowModeCombo" Wrap="False" />
			</td>
			<td>
				<dx:ASPxComboBox ID="filterRowModeCombo" runat="server" AutoPostBack="true" SelectedIndex="1" Width="120px">
					<Items>
						<dx:ListEditItem Value="Auto" />
						<dx:ListEditItem Value="OnClick" />
					</Items>
				</dx:ASPxComboBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblShowFilterRowMenu" runat="server" Text="ShowFilterRowMenu:" AssociatedControlID="chkFilterRowMenu" Wrap="False" />
			</td>
			<td>
				<dx:ASPxCheckBox runat="server" ID="chkFilterRowMenu" AutoPostBack="true" />
			</td>
		</tr>
	</table>
	<br />
	<dx:ASPxGridView ID="Grid" ClientInstanceName="Grid" runat="server" AutoGenerateColumns="False"
		DataSourceID="ProductsDataSource" KeyFieldName="ProductID" Width="1050px" OnLoad="Grid_Load">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" VisibleIndex="0" />
			<dx:GridViewDataComboBoxColumn Caption="Category Name" FieldName="CategoryID" VisibleIndex="1" Width="130">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueField="CategoryID" IncrementalFilteringMode="StartsWith"
					TextField="CategoryName" ValueType="System.Int32" DropDownStyle="DropDownList" >
					<ClearButton DisplayMode="OnHover"></ClearButton>
				</PropertiesComboBox>
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" VisibleIndex="2" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice" VisibleIndex="3" Width="130">
				<PropertiesSpinEdit DisplayFormatString="c" DecimalPlaces="2" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataTextColumn FieldName="ReorderLevel" VisibleIndex="4" />
			<dx:GridViewDataCheckColumn FieldName="Discontinued" VisibleIndex="5" Width="110">
				<PropertiesCheckEdit DisplayTextChecked="Yes" DisplayTextUnchecked="No" />
			</dx:GridViewDataCheckColumn>
			<dx:GridViewCommandColumn ShowClearFilterButton="true" ShowApplyFilterButton="true" VisibleIndex="6" />
		</Columns>
		<Settings ShowFilterRow="True" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products"/>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories"/>
</asp:Content>