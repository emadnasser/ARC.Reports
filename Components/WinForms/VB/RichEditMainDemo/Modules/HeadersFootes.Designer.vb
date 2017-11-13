﻿Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class HeadersFootersModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HeadersFootersModule))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.headerFooterBar1 = New DevExpress.XtraRichEdit.UI.HeaderFooterBar()
			Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
			Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
			Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
			Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
			Me.headerFooterToolsDesignNavigationBar1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationBar()
			Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
			Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
			Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
			Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
			Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
			Me.headerFooterToolsDesignOptionsBar1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsBar()
			Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
			Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
			Me.headerFooterToolsDesignCloseBar1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseBar()
			Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
			Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
			Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
			Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
			Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
			Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
			Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
			Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
			Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
			Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
			Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
			Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
			Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
			Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
			Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
			Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
			Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
			Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
			Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
			Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
			Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
			Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
			Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
			Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
			Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
			Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
			Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
			Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
			Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
			Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
			Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
			Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
			Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
			Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
			Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
			Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
			Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
			Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
			Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
			Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.headerFooterBar1, Me.headerFooterToolsDesignNavigationBar1, Me.headerFooterToolsDesignOptionsBar1, Me.headerFooterToolsDesignCloseBar1, Me.commonBar1, Me.clipboardBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.goToNextHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1})
			Me.barManager1.MaxItemId = 63
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
			' 
			' headerFooterBar1
			' 
			Me.headerFooterBar1.DockCol = 2
			Me.headerFooterBar1.DockRow = 0
			Me.headerFooterBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.headerFooterBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.editPageHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.editPageFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageNumberItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageCountItem1)})
			' 
			' editPageHeaderItem1
			' 
			Me.editPageHeaderItem1.Glyph = (CType(resources.GetObject("editPageHeaderItem1.Glyph"), System.Drawing.Image))
			Me.editPageHeaderItem1.Id = 0
			Me.editPageHeaderItem1.LargeGlyph = (CType(resources.GetObject("editPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
			Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
			' 
			' editPageFooterItem1
			' 
			Me.editPageFooterItem1.Glyph = (CType(resources.GetObject("editPageFooterItem1.Glyph"), System.Drawing.Image))
			Me.editPageFooterItem1.Id = 1
			Me.editPageFooterItem1.LargeGlyph = (CType(resources.GetObject("editPageFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.editPageFooterItem1.Name = "editPageFooterItem1"
			' 
			' insertPageNumberItem1
			' 
			Me.insertPageNumberItem1.Glyph = (CType(resources.GetObject("insertPageNumberItem1.Glyph"), System.Drawing.Image))
			Me.insertPageNumberItem1.Id = 61
			Me.insertPageNumberItem1.LargeGlyph = (CType(resources.GetObject("insertPageNumberItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
			' 
			' insertPageCountItem1
			' 
			Me.insertPageCountItem1.Glyph = (CType(resources.GetObject("insertPageCountItem1.Glyph"), System.Drawing.Image))
			Me.insertPageCountItem1.Id = 62
			Me.insertPageCountItem1.LargeGlyph = (CType(resources.GetObject("insertPageCountItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPageCountItem1.Name = "insertPageCountItem1"
			' 
			' headerFooterToolsDesignNavigationBar1
			' 
			Me.headerFooterToolsDesignNavigationBar1.DockCol = 3
			Me.headerFooterToolsDesignNavigationBar1.DockRow = 0
			Me.headerFooterToolsDesignNavigationBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.headerFooterToolsDesignNavigationBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPreviousHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToNextHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleLinkToPreviousItem1)})
			' 
			' goToPageHeaderItem1
			' 
			Me.goToPageHeaderItem1.Glyph = (CType(resources.GetObject("goToPageHeaderItem1.Glyph"), System.Drawing.Image))
			Me.goToPageHeaderItem1.Id = 2
			Me.goToPageHeaderItem1.LargeGlyph = (CType(resources.GetObject("goToPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
			Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
			' 
			' goToPageFooterItem1
			' 
			Me.goToPageFooterItem1.Glyph = (CType(resources.GetObject("goToPageFooterItem1.Glyph"), System.Drawing.Image))
			Me.goToPageFooterItem1.Id = 3
			Me.goToPageFooterItem1.LargeGlyph = (CType(resources.GetObject("goToPageFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
			' 
			' goToPreviousHeaderFooterItem1
			' 
			Me.goToPreviousHeaderFooterItem1.Glyph = (CType(resources.GetObject("goToPreviousHeaderFooterItem1.Glyph"), System.Drawing.Image))
			Me.goToPreviousHeaderFooterItem1.Id = 4
			Me.goToPreviousHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("goToPreviousHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
			' 
			' goToNextHeaderFooterItem1
			' 
			Me.goToNextHeaderFooterItem1.Glyph = (CType(resources.GetObject("goToNextHeaderFooterItem1.Glyph"), System.Drawing.Image))
			Me.goToNextHeaderFooterItem1.Id = 5
			Me.goToNextHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("goToNextHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
			' 
			' toggleLinkToPreviousItem1
			' 
			Me.toggleLinkToPreviousItem1.Glyph = (CType(resources.GetObject("toggleLinkToPreviousItem1.Glyph"), System.Drawing.Image))
			Me.toggleLinkToPreviousItem1.Id = 6
			Me.toggleLinkToPreviousItem1.LargeGlyph = (CType(resources.GetObject("toggleLinkToPreviousItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
			' 
			' headerFooterToolsDesignOptionsBar1
			' 
			Me.headerFooterToolsDesignOptionsBar1.DockCol = 4
			Me.headerFooterToolsDesignOptionsBar1.DockRow = 0
			Me.headerFooterToolsDesignOptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.headerFooterToolsDesignOptionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentFirstPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentOddAndEvenPagesItem1)})
			' 
			' toggleDifferentFirstPageItem1
			' 
			Me.toggleDifferentFirstPageItem1.Glyph = (CType(resources.GetObject("toggleDifferentFirstPageItem1.Glyph"), System.Drawing.Image))
			Me.toggleDifferentFirstPageItem1.Id = 7
			Me.toggleDifferentFirstPageItem1.LargeGlyph = (CType(resources.GetObject("toggleDifferentFirstPageItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
			' 
			' toggleDifferentOddAndEvenPagesItem1
			' 
			Me.toggleDifferentOddAndEvenPagesItem1.Glyph = (CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.Glyph"), System.Drawing.Image))
			Me.toggleDifferentOddAndEvenPagesItem1.Id = 8
			Me.toggleDifferentOddAndEvenPagesItem1.LargeGlyph = (CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
			' 
			' headerFooterToolsDesignCloseBar1
			' 
			Me.headerFooterToolsDesignCloseBar1.DockCol = 5
			Me.headerFooterToolsDesignCloseBar1.DockRow = 0
			Me.headerFooterToolsDesignCloseBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.headerFooterToolsDesignCloseBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.closePageHeaderFooterItem1)})
			' 
			' closePageHeaderFooterItem1
			' 
			Me.closePageHeaderFooterItem1.Glyph = (CType(resources.GetObject("closePageHeaderFooterItem1.Glyph"), System.Drawing.Image))
			Me.closePageHeaderFooterItem1.Id = 9
			Me.closePageHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("closePageHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
			' 
			' commonBar1
			' 
			Me.commonBar1.DockCol = 0
			Me.commonBar1.DockRow = 0
			Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
			' 
			' undoItem1
			' 
			Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
			Me.undoItem1.Id = 17
			Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
			Me.redoItem1.Id = 18
			Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
			Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
			Me.redoItem1.Name = "redoItem1"
			' 
			' clipboardBar1
			' 
			Me.clipboardBar1.DockCol = 1
			Me.clipboardBar1.DockRow = 0
			Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
			' 
			' cutItem1
			' 
			Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
			Me.cutItem1.Id = 19
			Me.cutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
			Me.copyItem1.Id = 20
			Me.copyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
			Me.pasteItem1.Id = 21
			Me.pasteItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
			Me.changeFontNameItem1.Id = 22
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
			Me.changeFontSizeItem1.Id = 23
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl
			Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' richEditControl
			' 
			Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl.Location = New System.Drawing.Point(2, 2)
			Me.richEditControl.MenuManager = Me
			Me.richEditControl.Name = "richEditControl"
			Me.richEditControl.Size = New System.Drawing.Size(823, 650)
			Me.richEditControl.TabIndex = 0
			Me.richEditControl.Text = "richEditControl1"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Glyph = (CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Id = 24
			Me.changeFontColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' changeFontBackColorItem1
			' 
			Me.changeFontBackColorItem1.Glyph = (CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Id = 25
			Me.changeFontBackColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
			' 
			' toggleFontBoldItem1
			' 
			Me.toggleFontBoldItem1.Glyph = (CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Id = 26
			Me.toggleFontBoldItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
			Me.toggleFontBoldItem1.LargeGlyph = (CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			Me.toggleFontItalicItem1.Glyph = (CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Id = 27
			Me.toggleFontItalicItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
			Me.toggleFontItalicItem1.LargeGlyph = (CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' toggleFontUnderlineItem1
			' 
			Me.toggleFontUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontUnderlineItem1.Id = 28
			Me.toggleFontUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
			Me.toggleFontUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
			' 
			' toggleFontDoubleUnderlineItem1
			' 
			Me.toggleFontDoubleUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontDoubleUnderlineItem1.Id = 29
			Me.toggleFontDoubleUnderlineItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D))
			Me.toggleFontDoubleUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
			' 
			' toggleFontStrikeoutItem1
			' 
			Me.toggleFontStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontStrikeoutItem1.Id = 30
			Me.toggleFontStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
			' 
			' toggleFontDoubleStrikeoutItem1
			' 
			Me.toggleFontDoubleStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontDoubleStrikeoutItem1.Id = 31
			Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
			' 
			' toggleFontSuperscriptItem1
			' 
			Me.toggleFontSuperscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontSuperscriptItem1.Id = 32
			Me.toggleFontSuperscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemplus))
			Me.toggleFontSuperscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
			' 
			' toggleFontSubscriptItem1
			' 
			Me.toggleFontSubscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontSubscriptItem1.Id = 33
			Me.toggleFontSubscriptItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus))
			Me.toggleFontSubscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
			' 
			' fontSizeIncreaseItem1
			' 
			Me.fontSizeIncreaseItem1.Glyph = (CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Id = 34
			Me.fontSizeIncreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.OemPeriod))
			Me.fontSizeIncreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			Me.fontSizeDecreaseItem1.Glyph = (CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Id = 35
			Me.fontSizeDecreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemcomma))
			Me.fontSizeDecreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' clearFormattingItem1
			' 
			Me.clearFormattingItem1.Glyph = (CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Id = 36
			Me.clearFormattingItem1.LargeGlyph = (CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Name = "clearFormattingItem1"
			' 
			' showFontFormItem1
			' 
			Me.showFontFormItem1.Glyph = (CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image))
			Me.showFontFormItem1.Id = 37
			Me.showFontFormItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
			Me.showFontFormItem1.LargeGlyph = (CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showFontFormItem1.Name = "showFontFormItem1"
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			Me.toggleParagraphAlignmentLeftItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Id = 38
			Me.toggleParagraphAlignmentLeftItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
			Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			Me.toggleParagraphAlignmentCenterItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Id = 39
			Me.toggleParagraphAlignmentCenterItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
			Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			Me.toggleParagraphAlignmentRightItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Id = 40
			Me.toggleParagraphAlignmentRightItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
			Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			Me.toggleParagraphAlignmentJustifyItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Id = 41
			Me.toggleParagraphAlignmentJustifyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J))
			Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' changeParagraphLineSpacingItem1
			' 
			Me.changeParagraphLineSpacingItem1.Id = 42
			Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
			Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
			' 
			' setSingleParagraphSpacingItem1
			' 
			Me.setSingleParagraphSpacingItem1.Id = 43
			Me.setSingleParagraphSpacingItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1))
			Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
			' 
			' setSesquialteralParagraphSpacingItem1
			' 
			Me.setSesquialteralParagraphSpacingItem1.Id = 44
			Me.setSesquialteralParagraphSpacingItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5))
			Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
			' 
			' setDoubleParagraphSpacingItem1
			' 
			Me.setDoubleParagraphSpacingItem1.Id = 45
			Me.setDoubleParagraphSpacingItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2))
			Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
			' 
			' showLineSpacingFormItem1
			' 
			Me.showLineSpacingFormItem1.Id = 46
			Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
			' 
			' addSpacingBeforeParagraphItem1
			' 
			Me.addSpacingBeforeParagraphItem1.Id = 47
			Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
			' 
			' removeSpacingBeforeParagraphItem1
			' 
			Me.removeSpacingBeforeParagraphItem1.Id = 48
			Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
			' 
			' addSpacingAfterParagraphItem1
			' 
			Me.addSpacingAfterParagraphItem1.Id = 49
			Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
			' 
			' removeSpacingAfterParagraphItem1
			' 
			Me.removeSpacingAfterParagraphItem1.Id = 50
			Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
			' 
			' toggleNumberingListItem1
			' 
			Me.toggleNumberingListItem1.Glyph = (CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Id = 51
			Me.toggleNumberingListItem1.LargeGlyph = (CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			' 
			' toggleBulletedListItem1
			' 
			Me.toggleBulletedListItem1.Glyph = (CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Id = 52
			Me.toggleBulletedListItem1.LargeGlyph = (CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			' 
			' toggleMultiLevelListItem1
			' 
			Me.toggleMultiLevelListItem1.Glyph = (CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Id = 53
			Me.toggleMultiLevelListItem1.LargeGlyph = (CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			' 
			' decreaseIndentItem1
			' 
			Me.decreaseIndentItem1.Glyph = (CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Id = 54
			Me.decreaseIndentItem1.LargeGlyph = (CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
			' 
			' increaseIndentItem1
			' 
			Me.increaseIndentItem1.Glyph = (CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Id = 55
			Me.increaseIndentItem1.LargeGlyph = (CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Name = "increaseIndentItem1"
			' 
			' toggleShowWhitespaceItem1
			' 
			Me.toggleShowWhitespaceItem1.Glyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Id = 56
			Me.toggleShowWhitespaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D8))
			Me.toggleShowWhitespaceItem1.LargeGlyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' showParagraphFormItem1
			' 
			Me.showParagraphFormItem1.Glyph = (CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Id = 57
			Me.showParagraphFormItem1.LargeGlyph = (CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
			' 
			' changeStyleItem1
			' 
			Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
			Me.changeStyleItem1.Id = 58
			Me.changeStyleItem1.Name = "changeStyleItem1"
			' 
			' repositoryItemRichEditStyleEdit1
			' 
			Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
			Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
			Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
			' 
			' findItem1
			' 
			Me.findItem1.Glyph = (CType(resources.GetObject("findItem1.Glyph"), System.Drawing.Image))
			Me.findItem1.Id = 59
			Me.findItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.findItem1.LargeGlyph = (CType(resources.GetObject("findItem1.LargeGlyph"), System.Drawing.Image))
			Me.findItem1.Name = "findItem1"
			' 
			' replaceItem1
			' 
			Me.replaceItem1.Glyph = (CType(resources.GetObject("replaceItem1.Glyph"), System.Drawing.Image))
			Me.replaceItem1.Id = 60
			Me.replaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
			Me.replaceItem1.LargeGlyph = (CType(resources.GetObject("replaceItem1.LargeGlyph"), System.Drawing.Image))
			Me.replaceItem1.Name = "replaceItem1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.richEditControl)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 26)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(827, 654)
			Me.panelControl1.TabIndex = 4
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
			Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
			Me.richEditBarController1.BarItems.Add(Me.goToPageHeaderItem1)
			Me.richEditBarController1.BarItems.Add(Me.goToPageFooterItem1)
			Me.richEditBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
			Me.richEditBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
			Me.richEditBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
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
			Me.richEditBarController1.RichEditControl = Me.richEditControl
			' 
			' HeadersFootersModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "HeadersFootersModule"
			Me.Size = New System.Drawing.Size(827, 680)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private headerFooterBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterBar
		Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
		Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
		Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
		Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
		Private headerFooterToolsDesignNavigationBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationBar
		Private goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
		Private goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
		Private goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
		Private goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
		Private toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
		Private headerFooterToolsDesignOptionsBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsBar
		Private toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
		Private toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
		Private headerFooterToolsDesignCloseBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseBar
		Private closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
		Private richEditControl As RichEditControl
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
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
	End Class
End Namespace
