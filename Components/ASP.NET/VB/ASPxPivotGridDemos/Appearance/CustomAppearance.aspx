<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomAppearance.aspx.vb"
	Inherits="Features_CustomAppearance" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxCheckBox ID="cbApplyCustomCellAppearance" runat="server" AutoPostBack="True" Text="Apply Custom Cell Appearance" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbTopAlignRowFieldValues" runat="server" AutoPostBack="True" Text="Top Align Row Field Values"
					OnCheckedChanged="cbTopAlignRowFieldValues_CheckedChanged" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="pivotGrid" runat="server" CssClass="dxpgControl" ClientInstanceName="pivotGrid"
		DataSourceID="CustomerReportDataSource" OnCustomCellStyle="ASPxPivotGrid1_CustomCellStyle"
		Width="100%" Height="116px">
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Customer" FieldName="CompanyName"
				ID="fieldCompanyName" UnboundFieldName="" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year" FieldName="OrderDate"
				ID="fieldOrderDate" GroupInterval="DateYear" UnboundFieldName="UnboundColumn1" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Product Amount" FieldName="ProductAmount"
				ID="fieldProductAmount" UnboundFieldName="" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="ProductName"
				ID="fieldProductName" UnboundFieldName="" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsLoadingPanel Text="Loading&amp;hellip;" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="CustomerReportDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>