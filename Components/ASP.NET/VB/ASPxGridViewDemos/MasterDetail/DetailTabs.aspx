<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DetailTabs.aspx.vb"
	Inherits="MasterDetail_DetailTabs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.categoryTable {
			width: 100%;
		}
			.categoryTable .imageCell {
				padding: 2px;
			}
			.categoryTable .textCell {
				padding-left: 20px;
				width: 100%;
			}
		.textCell .label {
			color: #969696;
		}
		.textCell .description {
			font-size: 13px;
			width: 230px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="SuppliersDataSource"
		KeyFieldName="SupplierID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Region" Visible="false" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="4" />
		</Columns>
		<Templates>
			<DetailRow>
				<div style="padding: 3px 3px 2px 3px">
					<dx:ASPxPageControl runat="server" ID="pageControl" Width="100%" EnableCallBacks="true">
						<TabPages>
							<dx:TabPage Text="Products" Visible="true">
								<ContentCollection>
									<dx:ContentControl runat="server">
										<dx:ASPxGridView ID="productsGrid" runat="server" DataSourceID="ProductsDataSource"
											KeyFieldName="ProductID" Width="100%" OnBeforePerformDataSelect="productsGrid_DataSelect">
											<Columns>
												<dx:GridViewDataColumn FieldName="ProductName" VisibleIndex="0" />
												<dx:GridViewDataColumn FieldName="CategoryName" VisibleIndex="1" />
												<dx:GridViewDataColumn FieldName="QuantityPerUnit" VisibleIndex="2" />
												<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="3">
													<PropertiesTextEdit DisplayFormatString="c">
													</PropertiesTextEdit>
												</dx:GridViewDataTextColumn>
												<dx:GridViewDataColumn FieldName="UnitsInStock" VisibleIndex="4" />
												<dx:GridViewDataColumn FieldName="Discontinued" VisibleIndex="5" />
											</Columns>
											<Templates>
												<DetailRow>
													<dx:ASPxGridView ID="ordersGridView" runat="server" DataSourceID="OrdersDataSource"
														KeyFieldName="OrderID" Width="100%" OnBeforePerformDataSelect="ordersGrid_DataSelect"
														OnCustomUnboundColumnData="ordersGrid_CustomUnboundColumnData">
														<Columns>
															<dx:GridViewDataColumn FieldName="OrderID" VisibleIndex="0" />
															<dx:GridViewDataTextColumn FieldName="UnitPrice" VisibleIndex="1">
																<PropertiesTextEdit DisplayFormatString="c" />
															</dx:GridViewDataTextColumn>
															<dx:GridViewDataColumn FieldName="Quantity" VisibleIndex="2" />
															<dx:GridViewDataTextColumn FieldName="Discount" VisibleIndex="3">
																<PropertiesTextEdit DisplayFormatString="p" />
															</dx:GridViewDataTextColumn>
															<dx:GridViewDataTextColumn FieldName="Total" VisibleIndex="4" UnboundType="Decimal">
																<PropertiesTextEdit DisplayFormatString="c" />
															</dx:GridViewDataTextColumn>
														</Columns>
														<TotalSummary>
															<dx:ASPxSummaryItem FieldName="Quantity" SummaryType="Sum" />
															<dx:ASPxSummaryItem FieldName="Total" SummaryType="Sum" />
														</TotalSummary>
														<Settings ShowFooter="True" />
													</dx:ASPxGridView>
												</DetailRow>
											</Templates>
											<TotalSummary>
												<dx:ASPxSummaryItem FieldName="UnitsInStock" SummaryType="Sum" />
												<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Average" />
											</TotalSummary>
											<SettingsDetail ShowDetailRow="true" />
											<Settings ShowFooter="True" />
										</dx:ASPxGridView>
									</dx:ContentControl>
								</ContentCollection>
							</dx:TabPage>
							<dx:TabPage Text="Categories" Visible="true">
								<ContentCollection>
									<dx:ContentControl runat="server">
										<dx:ASPxGridView ID="categoriesGridView" runat="server" DataSourceID="CategoriesDataSource"
											EnableRowsCache="False" KeyFieldName="CategoryID" Width="100%" OnBeforePerformDataSelect="categoriesGrid_DataSelect">
											<Columns>
												<dx:GridViewDataColumn FieldName="CategoryName" VisibleIndex="1" />
												<dx:GridViewDataColumn FieldName="Description" VisibleIndex="2" />
											</Columns>
											<Templates>
												<DataRow>
													<table class="categoryTable">
														<tr>
															<td class="imageCell">
																<dx:ASPxBinaryImage ID="ASPxBinaryImage2" runat="server" Value='<%#Eval("Picture")%>' />
															</td>
															<td class="textCell">
																<div class="label">
																	CATEGORY NAME
																</div>
																<div class="description">
																	<%#Eval("CategoryName")%>
																</div>
																<br />
																<div class="label">
																	DESCRIPTION
																</div>
																<div class="description">
																	<%#Eval("Description")%>
																</div>
															</td>
														</tr>
													</table>
												</DataRow>
											</Templates>
										</dx:ASPxGridView>
									</dx:ContentControl>
								</ContentCollection>
							</dx:TabPage>
							<dx:TabPage Text="Address" Visible="true">
								<ContentCollection>
									<dx:ContentControl runat="server">
										<table cellpadding="2" cellspacing="1" style="border-collapse: collapse; width: 100%">
											<tr>
												<td style="font-weight: bold">Address:
												</td>
												<td colspan="3">
													<%#Eval("Address")%>
												</td>
											</tr>
											<tr>
												<td style="font-weight: bold">Postal Code:
												</td>
												<td>
													<%#Eval("PostalCode")%>
												</td>
												<td style="font-weight: bold">Region:
												</td>
												<td>
													<%#Eval("Region")%>
												</td>
											</tr>
											<tr>
												<td style="font-weight: bold">City:
												</td>
												<td>
													<%#Eval("City")%>
												</td>
												<td style="font-weight: bold">Country:
												</td>
												<td>
													<%#Eval("Country")%>
												</td>
											</tr>
											<tr>
												<td style="font-weight: bold">Phone:
												</td>
												<td>
													<%#Eval("Phone")%>
												</td>
												<td style="font-weight: bold">Fax:
												</td>
												<td>
													<%#Eval("Fax")%>
												</td>
											</tr>
										</table>
									</dx:ContentControl>
								</ContentCollection>
							</dx:TabPage>
						</TabPages>
					</dx:ASPxPageControl>
				</div>
			</DetailRow>
		</Templates>
		<SettingsDetail ShowDetailRow="true" />
		<Settings ShowGroupPanel="True" />
		<SettingsBehavior EnableCustomizationWindow="true" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="SuppliersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Suppliers" />
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext"
		CommandText="SELECT p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.Discontinued, c.CategoryName  FROM Products AS p INNER JOIN Categories AS c ON p.CategoryID = c.CategoryID Where p.SupplierID = @SupplierID">
		<CommandParameters>
			<asp:SessionParameter Name="SupplierID" SessionField="SupplierID" Type="int32" />
		</CommandParameters>
	</ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext"
		CommandText="SELECT c.CategoryID, c.CategoryName, c.Description, c.Picture FROM Categories  AS c Where Exists (Select 1 From Products AS p Where p.CategoryID = c.CategoryID and p.SupplierID = @SupplierID)">
		<CommandParameters>
			<asp:SessionParameter Name="SupplierID" SessionField="SupplierID" Type="int32" />
		</CommandParameters>
	</ef:EntityDataSource>
	<ef:EntityDataSource runat="server" ID="OrdersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Order_Details" Where="it.ProductID = @ProductID">
		<WhereParameters>
			<asp:SessionParameter Name="ProductID" SessionField="ProductID" Type="int32" />
		</WhereParameters>
	</ef:EntityDataSource>
</asp:Content>