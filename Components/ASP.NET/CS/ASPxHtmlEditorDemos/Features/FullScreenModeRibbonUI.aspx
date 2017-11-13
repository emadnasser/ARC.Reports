<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FullScreenModeRibbonUI.aspx.cs" Inherits="Features_FullScreenModeRibbonUI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Html Editor Ribbon UI</title>
    <link type="text/css" rel="Stylesheet" href="../Content/Demo/Css/CustomCss_Preview.css" />
    <link type="text/css" rel="stylesheet" href="../Content/Site.css" />
    <link type="text/css" rel="stylesheet" href="../Content/Demo/Css/FullScreenModes.css" />
    <script type="text/javascript">
        function onInit(s, e) {
            s.SetHeight(document.getElementById("wrapper").offsetHeight);
            s.ExecuteCommand(ASPxClientCommandConsts.FULLSCREEN_COMMAND);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" CornerRadius="0px" CssClass="panel" Height="100%" ContentHeight="100%" Width="900px">
            <HeaderStyle Paddings-Padding="0px" />
            <ContentPaddings Padding="0px" />
            <HeaderTemplate>
                <div class="back">
                    <a href="General.aspx">Go to the technical demos to browse the complete set of ASPxHtmlEditor features</a>
                </div>
                <h1>
                    <span class="title">Full-Screen Mode</span>
                    <span>Ribbon UI</span><a href="FullScreenModeStandardUI.aspx" class="switchLink">switch to Standard UI</a>
                </h1>
            </HeaderTemplate>
            <PanelCollection>
                <dx:PanelContent>
                    <div id="wrapper">
                        <dx:ASPxHtmlEditor runat="server" ID="DemoHtmlEditor" ClientInstanceName="demoHtmlEditor" ToolbarMode="Ribbon" Width="100%" Height="600px">
                            <RibbonTabs>
                                <dx:HEHomeRibbonTab>
                                    <Groups>
                                        <dx:HEUndoRibbonGroup>
                                            <Items>
                                                <dx:HEUndoRibbonCommand Size="Large">
                                                </dx:HEUndoRibbonCommand>
                                                <dx:HERedoRibbonCommand Size="Large">
                                                </dx:HERedoRibbonCommand>
                                            </Items>
                                        </dx:HEUndoRibbonGroup>
                                        <dx:HEClipboardRibbonGroup>
                                            <Items>
                                                <dx:HEPasteFromWordRibbonCommand Size="Large">
                                                </dx:HEPasteFromWordRibbonCommand>
                                                <dx:HECutSelectionRibbonCommand>
                                                </dx:HECutSelectionRibbonCommand>
                                                <dx:HECopySelectionRibbonCommand>
                                                </dx:HECopySelectionRibbonCommand>
                                                <dx:HEPasteSelectionRibbonCommand>
                                                </dx:HEPasteSelectionRibbonCommand>
                                            </Items>
                                        </dx:HEClipboardRibbonGroup>
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
                                                        <dx:ListEditItem Text="Segoe UI" Value="Segoe UI" />
                                                    </Items>
                                                    <PropertiesComboBox IncrementalFilteringMode="None" NullText="(Font Name)" Width="140px">
                                                    </PropertiesComboBox>
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
                                                    <PropertiesComboBox IncrementalFilteringMode="None" NullText="(Font Size)" Width="90px">
                                                    </PropertiesComboBox>
                                                </dx:HEFontSizeRibbonCommand>
                                                <dx:HEBackColorRibbonCommand>
                                                </dx:HEBackColorRibbonCommand>
                                                <dx:HEFontColorRibbonCommand>
                                                </dx:HEFontColorRibbonCommand>
                                                <dx:HERemoveFormatRibbonCommand>
                                                </dx:HERemoveFormatRibbonCommand>
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
                                        <dx:RibbonGroup Text="Styles">
                                            <Image IconID="format_changefontstyle_32x32">
                                            </Image>
                                            <Items>
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
                                                    <PropertiesComboBox IncrementalFilteringMode="None" NullText="(Paragraph)" Width="120px">
                                                    </PropertiesComboBox>
                                                </dx:HEParagraphFormattingRibbonCommand>
                                                <dx:HECustomCssRibbonCommand>
                                                    <PropertiesComboBox Width="120px"></PropertiesComboBox>
                                                    <Items>
                                                        <dx:ToolbarCustomCssListEditItem TagName="" Text="Clear Style" CssClass="" />
                                                        <dx:ToolbarCustomCssListEditItem TagName="H1" Text="Title" CssClass="CommonTitle">
                                                            <PreviewStyle CssClass="CommonTitlePreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="H3" Text="Header1" CssClass="CommonHeader1">
                                                            <PreviewStyle CssClass="CommonHeader1Preview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="H4" Text="Header2" CssClass="CommonHeader2">
                                                            <PreviewStyle CssClass="CommonHeader2Preview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="Div" Text="Content" CssClass="CommonContent">
                                                            <PreviewStyle CssClass="CommonContentPreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="Strong" Text="Features" CssClass="CommonFeatures">
                                                            <PreviewStyle CssClass="CommonFeaturesPreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="Div" Text="Footer" CssClass="CommonFooter">
                                                            <PreviewStyle CssClass="CommonFooterPreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="" Text="Link" CssClass="Link">
                                                            <PreviewStyle CssClass="LinkPreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="EM" Text="ImageTitle" CssClass="ImageTitle">
                                                            <PreviewStyle CssClass="ImageTitlePreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                        <dx:ToolbarCustomCssListEditItem TagName="" Text="ImageMargin" CssClass="ImageMargin">
                                                            <PreviewStyle CssClass="ImageMarginPreview" />
                                                        </dx:ToolbarCustomCssListEditItem>
                                                    </Items>
                                                </dx:HECustomCssRibbonCommand>
                                            </Items>
                                        </dx:RibbonGroup>
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
                                        <dx:HEEditingRibbonGroup>
                                            <Items>
                                                <dx:HEFindAndReplaceDialogRibbonCommand Size="Small"></dx:HEFindAndReplaceDialogRibbonCommand>
                                                <dx:HESelectAllRibbonCommand Size="Small"></dx:HESelectAllRibbonCommand>
                                                <dx:HECheckSpellingRibbonCommand Size="Small"></dx:HECheckSpellingRibbonCommand>
                                            </Items>
                                        </dx:HEEditingRibbonGroup>
                                        <dx:RibbonGroup Text="Export and Print">
                                            <Image IconID="export_exportfile_32x32"></Image>
                                            <Items>
                                                <dx:RibbonDropDownButtonItem Name="Export To" Size="Large" Text="Export To" ToolTip="Export To" DropDownMode="false">
                                                    <Items>
                                                        <dx:HEExportToRtfDropDownRibbonCommand>
                                                        </dx:HEExportToRtfDropDownRibbonCommand>
                                                        <dx:HEExportToPdfDropDownRibbonCommand>
                                                        </dx:HEExportToPdfDropDownRibbonCommand>
                                                        <dx:HEExportToTxtDropDownRibbonCommand>
                                                        </dx:HEExportToTxtDropDownRibbonCommand>
                                                        <dx:HEExportToDocxDropDownRibbonCommand>
                                                        </dx:HEExportToDocxDropDownRibbonCommand>
                                                        <dx:HEExportToOdtDropDownRibbonCommand>
                                                        </dx:HEExportToOdtDropDownRibbonCommand>
                                                        <dx:HEExportToMhtDropDownRibbonCommand>
                                                        </dx:HEExportToMhtDropDownRibbonCommand>
                                                    </Items>
                                                    <LargeImage IconID="export_exportfile_32x32">
                                                    </LargeImage>
                                                    <SmallImage IconID="export_exportfile_16x16">
                                                    </SmallImage>
                                                </dx:RibbonDropDownButtonItem>
                                                <dx:HEPrintRibbonCommand Size="Large">
                                                </dx:HEPrintRibbonCommand>
                                            </Items>
                                        </dx:RibbonGroup>
                                        <dx:HEViewsRibbonGroup>
                                            <Items>
                                                <dx:HEFullscreenRibbonCommand Size="Large" Text="Full Screen Mode">
                                                </dx:HEFullscreenRibbonCommand>
                                            </Items>
                                        </dx:HEViewsRibbonGroup>
                                    </Groups>
                                </dx:HEHomeRibbonTab>
                                <dx:HEInsertRibbonTab>
                                    <Groups>
                                        <dx:HEInsertTableRibbonGroup Text="Tables">
                                            <Items>
                                                <dx:HEInsertTableDropDownRibbonCommand Size="Large">
                                                </dx:HEInsertTableDropDownRibbonCommand>
                                            </Items>
                                        </dx:HEInsertTableRibbonGroup>
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
                                        <dx:HEMediaRibbonGroup>
                                            <Items>
                                                <dx:HEInsertYouTubeVideoDialogRibbonCommand Size="Large">
                                                </dx:HEInsertYouTubeVideoDialogRibbonCommand>
                                                <dx:HEInsertFlashDialogRibbonCommand>
                                                </dx:HEInsertFlashDialogRibbonCommand>
                                                <dx:HEInsertVideoDialogRibbonCommand>
                                                </dx:HEInsertVideoDialogRibbonCommand>
                                                <dx:HEInsertAudioDialogRibbonCommand>
                                                </dx:HEInsertAudioDialogRibbonCommand>
                                            </Items>
                                        </dx:HEMediaRibbonGroup>
                                        <dx:RibbonGroup Name="Placeholders" Text="Placeholders">
                                            <Items>
                                                <dx:HEInsertPlaceholderDialogRibbonCommand Size="Large">
                                                </dx:HEInsertPlaceholderDialogRibbonCommand>
                                            </Items>
                                        </dx:RibbonGroup>
                                    </Groups>
                                </dx:HEInsertRibbonTab>
                            </RibbonTabs>
                            <Placeholders>
                                <dx:HtmlEditorPlaceholderItem Value="Placeholder1" />
                                <dx:HtmlEditorPlaceholderItem Value="Placeholder2" />
                                <dx:HtmlEditorPlaceholderItem Value="Placeholder3" />
                            </Placeholders>
                            <Settings AllowCustomColorsInColorPickers="True" AllowScriptExecutionInPreview="True" ShowTagInspector="True">
                                <SettingsHtmlView EnableAutoCompletion="True" HighlightActiveLine="True" HighlightMatchingTags="True" ShowCollapseTagButtons="True" ShowLineNumbers="True" />
                            </Settings>
                            <SettingsHtmlEditing AllowEditFullDocument="True" AllowFormElements="True" AllowHTML5MediaElements="True" AllowIFrames="True" AllowObjectAndEmbedElements="True" AllowScripts="True" AllowYouTubeVideoIFrames="True" EnablePasteOptions="True" EnterMode="BR" PasteMode="MergeFormatting">
                            </SettingsHtmlEditing>
                            <SettingsResize AllowResize="True" />
                            <ClientSideEvents Init="onInit" />
                            <CssFiles>
                                <dx:HtmlEditorCssFile FilePath="~/Content/Demo/Css/CustomCss.css"></dx:HtmlEditorCssFile>
                            </CssFiles>
                            <SettingsSpellChecker Culture="English (United States)">
                                <Dictionaries>
                                    <dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/App_Data/Dictionaries/EnglishAlphabet.txt"
                                        GrammarPath="~/App_Data/Dictionaries/english.aff" DictionaryPath="~/App_Data/Dictionaries/american.xlg"
                                        CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)"></dx:ASPxSpellCheckerISpellDictionary>
                                </Dictionaries>
                            </SettingsSpellChecker>
                        </dx:ASPxHtmlEditor>
                    </div>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel>
    </form>
</body>
</html>
