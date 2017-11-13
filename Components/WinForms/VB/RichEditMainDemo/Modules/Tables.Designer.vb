Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class TablesModule
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TablesModule))
            Dim BorderInfo1 As DevExpress.XtraRichEdit.Model.BorderInfo = New DevExpress.XtraRichEdit.Model.BorderInfo
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.tablesBar1 = New DevExpress.XtraRichEdit.UI.TablesBar
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem
            Me.tableStylesBar1 = New DevExpress.XtraRichEdit.UI.TableStylesBar
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
            Me.tableDrawBordersBar1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersBar
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
            Me.tableRowsAndColumnsBar1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsBar
            Me.deleteTableElementBarItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
            Me.deleteTableCellsItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
            Me.showInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
            Me.tableMergeBar1 = New DevExpress.XtraRichEdit.UI.TableMergeBar
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
            Me.tableTableBar1 = New DevExpress.XtraRichEdit.UI.TableTableBar
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
            Me.tableCellSizeBar1 = New DevExpress.XtraRichEdit.UI.TableCellSizeBar
            Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
            Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
            Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
            Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem
            Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
            Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem
            Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
            Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
            Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
            Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
            Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
            Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController
            Me.TableAlignmentBar1 = New DevExpress.XtraRichEdit.UI.TableAlignmentBar
            Me.ShowTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.tablesBar1, Me.commonBar1, Me.clipboardBar1, Me.tableStylesBar1, Me.tableDrawBordersBar1, Me.tableRowsAndColumnsBar1, Me.tableMergeBar1, Me.tableTableBar1, Me.tableCellSizeBar1, Me.TableAlignmentBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.insertPictureItem1, Me.insertTableItem1, Me.insertPageBreakItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.goToNextHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.insertSymbolItem1, Me.insertTableRowBelowItem1, Me.insertTableRowAboveItem1, Me.mergeTableCellsItem1, Me.splitTableItem1, Me.changeTableCellsShadingItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.deleteTableElementBarItem1, Me.deleteTableCellsItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showInsertTableCellsFormItem1, Me.showSplitTableCellsForm1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.toggleShowTableGridLinesItem1, Me.showTablePropertiesFormItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.ShowTableOptionsFormItem1})
            Me.barManager1.MaxItemId = 122
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1})
            '
            'tablesBar1
            '
            Me.tablesBar1.DockCol = 2
            Me.tablesBar1.DockRow = 0
            Me.tablesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tablesBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableItem1)})
            '
            'insertTableItem1
            '
            Me.insertTableItem1.Glyph = CType(resources.GetObject("insertTableItem1.Glyph"), System.Drawing.Image)
            Me.insertTableItem1.Id = 57
            Me.insertTableItem1.LargeGlyph = CType(resources.GetObject("insertTableItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTableItem1.Name = "insertTableItem1"
            '
            'commonBar1
            '
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            '
            'undoItem1
            '
            Me.undoItem1.Glyph = CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image)
            Me.undoItem1.Id = 7
            Me.undoItem1.LargeGlyph = CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image)
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Glyph = CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image)
            Me.redoItem1.Id = 8
            Me.redoItem1.LargeGlyph = CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image)
            Me.redoItem1.Name = "redoItem1"
            '
            'clipboardBar1
            '
            Me.clipboardBar1.DockCol = 1
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            '
            'cutItem1
            '
            Me.cutItem1.Glyph = CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image)
            Me.cutItem1.Id = 9
            Me.cutItem1.LargeGlyph = CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image)
            Me.cutItem1.Name = "cutItem1"
            '
            'copyItem1
            '
            Me.copyItem1.Glyph = CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image)
            Me.copyItem1.Id = 10
            Me.copyItem1.LargeGlyph = CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image)
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Glyph = CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image)
            Me.pasteItem1.Id = 11
            Me.pasteItem1.LargeGlyph = CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image)
            Me.pasteItem1.Name = "pasteItem1"
            '
            'tableStylesBar1
            '
            Me.tableStylesBar1.DockCol = 3
            Me.tableStylesBar1.DockRow = 0
            Me.tableStylesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableStylesBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeTableCellsShadingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeTableBordersItem1)})
            '
            'changeTableCellsShadingItem1
            '
            Me.changeTableCellsShadingItem1.Glyph = CType(resources.GetObject("changeTableCellsShadingItem1.Glyph"), System.Drawing.Image)
            Me.changeTableCellsShadingItem1.Id = 76
            Me.changeTableCellsShadingItem1.LargeGlyph = CType(resources.GetObject("changeTableCellsShadingItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            '
            'changeTableBordersItem1
            '
            Me.changeTableBordersItem1.Glyph = CType(resources.GetObject("changeTableBordersItem1.Glyph"), System.Drawing.Image)
            Me.changeTableBordersItem1.Id = 77
            Me.changeTableBordersItem1.LargeGlyph = CType(resources.GetObject("changeTableBordersItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1)})
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            Me.changeTableBordersItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'toggleTableCellsBottomBorderItem1
            '
            Me.toggleTableCellsBottomBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsBottomBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomBorderItem1.Id = 78
            Me.toggleTableCellsBottomBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsBottomBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            '
            'toggleTableCellsTopBorderItem1
            '
            Me.toggleTableCellsTopBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsTopBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsTopBorderItem1.Id = 79
            Me.toggleTableCellsTopBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsTopBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            '
            'toggleTableCellsLeftBorderItem1
            '
            Me.toggleTableCellsLeftBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsLeftBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsLeftBorderItem1.Id = 80
            Me.toggleTableCellsLeftBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsLeftBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            '
            'toggleTableCellsRightBorderItem1
            '
            Me.toggleTableCellsRightBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsRightBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsRightBorderItem1.Id = 81
            Me.toggleTableCellsRightBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsRightBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            '
            'resetTableCellsAllBordersItem1
            '
            Me.resetTableCellsAllBordersItem1.Glyph = CType(resources.GetObject("resetTableCellsAllBordersItem1.Glyph"), System.Drawing.Image)
            Me.resetTableCellsAllBordersItem1.Id = 82
            Me.resetTableCellsAllBordersItem1.LargeGlyph = CType(resources.GetObject("resetTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image)
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            '
            'toggleTableCellsAllBordersItem1
            '
            Me.toggleTableCellsAllBordersItem1.Glyph = CType(resources.GetObject("toggleTableCellsAllBordersItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsAllBordersItem1.Id = 83
            Me.toggleTableCellsAllBordersItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            '
            'toggleTableCellsOutsideBorderItem1
            '
            Me.toggleTableCellsOutsideBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsOutsideBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsOutsideBorderItem1.Id = 84
            Me.toggleTableCellsOutsideBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsOutsideBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            '
            'toggleTableCellsInsideBorderItem1
            '
            Me.toggleTableCellsInsideBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsInsideBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideBorderItem1.Id = 85
            Me.toggleTableCellsInsideBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsInsideBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            '
            'toggleTableCellsInsideHorizontalBorderItem1
            '
            Me.toggleTableCellsInsideHorizontalBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 86
            Me.toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            '
            'toggleTableCellsInsideVerticalBorderItem1
            '
            Me.toggleTableCellsInsideVerticalBorderItem1.Glyph = CType(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 87
            Me.toggleTableCellsInsideVerticalBorderItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            '
            'tableDrawBordersBar1
            '
            Me.tableDrawBordersBar1.DockCol = 4
            Me.tableDrawBordersBar1.DockRow = 0
            Me.tableDrawBordersBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableDrawBordersBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeTableBorderLineStyleItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeTableBorderLineWeightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeTableBorderColorItem1)})
            '
            'changeTableBorderLineStyleItem1
            '
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            BorderInfo1.Color = System.Drawing.Color.Black
            BorderInfo1.Frame = False
            BorderInfo1.Offset = 0
            BorderInfo1.Shadow = False
            BorderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.[Single]
            BorderInfo1.Width = 10
            Me.changeTableBorderLineStyleItem1.EditValue = BorderInfo1
            Me.changeTableBorderLineStyleItem1.Id = 88
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            '
            'repositoryItemBorderLineStyle1
            '
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.richEditControl
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            '
            'richEditControl
            '
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 2)
            Me.richEditControl.MenuManager = Me.barManager1
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(1187, 515)
            Me.richEditControl.TabIndex = 0
            Me.richEditControl.Text = "richEditControl"
            '
            'changeTableBorderLineWeightItem1
            '
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.Id = 89
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
            Me.changeTableBorderColorItem1.Glyph = CType(resources.GetObject("changeTableBorderColorItem1.Glyph"), System.Drawing.Image)
            Me.changeTableBorderColorItem1.Id = 90
            Me.changeTableBorderColorItem1.LargeGlyph = CType(resources.GetObject("changeTableBorderColorItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            '
            'tableRowsAndColumnsBar1
            '
            Me.tableRowsAndColumnsBar1.DockCol = 2
            Me.tableRowsAndColumnsBar1.DockRow = 1
            Me.tableRowsAndColumnsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableRowsAndColumnsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableElementBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableRowAboveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableRowBelowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableColumnToLeftItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableColumnToRightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showInsertTableCellsFormItem1)})
            '
            'deleteTableElementBarItem1
            '
            Me.deleteTableElementBarItem1.Glyph = CType(resources.GetObject("deleteTableElementBarItem1.Glyph"), System.Drawing.Image)
            Me.deleteTableElementBarItem1.Id = 93
            Me.deleteTableElementBarItem1.LargeGlyph = CType(resources.GetObject("deleteTableElementBarItem1.LargeGlyph"), System.Drawing.Image)
            Me.deleteTableElementBarItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableCellsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)})
            Me.deleteTableElementBarItem1.Name = "deleteTableElementBarItem1"
            Me.deleteTableElementBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'deleteTableCellsItem1
            '
            Me.deleteTableCellsItem1.Glyph = CType(resources.GetObject("deleteTableCellsItem1.Glyph"), System.Drawing.Image)
            Me.deleteTableCellsItem1.Id = 94
            Me.deleteTableCellsItem1.LargeGlyph = CType(resources.GetObject("deleteTableCellsItem1.LargeGlyph"), System.Drawing.Image)
            Me.deleteTableCellsItem1.Name = "deleteTableCellsItem1"
            '
            'deleteTableColumnsItem1
            '
            Me.deleteTableColumnsItem1.Glyph = CType(resources.GetObject("deleteTableColumnsItem1.Glyph"), System.Drawing.Image)
            Me.deleteTableColumnsItem1.Id = 95
            Me.deleteTableColumnsItem1.LargeGlyph = CType(resources.GetObject("deleteTableColumnsItem1.LargeGlyph"), System.Drawing.Image)
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            '
            'deleteTableRowsItem1
            '
            Me.deleteTableRowsItem1.Glyph = CType(resources.GetObject("deleteTableRowsItem1.Glyph"), System.Drawing.Image)
            Me.deleteTableRowsItem1.Id = 96
            Me.deleteTableRowsItem1.LargeGlyph = CType(resources.GetObject("deleteTableRowsItem1.LargeGlyph"), System.Drawing.Image)
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            '
            'deleteTableItem1
            '
            Me.deleteTableItem1.Glyph = CType(resources.GetObject("deleteTableItem1.Glyph"), System.Drawing.Image)
            Me.deleteTableItem1.Id = 97
            Me.deleteTableItem1.LargeGlyph = CType(resources.GetObject("deleteTableItem1.LargeGlyph"), System.Drawing.Image)
            Me.deleteTableItem1.Name = "deleteTableItem1"
            '
            'insertTableRowAboveItem1
            '
            Me.insertTableRowAboveItem1.Glyph = CType(resources.GetObject("insertTableRowAboveItem1.Glyph"), System.Drawing.Image)
            Me.insertTableRowAboveItem1.Id = 73
            Me.insertTableRowAboveItem1.LargeGlyph = CType(resources.GetObject("insertTableRowAboveItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            '
            'insertTableRowBelowItem1
            '
            Me.insertTableRowBelowItem1.Glyph = CType(resources.GetObject("insertTableRowBelowItem1.Glyph"), System.Drawing.Image)
            Me.insertTableRowBelowItem1.Id = 72
            Me.insertTableRowBelowItem1.LargeGlyph = CType(resources.GetObject("insertTableRowBelowItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            '
            'insertTableColumnToLeftItem1
            '
            Me.insertTableColumnToLeftItem1.Glyph = CType(resources.GetObject("insertTableColumnToLeftItem1.Glyph"), System.Drawing.Image)
            Me.insertTableColumnToLeftItem1.Id = 91
            Me.insertTableColumnToLeftItem1.LargeGlyph = CType(resources.GetObject("insertTableColumnToLeftItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            '
            'insertTableColumnToRightItem1
            '
            Me.insertTableColumnToRightItem1.Glyph = CType(resources.GetObject("insertTableColumnToRightItem1.Glyph"), System.Drawing.Image)
            Me.insertTableColumnToRightItem1.Id = 92
            Me.insertTableColumnToRightItem1.LargeGlyph = CType(resources.GetObject("insertTableColumnToRightItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            '
            'showInsertTableCellsFormItem1
            '
            Me.showInsertTableCellsFormItem1.Glyph = CType(resources.GetObject("showInsertTableCellsFormItem1.Glyph"), System.Drawing.Image)
            Me.showInsertTableCellsFormItem1.Id = 109
            Me.showInsertTableCellsFormItem1.LargeGlyph = CType(resources.GetObject("showInsertTableCellsFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1"
            '
            'tableMergeBar1
            '
            Me.tableMergeBar1.DockCol = 1
            Me.tableMergeBar1.DockRow = 1
            Me.tableMergeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableMergeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mergeTableCellsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showSplitTableCellsForm1), New DevExpress.XtraBars.LinkPersistInfo(Me.splitTableItem1)})
            '
            'mergeTableCellsItem1
            '
            Me.mergeTableCellsItem1.Glyph = CType(resources.GetObject("mergeTableCellsItem1.Glyph"), System.Drawing.Image)
            Me.mergeTableCellsItem1.Id = 74
            Me.mergeTableCellsItem1.LargeGlyph = CType(resources.GetObject("mergeTableCellsItem1.LargeGlyph"), System.Drawing.Image)
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            '
            'showSplitTableCellsForm1
            '
            Me.showSplitTableCellsForm1.Glyph = CType(resources.GetObject("showSplitTableCellsForm1.Glyph"), System.Drawing.Image)
            Me.showSplitTableCellsForm1.Id = 108
            Me.showSplitTableCellsForm1.LargeGlyph = CType(resources.GetObject("showSplitTableCellsForm1.LargeGlyph"), System.Drawing.Image)
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            '
            'splitTableItem1
            '
            Me.splitTableItem1.Glyph = CType(resources.GetObject("splitTableItem1.Glyph"), System.Drawing.Image)
            Me.splitTableItem1.Id = 75
            Me.splitTableItem1.LargeGlyph = CType(resources.GetObject("splitTableItem1.LargeGlyph"), System.Drawing.Image)
            Me.splitTableItem1.Name = "splitTableItem1"
            '
            'toggleTableCellsTopLeftAlignmentItem1
            '
            Me.toggleTableCellsTopLeftAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 99
            Me.toggleTableCellsTopLeftAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            '
            'toggleTableCellsTopCenterAlignmentItem1
            '
            Me.toggleTableCellsTopCenterAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 100
            Me.toggleTableCellsTopCenterAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            '
            'toggleTableCellsTopRightAlignmentItem1
            '
            Me.toggleTableCellsTopRightAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 101
            Me.toggleTableCellsTopRightAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            '
            'toggleTableCellsMiddleLeftAlignmentItem1
            '
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 102
            Me.toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            '
            'toggleTableCellsMiddleCenterAlignmentItem1
            '
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 103
            Me.toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            '
            'toggleTableCellsMiddleRightAlignmentItem1
            '
            Me.toggleTableCellsMiddleRightAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 104
            Me.toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            '
            'toggleTableCellsBottomLeftAlignmentItem1
            '
            Me.toggleTableCellsBottomLeftAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 105
            Me.toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            '
            'toggleTableCellsBottomCenterAlignmentItem1
            '
            Me.toggleTableCellsBottomCenterAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 106
            Me.toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            '
            'toggleTableCellsBottomRightAlignmentItem1
            '
            Me.toggleTableCellsBottomRightAlignmentItem1.Glyph = CType(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 107
            Me.toggleTableCellsBottomRightAlignmentItem1.LargeGlyph = CType(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            '
            'tableTableBar1
            '
            Me.tableTableBar1.DockCol = 0
            Me.tableTableBar1.DockRow = 1
            Me.tableTableBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableTableBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableElementsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showTablePropertiesFormItem1)})
            '
            'selectTableElementsItem1
            '
            Me.selectTableElementsItem1.Glyph = CType(resources.GetObject("selectTableElementsItem1.Glyph"), System.Drawing.Image)
            Me.selectTableElementsItem1.Id = 110
            Me.selectTableElementsItem1.LargeGlyph = CType(resources.GetObject("selectTableElementsItem1.LargeGlyph"), System.Drawing.Image)
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)})
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            Me.selectTableElementsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'selectTableCellItem1
            '
            Me.selectTableCellItem1.Glyph = CType(resources.GetObject("selectTableCellItem1.Glyph"), System.Drawing.Image)
            Me.selectTableCellItem1.Id = 111
            Me.selectTableCellItem1.LargeGlyph = CType(resources.GetObject("selectTableCellItem1.LargeGlyph"), System.Drawing.Image)
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            '
            'selectTableColumnItem1
            '
            Me.selectTableColumnItem1.Glyph = CType(resources.GetObject("selectTableColumnItem1.Glyph"), System.Drawing.Image)
            Me.selectTableColumnItem1.Id = 112
            Me.selectTableColumnItem1.LargeGlyph = CType(resources.GetObject("selectTableColumnItem1.LargeGlyph"), System.Drawing.Image)
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            '
            'selectTableRowItem1
            '
            Me.selectTableRowItem1.Glyph = CType(resources.GetObject("selectTableRowItem1.Glyph"), System.Drawing.Image)
            Me.selectTableRowItem1.Id = 113
            Me.selectTableRowItem1.LargeGlyph = CType(resources.GetObject("selectTableRowItem1.LargeGlyph"), System.Drawing.Image)
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            '
            'selectTableItem1
            '
            Me.selectTableItem1.Glyph = CType(resources.GetObject("selectTableItem1.Glyph"), System.Drawing.Image)
            Me.selectTableItem1.Id = 114
            Me.selectTableItem1.LargeGlyph = CType(resources.GetObject("selectTableItem1.LargeGlyph"), System.Drawing.Image)
            Me.selectTableItem1.Name = "selectTableItem1"
            '
            'toggleShowTableGridLinesItem1
            '
            Me.toggleShowTableGridLinesItem1.Glyph = CType(resources.GetObject("toggleShowTableGridLinesItem1.Glyph"), System.Drawing.Image)
            Me.toggleShowTableGridLinesItem1.Id = 115
            Me.toggleShowTableGridLinesItem1.LargeGlyph = CType(resources.GetObject("toggleShowTableGridLinesItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            '
            'showTablePropertiesFormItem1
            '
            Me.showTablePropertiesFormItem1.Glyph = CType(resources.GetObject("showTablePropertiesFormItem1.Glyph"), System.Drawing.Image)
            Me.showTablePropertiesFormItem1.Id = 116
            Me.showTablePropertiesFormItem1.LargeGlyph = CType(resources.GetObject("showTablePropertiesFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            '
            'tableCellSizeBar1
            '
            Me.tableCellSizeBar1.DockCol = 3
            Me.tableCellSizeBar1.DockRow = 1
            Me.tableCellSizeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.tableCellSizeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitItem1)})
            '
            'toggleTableAutoFitItem1
            '
            Me.toggleTableAutoFitItem1.Glyph = CType(resources.GetObject("toggleTableAutoFitItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableAutoFitItem1.Id = 117
            Me.toggleTableAutoFitItem1.LargeGlyph = CType(resources.GetObject("toggleTableAutoFitItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)})
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            Me.toggleTableAutoFitItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'toggleTableAutoFitContentsItem1
            '
            Me.toggleTableAutoFitContentsItem1.Glyph = CType(resources.GetObject("toggleTableAutoFitContentsItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableAutoFitContentsItem1.Id = 118
            Me.toggleTableAutoFitContentsItem1.LargeGlyph = CType(resources.GetObject("toggleTableAutoFitContentsItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            '
            'toggleTableAutoFitWindowItem1
            '
            Me.toggleTableAutoFitWindowItem1.Glyph = CType(resources.GetObject("toggleTableAutoFitWindowItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableAutoFitWindowItem1.Id = 119
            Me.toggleTableAutoFitWindowItem1.LargeGlyph = CType(resources.GetObject("toggleTableAutoFitWindowItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            '
            'toggleTableFixedColumnWidthItem1
            '
            Me.toggleTableFixedColumnWidthItem1.Glyph = CType(resources.GetObject("toggleTableFixedColumnWidthItem1.Glyph"), System.Drawing.Image)
            Me.toggleTableFixedColumnWidthItem1.Id = 120
            Me.toggleTableFixedColumnWidthItem1.LargeGlyph = CType(resources.GetObject("toggleTableFixedColumnWidthItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(1191, 62)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 581)
            Me.barDockControlBottom.Size = New System.Drawing.Size(1191, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 519)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1191, 62)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 519)
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 12
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
            Me.changeFontSizeItem1.Id = 13
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            '
            'repositoryItemRichEditFontSizeEdit1
            '
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            '
            'changeFontColorItem1
            '
            Me.changeFontColorItem1.Glyph = CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image)
            Me.changeFontColorItem1.Id = 14
            Me.changeFontColorItem1.LargeGlyph = CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            '
            'changeFontBackColorItem1
            '
            Me.changeFontBackColorItem1.Glyph = CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image)
            Me.changeFontBackColorItem1.Id = 15
            Me.changeFontBackColorItem1.LargeGlyph = CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            '
            'toggleFontBoldItem1
            '
            Me.toggleFontBoldItem1.Glyph = CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontBoldItem1.Id = 16
            Me.toggleFontBoldItem1.LargeGlyph = CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            '
            'toggleFontItalicItem1
            '
            Me.toggleFontItalicItem1.Glyph = CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontItalicItem1.Id = 17
            Me.toggleFontItalicItem1.LargeGlyph = CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            '
            'toggleFontUnderlineItem1
            '
            Me.toggleFontUnderlineItem1.Glyph = CType(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontUnderlineItem1.Id = 18
            Me.toggleFontUnderlineItem1.LargeGlyph = CType(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            '
            'toggleFontDoubleUnderlineItem1
            '
            Me.toggleFontDoubleUnderlineItem1.Glyph = CType(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontDoubleUnderlineItem1.Id = 19
            Me.toggleFontDoubleUnderlineItem1.LargeGlyph = CType(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            '
            'toggleFontStrikeoutItem1
            '
            Me.toggleFontStrikeoutItem1.Glyph = CType(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontStrikeoutItem1.Id = 20
            Me.toggleFontStrikeoutItem1.LargeGlyph = CType(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            '
            'toggleFontDoubleStrikeoutItem1
            '
            Me.toggleFontDoubleStrikeoutItem1.Glyph = CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontDoubleStrikeoutItem1.Id = 21
            Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            '
            'toggleFontSuperscriptItem1
            '
            Me.toggleFontSuperscriptItem1.Glyph = CType(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontSuperscriptItem1.Id = 22
            Me.toggleFontSuperscriptItem1.LargeGlyph = CType(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            '
            'toggleFontSubscriptItem1
            '
            Me.toggleFontSubscriptItem1.Glyph = CType(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image)
            Me.toggleFontSubscriptItem1.Id = 23
            Me.toggleFontSubscriptItem1.LargeGlyph = CType(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            '
            'fontSizeIncreaseItem1
            '
            Me.fontSizeIncreaseItem1.Glyph = CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image)
            Me.fontSizeIncreaseItem1.Id = 24
            Me.fontSizeIncreaseItem1.LargeGlyph = CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image)
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            '
            'fontSizeDecreaseItem1
            '
            Me.fontSizeDecreaseItem1.Glyph = CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image)
            Me.fontSizeDecreaseItem1.Id = 25
            Me.fontSizeDecreaseItem1.LargeGlyph = CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image)
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            '
            'clearFormattingItem1
            '
            Me.clearFormattingItem1.Glyph = CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image)
            Me.clearFormattingItem1.Id = 26
            Me.clearFormattingItem1.LargeGlyph = CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image)
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            '
            'showFontFormItem1
            '
            Me.showFontFormItem1.Glyph = CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image)
            Me.showFontFormItem1.Id = 27
            Me.showFontFormItem1.LargeGlyph = CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.showFontFormItem1.Name = "showFontFormItem1"
            '
            'toggleParagraphAlignmentLeftItem1
            '
            Me.toggleParagraphAlignmentLeftItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentLeftItem1.Id = 28
            Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            '
            'toggleParagraphAlignmentCenterItem1
            '
            Me.toggleParagraphAlignmentCenterItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentCenterItem1.Id = 29
            Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            '
            'toggleParagraphAlignmentRightItem1
            '
            Me.toggleParagraphAlignmentRightItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentRightItem1.Id = 30
            Me.toggleParagraphAlignmentRightItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            '
            'toggleParagraphAlignmentJustifyItem1
            '
            Me.toggleParagraphAlignmentJustifyItem1.Glyph = CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentJustifyItem1.Id = 31
            Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            '
            'changeParagraphLineSpacingItem1
            '
            Me.changeParagraphLineSpacingItem1.Glyph = CType(resources.GetObject("changeParagraphLineSpacingItem1.Glyph"), System.Drawing.Image)
            Me.changeParagraphLineSpacingItem1.Id = 32
            Me.changeParagraphLineSpacingItem1.LargeGlyph = CType(resources.GetObject("changeParagraphLineSpacingItem1.LargeGlyph"), System.Drawing.Image)
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            '
            'setSingleParagraphSpacingItem1
            '
            Me.setSingleParagraphSpacingItem1.Id = 33
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            '
            'setSesquialteralParagraphSpacingItem1
            '
            Me.setSesquialteralParagraphSpacingItem1.Id = 34
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            '
            'setDoubleParagraphSpacingItem1
            '
            Me.setDoubleParagraphSpacingItem1.Id = 35
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            '
            'showLineSpacingFormItem1
            '
            Me.showLineSpacingFormItem1.Id = 36
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            '
            'addSpacingBeforeParagraphItem1
            '
            Me.addSpacingBeforeParagraphItem1.Id = 37
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            '
            'removeSpacingBeforeParagraphItem1
            '
            Me.removeSpacingBeforeParagraphItem1.Id = 38
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            '
            'addSpacingAfterParagraphItem1
            '
            Me.addSpacingAfterParagraphItem1.Id = 39
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            '
            'removeSpacingAfterParagraphItem1
            '
            Me.removeSpacingAfterParagraphItem1.Id = 40
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            '
            'toggleNumberingListItem1
            '
            Me.toggleNumberingListItem1.Glyph = CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image)
            Me.toggleNumberingListItem1.Id = 41
            Me.toggleNumberingListItem1.LargeGlyph = CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            '
            'toggleBulletedListItem1
            '
            Me.toggleBulletedListItem1.Glyph = CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image)
            Me.toggleBulletedListItem1.Id = 42
            Me.toggleBulletedListItem1.LargeGlyph = CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            '
            'toggleMultiLevelListItem1
            '
            Me.toggleMultiLevelListItem1.Glyph = CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image)
            Me.toggleMultiLevelListItem1.Id = 43
            Me.toggleMultiLevelListItem1.LargeGlyph = CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            '
            'decreaseIndentItem1
            '
            Me.decreaseIndentItem1.Glyph = CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image)
            Me.decreaseIndentItem1.Id = 44
            Me.decreaseIndentItem1.LargeGlyph = CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image)
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            '
            'increaseIndentItem1
            '
            Me.increaseIndentItem1.Glyph = CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image)
            Me.increaseIndentItem1.Id = 45
            Me.increaseIndentItem1.LargeGlyph = CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image)
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            '
            'toggleShowWhitespaceItem1
            '
            Me.toggleShowWhitespaceItem1.Glyph = CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image)
            Me.toggleShowWhitespaceItem1.Id = 46
            Me.toggleShowWhitespaceItem1.LargeGlyph = CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            '
            'showParagraphFormItem1
            '
            Me.showParagraphFormItem1.Glyph = CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image)
            Me.showParagraphFormItem1.Id = 47
            Me.showParagraphFormItem1.LargeGlyph = CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            '
            'changeStyleItem1
            '
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 48
            Me.changeStyleItem1.Name = "changeStyleItem1"
            '
            'repositoryItemRichEditStyleEdit1
            '
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            '
            'findItem1
            '
            Me.findItem1.Glyph = CType(resources.GetObject("findItem1.Glyph"), System.Drawing.Image)
            Me.findItem1.Id = 49
            Me.findItem1.LargeGlyph = CType(resources.GetObject("findItem1.LargeGlyph"), System.Drawing.Image)
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Glyph = CType(resources.GetObject("replaceItem1.Glyph"), System.Drawing.Image)
            Me.replaceItem1.Id = 50
            Me.replaceItem1.LargeGlyph = CType(resources.GetObject("replaceItem1.LargeGlyph"), System.Drawing.Image)
            Me.replaceItem1.Name = "replaceItem1"
            '
            'switchToSimpleViewItem1
            '
            Me.switchToSimpleViewItem1.Glyph = CType(resources.GetObject("switchToSimpleViewItem1.Glyph"), System.Drawing.Image)
            Me.switchToSimpleViewItem1.Id = 51
            Me.switchToSimpleViewItem1.LargeGlyph = CType(resources.GetObject("switchToSimpleViewItem1.LargeGlyph"), System.Drawing.Image)
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            '
            'switchToDraftViewItem1
            '
            Me.switchToDraftViewItem1.Glyph = CType(resources.GetObject("switchToDraftViewItem1.Glyph"), System.Drawing.Image)
            Me.switchToDraftViewItem1.Id = 52
            Me.switchToDraftViewItem1.LargeGlyph = CType(resources.GetObject("switchToDraftViewItem1.LargeGlyph"), System.Drawing.Image)
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            '
            'switchToPrintLayoutViewItem1
            '
            Me.switchToPrintLayoutViewItem1.Glyph = CType(resources.GetObject("switchToPrintLayoutViewItem1.Glyph"), System.Drawing.Image)
            Me.switchToPrintLayoutViewItem1.Id = 53
            Me.switchToPrintLayoutViewItem1.LargeGlyph = CType(resources.GetObject("switchToPrintLayoutViewItem1.LargeGlyph"), System.Drawing.Image)
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            '
            'zoomOutItem1
            '
            Me.zoomOutItem1.Glyph = CType(resources.GetObject("zoomOutItem1.Glyph"), System.Drawing.Image)
            Me.zoomOutItem1.Id = 54
            Me.zoomOutItem1.LargeGlyph = CType(resources.GetObject("zoomOutItem1.LargeGlyph"), System.Drawing.Image)
            Me.zoomOutItem1.Name = "zoomOutItem1"
            '
            'zoomInItem1
            '
            Me.zoomInItem1.Glyph = CType(resources.GetObject("zoomInItem1.Glyph"), System.Drawing.Image)
            Me.zoomInItem1.Id = 55
            Me.zoomInItem1.LargeGlyph = CType(resources.GetObject("zoomInItem1.LargeGlyph"), System.Drawing.Image)
            Me.zoomInItem1.Name = "zoomInItem1"
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Glyph = CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image)
            Me.insertPictureItem1.Id = 56
            Me.insertPictureItem1.LargeGlyph = CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Glyph = CType(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image)
            Me.insertPageBreakItem1.Id = 58
            Me.insertPageBreakItem1.LargeGlyph = CType(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Glyph = CType(resources.GetObject("insertBookmarkItem1.Glyph"), System.Drawing.Image)
            Me.insertBookmarkItem1.Id = 59
            Me.insertBookmarkItem1.LargeGlyph = CType(resources.GetObject("insertBookmarkItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Glyph = CType(resources.GetObject("insertHyperlinkItem1.Glyph"), System.Drawing.Image)
            Me.insertHyperlinkItem1.Id = 60
            Me.insertHyperlinkItem1.LargeGlyph = CType(resources.GetObject("insertHyperlinkItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'editPageHeaderItem1
            '
            Me.editPageHeaderItem1.Glyph = CType(resources.GetObject("editPageHeaderItem1.Glyph"), System.Drawing.Image)
            Me.editPageHeaderItem1.Id = 61
            Me.editPageHeaderItem1.LargeGlyph = CType(resources.GetObject("editPageHeaderItem1.LargeGlyph"), System.Drawing.Image)
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            '
            'editPageFooterItem1
            '
            Me.editPageFooterItem1.Glyph = CType(resources.GetObject("editPageFooterItem1.Glyph"), System.Drawing.Image)
            Me.editPageFooterItem1.Id = 62
            Me.editPageFooterItem1.LargeGlyph = CType(resources.GetObject("editPageFooterItem1.LargeGlyph"), System.Drawing.Image)
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            '
            'goToPageHeaderItem1
            '
            Me.goToPageHeaderItem1.Glyph = CType(resources.GetObject("goToPageHeaderItem1.Glyph"), System.Drawing.Image)
            Me.goToPageHeaderItem1.Id = 63
            Me.goToPageHeaderItem1.LargeGlyph = CType(resources.GetObject("goToPageHeaderItem1.LargeGlyph"), System.Drawing.Image)
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            '
            'goToPageFooterItem1
            '
            Me.goToPageFooterItem1.Glyph = CType(resources.GetObject("goToPageFooterItem1.Glyph"), System.Drawing.Image)
            Me.goToPageFooterItem1.Id = 64
            Me.goToPageFooterItem1.LargeGlyph = CType(resources.GetObject("goToPageFooterItem1.LargeGlyph"), System.Drawing.Image)
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            '
            'goToPreviousHeaderFooterItem1
            '
            Me.goToPreviousHeaderFooterItem1.Glyph = CType(resources.GetObject("goToPreviousHeaderFooterItem1.Glyph"), System.Drawing.Image)
            Me.goToPreviousHeaderFooterItem1.Id = 65
            Me.goToPreviousHeaderFooterItem1.LargeGlyph = CType(resources.GetObject("goToPreviousHeaderFooterItem1.LargeGlyph"), System.Drawing.Image)
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            '
            'goToNextHeaderFooterItem1
            '
            Me.goToNextHeaderFooterItem1.Glyph = CType(resources.GetObject("goToNextHeaderFooterItem1.Glyph"), System.Drawing.Image)
            Me.goToNextHeaderFooterItem1.Id = 66
            Me.goToNextHeaderFooterItem1.LargeGlyph = CType(resources.GetObject("goToNextHeaderFooterItem1.LargeGlyph"), System.Drawing.Image)
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            '
            'toggleLinkToPreviousItem1
            '
            Me.toggleLinkToPreviousItem1.Glyph = CType(resources.GetObject("toggleLinkToPreviousItem1.Glyph"), System.Drawing.Image)
            Me.toggleLinkToPreviousItem1.Id = 67
            Me.toggleLinkToPreviousItem1.LargeGlyph = CType(resources.GetObject("toggleLinkToPreviousItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            '
            'toggleDifferentFirstPageItem1
            '
            Me.toggleDifferentFirstPageItem1.Glyph = CType(resources.GetObject("toggleDifferentFirstPageItem1.Glyph"), System.Drawing.Image)
            Me.toggleDifferentFirstPageItem1.Id = 68
            Me.toggleDifferentFirstPageItem1.LargeGlyph = CType(resources.GetObject("toggleDifferentFirstPageItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            '
            'toggleDifferentOddAndEvenPagesItem1
            '
            Me.toggleDifferentOddAndEvenPagesItem1.Glyph = CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.Glyph"), System.Drawing.Image)
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 69
            Me.toggleDifferentOddAndEvenPagesItem1.LargeGlyph = CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.LargeGlyph"), System.Drawing.Image)
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            '
            'closePageHeaderFooterItem1
            '
            Me.closePageHeaderFooterItem1.Glyph = CType(resources.GetObject("closePageHeaderFooterItem1.Glyph"), System.Drawing.Image)
            Me.closePageHeaderFooterItem1.Id = 70
            Me.closePageHeaderFooterItem1.LargeGlyph = CType(resources.GetObject("closePageHeaderFooterItem1.LargeGlyph"), System.Drawing.Image)
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Glyph = CType(resources.GetObject("insertSymbolItem1.Glyph"), System.Drawing.Image)
            Me.insertSymbolItem1.Id = 71
            Me.insertSymbolItem1.LargeGlyph = CType(resources.GetObject("insertSymbolItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 62)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1191, 519)
            Me.panelControl1.TabIndex = 4
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.richEditBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.splitTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableElementBarItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.richEditBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.richEditBarController1.BarItems.Add(Me.showInsertTableCellsFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.richEditBarController1.BarItems.Add(Me.selectTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowTableOptionsFormItem1)
            Me.richEditBarController1.RichEditControl = Me.richEditControl
            '
            'TableAlignmentBar1
            '
            Me.TableAlignmentBar1.DockCol = 4
            Me.TableAlignmentBar1.DockRow = 1
            Me.TableAlignmentBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.TableAlignmentBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowTableOptionsFormItem1)})
            '
            'ShowTableOptionsFormItem1
            '
            Me.ShowTableOptionsFormItem1.Glyph = CType(resources.GetObject("ShowTableOptionsFormItem1.Glyph"), System.Drawing.Image)
            Me.ShowTableOptionsFormItem1.Id = 121
            Me.ShowTableOptionsFormItem1.LargeGlyph = CType(resources.GetObject("ShowTableOptionsFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.ShowTableOptionsFormItem1.Name = "ShowTableOptionsFormItem1"
            '
            'TablesModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "TablesModule"
            Me.Size = New System.Drawing.Size(1191, 581)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private richEditControl As RichEditControl
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
		Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
		Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
		Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
		Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
		Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
		Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
		Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
		Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
		Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
		Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
		Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
		Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
		Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
		Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
		Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
		Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
		Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
		Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
		Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
		Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
		Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
		Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
		Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
		Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
		Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
		Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
		Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
		Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
		Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
		Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
		Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
		Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
		Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
		Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
		Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
		Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
		Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
		Private tablesBar1 As DevExpress.XtraRichEdit.UI.TablesBar
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
		Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
		Private goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
		Private goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
		Private goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
		Private goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
		Private toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
		Private toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
		Private toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
		Private closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
		Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
		Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
		Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
		Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
		Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
		Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
		Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
		Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
		Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
		Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
		Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
		Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
		Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
		Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
		Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
		Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
		Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
		Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
		Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
		Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
		Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
		Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
		Private deleteTableElementBarItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
		Private deleteTableCellsItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
		Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
		Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
		Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
		Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
		Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
		Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
		Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
		Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
		Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
		Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
		Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
		Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
		Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
		Private showInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
		Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
		Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
		Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
		Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
		Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
		Private tableStylesBar1 As DevExpress.XtraRichEdit.UI.TableStylesBar
		Private tableDrawBordersBar1 As DevExpress.XtraRichEdit.UI.TableDrawBordersBar
		Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
		Private tableRowsAndColumnsBar1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsBar
		Private tableMergeBar1 As DevExpress.XtraRichEdit.UI.TableMergeBar
        Private tableTableBar1 As DevExpress.XtraRichEdit.UI.TableTableBar
		Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
		Private tableCellSizeBar1 As DevExpress.XtraRichEdit.UI.TableCellSizeBar
		Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
		Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
		Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Friend WithEvents TableAlignmentBar1 As DevExpress.XtraRichEdit.UI.TableAlignmentBar
        Friend WithEvents ShowTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
	End Class
End Namespace
