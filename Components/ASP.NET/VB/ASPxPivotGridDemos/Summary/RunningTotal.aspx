<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RunningTotal.aspx.vb"
	Inherits="SummaryVariationDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxCheckBox ID="cbRunningTotals" runat="server" Text="Include Previous Quarter Sales into the Values of the Next Quarter"
					Checked="True" AutoPostBack="True" />
				<dx:ASPxCheckBox ID="cbAllowCrossGroupRunningTotals" runat="server" Text="Allow Cross-Group Running Totals Accumulation"
					Checked="False" AutoPostBack="True" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" DataSourceID="CustomerReportsDataSource"
		CssClass="" Width="100%">
		<OptionsView ShowFilterHeaders="False" ShowColumnTotals="False" />
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="ProductName" ID="fieldProductName"
				Caption="Product" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" FieldName="OrderDate" ID="fieldOrderDate"
				Caption="Year" GroupInterval="DateYear" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="OrderDate" Caption="Quarter"
				GroupInterval="DateQuarter" ID="fieldQuarter" ValueFormat-FormatString="Qtr {0}"
				ValueFormat-FormatType="Numeric" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="ProductAmount" ID="fieldProductAmount"
				Caption="Product Sales" />
		</Fields>
		<OptionsView HorizontalScrollBarMode="Auto" />
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>