<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Browser.aspx.vb"
	Inherits="Features_OLAP" AspCompat="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" CustomizationFieldsLeft="600" CustomizationFieldsTop="400"
		ClientInstanceName="pivotGrid" CssClass="dxpgControl" Width="100%" OptionsCustomization-CustomizationFormStyle="Excel2007"
		OLAPConnectionString="<%$ ConnectionStrings:NorthwindCubeFileConnection %>" >
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Category Name" FieldName="[Categories].[Category Name].[Category Name]"
				ID="field0" SortMode="None" />
			<dx:PivotGridField AreaIndex="0" Caption="City" FieldName="[Customers].[City].[City]"
				ID="field1" SortMode="None" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Country" FieldName="[Customers].[Country].[Country]"
				ID="field2" SortMode="None" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="[Products].[Products].[Products]"
				ID="field3" SortMode="None" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Quantity" FieldName="[Measures].[Quantity]"
				ID="field4" CellFormat-FormatString="#.##" CellFormat-FormatType="Custom" />
			<dx:PivotGridField Area="DataArea" AreaIndex="1" Caption="Discount" FieldName="[Measures].[Discount]"
				ID="field5" CellFormat-FormatString="{0:f2}%" CellFormat-FormatType="Custom" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
</asp:Content>