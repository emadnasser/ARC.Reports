<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Drilldown.aspx.vb"
	Inherits="Features_Click" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<script type="text/javascript">
		function ShowDrillDown() {
			var mainElement = PivotGrid.GetMainElement();
			DrillDownWindow.ShowAtPos(ASPxClientUtils.GetAbsoluteX(mainElement), ASPxClientUtils.GetAbsoluteY(mainElement));
		}
	</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" runat="Server">
	<input runat="server" id="ColumnIndex" type="hidden" enableviewstate="true" />
	<input runat="server" id="RowIndex" type="hidden" enableviewstate="true" />
	<p>
		Click on the Cell to Get the Drill Down Result.
	</p>
	<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientInstanceName="PivotGrid"
		DataSourceID="CustomerReportsDataSource" Width="100%">
		<Styles>
			<CellStyle Cursor="pointer" />
		</Styles>
		<Fields>
			<dx:PivotGridField Area="RowArea" AreaIndex="0" Caption="Customer" FieldName="CompanyName"
				ID="fieldCompanyName" />
			<dx:PivotGridField Area="ColumnArea" AreaIndex="0" Caption="Year" FieldName="OrderDate"
				ID="fieldOrderDate" GroupInterval="DateYear" UnboundFieldName="UnboundColumn1" />
			<dx:PivotGridField Area="DataArea" AreaIndex="0" Caption="Product Amount" FieldName="ProductAmount"
				ID="fieldProductAmount" />
			<dx:PivotGridField Area="RowArea" AreaIndex="1" Caption="Products" FieldName="ProductName"
				ID="fieldProductName" />
		</Fields>
		<OptionsView ShowFilterHeaders="False" HorizontalScrollBarMode="Auto"/>
		<OptionsFilter NativeCheckBoxes="False" />
	</dx:ASPxPivotGrid>
	<dx:ASPxPopupControl ID="ASPxPopupControl1" Modal="true" runat="server" Height="1px"
		AllowDragging="True" ClientInstanceName="DrillDownWindow" Left="200" Top="200"
		CloseAction="CloseButton" Width="153px" HeaderText="Drill Down Window">
		<ContentCollection>
			<dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
				<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" ClientInstanceName="GridView"
					OnCustomCallback="ASPxGridView1_CustomCallback">
					<ClientSideEvents EndCallback="function(s, e) { 
							if( s.cpShowDrillDownWindow )
								GridView.SetVisible(true);
						}" />
					<Columns>
						<dx:GridViewDataTextColumn Caption="Product Name" FieldName="ProductName" VisibleIndex="0" />
						<dx:GridViewDataTextColumn Caption="Company Name" FieldName="CompanyName" VisibleIndex="1" />
						<dx:GridViewDataDateColumn Caption="Order Date" FieldName="OrderDate" VisibleIndex="2" />
						<dx:GridViewDataTextColumn Caption="Product Amount" FieldName="ProductAmount" VisibleIndex="3">
							<PropertiesTextEdit DisplayFormatString="{0:C}" />
						</dx:GridViewDataTextColumn>
						<dx:GridViewDataTextColumn Caption="Year" FieldName="UnboundColumn1" VisibleIndex="4" />
					</Columns>
					<SettingsLoadingPanel Mode="ShowOnStatusBar" />
					<Styles>
						<Header ImageSpacing="5px" SortingImageSpacing="5px" />
					</Styles>
				</dx:ASPxGridView>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxPopupControl>
	<ef:EntityDataSource runat="server" ID="CustomerReportsDataSource" ContextTypeName="NorthwindContext" EntitySetName="CustomerReports" />
</asp:Content>