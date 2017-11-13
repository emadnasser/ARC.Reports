<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CompactLayout.aspx.vb"
	Inherits="Appearance_CompactLayout" %>
<asp:Content runat="server" ID="CssContent" ContentPlaceHolderID="CustomHeadHolder">
	<style type="text/css">
		div span input { margin-left: 10px; }
	</style>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ContentHolder">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxRadioButtonList ID="LayoutMode" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Border-BorderStyle="None">
					<Items>
						<dx:ListEditItem Value="0" Text="Compact Layout" Selected="True" />
						<dx:ListEditItem Value="1" Text="Full Layout" />
					</Items>
				</dx:ASPxRadioButtonList>
			</td>
		</tr>
	</table>
	<dx:ASPxRoundPanel runat="server" ID="ASPxRoundPanel3" HeaderText="Complex Pivot Table">
		<PanelCollection>
			<dx:PanelContent ID="PanelContent1" runat="server">
				<table>
					<tr>
						<td style="padding-right: 8px;">
							<dx:ASPxPivotCustomizationControl ID="ASPxPivotCustomizationControl1" ClientInstanceName="ASPxPivotCustomizationControl1"
								runat="server" Layout="BottomPanelOnly2by2" AllowedLayouts="BottomPanelOnly1by4, BottomPanelOnly2by2, StackedDefault, StackedSideBySide"
								Height="400px" Width="300px" AllowSort="true" AllowFilter="true" />
						</td>
						<td>
							<dx:ASPxPivotGrid ID="ASPxPivotGrid1" ClientInstanceName="ASPxPivotGrid1" runat="server"
								OptionsPager-RowsPerPage="15" DataSourceID="SalesPersonsDataSource" Width="500px">
								<Styles>
									<FieldValueStyle Wrap="False" />
								</Styles>
								<Fields>
									<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Country" FieldName="Country"
										ID="fieldCountry" />
									<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Category Name" FieldName="CategoryName"
										ID="fieldCategoryName" />
									<dx:PivotGridField Area="RowArea" AreaIndex="2" Caption="Product Name" FieldName="ProductName"
										ID="fieldProductName" />
									<dx:PivotGridField Area="RowArea" AreaIndex="3" Caption="Customer" FieldName="Sales_Person"
										ID="fieldSalesPerson" />
									<dx:PivotGridField Area="RowArea" AreaIndex="4" Caption="Order Year" FieldName="OrderDate"
										ID="fieldOrderYear" GroupInterval="DateYear" />
									<dx:PivotGridField Area="RowArea" AreaIndex="5" Caption="Order Quarter" FieldName="OrderDate"
										ID="fieldOrderQuarter" GroupInterval="DateQuarter" ValueFormat-FormatString="Qtr {0}" ValueFormat-FormatType="Numeric" />
									<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="Quantity"
										ID="fieldQuantity" />
									<dx:PivotGridField Area="FilterArea" AreaIndex="0" Caption="UnitPrice" FieldName="UnitPrice"
										ID="fieldUnitPrice" />
								</Fields>
								<OptionsPager NumericButtonCount="7" />
								<OptionsView HorizontalScrollBarMode="Auto" RowTotalsLocation="Tree" ShowTotalsForSingleValues="True"
									ShowColumnHeaders="False" ShowDataHeaders="False" ShowFilterHeaders="False" ShowRowHeaders="False" />
								<OptionsFilter NativeCheckBoxes="False" />
								<OptionsCustomization CustomizationFormStyle="Excel2007" />
								<ClientSideEvents Init="function(s, e) {
	if(typeof(ASPxPivotCustomizationControl1) == 'undefined')
		return;
	setTimeout( 
		function(){
			if(ASPxPivotGrid1.GetMainDiv().clientHeight &gt; 400)
				ASPxPivotCustomizationControl1.SetHeight(ASPxPivotGrid1.GetMainElement().offsetHeight); 
			else 
				ASPxPivotCustomizationControl1.SetHeight(400);
		}, 100);
	}" />
								<OptionsPager RowsPerPage="15" />
							</dx:ASPxPivotGrid>
						</td>
					</tr>
				</table>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxRoundPanel>
	<ef:EntityDataSource ID="SalesPersonsDataSource" runat="server" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>