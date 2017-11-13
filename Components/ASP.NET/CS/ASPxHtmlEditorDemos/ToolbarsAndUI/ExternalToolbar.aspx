<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ExternalToolbar.aspx.cs" Inherits="Features_ExternalToolbar" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var MaxLength = 2200;
        var ConfirmMessage = "Are you sure you want to perform the action? Unsaved html content will be lost.";
        var CustomErrorText = "Custom validation fails because the HTML content's length exceeds " + MaxLength.toString() + " characters. The current length of characters: ";
        var CurrentDocumentIndex = -1;
        function IsHtmlChanged() {
            return Ribbon.GetItemByName('SaveChanges').GetEnabled();
        }
        function UpdateRibbonItems() {
            Ribbon.GetItemByName("PreviousDocument").SetEnabled(ListBox.GetSelectedIndex() > 0);
            Ribbon.GetItemByName("NextDocument").SetEnabled(ListBox.GetSelectedIndex() != (ListBox.GetItemCount() - 1));
        }
        function SetEditingCommandEnabled(enabled) {
            Ribbon.GetItemByName('SaveChanges').SetEnabled(enabled);
            Ribbon.GetItemByName('CancelChanges').SetEnabled(enabled);
        }
        function LoadHtmlContent(htmlEditor, result) {
            if(result != null)
                htmlEditor.SetHtml(result);
            SetEditingCommandEnabled(false);
        }
        function CommandExecutedHandler(s, e) {
            var isHtmlChanged = IsHtmlChanged();
            switch (e.item.name) {
                case "PreviousDocument":
                    if(isHtmlChanged && !confirm(ConfirmMessage))
                        return;
                    ListBox.SelectIndex(ListBox.GetSelectedIndex() - 1);
                    break;
                case "NextDocument":
                    if(isHtmlChanged && !confirm(ConfirmMessage))
                        return;
                    ListBox.SelectIndex(ListBox.GetSelectedIndex() + 1);
                    break;
                case "SaveChanges":
                    HtmlEditor.Validate();
                    if(!HtmlEditor.GetIsValid())
                        return;
                    SetEditingCommandEnabled(false);
                    HtmlEditor.PerformDataCallback(e.item.name);
                    break;
                case "CancelChanges":
                    HtmlEditor.PerformDataCallback(e.item.name, LoadHtmlContent);
                    break;
            }
            if(!HtmlEditor.GetIsValid())
                HtmlEditor.SetIsValid(true)
            UpdateRibbonItems();
        }
        function ValidationHandler(s, e) {
            if(e.html.length > MaxLength) {
                e.isValid = false;
                e.errorText = CustomErrorText + e.html.length;
            }
        }
        function HtmlEditorInitHandler(s, e) {
            ASPxClientUtils.AttachEventToElement(window, "beforeunload", function(e) {
                if(!IsHtmlChanged() || CurrentDocumentIndex == -1)
                    return;
                e.returnValue = ConfirmMessage;
                return ConfirmMessage;
            });
            UpdateRibbonItems();
            SetEditingCommandEnabled(false);
            CurrentDocumentIndex = ListBox.GetSelectedIndex();
        }
        function HtmlChangedHandler(s, e) {
            if(!s.InCallback())
                SetEditingCommandEnabled(true);
        }
        function SelectedIndexChangedHandler(s, e) {
            if(IsHtmlChanged() && CurrentDocumentIndex != e.index && !confirm(ConfirmMessage))
                s.SetSelectedIndex(CurrentDocumentIndex);
            else {
                CurrentDocumentIndex = e.index;
                HtmlEditor.PerformDataCallback('CancelChanges', LoadHtmlContent);
                UpdateRibbonItems();
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRibbon ID="Ribbon" runat="server" ClientInstanceName="Ribbon" ShowFileTab="false" Width="917px">
        <Tabs>
            <dx:HEHomeRibbonTab>
                <Groups>
                    <dx:RibbonGroup Name="Editing" Text="Editing">
                        <Items>
                            <dx:RibbonButtonItem Name="SaveChanges" Size="Large" Text="Save Changes">
                                <SmallImage AlternateText="Save changes" IconID="save_save_16x16" />
                                <LargeImage AlternateText="Save changes" IconID="save_save_32x32" />
                            </dx:RibbonButtonItem>
                            <dx:RibbonButtonItem Name="CancelChanges" Size="Large" Text="Cancel Changes">
                                <SmallImage AlternateText="Cancel changes" IconID="actions_cancel_16x16" />
                                <LargeImage AlternateText="Cancel changes" IconID="actions_cancel_32x32" />
                            </dx:RibbonButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                    <dx:HEUndoRibbonGroup>
                        <Items>
                            <dx:HEUndoRibbonCommand Size="Large">
                            </dx:HEUndoRibbonCommand>
                            <dx:HERedoRibbonCommand Size="Large">
                            </dx:HERedoRibbonCommand>
                        </Items>
                    </dx:HEUndoRibbonGroup>
                    <dx:HEFontRibbonGroup>
                        <Items>
                            <dx:HEFontNameRibbonCommand>
                                <Items>
                                    <dx:ListEditItem Text="Times New Roman" Value="Times New Roman" />
                                    <dx:ListEditItem Text="Tahoma" Value="Tahoma" />
                                    <dx:ListEditItem Text="Verdana" Value="Verdana" />
                                    <dx:ListEditItem Text="Arial" Value="Arial" />
                                    <dx:ListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                    <dx:ListEditItem Text="Courier" Value="Courier" />
                                </Items>
                            </dx:HEFontNameRibbonCommand>
                            <dx:HEFontSizeRibbonCommand>
                                <Items>
                                    <dx:ListEditItem Text="1 (8pt)" Value="1" />
                                    <dx:ListEditItem Text="2 (10pt)" Value="2" />
                                    <dx:ListEditItem Text="3 (12pt)" Value="3" />
                                    <dx:ListEditItem Text="4 (14pt)" Value="4" />
                                    <dx:ListEditItem Text="5 (18pt)" Value="5" />
                                    <dx:ListEditItem Text="6 (24pt)" Value="6" />
                                    <dx:ListEditItem Text="7 (36pt)" Value="7" />
                                </Items>
                            </dx:HEFontSizeRibbonCommand>
                            <dx:HERemoveFormatRibbonCommand>
                            </dx:HERemoveFormatRibbonCommand>
                            <dx:HEParagraphFormattingRibbonCommand>
                                <Items>
                                    <dx:ListEditItem Text="Normal" Value="p" />
                                    <dx:ListEditItem Text="Heading  1" Value="h1" />
                                    <dx:ListEditItem Text="Heading  2" Value="h2" />
                                    <dx:ListEditItem Text="Heading  3" Value="h3" />
                                    <dx:ListEditItem Text="Heading  4" Value="h4" />
                                    <dx:ListEditItem Text="Heading  5" Value="h5" />
                                    <dx:ListEditItem Text="Heading  6" Value="h6" />
                                    <dx:ListEditItem Text="Address" Value="address" />
                                    <dx:ListEditItem Text="Normal (DIV)" Value="div" />
                                </Items>
                            </dx:HEParagraphFormattingRibbonCommand>
                            <dx:HEBoldRibbonCommand>
                            </dx:HEBoldRibbonCommand>
                            <dx:HEItalicRibbonCommand>
                            </dx:HEItalicRibbonCommand>
                            <dx:HEUnderlineRibbonCommand>
                            </dx:HEUnderlineRibbonCommand>
                            <dx:HEStrikeoutRibbonCommand>
                            </dx:HEStrikeoutRibbonCommand>
                            <dx:HESuperscriptRibbonCommand>
                            </dx:HESuperscriptRibbonCommand>
                            <dx:HESubscriptRibbonCommand>
                            </dx:HESubscriptRibbonCommand>
                        </Items>
                    </dx:HEFontRibbonGroup>
                    <dx:HEParagraphRibbonGroup>
                        <Items>
                            <dx:HEInsertUnorderedListRibbonCommand>
                            </dx:HEInsertUnorderedListRibbonCommand>
                            <dx:HEInsertOrderedListRibbonCommand>
                            </dx:HEInsertOrderedListRibbonCommand>
                            <dx:HEOutdentRibbonCommand>
                            </dx:HEOutdentRibbonCommand>
                            <dx:HEIndentRibbonCommand>
                            </dx:HEIndentRibbonCommand>
                            <dx:HEAlignmentLeftRibbonCommand>
                            </dx:HEAlignmentLeftRibbonCommand>
                            <dx:HEAlignmentCenterRibbonCommand>
                            </dx:HEAlignmentCenterRibbonCommand>
                            <dx:HEAlignmentRightRibbonCommand>
                            </dx:HEAlignmentRightRibbonCommand>
                        </Items>
                    </dx:HEParagraphRibbonGroup>
                    <dx:RibbonGroup Name="Navigation" Text="Navigation">
                        <Items>
                            <dx:RibbonButtonItem Name="PreviousDocument" Size="Large" Text="Previous Document">
                                <SmallImage AlternateText="Previous Document" IconID="navigation_previous_16x16" />
                                <LargeImage AlternateText="Previous Document" IconID="navigation_previous_32x32" />
                            </dx:RibbonButtonItem>
                            <dx:RibbonButtonItem Name="NextDocument" Size="Large" Text="Next Document">
                                <SmallImage AlternateText="Next Document" IconID="navigation_next_16x16" />
                                <LargeImage AlternateText="Next Document" IconID="navigation_next_32x32" />
                            </dx:RibbonButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                </Groups>
            </dx:HEHomeRibbonTab>
            <dx:HEInsertRibbonTab>
                <Groups>
                    <dx:HEImagesRibbonGroup>
                        <Items>
                            <dx:HEInsertImageRibbonCommand Size="Large">
                            </dx:HEInsertImageRibbonCommand>
                        </Items>
                    </dx:HEImagesRibbonGroup>
                    <dx:HELinksRibbonGroup>
                        <Items>
                            <dx:HEInsertLinkDialogRibbonCommand Size="Large">
                            </dx:HEInsertLinkDialogRibbonCommand>
                            <dx:HEUnlinkRibbonCommand Size="Large">
                            </dx:HEUnlinkRibbonCommand>
                        </Items>
                    </dx:HELinksRibbonGroup>
                </Groups>
            </dx:HEInsertRibbonTab>
            <dx:HEViewRibbonTab>
                <Groups>
                    <dx:HEViewsRibbonGroup>
                        <Items>
                            <dx:HEFullscreenRibbonCommand Size="Large">
                            </dx:HEFullscreenRibbonCommand>
                        </Items>
                    </dx:HEViewsRibbonGroup>
                </Groups>
            </dx:HEViewRibbonTab>
        </Tabs>
        <ClientSideEvents CommandExecuted="CommandExecutedHandler" />
    </dx:ASPxRibbon>
    <br />
    <div style="float: left; padding-right: 20px;">
        <dx:ASPxListBox ID="ListBox" runat="server" ClientInstanceName="ListBox"
            Width="146px" Height="370px">
            <ClientSideEvents SelectedIndexChanged = "SelectedIndexChangedHandler" />
        </dx:ASPxListBox>
    </div>
    <div style="float: left;">
        <dx:ASPxHtmlEditor ID="HtmlEditor" runat="server" OnCustomDataCallback="HtmlEditor_CustomDataCallback"
            Width="750px" Height="370px" ToolbarMode="ExternalRibbon" ClientInstanceName="HtmlEditor"
            AssociatedRibbonID="Ribbon">
            <SettingsDialogs>
                <InsertImageDialog>
                    <SettingsImageUpload UploadFolder="~/UploadFiles/Images/">
                        <ValidationSettings AllowedFileExtensions=".jpe,.jpeg,.jpg,.gif,.png" MaxFileSize="500000" />
                    </SettingsImageUpload>
                </InsertImageDialog>
            </SettingsDialogs>
            <SettingsLoadingPanel Enabled="false" />
            <ClientSideEvents
                Init = "HtmlEditorInitHandler"
                HtmlChanged = "HtmlChangedHandler"
                Validation = "ValidationHandler"
                BeginCallback = "function(s, e) { LoadingPanel.Show(); }"
                EndCallback = "function(s, e) { LoadingPanel.Hide(); }"
            />
        </dx:ASPxHtmlEditor>
    </div>
    <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Modal="True">
    </dx:ASPxLoadingPanel>
</asp:Content>
