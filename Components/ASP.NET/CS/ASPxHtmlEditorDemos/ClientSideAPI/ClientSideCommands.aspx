<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSideCommands.aspx.cs"
    Inherits="ClientSideAPI_ClientSideCommands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
    // <![CDATA[
        var MailMessageTemplate = '<p>Hi,</p><p>Thanks, <br/>Serge<br/><br/>R&amp;D, ASP.Net Team<br/>Developer Express Inc.<br/><br/>PS. If you wish to receive direct assistance from our Support Team, use Support Center at <a target="_blank" href="http://www.devexpress.com/Support/Center">http://www.devexpress.com/Support/Center</a></p>';
        function PasteEmailTemplate(commandName) {
            switch(commandName) {
                case ('deleteall'):
                    HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.SELECT_ALL, null);
                    HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.PASTEHTML_COMMAND, '&nbsp;');
                    break;
                case ('pastetemplate'):
                    HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.SELECT_ALL, null);
                    HtmlEditor.ExecuteCommand(ASPxClientCommandConsts.PASTEHTML_COMMAND, MailMessageTemplate);
                    break;
            }
        }
    // ]]> 
    </script>
    <%--end highlighted block--%>
    <dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="300px" Width="657px"
        ClientInstanceName="HtmlEditor">
        <SettingsDialogs>
            <InsertImageDialog>
                <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                    <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000">
                    </ValidationSettings>
                </SettingsImageUpload>
            </InsertImageDialog>
        </SettingsDialogs>
        <Toolbars>
            <dx:HtmlEditorToolbar>
                <Items>
                    <dx:ToolbarCutButton>
                    </dx:ToolbarCutButton>
                    <dx:ToolbarCopyButton>
                    </dx:ToolbarCopyButton>
                    <dx:ToolbarPasteButton>
                    </dx:ToolbarPasteButton>
                    <dx:ToolbarUndoButton BeginGroup="True">
                    </dx:ToolbarUndoButton>
                    <dx:ToolbarRedoButton>
                    </dx:ToolbarRedoButton>
                    <dx:ToolbarRemoveFormatButton BeginGroup="True">
                    </dx:ToolbarRemoveFormatButton>
                    <dx:ToolbarSuperscriptButton BeginGroup="True">
                    </dx:ToolbarSuperscriptButton>
                    <dx:ToolbarSubscriptButton>
                    </dx:ToolbarSubscriptButton>
                    <dx:ToolbarIndentButton BeginGroup="True">
                    </dx:ToolbarIndentButton>
                    <dx:ToolbarOutdentButton>
                    </dx:ToolbarOutdentButton>
                    <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                    </dx:ToolbarInsertLinkDialogButton>
                    <dx:ToolbarUnlinkButton>
                    </dx:ToolbarUnlinkButton>
                    <dx:ToolbarInsertImageDialogButton>
                    </dx:ToolbarInsertImageDialogButton>
                    <dx:ToolbarTableOperationsDropDownButton BeginGroup="True">
                        <Items>
                            <dx:ToolbarInsertTableDialogButton BeginGroup="True" ViewStyle="ImageAndText">
                            </dx:ToolbarInsertTableDialogButton>
                            <dx:ToolbarTablePropertiesDialogButton BeginGroup="True">
                            </dx:ToolbarTablePropertiesDialogButton>
                            <dx:ToolbarTableRowPropertiesDialogButton>
                            </dx:ToolbarTableRowPropertiesDialogButton>
                            <dx:ToolbarTableColumnPropertiesDialogButton>
                            </dx:ToolbarTableColumnPropertiesDialogButton>
                            <dx:ToolbarTableCellPropertiesDialogButton>
                            </dx:ToolbarTableCellPropertiesDialogButton>
                            <dx:ToolbarInsertTableRowAboveButton BeginGroup="True">
                            </dx:ToolbarInsertTableRowAboveButton>
                            <dx:ToolbarInsertTableRowBelowButton>
                            </dx:ToolbarInsertTableRowBelowButton>
                            <dx:ToolbarInsertTableColumnToLeftButton>
                            </dx:ToolbarInsertTableColumnToLeftButton>
                            <dx:ToolbarInsertTableColumnToRightButton>
                            </dx:ToolbarInsertTableColumnToRightButton>
                            <dx:ToolbarSplitTableCellHorizontallyButton BeginGroup="True">
                            </dx:ToolbarSplitTableCellHorizontallyButton>
                            <dx:ToolbarSplitTableCellVerticallyButton>
                            </dx:ToolbarSplitTableCellVerticallyButton>
                            <dx:ToolbarMergeTableCellRightButton>
                            </dx:ToolbarMergeTableCellRightButton>
                            <dx:ToolbarMergeTableCellDownButton>
                            </dx:ToolbarMergeTableCellDownButton>
                            <dx:ToolbarDeleteTableButton BeginGroup="True">
                            </dx:ToolbarDeleteTableButton>
                            <dx:ToolbarDeleteTableRowButton>
                            </dx:ToolbarDeleteTableRowButton>
                            <dx:ToolbarDeleteTableColumnButton>
                            </dx:ToolbarDeleteTableColumnButton>
                        </Items>
                    </dx:ToolbarTableOperationsDropDownButton>
                </Items>
            </dx:HtmlEditorToolbar>
            <dx:HtmlEditorToolbar>
                <Items>
                    <dx:ToolbarFontNameEdit>
                        <Items>
                            <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="Verdana" Value="Verdana"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="Arial" Value="Arial"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="Courier" Value="Courier"></dx:ToolbarListEditItem>
                        </Items>
                    </dx:ToolbarFontNameEdit>
                    <dx:ToolbarFontSizeEdit>
                        <Items>
                            <dx:ToolbarListEditItem Text="1 (8pt)" Value="1"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="2 (10pt)" Value="2"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="3 (12pt)" Value="3"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="4 (14pt)" Value="4"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="5 (18pt)" Value="5"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="6 (24pt)" Value="6"></dx:ToolbarListEditItem>
                            <dx:ToolbarListEditItem Text="7 (36pt)" Value="7"></dx:ToolbarListEditItem>
                        </Items>
                    </dx:ToolbarFontSizeEdit>
                    <dx:ToolbarBoldButton BeginGroup="True">
                    </dx:ToolbarBoldButton>
                    <dx:ToolbarItalicButton>
                    </dx:ToolbarItalicButton>
                    <dx:ToolbarUnderlineButton>
                    </dx:ToolbarUnderlineButton>
                    <dx:ToolbarStrikethroughButton>
                    </dx:ToolbarStrikethroughButton>
                    <dx:ToolbarJustifyLeftButton BeginGroup="True">
                    </dx:ToolbarJustifyLeftButton>
                    <dx:ToolbarJustifyCenterButton>
                    </dx:ToolbarJustifyCenterButton>
                    <dx:ToolbarJustifyRightButton>
                    </dx:ToolbarJustifyRightButton>
                    <dx:ToolbarJustifyFullButton>
                    </dx:ToolbarJustifyFullButton>
                    <dx:ToolbarBackColorButton Text="BackColor" ToolTip="Back Color">
                    </dx:ToolbarBackColorButton>
                    <dx:ToolbarFontColorButton Text="ForeColor" ToolTip="Fore Color">
                    </dx:ToolbarFontColorButton>
                </Items>
            </dx:HtmlEditorToolbar>
            <dx:HtmlEditorToolbar>
                <Items>
                    <dx:CustomToolbarButton CommandName="pastetemplate" Text="Paste Template" ToolTip="Paste mail message template (Ctrl+Shift+I)"
                        BeginGroup="true">
                    </dx:CustomToolbarButton>
                    <dx:CustomToolbarButton CommandName="deleteall" Text="Delete All" ToolTip="Delete all (Ctrl+Shift+D)">
                    </dx:CustomToolbarButton>
                </Items>
            </dx:HtmlEditorToolbar>
        </Toolbars>
        <Shortcuts>
            <dx:HtmlEditorShortcut ActionName="pastetemplate" ActionType="ExecuteCommand" Shortcut="Ctrl+Shift+I" />
            <dx:HtmlEditorShortcut ActionName="deleteall" ActionType="ExecuteCommand" Shortcut="Ctrl+Shift+D" />
        </Shortcuts>
        <ClientSideEvents CustomCommand="function(s, e) { PasteEmailTemplate(e.commandName); }">
        </ClientSideEvents>
    </dx:ASPxHtmlEditor>
</asp:Content>
