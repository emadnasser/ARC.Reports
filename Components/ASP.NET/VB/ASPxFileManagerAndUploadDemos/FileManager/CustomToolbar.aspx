<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomToolbar.aspx.vb" Inherits="FileManager_CustomToolbar" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.dxpc-mainDiv.DetailsPopup
		{
			border-width: 4px;  
		}
		.dxpc-mainDiv.DetailsPopup .dxpc-content
		{
			padding: 0;
		}
		.dxpc-mainDiv.DetailsPopup .dxpc-content > div
		{
			margin: auto;
		}
		.dxpc-mainDiv.DetailsPopup .dxflGroupSys
		{
			padding-top: 12px;
			padding-bottom: 12px;
		}
		.dxpc-mainDiv.DetailsPopup .dxflCaptionCellSys label
		{
			color: #929292;
		}
	</style>
	<%--start highlighted block--%>
	<script>
		function OnCustomCommand(s, e) {
			switch(e.commandName) {
				case "ChangeView-Thumbnails":
					FileManager.PerformCallback("Thumbnails");
					break;
				case "ChangeView-Details":
					FileManager.PerformCallback("Details");
					break;
				case "Properties":
					PopupControl.PerformCallback(FileManager.GetActiveAreaName());
					break;
			}
		}
		function OnToolbarUpdating(s, e) {
			var enabled = (e.activeAreaName == "Folders" || FileManager.GetSelectedItems().length > 0) && e.activeAreaName != "None";
			FileManager.GetToolbarItemByCommandName("Properties").SetEnabled(enabled);
			FileManager.GetContextMenuItemByCommandName("Properties").SetEnabled(enabled);
		}
		function OnPopupEndCallback(s, e) {
			PopupControl.SetHeaderText(PopupControl.cpHeaderText);
			PopupControl.ShowAtElement(FileManager.GetMainElement());
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFileManager ID="FileManager" ClientInstanceName="FileManager" runat="server" OnCustomCallback="ASPxFileManager_CustomCallback" OnItemRenaming="FileManager_ItemRenaming"
		OnItemMoving="FileManager_ItemMoving" OnItemCopying="FileManager_ItemCopying" OnItemDeleting="FileManager_ItemDeleting">
		<ClientSideEvents CustomCommand="OnCustomCommand" ToolbarUpdating="OnToolbarUpdating" />
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~\Thumb\" 
			AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf" />
		<SettingsEditing AllowRename="true" AllowMove="true" AllowCopy="true" AllowDelete="true" />
		<SettingsUpload Enabled="false" />
		<SettingsToolbar>
			<Items>
				<dx:FileManagerToolbarCustomButton CommandName="Properties">
					<Image IconID="setup_properties_16x16" />
				</dx:FileManagerToolbarCustomButton>
				<dx:FileManagerToolbarRefreshButton BeginGroup="false" />
				<dx:FileManagerToolbarCustomButton Text="Thumbnails View" CommandName="ChangeView-Thumbnails" GroupName="ViewMode">
					<Image IconID="grid_cards_16x16" />
				</dx:FileManagerToolbarCustomButton>
				<dx:FileManagerToolbarCustomButton Text="Details View" CommandName="ChangeView-Details" GroupName="ViewMode">
					<Image IconID="grid_grid_16x16" />
				</dx:FileManagerToolbarCustomButton>                                
			</Items>
		</SettingsToolbar>
		<SettingsContextMenu Enabled="true">
			<Items>
				<dx:FileManagerToolbarMoveButton />
				<dx:FileManagerToolbarCopyButton />
				<dx:FileManagerToolbarRenameButton BeginGroup="true" />
				<dx:FileManagerToolbarDeleteButton />
				<dx:FileManagerToolbarRefreshButton BeginGroup="false" />
				<dx:FileManagerToolbarCustomButton Text="Properties" CommandName="Properties" BeginGroup="true">
					<Image IconID="setup_properties_16x16" />
				</dx:FileManagerToolbarCustomButton>
			</Items>
		</SettingsContextMenu>
	</dx:ASPxFileManager>
	<dx:ASPxPopupControl ID="PopupControl" runat="server" ClientInstanceName="PopupControl" OnWindowCallback="PopupControl_WindowCallback" Width="430" 
		ShowHeader="true" ShowFooter="false" PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" AllowDragging="true" DragElement="Header" CssClass="DetailsPopup" CloseOnEscape="true">
		<ClientSideEvents EndCallback="OnPopupEndCallback" />
		<ContentCollection>
			<dx:PopupControlContentControl>
				<dx:ASPxFormLayout ID="FormLayout" runat="server" AlignItemCaptionsInAllGroups="True">
					<Items>
						<dx:LayoutGroup Caption=" " GroupBoxDecoration="None">
							<Items>
								<dx:LayoutItem Caption="Name">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Name" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Type">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Type" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
						<dx:LayoutGroup Caption=" " GroupBoxDecoration="None">
							<Items>
								<dx:LayoutItem Caption="Location">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Location" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Relative Location">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="RelativeLocation" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Size">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Size" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Contains" Name="Contains">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Contains" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
						<dx:LayoutGroup Caption=" " GroupBoxDecoration="None">
							<Items>
								<dx:LayoutItem Caption="Created">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Created" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Modified" Name="Modified">
									<LayoutItemNestedControlCollection >
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Modified" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
								<dx:LayoutItem Caption="Accessed" Name="Accessed">
									<LayoutItemNestedControlCollection>
										<dx:LayoutItemNestedControlContainer>
											<dx:ASPxLabel ID="Accessed" runat="server" />
										</dx:LayoutItemNestedControlContainer>
									</LayoutItemNestedControlCollection>
								</dx:LayoutItem>
							</Items>
						</dx:LayoutGroup>
					</Items>
				</dx:ASPxFormLayout>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxPopupControl>
</asp:Content>