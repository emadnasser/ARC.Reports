<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ContextMenu.aspx.vb" Inherits="Columns_ContextMenu" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnContextMenuItemClick(sender,args) {
			if(args.item.name == "ExportToPDF" || args.item.name == "ExportToXLS") {
				args.processOnServer = true;
				args.usePostBack = true;
			} else if(args.item.name == "SumSelected")
				args.processOnServer = true;
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content runat="Server" ID="Content1" ContentPlaceHolderID="ContentHolder">
	<dx:ASPxGridView runat="server" ID="Grid" ClientInstanceName="Grid" Width="100%" EnableRowsCache="false" DataSourceID="DemoDataSource1" KeyFieldName="ProductID"
		OnFillContextMenuItems="Grid_FillContextMenuItems"
		OnAddSummaryItemViaContextMenu="Grid_AddSummaryItemViaContextMenu"
		OnContextMenuItemClick="Grid_ContextMenuItemClick"
		OnCustomSummaryCalculate="Grid_CustomSummaryCalculate">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="ProductName" />
			<dx:GridViewDataComboBoxColumn FieldName="CategoryID" Caption="Category Name" GroupIndex="0" SortOrder="Descending">
				<PropertiesComboBox DataSourceID="CategoriesDataSource" ValueType="System.Int32"
					ValueField="CategoryID" TextField="CategoryName" />
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataTextColumn FieldName="QuantityPerUnit" />
			<dx:GridViewDataSpinEditColumn FieldName="UnitPrice">
				<PropertiesSpinEdit DisplayFormatString="c" DisplayFormatInEditMode="true" MinValue="0" MaxValue="60000" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataSpinEditColumn FieldName="UnitsInStock">
				<PropertiesSpinEdit MinValue="0" MaxValue="10000" />
			</dx:GridViewDataSpinEditColumn>
			<dx:GridViewDataCheckColumn FieldName="Discontinued">
				<PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
			</dx:GridViewDataCheckColumn>
		</Columns>
		<SettingsBehavior ConfirmDelete="true" EnableCustomizationWindow="true" EnableRowHotTrack="true" />
		<Settings ShowFooter="true" ShowGroupPanel="true" ShowGroupFooter="VisibleIfExpanded" />
		<SettingsEditing Mode="EditForm" />
		<SettingsContextMenu Enabled="true" />
		<ClientSideEvents ContextMenuItemClick="function(s,e) { OnContextMenuItemClick(s, e); }" />
		<TotalSummary>
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Sum" />
		</TotalSummary>
		<GroupSummary>
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Sum" ShowInGroupFooterColumn="UnitPrice" />
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Min" />
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Max" />
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Count" Visible="false" />
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Average" Visible="false" />
			<dx:ASPxSummaryItem FieldName="UnitPrice" SummaryType="Sum" Visible="false" />
		</GroupSummary>
	</dx:ASPxGridView>
	<dx:ASPxGridViewExporter runat="server" ID="GridExporter" GridViewID="Grid" />
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="ProductID" DataSourceID="ProductsDataSource" IsSiteMode="True"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="ProductsDataSource" ContextTypeName="NorthwindContext" EntitySetName="Products" EnableDelete="true" EnableInsert="true" EnableUpdate="true" />
	<ef:EntityDataSource runat="server" ID="CategoriesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Categories" />
</asp:Content>