﻿Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class WordModule
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WordModule))
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim ReduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem2 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            Me.showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
            Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            Me.changePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
            Me.insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            Me.updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            Me.addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            Me.setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.insertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
            Me.insertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
            Me.insertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
            Me.insertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
            Me.insertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
            Me.insertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
            Me.insertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
            Me.insertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
            Me.updateTableOfFiguresItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.changeLanguageItem1 = New DevExpress.XtraRichEdit.UI.ChangeLanguageItem()
            Me.protectDocumentItem1 = New DevExpress.XtraRichEdit.UI.ProtectDocumentItem()
            Me.changeRangeEditingPermissionsItem1 = New DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem()
            Me.unprotectDocumentItem1 = New DevExpress.XtraRichEdit.UI.UnprotectDocumentItem()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
            Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
            Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
            Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
            Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
            Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
            Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
            Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
            Me.toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
            Me.toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
            Me.toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
            Me.toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
            Me.toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
            Me.toggleBandedColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
            Me.galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            Me.changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            Me.changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            Me.changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            Me.setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            Me.setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            Me.setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            Me.setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            Me.changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            Me.setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            Me.setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            Me.setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            Me.setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            Me.setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            Me.setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            Me.setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            Me.setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            Me.setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            Me.floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            Me.floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            Me.floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            Me.floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            Me.floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            Me.floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            Me.floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            Me.floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            Me.headerFooterToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory()
            Me.headerFooterToolsDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage()
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup()
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup()
            Me.headerFooterToolsDesignCloseRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup()
            Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup()
            Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            Me.tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
            Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            Me.floatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
            Me.floatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
            Me.floatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
            Me.floatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
            Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            Me.pageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
            Me.referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            Me.tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            Me.captionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
            Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            Me.documentProtectionRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.insertPageBreakItem2 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.commonBar2 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.clipboardBar2 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.commonBar3 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.clipboardBar3 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.bottomDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.grid1 = New DevExpress.XtraGrid.GridControl()
            Me.view = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.clipboardBar4 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'stylesRibbonPageGroup1
            '
            Me.stylesRibbonPageGroup1.Glyph = CType(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            '
            'galleryChangeStyleItem1
            '
            '
            '
            '
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 61
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            '
            'commonBar1
            '
            Me.commonBar1.BarName = ""
            Me.commonBar1.Control = Nothing
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar1.FloatLocation = New System.Drawing.Point(291, 185)
            Me.commonBar1.Text = ""
            '
            'clipboardBar1
            '
            Me.clipboardBar1.BarName = ""
            Me.clipboardBar1.Control = Nothing
            Me.clipboardBar1.DockCol = 1
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(479, 182)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1)})
            Me.clipboardBar1.Text = ""
            '
            'cutItem1
            '
            Me.cutItem1.Id = 16
            Me.cutItem1.Name = "cutItem1"
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem2)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showPageMarginsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem2)
            Me.richEditBarController1.BarItems.Add(Me.insertColumnBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changePageColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.updateTableOfContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.addParagraphsToTableOfContentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem1)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem2)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem3)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem4)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem5)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem6)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem7)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem8)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem9)
            Me.richEditBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem10)
            Me.richEditBarController1.BarItems.Add(Me.insertCaptionPlaceholderItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFiguresCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.insertTablesCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.insertEquationsCaptionItems1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfFiguresPlaceholderItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfFiguresItems1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfTablesItems1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableOfEquationsItems1)
            Me.richEditBarController1.BarItems.Add(Me.updateTableOfFiguresItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.BarItems.Add(Me.checkSpellingItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeLanguageItem1)
            Me.richEditBarController1.BarItems.Add(Me.protectDocumentItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeRangeEditingPermissionsItem1)
            Me.richEditBarController1.BarItems.Add(Me.unprotectDocumentItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.richEditBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFirstRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleLastRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBandedRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFirstColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleLastColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBandedColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.galleryChangeTableStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.richEditBarController1.BarItems.Add(Me.splitTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.showTableOptionsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectFillColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectSquareTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTightTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectThroughTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBehindTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.setFloatingObjectBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringForwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringForwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringToFrontItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectBringInFrontOfTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBackwardItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendToBackItem1)
            Me.richEditBarController1.BarItems.Add(Me.floatingObjectSendBehindTextItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 1
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 2
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 3
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 4
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 5
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 6
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 7
            Me.printPreviewItem1.Name = "printPreviewItem1"
            '
            'undoItem1
            '
            Me.undoItem1.Id = 8
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Id = 9
            Me.redoItem1.Name = "redoItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Id = 17
            Me.pasteItem1.Name = "pasteItem1"
            '
            'cutItem2
            '
            Me.cutItem2.Id = 18
            Me.cutItem2.Name = "cutItem2"
            '
            'copyItem1
            '
            Me.copyItem1.Id = 19
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteSpecialItem1
            '
            Me.pasteSpecialItem1.Id = 20
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 21
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            '
            'repositoryItemFontEdit1
            '
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            '
            'changeFontSizeItem1
            '
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 22
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            '
            'repositoryItemRichEditFontSizeEdit1
            '
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            '
            'richEditControl
            '
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(168, 2)
            Me.richEditControl.MenuManager = Me.ribbonControl1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Comments.ShowAllAuthors = False
            Me.richEditControl.Options.Export.Rtf.ExportTheme = True
            Me.richEditControl.Size = New System.Drawing.Size(530, 555)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.pasteItem1, Me.cutItem2, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changePageColorItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.insertCaptionPlaceholderItem1, Me.insertFiguresCaptionItems1, Me.insertTablesCaptionItems1, Me.insertEquationsCaptionItems1, Me.insertTableOfFiguresPlaceholderItem1, Me.insertTableOfFiguresItems1, Me.insertTableOfTablesItems1, Me.insertTableOfEquationsItems1, Me.updateTableOfFiguresItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.checkSpellingItem1, Me.changeLanguageItem1, Me.protectDocumentItem1, Me.changeRangeEditingPermissionsItem1, Me.unprotectDocumentItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToNextHeaderFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.toggleFirstRowItem1, Me.toggleLastRowItem1, Me.toggleBandedRowsItem1, Me.toggleFirstColumnItem1, Me.toggleLastColumnItem1, Me.toggleBandedColumnItem1, Me.galleryChangeTableStyleItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableCellsShadingItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showTableOptionsFormItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 247
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.headerFooterToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.referencesRibbonPage1, Me.mailingsRibbonPage1, Me.reviewRibbonPage1, Me.viewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl1.Size = New System.Drawing.Size(700, 141)
            '
            'barButtonGroup1
            '
            Me.barButtonGroup1.Id = 10
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1, "FF")
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1, "FG")
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1, "FK")
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            '
            'fontSizeIncreaseItem1
            '
            Me.fontSizeIncreaseItem1.Id = 23
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            '
            'fontSizeDecreaseItem1
            '
            Me.fontSizeDecreaseItem1.Id = 24
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            '
            'barButtonGroup2
            '
            Me.barButtonGroup2.Id = 11
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            '
            'toggleFontBoldItem1
            '
            Me.toggleFontBoldItem1.Id = 25
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            '
            'toggleFontItalicItem1
            '
            Me.toggleFontItalicItem1.Id = 26
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            '
            'toggleFontUnderlineItem1
            '
            Me.toggleFontUnderlineItem1.Id = 27
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            '
            'toggleFontDoubleUnderlineItem1
            '
            Me.toggleFontDoubleUnderlineItem1.Id = 28
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            '
            'toggleFontStrikeoutItem1
            '
            Me.toggleFontStrikeoutItem1.Id = 29
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            '
            'toggleFontDoubleStrikeoutItem1
            '
            Me.toggleFontDoubleStrikeoutItem1.Id = 30
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            '
            'toggleFontSuperscriptItem1
            '
            Me.toggleFontSuperscriptItem1.Id = 31
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            '
            'toggleFontSubscriptItem1
            '
            Me.toggleFontSubscriptItem1.Id = 32
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            '
            'barButtonGroup3
            '
            Me.barButtonGroup3.Id = 12
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            '
            'changeFontColorItem1
            '
            Me.changeFontColorItem1.Id = 33
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            '
            'changeFontBackColorItem1
            '
            Me.changeFontBackColorItem1.Id = 34
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            '
            'changeTextCaseItem1
            '
            Me.changeTextCaseItem1.Id = 35
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            '
            'makeTextUpperCaseItem1
            '
            Me.makeTextUpperCaseItem1.Id = 36
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            '
            'makeTextLowerCaseItem1
            '
            Me.makeTextLowerCaseItem1.Id = 37
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            '
            'capitalizeEachWordCaseItem1
            '
            Me.capitalizeEachWordCaseItem1.Id = 38
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            '
            'toggleTextCaseItem1
            '
            Me.toggleTextCaseItem1.Id = 39
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            '
            'clearFormattingItem1
            '
            Me.clearFormattingItem1.Id = 40
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            '
            'barButtonGroup4
            '
            Me.barButtonGroup4.Id = 13
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1, "M")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            '
            'toggleBulletedListItem1
            '
            Me.toggleBulletedListItem1.Id = 41
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            '
            'toggleNumberingListItem1
            '
            Me.toggleNumberingListItem1.Id = 42
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            '
            'toggleMultiLevelListItem1
            '
            Me.toggleMultiLevelListItem1.Id = 43
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            '
            'barButtonGroup5
            '
            Me.barButtonGroup5.Id = 14
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            '
            'decreaseIndentItem1
            '
            Me.decreaseIndentItem1.Id = 44
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            '
            'increaseIndentItem1
            '
            Me.increaseIndentItem1.Id = 45
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            '
            'toggleShowWhitespaceItem1
            '
            Me.toggleShowWhitespaceItem1.Id = 50
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            '
            'barButtonGroup6
            '
            Me.barButtonGroup6.Id = 15
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1, "AJ")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            '
            'toggleParagraphAlignmentLeftItem1
            '
            Me.toggleParagraphAlignmentLeftItem1.Id = 46
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            '
            'toggleParagraphAlignmentCenterItem1
            '
            Me.toggleParagraphAlignmentCenterItem1.Id = 47
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            '
            'toggleParagraphAlignmentRightItem1
            '
            Me.toggleParagraphAlignmentRightItem1.Id = 48
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            '
            'toggleParagraphAlignmentJustifyItem1
            '
            Me.toggleParagraphAlignmentJustifyItem1.Id = 49
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            '
            'barButtonGroup7
            '
            Me.barButtonGroup7.Id = 16
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1, "K")
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            '
            'changeParagraphLineSpacingItem1
            '
            Me.changeParagraphLineSpacingItem1.Id = 51
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            '
            'setSingleParagraphSpacingItem1
            '
            Me.setSingleParagraphSpacingItem1.Id = 52
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            '
            'setSesquialteralParagraphSpacingItem1
            '
            Me.setSesquialteralParagraphSpacingItem1.Id = 53
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            '
            'setDoubleParagraphSpacingItem1
            '
            Me.setDoubleParagraphSpacingItem1.Id = 54
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            '
            'showLineSpacingFormItem1
            '
            Me.showLineSpacingFormItem1.Id = 55
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            '
            'addSpacingBeforeParagraphItem1
            '
            Me.addSpacingBeforeParagraphItem1.Id = 56
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            '
            'removeSpacingBeforeParagraphItem1
            '
            Me.removeSpacingBeforeParagraphItem1.Id = 57
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            '
            'addSpacingAfterParagraphItem1
            '
            Me.addSpacingAfterParagraphItem1.Id = 58
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            '
            'removeSpacingAfterParagraphItem1
            '
            Me.removeSpacingAfterParagraphItem1.Id = 59
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            '
            'changeParagraphBackColorItem1
            '
            Me.changeParagraphBackColorItem1.Id = 60
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            '
            'findItem1
            '
            Me.findItem1.Id = 62
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Id = 63
            Me.replaceItem1.Name = "replaceItem1"
            '
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Id = 64
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            '
            'insertTableItem1
            '
            Me.insertTableItem1.Id = 65
            Me.insertTableItem1.Name = "insertTableItem1"
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Id = 66
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Id = 67
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Id = 68
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Id = 69
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'editPageHeaderItem1
            '
            Me.editPageHeaderItem1.Id = 70
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            '
            'editPageFooterItem1
            '
            Me.editPageFooterItem1.Id = 71
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            '
            'insertPageNumberItem1
            '
            Me.insertPageNumberItem1.Id = 72
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            '
            'insertPageCountItem1
            '
            Me.insertPageCountItem1.Id = 73
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Id = 74
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Id = 75
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            '
            'changeSectionPageMarginsItem1
            '
            Me.changeSectionPageMarginsItem1.Id = 76
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1)})
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            '
            'setNormalSectionPageMarginsItem1
            '
            Me.setNormalSectionPageMarginsItem1.Id = 77
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            '
            'setNarrowSectionPageMarginsItem1
            '
            Me.setNarrowSectionPageMarginsItem1.Id = 78
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            '
            'setModerateSectionPageMarginsItem1
            '
            Me.setModerateSectionPageMarginsItem1.Id = 79
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            '
            'setWideSectionPageMarginsItem1
            '
            Me.setWideSectionPageMarginsItem1.Id = 80
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            '
            'showPageMarginsSetupFormItem1
            '
            Me.showPageMarginsSetupFormItem1.Id = 81
            Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            '
            'changeSectionPageOrientationItem1
            '
            Me.changeSectionPageOrientationItem1.Id = 82
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            '
            'setPortraitPageOrientationItem1
            '
            Me.setPortraitPageOrientationItem1.Id = 83
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            '
            'setLandscapePageOrientationItem1
            '
            Me.setLandscapePageOrientationItem1.Id = 84
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            '
            'changeSectionPaperKindItem1
            '
            Me.changeSectionPaperKindItem1.Id = 85
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            '
            'changeSectionColumnsItem1
            '
            Me.changeSectionColumnsItem1.Id = 86
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1)})
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            '
            'setSectionOneColumnItem1
            '
            Me.setSectionOneColumnItem1.Id = 87
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            '
            'setSectionTwoColumnsItem1
            '
            Me.setSectionTwoColumnsItem1.Id = 88
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            '
            'setSectionThreeColumnsItem1
            '
            Me.setSectionThreeColumnsItem1.Id = 89
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            '
            'showColumnsSetupFormItem1
            '
            Me.showColumnsSetupFormItem1.Id = 90
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            '
            'insertBreakItem1
            '
            Me.insertBreakItem1.Id = 91
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.insertPageBreakItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
            Me.insertBreakItem1.Name = "insertBreakItem1"
            '
            'insertColumnBreakItem1
            '
            Me.insertColumnBreakItem1.Id = 92
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            '
            'insertSectionBreakNextPageItem1
            '
            Me.insertSectionBreakNextPageItem1.Id = 93
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            '
            'insertSectionBreakEvenPageItem1
            '
            Me.insertSectionBreakEvenPageItem1.Id = 94
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            '
            'insertSectionBreakOddPageItem1
            '
            Me.insertSectionBreakOddPageItem1.Id = 95
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            '
            'changeSectionLineNumberingItem1
            '
            Me.changeSectionLineNumberingItem1.Id = 96
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1)})
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            '
            'setSectionLineNumberingNoneItem1
            '
            Me.setSectionLineNumberingNoneItem1.Id = 97
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            '
            'setSectionLineNumberingContinuousItem1
            '
            Me.setSectionLineNumberingContinuousItem1.Id = 98
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            '
            'setSectionLineNumberingRestartNewPageItem1
            '
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 99
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            '
            'setSectionLineNumberingRestartNewSectionItem1
            '
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 100
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            '
            'toggleParagraphSuppressLineNumbersItem1
            '
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 101
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            '
            'showLineNumberingFormItem1
            '
            Me.showLineNumberingFormItem1.Id = 102
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            '
            'changePageColorItem1
            '
            Me.changePageColorItem1.Id = 103
            Me.changePageColorItem1.Name = "changePageColorItem1"
            '
            'insertTableOfContentsItem1
            '
            Me.insertTableOfContentsItem1.Id = 104
            Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            '
            'updateTableOfContentsItem1
            '
            Me.updateTableOfContentsItem1.Id = 105
            Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            '
            'addParagraphsToTableOfContentItem1
            '
            Me.addParagraphsToTableOfContentItem1.Id = 106
            Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10)})
            Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            '
            'setParagraphHeadingLevelItem1
            '
            Me.setParagraphHeadingLevelItem1.Id = 107
            Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
            '
            'setParagraphHeadingLevelItem2
            '
            Me.setParagraphHeadingLevelItem2.Id = 108
            Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
            '
            'setParagraphHeadingLevelItem3
            '
            Me.setParagraphHeadingLevelItem3.Id = 109
            Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
            '
            'setParagraphHeadingLevelItem4
            '
            Me.setParagraphHeadingLevelItem4.Id = 110
            Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
            '
            'setParagraphHeadingLevelItem5
            '
            Me.setParagraphHeadingLevelItem5.Id = 111
            Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
            '
            'setParagraphHeadingLevelItem6
            '
            Me.setParagraphHeadingLevelItem6.Id = 112
            Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
            '
            'setParagraphHeadingLevelItem7
            '
            Me.setParagraphHeadingLevelItem7.Id = 113
            Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
            '
            'setParagraphHeadingLevelItem8
            '
            Me.setParagraphHeadingLevelItem8.Id = 114
            Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
            '
            'setParagraphHeadingLevelItem9
            '
            Me.setParagraphHeadingLevelItem9.Id = 115
            Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
            '
            'setParagraphHeadingLevelItem10
            '
            Me.setParagraphHeadingLevelItem10.Id = 116
            Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
            '
            'insertCaptionPlaceholderItem1
            '
            Me.insertCaptionPlaceholderItem1.Id = 117
            Me.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertFiguresCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTablesCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertEquationsCaptionItems1)})
            Me.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
            '
            'insertFiguresCaptionItems1
            '
            Me.insertFiguresCaptionItems1.Id = 118
            Me.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
            '
            'insertTablesCaptionItems1
            '
            Me.insertTablesCaptionItems1.Id = 119
            Me.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
            '
            'insertEquationsCaptionItems1
            '
            Me.insertEquationsCaptionItems1.Id = 120
            Me.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
            '
            'insertTableOfFiguresPlaceholderItem1
            '
            Me.insertTableOfFiguresPlaceholderItem1.Id = 121
            Me.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfFiguresItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfTablesItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfEquationsItems1)})
            Me.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
            '
            'insertTableOfFiguresItems1
            '
            Me.insertTableOfFiguresItems1.Id = 122
            Me.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
            '
            'insertTableOfTablesItems1
            '
            Me.insertTableOfTablesItems1.Id = 123
            Me.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
            '
            'insertTableOfEquationsItems1
            '
            Me.insertTableOfEquationsItems1.Id = 124
            Me.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
            '
            'updateTableOfFiguresItem1
            '
            Me.updateTableOfFiguresItem1.Id = 125
            Me.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
            '
            'insertMergeFieldItem1
            '
            Me.insertMergeFieldItem1.Id = 126
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            '
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 127
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 128
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'toggleViewMergedDataItem1
            '
            Me.toggleViewMergedDataItem1.Id = 129
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            '
            'checkSpellingItem1
            '
            Me.checkSpellingItem1.Id = 130
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            '
            'changeLanguageItem1
            '
            Me.changeLanguageItem1.Id = 131
            Me.changeLanguageItem1.Name = "changeLanguageItem1"
            '
            'protectDocumentItem1
            '
            Me.protectDocumentItem1.Id = 132
            Me.protectDocumentItem1.Name = "protectDocumentItem1"
            '
            'changeRangeEditingPermissionsItem1
            '
            Me.changeRangeEditingPermissionsItem1.Id = 133
            Me.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1"
            '
            'unprotectDocumentItem1
            '
            Me.unprotectDocumentItem1.Id = 134
            Me.unprotectDocumentItem1.Name = "unprotectDocumentItem1"
            '
            'switchToSimpleViewItem1
            '
            Me.switchToSimpleViewItem1.Id = 135
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            '
            'switchToDraftViewItem1
            '
            Me.switchToDraftViewItem1.Id = 136
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            '
            'switchToPrintLayoutViewItem1
            '
            Me.switchToPrintLayoutViewItem1.Id = 137
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            '
            'toggleShowHorizontalRulerItem1
            '
            Me.toggleShowHorizontalRulerItem1.Id = 138
            Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            '
            'toggleShowVerticalRulerItem1
            '
            Me.toggleShowVerticalRulerItem1.Id = 139
            Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            '
            'zoomOutItem1
            '
            Me.zoomOutItem1.Id = 140
            Me.zoomOutItem1.Name = "zoomOutItem1"
            '
            'zoomInItem1
            '
            Me.zoomInItem1.Id = 141
            Me.zoomInItem1.Name = "zoomInItem1"
            '
            'goToPageHeaderItem1
            '
            Me.goToPageHeaderItem1.Id = 142
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            '
            'goToPageFooterItem1
            '
            Me.goToPageFooterItem1.Id = 143
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            '
            'goToNextHeaderFooterItem1
            '
            Me.goToNextHeaderFooterItem1.Id = 144
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            '
            'goToPreviousHeaderFooterItem1
            '
            Me.goToPreviousHeaderFooterItem1.Id = 145
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            '
            'toggleLinkToPreviousItem1
            '
            Me.toggleLinkToPreviousItem1.Id = 146
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            '
            'toggleDifferentFirstPageItem1
            '
            Me.toggleDifferentFirstPageItem1.Id = 147
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            '
            'toggleDifferentOddAndEvenPagesItem1
            '
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 148
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            '
            'closePageHeaderFooterItem1
            '
            Me.closePageHeaderFooterItem1.Id = 149
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            '
            'toggleFirstRowItem1
            '
            Me.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstRowItem1.Id = 150
            Me.toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            '
            'toggleLastRowItem1
            '
            Me.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastRowItem1.Id = 151
            Me.toggleLastRowItem1.Name = "toggleLastRowItem1"
            '
            'toggleBandedRowsItem1
            '
            Me.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedRowsItem1.Id = 152
            Me.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            '
            'toggleFirstColumnItem1
            '
            Me.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstColumnItem1.Id = 153
            Me.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            '
            'toggleLastColumnItem1
            '
            Me.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastColumnItem1.Id = 154
            Me.toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            '
            'toggleBandedColumnItem1
            '
            Me.toggleBandedColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedColumnItem1.Id = 155
            Me.toggleBandedColumnItem1.Name = "toggleBandedColumnItem1"
            '
            'galleryChangeTableStyleItem1
            '
            Me.galleryChangeTableStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableStyleItem1.DeleteItemLink = Nothing
            '
            '
            '
            Me.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup2})
            Me.galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableStyleItem1.Id = 156
            Me.galleryChangeTableStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            Me.galleryChangeTableStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableStyleItem1.PopupGallery = Nothing
            '
            'changeTableBorderLineStyleItem1
            '
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            Me.changeTableBorderLineStyleItem1.EditWidth = 130
            Me.changeTableBorderLineStyleItem1.Id = 157
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            '
            'repositoryItemBorderLineStyle1
            '
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            '
            'changeTableBorderLineWeightItem1
            '
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.EditWidth = 130
            Me.changeTableBorderLineWeightItem1.Id = 158
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            '
            'repositoryItemBorderLineWeight1
            '
            Me.repositoryItemBorderLineWeight1.AutoHeight = False
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineWeight1.Control = Me.richEditControl
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            '
            'changeTableBorderColorItem1
            '
            Me.changeTableBorderColorItem1.Id = 159
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            '
            'changeTableBordersItem1
            '
            Me.changeTableBordersItem1.Id = 160
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.toggleShowTableGridLinesItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "TG", "")})
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            '
            'toggleTableCellsBottomBorderItem1
            '
            Me.toggleTableCellsBottomBorderItem1.Id = 161
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            '
            'toggleTableCellsTopBorderItem1
            '
            Me.toggleTableCellsTopBorderItem1.Id = 162
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            '
            'toggleTableCellsLeftBorderItem1
            '
            Me.toggleTableCellsLeftBorderItem1.Id = 163
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            '
            'toggleTableCellsRightBorderItem1
            '
            Me.toggleTableCellsRightBorderItem1.Id = 164
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            '
            'resetTableCellsAllBordersItem1
            '
            Me.resetTableCellsAllBordersItem1.Id = 165
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            '
            'toggleTableCellsAllBordersItem1
            '
            Me.toggleTableCellsAllBordersItem1.Id = 166
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            '
            'toggleTableCellsOutsideBorderItem1
            '
            Me.toggleTableCellsOutsideBorderItem1.Id = 167
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            '
            'toggleTableCellsInsideBorderItem1
            '
            Me.toggleTableCellsInsideBorderItem1.Id = 168
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            '
            'toggleTableCellsInsideHorizontalBorderItem1
            '
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 169
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            '
            'toggleTableCellsInsideVerticalBorderItem1
            '
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 170
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            '
            'toggleShowTableGridLinesItem1
            '
            Me.toggleShowTableGridLinesItem1.Id = 171
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            '
            'changeTableCellsShadingItem1
            '
            Me.changeTableCellsShadingItem1.Id = 172
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            '
            'selectTableElementsItem1
            '
            Me.selectTableElementsItem1.Id = 173
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)})
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            '
            'selectTableCellItem1
            '
            Me.selectTableCellItem1.Id = 174
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            '
            'selectTableColumnItem1
            '
            Me.selectTableColumnItem1.Id = 175
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            '
            'selectTableRowItem1
            '
            Me.selectTableRowItem1.Id = 176
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            '
            'selectTableItem1
            '
            Me.selectTableItem1.Id = 177
            Me.selectTableItem1.Name = "selectTableItem1"
            '
            'showTablePropertiesFormItem1
            '
            Me.showTablePropertiesFormItem1.Id = 178
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            '
            'deleteTableElementsItem1
            '
            Me.deleteTableElementsItem1.Id = 179
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)})
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            '
            'showDeleteTableCellsFormItem1
            '
            Me.showDeleteTableCellsFormItem1.Id = 180
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            '
            'deleteTableColumnsItem1
            '
            Me.deleteTableColumnsItem1.Id = 181
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            '
            'deleteTableRowsItem1
            '
            Me.deleteTableRowsItem1.Id = 182
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            '
            'deleteTableItem1
            '
            Me.deleteTableItem1.Id = 183
            Me.deleteTableItem1.Name = "deleteTableItem1"
            '
            'insertTableRowAboveItem1
            '
            Me.insertTableRowAboveItem1.Id = 184
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            '
            'insertTableRowBelowItem1
            '
            Me.insertTableRowBelowItem1.Id = 185
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            '
            'insertTableColumnToLeftItem1
            '
            Me.insertTableColumnToLeftItem1.Id = 186
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            '
            'insertTableColumnToRightItem1
            '
            Me.insertTableColumnToRightItem1.Id = 187
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            '
            'mergeTableCellsItem1
            '
            Me.mergeTableCellsItem1.Id = 188
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            '
            'showSplitTableCellsForm1
            '
            Me.showSplitTableCellsForm1.Id = 189
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            '
            'splitTableItem1
            '
            Me.splitTableItem1.Id = 190
            Me.splitTableItem1.Name = "splitTableItem1"
            '
            'toggleTableAutoFitItem1
            '
            Me.toggleTableAutoFitItem1.Id = 191
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)})
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            '
            'toggleTableAutoFitContentsItem1
            '
            Me.toggleTableAutoFitContentsItem1.Id = 192
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            '
            'toggleTableAutoFitWindowItem1
            '
            Me.toggleTableAutoFitWindowItem1.Id = 193
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            '
            'toggleTableFixedColumnWidthItem1
            '
            Me.toggleTableFixedColumnWidthItem1.Id = 194
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            '
            'toggleTableCellsTopLeftAlignmentItem1
            '
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 195
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            '
            'toggleTableCellsMiddleLeftAlignmentItem1
            '
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 196
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            '
            'toggleTableCellsBottomLeftAlignmentItem1
            '
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 197
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            '
            'toggleTableCellsTopCenterAlignmentItem1
            '
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 198
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            '
            'toggleTableCellsMiddleCenterAlignmentItem1
            '
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 199
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            '
            'toggleTableCellsBottomCenterAlignmentItem1
            '
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 200
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            '
            'toggleTableCellsTopRightAlignmentItem1
            '
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 201
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            '
            'toggleTableCellsMiddleRightAlignmentItem1
            '
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 202
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            '
            'toggleTableCellsBottomRightAlignmentItem1
            '
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 203
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            '
            'showTableOptionsFormItem1
            '
            Me.showTableOptionsFormItem1.Id = 204
            Me.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            '
            'changeFloatingObjectFillColorItem1
            '
            Me.changeFloatingObjectFillColorItem1.Id = 205
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            '
            'changeFloatingObjectOutlineColorItem1
            '
            Me.changeFloatingObjectOutlineColorItem1.Id = 206
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            '
            'changeFloatingObjectOutlineWeightItem1
            '
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 207
            Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            '
            'repositoryItemFloatingObjectOutlineWeight1
            '
            Me.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.richEditControl
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            '
            'changeFloatingObjectTextWrapTypeItem1
            '
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 208
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)})
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            '
            'setFloatingObjectSquareTextWrapTypeItem1
            '
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 209
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            '
            'setFloatingObjectTightTextWrapTypeItem1
            '
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 210
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            '
            'setFloatingObjectThroughTextWrapTypeItem1
            '
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 211
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            '
            'setFloatingObjectTopAndBottomTextWrapTypeItem1
            '
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 212
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            '
            'setFloatingObjectBehindTextWrapTypeItem1
            '
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 213
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            '
            'setFloatingObjectInFrontOfTextWrapTypeItem1
            '
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 214
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            '
            'changeFloatingObjectAlignmentItem1
            '
            Me.changeFloatingObjectAlignmentItem1.Id = 215
            Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1)})
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            '
            'setFloatingObjectTopLeftAlignmentItem1
            '
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 216
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            '
            'setFloatingObjectTopCenterAlignmentItem1
            '
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 217
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            '
            'setFloatingObjectTopRightAlignmentItem1
            '
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 218
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            '
            'setFloatingObjectMiddleLeftAlignmentItem1
            '
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 219
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            '
            'setFloatingObjectMiddleCenterAlignmentItem1
            '
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 220
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            '
            'setFloatingObjectMiddleRightAlignmentItem1
            '
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 221
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            '
            'setFloatingObjectBottomLeftAlignmentItem1
            '
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 222
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            '
            'setFloatingObjectBottomCenterAlignmentItem1
            '
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 223
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            '
            'setFloatingObjectBottomRightAlignmentItem1
            '
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 224
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            '
            'floatingObjectBringForwardSubItem1
            '
            Me.floatingObjectBringForwardSubItem1.Id = 225
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1)})
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            '
            'floatingObjectBringForwardItem1
            '
            Me.floatingObjectBringForwardItem1.Id = 226
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            '
            'floatingObjectBringToFrontItem1
            '
            Me.floatingObjectBringToFrontItem1.Id = 227
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            '
            'floatingObjectBringInFrontOfTextItem1
            '
            Me.floatingObjectBringInFrontOfTextItem1.Id = 228
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            '
            'floatingObjectSendBackwardSubItem1
            '
            Me.floatingObjectSendBackwardSubItem1.Id = 229
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1)})
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            '
            'floatingObjectSendBackwardItem1
            '
            Me.floatingObjectSendBackwardItem1.Id = 230
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            '
            'floatingObjectSendToBackItem1
            '
            Me.floatingObjectSendToBackItem1.Id = 231
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            '
            'floatingObjectSendBehindTextItem1
            '
            Me.floatingObjectSendBehindTextItem1.Id = 232
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            '
            'headerFooterToolsRibbonPageCategory1
            '
            Me.headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.headerFooterToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1"
            Me.headerFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.headerFooterToolsDesignRibbonPage1})
            '
            'headerFooterToolsDesignRibbonPage1
            '
            Me.headerFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.headerFooterToolsDesignNavigationRibbonPageGroup1, Me.headerFooterToolsDesignOptionsRibbonPageGroup1, Me.headerFooterToolsDesignCloseRibbonPageGroup1})
            Me.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1"
            '
            'headerFooterToolsDesignNavigationRibbonPageGroup1
            '
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageHeaderItem1, "E")
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageFooterItem1, "G")
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToNextHeaderFooterItem1, "X")
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPreviousHeaderFooterItem1, "R")
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.toggleLinkToPreviousItem1, "K")
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1"
            '
            'headerFooterToolsDesignOptionsRibbonPageGroup1
            '
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentFirstPageItem1, "A")
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentOddAndEvenPagesItem1, "V")
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1"
            '
            'headerFooterToolsDesignCloseRibbonPageGroup1
            '
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(Me.closePageHeaderFooterItem1, "C")
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1"
            '
            'tableToolsRibbonPageCategory1
            '
            Me.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tableToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
            '
            'tableDesignRibbonPage1
            '
            Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
            Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            '
            'tableStyleOptionsRibbonPageGroup1
            '
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstRowItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastRowItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedRowsItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleFirstColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleLastColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleBandedColumnItem1)
            Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
            '
            'tableStylesRibbonPageGroup1
            '
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeTableStyleItem1)
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            '
            'tableDrawBordersRibbonPageGroup1
            '
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1, "C")
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1, "B")
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1, "H")
            Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            '
            'tableLayoutRibbonPage1
            '
            Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
            Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            '
            'tableTableRibbonPageGroup1
            '
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1, "K")
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1, "TG")
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1, "O")
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            '
            'tableRowsAndColumnsRibbonPageGroup1
            '
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1, "D")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1, "A")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1, "E")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1, "L")
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1, "R")
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            '
            'tableMergeRibbonPageGroup1
            '
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1, "M")
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1, "P")
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1, "Q")
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            '
            'tableCellSizeRibbonPageGroup1
            '
            Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1, "F")
            Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            '
            'tableAlignmentRibbonPageGroup1
            '
            Me.tableAlignmentRibbonPageGroup1.Glyph = CType(resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1, "TL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1, "CL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1, "BL")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1, "TC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1, "CC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1, "BC")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1, "TR")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1, "CR")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1, "BR")
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.showTableOptionsFormItem1, "N")
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            '
            'floatingPictureToolsRibbonPageCategory1
            '
            Me.floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.floatingPictureToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
            Me.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.floatingPictureToolsFormatPage1})
            '
            'floatingPictureToolsFormatPage1
            '
            Me.floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.floatingPictureToolsShapeStylesPageGroup1, Me.floatingPictureToolsArrangePageGroup1})
            Me.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
            '
            'floatingPictureToolsShapeStylesPageGroup1
            '
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectFillColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1"
            '
            'floatingPictureToolsArrangePageGroup1
            '
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1, "TW")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1, "PO")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1, "AF")
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1, "AE")
            Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            '
            'FileRibbonPage1
            '
            Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.InfoRibbonPageGroup1})
            Me.FileRibbonPage1.Name = "FileRibbonPage1"
            '
            'CommonRibbonPageGroup1
            '
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1, "N")
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1, "O")
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1, "S")
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1, "A")
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.printItem1, "P")
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
            '
            'homeRibbonPage1
            '
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            ReduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            ReduceOperation1.Group = Me.stylesRibbonPageGroup1
            ReduceOperation1.ItemLinkIndex = 0
            ReduceOperation1.ItemLinksCount = 0
            ReduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(ReduceOperation1)
            '
            'clipboardRibbonPageGroup1
            '
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1, "V")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem2, "X")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1, "C")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            '
            'fontRibbonPageGroup1
            '
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1, "E")
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            '
            'paragraphRibbonPageGroup1
            '
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            '
            'editingRibbonPageGroup1
            '
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1, "FD")
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1, "R")
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            '
            'insertRibbonPage1
            '
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            '
            'pagesRibbonPageGroup1
            '
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1, "B")
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            '
            'tablesRibbonPageGroup1
            '
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1, "T")
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            '
            'illustrationsRibbonPageGroup1
            '
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1, "P")
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            '
            'linksRibbonPageGroup1
            '
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1, "K")
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1, "I")
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            '
            'headerFooterRibbonPageGroup1
            '
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1, "H")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1, "O")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1, "NU")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            '
            'textRibbonPageGroup1
            '
            Me.textRibbonPageGroup1.Glyph = CType(resources.GetObject("textRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1, "X")
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            '
            'symbolsRibbonPageGroup1
            '
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1, "U")
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            '
            'pageLayoutRibbonPage1
            '
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pageSetupRibbonPageGroup1, Me.pageBackgroundRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            '
            'pageSetupRibbonPageGroup1
            '
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1, "M")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1, "O")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1, "SZ")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1, "J")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1, "B")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1, "LN")
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            '
            'pageBackgroundRibbonPageGroup1
            '
            Me.pageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.changePageColorItem1, "PC")
            Me.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
            '
            'referencesRibbonPage1
            '
            Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableOfContentsRibbonPageGroup1, Me.captionsRibbonPageGroup1})
            Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
            '
            'tableOfContentsRibbonPageGroup1
            '
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1, "T")
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1, "U")
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1, "A")
            Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            '
            'captionsRibbonPageGroup1
            '
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertCaptionPlaceholderItem1, "C")
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfFiguresPlaceholderItem1, "G")
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfFiguresItem1, "V")
            Me.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1"
            '
            'mailingsRibbonPage1
            '
            Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeRibbonPageGroup1})
            Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            '
            'mailMergeRibbonPageGroup1
            '
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1, "P")
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            '
            'reviewRibbonPage1
            '
            Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.documentProofingRibbonPageGroup1, Me.documentProtectionRibbonPageGroup1})
            Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
            '
            'documentProofingRibbonPageGroup1
            '
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1, "S")
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.changeLanguageItem1)
            Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
            '
            'documentProtectionRibbonPageGroup1
            '
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.protectDocumentItem1)
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.changeRangeEditingPermissionsItem1)
            Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.unprotectDocumentItem1)
            Me.documentProtectionRibbonPageGroup1.Name = "documentProtectionRibbonPageGroup1"
            '
            'viewRibbonPage1
            '
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            '
            'documentViewsRibbonPageGroup1
            '
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1, "L")
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1, "E")
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1, "P")
            Me.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
            '
            'showRibbonPageGroup1
            '
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowHorizontalRulerItem1)
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowVerticalRulerItem1)
            Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            '
            'zoomRibbonPageGroup1
            '
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
            Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            '
            'insertPageBreakItem2
            '
            Me.insertPageBreakItem2.Id = -1
            Me.insertPageBreakItem2.Name = "insertPageBreakItem2"
            '
            'commonBar2
            '
            Me.commonBar2.BarName = ""
            Me.commonBar2.Control = Nothing
            Me.commonBar2.DockCol = 0
            Me.commonBar2.DockRow = 0
            Me.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar2.FloatLocation = New System.Drawing.Point(291, 185)
            Me.commonBar2.Text = ""
            '
            'clipboardBar2
            '
            Me.clipboardBar2.BarName = ""
            Me.clipboardBar2.Control = Nothing
            Me.clipboardBar2.DockCol = 1
            Me.clipboardBar2.DockRow = 0
            Me.clipboardBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar2.FloatLocation = New System.Drawing.Point(479, 182)
            Me.clipboardBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1)})
            Me.clipboardBar2.Text = ""
            '
            'commonBar3
            '
            Me.commonBar3.BarName = ""
            Me.commonBar3.Control = Nothing
            Me.commonBar3.DockCol = 0
            Me.commonBar3.DockRow = 0
            Me.commonBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar3.FloatLocation = New System.Drawing.Point(291, 185)
            Me.commonBar3.Text = ""
            '
            'clipboardBar3
            '
            Me.clipboardBar3.BarName = ""
            Me.clipboardBar3.Control = Nothing
            Me.clipboardBar3.DockCol = 1
            Me.clipboardBar3.DockRow = 0
            Me.clipboardBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar3.FloatLocation = New System.Drawing.Point(479, 182)
            Me.clipboardBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1)})
            Me.clipboardBar3.Text = ""
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.bottomDockArea)
            Me.panelControl1.Controls.Add(Me.grid1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 141)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(700, 559)
            Me.panelControl1.TabIndex = 5
            '
            'bottomDockArea
            '
            Me.bottomDockArea.AutoSize = True
            Me.bottomDockArea.CausesValidation = False
            Me.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bottomDockArea.Location = New System.Drawing.Point(168, 557)
            Me.bottomDockArea.Manager = Nothing
            Me.bottomDockArea.Name = "bottomDockArea"
            Me.bottomDockArea.Size = New System.Drawing.Size(530, 0)
            Me.bottomDockArea.Text = "standaloneBarDockControl2"
            '
            'grid1
            '
            Me.grid1.Dock = System.Windows.Forms.DockStyle.Left
            Me.grid1.Location = New System.Drawing.Point(2, 2)
            Me.grid1.MainView = Me.view
            Me.grid1.MenuManager = Me.ribbonControl1
            Me.grid1.Name = "grid1"
            Me.grid1.Size = New System.Drawing.Size(166, 555)
            Me.grid1.TabIndex = 3
            Me.grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.view})
            '
            'view
            '
            Me.view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFullName})
            Me.view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.view.GridControl = Me.grid1
            Me.view.Name = "view"
            Me.view.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.view.OptionsBehavior.Editable = False
            Me.view.OptionsCustomization.AllowColumnMoving = False
            Me.view.OptionsCustomization.AllowColumnResizing = False
            Me.view.OptionsCustomization.AllowFilter = False
            Me.view.OptionsCustomization.AllowGroup = False
            Me.view.OptionsCustomization.AllowQuickHideColumns = False
            Me.view.OptionsDetail.EnableMasterViewMode = False
            Me.view.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.view.OptionsSelection.EnableAppearanceHideSelection = False
            Me.view.OptionsView.ShowGroupPanel = False
            '
            'colFullName
            '
            Me.colFullName.FieldName = "FullName"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 0
            '
            'clipboardBar4
            '
            Me.clipboardBar4.BarName = ""
            Me.clipboardBar4.Control = Me.richEditControl
            Me.clipboardBar4.DockCol = 1
            Me.clipboardBar4.DockRow = 0
            Me.clipboardBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar4.FloatLocation = New System.Drawing.Point(388, 178)
            Me.clipboardBar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1)})
            Me.clipboardBar4.Text = ""
            '
            'InfoRibbonPageGroup1
            '
            Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 246
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'WordModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "WordModule"
            Me.Size = New System.Drawing.Size(700, 700)
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private commonBar1 As XtraRichEdit.UI.CommonBar
        Private clipboardBar1 As XtraRichEdit.UI.ClipboardBar
        Private cutItem1 As XtraRichEdit.UI.CutItem
        Private richEditBarController1 As XtraRichEdit.UI.RichEditBarController
        Private commonBar2 As XtraRichEdit.UI.CommonBar
        Private clipboardBar2 As XtraRichEdit.UI.ClipboardBar
        Private commonBar3 As XtraRichEdit.UI.CommonBar
        Private clipboardBar3 As XtraRichEdit.UI.ClipboardBar
        Private WithEvents richEditControl As XtraRichEdit.RichEditControl
        Private panelControl1 As XtraEditors.PanelControl
        Private bottomDockArea As XtraBars.StandaloneBarDockControl
        Private clipboardBar4 As XtraRichEdit.UI.ClipboardBar
        Private fileNewItem1 As XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As XtraRichEdit.UI.FileSaveAsItem
        Private quickPrintItem1 As XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As XtraRichEdit.UI.UndoItem
        Private redoItem1 As XtraRichEdit.UI.RedoItem
        Private pasteItem1 As XtraRichEdit.UI.PasteItem
        Private cutItem2 As XtraRichEdit.UI.CutItem
        Private copyItem1 As XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As XtraRichEdit.UI.PasteSpecialItem
        Private changeFontNameItem1 As XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private barButtonGroup1 As XtraBars.BarButtonGroup
        Private fontSizeIncreaseItem1 As XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As XtraRichEdit.UI.FontSizeDecreaseItem
        Private barButtonGroup2 As XtraBars.BarButtonGroup
        Private toggleFontBoldItem1 As XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As XtraRichEdit.UI.ToggleFontSubscriptItem
        Private barButtonGroup3 As XtraBars.BarButtonGroup
        Private changeFontColorItem1 As XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As XtraRichEdit.UI.ChangeFontBackColorItem
        Private changeTextCaseItem1 As XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As XtraRichEdit.UI.MakeTextLowerCaseItem
        Private capitalizeEachWordCaseItem1 As XtraRichEdit.UI.CapitalizeEachWordCaseItem
        Private toggleTextCaseItem1 As XtraRichEdit.UI.ToggleTextCaseItem
        Private clearFormattingItem1 As XtraRichEdit.UI.ClearFormattingItem
        Private barButtonGroup4 As XtraBars.BarButtonGroup
        Private toggleBulletedListItem1 As XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As XtraRichEdit.UI.ToggleMultiLevelListItem
        Private barButtonGroup5 As XtraBars.BarButtonGroup
        Private decreaseIndentItem1 As XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private barButtonGroup6 As XtraBars.BarButtonGroup
        Private toggleParagraphAlignmentLeftItem1 As XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private barButtonGroup7 As XtraBars.BarButtonGroup
        Private changeParagraphLineSpacingItem1 As XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private changeParagraphBackColorItem1 As XtraRichEdit.UI.ChangeParagraphBackColorItem
        Private galleryChangeStyleItem1 As XtraRichEdit.UI.GalleryChangeStyleItem
        Private findItem1 As XtraRichEdit.UI.FindItem
        Private replaceItem1 As XtraRichEdit.UI.ReplaceItem
        Private insertPageBreakItem1 As XtraRichEdit.UI.InsertPageBreakItem
        Private insertTableItem1 As XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As XtraRichEdit.UI.InsertFloatingPictureItem
        Private insertBookmarkItem1 As XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As XtraRichEdit.UI.InsertHyperlinkItem
        Private editPageHeaderItem1 As XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As XtraRichEdit.UI.InsertPageCountItem
        Private insertTextBoxItem1 As XtraRichEdit.UI.InsertTextBoxItem
        Private insertSymbolItem1 As XtraRichEdit.UI.InsertSymbolItem
        Private changeSectionPageMarginsItem1 As XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Private setNormalSectionPageMarginsItem1 As XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Private setNarrowSectionPageMarginsItem1 As XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Private setModerateSectionPageMarginsItem1 As XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Private setWideSectionPageMarginsItem1 As XtraRichEdit.UI.SetWideSectionPageMarginsItem
        Private showPageMarginsSetupFormItem1 As XtraRichEdit.UI.ShowPageMarginsSetupFormItem
        Private changeSectionPageOrientationItem1 As XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Private setPortraitPageOrientationItem1 As XtraRichEdit.UI.SetPortraitPageOrientationItem
        Private setLandscapePageOrientationItem1 As XtraRichEdit.UI.SetLandscapePageOrientationItem
        Private changeSectionPaperKindItem1 As XtraRichEdit.UI.ChangeSectionPaperKindItem
        Private changeSectionColumnsItem1 As XtraRichEdit.UI.ChangeSectionColumnsItem
        Private setSectionOneColumnItem1 As XtraRichEdit.UI.SetSectionOneColumnItem
        Private setSectionTwoColumnsItem1 As XtraRichEdit.UI.SetSectionTwoColumnsItem
        Private setSectionThreeColumnsItem1 As XtraRichEdit.UI.SetSectionThreeColumnsItem
        Private showColumnsSetupFormItem1 As XtraRichEdit.UI.ShowColumnsSetupFormItem
        Private insertBreakItem1 As XtraRichEdit.UI.InsertBreakItem
        Private insertColumnBreakItem1 As XtraRichEdit.UI.InsertColumnBreakItem
        Private insertSectionBreakNextPageItem1 As XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Private insertSectionBreakEvenPageItem1 As XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Private insertSectionBreakOddPageItem1 As XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Private changeSectionLineNumberingItem1 As XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Private setSectionLineNumberingNoneItem1 As XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Private setSectionLineNumberingContinuousItem1 As XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Private setSectionLineNumberingRestartNewPageItem1 As XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Private setSectionLineNumberingRestartNewSectionItem1 As XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Private toggleParagraphSuppressLineNumbersItem1 As XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Private showLineNumberingFormItem1 As XtraRichEdit.UI.ShowLineNumberingFormItem
        Private changePageColorItem1 As XtraRichEdit.UI.ChangePageColorItem
        Private insertTableOfContentsItem1 As XtraRichEdit.UI.InsertTableOfContentsItem
        Private updateTableOfContentsItem1 As XtraRichEdit.UI.UpdateTableOfContentsItem
        Private addParagraphsToTableOfContentItem1 As XtraRichEdit.UI.AddParagraphsToTableOfContentItem
        Private setParagraphHeadingLevelItem1 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem2 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem3 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem4 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem5 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem6 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem7 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem8 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem9 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem10 As XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private insertCaptionPlaceholderItem1 As XtraRichEdit.UI.InsertCaptionPlaceholderItem
        Private insertFiguresCaptionItems1 As XtraRichEdit.UI.InsertFiguresCaptionItems
        Private insertTablesCaptionItems1 As XtraRichEdit.UI.InsertTablesCaptionItems
        Private insertEquationsCaptionItems1 As XtraRichEdit.UI.InsertEquationsCaptionItems
        Private insertTableOfFiguresPlaceholderItem1 As XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
        Private insertTableOfFiguresItems1 As XtraRichEdit.UI.InsertTableOfFiguresItems
        Private insertTableOfTablesItems1 As XtraRichEdit.UI.InsertTableOfTablesItems
        Private insertTableOfEquationsItems1 As XtraRichEdit.UI.InsertTableOfEquationsItems
        Private updateTableOfFiguresItem1 As XtraRichEdit.UI.UpdateTableOfFiguresItem
        Private insertMergeFieldItem1 As XtraRichEdit.UI.InsertMergeFieldItem
        Private showAllFieldCodesItem1 As XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleViewMergedDataItem1 As XtraRichEdit.UI.ToggleViewMergedDataItem
        Private checkSpellingItem1 As XtraRichEdit.UI.CheckSpellingItem
        Private changeLanguageItem1 As XtraRichEdit.UI.ChangeLanguageItem
        Private protectDocumentItem1 As XtraRichEdit.UI.ProtectDocumentItem
        Private changeRangeEditingPermissionsItem1 As XtraRichEdit.UI.ChangeRangeEditingPermissionsItem
        Private unprotectDocumentItem1 As XtraRichEdit.UI.UnprotectDocumentItem
        Private switchToSimpleViewItem1 As XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private toggleShowHorizontalRulerItem1 As XtraRichEdit.UI.ToggleShowHorizontalRulerItem
        Private toggleShowVerticalRulerItem1 As XtraRichEdit.UI.ToggleShowVerticalRulerItem
        Private zoomOutItem1 As XtraRichEdit.UI.ZoomOutItem
        Private zoomInItem1 As XtraRichEdit.UI.ZoomInItem
        Private goToPageHeaderItem1 As XtraRichEdit.UI.GoToPageHeaderItem
        Private goToPageFooterItem1 As XtraRichEdit.UI.GoToPageFooterItem
        Private goToNextHeaderFooterItem1 As XtraRichEdit.UI.GoToNextHeaderFooterItem
        Private goToPreviousHeaderFooterItem1 As XtraRichEdit.UI.GoToPreviousHeaderFooterItem
        Private toggleLinkToPreviousItem1 As XtraRichEdit.UI.ToggleLinkToPreviousItem
        Private toggleDifferentFirstPageItem1 As XtraRichEdit.UI.ToggleDifferentFirstPageItem
        Private toggleDifferentOddAndEvenPagesItem1 As XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
        Private closePageHeaderFooterItem1 As XtraRichEdit.UI.ClosePageHeaderFooterItem
        Private toggleFirstRowItem1 As XtraRichEdit.UI.ToggleFirstRowItem
        Private toggleLastRowItem1 As XtraRichEdit.UI.ToggleLastRowItem
        Private toggleBandedRowsItem1 As XtraRichEdit.UI.ToggleBandedRowsItem
        Private toggleFirstColumnItem1 As XtraRichEdit.UI.ToggleFirstColumnItem
        Private toggleLastColumnItem1 As XtraRichEdit.UI.ToggleLastColumnItem
        Private toggleBandedColumnItem1 As XtraRichEdit.UI.ToggleBandedColumnsItem
        Private galleryChangeTableStyleItem1 As XtraRichEdit.UI.GalleryChangeTableStyleItem
        Private changeTableBorderLineStyleItem1 As XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As XtraRichEdit.UI.ChangeTableBorderColorItem
        Private changeTableBordersItem1 As XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableCellsShadingItem1 As XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private selectTableElementsItem1 As XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As XtraRichEdit.UI.InsertTableColumnToRightItem
        Private mergeTableCellsItem1 As XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As XtraRichEdit.UI.SplitTableItem
        Private toggleTableAutoFitItem1 As XtraRichEdit.UI.ToggleTableAutoFitItem
        Private toggleTableAutoFitContentsItem1 As XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Private toggleTableAutoFitWindowItem1 As XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Private toggleTableCellsTopLeftAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private showTableOptionsFormItem1 As XtraRichEdit.UI.ShowTableOptionsFormItem
        Private changeFloatingObjectFillColorItem1 As XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
        Private changeFloatingObjectOutlineColorItem1 As XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
        Private changeFloatingObjectOutlineWeightItem1 As XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
        Private repositoryItemFloatingObjectOutlineWeight1 As XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
        Private changeFloatingObjectTextWrapTypeItem1 As XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
        Private setFloatingObjectSquareTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
        Private setFloatingObjectTightTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
        Private setFloatingObjectThroughTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
        Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
        Private setFloatingObjectBehindTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
        Private setFloatingObjectInFrontOfTextWrapTypeItem1 As XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
        Private changeFloatingObjectAlignmentItem1 As XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
        Private setFloatingObjectTopLeftAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
        Private setFloatingObjectTopCenterAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
        Private setFloatingObjectTopRightAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
        Private setFloatingObjectMiddleLeftAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
        Private setFloatingObjectMiddleCenterAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
        Private setFloatingObjectMiddleRightAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
        Private setFloatingObjectBottomLeftAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
        Private setFloatingObjectBottomCenterAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
        Private setFloatingObjectBottomRightAlignmentItem1 As XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
        Private floatingObjectBringForwardSubItem1 As XtraRichEdit.UI.FloatingObjectBringForwardSubItem
        Private floatingObjectBringForwardItem1 As XtraRichEdit.UI.FloatingObjectBringForwardItem
        Private floatingObjectBringToFrontItem1 As XtraRichEdit.UI.FloatingObjectBringToFrontItem
        Private floatingObjectBringInFrontOfTextItem1 As XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
        Private floatingObjectSendBackwardSubItem1 As XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
        Private floatingObjectSendBackwardItem1 As XtraRichEdit.UI.FloatingObjectSendBackwardItem
        Private floatingObjectSendToBackItem1 As XtraRichEdit.UI.FloatingObjectSendToBackItem
        Private floatingObjectSendBehindTextItem1 As XtraRichEdit.UI.FloatingObjectSendBehindTextItem
        Private headerFooterToolsRibbonPageCategory1 As XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory
        Private headerFooterToolsDesignRibbonPage1 As XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage
        Private headerFooterToolsDesignNavigationRibbonPageGroup1 As XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
        Private headerFooterToolsDesignOptionsRibbonPageGroup1 As XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
        Private headerFooterToolsDesignCloseRibbonPageGroup1 As XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup
        Private tableToolsRibbonPageCategory1 As XtraRichEdit.UI.TableToolsRibbonPageCategory
        Private tableDesignRibbonPage1 As XtraRichEdit.UI.TableDesignRibbonPage
        Private tableStyleOptionsRibbonPageGroup1 As XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup
        Private tableStylesRibbonPageGroup1 As XtraRichEdit.UI.TableStylesRibbonPageGroup
        Private tableDrawBordersRibbonPageGroup1 As XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
        Private tableLayoutRibbonPage1 As XtraRichEdit.UI.TableLayoutRibbonPage
        Private tableTableRibbonPageGroup1 As XtraRichEdit.UI.TableTableRibbonPageGroup
        Private tableRowsAndColumnsRibbonPageGroup1 As XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
        Private tableMergeRibbonPageGroup1 As XtraRichEdit.UI.TableMergeRibbonPageGroup
        Private tableCellSizeRibbonPageGroup1 As XtraRichEdit.UI.TableCellSizeRibbonPageGroup
        Private tableAlignmentRibbonPageGroup1 As XtraRichEdit.UI.TableAlignmentRibbonPageGroup
        Private floatingPictureToolsRibbonPageCategory1 As XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
        Private floatingPictureToolsFormatPage1 As XtraRichEdit.UI.FloatingPictureToolsFormatPage
        Private floatingPictureToolsShapeStylesPageGroup1 As XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
        Private floatingPictureToolsArrangePageGroup1 As XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
        Private homeRibbonPage1 As XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private linksRibbonPageGroup1 As XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private textRibbonPageGroup1 As XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private pageLayoutRibbonPage1 As XtraRichEdit.UI.PageLayoutRibbonPage
        Private pageSetupRibbonPageGroup1 As XtraRichEdit.UI.PageSetupRibbonPageGroup
        Private pageBackgroundRibbonPageGroup1 As XtraRichEdit.UI.PageBackgroundRibbonPageGroup
        Private referencesRibbonPage1 As XtraRichEdit.UI.ReferencesRibbonPage
        Private tableOfContentsRibbonPageGroup1 As XtraRichEdit.UI.TableOfContentsRibbonPageGroup
        Private captionsRibbonPageGroup1 As XtraRichEdit.UI.CaptionsRibbonPageGroup
        Private mailingsRibbonPage1 As XtraRichEdit.UI.MailingsRibbonPage
        Private mailMergeRibbonPageGroup1 As XtraRichEdit.UI.MailMergeRibbonPageGroup
        Private reviewRibbonPage1 As XtraRichEdit.UI.ReviewRibbonPage
        Private documentProofingRibbonPageGroup1 As XtraRichEdit.UI.DocumentProofingRibbonPageGroup
        Private documentProtectionRibbonPageGroup1 As XtraRichEdit.UI.DocumentProtectionRibbonPageGroup
        Private viewRibbonPage1 As XtraRichEdit.UI.ViewRibbonPage
        Private documentViewsRibbonPageGroup1 As XtraRichEdit.UI.DocumentViewsRibbonPageGroup
        Private showRibbonPageGroup1 As XtraRichEdit.UI.ShowRibbonPageGroup
        Private zoomRibbonPageGroup1 As XtraRichEdit.UI.ZoomRibbonPageGroup
        Private insertPageBreakItem2 As XtraRichEdit.UI.InsertPageBreakItem
        Private grid1 As XtraGrid.GridControl
		Private WithEvents view As XtraGrid.Views.Grid.GridView
        Private colFullName As XtraGrid.Columns.GridColumn
        Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Friend WithEvents ShowDocumentPropertiesFormItem1 As XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Friend WithEvents InfoRibbonPageGroup1 As XtraRichEdit.UI.InfoRibbonPageGroup
    End Class
End Namespace