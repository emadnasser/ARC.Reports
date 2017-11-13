<%@ Page Language="vb" AutoEventWireup="true" CodeFile="FullScreenModeStandardUI.aspx.vb" Inherits="Features_FullScreenModeStandardUI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Html Editor Standard UI</title>
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
		<dx:ASPxRoundPanel runat="server" CssClass="panel" Height="100%" CornerRadius="0px" ContentHeight="100%" Width="900px">
			<HeaderStyle Paddings-Padding="0px" />
			<ContentPaddings Padding="0px" />
			<HeaderTemplate>
				<div class="back">
					<a href="General.aspx">Go to the technical demos to browse the complete set of ASPxHtmlEditor features</a>
				</div>
				<h1>
					<span class="title">Full-Screen Mode</span>
					<span>Standard UI</span><a href="FullScreenModeRibbonUI.aspx" class="switchLink">switch to Ribbon UI</a>
				</h1>
			</HeaderTemplate>
			<PanelCollection>
				<dx:PanelContent>
					<div id="wrapper">
						<dx:ASPxHtmlEditor runat="server" ID="DemoHtmlEditor" ClientInstanceName="demoHtmlEditor" Width="100%">
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
							<Toolbars>
								<dx:HtmlEditorToolbar>
									<Items>
										<dx:ToolbarSelectAllButton></dx:ToolbarSelectAllButton>
										<dx:ToolbarCutButton>
										</dx:ToolbarCutButton>
										<dx:ToolbarCopyButton>
										</dx:ToolbarCopyButton>
										<dx:ToolbarPasteButton>
										</dx:ToolbarPasteButton>
										<dx:ToolbarPasteFromWordButton>
										</dx:ToolbarPasteFromWordButton>
										<dx:ToolbarUndoButton BeginGroup="True">
										</dx:ToolbarUndoButton>
										<dx:ToolbarRedoButton>
										</dx:ToolbarRedoButton>
										<dx:ToolbarRemoveFormatButton BeginGroup="True">
										</dx:ToolbarRemoveFormatButton>
										<dx:ToolbarBoldButton>
										</dx:ToolbarBoldButton>
										<dx:ToolbarItalicButton>
										</dx:ToolbarItalicButton>
										<dx:ToolbarUnderlineButton>
										</dx:ToolbarUnderlineButton>
										<dx:ToolbarStrikethroughButton>
										</dx:ToolbarStrikethroughButton>
										<dx:ToolbarSuperscriptButton>
										</dx:ToolbarSuperscriptButton>
										<dx:ToolbarSubscriptButton>
										</dx:ToolbarSubscriptButton>
										<dx:ToolbarPrintButton BeginGroup="True">
										</dx:ToolbarPrintButton>
										<dx:ToolbarExportDropDownButton>
											<Items>
												<dx:ToolbarExportDropDownItem>
												</dx:ToolbarExportDropDownItem>
												<dx:ToolbarExportDropDownItem Format="Pdf">
												</dx:ToolbarExportDropDownItem>
												<dx:ToolbarExportDropDownItem Format="Txt">
												</dx:ToolbarExportDropDownItem>
												<dx:ToolbarExportDropDownItem Format="Docx">
												</dx:ToolbarExportDropDownItem>
												<dx:ToolbarExportDropDownItem Format="Odt">
												</dx:ToolbarExportDropDownItem>
												<dx:ToolbarExportDropDownItem Format="Mht">
												</dx:ToolbarExportDropDownItem>
											</Items>
										</dx:ToolbarExportDropDownButton>
										<dx:ToolbarFindAndReplaceDialogButton BeginGroup="True">
										</dx:ToolbarFindAndReplaceDialogButton>
										<dx:ToolbarCheckSpellingButton></dx:ToolbarCheckSpellingButton>
										<dx:ToolbarFullscreenButton BeginGroup="True" Text="Full Screen Mode" ViewStyle="ImageAndText">
										</dx:ToolbarFullscreenButton>
									</Items>
								</dx:HtmlEditorToolbar>
								<dx:HtmlEditorToolbar>
									<Items>
										<dx:ToolbarInsertOrderedListButton>
										</dx:ToolbarInsertOrderedListButton>
										<dx:ToolbarInsertUnorderedListButton>
										</dx:ToolbarInsertUnorderedListButton>
										<dx:ToolbarIndentButton>
										</dx:ToolbarIndentButton>
										<dx:ToolbarOutdentButton>
										</dx:ToolbarOutdentButton>
										<dx:ToolbarJustifyLeftButton>
										</dx:ToolbarJustifyLeftButton>
										<dx:ToolbarJustifyCenterButton>
										</dx:ToolbarJustifyCenterButton>
										<dx:ToolbarJustifyRightButton>
										</dx:ToolbarJustifyRightButton>
										<dx:ToolbarJustifyFullButton>
										</dx:ToolbarJustifyFullButton>
										<dx:ToolbarTableOperationsDropDownButton BeginGroup="True">
											<Items>
												<dx:ToolbarInsertTableDialogButton BeginGroup="True" Text="Insert Table..." ToolTip="Insert Table...">
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
										<dx:ToolbarInsertPlaceholderDialogButton>
										</dx:ToolbarInsertPlaceholderDialogButton>
										<dx:ToolbarInsertLinkDialogButton>
										</dx:ToolbarInsertLinkDialogButton>
										<dx:ToolbarUnlinkButton>
										</dx:ToolbarUnlinkButton>
										<dx:ToolbarInsertImageDialogButton>
										</dx:ToolbarInsertImageDialogButton>
										<dx:ToolbarInsertFlashDialogButton BeginGroup="True">
										</dx:ToolbarInsertFlashDialogButton>
										<dx:ToolbarInsertAudioDialogButton>
										</dx:ToolbarInsertAudioDialogButton>
										<dx:ToolbarInsertVideoDialogButton>
										</dx:ToolbarInsertVideoDialogButton>
										<dx:ToolbarInsertYouTubeVideoDialogButton>
										</dx:ToolbarInsertYouTubeVideoDialogButton>
									</Items>
								</dx:HtmlEditorToolbar>
								<dx:HtmlEditorToolbar>
									<Items>
										<dx:ToolbarCustomCssEdit>
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
										</dx:ToolbarCustomCssEdit>
										<dx:ToolbarParagraphFormattingEdit Width="120px">
											<Items>
												<dx:ToolbarListEditItem Text="Normal" Value="p" />
												<dx:ToolbarListEditItem Text="Heading  1" Value="h1" />
												<dx:ToolbarListEditItem Text="Heading  2" Value="h2" />
												<dx:ToolbarListEditItem Text="Heading  3" Value="h3" />
												<dx:ToolbarListEditItem Text="Heading  4" Value="h4" />
												<dx:ToolbarListEditItem Text="Heading  5" Value="h5" />
												<dx:ToolbarListEditItem Text="Heading  6" Value="h6" />
												<dx:ToolbarListEditItem Text="Address" Value="address" />
												<dx:ToolbarListEditItem Text="Normal (DIV)" Value="div" />
											</Items>
										</dx:ToolbarParagraphFormattingEdit>
										<dx:ToolbarFontNameEdit>
											<Items>
												<dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
												<dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
												<dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
												<dx:ToolbarListEditItem Text="Arial" Value="Arial" />
												<dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
												<dx:ToolbarListEditItem Text="Courier" Value="Courier" />
												<dx:ToolbarListEditItem Text="Segoe UI" Value="Segoe UI" />
											</Items>
										</dx:ToolbarFontNameEdit>
										<dx:ToolbarFontSizeEdit>
											<Items>
												<dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
												<dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
												<dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
												<dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
												<dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
												<dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
												<dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
											</Items>
										</dx:ToolbarFontSizeEdit>
										<dx:ToolbarBackColorButton BeginGroup="True">
										</dx:ToolbarBackColorButton>
										<dx:ToolbarFontColorButton>
										</dx:ToolbarFontColorButton>
									</Items>
								</dx:HtmlEditorToolbar>
							</Toolbars>
							<Placeholders>
								<dx:HtmlEditorPlaceholderItem Value="Placeholder1" />
								<dx:HtmlEditorPlaceholderItem Value="Placeholder2" />
								<dx:HtmlEditorPlaceholderItem Value="Placeholder3" />
							</Placeholders>
							<Settings AllowCustomColorsInColorPickers="True" AllowScriptExecutionInPreview="True" ShowTagInspector="True">
								<SettingsHtmlView EnableAutoCompletion="True" HighlightActiveLine="True" HighlightMatchingTags="True" ShowCollapseTagButtons="True" ShowLineNumbers="True" />
							</Settings>
							<SettingsHtmlEditing AllowEditFullDocument="True" AllowFormElements="True" AllowHTML5MediaElements="True" AllowIFrames="True" AllowObjectAndEmbedElements="True"
								AllowScripts="True" AllowYouTubeVideoIFrames="True" EnablePasteOptions="True" EnterMode="BR" PasteMode="MergeFormatting" ResourcePathMode="RootRelative">
							</SettingsHtmlEditing>
							<SettingsResize AllowResize="True" />
						</dx:ASPxHtmlEditor>
					</div>
				</dx:PanelContent>
			</PanelCollection>
		</dx:ASPxRoundPanel>
	</form>
</body>
</html>