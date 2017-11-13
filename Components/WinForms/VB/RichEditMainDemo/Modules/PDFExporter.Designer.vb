Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class PDFExporterModule
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFExporterModule))
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim ReduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.grpXtraRichEdit = New DevExpress.XtraEditors.GroupControl()
            Me.grpPdfViewer = New DevExpress.XtraEditors.GroupControl()
            Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
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
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
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
            Me.insertPageBreakItem2 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
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
            Me.insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.exportToPdfBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
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
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.exportToPdfRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
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
            Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.grpXtraRichEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpXtraRichEdit.SuspendLayout()
            CType(Me.grpPdfViewer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpPdfViewer.SuspendLayout()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.galleryChangeStyleItem1.Id = 82
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            '
            'richEditControl
            '
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 20)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Comments.ShowAllAuthors = False
            Me.richEditControl.Size = New System.Drawing.Size(405, 222)
            Me.richEditControl.TabIndex = 1
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.splitContainerControl1)
            Me.panelControl1.Controls.Add(Me.standaloneBarDockControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 141)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(845, 248)
            Me.panelControl1.TabIndex = 4
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
            Me.splitContainerControl1.Location = New System.Drawing.Point(2, 2)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.grpXtraRichEdit)
            Me.splitContainerControl1.Panel1.ShowCaption = True
            Me.splitContainerControl1.Panel1.Text = "XtraRichEdit control:"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.grpPdfViewer)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(841, 244)
            Me.splitContainerControl1.SplitterPosition = 409
            Me.splitContainerControl1.TabIndex = 6
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'grpXtraRichEdit
            '
            Me.grpXtraRichEdit.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.grpXtraRichEdit.AppearanceCaption.Options.UseFont = True
            Me.grpXtraRichEdit.Controls.Add(Me.richEditControl)
            Me.grpXtraRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpXtraRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.grpXtraRichEdit.Name = "grpXtraRichEdit"
            Me.grpXtraRichEdit.Size = New System.Drawing.Size(409, 244)
            Me.grpXtraRichEdit.TabIndex = 0
            Me.grpXtraRichEdit.Text = "XtraRichEdit control"
            '
            'grpPdfViewer
            '
            Me.grpPdfViewer.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.grpPdfViewer.AppearanceCaption.Options.UseFont = True
            Me.grpPdfViewer.Controls.Add(Me.pdfViewer)
            Me.grpPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpPdfViewer.Location = New System.Drawing.Point(0, 0)
            Me.grpPdfViewer.Name = "grpPdfViewer"
            Me.grpPdfViewer.Size = New System.Drawing.Size(427, 244)
            Me.grpPdfViewer.TabIndex = 9
            Me.grpPdfViewer.Text = "PDF viewer"
            '
            'pdfViewer
            '
            Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer.Location = New System.Drawing.Point(2, 20)
            Me.pdfViewer.Name = "pdfViewer"
            Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
            Me.pdfViewer.Size = New System.Drawing.Size(423, 222)
            Me.pdfViewer.TabIndex = 0
            Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
            '
            'standaloneBarDockControl1
            '
            Me.standaloneBarDockControl1.AutoSize = True
            Me.standaloneBarDockControl1.CausesValidation = False
            Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            Me.standaloneBarDockControl1.Size = New System.Drawing.Size(841, 0)
            Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
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
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem21)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 23
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 24
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 25
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 26
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 27
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 28
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 29
            Me.printPreviewItem1.Name = "printPreviewItem1"
            '
            'undoItem1
            '
            Me.undoItem1.Id = 30
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Id = 31
            Me.redoItem1.Name = "redoItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Id = 39
            Me.pasteItem1.Name = "pasteItem1"
            '
            'cutItem1
            '
            Me.cutItem1.Id = 40
            Me.cutItem1.Name = "cutItem1"
            '
            'copyItem1
            '
            Me.copyItem1.Id = 41
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteSpecialItem1
            '
            Me.pasteSpecialItem1.Id = 42
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 43
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
            Me.changeFontSizeItem1.Id = 44
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            '
            'repositoryItemRichEditFontSizeEdit1
            '
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            '
            'fontSizeIncreaseItem1
            '
            Me.fontSizeIncreaseItem1.Id = 45
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            '
            'fontSizeDecreaseItem1
            '
            Me.fontSizeDecreaseItem1.Id = 46
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            '
            'toggleFontBoldItem1
            '
            Me.toggleFontBoldItem1.Id = 47
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            '
            'toggleFontItalicItem1
            '
            Me.toggleFontItalicItem1.Id = 48
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            '
            'toggleFontUnderlineItem1
            '
            Me.toggleFontUnderlineItem1.Id = 49
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            '
            'toggleFontDoubleUnderlineItem1
            '
            Me.toggleFontDoubleUnderlineItem1.Id = 50
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            '
            'toggleFontStrikeoutItem1
            '
            Me.toggleFontStrikeoutItem1.Id = 51
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            '
            'toggleFontDoubleStrikeoutItem1
            '
            Me.toggleFontDoubleStrikeoutItem1.Id = 52
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            '
            'toggleFontSuperscriptItem1
            '
            Me.toggleFontSuperscriptItem1.Id = 53
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            '
            'toggleFontSubscriptItem1
            '
            Me.toggleFontSubscriptItem1.Id = 54
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            '
            'changeFontColorItem1
            '
            Me.changeFontColorItem1.Id = 55
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            '
            'changeFontBackColorItem1
            '
            Me.changeFontBackColorItem1.Id = 56
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            '
            'changeTextCaseItem1
            '
            Me.changeTextCaseItem1.Id = 57
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            '
            'makeTextUpperCaseItem1
            '
            Me.makeTextUpperCaseItem1.Id = 58
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            '
            'makeTextLowerCaseItem1
            '
            Me.makeTextLowerCaseItem1.Id = 59
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            '
            'toggleTextCaseItem1
            '
            Me.toggleTextCaseItem1.Id = 60
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            '
            'clearFormattingItem1
            '
            Me.clearFormattingItem1.Id = 61
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            '
            'toggleBulletedListItem1
            '
            Me.toggleBulletedListItem1.Id = 62
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            '
            'toggleNumberingListItem1
            '
            Me.toggleNumberingListItem1.Id = 63
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            '
            'toggleMultiLevelListItem1
            '
            Me.toggleMultiLevelListItem1.Id = 64
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            '
            'decreaseIndentItem1
            '
            Me.decreaseIndentItem1.Id = 65
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            '
            'increaseIndentItem1
            '
            Me.increaseIndentItem1.Id = 66
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            '
            'toggleParagraphAlignmentLeftItem1
            '
            Me.toggleParagraphAlignmentLeftItem1.Id = 67
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            '
            'toggleParagraphAlignmentCenterItem1
            '
            Me.toggleParagraphAlignmentCenterItem1.Id = 68
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            '
            'toggleParagraphAlignmentRightItem1
            '
            Me.toggleParagraphAlignmentRightItem1.Id = 69
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            '
            'toggleParagraphAlignmentJustifyItem1
            '
            Me.toggleParagraphAlignmentJustifyItem1.Id = 70
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            '
            'toggleShowWhitespaceItem1
            '
            Me.toggleShowWhitespaceItem1.Id = 71
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            '
            'changeParagraphLineSpacingItem1
            '
            Me.changeParagraphLineSpacingItem1.Id = 72
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            '
            'setSingleParagraphSpacingItem1
            '
            Me.setSingleParagraphSpacingItem1.Id = 73
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            '
            'setSesquialteralParagraphSpacingItem1
            '
            Me.setSesquialteralParagraphSpacingItem1.Id = 74
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            '
            'setDoubleParagraphSpacingItem1
            '
            Me.setDoubleParagraphSpacingItem1.Id = 75
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            '
            'showLineSpacingFormItem1
            '
            Me.showLineSpacingFormItem1.Id = 76
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            '
            'addSpacingBeforeParagraphItem1
            '
            Me.addSpacingBeforeParagraphItem1.Id = 77
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            '
            'removeSpacingBeforeParagraphItem1
            '
            Me.removeSpacingBeforeParagraphItem1.Id = 78
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            '
            'addSpacingAfterParagraphItem1
            '
            Me.addSpacingAfterParagraphItem1.Id = 79
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            '
            'removeSpacingAfterParagraphItem1
            '
            Me.removeSpacingAfterParagraphItem1.Id = 80
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            '
            'changeParagraphBackColorItem1
            '
            Me.changeParagraphBackColorItem1.Id = 81
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            '
            'findItem1
            '
            Me.findItem1.Id = 83
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Id = 84
            Me.replaceItem1.Name = "replaceItem1"
            '
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Id = 85
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            '
            'insertTableItem1
            '
            Me.insertTableItem1.Id = 86
            Me.insertTableItem1.Name = "insertTableItem1"
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Id = 87
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Id = 88
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Id = 89
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Id = 90
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'editPageHeaderItem1
            '
            Me.editPageHeaderItem1.Id = 91
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            '
            'editPageFooterItem1
            '
            Me.editPageFooterItem1.Id = 92
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            '
            'insertPageNumberItem1
            '
            Me.insertPageNumberItem1.Id = 93
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            '
            'insertPageCountItem1
            '
            Me.insertPageCountItem1.Id = 94
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Id = 95
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Id = 96
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            '
            'changeSectionPageMarginsItem1
            '
            Me.changeSectionPageMarginsItem1.Id = 97
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1)})
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            '
            'setNormalSectionPageMarginsItem1
            '
            Me.setNormalSectionPageMarginsItem1.Id = 98
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            '
            'setNarrowSectionPageMarginsItem1
            '
            Me.setNarrowSectionPageMarginsItem1.Id = 99
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            '
            'setModerateSectionPageMarginsItem1
            '
            Me.setModerateSectionPageMarginsItem1.Id = 100
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            '
            'setWideSectionPageMarginsItem1
            '
            Me.setWideSectionPageMarginsItem1.Id = 101
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            '
            'showPageMarginsSetupFormItem1
            '
            Me.showPageMarginsSetupFormItem1.Id = 102
            Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            '
            'changeSectionPageOrientationItem1
            '
            Me.changeSectionPageOrientationItem1.Id = 103
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            '
            'setPortraitPageOrientationItem1
            '
            Me.setPortraitPageOrientationItem1.Id = 104
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            '
            'setLandscapePageOrientationItem1
            '
            Me.setLandscapePageOrientationItem1.Id = 105
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            '
            'changeSectionPaperKindItem1
            '
            Me.changeSectionPaperKindItem1.Id = 106
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            '
            'changeSectionColumnsItem1
            '
            Me.changeSectionColumnsItem1.Id = 107
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1)})
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            '
            'setSectionOneColumnItem1
            '
            Me.setSectionOneColumnItem1.Id = 108
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            '
            'setSectionTwoColumnsItem1
            '
            Me.setSectionTwoColumnsItem1.Id = 109
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            '
            'setSectionThreeColumnsItem1
            '
            Me.setSectionThreeColumnsItem1.Id = 110
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            '
            'showColumnsSetupFormItem1
            '
            Me.showColumnsSetupFormItem1.Id = 111
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            '
            'insertBreakItem1
            '
            Me.insertBreakItem1.Id = 112
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
            Me.insertBreakItem1.Name = "insertBreakItem1"
            '
            'insertColumnBreakItem1
            '
            Me.insertColumnBreakItem1.Id = 113
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            '
            'insertSectionBreakNextPageItem1
            '
            Me.insertSectionBreakNextPageItem1.Id = 114
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            '
            'insertSectionBreakEvenPageItem1
            '
            Me.insertSectionBreakEvenPageItem1.Id = 115
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            '
            'insertSectionBreakOddPageItem1
            '
            Me.insertSectionBreakOddPageItem1.Id = 116
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            '
            'insertPageBreakItem2
            '
            Me.insertPageBreakItem2.Id = -1
            Me.insertPageBreakItem2.Name = "insertPageBreakItem2"
            '
            'changeSectionLineNumberingItem1
            '
            Me.changeSectionLineNumberingItem1.Id = 117
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1)})
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            '
            'setSectionLineNumberingNoneItem1
            '
            Me.setSectionLineNumberingNoneItem1.Id = 118
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            '
            'setSectionLineNumberingContinuousItem1
            '
            Me.setSectionLineNumberingContinuousItem1.Id = 119
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            '
            'setSectionLineNumberingRestartNewPageItem1
            '
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 120
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            '
            'setSectionLineNumberingRestartNewSectionItem1
            '
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 121
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            '
            'toggleParagraphSuppressLineNumbersItem1
            '
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 122
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            '
            'showLineNumberingFormItem1
            '
            Me.showLineNumberingFormItem1.Id = 123
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            '
            'changePageColorItem1
            '
            Me.changePageColorItem1.Id = 124
            Me.changePageColorItem1.Name = "changePageColorItem1"
            '
            'insertTableOfContentsItem1
            '
            Me.insertTableOfContentsItem1.Id = 125
            Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            '
            'updateTableOfContentsItem1
            '
            Me.updateTableOfContentsItem1.Id = 126
            Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            '
            'addParagraphsToTableOfContentItem1
            '
            Me.addParagraphsToTableOfContentItem1.Id = 127
            Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10)})
            Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            '
            'setParagraphHeadingLevelItem1
            '
            Me.setParagraphHeadingLevelItem1.Id = 128
            Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
            '
            'setParagraphHeadingLevelItem2
            '
            Me.setParagraphHeadingLevelItem2.Id = 129
            Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
            '
            'setParagraphHeadingLevelItem3
            '
            Me.setParagraphHeadingLevelItem3.Id = 130
            Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
            '
            'setParagraphHeadingLevelItem4
            '
            Me.setParagraphHeadingLevelItem4.Id = 131
            Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
            '
            'setParagraphHeadingLevelItem5
            '
            Me.setParagraphHeadingLevelItem5.Id = 132
            Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
            '
            'setParagraphHeadingLevelItem6
            '
            Me.setParagraphHeadingLevelItem6.Id = 133
            Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
            '
            'setParagraphHeadingLevelItem7
            '
            Me.setParagraphHeadingLevelItem7.Id = 134
            Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
            '
            'setParagraphHeadingLevelItem8
            '
            Me.setParagraphHeadingLevelItem8.Id = 135
            Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
            '
            'setParagraphHeadingLevelItem9
            '
            Me.setParagraphHeadingLevelItem9.Id = 136
            Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
            '
            'setParagraphHeadingLevelItem10
            '
            Me.setParagraphHeadingLevelItem10.Id = 137
            Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
            '
            'insertCaptionPlaceholderItem1
            '
            Me.insertCaptionPlaceholderItem1.Id = 138
            Me.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertFiguresCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTablesCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertEquationsCaptionItems1)})
            Me.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
            '
            'insertFiguresCaptionItems1
            '
            Me.insertFiguresCaptionItems1.Id = 139
            Me.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
            '
            'insertTablesCaptionItems1
            '
            Me.insertTablesCaptionItems1.Id = 140
            Me.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
            '
            'insertEquationsCaptionItems1
            '
            Me.insertEquationsCaptionItems1.Id = 141
            Me.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
            '
            'insertTableOfFiguresPlaceholderItem1
            '
            Me.insertTableOfFiguresPlaceholderItem1.Id = 142
            Me.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfFiguresItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfTablesItems1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfEquationsItems1)})
            Me.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
            '
            'insertTableOfFiguresItems1
            '
            Me.insertTableOfFiguresItems1.Id = 143
            Me.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
            '
            'insertTableOfTablesItems1
            '
            Me.insertTableOfTablesItems1.Id = 144
            Me.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
            '
            'insertTableOfEquationsItems1
            '
            Me.insertTableOfEquationsItems1.Id = 145
            Me.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
            '
            'updateTableOfFiguresItem1
            '
            Me.updateTableOfFiguresItem1.Id = 146
            Me.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
            '
            'insertMergeFieldItem1
            '
            Me.insertMergeFieldItem1.Id = 147
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            '
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 148
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 149
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'toggleViewMergedDataItem1
            '
            Me.toggleViewMergedDataItem1.Id = 150
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            '
            'checkSpellingItem1
            '
            Me.checkSpellingItem1.Id = 151
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            '
            'changeLanguageItem1
            '
            Me.changeLanguageItem1.Id = 152
            Me.changeLanguageItem1.Name = "changeLanguageItem1"
            '
            'protectDocumentItem1
            '
            Me.protectDocumentItem1.Id = 153
            Me.protectDocumentItem1.Name = "protectDocumentItem1"
            '
            'changeRangeEditingPermissionsItem1
            '
            Me.changeRangeEditingPermissionsItem1.Id = 154
            Me.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1"
            '
            'unprotectDocumentItem1
            '
            Me.unprotectDocumentItem1.Id = 155
            Me.unprotectDocumentItem1.Name = "unprotectDocumentItem1"
            '
            'switchToSimpleViewItem1
            '
            Me.switchToSimpleViewItem1.Id = 156
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            '
            'switchToDraftViewItem1
            '
            Me.switchToDraftViewItem1.Id = 157
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            '
            'switchToPrintLayoutViewItem1
            '
            Me.switchToPrintLayoutViewItem1.Id = 158
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            '
            'toggleShowHorizontalRulerItem1
            '
            Me.toggleShowHorizontalRulerItem1.Id = 159
            Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            '
            'toggleShowVerticalRulerItem1
            '
            Me.toggleShowVerticalRulerItem1.Id = 160
            Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            '
            'zoomOutItem1
            '
            Me.zoomOutItem1.Id = 161
            Me.zoomOutItem1.Name = "zoomOutItem1"
            '
            'zoomInItem1
            '
            Me.zoomInItem1.Id = 162
            Me.zoomInItem1.Name = "zoomInItem1"
            '
            'goToPageHeaderItem1
            '
            Me.goToPageHeaderItem1.Id = 163
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            '
            'goToPageFooterItem1
            '
            Me.goToPageFooterItem1.Id = 164
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            '
            'goToNextHeaderFooterItem1
            '
            Me.goToNextHeaderFooterItem1.Id = 165
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            '
            'goToPreviousHeaderFooterItem1
            '
            Me.goToPreviousHeaderFooterItem1.Id = 166
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            '
            'toggleLinkToPreviousItem1
            '
            Me.toggleLinkToPreviousItem1.Id = 167
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            '
            'toggleDifferentFirstPageItem1
            '
            Me.toggleDifferentFirstPageItem1.Id = 168
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            '
            'toggleDifferentOddAndEvenPagesItem1
            '
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 169
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            '
            'closePageHeaderFooterItem1
            '
            Me.closePageHeaderFooterItem1.Id = 170
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            '
            'toggleFirstRowItem1
            '
            Me.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstRowItem1.Id = 171
            Me.toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            '
            'toggleLastRowItem1
            '
            Me.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastRowItem1.Id = 172
            Me.toggleLastRowItem1.Name = "toggleLastRowItem1"
            '
            'toggleBandedRowsItem1
            '
            Me.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedRowsItem1.Id = 173
            Me.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            '
            'toggleFirstColumnItem1
            '
            Me.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstColumnItem1.Id = 174
            Me.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            '
            'toggleLastColumnItem1
            '
            Me.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastColumnItem1.Id = 175
            Me.toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            '
            'toggleBandedColumnItem1
            '
            Me.toggleBandedColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedColumnItem1.Id = 176
            Me.toggleBandedColumnItem1.Name = "toggleBandedColumnItem1"
            '
            'galleryChangeTableStyleItem1
            '
            Me.galleryChangeTableStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableStyleItem1.CurrentItemStyle = Nothing
            Me.galleryChangeTableStyleItem1.CurrentStyle = Nothing
            Me.galleryChangeTableStyleItem1.DeleteItemLink = Nothing
            '
            '
            '
            Me.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup2})
            Me.galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableStyleItem1.Id = 177
            Me.galleryChangeTableStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            Me.galleryChangeTableStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableStyleItem1.PopupGallery = Nothing
            '
            'changeTableBorderLineStyleItem1
            '
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            Me.changeTableBorderLineStyleItem1.EditWidth = 130
            Me.changeTableBorderLineStyleItem1.Id = 178
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
            Me.changeTableBorderLineWeightItem1.Id = 179
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
            Me.changeTableBorderColorItem1.Id = 180
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            '
            'changeTableBordersItem1
            '
            Me.changeTableBordersItem1.Id = 181
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1)})
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            '
            'toggleTableCellsBottomBorderItem1
            '
            Me.toggleTableCellsBottomBorderItem1.Id = 182
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            '
            'toggleTableCellsTopBorderItem1
            '
            Me.toggleTableCellsTopBorderItem1.Id = 183
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            '
            'toggleTableCellsLeftBorderItem1
            '
            Me.toggleTableCellsLeftBorderItem1.Id = 184
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            '
            'toggleTableCellsRightBorderItem1
            '
            Me.toggleTableCellsRightBorderItem1.Id = 185
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            '
            'resetTableCellsAllBordersItem1
            '
            Me.resetTableCellsAllBordersItem1.Id = 186
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            '
            'toggleTableCellsAllBordersItem1
            '
            Me.toggleTableCellsAllBordersItem1.Id = 187
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            '
            'toggleTableCellsOutsideBorderItem1
            '
            Me.toggleTableCellsOutsideBorderItem1.Id = 188
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            '
            'toggleTableCellsInsideBorderItem1
            '
            Me.toggleTableCellsInsideBorderItem1.Id = 189
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            '
            'toggleTableCellsInsideHorizontalBorderItem1
            '
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 190
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            '
            'toggleTableCellsInsideVerticalBorderItem1
            '
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 191
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            '
            'toggleShowTableGridLinesItem1
            '
            Me.toggleShowTableGridLinesItem1.Id = 192
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            '
            'changeTableCellsShadingItem1
            '
            Me.changeTableCellsShadingItem1.Id = 193
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            '
            'selectTableElementsItem1
            '
            Me.selectTableElementsItem1.Id = 194
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)})
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            '
            'selectTableCellItem1
            '
            Me.selectTableCellItem1.Id = 195
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            '
            'selectTableColumnItem1
            '
            Me.selectTableColumnItem1.Id = 196
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            '
            'selectTableRowItem1
            '
            Me.selectTableRowItem1.Id = 197
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            '
            'selectTableItem1
            '
            Me.selectTableItem1.Id = 198
            Me.selectTableItem1.Name = "selectTableItem1"
            '
            'showTablePropertiesFormItem1
            '
            Me.showTablePropertiesFormItem1.Id = 199
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            '
            'deleteTableElementsItem1
            '
            Me.deleteTableElementsItem1.Id = 200
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)})
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            '
            'showDeleteTableCellsFormItem1
            '
            Me.showDeleteTableCellsFormItem1.Id = 201
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            '
            'deleteTableColumnsItem1
            '
            Me.deleteTableColumnsItem1.Id = 202
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            '
            'deleteTableRowsItem1
            '
            Me.deleteTableRowsItem1.Id = 203
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            '
            'deleteTableItem1
            '
            Me.deleteTableItem1.Id = 204
            Me.deleteTableItem1.Name = "deleteTableItem1"
            '
            'insertTableRowAboveItem1
            '
            Me.insertTableRowAboveItem1.Id = 205
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            '
            'insertTableRowBelowItem1
            '
            Me.insertTableRowBelowItem1.Id = 206
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            '
            'insertTableColumnToLeftItem1
            '
            Me.insertTableColumnToLeftItem1.Id = 207
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            '
            'insertTableColumnToRightItem1
            '
            Me.insertTableColumnToRightItem1.Id = 208
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            '
            'mergeTableCellsItem1
            '
            Me.mergeTableCellsItem1.Id = 209
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            '
            'showSplitTableCellsForm1
            '
            Me.showSplitTableCellsForm1.Id = 210
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            '
            'splitTableItem1
            '
            Me.splitTableItem1.Id = 211
            Me.splitTableItem1.Name = "splitTableItem1"
            '
            'toggleTableAutoFitItem1
            '
            Me.toggleTableAutoFitItem1.Id = 212
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)})
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            '
            'toggleTableAutoFitContentsItem1
            '
            Me.toggleTableAutoFitContentsItem1.Id = 213
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            '
            'toggleTableAutoFitWindowItem1
            '
            Me.toggleTableAutoFitWindowItem1.Id = 214
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            '
            'toggleTableFixedColumnWidthItem1
            '
            Me.toggleTableFixedColumnWidthItem1.Id = 215
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            '
            'toggleTableCellsTopLeftAlignmentItem1
            '
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 216
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            '
            'toggleTableCellsMiddleLeftAlignmentItem1
            '
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 217
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            '
            'toggleTableCellsBottomLeftAlignmentItem1
            '
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 218
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            '
            'toggleTableCellsTopCenterAlignmentItem1
            '
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 219
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            '
            'toggleTableCellsMiddleCenterAlignmentItem1
            '
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 220
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            '
            'toggleTableCellsBottomCenterAlignmentItem1
            '
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 221
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            '
            'toggleTableCellsTopRightAlignmentItem1
            '
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 222
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            '
            'toggleTableCellsMiddleRightAlignmentItem1
            '
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 223
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            '
            'toggleTableCellsBottomRightAlignmentItem1
            '
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 224
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            '
            'showTableOptionsFormItem1
            '
            Me.showTableOptionsFormItem1.Id = 225
            Me.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            '
            'changeFloatingObjectFillColorItem1
            '
            Me.changeFloatingObjectFillColorItem1.Id = 226
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            '
            'changeFloatingObjectOutlineColorItem1
            '
            Me.changeFloatingObjectOutlineColorItem1.Id = 227
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            '
            'changeFloatingObjectOutlineWeightItem1
            '
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 228
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
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 229
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)})
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            '
            'setFloatingObjectSquareTextWrapTypeItem1
            '
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 230
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            '
            'setFloatingObjectTightTextWrapTypeItem1
            '
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 231
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            '
            'setFloatingObjectThroughTextWrapTypeItem1
            '
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 232
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            '
            'setFloatingObjectTopAndBottomTextWrapTypeItem1
            '
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 233
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            '
            'setFloatingObjectBehindTextWrapTypeItem1
            '
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 234
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            '
            'setFloatingObjectInFrontOfTextWrapTypeItem1
            '
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 235
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            '
            'changeFloatingObjectAlignmentItem1
            '
            Me.changeFloatingObjectAlignmentItem1.Id = 236
            Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1)})
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            '
            'setFloatingObjectTopLeftAlignmentItem1
            '
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 237
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            '
            'setFloatingObjectTopCenterAlignmentItem1
            '
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 238
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            '
            'setFloatingObjectTopRightAlignmentItem1
            '
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 239
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            '
            'setFloatingObjectMiddleLeftAlignmentItem1
            '
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 240
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            '
            'setFloatingObjectMiddleCenterAlignmentItem1
            '
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 241
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            '
            'setFloatingObjectMiddleRightAlignmentItem1
            '
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 242
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            '
            'setFloatingObjectBottomLeftAlignmentItem1
            '
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 243
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            '
            'setFloatingObjectBottomCenterAlignmentItem1
            '
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 244
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            '
            'setFloatingObjectBottomRightAlignmentItem1
            '
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 245
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            '
            'floatingObjectBringForwardSubItem1
            '
            Me.floatingObjectBringForwardSubItem1.Id = 246
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1)})
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            '
            'floatingObjectBringForwardItem1
            '
            Me.floatingObjectBringForwardItem1.Id = 247
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            '
            'floatingObjectBringToFrontItem1
            '
            Me.floatingObjectBringToFrontItem1.Id = 248
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            '
            'floatingObjectBringInFrontOfTextItem1
            '
            Me.floatingObjectBringInFrontOfTextItem1.Id = 249
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            '
            'floatingObjectSendBackwardSubItem1
            '
            Me.floatingObjectSendBackwardSubItem1.Id = 250
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1)})
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            '
            'floatingObjectSendBackwardItem1
            '
            Me.floatingObjectSendBackwardItem1.Id = 251
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            '
            'floatingObjectSendToBackItem1
            '
            Me.floatingObjectSendToBackItem1.Id = 252
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            '
            'floatingObjectSendBehindTextItem1
            '
            Me.floatingObjectSendBehindTextItem1.Id = 253
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            '
            'insertPageBreakItem21
            '
            Me.insertPageBreakItem21.Id = 258
            Me.insertPageBreakItem21.Name = "insertPageBreakItem21"
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 259
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changePageColorItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.insertCaptionPlaceholderItem1, Me.insertFiguresCaptionItems1, Me.insertTablesCaptionItems1, Me.insertEquationsCaptionItems1, Me.insertTableOfFiguresPlaceholderItem1, Me.insertTableOfFiguresItems1, Me.insertTableOfTablesItems1, Me.insertTableOfEquationsItems1, Me.updateTableOfFiguresItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.checkSpellingItem1, Me.changeLanguageItem1, Me.protectDocumentItem1, Me.changeRangeEditingPermissionsItem1, Me.unprotectDocumentItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToNextHeaderFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.toggleFirstRowItem1, Me.toggleLastRowItem1, Me.toggleBandedRowsItem1, Me.toggleFirstColumnItem1, Me.toggleLastColumnItem1, Me.toggleBandedColumnItem1, Me.galleryChangeTableStyleItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableCellsShadingItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showTableOptionsFormItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.exportToPdfBarButtonItem, Me.insertPageBreakItem21, Me.ShowDocumentPropertiesFormItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 260
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.headerFooterToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.floatingPictureToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.referencesRibbonPage1, Me.mailingsRibbonPage1, Me.viewRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
            Me.ribbonControl1.Size = New System.Drawing.Size(845, 141)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
            '
            'barButtonGroup1
            '
            Me.barButtonGroup1.Id = 32
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            '
            'barButtonGroup2
            '
            Me.barButtonGroup2.Id = 33
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
            'barButtonGroup3
            '
            Me.barButtonGroup3.Id = 34
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            '
            'barButtonGroup4
            '
            Me.barButtonGroup4.Id = 35
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            '
            'barButtonGroup5
            '
            Me.barButtonGroup5.Id = 36
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            '
            'barButtonGroup6
            '
            Me.barButtonGroup6.Id = 37
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            '
            'barButtonGroup7
            '
            Me.barButtonGroup7.Id = 38
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            '
            'exportToPdfBarButtonItem
            '
            Me.exportToPdfBarButtonItem.Caption = "Generate PDF"
            Me.exportToPdfBarButtonItem.Glyph = CType(resources.GetObject("exportToPdfBarButtonItem.Glyph"), System.Drawing.Image)
            Me.exportToPdfBarButtonItem.Id = 257
            Me.exportToPdfBarButtonItem.LargeGlyph = CType(resources.GetObject("exportToPdfBarButtonItem.LargeGlyph"), System.Drawing.Image)
            Me.exportToPdfBarButtonItem.Name = "exportToPdfBarButtonItem"
            Me.exportToPdfBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'headerFooterToolsRibbonPageCategory1
            '
            Me.headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.headerFooterToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1"
            Me.headerFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.headerFooterToolsDesignRibbonPage1})
            Me.headerFooterToolsRibbonPageCategory1.Visible = False
            '
            'headerFooterToolsDesignRibbonPage1
            '
            Me.headerFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.headerFooterToolsDesignNavigationRibbonPageGroup1, Me.headerFooterToolsDesignOptionsRibbonPageGroup1, Me.headerFooterToolsDesignCloseRibbonPageGroup1})
            Me.headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1"
            Me.headerFooterToolsDesignRibbonPage1.Visible = False
            '
            'headerFooterToolsDesignNavigationRibbonPageGroup1
            '
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageHeaderItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPageFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToNextHeaderFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.goToPreviousHeaderFooterItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(Me.toggleLinkToPreviousItem1)
            Me.headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1"
            '
            'headerFooterToolsDesignOptionsRibbonPageGroup1
            '
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentFirstPageItem1)
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1"
            '
            'headerFooterToolsDesignCloseRibbonPageGroup1
            '
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(Me.closePageHeaderFooterItem1)
            Me.headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1"
            '
            'tableToolsRibbonPageCategory1
            '
            Me.tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.tableToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
            Me.tableToolsRibbonPageCategory1.Visible = False
            '
            'tableDesignRibbonPage1
            '
            Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
            Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            Me.tableDesignRibbonPage1.Visible = False
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
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
            Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
            Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            '
            'tableLayoutRibbonPage1
            '
            Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
            Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            Me.tableLayoutRibbonPage1.Visible = False
            '
            'tableTableRibbonPageGroup1
            '
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
            Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
            Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            '
            'tableRowsAndColumnsRibbonPageGroup1
            '
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
            Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            '
            'tableMergeRibbonPageGroup1
            '
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
            Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
            Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            '
            'tableCellSizeRibbonPageGroup1
            '
            Me.tableCellSizeRibbonPageGroup1.AllowTextClipping = False
            Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1)
            Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            '
            'tableAlignmentRibbonPageGroup1
            '
            Me.tableAlignmentRibbonPageGroup1.Glyph = CType(resources.GetObject("tableAlignmentRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.showTableOptionsFormItem1)
            Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            '
            'floatingPictureToolsRibbonPageCategory1
            '
            Me.floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.floatingPictureToolsRibbonPageCategory1.Control = Me.richEditControl
            Me.floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
            Me.floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.floatingPictureToolsFormatPage1})
            Me.floatingPictureToolsRibbonPageCategory1.Visible = False
            '
            'floatingPictureToolsFormatPage1
            '
            Me.floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.floatingPictureToolsShapeStylesPageGroup1, Me.floatingPictureToolsArrangePageGroup1})
            Me.floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
            Me.floatingPictureToolsFormatPage1.Visible = False
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
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectBringForwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.ItemLinks.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            '
            'fileRibbonPage1
            '
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1, Me.exportToPdfRibbonPageGroup, Me.InfoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            '
            'commonRibbonPageGroup1
            '
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            '
            'exportToPdfRibbonPageGroup
            '
            Me.exportToPdfRibbonPageGroup.AllowTextClipping = False
            Me.exportToPdfRibbonPageGroup.ItemLinks.Add(Me.exportToPdfBarButtonItem)
            Me.exportToPdfRibbonPageGroup.Name = "exportToPdfRibbonPageGroup"
            Me.exportToPdfRibbonPageGroup.ShowCaptionButton = False
            Me.exportToPdfRibbonPageGroup.Text = "Export"
            '
            'InfoRibbonPageGroup1
            '
            Me.InfoRibbonPageGroup1.ItemLinks.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.InfoRibbonPageGroup1.Name = "InfoRibbonPageGroup1"
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
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            '
            'fontRibbonPageGroup1
            '
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
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
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            '
            'insertRibbonPage1
            '
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            '
            'pagesRibbonPageGroup1
            '
            Me.pagesRibbonPageGroup1.AllowTextClipping = False
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem21)
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            '
            'tablesRibbonPageGroup1
            '
            Me.tablesRibbonPageGroup1.AllowTextClipping = False
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            '
            'illustrationsRibbonPageGroup1
            '
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            '
            'linksRibbonPageGroup1
            '
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            '
            'headerFooterRibbonPageGroup1
            '
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            '
            'textRibbonPageGroup1
            '
            Me.textRibbonPageGroup1.Glyph = CType(resources.GetObject("textRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1)
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            '
            'symbolsRibbonPageGroup1
            '
            Me.symbolsRibbonPageGroup1.AllowTextClipping = False
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            '
            'pageLayoutRibbonPage1
            '
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pageSetupRibbonPageGroup1, Me.pageBackgroundRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            '
            'pageSetupRibbonPageGroup1
            '
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1)
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            '
            'pageBackgroundRibbonPageGroup1
            '
            Me.pageBackgroundRibbonPageGroup1.AllowTextClipping = False
            Me.pageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.changePageColorItem1)
            Me.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
            '
            'referencesRibbonPage1
            '
            Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tableOfContentsRibbonPageGroup1, Me.captionsRibbonPageGroup1})
            Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
            '
            'tableOfContentsRibbonPageGroup1
            '
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1)
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1)
            Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            '
            'captionsRibbonPageGroup1
            '
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertCaptionPlaceholderItem1)
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfFiguresPlaceholderItem1)
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfFiguresItem1)
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
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            '
            'viewRibbonPage1
            '
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            '
            'documentViewsRibbonPageGroup1
            '
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1)
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1)
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
            'barButtonItem1
            '
            Me.barButtonItem1.Caption = "Export to PDF"
            Me.barButtonItem1.Glyph = CType(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image)
            Me.barButtonItem1.Id = -1
            Me.barButtonItem1.LargeGlyph = CType(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image)
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            '
            'PDFExporterModule
            '
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "PDFExporterModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.grpXtraRichEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpXtraRichEdit.ResumeLayout(False)
            CType(Me.grpPdfViewer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpPdfViewer.ResumeLayout(False)
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents richEditControl As RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private grpXtraRichEdit As DevExpress.XtraEditors.GroupControl
		Private grpPdfViewer As DevExpress.XtraEditors.GroupControl
		Private pdfViewer As XtraPdfViewer.PdfViewer
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private fileNewItem1 As UI.FileNewItem
		Private fileOpenItem1 As UI.FileOpenItem
		Private fileSaveItem1 As UI.FileSaveItem
		Private fileSaveAsItem1 As UI.FileSaveAsItem
		Private quickPrintItem1 As UI.QuickPrintItem
		Private printItem1 As UI.PrintItem
		Private printPreviewItem1 As UI.PrintPreviewItem
		Private undoItem1 As UI.UndoItem
		Private redoItem1 As UI.RedoItem
		Private pasteItem1 As UI.PasteItem
		Private cutItem1 As UI.CutItem
		Private copyItem1 As UI.CopyItem
		Private pasteSpecialItem1 As UI.PasteSpecialItem
		Private barButtonGroup1 As XtraBars.BarButtonGroup
		Private changeFontNameItem1 As UI.ChangeFontNameItem
		Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit1 As Design.RepositoryItemRichEditFontSizeEdit
		Private fontSizeIncreaseItem1 As UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As UI.FontSizeDecreaseItem
		Private barButtonGroup2 As XtraBars.BarButtonGroup
		Private toggleFontBoldItem1 As UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As UI.ToggleFontItalicItem
		Private toggleFontUnderlineItem1 As UI.ToggleFontUnderlineItem
		Private toggleFontDoubleUnderlineItem1 As UI.ToggleFontDoubleUnderlineItem
		Private toggleFontStrikeoutItem1 As UI.ToggleFontStrikeoutItem
		Private toggleFontDoubleStrikeoutItem1 As UI.ToggleFontDoubleStrikeoutItem
		Private toggleFontSuperscriptItem1 As UI.ToggleFontSuperscriptItem
		Private toggleFontSubscriptItem1 As UI.ToggleFontSubscriptItem
		Private barButtonGroup3 As XtraBars.BarButtonGroup
		Private changeFontColorItem1 As UI.ChangeFontColorItem
		Private changeFontBackColorItem1 As UI.ChangeFontBackColorItem
		Private changeTextCaseItem1 As UI.ChangeTextCaseItem
		Private makeTextUpperCaseItem1 As UI.MakeTextUpperCaseItem
		Private makeTextLowerCaseItem1 As UI.MakeTextLowerCaseItem
		Private toggleTextCaseItem1 As UI.ToggleTextCaseItem
		Private clearFormattingItem1 As UI.ClearFormattingItem
		Private barButtonGroup4 As XtraBars.BarButtonGroup
		Private toggleBulletedListItem1 As UI.ToggleBulletedListItem
		Private toggleNumberingListItem1 As UI.ToggleNumberingListItem
		Private toggleMultiLevelListItem1 As UI.ToggleMultiLevelListItem
		Private barButtonGroup5 As XtraBars.BarButtonGroup
		Private decreaseIndentItem1 As UI.DecreaseIndentItem
		Private increaseIndentItem1 As UI.IncreaseIndentItem
		Private toggleShowWhitespaceItem1 As UI.ToggleShowWhitespaceItem
		Private barButtonGroup6 As XtraBars.BarButtonGroup
		Private toggleParagraphAlignmentLeftItem1 As UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As UI.ToggleParagraphAlignmentJustifyItem
		Private barButtonGroup7 As XtraBars.BarButtonGroup
		Private changeParagraphLineSpacingItem1 As UI.ChangeParagraphLineSpacingItem
		Private setSingleParagraphSpacingItem1 As UI.SetSingleParagraphSpacingItem
		Private setSesquialteralParagraphSpacingItem1 As UI.SetSesquialteralParagraphSpacingItem
		Private setDoubleParagraphSpacingItem1 As UI.SetDoubleParagraphSpacingItem
		Private showLineSpacingFormItem1 As UI.ShowLineSpacingFormItem
		Private addSpacingBeforeParagraphItem1 As UI.AddSpacingBeforeParagraphItem
		Private removeSpacingBeforeParagraphItem1 As UI.RemoveSpacingBeforeParagraphItem
		Private addSpacingAfterParagraphItem1 As UI.AddSpacingAfterParagraphItem
		Private removeSpacingAfterParagraphItem1 As UI.RemoveSpacingAfterParagraphItem
		Private changeParagraphBackColorItem1 As UI.ChangeParagraphBackColorItem
		Private galleryChangeStyleItem1 As UI.GalleryChangeStyleItem
		Private findItem1 As UI.FindItem
		Private replaceItem1 As UI.ReplaceItem
		Private insertPageBreakItem1 As UI.InsertPageBreakItem
		Private insertTableItem1 As UI.InsertTableItem
		Private insertPictureItem1 As UI.InsertPictureItem
		Private insertFloatingPictureItem1 As UI.InsertFloatingPictureItem
		Private insertBookmarkItem1 As UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As UI.InsertHyperlinkItem
		Private editPageHeaderItem1 As UI.EditPageHeaderItem
		Private editPageFooterItem1 As UI.EditPageFooterItem
		Private insertPageNumberItem1 As UI.InsertPageNumberItem
		Private insertPageCountItem1 As UI.InsertPageCountItem
		Private insertTextBoxItem1 As UI.InsertTextBoxItem
		Private insertSymbolItem1 As UI.InsertSymbolItem
		Private changeSectionPageMarginsItem1 As UI.ChangeSectionPageMarginsItem
		Private setNormalSectionPageMarginsItem1 As UI.SetNormalSectionPageMarginsItem
		Private setNarrowSectionPageMarginsItem1 As UI.SetNarrowSectionPageMarginsItem
		Private setModerateSectionPageMarginsItem1 As UI.SetModerateSectionPageMarginsItem
		Private setWideSectionPageMarginsItem1 As UI.SetWideSectionPageMarginsItem
		Private showPageMarginsSetupFormItem1 As UI.ShowPageMarginsSetupFormItem
		Private changeSectionPageOrientationItem1 As UI.ChangeSectionPageOrientationItem
		Private setPortraitPageOrientationItem1 As UI.SetPortraitPageOrientationItem
		Private setLandscapePageOrientationItem1 As UI.SetLandscapePageOrientationItem
		Private changeSectionPaperKindItem1 As UI.ChangeSectionPaperKindItem
		Private changeSectionColumnsItem1 As UI.ChangeSectionColumnsItem
		Private setSectionOneColumnItem1 As UI.SetSectionOneColumnItem
		Private setSectionTwoColumnsItem1 As UI.SetSectionTwoColumnsItem
		Private setSectionThreeColumnsItem1 As UI.SetSectionThreeColumnsItem
		Private showColumnsSetupFormItem1 As UI.ShowColumnsSetupFormItem
		Private insertBreakItem1 As UI.InsertBreakItem
		Private insertColumnBreakItem1 As UI.InsertColumnBreakItem
		Private insertSectionBreakNextPageItem1 As UI.InsertSectionBreakNextPageItem
		Private insertSectionBreakEvenPageItem1 As UI.InsertSectionBreakEvenPageItem
		Private insertSectionBreakOddPageItem1 As UI.InsertSectionBreakOddPageItem
		Private changeSectionLineNumberingItem1 As UI.ChangeSectionLineNumberingItem
		Private setSectionLineNumberingNoneItem1 As UI.SetSectionLineNumberingNoneItem
		Private setSectionLineNumberingContinuousItem1 As UI.SetSectionLineNumberingContinuousItem
		Private setSectionLineNumberingRestartNewPageItem1 As UI.SetSectionLineNumberingRestartNewPageItem
		Private setSectionLineNumberingRestartNewSectionItem1 As UI.SetSectionLineNumberingRestartNewSectionItem
		Private toggleParagraphSuppressLineNumbersItem1 As UI.ToggleParagraphSuppressLineNumbersItem
		Private showLineNumberingFormItem1 As UI.ShowLineNumberingFormItem
		Private changePageColorItem1 As UI.ChangePageColorItem
		Private insertTableOfContentsItem1 As UI.InsertTableOfContentsItem
		Private updateTableOfContentsItem1 As UI.UpdateTableOfContentsItem
		Private addParagraphsToTableOfContentItem1 As UI.AddParagraphsToTableOfContentItem
		Private setParagraphHeadingLevelItem1 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem2 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem3 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem4 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem5 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem6 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem7 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem8 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem9 As UI.SetParagraphHeadingLevelItem
		Private setParagraphHeadingLevelItem10 As UI.SetParagraphHeadingLevelItem
		Private insertCaptionPlaceholderItem1 As UI.InsertCaptionPlaceholderItem
		Private insertFiguresCaptionItems1 As UI.InsertFiguresCaptionItems
		Private insertTablesCaptionItems1 As UI.InsertTablesCaptionItems
		Private insertEquationsCaptionItems1 As UI.InsertEquationsCaptionItems
		Private insertTableOfFiguresPlaceholderItem1 As UI.InsertTableOfFiguresPlaceholderItem
		Private insertTableOfFiguresItems1 As UI.InsertTableOfFiguresItems
		Private insertTableOfTablesItems1 As UI.InsertTableOfTablesItems
		Private insertTableOfEquationsItems1 As UI.InsertTableOfEquationsItems
		Private updateTableOfFiguresItem1 As UI.UpdateTableOfFiguresItem
		Private insertMergeFieldItem1 As UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As UI.ToggleViewMergedDataItem
		Private checkSpellingItem1 As UI.CheckSpellingItem
		Private changeLanguageItem1 As UI.ChangeLanguageItem
		Private protectDocumentItem1 As UI.ProtectDocumentItem
		Private changeRangeEditingPermissionsItem1 As UI.ChangeRangeEditingPermissionsItem
		Private unprotectDocumentItem1 As UI.UnprotectDocumentItem
		Private switchToSimpleViewItem1 As UI.SwitchToSimpleViewItem
		Private switchToDraftViewItem1 As UI.SwitchToDraftViewItem
		Private switchToPrintLayoutViewItem1 As UI.SwitchToPrintLayoutViewItem
		Private toggleShowHorizontalRulerItem1 As UI.ToggleShowHorizontalRulerItem
		Private toggleShowVerticalRulerItem1 As UI.ToggleShowVerticalRulerItem
		Private zoomOutItem1 As UI.ZoomOutItem
		Private zoomInItem1 As UI.ZoomInItem
		Private goToPageHeaderItem1 As UI.GoToPageHeaderItem
		Private goToPageFooterItem1 As UI.GoToPageFooterItem
		Private goToNextHeaderFooterItem1 As UI.GoToNextHeaderFooterItem
		Private goToPreviousHeaderFooterItem1 As UI.GoToPreviousHeaderFooterItem
		Private toggleLinkToPreviousItem1 As UI.ToggleLinkToPreviousItem
		Private toggleDifferentFirstPageItem1 As UI.ToggleDifferentFirstPageItem
		Private toggleDifferentOddAndEvenPagesItem1 As UI.ToggleDifferentOddAndEvenPagesItem
		Private closePageHeaderFooterItem1 As UI.ClosePageHeaderFooterItem
		Private toggleFirstRowItem1 As UI.ToggleFirstRowItem
		Private toggleLastRowItem1 As UI.ToggleLastRowItem
		Private toggleBandedRowsItem1 As UI.ToggleBandedRowsItem
		Private toggleFirstColumnItem1 As UI.ToggleFirstColumnItem
		Private toggleLastColumnItem1 As UI.ToggleLastColumnItem
		Private toggleBandedColumnItem1 As UI.ToggleBandedColumnsItem
		Private galleryChangeTableStyleItem1 As UI.GalleryChangeTableStyleItem
		Private changeTableBorderLineStyleItem1 As UI.ChangeTableBorderLineStyleItem
		Private repositoryItemBorderLineStyle1 As XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
		Private changeTableBorderLineWeightItem1 As UI.ChangeTableBorderLineWeightItem
		Private repositoryItemBorderLineWeight1 As XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
		Private changeTableBorderColorItem1 As UI.ChangeTableBorderColorItem
		Private changeTableBordersItem1 As UI.ChangeTableBordersItem
		Private toggleTableCellsBottomBorderItem1 As UI.ToggleTableCellsBottomBorderItem
		Private toggleTableCellsTopBorderItem1 As UI.ToggleTableCellsTopBorderItem
		Private toggleTableCellsLeftBorderItem1 As UI.ToggleTableCellsLeftBorderItem
		Private toggleTableCellsRightBorderItem1 As UI.ToggleTableCellsRightBorderItem
		Private resetTableCellsAllBordersItem1 As UI.ResetTableCellsAllBordersItem
		Private toggleTableCellsAllBordersItem1 As UI.ToggleTableCellsAllBordersItem
		Private toggleTableCellsOutsideBorderItem1 As UI.ToggleTableCellsOutsideBorderItem
		Private toggleTableCellsInsideBorderItem1 As UI.ToggleTableCellsInsideBorderItem
		Private toggleTableCellsInsideHorizontalBorderItem1 As UI.ToggleTableCellsInsideHorizontalBorderItem
		Private toggleTableCellsInsideVerticalBorderItem1 As UI.ToggleTableCellsInsideVerticalBorderItem
		Private toggleShowTableGridLinesItem1 As UI.ToggleShowTableGridLinesItem
		Private changeTableCellsShadingItem1 As UI.ChangeTableCellsShadingItem
		Private selectTableElementsItem1 As UI.SelectTableElementsItem
		Private selectTableCellItem1 As UI.SelectTableCellItem
		Private selectTableColumnItem1 As UI.SelectTableColumnItem
		Private selectTableRowItem1 As UI.SelectTableRowItem
		Private selectTableItem1 As UI.SelectTableItem
		Private showTablePropertiesFormItem1 As UI.ShowTablePropertiesFormItem
		Private deleteTableElementsItem1 As UI.DeleteTableElementsItem
		Private showDeleteTableCellsFormItem1 As UI.ShowDeleteTableCellsFormItem
		Private deleteTableColumnsItem1 As UI.DeleteTableColumnsItem
		Private deleteTableRowsItem1 As UI.DeleteTableRowsItem
		Private deleteTableItem1 As UI.DeleteTableItem
		Private insertTableRowAboveItem1 As UI.InsertTableRowAboveItem
		Private insertTableRowBelowItem1 As UI.InsertTableRowBelowItem
		Private insertTableColumnToLeftItem1 As UI.InsertTableColumnToLeftItem
		Private insertTableColumnToRightItem1 As UI.InsertTableColumnToRightItem
		Private mergeTableCellsItem1 As UI.MergeTableCellsItem
		Private showSplitTableCellsForm1 As UI.ShowSplitTableCellsForm
		Private splitTableItem1 As UI.SplitTableItem
		Private toggleTableAutoFitItem1 As UI.ToggleTableAutoFitItem
		Private toggleTableAutoFitContentsItem1 As UI.ToggleTableAutoFitContentsItem
		Private toggleTableAutoFitWindowItem1 As UI.ToggleTableAutoFitWindowItem
		Private toggleTableFixedColumnWidthItem1 As UI.ToggleTableFixedColumnWidthItem
		Private toggleTableCellsTopLeftAlignmentItem1 As UI.ToggleTableCellsTopLeftAlignmentItem
		Private toggleTableCellsMiddleLeftAlignmentItem1 As UI.ToggleTableCellsMiddleLeftAlignmentItem
		Private toggleTableCellsBottomLeftAlignmentItem1 As UI.ToggleTableCellsBottomLeftAlignmentItem
		Private toggleTableCellsTopCenterAlignmentItem1 As UI.ToggleTableCellsTopCenterAlignmentItem
		Private toggleTableCellsMiddleCenterAlignmentItem1 As UI.ToggleTableCellsMiddleCenterAlignmentItem
		Private toggleTableCellsBottomCenterAlignmentItem1 As UI.ToggleTableCellsBottomCenterAlignmentItem
		Private toggleTableCellsTopRightAlignmentItem1 As UI.ToggleTableCellsTopRightAlignmentItem
		Private toggleTableCellsMiddleRightAlignmentItem1 As UI.ToggleTableCellsMiddleRightAlignmentItem
		Private toggleTableCellsBottomRightAlignmentItem1 As UI.ToggleTableCellsBottomRightAlignmentItem
		Private showTableOptionsFormItem1 As UI.ShowTableOptionsFormItem
		Private changeFloatingObjectFillColorItem1 As UI.ChangeFloatingObjectFillColorItem
		Private changeFloatingObjectOutlineColorItem1 As UI.ChangeFloatingObjectOutlineColorItem
		Private changeFloatingObjectOutlineWeightItem1 As UI.ChangeFloatingObjectOutlineWeightItem
		Private repositoryItemFloatingObjectOutlineWeight1 As XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
		Private changeFloatingObjectTextWrapTypeItem1 As UI.ChangeFloatingObjectTextWrapTypeItem
		Private setFloatingObjectSquareTextWrapTypeItem1 As UI.SetFloatingObjectSquareTextWrapTypeItem
		Private setFloatingObjectTightTextWrapTypeItem1 As UI.SetFloatingObjectTightTextWrapTypeItem
		Private setFloatingObjectThroughTextWrapTypeItem1 As UI.SetFloatingObjectThroughTextWrapTypeItem
		Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
		Private setFloatingObjectBehindTextWrapTypeItem1 As UI.SetFloatingObjectBehindTextWrapTypeItem
		Private setFloatingObjectInFrontOfTextWrapTypeItem1 As UI.SetFloatingObjectInFrontOfTextWrapTypeItem
		Private changeFloatingObjectAlignmentItem1 As UI.ChangeFloatingObjectAlignmentItem
		Private setFloatingObjectTopLeftAlignmentItem1 As UI.SetFloatingObjectTopLeftAlignmentItem
		Private setFloatingObjectTopCenterAlignmentItem1 As UI.SetFloatingObjectTopCenterAlignmentItem
		Private setFloatingObjectTopRightAlignmentItem1 As UI.SetFloatingObjectTopRightAlignmentItem
		Private setFloatingObjectMiddleLeftAlignmentItem1 As UI.SetFloatingObjectMiddleLeftAlignmentItem
		Private setFloatingObjectMiddleCenterAlignmentItem1 As UI.SetFloatingObjectMiddleCenterAlignmentItem
		Private setFloatingObjectMiddleRightAlignmentItem1 As UI.SetFloatingObjectMiddleRightAlignmentItem
		Private setFloatingObjectBottomLeftAlignmentItem1 As UI.SetFloatingObjectBottomLeftAlignmentItem
		Private setFloatingObjectBottomCenterAlignmentItem1 As UI.SetFloatingObjectBottomCenterAlignmentItem
		Private setFloatingObjectBottomRightAlignmentItem1 As UI.SetFloatingObjectBottomRightAlignmentItem
		Private floatingObjectBringForwardSubItem1 As UI.FloatingObjectBringForwardSubItem
		Private floatingObjectBringForwardItem1 As UI.FloatingObjectBringForwardItem
		Private floatingObjectBringToFrontItem1 As UI.FloatingObjectBringToFrontItem
		Private floatingObjectBringInFrontOfTextItem1 As UI.FloatingObjectBringInFrontOfTextItem
		Private floatingObjectSendBackwardSubItem1 As UI.FloatingObjectSendBackwardSubItem
		Private floatingObjectSendBackwardItem1 As UI.FloatingObjectSendBackwardItem
		Private floatingObjectSendToBackItem1 As UI.FloatingObjectSendToBackItem
		Private floatingObjectSendBehindTextItem1 As UI.FloatingObjectSendBehindTextItem
		Private headerFooterToolsRibbonPageCategory1 As UI.HeaderFooterToolsRibbonPageCategory
		Private headerFooterToolsDesignRibbonPage1 As UI.HeaderFooterToolsDesignRibbonPage
		Private headerFooterToolsDesignNavigationRibbonPageGroup1 As UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
		Private headerFooterToolsDesignOptionsRibbonPageGroup1 As UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
		Private headerFooterToolsDesignCloseRibbonPageGroup1 As UI.HeaderFooterToolsDesignCloseRibbonPageGroup
		Private tableToolsRibbonPageCategory1 As UI.TableToolsRibbonPageCategory
		Private tableDesignRibbonPage1 As UI.TableDesignRibbonPage
		Private tableStyleOptionsRibbonPageGroup1 As UI.TableStyleOptionsRibbonPageGroup
		Private tableStylesRibbonPageGroup1 As UI.TableStylesRibbonPageGroup
		Private tableDrawBordersRibbonPageGroup1 As UI.TableDrawBordersRibbonPageGroup
		Private tableLayoutRibbonPage1 As UI.TableLayoutRibbonPage
		Private tableTableRibbonPageGroup1 As UI.TableTableRibbonPageGroup
		Private tableRowsAndColumnsRibbonPageGroup1 As UI.TableRowsAndColumnsRibbonPageGroup
		Private tableMergeRibbonPageGroup1 As UI.TableMergeRibbonPageGroup
		Private tableCellSizeRibbonPageGroup1 As UI.TableCellSizeRibbonPageGroup
		Private tableAlignmentRibbonPageGroup1 As UI.TableAlignmentRibbonPageGroup
		Private floatingPictureToolsRibbonPageCategory1 As UI.FloatingPictureToolsRibbonPageCategory
		Private floatingPictureToolsFormatPage1 As UI.FloatingPictureToolsFormatPage
		Private floatingPictureToolsShapeStylesPageGroup1 As UI.FloatingPictureToolsShapeStylesPageGroup
		Private floatingPictureToolsArrangePageGroup1 As UI.FloatingPictureToolsArrangePageGroup
		Private homeRibbonPage1 As UI.HomeRibbonPage
		Private clipboardRibbonPageGroup1 As UI.ClipboardRibbonPageGroup
		Private fontRibbonPageGroup1 As UI.FontRibbonPageGroup
		Private paragraphRibbonPageGroup1 As UI.ParagraphRibbonPageGroup
		Private stylesRibbonPageGroup1 As UI.StylesRibbonPageGroup
		Private editingRibbonPageGroup1 As UI.EditingRibbonPageGroup
		Private pageLayoutRibbonPage1 As UI.PageLayoutRibbonPage
		Private pageSetupRibbonPageGroup1 As UI.PageSetupRibbonPageGroup
		Private pageBackgroundRibbonPageGroup1 As UI.PageBackgroundRibbonPageGroup
		Private referencesRibbonPage1 As UI.ReferencesRibbonPage
		Private tableOfContentsRibbonPageGroup1 As UI.TableOfContentsRibbonPageGroup
		Private captionsRibbonPageGroup1 As UI.CaptionsRibbonPageGroup
		Private mailingsRibbonPage1 As UI.MailingsRibbonPage
		Private mailMergeRibbonPageGroup1 As UI.MailMergeRibbonPageGroup
		Private viewRibbonPage1 As UI.ViewRibbonPage
		Private documentViewsRibbonPageGroup1 As UI.DocumentViewsRibbonPageGroup
		Private showRibbonPageGroup1 As UI.ShowRibbonPageGroup
		Private zoomRibbonPageGroup1 As UI.ZoomRibbonPageGroup
		Private insertPageBreakItem2 As UI.InsertPageBreakItem
		Private WithEvents barButtonItem1 As XtraBars.BarButtonItem
		Private WithEvents exportToPdfBarButtonItem As XtraBars.BarButtonItem
		Private exportToPdfRibbonPageGroup As XtraBars.Ribbon.RibbonPageGroup
		Private insertPageBreakItem21 As UI.InsertPageBreakItem2
		Private insertRibbonPage1 As UI.InsertRibbonPage
		Private pagesRibbonPageGroup1 As UI.PagesRibbonPageGroup
		Private tablesRibbonPageGroup1 As UI.TablesRibbonPageGroup
		Private illustrationsRibbonPageGroup1 As UI.IllustrationsRibbonPageGroup
		Private linksRibbonPageGroup1 As UI.LinksRibbonPageGroup
		Private headerFooterRibbonPageGroup1 As UI.HeaderFooterRibbonPageGroup
		Private textRibbonPageGroup1 As UI.TextRibbonPageGroup
		Private symbolsRibbonPageGroup1 As UI.SymbolsRibbonPageGroup
		Private fileRibbonPage1 As UI.FileRibbonPage
        Private commonRibbonPageGroup1 As UI.CommonRibbonPageGroup
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
	End Class
End Namespace
