using System;
using System.Web.UI;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Utils;
using DevExpress.Web.Internal;
using DevExpress.Web;

public partial class Features_ContextMenu : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/ContextMenu.html");

            DemoHtmlEditor.Toolbars.Add(CreateDemoToolbar());

            DemoHtmlEditor.ContextMenuItems.CreateDefaultItems();
            DemoHtmlEditor.ContextMenuItems.Insert(0, new HtmlEditorContextMenuItem("Add Title...", "AddTitle"));
            DemoHtmlEditor.ContextMenuItems.Insert(1, new HtmlEditorContextMenuItem("Change Title...", "ChangeTitle"));
            DemoHtmlEditor.ContextMenuItems.Insert(2, new HtmlEditorContextMenuItem("Remove Title", "RemoveTitle"));

            DemoHtmlEditor.ContextMenuItems.ForEach(ProcessContextMenuItem);

            cbContextMenu.Items.FindByValue(DemoHtmlEditor.Settings.AllowContextMenu.ToString()).Selected = true;
        }
        else {
            foreach(ListEditItem item in lbContextMenuItems.Items)
                DemoHtmlEditor.ContextMenuItems[item.Value.ToString()].Visible = item.Selected;

            DefaultBoolean allowContextMenu = (DefaultBoolean)Enum.Parse(typeof(DefaultBoolean), cbContextMenu.Value.ToString());
            DemoHtmlEditor.Settings.AllowContextMenu = allowContextMenu;
            lbContextMenuItems.Enabled = allowContextMenu.Equals(DefaultBoolean.True);
            btnApply.Enabled = allowContextMenu.Equals(DefaultBoolean.True);
        }
    }
    protected void ProcessContextMenuItem(HtmlEditorContextMenuItem contextMenuItem) {
        if(!RenderUtils.Browser.IsIE && (contextMenuItem.CommandName == "cut" || contextMenuItem.CommandName == "copy" || contextMenuItem.CommandName == "paste"))
            return;
        string text = contextMenuItem.Text;
        if(text.Contains("Title"))
            text = string.Format("<b>{0}</b>", text);
        ListEditItem item = new ListEditItem(text, contextMenuItem.CommandName);
        item.Selected = contextMenuItem.Visible;
        lbContextMenuItems.Items.Add(item);
    }

    protected HtmlEditorToolbar CreateDemoToolbar() {
        return new HtmlEditorToolbar("DemoToolbar",
            new ToolbarUndoButton(true),
            new ToolbarRedoButton(),
            new ToolbarBoldButton(true),
            new ToolbarItalicButton(),
            new ToolbarUnderlineButton(),
            new ToolbarStrikethroughButton(),
            new ToolbarInsertLinkDialogButton(true),
            new ToolbarUnlinkButton(),
            new ToolbarInsertImageDialogButton(),
            new ToolbarTableOperationsDropDownButton(true),
            new ToolbarFullscreenButton(true)
        ).CreateDefaultItems();
    }
}
