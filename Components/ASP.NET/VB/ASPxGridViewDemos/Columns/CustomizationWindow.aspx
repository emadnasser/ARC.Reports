<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomizationWindow.aspx.vb"
	Inherits="Columns_CustomizationWindow" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function button1_Click(s, e) {
			if(grid.IsCustomizationWindowVisible())
				grid.HideCustomizationWindow();
			else
				grid.ShowCustomizationWindow();
			UpdateButtonText();
		}
		function grid_CustomizationWindowCloseUp(s, e) {
			UpdateButtonText();
		}
		function UpdateButtonText() {
			var text = grid.IsCustomizationWindowVisible() ? "Hide" : "Show";
			text += " Customization Window";
			button1.SetText(text);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxButton runat="server" ID="button1" ClientInstanceName="button1" Text="Show Customization Window"
		UseSubmitBehavior="false" AutoPostBack="false">
		<ClientSideEvents Click="button1_Click" />
	</dx:ASPxButton>
	<br />
	<br />
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource"
		KeyFieldName="CustomerID" Width="100%">
		<Columns>
			<dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="0" />
			<dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="City" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Region" Visible="false" />
			<dx:GridViewDataColumn FieldName="Country" VisibleIndex="3" />
		</Columns>
		<Settings ShowGroupPanel="True" />
		<SettingsLoadingPanel Mode="ShowOnStatusBar" />
		<SettingsBehavior EnableCustomizationWindow="true" />
		<ClientSideEvents CustomizationWindowCloseUp="grid_CustomizationWindowCloseUp" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="NorthwindContext" EntitySetName="Customers" />
</asp:Content>