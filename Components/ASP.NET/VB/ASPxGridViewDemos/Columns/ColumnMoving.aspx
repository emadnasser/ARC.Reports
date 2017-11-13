<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="ColumnMoving.aspx.vb" Inherits="Columns_ColumnMoving" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">  
	<dx:ASPxFormLayout runat="server" ID="flOptions" UseDefaultPaddings="false">
		<Items>
			<dx:LayoutItem Caption="Process column moving on client">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxCheckBox runat="server" ID="cbProcessColumnMoveOnClient" AutoPostBack="true" Checked="true" />
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
			<dx:LayoutItem Caption="Column move mode">
				<LayoutItemNestedControlCollection>
					<dx:LayoutItemNestedControlContainer>
						<dx:ASPxComboBox runat="server" ID="cpColumnMoveMode" AutoPostBack="true" ValueType="DevExpress.Web.GridColumnMoveMode" >
							<Items>
								<dx:ListEditItem Value="AmongSiblings" Selected="true" />
								<dx:ListEditItem Value="ThroughHierarchy" />
							</Items>
						</dx:ASPxComboBox>
					</dx:LayoutItemNestedControlContainer>
				</LayoutItemNestedControlCollection>
			</dx:LayoutItem>
		</Items>
	</dx:ASPxFormLayout>
	<br />
	<dx:ASPxGridView ID="Grid" runat="server" DataSourceID="ProductsDataSource" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" />
			<dx:GridViewDataComboBoxColumn FieldName="Category.CategoryName" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsInStock" />
			<dx:GridViewDataSpinEditColumn FieldName="Total" UnboundType="Integer" UnboundExpression="UnitsInStock*UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataCheckColumn FieldName="Discontinued" Width="80">
				<HeaderStyle HorizontalAlign="Center" />
			</dx:GridViewDataCheckColumn>
		</Columns>
		<FormatConditions>
			<dx:GridViewFormatConditionHighlight FieldName="UnitPrice" Expression="[Discount] > 0" Format="GreenFillWithDarkGreenText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="TopItems" Threshold="15" Format="BoldText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="ItalicText" />
			<dx:GridViewFormatConditionTopBottom FieldName="UnitPrice" Rule="AboveAverage" Format="RedText" />
			<dx:GridViewFormatConditionColorScale FieldName="UnitsInStock" Format="BlueWhiteRed" />
			<dx:GridViewFormatConditionIconSet FieldName="UnitsInStock" Format="Ratings4" />
			<dx:GridViewFormatConditionIconSet FieldName="Total" Format="Arrows5Colored" />
		</FormatConditions>
	</dx:ASPxGridView>  
	<div class="Note">
		<b>Note:</b>
		For demonstration purposes, the grid's callback time is intentionally extended.
	</div>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" Include="Category" ContextTypeName="NorthwindContext" EntitySetName="Products"></ef:EntityDataSource>
</asp:Content>