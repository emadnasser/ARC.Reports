<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WorksheetProtection.aspx.vb" Inherits="Features_WorksheetProtection" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
	<script type="text/javascript">
		function ApplyProtectionSettings() {
			CallbackPanel.PerformCallback();
		}
	</script>
	<style type="text/css">
		.optionsList {
			border-style: none;
		}
	</style>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxCallbackPanel runat="server" ID="CallbackPanel" ClientInstanceName="CallbackPanel" OnCallback="CallbackPanel_Callback">
		<PanelCollection>
			<dx:PanelContent>
				<dx:ASPxCheckBoxList runat="server" ID="ProtectionOptionsList"  RepeatColumns="4" 
					RepeatLayout="Table" RepeatDirection="Vertical" CssClass="optionsList" 
					Caption="Actions allowed in the protected worksheet:" Width="100%">
					<CaptionSettings position="Top" />
					<ClientSideEvents SelectedIndexChanged="function (s, e) { ApplyProtectionSettings(); }" />
					<Items>
						<dx:ListEditItem Value="FormatCells" Text="Format cells" />
						<dx:ListEditItem Value="FormatColumns" Text="Format columns" />
						<dx:ListEditItem Value="FormatRows" Text="Format rows" />
						<dx:ListEditItem Value="InsertColumns" Text="Insert columns" />
						<dx:ListEditItem Value="InsertRows" Text="Insert rows" />
						<dx:ListEditItem Value="InsertHyperlinks" Text="Insert hyperlinks" />
						<dx:ListEditItem Value="DeleteColumns" Text="Delete columns" />
						<dx:ListEditItem Value="DeleteRows" Text="Delete rows" />
						<dx:ListEditItem Value="Sort" Text="Sort" />
						<dx:ListEditItem Value="AutoFilters" Text="Use AutoFilter" />
						<dx:ListEditItem Value="Objects" Text="Edit objects" />
					</Items>
				</dx:ASPxCheckBoxList>
				<dx:ASPxSpreadsheet ID="Spreadsheet" ClientInstanceName="Spreadsheet" Width="100%" Height="700px" runat="server" ActiveTabIndex="0" 
					ShowConfirmOnLosingChanges="false">   
				</dx:ASPxSpreadsheet>
			</dx:PanelContent>
		</PanelCollection>
	</dx:ASPxCallbackPanel>
</asp:Content>