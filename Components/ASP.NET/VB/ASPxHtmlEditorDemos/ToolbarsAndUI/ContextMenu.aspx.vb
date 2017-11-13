Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Utils
Imports DevExpress.Web.Internal
Imports DevExpress.Web

Partial Public Class Features_ContextMenu
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			HtmlEditorUtils.SetHtml(Me, DemoHtmlEditor, "Features/ContextMenu.html")

			DemoHtmlEditor.Toolbars.Add(CreateDemoToolbar())

			DemoHtmlEditor.ContextMenuItems.CreateDefaultItems()
			DemoHtmlEditor.ContextMenuItems.Insert(0, New HtmlEditorContextMenuItem("Add Title...", "AddTitle"))
			DemoHtmlEditor.ContextMenuItems.Insert(1, New HtmlEditorContextMenuItem("Change Title...", "ChangeTitle"))
			DemoHtmlEditor.ContextMenuItems.Insert(2, New HtmlEditorContextMenuItem("Remove Title", "RemoveTitle"))

			DemoHtmlEditor.ContextMenuItems.ForEach(AddressOf ProcessContextMenuItem)

			cbContextMenu.Items.FindByValue(DemoHtmlEditor.Settings.AllowContextMenu.ToString()).Selected = True
		Else
			For Each item As ListEditItem In lbContextMenuItems.Items
				DemoHtmlEditor.ContextMenuItems(item.Value.ToString()).Visible = item.Selected
			Next item

			Dim allowContextMenu As DefaultBoolean = CType(System.Enum.Parse(GetType(DefaultBoolean), cbContextMenu.Value.ToString()), DefaultBoolean)
			DemoHtmlEditor.Settings.AllowContextMenu = allowContextMenu
			lbContextMenuItems.Enabled = allowContextMenu.Equals(DefaultBoolean.True)
			btnApply.Enabled = allowContextMenu.Equals(DefaultBoolean.True)
		End If
	End Sub
	Protected Sub ProcessContextMenuItem(ByVal contextMenuItem As HtmlEditorContextMenuItem)
		If (Not RenderUtils.Browser.IsIE) AndAlso (contextMenuItem.CommandName = "cut" OrElse contextMenuItem.CommandName = "copy" OrElse contextMenuItem.CommandName = "paste") Then
			Return
		End If
		Dim text As String = contextMenuItem.Text
		If text.Contains("Title") Then
			text = String.Format("<b>{0}</b>", text)
		End If
		Dim item As New ListEditItem(text, contextMenuItem.CommandName)
		item.Selected = contextMenuItem.Visible
		lbContextMenuItems.Items.Add(item)
	End Sub

	Protected Function CreateDemoToolbar() As HtmlEditorToolbar
		Return New HtmlEditorToolbar("DemoToolbar", New ToolbarUndoButton(True), New ToolbarRedoButton(), New ToolbarBoldButton(True), New ToolbarItalicButton(), New ToolbarUnderlineButton(), New ToolbarStrikethroughButton(), New ToolbarInsertLinkDialogButton(True), New ToolbarUnlinkButton(), New ToolbarInsertImageDialogButton(), New ToolbarTableOperationsDropDownButton(True), New ToolbarFullscreenButton(True)).CreateDefaultItems()
	End Function
End Class
