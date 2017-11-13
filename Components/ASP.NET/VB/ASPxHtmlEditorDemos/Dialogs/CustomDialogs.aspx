<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDialogs.aspx.vb"
	Inherits="Dialogs_CustomDialogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<script type="text/javascript" src="../Scripts/InsertTemplateForm.js"></script>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" ClientInstanceName="HtmlEditor">
		<CustomDialogs>
			<dx:HtmlEditorCustomDialog Caption="Insert Template" Name="InsertTemplate" FormPath="InsertTemplateForm.ascx">
			</dx:HtmlEditorCustomDialog>
		</CustomDialogs>
		<ClientSideEvents CustomDialogOpened="OnCustomDialogOpened" CustomDialogClosed="OnCustomDialogClosed"
			CustomDialogClosing="OnCustomDialogClosing" />
		<Toolbars>
			<dx:HtmlEditorToolbar Caption="DemoToolbar" Name="DemoToolbar">
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarJustifyLeftButton BeginGroup="True">
					</dx:ToolbarJustifyLeftButton>
					<dx:ToolbarJustifyCenterButton>
					</dx:ToolbarJustifyCenterButton>
					<dx:ToolbarJustifyRightButton>
					</dx:ToolbarJustifyRightButton>
					<dx:ToolbarJustifyFullButton>
					</dx:ToolbarJustifyFullButton>
					<dx:ToolbarCustomDialogButton Name="InsertTemplate" BeginGroup="True" ToolTip="Insert Template (Ctrl+Shift+I)">
						<Image Url="~/Content/Demo/Toolbar/template.png">
						</Image>
					</dx:ToolbarCustomDialogButton>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
		<Shortcuts>
			<dx:HtmlEditorShortcut ActionName="InsertTemplate" ActionType="ShowCustomDialog" Shortcut="Ctrl+Shift+I" />
		</Shortcuts>
	</dx:ASPxHtmlEditor>
</asp:Content>