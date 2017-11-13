<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FieldsCustomization.aspx.vb"
	Inherits="FieldsCustomizationDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				Customization Form Style:
			</td>
			<td>
				<dx:ASPxComboBox ID="FieldListStyle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="FieldListStyle_SelectedIndexChanged"
					SelectedIndex="0" ValueType="System.String">
					<Items>
						<dx:ListEditItem Text="Simple" Value="Simple" Selected="True" />
						<dx:ListEditItem Text="Excel2007" Value="Excel2007" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxCheckBox ID="allowDrag" runat="server" Text="Allow Dragging Fields in Pivot Grid" Checked="True"
					AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td>
				Customization Form Layout:
			</td>
			<td>
				<dx:ASPxComboBox ID="FieldListLayout" runat="server" AutoPostBack="True" OnSelectedIndexChanged="FieldListLayout_SelectedIndexChanged"
					SelectedIndex="0" ValueType="System.String">
					<Items>
						<dx:ListEditItem Text="Fields Section and Areas Section Stacked" Value="StackedDefault"
							Selected="True" />
						<dx:ListEditItem Text="Fields Section and Areas Section Side-By-Side" Value="StackedSideBySide" />
						<dx:ListEditItem Text="Fields Section Only" Value="TopPanelOnly" />
						<dx:ListEditItem Text="Areas Section Only (2 by 2)" Value="BottomPanelOnly2by2" />
						<dx:ListEditItem Text="Areas Section Only (1 by 4)" Value="BottomPanelOnly1by4" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxCheckBox ID="allowDragCF" runat="server" Text="Allow Dragging Fields in Customization Form"
					Checked="True" AutoPostBack="True" />
			</td>
		</tr>
		<tr>
			<td colspan="3">
				<dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="False" EnableClientSideAPI="True" Width="240px"
					Text="Show Customization Window" ClientInstanceName="button">
					<ClientSideEvents Click="function(s, e) { pivotGrid.ChangeCustomizationFieldsVisibility(); }" />
				</dx:ASPxButton>
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="SalesPersonsDataSource"
		OptionsCustomization-AllowDrag="true" OptionsCustomization-AllowDragInCustomizationForm="true"
		OnCustomUnboundFieldData="pivotGrid_CustomUnboundFieldData" CustomizationFieldsLeft="600"
		CustomizationFieldsTop="400" ClientInstanceName="pivotGrid" Width="100%">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Order Quarter" FieldName="OrderDate"
				ID="fieldOrderDate" GroupInterval="DateQuarter" ValueFormat-FormatString="Qtr {0}"
				ValueFormat-FormatType="Numeric" UnboundFieldName="UnboundColumn0" DisplayFolder="Date" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Category Name" FieldName="CategoryName"
				ID="fieldCategoryName" DisplayFolder="Products" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="Country" ID="fieldCountry" DisplayFolder="Geography" />
			<dx:PivotGridField ID="OrderAmount" Area="DataArea" AreaIndex="0" Caption="Order Amount"
				UnboundType="Decimal" UnboundFieldName="OrderAmount" DisplayFolder="Orders\\Unbound" />
			<dx:PivotGridField Area="DataArea" AreaIndex="1" FieldName="Quantity" ID="fieldQuantity" DisplayFolder="Orders" />
			<dx:PivotGridField ID="OrderYear" AreaIndex="0" Caption="Order Year" FieldName="OrderDate"
				GroupInterval="DateYear" UnboundFieldName="OrderYear" DisplayFolder="Date" />
			<dx:PivotGridField AreaIndex="1" Caption="Product Name" FieldName="ProductName" ID="fieldProductName"
				Visible="False" DisplayFolder="Products" />
			<dx:PivotGridField ID="fieldSalesPerson" AreaIndex="1" Caption="Sales Person" FieldName="Sales_Person"
				Visible="False" SummaryDisplayType="AbsoluteVariation" DisplayFolder="Sales Person" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
		<ClientSideEvents CustomizationFieldsVisibleChanged="function(s, e) {
	if(button != null &amp;&amp; pivotGrid != null) {
		button.SetText((pivotGrid.GetCustomizationFieldsVisibility() ? &quot;Hide&quot; : &quot;Show&quot;) + &quot; Customization Window&quot;);
	}
}" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>