<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideEvents.aspx.vb" Inherits="API_ClientSideEvents" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CustomTopHeadHolder">
	<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/InitEventMonitor.js")%>"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxSpreadsheet ID="Spreadsheet" Width="100%" ClientInstanceName="Spreadsheet" ShowFormulaBar="false"
		runat="server" ShowConfirmOnLosingChanges="false">
		<RibbonTabs>
			<dx:SRHomeTab>
				<Groups>
					<dx:SRFileCommonGroup>
						<Items>
							<dx:SRFileNewCommand />
							<dx:SRFilePrintCommand />
						</Items>
					</dx:SRFileCommonGroup>
					<dx:SRUndoGroup>
						<Items>
							<dx:SRFileUndoCommand />
							<dx:SRFileRedoCommand />
						</Items>
					</dx:SRUndoGroup>
					<dx:SRViewGroup>
						<Items>
							<dx:SRFullScreenCommand />
						</Items>
					</dx:SRViewGroup>
					<dx:RibbonGroup Name="Custom Ribbon Group" Text="Custom Ribbon Group">
						<Items>
							<dx:RibbonOptionButtonItem Name="CustomOption" OptionGroupName="Group1" Size="Large" Text="Custom option">
								<LargeImage IconID="content_notes_32x32"></LargeImage>
							</dx:RibbonOptionButtonItem>
							<dx:RibbonButtonItem Name="CustomButton" Size="Large" Text="Custom Button">
								<LargeImage IconID="grid_cards_32x32"></LargeImage>
							</dx:RibbonButtonItem>
							<dx:RibbonDropDownButtonItem Size="Large" DropDownMode="false" Text="Custom DropDown Toggle Buttons">
								<LargeImage IconID="setup_properties_32x32">
								</LargeImage>
								<Items>
									<dx:RibbonDropDownToggleButtonItem Name="DropDownToggleButton1" Text="DropDown Toggle Button 1">
									</dx:RibbonDropDownToggleButtonItem>
									<dx:RibbonDropDownToggleButtonItem Name="DropDownToggleButton2" Text="DropDown Toggle Button 2">
									<SmallImage IconID="content_checkbox_16x16"></SmallImage>
									</dx:RibbonDropDownToggleButtonItem>
								</Items>
							</dx:RibbonDropDownButtonItem>
						</Items>
					</dx:RibbonGroup>
				</Groups>
			</dx:SRHomeTab>
		 </RibbonTabs>
		<ClientSideEvents Init="function(s, e) { DXEventMonitor.Trace(s, e, 'Init'); SetDefaultTrackedEvents(); }" SelectionChanged="function(s, e) { DXEventMonitor.Trace(s, e, 'SelectionChanged') }" 
			HyperlinkClick="function(s, e) { DXEventMonitor.Trace(s, e, 'HyperlinkClick'); e.handled = true; }" CustomCommandExecuted="function(s, e) { DXEventMonitor.Trace(s, e, 'CustomCommandExecuted') }" 
			BeginSynchronization="function(s, e) { DXEventMonitor.Trace(s, e, 'BeginSynchronization') }" EndSynchronization="function(s, e) { DXEventMonitor.Trace(s, e, 'EndSynchronization') }" />
	</dx:ASPxSpreadsheet>
	<dx:EventMonitor runat="server" ID="EventMonitor" EventNames="Init SelectionChanged HyperlinkClick CustomCommandExecuted BeginSynchronization EndSynchronization"  EventLogWidth="540" />
</asp:Content>