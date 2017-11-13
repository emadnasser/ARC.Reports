<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="FindAndReplace.aspx.vb" Inherits="Features_FindAndReplace" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server">
		<Toolbars>
				<dx:HtmlEditorToolbar Name="Toolbar">
					<Items>
						<dx:ToolbarUndoButton>
						</dx:ToolbarUndoButton>
						<dx:ToolbarRedoButton>
						</dx:ToolbarRedoButton>
						<dx:ToolbarBoldButton BeginGroup="True">
						</dx:ToolbarBoldButton>
						<dx:ToolbarItalicButton>
						</dx:ToolbarItalicButton>
						<dx:ToolbarUnderlineButton>
						</dx:ToolbarUnderlineButton>
						<dx:ToolbarStrikethroughButton>
						</dx:ToolbarStrikethroughButton>
						<dx:ToolbarFindAndReplaceDialogButton BeginGroup="true">
						</dx:ToolbarFindAndReplaceDialogButton>
						<dx:ToolbarFullscreenButton BeginGroup="true">
						</dx:ToolbarFullscreenButton>
					</Items>
				</dx:HtmlEditorToolbar>
			</Toolbars>
	</dx:ASPxHtmlEditor>
</asp:Content>