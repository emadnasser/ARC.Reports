<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Placeholders.aspx.cs" Inherits="Features_Placeholders" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function onButtonClick(s, e) {
            if (!ListBox.GetEnabled()) {
                ShowPreviewResults(true);
                RoundPanel.PerformCallback(ListBox.GetValue());
            }
            else
                ShowPreviewResults(false);
        }
        function onSelectedIndexChanged(s, e) {
            RoundPanel.PerformCallback(s.GetValue());
        }
        function ShowPreviewResults(value) {
            ListBox.SetEnabled(value);
            HtmlEditor.SetVisible(!value);
            RoundPanel.SetVisible(value);
            Button.SetText(value ? "Edit Template" : "Preview Results");
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; padding-right: 20px;">
        <dx:ASPxButton ID="Button" ClientInstanceName="Button" runat="server" AutoPostBack="false" Width="100%" Text="Preview Results">
            <ClientSideEvents Click="onButtonClick" />
        </dx:ASPxButton>
        <br />
        <br />
        <dx:ASPxListBox ID="ListBox" ClientInstanceName="ListBox" runat="server" Height="316px">
            <ClientSideEvents SelectedIndexChanged = "onSelectedIndexChanged" />
        </dx:ASPxListBox>
    </div>
    <div style="float: left;">
        <dx:ASPxHtmlEditor ID="HtmlEditor" ClientInstanceName="HtmlEditor" runat="server" Width="700px" Height="360px">
            <Placeholders>
                <dx:HtmlEditorPlaceholderItem Value="FirstName" />
                <dx:HtmlEditorPlaceholderItem Value="LastName" />
                <dx:HtmlEditorPlaceholderItem Value="Title" />
                <dx:HtmlEditorPlaceholderItem Value="TitleOfCourtesy" />
                <dx:HtmlEditorPlaceholderItem Value="BirthDate" />
                <dx:HtmlEditorPlaceholderItem Value="HireDate" />
                <dx:HtmlEditorPlaceholderItem Value="Address" />
                <dx:HtmlEditorPlaceholderItem Value="City" />
                <dx:HtmlEditorPlaceholderItem Value="Region" />
                <dx:HtmlEditorPlaceholderItem Value="Country" />
                <dx:HtmlEditorPlaceholderItem Value="HomePhone" />
                <dx:HtmlEditorPlaceholderItem Value="Notes" />
                <dx:HtmlEditorPlaceholderItem Value="Photo" />
            </Placeholders>
            <Toolbars>
                <dx:HtmlEditorToolbar Name="StandardToolbar1">
                    <Items>
                        <dx:ToolbarUndoButton BeginGroup="True">
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
                        <dx:ToolbarJustifyLeftButton BeginGroup="True">
                        </dx:ToolbarJustifyLeftButton>
                        <dx:ToolbarJustifyCenterButton>
                        </dx:ToolbarJustifyCenterButton>
                        <dx:ToolbarJustifyRightButton>
                        </dx:ToolbarJustifyRightButton>
                        <dx:ToolbarBackColorButton BeginGroup="True">
                        </dx:ToolbarBackColorButton>
                        <dx:ToolbarFontColorButton>
                        </dx:ToolbarFontColorButton>
                        <dx:ToolbarTableOperationsDropDownButton BeginGroup="True">
                            <Items>
                                <dx:ToolbarInsertTableDialogButton BeginGroup="True">
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
                        <dx:ToolbarInsertPlaceholderDialogButton BeginGroup="True">
                        </dx:ToolbarInsertPlaceholderDialogButton>
                    </Items>
                </dx:HtmlEditorToolbar>
            </Toolbars>
        </dx:ASPxHtmlEditor>
        <dx:ASPxRoundPanel ID="RoundPanel" runat="server" ClientInstanceName="RoundPanel" ClientVisible="false" HeaderText="Document Preview" LoadContentViaCallback="true" OnContentCallback="RoundPanel_ContentCallback" Height="360px" Width="700px">
            <HeaderStyle HorizontalAlign="Center" />
        </dx:ASPxRoundPanel>
    </div>
</asp:Content>
