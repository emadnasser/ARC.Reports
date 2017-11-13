<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TopValues.aspx.vb"
	Inherits="TopValuesDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxComboBox ID="ddlTopCount" runat="server" AutoPostBack="true" Width="50px" Caption="Show Top">
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxComboBox ID="ddlField" runat="server" AutoPostBack="true" Width="120" SelectedIndex="0" Caption="Values for the Field">
					<Items>
						<dx:ListEditItem Text="Sales Person" Value="0" />
						<dx:ListEditItem Text="Order Id" Value="1" />
						<dx:ListEditItem Text="Category Name" Value="2" />
						<dx:ListEditItem Text="Product Name" Value="3" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td style="padding-left : 20px">
				<dx:ASPxCheckBox ID="cbShowOthers" runat="server" AutoPostBack="true" Text="TopValuesShowOthers" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="SalesPersonsDataSource"
		Width="800px">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Sales Person" FieldName="Sales_Person"
				ID="fieldSalesPerson" SortOrder="Descending" SortBySummaryInfo-FieldName="Extended_Price" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Order Amount" FieldName="Extended_Price"
				ID="fieldOrderAmount" />
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Order Id" FieldName="OrderID"
				ID="fieldOrderID" SortOrder="Descending" Visible="False" SortBySummaryInfo-FieldName="Extended_Price" />
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category Name" FieldName="CategoryName"
				ID="fieldCategoryName" SortOrder="Descending" Visible="False" SortBySummaryInfo-FieldName="Extended_Price" />
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Product Name" FieldName="ProductName"
				ID="fieldProductName" SortOrder="Descending" Visible="False" SortBySummaryInfo-FieldName="Extended_Price" />
		</Fields>
		<OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="SalesPersonsDataSource" ContextTypeName="NorthwindContext" EntitySetName="SalesPersons" />
</asp:Content>