<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Export.aspx.vb"
	Inherits="Features_Printing" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="padding-bottom: 30px">
	<table>
		<tr>
			<td style="padding-right: 30px;">
				<strong>Export to:</strong>
			</td>
			<td style="padding-right: 30px">
				<dx:ASPxComboBox ID="listExportFormat" runat="server" Style="vertical-align: middle" SelectedIndex="6" 
					ValueType="System.String" Width="200px" Height="23px">
								<Items>
									<dx:ListEditItem Text="Pdf" Value="0" />
									<dx:ListEditItem Text="Excel" Value="1" />
									<dx:ListEditItem Text="Mht" Value="2" />
									<dx:ListEditItem Text="Rtf" Value="3" />
									<dx:ListEditItem Text="Text" Value="4" />
									<dx:ListEditItem Text="Html" Value="5" />
									<dx:ListEditItem Text="Excel (Data Aware)" Value="6" />
								</Items>
								<ClientSideEvents
									Init="function(s, e) {
										fieldHeaderOptionsPanel.SetVisible(false);
										fieldValuesOptionsPanel.SetVisible(false);
										dataAwareOptionsPanel.SetVisible(true);
										checkCustomFormattedValuesAsText.SetEnabled(false);
									}"
									SelectedIndexChanged="function(s, e) {
										var selectedIndex = s.GetSelectedIndex(), 
											isExportToExcel = selectedIndex == 1,
											isDataAwareExport = selectedIndex == 6;
										fieldHeaderOptionsPanel.SetVisible(!isDataAwareExport);
										fieldValuesOptionsPanel.SetVisible(!isDataAwareExport);
										dataAwareOptionsPanel.SetVisible(isDataAwareExport);
										checkCustomFormattedValuesAsText.SetEnabled(isExportToExcel);
									}" 
								 />
							</dx:ASPxComboBox>
			</td>
			<td style="padding-right: 10px" >
				<dx:ASPxButton ID="ASPxButton3" ClientInstanceName="buttonSaveAs" runat="server" ToolTip="Export and save"
					OnClick="buttonSaveAs_Click" Text="Export"/>
			</td>
			<td>
				<dx:ASPxButton ID="ASPxButton4" ClientInstanceName="buttonOpen" runat="server" ToolTip="Export and open"
					OnClick="buttonOpen_Click" Text="Export and Open" />
			</td>
		</tr>
		</table>
	</div>
	<div style="padding-bottom: 30px">
	<table style="width: 100%;" >
		<tr>
			<td style="width: 30%; padding-right: 30px">
			<dx:ASPxRoundPanel ID="fieldHeaderOptionsPanel" ClientInstanceName="fieldHeaderOptionsPanel" runat="server" Width="100%" HeaderText="Field Header Options:" View="GroupBox" CornerRadius="0px" Height="100%"><PanelCollection>
				<dx:PanelContent ID="PanelContent1"  runat="server">
					<table>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkPrintFilterFieldHeaders" runat="server" Text="Print filter field headers" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkPrintColumnFieldHeaders" runat="server" Text="Print column field headers" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkPrintRowFieldHeaders" runat="server" Text="Print row field headers" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkPrintDataFieldHeaders" runat="server" Text="Print data field headers" Checked="True" />
						</td>
					</tr>
				</table>
				</dx:PanelContent></PanelCollection>
			</dx:ASPxRoundPanel>
			</td>
			<td style="width: 70%;" >
				<dx:ASPxRoundPanel ID="fieldValuesOptionsPanel" ClientInstanceName="fieldValuesOptionsPanel" runat="server" Width="100%" HeaderText="Field Values Options:" View="GroupBox" CornerRadius="0px" Height="100%"><PanelCollection>
					<dx:PanelContent ID="PanelContent2" runat="server">
						<table>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkPrintHeadersOnEveryPage" runat="server" Text="Print column headers on every page" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkMergeColumnFieldValues" runat="server" Text="Merge values of outer column fields" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkMergeRowFieldValues" runat="server" Text="Merge values of outer row fields" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="checkCustomFormattedValuesAsText" ClientInstanceName="checkCustomFormattedValuesAsText" runat="server" 
								Text="Export custom formatted values as text"  Checked="True" />
						</td>
					</tr>
				</table>
					</dx:PanelContent></PanelCollection>
				</dx:ASPxRoundPanel>
			</td>
		</tr>
		<tr>
			<td colspan = "2" style="width: 100%;">
			<dx:ASPxRoundPanel ID="dataAwareOptionsPanel" ClientInstanceName="dataAwareOptionsPanel" Height ="100%" Width ="100%" runat="server" HeaderText="Data Aware Options:" View="GroupBox" CornerRadius="0px"><PanelCollection>
					<dx:PanelContent ID="PanelContent3" runat="server">
						<table>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="allowGroupingCheckBox" ClientInstanceName="allowGroupingCheckBox" runat="server" Text="Allow grouping columns/rows" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="allowFixedColumns" ClientInstanceName="allowFixedColumns" runat="server" Text="Allow fixed ColumnArea and RowArea" Checked="True" />
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="exportCellValuesAsText" ClientInstanceName="exportCellValuesAsText" runat="server" Text="Export cell values as display text"/>
						</td>
					</tr>
					<tr>
						<td>
							<dx:ASPxCheckBox ID="exportRawData" ClientInstanceName="exportRawData" runat="server" Text="Export raw data" CheckState="Unchecked"/>
						</td>
					</tr>
				</table>
					</dx:PanelContent></PanelCollection>
				</dx:ASPxRoundPanel>
				</td>
		</tr>
	</table>
	</div>
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" CssClass="dxpgControl"
		DataSourceID="SalesPersonsDataSource" Width="100%" 
		ClientIDMode="AutoID">
		<Fields>
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Country" FieldName="Country"
				ID="fieldCountry" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Product" FieldName="ProductName"
				ID="fieldProductName" />
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category" FieldName="CategoryName"
				ID="fieldCategoryName" />
			<dx:PivotGridField AreaIndex="0" Caption="Order date" FieldName="OrderDate"
				ID="fieldOrderDate" Visible="False" />
			<dx:PivotGridField Area="FilterArea" AreaIndex="0" Caption="Unit price" FieldName="UnitPrice"
				ID="fieldUnitPrice" Visible="False" />
			<dx:PivotGridField ID="fieldQuantity" Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="Quantity">
			</dx:PivotGridField>
			<dx:PivotGridField ID="fieldDiscount" AreaIndex="0" Caption="Discount" FieldName="Discount" Visible="False">
			</dx:PivotGridField>
			<dx:PivotGridField ID="fieldExtendedPrice" Area="DataArea" AreaIndex="1" Caption="Price" FieldName="Extended_Price">
			</dx:PivotGridField>
			<dx:PivotGridField ID="fieldSalesPerson" Area="ColumnArea" AreaIndex="1" Caption="Sales person" FieldName="Sales_Person">
			</dx:PivotGridField>
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
	<dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1" Visible="False" />
</asp:Content>