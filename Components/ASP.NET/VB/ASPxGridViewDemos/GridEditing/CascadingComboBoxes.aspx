<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CascadingComboBoxes.aspx.vb"
	Inherits="GridEditing_CascadingComboBoxes" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		var lastCountry = null;
		function OnCountryChanged(cmbCountry) {
			if (grid.GetEditor("City").InCallback() )
				lastCountry = cmbCountry.GetValue().toString();
			else            
				grid.GetEditor("City").PerformCallback(cmbCountry.GetValue().toString());
		}
		function OnEndCallback(s,e){
			if (lastCountry){
				grid.GetEditor("City").PerformCallback(lastCountry);
				lastCountry = null;
			}
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1"
		KeyFieldName="CustomerID" Width="100%" AutoGenerateColumns="False" OnCellEditorInitialize="grid_CellEditorInitialize">
		<Settings ShowGroupPanel="True" />
		<SettingsEditing Mode="Inline" />
		<Columns>
			<dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
			<dx:GridViewDataComboBoxColumn FieldName="Country" VisibleIndex="1" Width="150">
				<PropertiesComboBox TextField="CountryName" ValueField="CountryName" EnableSynchronization="False"
					IncrementalFilteringMode="StartsWith" DataSourceID="CountriesDataSource">
					<ClientSideEvents SelectedIndexChanged="function(s, e) { OnCountryChanged(s); }"></ClientSideEvents>
				</PropertiesComboBox>
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataComboBoxColumn FieldName="City" VisibleIndex="2" Width="150">
				<PropertiesComboBox EnableSynchronization="False" IncrementalFilteringMode="StartsWith" >
					<ClientSideEvents  EndCallback="OnEndCallback"/>
				</PropertiesComboBox>
			</dx:GridViewDataComboBoxColumn>
			<dx:GridViewDataColumn VisibleIndex="3" FieldName="ContactName">
			</dx:GridViewDataColumn>
			<dx:GridViewDataColumn VisibleIndex="4" FieldName="CompanyName">
			</dx:GridViewDataColumn>
		</Columns>
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="CustomersDataSource"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource"
		ContextTypeName="NorthwindContext"
		EnableDelete="True" EnableInsert="True" EnableUpdate="True"
		EntitySetName="Customers">
	</ef:EntityDataSource>
	<ef:EntityDataSource ID="CountriesDataSource" runat="server" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName"></ef:EntityDataSource>
</asp:Content>