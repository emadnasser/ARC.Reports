<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShowHeaders.aspx.vb"
	Inherits="Appearance_ShowHeaders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td>
				<dx:ASPxCheckBox ID="cbShowFilterHeaders" runat="server" AutoPostBack="true" Text="Show Filter Headers" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowDataHeaders" runat="server" AutoPostBack="true" Text="Show Data Headers" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxCheckBox ID="cbShowColumnHeaders" runat="server" AutoPostBack="true" Text="Show Column Headers" />
			</td>
			<td>
				<dx:ASPxCheckBox ID="cbShowRowHeaders" runat="server" AutoPostBack="true" Text="Show Row Headers" />
			</td>
		</tr>
	</table>
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" CssClass="dxpgControl" DataSourceID="CustomerReportsDataSource"
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
		<OptionsFilter NativeCheckBoxes="False" />
		<OptionsLoadingPanel Text="Loading&amp;hellip;" />
	</dx:ASPxPivotGrid>
	<ef:EntityDataSource ID="CustomerReportsDataSource" runat="server" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>