Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class RibbonModule
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.FileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.FileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.FileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.FileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.QuickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.PrintItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.PrintPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.UndoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.RedoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.PasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.CutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.CopyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.PasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ChangeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.RepositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.ChangeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.RepositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.FontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.FontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.BarButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ToggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.ToggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.ToggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.ToggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.ToggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.ToggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.ToggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.ToggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.BarButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ChangeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.ChangeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.ChangeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.MakeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.MakeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.ToggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.ClearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.BarButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ToggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.ToggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.ToggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.BarButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.DecreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.IncreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.ToggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.BarButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ToggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.ToggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.ToggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.ToggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.BarButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.ChangeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.SetSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.SetSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.SetDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.ShowLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.AddSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.RemoveSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.AddSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.RemoveSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.ChangeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.ChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.RepositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.FindItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.ReplaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.InsertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.InsertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.InsertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.InsertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.InsertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.InsertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.EditPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.EditPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.InsertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.InsertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.InsertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.InsertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.ChangeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            Me.SetNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            Me.SetNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            Me.SetModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            Me.SetWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            Me.ShowPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
            Me.ChangeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            Me.SetPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            Me.SetLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            Me.ChangeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            Me.ChangeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            Me.SetSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            Me.SetSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            Me.SetSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            Me.ShowColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            Me.InsertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            Me.InsertPageBreakItem2 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.InsertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            Me.InsertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            Me.InsertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            Me.InsertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            Me.ChangeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            Me.SetSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            Me.SetSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            Me.SetSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            Me.SetSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            Me.ToggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            Me.ShowLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            Me.InsertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.ShowAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.ShowAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.ToggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.SwitchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.SwitchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.SwitchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.ToggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            Me.ToggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            Me.ZoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.ZoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.GoToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
            Me.GoToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
            Me.GoToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
            Me.GoToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
            Me.ToggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
            Me.ToggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
            Me.ToggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
            Me.ClosePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
            Me.ChangeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.ChangeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.ToggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.ToggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.ToggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.ToggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.ResetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.ToggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.ToggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.ToggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.ToggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.ToggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.ToggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.ChangeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.RepositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.ChangeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.RepositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.ChangeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.SelectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.SelectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.SelectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.SelectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.SelectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.ShowTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.DeleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.ShowDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.DeleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.DeleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.DeleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.InsertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.InsertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.InsertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.InsertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.MergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.ShowSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.SplitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.ToggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            Me.ToggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            Me.ToggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            Me.ToggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            Me.ToggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.ToggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.ToggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.ToggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.ToggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.ToggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.ToggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.ToggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.ToggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.CheckSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.ProtectDocumentItem1 = New DevExpress.XtraRichEdit.UI.ProtectDocumentItem()
            Me.ChangeRangeEditingPermissionsItem1 = New DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem()
            Me.UnprotectDocumentItem1 = New DevExpress.XtraRichEdit.UI.UnprotectDocumentItem()
            Me.InsertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            Me.UpdateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            Me.AddParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            Me.SetParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.SetParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.InsertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
            Me.InsertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
            Me.InsertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
            Me.InsertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
            Me.InsertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
            Me.InsertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
            Me.InsertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
            Me.InsertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
            Me.ChangeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            Me.ChangeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            Me.ChangeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            Me.RepositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.ChangeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            Me.SetFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            Me.SetFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            Me.SetFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            Me.SetFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            Me.SetFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            Me.ChangeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            Me.SetFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            Me.SetFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            Me.SetFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            Me.SetFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            Me.SetFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            Me.SetFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            Me.SetFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            Me.SetFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            Me.SetFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            Me.FloatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            Me.FloatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            Me.FloatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            Me.FloatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            Me.FloatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            Me.FloatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            Me.FloatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            Me.FloatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            Me.ShowTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            Me.ChangePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
            Me.GalleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.ChangeLanguageItem1 = New DevExpress.XtraRichEdit.UI.ChangeLanguageItem()
            Me.ChangeCommentItem1 = New DevExpress.XtraRichEdit.UI.ChangeCommentItem()
            Me.ReviewersItem1 = New DevExpress.XtraRichEdit.UI.ReviewersItem()
            Me.ReviewingPaneItem1 = New DevExpress.XtraRichEdit.UI.ReviewingPaneItem()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.HeaderFooterToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory()
            Me.HeaderFooterToolsDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage()
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup()
            Me.HeaderFooterToolsDesignOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup()
            Me.HeaderFooterToolsDesignCloseRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup()
            Me.TableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            Me.TableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            Me.TableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            Me.TableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            Me.TableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            Me.TableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            Me.TableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            Me.TableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            Me.TableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
            Me.TableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            Me.FloatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
            Me.FloatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
            Me.FloatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
            Me.FloatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
            Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.HomeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.ClipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.FontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.ParagraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.StylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.EditingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.InsertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.PagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.TablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.IllustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.LinksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.HeaderFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.TextRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.SymbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.PageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            Me.PageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            Me.PageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
            Me.MailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.MailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.ViewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.DocumentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.ShowRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.ZoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.ReviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            Me.DocumentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            Me.DocumentProtectionRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup()
            Me.DocumentCommentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentCommentRibbonPageGroup()
            Me.ReferencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            Me.TableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            Me.CaptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.ShowFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.ShowParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.ShowInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem()
            Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage()
            Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager()
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.RichEditCommentControl1 = New DevExpress.XtraRichEdit.RichEditCommentControl()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'spellChecker1
            '
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            '
            'richEditControl
            '
            Me.richEditControl.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 141)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Comments.ShowAllAuthors = False
            Me.richEditControl.Size = New System.Drawing.Size(845, 248)
            Me.richEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, OptionsSpelling1)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.FileNewItem1, Me.FileOpenItem1, Me.FileSaveItem1, Me.FileSaveAsItem1, Me.QuickPrintItem1, Me.PrintItem1, Me.PrintPreviewItem1, Me.UndoItem1, Me.RedoItem1, Me.PasteItem1, Me.CutItem1, Me.CopyItem1, Me.PasteSpecialItem1, Me.BarButtonGroup1, Me.ChangeFontNameItem1, Me.ChangeFontSizeItem1, Me.FontSizeIncreaseItem1, Me.FontSizeDecreaseItem1, Me.BarButtonGroup2, Me.ToggleFontBoldItem1, Me.ToggleFontItalicItem1, Me.ToggleFontUnderlineItem1, Me.ToggleFontDoubleUnderlineItem1, Me.ToggleFontStrikeoutItem1, Me.ToggleFontDoubleStrikeoutItem1, Me.ToggleFontSuperscriptItem1, Me.ToggleFontSubscriptItem1, Me.BarButtonGroup3, Me.ChangeFontColorItem1, Me.ChangeFontBackColorItem1, Me.ChangeTextCaseItem1, Me.MakeTextUpperCaseItem1, Me.MakeTextLowerCaseItem1, Me.ToggleTextCaseItem1, Me.ClearFormattingItem1, Me.BarButtonGroup4, Me.ToggleBulletedListItem1, Me.ToggleNumberingListItem1, Me.ToggleMultiLevelListItem1, Me.BarButtonGroup5, Me.DecreaseIndentItem1, Me.IncreaseIndentItem1, Me.BarButtonGroup6, Me.ToggleParagraphAlignmentLeftItem1, Me.ToggleParagraphAlignmentCenterItem1, Me.ToggleParagraphAlignmentRightItem1, Me.ToggleParagraphAlignmentJustifyItem1, Me.ToggleShowWhitespaceItem1, Me.BarButtonGroup7, Me.ChangeParagraphLineSpacingItem1, Me.SetSingleParagraphSpacingItem1, Me.SetSesquialteralParagraphSpacingItem1, Me.SetDoubleParagraphSpacingItem1, Me.ShowLineSpacingFormItem1, Me.AddSpacingBeforeParagraphItem1, Me.RemoveSpacingBeforeParagraphItem1, Me.AddSpacingAfterParagraphItem1, Me.RemoveSpacingAfterParagraphItem1, Me.ChangeParagraphBackColorItem1, Me.ChangeStyleItem1, Me.FindItem1, Me.ReplaceItem1, Me.InsertPageBreakItem1, Me.InsertTableItem1, Me.InsertPictureItem1, Me.InsertFloatingPictureItem1, Me.InsertBookmarkItem1, Me.InsertHyperlinkItem1, Me.EditPageHeaderItem1, Me.EditPageFooterItem1, Me.InsertPageNumberItem1, Me.InsertPageCountItem1, Me.InsertTextBoxItem1, Me.InsertSymbolItem1, Me.ChangeSectionPageMarginsItem1, Me.SetNormalSectionPageMarginsItem1, Me.SetNarrowSectionPageMarginsItem1, Me.SetModerateSectionPageMarginsItem1, Me.SetWideSectionPageMarginsItem1, Me.ShowPageMarginsSetupFormItem1, Me.ChangeSectionPageOrientationItem1, Me.SetPortraitPageOrientationItem1, Me.SetLandscapePageOrientationItem1, Me.ChangeSectionPaperKindItem1, Me.ChangeSectionColumnsItem1, Me.SetSectionOneColumnItem1, Me.SetSectionTwoColumnsItem1, Me.SetSectionThreeColumnsItem1, Me.ShowColumnsSetupFormItem1, Me.InsertBreakItem1, Me.InsertPageBreakItem2, Me.InsertColumnBreakItem1, Me.InsertSectionBreakNextPageItem1, Me.InsertSectionBreakEvenPageItem1, Me.InsertSectionBreakOddPageItem1, Me.ChangeSectionLineNumberingItem1, Me.SetSectionLineNumberingNoneItem1, Me.SetSectionLineNumberingContinuousItem1, Me.SetSectionLineNumberingRestartNewPageItem1, Me.SetSectionLineNumberingRestartNewSectionItem1, Me.ToggleParagraphSuppressLineNumbersItem1, Me.ShowLineNumberingFormItem1, Me.InsertMergeFieldItem1, Me.ShowAllFieldCodesItem1, Me.ShowAllFieldResultsItem1, Me.ToggleViewMergedDataItem1, Me.SwitchToSimpleViewItem1, Me.SwitchToDraftViewItem1, Me.SwitchToPrintLayoutViewItem1, Me.ToggleShowHorizontalRulerItem1, Me.ToggleShowVerticalRulerItem1, Me.ZoomOutItem1, Me.ZoomInItem1, Me.GoToPageHeaderItem1, Me.GoToPageFooterItem1, Me.GoToNextHeaderFooterItem1, Me.GoToPreviousHeaderFooterItem1, Me.ToggleLinkToPreviousItem1, Me.ToggleDifferentFirstPageItem1, Me.ToggleDifferentOddAndEvenPagesItem1, Me.ClosePageHeaderFooterItem1, Me.ChangeTableCellsShadingItem1, Me.ChangeTableBordersItem1, Me.ToggleTableCellsBottomBorderItem1, Me.ToggleTableCellsTopBorderItem1, Me.ToggleTableCellsLeftBorderItem1, Me.ToggleTableCellsRightBorderItem1, Me.ResetTableCellsAllBordersItem1, Me.ToggleTableCellsAllBordersItem1, Me.ToggleTableCellsOutsideBorderItem1, Me.ToggleTableCellsInsideBorderItem1, Me.ToggleTableCellsInsideHorizontalBorderItem1, Me.ToggleTableCellsInsideVerticalBorderItem1, Me.ToggleShowTableGridLinesItem1, Me.ChangeTableBorderLineStyleItem1, Me.ChangeTableBorderLineWeightItem1, Me.ChangeTableBorderColorItem1, Me.SelectTableElementsItem1, Me.SelectTableCellItem1, Me.SelectTableColumnItem1, Me.SelectTableRowItem1, Me.SelectTableItem1, Me.ShowTablePropertiesFormItem1, Me.DeleteTableElementsItem1, Me.ShowDeleteTableCellsFormItem1, Me.DeleteTableColumnsItem1, Me.DeleteTableRowsItem1, Me.DeleteTableItem1, Me.InsertTableRowAboveItem1, Me.InsertTableRowBelowItem1, Me.InsertTableColumnToLeftItem1, Me.InsertTableColumnToRightItem1, Me.MergeTableCellsItem1, Me.ShowSplitTableCellsForm1, Me.SplitTableItem1, Me.ToggleTableAutoFitItem1, Me.ToggleTableAutoFitContentsItem1, Me.ToggleTableAutoFitWindowItem1, Me.ToggleTableFixedColumnWidthItem1, Me.ToggleTableCellsTopLeftAlignmentItem1, Me.ToggleTableCellsMiddleLeftAlignmentItem1, Me.ToggleTableCellsBottomLeftAlignmentItem1, Me.ToggleTableCellsTopCenterAlignmentItem1, Me.ToggleTableCellsMiddleCenterAlignmentItem1, Me.ToggleTableCellsBottomCenterAlignmentItem1, Me.ToggleTableCellsTopRightAlignmentItem1, Me.ToggleTableCellsMiddleRightAlignmentItem1, Me.ToggleTableCellsBottomRightAlignmentItem1, Me.CheckSpellingItem1, Me.ProtectDocumentItem1, Me.ChangeRangeEditingPermissionsItem1, Me.UnprotectDocumentItem1, Me.InsertTableOfContentsItem1, Me.UpdateTableOfContentsItem1, Me.AddParagraphsToTableOfContentItem1, Me.SetParagraphHeadingLevelItem1, Me.SetParagraphHeadingLevelItem2, Me.SetParagraphHeadingLevelItem3, Me.SetParagraphHeadingLevelItem4, Me.SetParagraphHeadingLevelItem5, Me.SetParagraphHeadingLevelItem6, Me.SetParagraphHeadingLevelItem7, Me.SetParagraphHeadingLevelItem8, Me.SetParagraphHeadingLevelItem9, Me.SetParagraphHeadingLevelItem10, Me.InsertCaptionPlaceholderItem1, Me.InsertFiguresCaptionItems1, Me.InsertTablesCaptionItems1, Me.InsertEquationsCaptionItems1, Me.InsertTableOfFiguresPlaceholderItem1, Me.InsertTableOfFiguresItems1, Me.InsertTableOfTablesItems1, Me.InsertTableOfEquationsItems1, Me.ChangeFloatingObjectFillColorItem1, Me.ChangeFloatingObjectOutlineColorItem1, Me.ChangeFloatingObjectOutlineWeightItem1, Me.ChangeFloatingObjectTextWrapTypeItem1, Me.SetFloatingObjectSquareTextWrapTypeItem1, Me.SetFloatingObjectTightTextWrapTypeItem1, Me.SetFloatingObjectThroughTextWrapTypeItem1, Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1, Me.SetFloatingObjectBehindTextWrapTypeItem1, Me.SetFloatingObjectInFrontOfTextWrapTypeItem1, Me.ChangeFloatingObjectAlignmentItem1, Me.SetFloatingObjectTopLeftAlignmentItem1, Me.SetFloatingObjectTopCenterAlignmentItem1, Me.SetFloatingObjectTopRightAlignmentItem1, Me.SetFloatingObjectMiddleLeftAlignmentItem1, Me.SetFloatingObjectMiddleCenterAlignmentItem1, Me.SetFloatingObjectMiddleRightAlignmentItem1, Me.SetFloatingObjectBottomLeftAlignmentItem1, Me.SetFloatingObjectBottomCenterAlignmentItem1, Me.SetFloatingObjectBottomRightAlignmentItem1, Me.FloatingObjectBringForwardSubItem1, Me.FloatingObjectBringForwardItem1, Me.FloatingObjectBringToFrontItem1, Me.FloatingObjectBringInFrontOfTextItem1, Me.FloatingObjectSendBackwardSubItem1, Me.FloatingObjectSendBackwardItem1, Me.FloatingObjectSendToBackItem1, Me.FloatingObjectSendBehindTextItem1, Me.ShowTableOptionsFormItem1, Me.ChangePageColorItem1, Me.GalleryChangeStyleItem1, Me.ChangeLanguageItem1, Me.ChangeCommentItem1, Me.ReviewersItem1, Me.ReviewingPaneItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 667
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.HeaderFooterToolsRibbonPageCategory1, Me.TableToolsRibbonPageCategory1, Me.FloatingPictureToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1, Me.InsertRibbonPage1, Me.PageLayoutRibbonPage1, Me.MailingsRibbonPage1, Me.ViewRibbonPage1, Me.ReviewRibbonPage1, Me.ReferencesRibbonPage1})
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.FileSaveItem1)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.UndoItem1)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.RedoItem1)
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemFontEdit1, Me.RepositoryItemRichEditFontSizeEdit1, Me.RepositoryItemRichEditStyleEdit1, Me.RepositoryItemBorderLineStyle1, Me.RepositoryItemBorderLineWeight1, Me.RepositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl1.Size = New System.Drawing.Size(845, 141)
            Me.ribbonControl1.Tag = ""
            '
            'FileNewItem1
            '
            Me.FileNewItem1.Id = 445
            Me.FileNewItem1.Name = "FileNewItem1"
            '
            'FileOpenItem1
            '
            Me.FileOpenItem1.Id = 446
            Me.FileOpenItem1.Name = "FileOpenItem1"
            '
            'FileSaveItem1
            '
            Me.FileSaveItem1.Id = 447
            Me.FileSaveItem1.Name = "FileSaveItem1"
            '
            'FileSaveAsItem1
            '
            Me.FileSaveAsItem1.Id = 448
            Me.FileSaveAsItem1.Name = "FileSaveAsItem1"
            '
            'QuickPrintItem1
            '
            Me.QuickPrintItem1.Id = 449
            Me.QuickPrintItem1.Name = "QuickPrintItem1"
            '
            'PrintItem1
            '
            Me.PrintItem1.Id = 450
            Me.PrintItem1.Name = "PrintItem1"
            '
            'PrintPreviewItem1
            '
            Me.PrintPreviewItem1.Id = 451
            Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
            '
            'UndoItem1
            '
            Me.UndoItem1.Id = 452
            Me.UndoItem1.Name = "UndoItem1"
            '
            'RedoItem1
            '
            Me.RedoItem1.Id = 453
            Me.RedoItem1.Name = "RedoItem1"
            '
            'PasteItem1
            '
            Me.PasteItem1.Id = 454
            Me.PasteItem1.Name = "PasteItem1"
            '
            'CutItem1
            '
            Me.CutItem1.Id = 455
            Me.CutItem1.Name = "CutItem1"
            '
            'CopyItem1
            '
            Me.CopyItem1.Id = 456
            Me.CopyItem1.Name = "CopyItem1"
            '
            'PasteSpecialItem1
            '
            Me.PasteSpecialItem1.Id = 457
            Me.PasteSpecialItem1.Name = "PasteSpecialItem1"
            '
            'BarButtonGroup1
            '
            Me.BarButtonGroup1.Id = 438
            Me.BarButtonGroup1.ItemLinks.Add(Me.ChangeFontNameItem1)
            Me.BarButtonGroup1.ItemLinks.Add(Me.ChangeFontSizeItem1)
            Me.BarButtonGroup1.ItemLinks.Add(Me.FontSizeIncreaseItem1)
            Me.BarButtonGroup1.ItemLinks.Add(Me.FontSizeDecreaseItem1)
            Me.BarButtonGroup1.Name = "BarButtonGroup1"
            Me.BarButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            '
            'ChangeFontNameItem1
            '
            Me.ChangeFontNameItem1.Edit = Me.RepositoryItemFontEdit1
            Me.ChangeFontNameItem1.Id = 458
            Me.ChangeFontNameItem1.Name = "ChangeFontNameItem1"
            '
            'RepositoryItemFontEdit1
            '
            Me.RepositoryItemFontEdit1.AutoHeight = False
            Me.RepositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemFontEdit1.Name = "RepositoryItemFontEdit1"
            '
            'ChangeFontSizeItem1
            '
            Me.ChangeFontSizeItem1.Edit = Me.RepositoryItemRichEditFontSizeEdit1
            Me.ChangeFontSizeItem1.Id = 459
            Me.ChangeFontSizeItem1.Name = "ChangeFontSizeItem1"
            '
            'RepositoryItemRichEditFontSizeEdit1
            '
            Me.RepositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.RepositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.RepositoryItemRichEditFontSizeEdit1.Name = "RepositoryItemRichEditFontSizeEdit1"
            '
            'FontSizeIncreaseItem1
            '
            Me.FontSizeIncreaseItem1.Id = 460
            Me.FontSizeIncreaseItem1.Name = "FontSizeIncreaseItem1"
            '
            'FontSizeDecreaseItem1
            '
            Me.FontSizeDecreaseItem1.Id = 461
            Me.FontSizeDecreaseItem1.Name = "FontSizeDecreaseItem1"
            '
            'BarButtonGroup2
            '
            Me.BarButtonGroup2.Id = 439
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontBoldItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontItalicItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontUnderlineItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontDoubleUnderlineItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontStrikeoutItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontDoubleStrikeoutItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontSuperscriptItem1)
            Me.BarButtonGroup2.ItemLinks.Add(Me.ToggleFontSubscriptItem1)
            Me.BarButtonGroup2.Name = "BarButtonGroup2"
            Me.BarButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            '
            'ToggleFontBoldItem1
            '
            Me.ToggleFontBoldItem1.Id = 462
            Me.ToggleFontBoldItem1.Name = "ToggleFontBoldItem1"
            '
            'ToggleFontItalicItem1
            '
            Me.ToggleFontItalicItem1.Id = 463
            Me.ToggleFontItalicItem1.Name = "ToggleFontItalicItem1"
            '
            'ToggleFontUnderlineItem1
            '
            Me.ToggleFontUnderlineItem1.Id = 464
            Me.ToggleFontUnderlineItem1.Name = "ToggleFontUnderlineItem1"
            '
            'ToggleFontDoubleUnderlineItem1
            '
            Me.ToggleFontDoubleUnderlineItem1.Id = 465
            Me.ToggleFontDoubleUnderlineItem1.Name = "ToggleFontDoubleUnderlineItem1"
            '
            'ToggleFontStrikeoutItem1
            '
            Me.ToggleFontStrikeoutItem1.Id = 466
            Me.ToggleFontStrikeoutItem1.Name = "ToggleFontStrikeoutItem1"
            '
            'ToggleFontDoubleStrikeoutItem1
            '
            Me.ToggleFontDoubleStrikeoutItem1.Id = 467
            Me.ToggleFontDoubleStrikeoutItem1.Name = "ToggleFontDoubleStrikeoutItem1"
            '
            'ToggleFontSuperscriptItem1
            '
            Me.ToggleFontSuperscriptItem1.Id = 468
            Me.ToggleFontSuperscriptItem1.Name = "ToggleFontSuperscriptItem1"
            '
            'ToggleFontSubscriptItem1
            '
            Me.ToggleFontSubscriptItem1.Id = 469
            Me.ToggleFontSubscriptItem1.Name = "ToggleFontSubscriptItem1"
            '
            'BarButtonGroup3
            '
            Me.BarButtonGroup3.Id = 440
            Me.BarButtonGroup3.ItemLinks.Add(Me.ChangeFontColorItem1)
            Me.BarButtonGroup3.ItemLinks.Add(Me.ChangeFontBackColorItem1)
            Me.BarButtonGroup3.Name = "BarButtonGroup3"
            Me.BarButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            '
            'ChangeFontColorItem1
            '
            Me.ChangeFontColorItem1.Id = 470
            Me.ChangeFontColorItem1.Name = "ChangeFontColorItem1"
            '
            'ChangeFontBackColorItem1
            '
            Me.ChangeFontBackColorItem1.Id = 471
            Me.ChangeFontBackColorItem1.Name = "ChangeFontBackColorItem1"
            '
            'ChangeTextCaseItem1
            '
            Me.ChangeTextCaseItem1.Id = 472
            Me.ChangeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MakeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.MakeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTextCaseItem1)})
            Me.ChangeTextCaseItem1.Name = "ChangeTextCaseItem1"
            '
            'MakeTextUpperCaseItem1
            '
            Me.MakeTextUpperCaseItem1.Id = 473
            Me.MakeTextUpperCaseItem1.Name = "MakeTextUpperCaseItem1"
            '
            'MakeTextLowerCaseItem1
            '
            Me.MakeTextLowerCaseItem1.Id = 474
            Me.MakeTextLowerCaseItem1.Name = "MakeTextLowerCaseItem1"
            '
            'ToggleTextCaseItem1
            '
            Me.ToggleTextCaseItem1.Id = 475
            Me.ToggleTextCaseItem1.Name = "ToggleTextCaseItem1"
            '
            'ClearFormattingItem1
            '
            Me.ClearFormattingItem1.Id = 476
            Me.ClearFormattingItem1.Name = "ClearFormattingItem1"
            '
            'BarButtonGroup4
            '
            Me.BarButtonGroup4.Id = 441
            Me.BarButtonGroup4.ItemLinks.Add(Me.ToggleBulletedListItem1)
            Me.BarButtonGroup4.ItemLinks.Add(Me.ToggleNumberingListItem1)
            Me.BarButtonGroup4.ItemLinks.Add(Me.ToggleMultiLevelListItem1)
            Me.BarButtonGroup4.Name = "BarButtonGroup4"
            Me.BarButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            '
            'ToggleBulletedListItem1
            '
            Me.ToggleBulletedListItem1.Id = 477
            Me.ToggleBulletedListItem1.Name = "ToggleBulletedListItem1"
            '
            'ToggleNumberingListItem1
            '
            Me.ToggleNumberingListItem1.Id = 478
            Me.ToggleNumberingListItem1.Name = "ToggleNumberingListItem1"
            '
            'ToggleMultiLevelListItem1
            '
            Me.ToggleMultiLevelListItem1.Id = 479
            Me.ToggleMultiLevelListItem1.Name = "ToggleMultiLevelListItem1"
            '
            'BarButtonGroup5
            '
            Me.BarButtonGroup5.Id = 442
            Me.BarButtonGroup5.ItemLinks.Add(Me.DecreaseIndentItem1)
            Me.BarButtonGroup5.ItemLinks.Add(Me.IncreaseIndentItem1)
            Me.BarButtonGroup5.ItemLinks.Add(Me.ToggleShowWhitespaceItem1)
            Me.BarButtonGroup5.Name = "BarButtonGroup5"
            Me.BarButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            '
            'DecreaseIndentItem1
            '
            Me.DecreaseIndentItem1.Id = 480
            Me.DecreaseIndentItem1.Name = "DecreaseIndentItem1"
            '
            'IncreaseIndentItem1
            '
            Me.IncreaseIndentItem1.Id = 481
            Me.IncreaseIndentItem1.Name = "IncreaseIndentItem1"
            '
            'ToggleShowWhitespaceItem1
            '
            Me.ToggleShowWhitespaceItem1.Id = 482
            Me.ToggleShowWhitespaceItem1.Name = "ToggleShowWhitespaceItem1"
            '
            'BarButtonGroup6
            '
            Me.BarButtonGroup6.Id = 443
            Me.BarButtonGroup6.ItemLinks.Add(Me.ToggleParagraphAlignmentLeftItem1)
            Me.BarButtonGroup6.ItemLinks.Add(Me.ToggleParagraphAlignmentCenterItem1)
            Me.BarButtonGroup6.ItemLinks.Add(Me.ToggleParagraphAlignmentRightItem1)
            Me.BarButtonGroup6.ItemLinks.Add(Me.ToggleParagraphAlignmentJustifyItem1)
            Me.BarButtonGroup6.Name = "BarButtonGroup6"
            Me.BarButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            '
            'ToggleParagraphAlignmentLeftItem1
            '
            Me.ToggleParagraphAlignmentLeftItem1.Id = 483
            Me.ToggleParagraphAlignmentLeftItem1.Name = "ToggleParagraphAlignmentLeftItem1"
            '
            'ToggleParagraphAlignmentCenterItem1
            '
            Me.ToggleParagraphAlignmentCenterItem1.Id = 484
            Me.ToggleParagraphAlignmentCenterItem1.Name = "ToggleParagraphAlignmentCenterItem1"
            '
            'ToggleParagraphAlignmentRightItem1
            '
            Me.ToggleParagraphAlignmentRightItem1.Id = 485
            Me.ToggleParagraphAlignmentRightItem1.Name = "ToggleParagraphAlignmentRightItem1"
            '
            'ToggleParagraphAlignmentJustifyItem1
            '
            Me.ToggleParagraphAlignmentJustifyItem1.Id = 486
            Me.ToggleParagraphAlignmentJustifyItem1.Name = "ToggleParagraphAlignmentJustifyItem1"
            '
            'BarButtonGroup7
            '
            Me.BarButtonGroup7.Id = 444
            Me.BarButtonGroup7.ItemLinks.Add(Me.ChangeParagraphLineSpacingItem1)
            Me.BarButtonGroup7.ItemLinks.Add(Me.ChangeParagraphBackColorItem1)
            Me.BarButtonGroup7.Name = "BarButtonGroup7"
            Me.BarButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            '
            'ChangeParagraphLineSpacingItem1
            '
            Me.ChangeParagraphLineSpacingItem1.Id = 487
            Me.ChangeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.AddSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.RemoveSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.AddSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.RemoveSpacingAfterParagraphItem1)})
            Me.ChangeParagraphLineSpacingItem1.Name = "ChangeParagraphLineSpacingItem1"
            '
            'SetSingleParagraphSpacingItem1
            '
            Me.SetSingleParagraphSpacingItem1.Id = 488
            Me.SetSingleParagraphSpacingItem1.Name = "SetSingleParagraphSpacingItem1"
            '
            'SetSesquialteralParagraphSpacingItem1
            '
            Me.SetSesquialteralParagraphSpacingItem1.Id = 489
            Me.SetSesquialteralParagraphSpacingItem1.Name = "SetSesquialteralParagraphSpacingItem1"
            '
            'SetDoubleParagraphSpacingItem1
            '
            Me.SetDoubleParagraphSpacingItem1.Id = 490
            Me.SetDoubleParagraphSpacingItem1.Name = "SetDoubleParagraphSpacingItem1"
            '
            'ShowLineSpacingFormItem1
            '
            Me.ShowLineSpacingFormItem1.Id = 491
            Me.ShowLineSpacingFormItem1.Name = "ShowLineSpacingFormItem1"
            '
            'AddSpacingBeforeParagraphItem1
            '
            Me.AddSpacingBeforeParagraphItem1.Id = 492
            Me.AddSpacingBeforeParagraphItem1.Name = "AddSpacingBeforeParagraphItem1"
            '
            'RemoveSpacingBeforeParagraphItem1
            '
            Me.RemoveSpacingBeforeParagraphItem1.Id = 493
            Me.RemoveSpacingBeforeParagraphItem1.Name = "RemoveSpacingBeforeParagraphItem1"
            '
            'AddSpacingAfterParagraphItem1
            '
            Me.AddSpacingAfterParagraphItem1.Id = 494
            Me.AddSpacingAfterParagraphItem1.Name = "AddSpacingAfterParagraphItem1"
            '
            'RemoveSpacingAfterParagraphItem1
            '
            Me.RemoveSpacingAfterParagraphItem1.Id = 495
            Me.RemoveSpacingAfterParagraphItem1.Name = "RemoveSpacingAfterParagraphItem1"
            '
            'ChangeParagraphBackColorItem1
            '
            Me.ChangeParagraphBackColorItem1.Id = 496
            Me.ChangeParagraphBackColorItem1.Name = "ChangeParagraphBackColorItem1"
            '
            'ChangeStyleItem1
            '
            Me.ChangeStyleItem1.Edit = Me.RepositoryItemRichEditStyleEdit1
            Me.ChangeStyleItem1.Id = 497
            Me.ChangeStyleItem1.Name = "ChangeStyleItem1"
            '
            'RepositoryItemRichEditStyleEdit1
            '
            Me.RepositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.RepositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.RepositoryItemRichEditStyleEdit1.Name = "RepositoryItemRichEditStyleEdit1"
            '
            'FindItem1
            '
            Me.FindItem1.Id = 498
            Me.FindItem1.Name = "FindItem1"
            '
            'ReplaceItem1
            '
            Me.ReplaceItem1.Id = 499
            Me.ReplaceItem1.Name = "ReplaceItem1"
            '
            'InsertPageBreakItem1
            '
            Me.InsertPageBreakItem1.Id = 500
            Me.InsertPageBreakItem1.Name = "InsertPageBreakItem1"
            '
            'InsertTableItem1
            '
            Me.InsertTableItem1.Id = 501
            Me.InsertTableItem1.Name = "InsertTableItem1"
            '
            'InsertPictureItem1
            '
            Me.InsertPictureItem1.Id = 502
            Me.InsertPictureItem1.Name = "InsertPictureItem1"
            '
            'InsertFloatingPictureItem1
            '
            Me.InsertFloatingPictureItem1.Id = 503
            Me.InsertFloatingPictureItem1.Name = "InsertFloatingPictureItem1"
            '
            'InsertBookmarkItem1
            '
            Me.InsertBookmarkItem1.Id = 504
            Me.InsertBookmarkItem1.Name = "InsertBookmarkItem1"
            '
            'InsertHyperlinkItem1
            '
            Me.InsertHyperlinkItem1.Id = 505
            Me.InsertHyperlinkItem1.Name = "InsertHyperlinkItem1"
            '
            'EditPageHeaderItem1
            '
            Me.EditPageHeaderItem1.Id = 506
            Me.EditPageHeaderItem1.Name = "EditPageHeaderItem1"
            '
            'EditPageFooterItem1
            '
            Me.EditPageFooterItem1.Id = 507
            Me.EditPageFooterItem1.Name = "EditPageFooterItem1"
            '
            'InsertPageNumberItem1
            '
            Me.InsertPageNumberItem1.Id = 508
            Me.InsertPageNumberItem1.Name = "InsertPageNumberItem1"
            '
            'InsertPageCountItem1
            '
            Me.InsertPageCountItem1.Id = 509
            Me.InsertPageCountItem1.Name = "InsertPageCountItem1"
            '
            'InsertTextBoxItem1
            '
            Me.InsertTextBoxItem1.Id = 510
            Me.InsertTextBoxItem1.Name = "InsertTextBoxItem1"
            '
            'InsertSymbolItem1
            '
            Me.InsertSymbolItem1.Id = 511
            Me.InsertSymbolItem1.Name = "InsertSymbolItem1"
            '
            'ChangeSectionPageMarginsItem1
            '
            Me.ChangeSectionPageMarginsItem1.Id = 512
            Me.ChangeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowPageMarginsSetupFormItem1)})
            Me.ChangeSectionPageMarginsItem1.Name = "ChangeSectionPageMarginsItem1"
            '
            'SetNormalSectionPageMarginsItem1
            '
            Me.SetNormalSectionPageMarginsItem1.Id = 513
            Me.SetNormalSectionPageMarginsItem1.Name = "SetNormalSectionPageMarginsItem1"
            '
            'SetNarrowSectionPageMarginsItem1
            '
            Me.SetNarrowSectionPageMarginsItem1.Id = 514
            Me.SetNarrowSectionPageMarginsItem1.Name = "SetNarrowSectionPageMarginsItem1"
            '
            'SetModerateSectionPageMarginsItem1
            '
            Me.SetModerateSectionPageMarginsItem1.Id = 515
            Me.SetModerateSectionPageMarginsItem1.Name = "SetModerateSectionPageMarginsItem1"
            '
            'SetWideSectionPageMarginsItem1
            '
            Me.SetWideSectionPageMarginsItem1.Id = 516
            Me.SetWideSectionPageMarginsItem1.Name = "SetWideSectionPageMarginsItem1"
            '
            'ShowPageMarginsSetupFormItem1
            '
            Me.ShowPageMarginsSetupFormItem1.Id = 517
            Me.ShowPageMarginsSetupFormItem1.Name = "ShowPageMarginsSetupFormItem1"
            '
            'ChangeSectionPageOrientationItem1
            '
            Me.ChangeSectionPageOrientationItem1.Id = 518
            Me.ChangeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetLandscapePageOrientationItem1)})
            Me.ChangeSectionPageOrientationItem1.Name = "ChangeSectionPageOrientationItem1"
            '
            'SetPortraitPageOrientationItem1
            '
            Me.SetPortraitPageOrientationItem1.Id = 519
            Me.SetPortraitPageOrientationItem1.Name = "SetPortraitPageOrientationItem1"
            '
            'SetLandscapePageOrientationItem1
            '
            Me.SetLandscapePageOrientationItem1.Id = 520
            Me.SetLandscapePageOrientationItem1.Name = "SetLandscapePageOrientationItem1"
            '
            'ChangeSectionPaperKindItem1
            '
            Me.ChangeSectionPaperKindItem1.Id = 521
            Me.ChangeSectionPaperKindItem1.Name = "ChangeSectionPaperKindItem1"
            '
            'ChangeSectionColumnsItem1
            '
            Me.ChangeSectionColumnsItem1.Id = 522
            Me.ChangeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowColumnsSetupFormItem1)})
            Me.ChangeSectionColumnsItem1.Name = "ChangeSectionColumnsItem1"
            '
            'SetSectionOneColumnItem1
            '
            Me.SetSectionOneColumnItem1.Id = 523
            Me.SetSectionOneColumnItem1.Name = "SetSectionOneColumnItem1"
            '
            'SetSectionTwoColumnsItem1
            '
            Me.SetSectionTwoColumnsItem1.Id = 524
            Me.SetSectionTwoColumnsItem1.Name = "SetSectionTwoColumnsItem1"
            '
            'SetSectionThreeColumnsItem1
            '
            Me.SetSectionThreeColumnsItem1.Id = 525
            Me.SetSectionThreeColumnsItem1.Name = "SetSectionThreeColumnsItem1"
            '
            'ShowColumnsSetupFormItem1
            '
            Me.ShowColumnsSetupFormItem1.Id = 526
            Me.ShowColumnsSetupFormItem1.Name = "ShowColumnsSetupFormItem1"
            '
            'InsertBreakItem1
            '
            Me.InsertBreakItem1.Id = 527
            Me.InsertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.InsertPageBreakItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertSectionBreakOddPageItem1)})
            Me.InsertBreakItem1.Name = "InsertBreakItem1"
            '
            'InsertPageBreakItem2
            '
            Me.InsertPageBreakItem2.Id = 528
            Me.InsertPageBreakItem2.Name = "InsertPageBreakItem2"
            '
            'InsertColumnBreakItem1
            '
            Me.InsertColumnBreakItem1.Id = 529
            Me.InsertColumnBreakItem1.Name = "InsertColumnBreakItem1"
            '
            'InsertSectionBreakNextPageItem1
            '
            Me.InsertSectionBreakNextPageItem1.Id = 530
            Me.InsertSectionBreakNextPageItem1.Name = "InsertSectionBreakNextPageItem1"
            '
            'InsertSectionBreakEvenPageItem1
            '
            Me.InsertSectionBreakEvenPageItem1.Id = 531
            Me.InsertSectionBreakEvenPageItem1.Name = "InsertSectionBreakEvenPageItem1"
            '
            'InsertSectionBreakOddPageItem1
            '
            Me.InsertSectionBreakOddPageItem1.Id = 532
            Me.InsertSectionBreakOddPageItem1.Name = "InsertSectionBreakOddPageItem1"
            '
            'ChangeSectionLineNumberingItem1
            '
            Me.ChangeSectionLineNumberingItem1.Id = 533
            Me.ChangeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowLineNumberingFormItem1)})
            Me.ChangeSectionLineNumberingItem1.Name = "ChangeSectionLineNumberingItem1"
            '
            'SetSectionLineNumberingNoneItem1
            '
            Me.SetSectionLineNumberingNoneItem1.Id = 534
            Me.SetSectionLineNumberingNoneItem1.Name = "SetSectionLineNumberingNoneItem1"
            '
            'SetSectionLineNumberingContinuousItem1
            '
            Me.SetSectionLineNumberingContinuousItem1.Id = 535
            Me.SetSectionLineNumberingContinuousItem1.Name = "SetSectionLineNumberingContinuousItem1"
            '
            'SetSectionLineNumberingRestartNewPageItem1
            '
            Me.SetSectionLineNumberingRestartNewPageItem1.Id = 536
            Me.SetSectionLineNumberingRestartNewPageItem1.Name = "SetSectionLineNumberingRestartNewPageItem1"
            '
            'SetSectionLineNumberingRestartNewSectionItem1
            '
            Me.SetSectionLineNumberingRestartNewSectionItem1.Id = 537
            Me.SetSectionLineNumberingRestartNewSectionItem1.Name = "SetSectionLineNumberingRestartNewSectionItem1"
            '
            'ToggleParagraphSuppressLineNumbersItem1
            '
            Me.ToggleParagraphSuppressLineNumbersItem1.Id = 538
            Me.ToggleParagraphSuppressLineNumbersItem1.Name = "ToggleParagraphSuppressLineNumbersItem1"
            '
            'ShowLineNumberingFormItem1
            '
            Me.ShowLineNumberingFormItem1.Id = 539
            Me.ShowLineNumberingFormItem1.Name = "ShowLineNumberingFormItem1"
            '
            'InsertMergeFieldItem1
            '
            Me.InsertMergeFieldItem1.Id = 540
            Me.InsertMergeFieldItem1.Name = "InsertMergeFieldItem1"
            '
            'ShowAllFieldCodesItem1
            '
            Me.ShowAllFieldCodesItem1.Id = 541
            Me.ShowAllFieldCodesItem1.Name = "ShowAllFieldCodesItem1"
            '
            'ShowAllFieldResultsItem1
            '
            Me.ShowAllFieldResultsItem1.Id = 542
            Me.ShowAllFieldResultsItem1.Name = "ShowAllFieldResultsItem1"
            '
            'ToggleViewMergedDataItem1
            '
            Me.ToggleViewMergedDataItem1.Id = 543
            Me.ToggleViewMergedDataItem1.Name = "ToggleViewMergedDataItem1"
            '
            'SwitchToSimpleViewItem1
            '
            Me.SwitchToSimpleViewItem1.Id = 544
            Me.SwitchToSimpleViewItem1.Name = "SwitchToSimpleViewItem1"
            '
            'SwitchToDraftViewItem1
            '
            Me.SwitchToDraftViewItem1.Id = 545
            Me.SwitchToDraftViewItem1.Name = "SwitchToDraftViewItem1"
            '
            'SwitchToPrintLayoutViewItem1
            '
            Me.SwitchToPrintLayoutViewItem1.Id = 546
            Me.SwitchToPrintLayoutViewItem1.Name = "SwitchToPrintLayoutViewItem1"
            '
            'ToggleShowHorizontalRulerItem1
            '
            Me.ToggleShowHorizontalRulerItem1.Id = 547
            Me.ToggleShowHorizontalRulerItem1.Name = "ToggleShowHorizontalRulerItem1"
            '
            'ToggleShowVerticalRulerItem1
            '
            Me.ToggleShowVerticalRulerItem1.Id = 548
            Me.ToggleShowVerticalRulerItem1.Name = "ToggleShowVerticalRulerItem1"
            '
            'ZoomOutItem1
            '
            Me.ZoomOutItem1.Id = 549
            Me.ZoomOutItem1.Name = "ZoomOutItem1"
            '
            'ZoomInItem1
            '
            Me.ZoomInItem1.Id = 550
            Me.ZoomInItem1.Name = "ZoomInItem1"
            '
            'GoToPageHeaderItem1
            '
            Me.GoToPageHeaderItem1.Id = 551
            Me.GoToPageHeaderItem1.Name = "GoToPageHeaderItem1"
            '
            'GoToPageFooterItem1
            '
            Me.GoToPageFooterItem1.Id = 552
            Me.GoToPageFooterItem1.Name = "GoToPageFooterItem1"
            '
            'GoToNextHeaderFooterItem1
            '
            Me.GoToNextHeaderFooterItem1.Id = 553
            Me.GoToNextHeaderFooterItem1.Name = "GoToNextHeaderFooterItem1"
            '
            'GoToPreviousHeaderFooterItem1
            '
            Me.GoToPreviousHeaderFooterItem1.Id = 554
            Me.GoToPreviousHeaderFooterItem1.Name = "GoToPreviousHeaderFooterItem1"
            '
            'ToggleLinkToPreviousItem1
            '
            Me.ToggleLinkToPreviousItem1.Id = 555
            Me.ToggleLinkToPreviousItem1.Name = "ToggleLinkToPreviousItem1"
            '
            'ToggleDifferentFirstPageItem1
            '
            Me.ToggleDifferentFirstPageItem1.Id = 556
            Me.ToggleDifferentFirstPageItem1.Name = "ToggleDifferentFirstPageItem1"
            '
            'ToggleDifferentOddAndEvenPagesItem1
            '
            Me.ToggleDifferentOddAndEvenPagesItem1.Id = 557
            Me.ToggleDifferentOddAndEvenPagesItem1.Name = "ToggleDifferentOddAndEvenPagesItem1"
            '
            'ClosePageHeaderFooterItem1
            '
            Me.ClosePageHeaderFooterItem1.Id = 558
            Me.ClosePageHeaderFooterItem1.Name = "ClosePageHeaderFooterItem1"
            '
            'ChangeTableCellsShadingItem1
            '
            Me.ChangeTableCellsShadingItem1.Id = 559
            Me.ChangeTableCellsShadingItem1.Name = "ChangeTableCellsShadingItem1"
            '
            'ChangeTableBordersItem1
            '
            Me.ChangeTableBordersItem1.Id = 560
            Me.ChangeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ResetTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsInsideHorizontalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleShowTableGridLinesItem1)})
            Me.ChangeTableBordersItem1.Name = "ChangeTableBordersItem1"
            '
            'ToggleTableCellsBottomBorderItem1
            '
            Me.ToggleTableCellsBottomBorderItem1.Id = 561
            Me.ToggleTableCellsBottomBorderItem1.Name = "ToggleTableCellsBottomBorderItem1"
            '
            'ToggleTableCellsTopBorderItem1
            '
            Me.ToggleTableCellsTopBorderItem1.Id = 562
            Me.ToggleTableCellsTopBorderItem1.Name = "ToggleTableCellsTopBorderItem1"
            '
            'ToggleTableCellsLeftBorderItem1
            '
            Me.ToggleTableCellsLeftBorderItem1.Id = 563
            Me.ToggleTableCellsLeftBorderItem1.Name = "ToggleTableCellsLeftBorderItem1"
            '
            'ToggleTableCellsRightBorderItem1
            '
            Me.ToggleTableCellsRightBorderItem1.Id = 564
            Me.ToggleTableCellsRightBorderItem1.Name = "ToggleTableCellsRightBorderItem1"
            '
            'ResetTableCellsAllBordersItem1
            '
            Me.ResetTableCellsAllBordersItem1.Id = 565
            Me.ResetTableCellsAllBordersItem1.Name = "ResetTableCellsAllBordersItem1"
            '
            'ToggleTableCellsAllBordersItem1
            '
            Me.ToggleTableCellsAllBordersItem1.Id = 566
            Me.ToggleTableCellsAllBordersItem1.Name = "ToggleTableCellsAllBordersItem1"
            '
            'ToggleTableCellsOutsideBorderItem1
            '
            Me.ToggleTableCellsOutsideBorderItem1.Id = 567
            Me.ToggleTableCellsOutsideBorderItem1.Name = "ToggleTableCellsOutsideBorderItem1"
            '
            'ToggleTableCellsInsideBorderItem1
            '
            Me.ToggleTableCellsInsideBorderItem1.Id = 568
            Me.ToggleTableCellsInsideBorderItem1.Name = "ToggleTableCellsInsideBorderItem1"
            '
            'ToggleTableCellsInsideHorizontalBorderItem1
            '
            Me.ToggleTableCellsInsideHorizontalBorderItem1.Id = 569
            Me.ToggleTableCellsInsideHorizontalBorderItem1.Name = "ToggleTableCellsInsideHorizontalBorderItem1"
            '
            'ToggleTableCellsInsideVerticalBorderItem1
            '
            Me.ToggleTableCellsInsideVerticalBorderItem1.Id = 570
            Me.ToggleTableCellsInsideVerticalBorderItem1.Name = "ToggleTableCellsInsideVerticalBorderItem1"
            '
            'ToggleShowTableGridLinesItem1
            '
            Me.ToggleShowTableGridLinesItem1.Id = 571
            Me.ToggleShowTableGridLinesItem1.Name = "ToggleShowTableGridLinesItem1"
            '
            'ChangeTableBorderLineStyleItem1
            '
            Me.ChangeTableBorderLineStyleItem1.Edit = Me.RepositoryItemBorderLineStyle1
            Me.ChangeTableBorderLineStyleItem1.EditWidth = 130
            Me.ChangeTableBorderLineStyleItem1.Id = 572
            Me.ChangeTableBorderLineStyleItem1.Name = "ChangeTableBorderLineStyleItem1"
            '
            'RepositoryItemBorderLineStyle1
            '
            Me.RepositoryItemBorderLineStyle1.AutoHeight = False
            Me.RepositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemBorderLineStyle1.Control = Me.richEditControl
            Me.RepositoryItemBorderLineStyle1.Name = "RepositoryItemBorderLineStyle1"
            '
            'ChangeTableBorderLineWeightItem1
            '
            Me.ChangeTableBorderLineWeightItem1.Edit = Me.RepositoryItemBorderLineWeight1
            Me.ChangeTableBorderLineWeightItem1.EditValue = 20
            Me.ChangeTableBorderLineWeightItem1.EditWidth = 130
            Me.ChangeTableBorderLineWeightItem1.Id = 573
            Me.ChangeTableBorderLineWeightItem1.Name = "ChangeTableBorderLineWeightItem1"
            '
            'RepositoryItemBorderLineWeight1
            '
            Me.RepositoryItemBorderLineWeight1.AutoHeight = False
            Me.RepositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemBorderLineWeight1.Control = Me.richEditControl
            Me.RepositoryItemBorderLineWeight1.Name = "RepositoryItemBorderLineWeight1"
            '
            'ChangeTableBorderColorItem1
            '
            Me.ChangeTableBorderColorItem1.Id = 574
            Me.ChangeTableBorderColorItem1.Name = "ChangeTableBorderColorItem1"
            '
            'SelectTableElementsItem1
            '
            Me.SelectTableElementsItem1.Id = 575
            Me.SelectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SelectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SelectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SelectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SelectTableItem1)})
            Me.SelectTableElementsItem1.Name = "SelectTableElementsItem1"
            '
            'SelectTableCellItem1
            '
            Me.SelectTableCellItem1.Id = 576
            Me.SelectTableCellItem1.Name = "SelectTableCellItem1"
            '
            'SelectTableColumnItem1
            '
            Me.SelectTableColumnItem1.Id = 577
            Me.SelectTableColumnItem1.Name = "SelectTableColumnItem1"
            '
            'SelectTableRowItem1
            '
            Me.SelectTableRowItem1.Id = 578
            Me.SelectTableRowItem1.Name = "SelectTableRowItem1"
            '
            'SelectTableItem1
            '
            Me.SelectTableItem1.Id = 579
            Me.SelectTableItem1.Name = "SelectTableItem1"
            '
            'ShowTablePropertiesFormItem1
            '
            Me.ShowTablePropertiesFormItem1.Id = 580
            Me.ShowTablePropertiesFormItem1.Name = "ShowTablePropertiesFormItem1"
            '
            'DeleteTableElementsItem1
            '
            Me.DeleteTableElementsItem1.Id = 581
            Me.DeleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ShowDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteTableItem1)})
            Me.DeleteTableElementsItem1.Name = "DeleteTableElementsItem1"
            '
            'ShowDeleteTableCellsFormItem1
            '
            Me.ShowDeleteTableCellsFormItem1.Id = 582
            Me.ShowDeleteTableCellsFormItem1.Name = "ShowDeleteTableCellsFormItem1"
            '
            'DeleteTableColumnsItem1
            '
            Me.DeleteTableColumnsItem1.Id = 583
            Me.DeleteTableColumnsItem1.Name = "DeleteTableColumnsItem1"
            '
            'DeleteTableRowsItem1
            '
            Me.DeleteTableRowsItem1.Id = 584
            Me.DeleteTableRowsItem1.Name = "DeleteTableRowsItem1"
            '
            'DeleteTableItem1
            '
            Me.DeleteTableItem1.Id = 585
            Me.DeleteTableItem1.Name = "DeleteTableItem1"
            '
            'InsertTableRowAboveItem1
            '
            Me.InsertTableRowAboveItem1.Id = 586
            Me.InsertTableRowAboveItem1.Name = "InsertTableRowAboveItem1"
            '
            'InsertTableRowBelowItem1
            '
            Me.InsertTableRowBelowItem1.Id = 587
            Me.InsertTableRowBelowItem1.Name = "InsertTableRowBelowItem1"
            '
            'InsertTableColumnToLeftItem1
            '
            Me.InsertTableColumnToLeftItem1.Id = 588
            Me.InsertTableColumnToLeftItem1.Name = "InsertTableColumnToLeftItem1"
            '
            'InsertTableColumnToRightItem1
            '
            Me.InsertTableColumnToRightItem1.Id = 589
            Me.InsertTableColumnToRightItem1.Name = "InsertTableColumnToRightItem1"
            '
            'MergeTableCellsItem1
            '
            Me.MergeTableCellsItem1.Id = 590
            Me.MergeTableCellsItem1.Name = "MergeTableCellsItem1"
            '
            'ShowSplitTableCellsForm1
            '
            Me.ShowSplitTableCellsForm1.Id = 591
            Me.ShowSplitTableCellsForm1.Name = "ShowSplitTableCellsForm1"
            '
            'SplitTableItem1
            '
            Me.SplitTableItem1.Id = 592
            Me.SplitTableItem1.Name = "SplitTableItem1"
            '
            'ToggleTableAutoFitItem1
            '
            Me.ToggleTableAutoFitItem1.Id = 593
            Me.ToggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleTableFixedColumnWidthItem1)})
            Me.ToggleTableAutoFitItem1.Name = "ToggleTableAutoFitItem1"
            '
            'ToggleTableAutoFitContentsItem1
            '
            Me.ToggleTableAutoFitContentsItem1.Id = 594
            Me.ToggleTableAutoFitContentsItem1.Name = "ToggleTableAutoFitContentsItem1"
            '
            'ToggleTableAutoFitWindowItem1
            '
            Me.ToggleTableAutoFitWindowItem1.Id = 595
            Me.ToggleTableAutoFitWindowItem1.Name = "ToggleTableAutoFitWindowItem1"
            '
            'ToggleTableFixedColumnWidthItem1
            '
            Me.ToggleTableFixedColumnWidthItem1.Id = 596
            Me.ToggleTableFixedColumnWidthItem1.Name = "ToggleTableFixedColumnWidthItem1"
            '
            'ToggleTableCellsTopLeftAlignmentItem1
            '
            Me.ToggleTableCellsTopLeftAlignmentItem1.Id = 597
            Me.ToggleTableCellsTopLeftAlignmentItem1.Name = "ToggleTableCellsTopLeftAlignmentItem1"
            '
            'ToggleTableCellsMiddleLeftAlignmentItem1
            '
            Me.ToggleTableCellsMiddleLeftAlignmentItem1.Id = 598
            Me.ToggleTableCellsMiddleLeftAlignmentItem1.Name = "ToggleTableCellsMiddleLeftAlignmentItem1"
            '
            'ToggleTableCellsBottomLeftAlignmentItem1
            '
            Me.ToggleTableCellsBottomLeftAlignmentItem1.Id = 599
            Me.ToggleTableCellsBottomLeftAlignmentItem1.Name = "ToggleTableCellsBottomLeftAlignmentItem1"
            '
            'ToggleTableCellsTopCenterAlignmentItem1
            '
            Me.ToggleTableCellsTopCenterAlignmentItem1.Id = 600
            Me.ToggleTableCellsTopCenterAlignmentItem1.Name = "ToggleTableCellsTopCenterAlignmentItem1"
            '
            'ToggleTableCellsMiddleCenterAlignmentItem1
            '
            Me.ToggleTableCellsMiddleCenterAlignmentItem1.Id = 601
            Me.ToggleTableCellsMiddleCenterAlignmentItem1.Name = "ToggleTableCellsMiddleCenterAlignmentItem1"
            '
            'ToggleTableCellsBottomCenterAlignmentItem1
            '
            Me.ToggleTableCellsBottomCenterAlignmentItem1.Id = 602
            Me.ToggleTableCellsBottomCenterAlignmentItem1.Name = "ToggleTableCellsBottomCenterAlignmentItem1"
            '
            'ToggleTableCellsTopRightAlignmentItem1
            '
            Me.ToggleTableCellsTopRightAlignmentItem1.Id = 603
            Me.ToggleTableCellsTopRightAlignmentItem1.Name = "ToggleTableCellsTopRightAlignmentItem1"
            '
            'ToggleTableCellsMiddleRightAlignmentItem1
            '
            Me.ToggleTableCellsMiddleRightAlignmentItem1.Id = 604
            Me.ToggleTableCellsMiddleRightAlignmentItem1.Name = "ToggleTableCellsMiddleRightAlignmentItem1"
            '
            'ToggleTableCellsBottomRightAlignmentItem1
            '
            Me.ToggleTableCellsBottomRightAlignmentItem1.Id = 605
            Me.ToggleTableCellsBottomRightAlignmentItem1.Name = "ToggleTableCellsBottomRightAlignmentItem1"
            '
            'CheckSpellingItem1
            '
            Me.CheckSpellingItem1.Id = 606
            Me.CheckSpellingItem1.Name = "CheckSpellingItem1"
            '
            'ProtectDocumentItem1
            '
            Me.ProtectDocumentItem1.Id = 607
            Me.ProtectDocumentItem1.Name = "ProtectDocumentItem1"
            '
            'ChangeRangeEditingPermissionsItem1
            '
            Me.ChangeRangeEditingPermissionsItem1.Id = 608
            Me.ChangeRangeEditingPermissionsItem1.Name = "ChangeRangeEditingPermissionsItem1"
            '
            'UnprotectDocumentItem1
            '
            Me.UnprotectDocumentItem1.Id = 609
            Me.UnprotectDocumentItem1.Name = "UnprotectDocumentItem1"
            '
            'InsertTableOfContentsItem1
            '
            Me.InsertTableOfContentsItem1.Id = 610
            Me.InsertTableOfContentsItem1.Name = "InsertTableOfContentsItem1"
            '
            'UpdateTableOfContentsItem1
            '
            Me.UpdateTableOfContentsItem1.Id = 611
            Me.UpdateTableOfContentsItem1.Name = "UpdateTableOfContentsItem1"
            '
            'AddParagraphsToTableOfContentItem1
            '
            Me.AddParagraphsToTableOfContentItem1.Id = 612
            Me.AddParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.SetParagraphHeadingLevelItem10)})
            Me.AddParagraphsToTableOfContentItem1.Name = "AddParagraphsToTableOfContentItem1"
            '
            'SetParagraphHeadingLevelItem1
            '
            Me.SetParagraphHeadingLevelItem1.Id = 613
            Me.SetParagraphHeadingLevelItem1.Name = "SetParagraphHeadingLevelItem1"
            Me.SetParagraphHeadingLevelItem1.OutlineLevel = 0
            '
            'SetParagraphHeadingLevelItem2
            '
            Me.SetParagraphHeadingLevelItem2.Id = 614
            Me.SetParagraphHeadingLevelItem2.Name = "SetParagraphHeadingLevelItem2"
            Me.SetParagraphHeadingLevelItem2.OutlineLevel = 1
            '
            'SetParagraphHeadingLevelItem3
            '
            Me.SetParagraphHeadingLevelItem3.Id = 615
            Me.SetParagraphHeadingLevelItem3.Name = "SetParagraphHeadingLevelItem3"
            Me.SetParagraphHeadingLevelItem3.OutlineLevel = 2
            '
            'SetParagraphHeadingLevelItem4
            '
            Me.SetParagraphHeadingLevelItem4.Id = 616
            Me.SetParagraphHeadingLevelItem4.Name = "SetParagraphHeadingLevelItem4"
            Me.SetParagraphHeadingLevelItem4.OutlineLevel = 3
            '
            'SetParagraphHeadingLevelItem5
            '
            Me.SetParagraphHeadingLevelItem5.Id = 617
            Me.SetParagraphHeadingLevelItem5.Name = "SetParagraphHeadingLevelItem5"
            Me.SetParagraphHeadingLevelItem5.OutlineLevel = 4
            '
            'SetParagraphHeadingLevelItem6
            '
            Me.SetParagraphHeadingLevelItem6.Id = 618
            Me.SetParagraphHeadingLevelItem6.Name = "SetParagraphHeadingLevelItem6"
            Me.SetParagraphHeadingLevelItem6.OutlineLevel = 5
            '
            'SetParagraphHeadingLevelItem7
            '
            Me.SetParagraphHeadingLevelItem7.Id = 619
            Me.SetParagraphHeadingLevelItem7.Name = "SetParagraphHeadingLevelItem7"
            Me.SetParagraphHeadingLevelItem7.OutlineLevel = 6
            '
            'SetParagraphHeadingLevelItem8
            '
            Me.SetParagraphHeadingLevelItem8.Id = 620
            Me.SetParagraphHeadingLevelItem8.Name = "SetParagraphHeadingLevelItem8"
            Me.SetParagraphHeadingLevelItem8.OutlineLevel = 7
            '
            'SetParagraphHeadingLevelItem9
            '
            Me.SetParagraphHeadingLevelItem9.Id = 621
            Me.SetParagraphHeadingLevelItem9.Name = "SetParagraphHeadingLevelItem9"
            Me.SetParagraphHeadingLevelItem9.OutlineLevel = 8
            '
            'SetParagraphHeadingLevelItem10
            '
            Me.SetParagraphHeadingLevelItem10.Id = 622
            Me.SetParagraphHeadingLevelItem10.Name = "SetParagraphHeadingLevelItem10"
            Me.SetParagraphHeadingLevelItem10.OutlineLevel = 9
            '
            'InsertCaptionPlaceholderItem1
            '
            Me.InsertCaptionPlaceholderItem1.Id = 623
            Me.InsertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.InsertFiguresCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertTablesCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertEquationsCaptionItems1)})
            Me.InsertCaptionPlaceholderItem1.Name = "InsertCaptionPlaceholderItem1"
            '
            'InsertFiguresCaptionItems1
            '
            Me.InsertFiguresCaptionItems1.Id = 624
            Me.InsertFiguresCaptionItems1.Name = "InsertFiguresCaptionItems1"
            '
            'InsertTablesCaptionItems1
            '
            Me.InsertTablesCaptionItems1.Id = 625
            Me.InsertTablesCaptionItems1.Name = "InsertTablesCaptionItems1"
            '
            'InsertEquationsCaptionItems1
            '
            Me.InsertEquationsCaptionItems1.Id = 626
            Me.InsertEquationsCaptionItems1.Name = "InsertEquationsCaptionItems1"
            '
            'InsertTableOfFiguresPlaceholderItem1
            '
            Me.InsertTableOfFiguresPlaceholderItem1.Id = 627
            Me.InsertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.InsertTableOfFiguresItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertTableOfTablesItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.InsertTableOfEquationsItems1)})
            Me.InsertTableOfFiguresPlaceholderItem1.Name = "InsertTableOfFiguresPlaceholderItem1"
            '
            'InsertTableOfFiguresItems1
            '
            Me.InsertTableOfFiguresItems1.Id = 628
            Me.InsertTableOfFiguresItems1.Name = "InsertTableOfFiguresItems1"
            '
            'InsertTableOfTablesItems1
            '
            Me.InsertTableOfTablesItems1.Id = 629
            Me.InsertTableOfTablesItems1.Name = "InsertTableOfTablesItems1"
            '
            'InsertTableOfEquationsItems1
            '
            Me.InsertTableOfEquationsItems1.Id = 630
            Me.InsertTableOfEquationsItems1.Name = "InsertTableOfEquationsItems1"
            '
            'ChangeFloatingObjectFillColorItem1
            '
            Me.ChangeFloatingObjectFillColorItem1.Id = 631
            Me.ChangeFloatingObjectFillColorItem1.Name = "ChangeFloatingObjectFillColorItem1"
            '
            'ChangeFloatingObjectOutlineColorItem1
            '
            Me.ChangeFloatingObjectOutlineColorItem1.Id = 632
            Me.ChangeFloatingObjectOutlineColorItem1.Name = "ChangeFloatingObjectOutlineColorItem1"
            '
            'ChangeFloatingObjectOutlineWeightItem1
            '
            Me.ChangeFloatingObjectOutlineWeightItem1.Edit = Me.RepositoryItemFloatingObjectOutlineWeight1
            Me.ChangeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.ChangeFloatingObjectOutlineWeightItem1.Id = 633
            Me.ChangeFloatingObjectOutlineWeightItem1.Name = "ChangeFloatingObjectOutlineWeightItem1"
            '
            'RepositoryItemFloatingObjectOutlineWeight1
            '
            Me.RepositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            Me.RepositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemFloatingObjectOutlineWeight1.Control = Me.richEditControl
            Me.RepositoryItemFloatingObjectOutlineWeight1.Name = "RepositoryItemFloatingObjectOutlineWeight1"
            '
            'ChangeFloatingObjectTextWrapTypeItem1
            '
            Me.ChangeFloatingObjectTextWrapTypeItem1.Id = 634
            Me.ChangeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectSquareTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectTightTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectThroughTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectBehindTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectInFrontOfTextWrapTypeItem1)})
            Me.ChangeFloatingObjectTextWrapTypeItem1.Name = "ChangeFloatingObjectTextWrapTypeItem1"
            '
            'SetFloatingObjectSquareTextWrapTypeItem1
            '
            Me.SetFloatingObjectSquareTextWrapTypeItem1.Id = 635
            Me.SetFloatingObjectSquareTextWrapTypeItem1.Name = "SetFloatingObjectSquareTextWrapTypeItem1"
            '
            'SetFloatingObjectTightTextWrapTypeItem1
            '
            Me.SetFloatingObjectTightTextWrapTypeItem1.Id = 636
            Me.SetFloatingObjectTightTextWrapTypeItem1.Name = "SetFloatingObjectTightTextWrapTypeItem1"
            '
            'SetFloatingObjectThroughTextWrapTypeItem1
            '
            Me.SetFloatingObjectThroughTextWrapTypeItem1.Id = 637
            Me.SetFloatingObjectThroughTextWrapTypeItem1.Name = "SetFloatingObjectThroughTextWrapTypeItem1"
            '
            'SetFloatingObjectTopAndBottomTextWrapTypeItem1
            '
            Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 638
            Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "SetFloatingObjectTopAndBottomTextWrapTypeItem1"
            '
            'SetFloatingObjectBehindTextWrapTypeItem1
            '
            Me.SetFloatingObjectBehindTextWrapTypeItem1.Id = 639
            Me.SetFloatingObjectBehindTextWrapTypeItem1.Name = "SetFloatingObjectBehindTextWrapTypeItem1"
            '
            'SetFloatingObjectInFrontOfTextWrapTypeItem1
            '
            Me.SetFloatingObjectInFrontOfTextWrapTypeItem1.Id = 640
            Me.SetFloatingObjectInFrontOfTextWrapTypeItem1.Name = "SetFloatingObjectInFrontOfTextWrapTypeItem1"
            '
            'ChangeFloatingObjectAlignmentItem1
            '
            Me.ChangeFloatingObjectAlignmentItem1.Id = 641
            Me.ChangeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetFloatingObjectBottomRightAlignmentItem1)})
            Me.ChangeFloatingObjectAlignmentItem1.Name = "ChangeFloatingObjectAlignmentItem1"
            '
            'SetFloatingObjectTopLeftAlignmentItem1
            '
            Me.SetFloatingObjectTopLeftAlignmentItem1.Id = 642
            Me.SetFloatingObjectTopLeftAlignmentItem1.Name = "SetFloatingObjectTopLeftAlignmentItem1"
            '
            'SetFloatingObjectTopCenterAlignmentItem1
            '
            Me.SetFloatingObjectTopCenterAlignmentItem1.Id = 643
            Me.SetFloatingObjectTopCenterAlignmentItem1.Name = "SetFloatingObjectTopCenterAlignmentItem1"
            '
            'SetFloatingObjectTopRightAlignmentItem1
            '
            Me.SetFloatingObjectTopRightAlignmentItem1.Id = 644
            Me.SetFloatingObjectTopRightAlignmentItem1.Name = "SetFloatingObjectTopRightAlignmentItem1"
            '
            'SetFloatingObjectMiddleLeftAlignmentItem1
            '
            Me.SetFloatingObjectMiddleLeftAlignmentItem1.Id = 645
            Me.SetFloatingObjectMiddleLeftAlignmentItem1.Name = "SetFloatingObjectMiddleLeftAlignmentItem1"
            '
            'SetFloatingObjectMiddleCenterAlignmentItem1
            '
            Me.SetFloatingObjectMiddleCenterAlignmentItem1.Id = 646
            Me.SetFloatingObjectMiddleCenterAlignmentItem1.Name = "SetFloatingObjectMiddleCenterAlignmentItem1"
            '
            'SetFloatingObjectMiddleRightAlignmentItem1
            '
            Me.SetFloatingObjectMiddleRightAlignmentItem1.Id = 647
            Me.SetFloatingObjectMiddleRightAlignmentItem1.Name = "SetFloatingObjectMiddleRightAlignmentItem1"
            '
            'SetFloatingObjectBottomLeftAlignmentItem1
            '
            Me.SetFloatingObjectBottomLeftAlignmentItem1.Id = 648
            Me.SetFloatingObjectBottomLeftAlignmentItem1.Name = "SetFloatingObjectBottomLeftAlignmentItem1"
            '
            'SetFloatingObjectBottomCenterAlignmentItem1
            '
            Me.SetFloatingObjectBottomCenterAlignmentItem1.Id = 649
            Me.SetFloatingObjectBottomCenterAlignmentItem1.Name = "SetFloatingObjectBottomCenterAlignmentItem1"
            '
            'SetFloatingObjectBottomRightAlignmentItem1
            '
            Me.SetFloatingObjectBottomRightAlignmentItem1.Id = 650
            Me.SetFloatingObjectBottomRightAlignmentItem1.Name = "SetFloatingObjectBottomRightAlignmentItem1"
            '
            'FloatingObjectBringForwardSubItem1
            '
            Me.FloatingObjectBringForwardSubItem1.Id = 651
            Me.FloatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectBringForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectBringToFrontItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectBringInFrontOfTextItem1)})
            Me.FloatingObjectBringForwardSubItem1.Name = "FloatingObjectBringForwardSubItem1"
            '
            'FloatingObjectBringForwardItem1
            '
            Me.FloatingObjectBringForwardItem1.Id = 652
            Me.FloatingObjectBringForwardItem1.Name = "FloatingObjectBringForwardItem1"
            '
            'FloatingObjectBringToFrontItem1
            '
            Me.FloatingObjectBringToFrontItem1.Id = 653
            Me.FloatingObjectBringToFrontItem1.Name = "FloatingObjectBringToFrontItem1"
            '
            'FloatingObjectBringInFrontOfTextItem1
            '
            Me.FloatingObjectBringInFrontOfTextItem1.Id = 654
            Me.FloatingObjectBringInFrontOfTextItem1.Name = "FloatingObjectBringInFrontOfTextItem1"
            '
            'FloatingObjectSendBackwardSubItem1
            '
            Me.FloatingObjectSendBackwardSubItem1.Id = 655
            Me.FloatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectSendBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectSendToBackItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.FloatingObjectSendBehindTextItem1)})
            Me.FloatingObjectSendBackwardSubItem1.Name = "FloatingObjectSendBackwardSubItem1"
            '
            'FloatingObjectSendBackwardItem1
            '
            Me.FloatingObjectSendBackwardItem1.Id = 656
            Me.FloatingObjectSendBackwardItem1.Name = "FloatingObjectSendBackwardItem1"
            '
            'FloatingObjectSendToBackItem1
            '
            Me.FloatingObjectSendToBackItem1.Id = 657
            Me.FloatingObjectSendToBackItem1.Name = "FloatingObjectSendToBackItem1"
            '
            'FloatingObjectSendBehindTextItem1
            '
            Me.FloatingObjectSendBehindTextItem1.Id = 658
            Me.FloatingObjectSendBehindTextItem1.Name = "FloatingObjectSendBehindTextItem1"
            '
            'ShowTableOptionsFormItem1
            '
            Me.ShowTableOptionsFormItem1.Id = 659
            Me.ShowTableOptionsFormItem1.Name = "ShowTableOptionsFormItem1"
            '
            'ChangePageColorItem1
            '
            Me.ChangePageColorItem1.Id = 660
            Me.ChangePageColorItem1.Name = "ChangePageColorItem1"
            '
            'GalleryChangeStyleItem1
            '
            '
            '
            '
            Me.GalleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.GalleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.GalleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.GalleryChangeStyleItem1.Id = 661
            Me.GalleryChangeStyleItem1.Name = "GalleryChangeStyleItem1"
            '
            'ChangeLanguageItem1
            '
            Me.ChangeLanguageItem1.Id = 662
            Me.ChangeLanguageItem1.Name = "ChangeLanguageItem1"
            '
            'ChangeCommentItem1
            '
            Me.ChangeCommentItem1.Id = 663
            Me.ChangeCommentItem1.Name = "ChangeCommentItem1"
            '
            'ReviewersItem1
            '
            Me.ReviewersItem1.Id = 664
            Me.ReviewersItem1.Name = "ReviewersItem1"
            '
            'ReviewingPaneItem1
            '
            Me.ReviewingPaneItem1.Id = 665
            Me.ReviewingPaneItem1.Name = "ReviewingPaneItem1"
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 666
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'HeaderFooterToolsRibbonPageCategory1
            '
            Me.HeaderFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.HeaderFooterToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.HeaderFooterToolsRibbonPageCategory1.Name = "HeaderFooterToolsRibbonPageCategory1"
            Me.HeaderFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.HeaderFooterToolsDesignRibbonPage1})
            '
            'HeaderFooterToolsDesignRibbonPage1
            '
            Me.HeaderFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1, Me.HeaderFooterToolsDesignOptionsRibbonPageGroup1, Me.HeaderFooterToolsDesignCloseRibbonPageGroup1})
            Me.HeaderFooterToolsDesignRibbonPage1.Name = "HeaderFooterToolsDesignRibbonPage1"
            '
            'HeaderFooterToolsDesignNavigationRibbonPageGroup1
            '
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.GoToPageHeaderItem1)
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.GoToPageFooterItem1)
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.GoToNextHeaderFooterItem1)
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.GoToPreviousHeaderFooterItem1)
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.ToggleLinkToPreviousItem1)
            Me.HeaderFooterToolsDesignNavigationRibbonPageGroup1.Name = "HeaderFooterToolsDesignNavigationRibbonPageGroup1"
            '
            'HeaderFooterToolsDesignOptionsRibbonPageGroup1
            '
            Me.HeaderFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleDifferentFirstPageItem1)
            Me.HeaderFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleDifferentOddAndEvenPagesItem1)
            Me.HeaderFooterToolsDesignOptionsRibbonPageGroup1.Name = "HeaderFooterToolsDesignOptionsRibbonPageGroup1"
            '
            'HeaderFooterToolsDesignCloseRibbonPageGroup1
            '
            Me.HeaderFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(Me.ClosePageHeaderFooterItem1)
            Me.HeaderFooterToolsDesignCloseRibbonPageGroup1.Name = "HeaderFooterToolsDesignCloseRibbonPageGroup1"
            '
            'TableToolsRibbonPageCategory1
            '
            Me.TableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.TableToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.TableToolsRibbonPageCategory1.Name = "TableToolsRibbonPageCategory1"
            Me.TableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.TableDesignRibbonPage1, Me.TableLayoutRibbonPage1})
            '
            'TableDesignRibbonPage1
            '
            Me.TableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TableStylesRibbonPageGroup1, Me.TableDrawBordersRibbonPageGroup1})
            Me.TableDesignRibbonPage1.Name = "TableDesignRibbonPage1"
            '
            'TableStylesRibbonPageGroup1
            '
            Me.TableStylesRibbonPageGroup1.ItemLinks.Add(Me.ChangeTableCellsShadingItem1)
            Me.TableStylesRibbonPageGroup1.ItemLinks.Add(Me.ChangeTableBordersItem1)
            Me.TableStylesRibbonPageGroup1.Name = "TableStylesRibbonPageGroup1"
            '
            'TableDrawBordersRibbonPageGroup1
            '
            Me.TableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.ChangeTableBorderLineStyleItem1)
            Me.TableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.ChangeTableBorderLineWeightItem1)
            Me.TableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.ChangeTableBorderColorItem1)
            Me.TableDrawBordersRibbonPageGroup1.Name = "TableDrawBordersRibbonPageGroup1"
            '
            'TableLayoutRibbonPage1
            '
            Me.TableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TableTableRibbonPageGroup1, Me.TableRowsAndColumnsRibbonPageGroup1, Me.TableMergeRibbonPageGroup1, Me.TableCellSizeRibbonPageGroup1, Me.TableAlignmentRibbonPageGroup1})
            Me.TableLayoutRibbonPage1.Name = "TableLayoutRibbonPage1"
            '
            'TableTableRibbonPageGroup1
            '
            Me.TableTableRibbonPageGroup1.ItemLinks.Add(Me.SelectTableElementsItem1)
            Me.TableTableRibbonPageGroup1.ItemLinks.Add(Me.ToggleShowTableGridLinesItem1)
            Me.TableTableRibbonPageGroup1.ItemLinks.Add(Me.ShowTablePropertiesFormItem1)
            Me.TableTableRibbonPageGroup1.Name = "TableTableRibbonPageGroup1"
            '
            'TableRowsAndColumnsRibbonPageGroup1
            '
            Me.TableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.DeleteTableElementsItem1)
            Me.TableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableRowAboveItem1)
            Me.TableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableRowBelowItem1)
            Me.TableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableColumnToLeftItem1)
            Me.TableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableColumnToRightItem1)
            Me.TableRowsAndColumnsRibbonPageGroup1.Name = "TableRowsAndColumnsRibbonPageGroup1"
            '
            'TableMergeRibbonPageGroup1
            '
            Me.TableMergeRibbonPageGroup1.ItemLinks.Add(Me.MergeTableCellsItem1)
            Me.TableMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowSplitTableCellsForm1)
            Me.TableMergeRibbonPageGroup1.ItemLinks.Add(Me.SplitTableItem1)
            Me.TableMergeRibbonPageGroup1.Name = "TableMergeRibbonPageGroup1"
            '
            'TableCellSizeRibbonPageGroup1
            '
            Me.TableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableAutoFitItem1)
            Me.TableCellSizeRibbonPageGroup1.Name = "TableCellSizeRibbonPageGroup1"
            '
            'TableAlignmentRibbonPageGroup1
            '
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsTopLeftAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsMiddleLeftAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsBottomLeftAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsTopCenterAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsMiddleCenterAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsBottomCenterAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsTopRightAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsMiddleRightAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ToggleTableCellsBottomRightAlignmentItem1)
            Me.TableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.ShowTableOptionsFormItem1)
            Me.TableAlignmentRibbonPageGroup1.Name = "TableAlignmentRibbonPageGroup1"
            '
            'FloatingPictureToolsRibbonPageCategory1
            '
            Me.FloatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.FloatingPictureToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.FloatingPictureToolsRibbonPageCategory1.Name = "FloatingPictureToolsRibbonPageCategory1"
            Me.FloatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FloatingPictureToolsFormatPage1})
            '
            'FloatingPictureToolsFormatPage1
            '
            Me.FloatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.FloatingPictureToolsShapeStylesPageGroup1, Me.FloatingPictureToolsArrangePageGroup1})
            Me.FloatingPictureToolsFormatPage1.Name = "FloatingPictureToolsFormatPage1"
            '
            'FloatingPictureToolsShapeStylesPageGroup1
            '
            Me.FloatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.ChangeFloatingObjectFillColorItem1)
            Me.FloatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.ChangeFloatingObjectOutlineColorItem1)
            Me.FloatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.ChangeFloatingObjectOutlineWeightItem1)
            Me.FloatingPictureToolsShapeStylesPageGroup1.Name = "FloatingPictureToolsShapeStylesPageGroup1"
            '
            'FloatingPictureToolsArrangePageGroup1
            '
            Me.FloatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.ChangeFloatingObjectTextWrapTypeItem1)
            Me.FloatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.ChangeFloatingObjectAlignmentItem1)
            Me.FloatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.FloatingObjectBringForwardSubItem1)
            Me.FloatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.FloatingObjectSendBackwardSubItem1)
            Me.FloatingPictureToolsArrangePageGroup1.Name = "FloatingPictureToolsArrangePageGroup1"
            '
            'FileRibbonPage1
            '
            Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1})
            Me.FileRibbonPage1.Name = "FileRibbonPage1"
            '
            'CommonRibbonPageGroup1
            '
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.UndoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.RedoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileNewItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileOpenItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.FileSaveAsItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.QuickPrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
            Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
            '
            'InfoRibbonPageGroup1
            '
            Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
            '
            'HomeRibbonPage1
            '
            Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ClipboardRibbonPageGroup1, Me.FontRibbonPageGroup1, Me.ParagraphRibbonPageGroup1, Me.StylesRibbonPageGroup1, Me.EditingRibbonPageGroup1})
            Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
            '
            'ClipboardRibbonPageGroup1
            '
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.PasteItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.CutItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.CopyItem1)
            Me.ClipboardRibbonPageGroup1.ItemLinks.Add(Me.PasteSpecialItem1)
            Me.ClipboardRibbonPageGroup1.Name = "ClipboardRibbonPageGroup1"
            '
            'FontRibbonPageGroup1
            '
            Me.FontRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup1)
            Me.FontRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup2)
            Me.FontRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup3)
            Me.FontRibbonPageGroup1.ItemLinks.Add(Me.ChangeTextCaseItem1)
            Me.FontRibbonPageGroup1.ItemLinks.Add(Me.ClearFormattingItem1)
            Me.FontRibbonPageGroup1.Name = "FontRibbonPageGroup1"
            '
            'ParagraphRibbonPageGroup1
            '
            Me.ParagraphRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup4)
            Me.ParagraphRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup5)
            Me.ParagraphRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup6)
            Me.ParagraphRibbonPageGroup1.ItemLinks.Add(Me.BarButtonGroup7)
            Me.ParagraphRibbonPageGroup1.Name = "ParagraphRibbonPageGroup1"
            '
            'StylesRibbonPageGroup1
            '
            Me.StylesRibbonPageGroup1.ItemLinks.Add(Me.GalleryChangeStyleItem1)
            Me.StylesRibbonPageGroup1.Name = "StylesRibbonPageGroup1"
            '
            'EditingRibbonPageGroup1
            '
            Me.EditingRibbonPageGroup1.ItemLinks.Add(Me.FindItem1)
            Me.EditingRibbonPageGroup1.ItemLinks.Add(Me.ReplaceItem1)
            Me.EditingRibbonPageGroup1.Name = "EditingRibbonPageGroup1"
            '
            'InsertRibbonPage1
            '
            Me.InsertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagesRibbonPageGroup1, Me.TablesRibbonPageGroup1, Me.IllustrationsRibbonPageGroup1, Me.LinksRibbonPageGroup1, Me.HeaderFooterRibbonPageGroup1, Me.TextRibbonPageGroup1, Me.SymbolsRibbonPageGroup1})
            Me.InsertRibbonPage1.Name = "InsertRibbonPage1"
            '
            'PagesRibbonPageGroup1
            '
            Me.PagesRibbonPageGroup1.ItemLinks.Add(Me.InsertPageBreakItem1)
            Me.PagesRibbonPageGroup1.Name = "PagesRibbonPageGroup1"
            '
            'TablesRibbonPageGroup1
            '
            Me.TablesRibbonPageGroup1.ItemLinks.Add(Me.InsertTableItem1)
            Me.TablesRibbonPageGroup1.Name = "TablesRibbonPageGroup1"
            '
            'IllustrationsRibbonPageGroup1
            '
            Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.InsertPictureItem1)
            Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.InsertFloatingPictureItem1)
            Me.IllustrationsRibbonPageGroup1.Name = "IllustrationsRibbonPageGroup1"
            '
            'LinksRibbonPageGroup1
            '
            Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.InsertBookmarkItem1)
            Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.InsertHyperlinkItem1)
            Me.LinksRibbonPageGroup1.Name = "LinksRibbonPageGroup1"
            '
            'HeaderFooterRibbonPageGroup1
            '
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.EditPageHeaderItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.EditPageFooterItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.InsertPageNumberItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.InsertPageCountItem1)
            Me.HeaderFooterRibbonPageGroup1.Name = "HeaderFooterRibbonPageGroup1"
            '
            'TextRibbonPageGroup1
            '
            Me.TextRibbonPageGroup1.ItemLinks.Add(Me.InsertTextBoxItem1)
            Me.TextRibbonPageGroup1.Name = "TextRibbonPageGroup1"
            '
            'SymbolsRibbonPageGroup1
            '
            Me.SymbolsRibbonPageGroup1.ItemLinks.Add(Me.InsertSymbolItem1)
            Me.SymbolsRibbonPageGroup1.Name = "SymbolsRibbonPageGroup1"
            '
            'PageLayoutRibbonPage1
            '
            Me.PageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageSetupRibbonPageGroup1, Me.PageBackgroundRibbonPageGroup1})
            Me.PageLayoutRibbonPage1.Name = "PageLayoutRibbonPage1"
            '
            'PageSetupRibbonPageGroup1
            '
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPageMarginsItem1)
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPageOrientationItem1)
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionPaperKindItem1)
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionColumnsItem1)
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.InsertBreakItem1)
            Me.PageSetupRibbonPageGroup1.ItemLinks.Add(Me.ChangeSectionLineNumberingItem1)
            Me.PageSetupRibbonPageGroup1.Name = "PageSetupRibbonPageGroup1"
            '
            'PageBackgroundRibbonPageGroup1
            '
            Me.PageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.ChangePageColorItem1)
            Me.PageBackgroundRibbonPageGroup1.Name = "PageBackgroundRibbonPageGroup1"
            '
            'MailingsRibbonPage1
            '
            Me.MailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.MailMergeRibbonPageGroup1})
            Me.MailingsRibbonPage1.Name = "MailingsRibbonPage1"
            '
            'MailMergeRibbonPageGroup1
            '
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.InsertMergeFieldItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldCodesItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ShowAllFieldResultsItem1)
            Me.MailMergeRibbonPageGroup1.ItemLinks.Add(Me.ToggleViewMergedDataItem1)
            Me.MailMergeRibbonPageGroup1.Name = "MailMergeRibbonPageGroup1"
            '
            'ViewRibbonPage1
            '
            Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.DocumentViewsRibbonPageGroup1, Me.ShowRibbonPageGroup1, Me.ZoomRibbonPageGroup1})
            Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
            '
            'DocumentViewsRibbonPageGroup1
            '
            Me.DocumentViewsRibbonPageGroup1.ItemLinks.Add(Me.SwitchToSimpleViewItem1)
            Me.DocumentViewsRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDraftViewItem1)
            Me.DocumentViewsRibbonPageGroup1.ItemLinks.Add(Me.SwitchToPrintLayoutViewItem1)
            Me.DocumentViewsRibbonPageGroup1.Name = "DocumentViewsRibbonPageGroup1"
            '
            'ShowRibbonPageGroup1
            '
            Me.ShowRibbonPageGroup1.ItemLinks.Add(Me.ToggleShowHorizontalRulerItem1)
            Me.ShowRibbonPageGroup1.ItemLinks.Add(Me.ToggleShowVerticalRulerItem1)
            Me.ShowRibbonPageGroup1.Name = "ShowRibbonPageGroup1"
            '
            'ZoomRibbonPageGroup1
            '
            Me.ZoomRibbonPageGroup1.ItemLinks.Add(Me.ZoomOutItem1)
            Me.ZoomRibbonPageGroup1.ItemLinks.Add(Me.ZoomInItem1)
            Me.ZoomRibbonPageGroup1.Name = "ZoomRibbonPageGroup1"
            '
            'ReviewRibbonPage1
            '
            Me.ReviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.DocumentProofingRibbonPageGroup1, Me.DocumentProtectionRibbonPageGroup1, Me.DocumentCommentRibbonPageGroup1})
            Me.ReviewRibbonPage1.Name = "ReviewRibbonPage1"
            '
            'DocumentProofingRibbonPageGroup1
            '
            Me.DocumentProofingRibbonPageGroup1.ItemLinks.Add(Me.CheckSpellingItem1)
            Me.DocumentProofingRibbonPageGroup1.ItemLinks.Add(Me.ChangeLanguageItem1)
            Me.DocumentProofingRibbonPageGroup1.Name = "DocumentProofingRibbonPageGroup1"
            '
            'DocumentProtectionRibbonPageGroup1
            '
            Me.DocumentProtectionRibbonPageGroup1.ItemLinks.Add(Me.ProtectDocumentItem1)
            Me.DocumentProtectionRibbonPageGroup1.ItemLinks.Add(Me.ChangeRangeEditingPermissionsItem1)
            Me.DocumentProtectionRibbonPageGroup1.ItemLinks.Add(Me.UnprotectDocumentItem1)
            Me.DocumentProtectionRibbonPageGroup1.Name = "DocumentProtectionRibbonPageGroup1"
            '
            'DocumentCommentRibbonPageGroup1
            '
            Me.DocumentCommentRibbonPageGroup1.ItemLinks.Add(Me.ChangeCommentItem1)
            Me.DocumentCommentRibbonPageGroup1.ItemLinks.Add(Me.ReviewersItem1)
            Me.DocumentCommentRibbonPageGroup1.ItemLinks.Add(Me.ReviewingPaneItem1)
            Me.DocumentCommentRibbonPageGroup1.Name = "DocumentCommentRibbonPageGroup1"
            '
            'ReferencesRibbonPage1
            '
            Me.ReferencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TableOfContentsRibbonPageGroup1, Me.CaptionsRibbonPageGroup1})
            Me.ReferencesRibbonPage1.Name = "ReferencesRibbonPage1"
            '
            'TableOfContentsRibbonPageGroup1
            '
            Me.TableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableOfContentsItem1)
            Me.TableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.UpdateTableOfContentsItem1)
            Me.TableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.AddParagraphsToTableOfContentItem1)
            Me.TableOfContentsRibbonPageGroup1.Name = "TableOfContentsRibbonPageGroup1"
            '
            'CaptionsRibbonPageGroup1
            '
            Me.CaptionsRibbonPageGroup1.ItemLinks.Add(Me.InsertCaptionPlaceholderItem1)
            Me.CaptionsRibbonPageGroup1.ItemLinks.Add(Me.InsertTableOfFiguresPlaceholderItem1)
            Me.CaptionsRibbonPageGroup1.ItemLinks.Add(Me.UpdateTableOfContentsItem1)
            Me.CaptionsRibbonPageGroup1.Name = "CaptionsRibbonPageGroup1"
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.FileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.FileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.FileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.FileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.QuickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.PrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.PrintPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.UndoItem1)
            Me.richEditBarController1.BarItems.Add(Me.RedoItem1)
            Me.richEditBarController1.BarItems.Add(Me.PasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.CutItem1)
            Me.richEditBarController1.BarItems.Add(Me.CopyItem1)
            Me.richEditBarController1.BarItems.Add(Me.PasteSpecialItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.FontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.FontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.MakeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.MakeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.ClearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.DecreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.IncreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.AddSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.RemoveSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.AddSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.RemoveSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeParagraphBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.FindItem1)
            Me.richEditBarController1.BarItems.Add(Me.ReplaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.EditPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.EditPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTextBoxItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetNormalSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetNarrowSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetModerateSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetWideSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowPageMarginsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetPortraitPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetLandscapePageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeSectionPaperKindItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeSectionColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionOneColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionTwoColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionThreeColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowColumnsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertPageBreakItem2)
            Me.richEditBarController1.BarItems.Add(Me.InsertColumnBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakNextPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakEvenPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertSectionBreakOddPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeSectionLineNumberingItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingNoneItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingContinuousItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingRestartNewPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetSectionLineNumberingRestartNewSectionItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleParagraphSuppressLineNumbersItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowLineNumberingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleViewMergedDataItem1)
            Me.richEditBarController1.BarItems.Add(Me.SwitchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.SwitchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.SwitchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleShowHorizontalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleShowVerticalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.ZoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.ZoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.GoToPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.GoToPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.GoToNextHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.GoToPreviousHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleLinkToPreviousItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleDifferentFirstPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleDifferentOddAndEvenPagesItem1)
            Me.richEditBarController1.BarItems.Add(Me.ClosePageHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTableCellsShadingItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTableBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsBottomBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsTopBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsLeftBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsRightBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ResetTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsOutsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsInsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsInsideHorizontalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsInsideVerticalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleShowTableGridLinesItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTableBorderLineStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTableBorderLineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeTableBorderColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.SelectTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.SelectTableCellItem1)
            Me.richEditBarController1.BarItems.Add(Me.SelectTableColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.SelectTableRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.SelectTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowTablePropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.DeleteTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDeleteTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.DeleteTableColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.DeleteTableRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.DeleteTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableColumnToLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableColumnToRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowInsertTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.MergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowSplitTableCellsForm1)
            Me.richEditBarController1.BarItems.Add(Me.SplitTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableAutoFitItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableAutoFitContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableAutoFitWindowItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableFixedColumnWidthItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ToggleTableCellsBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.CheckSpellingItem1)
            Me.richEditBarController1.BarItems.Add(Me.ProtectDocumentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeRangeEditingPermissionsItem1)
            Me.richEditBarController1.BarItems.Add(Me.UnprotectDocumentItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.UpdateTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.AddParagraphsToTableOfContentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem2)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem3)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem4)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem5)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem6)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem7)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem8)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem9)
            Me.richEditBarController1.BarItems.Add(Me.SetParagraphHeadingLevelItem10)
            Me.richEditBarController1.BarItems.Add(Me.InsertCaptionPlaceholderItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertFiguresCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTablesCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.InsertEquationsCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableOfFiguresPlaceholderItem1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableOfFiguresItems1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableOfTablesItems1)
            Me.richEditBarController1.BarItems.Add(Me.InsertTableOfEquationsItems1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFloatingObjectFillColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFloatingObjectOutlineColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFloatingObjectOutlineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFloatingObjectTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectSquareTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectTightTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectThroughTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectTopAndBottomTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectBehindTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectInFrontOfTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeFloatingObjectAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.SetFloatingObjectBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectBringForwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectBringForwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectBringToFrontItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectBringInFrontOfTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectSendBackwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectSendBackwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectSendToBackItem1)
            Me.richEditBarController1.BarItems.Add(Me.FloatingObjectSendBehindTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowTableOptionsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangePageColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.GalleryChangeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeLanguageItem1)
            Me.richEditBarController1.BarItems.Add(Me.ChangeCommentItem1)
            Me.richEditBarController1.BarItems.Add(Me.ReviewersItem1)
            Me.richEditBarController1.BarItems.Add(Me.ReviewingPaneItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'ShowFontFormItem1
            '
            Me.ShowFontFormItem1.Id = -1
            Me.ShowFontFormItem1.Name = "ShowFontFormItem1"
            '
            'ShowParagraphFormItem1
            '
            Me.ShowParagraphFormItem1.Id = -1
            Me.ShowParagraphFormItem1.Name = "ShowParagraphFormItem1"
            '
            'ShowInsertTableCellsFormItem1
            '
            Me.ShowInsertTableCellsFormItem1.Id = -1
            Me.ShowInsertTableCellsFormItem1.Name = "ShowInsertTableCellsFormItem1"
            '
            'DockManager1
            '
            Me.DockManager1.Form = Me
            Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
            Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("4be568cd-1dc6-4a0e-8932-028a176500f4")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 142)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(400, 200)
            Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.SavedIndex = 0
            Me.DockPanel1.Size = New System.Drawing.Size(400, 247)
            Me.DockPanel1.Text = "Main document comments"
            Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.RichEditCommentControl1)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(392, 220)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'RichEditCommentControl1
            '
            Me.RichEditCommentControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.RichEditCommentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RichEditCommentControl1.Location = New System.Drawing.Point(0, 0)
            Me.RichEditCommentControl1.Name = "RichEditCommentControl1"
            Me.RichEditCommentControl1.ReadOnly = True
            Me.RichEditCommentControl1.RichEditControl = Me.richEditControl
            Me.RichEditCommentControl1.Size = New System.Drawing.Size(392, 220)
            Me.RichEditCommentControl1.TabIndex = 0
            '
            'RibbonModule
            '
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "RibbonModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage
        Private WithEvents richEditControl As RichEditControl
        Friend WithEvents FileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Friend WithEvents FileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Friend WithEvents FileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Friend WithEvents FileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Friend WithEvents QuickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Friend WithEvents PrintItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Friend WithEvents PrintPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Friend WithEvents UndoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Friend WithEvents RedoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Friend WithEvents PasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Friend WithEvents CutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Friend WithEvents CopyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Friend WithEvents PasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ChangeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Friend WithEvents RepositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Friend WithEvents ChangeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Friend WithEvents RepositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Friend WithEvents FontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Friend WithEvents FontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Friend WithEvents BarButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ToggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Friend WithEvents ToggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Friend WithEvents ToggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Friend WithEvents ToggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Friend WithEvents ToggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Friend WithEvents ToggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Friend WithEvents ToggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Friend WithEvents ToggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Friend WithEvents BarButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ChangeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Friend WithEvents ChangeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Friend WithEvents ChangeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Friend WithEvents MakeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Friend WithEvents MakeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Friend WithEvents ToggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Friend WithEvents ClearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Friend WithEvents BarButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ToggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Friend WithEvents ToggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Friend WithEvents ToggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Friend WithEvents BarButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents DecreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Friend WithEvents IncreaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Friend WithEvents ToggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Friend WithEvents BarButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ToggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Friend WithEvents ToggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Friend WithEvents ToggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Friend WithEvents ToggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Friend WithEvents BarButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Friend WithEvents ChangeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Friend WithEvents SetSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Friend WithEvents SetSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Friend WithEvents SetDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Friend WithEvents ShowLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Friend WithEvents AddSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Friend WithEvents RemoveSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Friend WithEvents AddSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Friend WithEvents RemoveSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Friend WithEvents ChangeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
        Friend WithEvents ChangeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Friend WithEvents RepositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Friend WithEvents FindItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Friend WithEvents ReplaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Friend WithEvents InsertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Friend WithEvents InsertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Friend WithEvents InsertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Friend WithEvents InsertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Friend WithEvents InsertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Friend WithEvents InsertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Friend WithEvents EditPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Friend WithEvents EditPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Friend WithEvents InsertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Friend WithEvents InsertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Friend WithEvents InsertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Friend WithEvents InsertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Friend WithEvents ChangeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Friend WithEvents SetNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Friend WithEvents SetNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Friend WithEvents SetModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Friend WithEvents SetWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
        Friend WithEvents ShowPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
        Friend WithEvents ChangeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Friend WithEvents SetPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
        Friend WithEvents SetLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
        Friend WithEvents ChangeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
        Friend WithEvents ChangeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
        Friend WithEvents SetSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
        Friend WithEvents SetSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
        Friend WithEvents SetSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
        Friend WithEvents ShowColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
        Friend WithEvents InsertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
        Friend WithEvents InsertPageBreakItem2 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Friend WithEvents InsertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
        Friend WithEvents InsertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Friend WithEvents InsertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Friend WithEvents InsertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Friend WithEvents ChangeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Friend WithEvents SetSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Friend WithEvents SetSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Friend WithEvents SetSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Friend WithEvents SetSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Friend WithEvents ToggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Friend WithEvents ShowLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
        Friend WithEvents InsertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Friend WithEvents ShowAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Friend WithEvents ShowAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Friend WithEvents ToggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Friend WithEvents SwitchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Friend WithEvents SwitchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Friend WithEvents SwitchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Friend WithEvents ToggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
        Friend WithEvents ToggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
        Friend WithEvents ZoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
        Friend WithEvents ZoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
        Friend WithEvents GoToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
        Friend WithEvents GoToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
        Friend WithEvents GoToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
        Friend WithEvents GoToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
        Friend WithEvents ToggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
        Friend WithEvents ToggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
        Friend WithEvents ToggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
        Friend WithEvents ClosePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
        Friend WithEvents ChangeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Friend WithEvents ChangeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Friend WithEvents ToggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Friend WithEvents ToggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Friend WithEvents ToggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Friend WithEvents ToggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Friend WithEvents ResetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Friend WithEvents ToggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Friend WithEvents ToggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Friend WithEvents ToggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Friend WithEvents ToggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Friend WithEvents ToggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Friend WithEvents ToggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Friend WithEvents ChangeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Friend WithEvents RepositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Friend WithEvents ChangeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Friend WithEvents RepositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Friend WithEvents ChangeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Friend WithEvents SelectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Friend WithEvents SelectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Friend WithEvents SelectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Friend WithEvents SelectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Friend WithEvents SelectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Friend WithEvents ShowTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Friend WithEvents DeleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Friend WithEvents ShowDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Friend WithEvents DeleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Friend WithEvents DeleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Friend WithEvents DeleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Friend WithEvents InsertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Friend WithEvents InsertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Friend WithEvents InsertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Friend WithEvents InsertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Friend WithEvents MergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Friend WithEvents ShowSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Friend WithEvents SplitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Friend WithEvents ToggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
        Friend WithEvents ToggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Friend WithEvents ToggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Friend WithEvents ToggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Friend WithEvents ToggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Friend WithEvents ToggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Friend WithEvents ToggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Friend WithEvents ToggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Friend WithEvents ToggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Friend WithEvents ToggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Friend WithEvents ToggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Friend WithEvents ToggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Friend WithEvents ToggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Friend WithEvents CheckSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
        Friend WithEvents ProtectDocumentItem1 As DevExpress.XtraRichEdit.UI.ProtectDocumentItem
        Friend WithEvents ChangeRangeEditingPermissionsItem1 As DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem
        Friend WithEvents UnprotectDocumentItem1 As DevExpress.XtraRichEdit.UI.UnprotectDocumentItem
        Friend WithEvents InsertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
        Friend WithEvents UpdateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
        Friend WithEvents AddParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
        Friend WithEvents SetParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents SetParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Friend WithEvents InsertCaptionPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem
        Friend WithEvents InsertFiguresCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems
        Friend WithEvents InsertTablesCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems
        Friend WithEvents InsertEquationsCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems
        Friend WithEvents InsertTableOfFiguresPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
        Friend WithEvents InsertTableOfFiguresItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems
        Friend WithEvents InsertTableOfTablesItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems
        Friend WithEvents InsertTableOfEquationsItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems
        Friend WithEvents ChangeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
        Friend WithEvents ChangeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
        Friend WithEvents ChangeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
        Friend WithEvents RepositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
        Friend WithEvents ChangeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
        Friend WithEvents SetFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
        Friend WithEvents SetFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
        Friend WithEvents SetFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
        Friend WithEvents SetFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
        Friend WithEvents SetFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
        Friend WithEvents SetFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
        Friend WithEvents ChangeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
        Friend WithEvents SetFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
        Friend WithEvents SetFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
        Friend WithEvents SetFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
        Friend WithEvents SetFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
        Friend WithEvents SetFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
        Friend WithEvents SetFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
        Friend WithEvents SetFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
        Friend WithEvents SetFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
        Friend WithEvents SetFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
        Friend WithEvents FloatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
        Friend WithEvents FloatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
        Friend WithEvents FloatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
        Friend WithEvents FloatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
        Friend WithEvents FloatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
        Friend WithEvents FloatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
        Friend WithEvents FloatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
        Friend WithEvents FloatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
        Friend WithEvents HeaderFooterToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory
        Friend WithEvents HeaderFooterToolsDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage
        Friend WithEvents HeaderFooterToolsDesignNavigationRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
        Friend WithEvents HeaderFooterToolsDesignOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
        Friend WithEvents HeaderFooterToolsDesignCloseRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup
        Friend WithEvents TableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
        Friend WithEvents TableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
        Friend WithEvents TableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
        Friend WithEvents TableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
        Friend WithEvents TableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
        Friend WithEvents TableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
        Friend WithEvents TableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
        Friend WithEvents TableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
        Friend WithEvents FloatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
        Friend WithEvents FloatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
        Friend WithEvents FloatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
        Friend WithEvents FloatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
        Friend WithEvents HomeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Friend WithEvents ClipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Friend WithEvents FontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Friend WithEvents ParagraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Friend WithEvents InsertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Friend WithEvents PagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Friend WithEvents TablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Friend WithEvents IllustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Friend WithEvents LinksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Friend WithEvents HeaderFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Friend WithEvents TextRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Friend WithEvents SymbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Friend WithEvents PageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
        Friend WithEvents PageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
        Friend WithEvents MailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Friend WithEvents MailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Friend WithEvents ViewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
        Friend WithEvents DocumentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
        Friend WithEvents ShowRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
        Friend WithEvents ZoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
        Friend WithEvents ReviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
        Friend WithEvents DocumentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
        Friend WithEvents DocumentProtectionRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup
        Friend WithEvents ReferencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
        Friend WithEvents TableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
        Friend WithEvents CaptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup
        Friend WithEvents ShowFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Friend WithEvents ShowParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Friend WithEvents ShowInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
        Friend WithEvents ShowTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
        Friend WithEvents TableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
        Friend WithEvents TableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
        Friend WithEvents ChangePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
        Friend WithEvents PageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
        Friend WithEvents GalleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
        Friend WithEvents StylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Friend WithEvents EditingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Friend WithEvents ChangeLanguageItem1 As DevExpress.XtraRichEdit.UI.ChangeLanguageItem
        Friend WithEvents ChangeCommentItem1 As DevExpress.XtraRichEdit.UI.ChangeCommentItem
        Friend WithEvents ReviewersItem1 As DevExpress.XtraRichEdit.UI.ReviewersItem
        Friend WithEvents ReviewingPaneItem1 As DevExpress.XtraRichEdit.UI.ReviewingPaneItem
        Friend WithEvents DocumentCommentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentCommentRibbonPageGroup
        Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents RichEditCommentControl1 As DevExpress.XtraRichEdit.RichEditCommentControl
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
    End Class
End Namespace
