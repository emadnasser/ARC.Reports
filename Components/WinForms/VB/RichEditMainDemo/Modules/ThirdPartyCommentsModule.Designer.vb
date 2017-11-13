Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ThirdPartyCommentsModule
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ThirdPartyCommentsModule))
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
			Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
			Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
			Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			Me.repositoryItemRichEditFontSizeEdit2 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
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
			Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
			Me.changeLanguageItem1 = New DevExpress.XtraRichEdit.UI.ChangeLanguageItem()
			Me.protectDocumentItem1 = New DevExpress.XtraRichEdit.UI.ProtectDocumentItem()
			Me.changeRangeEditingPermissionsItem1 = New DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem()
			Me.unprotectDocumentItem1 = New DevExpress.XtraRichEdit.UI.UnprotectDocumentItem()
			Me.newCommentItem1 = New DevExpress.XtraRichEdit.UI.NewCommentItem()
			Me.deleteCommentsItem1 = New DevExpress.XtraRichEdit.UI.DeleteCommentsItem()
			Me.deleteOneCommentItem1 = New DevExpress.XtraRichEdit.UI.DeleteOneCommentItem()
			Me.deleteAllCommentsShownItem1 = New DevExpress.XtraRichEdit.UI.DeleteAllCommentsShownItem()
			Me.deleteAllCommentsItem1 = New DevExpress.XtraRichEdit.UI.DeleteAllCommentsItem()
			Me.previousCommentItem1 = New DevExpress.XtraRichEdit.UI.PreviousCommentItem()
			Me.nextCommentItem1 = New DevExpress.XtraRichEdit.UI.NextCommentItem()
			Me.changeCommentItem1 = New DevExpress.XtraRichEdit.UI.ChangeCommentItem()
			Me.reviewersItem1 = New DevExpress.XtraRichEdit.UI.ReviewersItem()
			Me.reviewingPaneItem1 = New DevExpress.XtraRichEdit.UI.ReviewingPaneItem()
			Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
			Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.infoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
			Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
			Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
			Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
			Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
			Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
			Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
			Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
			Me.documentProtectionRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup()
			Me.documentCommentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentCommentRibbonPageGroup()
			Me.documentTrackingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentTrackingRibbonPageGroup()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.cbUserName = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.bottomDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.chkResetColor = New DevExpress.XtraEditors.CheckEdit()
			Me.chkHighlightCommentedRange = New DevExpress.XtraEditors.CheckEdit()
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.chkViewComments = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditAuthors = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.richEditCommentControl1 = New DevExpress.XtraRichEdit.RichEditCommentControl()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbUserName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.hideContainerRight.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			Me.dockPanel2_Container.SuspendLayout()
			CType(Me.chkResetColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkHighlightCommentedRange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkViewComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditAuthors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			Me.SuspendLayout()
			' 
			' stylesRibbonPageGroup1
			' 
			Me.stylesRibbonPageGroup1.Glyph = (CType(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image))
			Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
			Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
			' 
			' galleryChangeStyleItem1
			' 
			' 
			' 
			' 
			Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
			Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
			Me.galleryChangeStyleItem1.Id = 160
			Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barCheckItem1, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.checkSpellingItem1, Me.changeLanguageItem1, Me.protectDocumentItem1, Me.changeRangeEditingPermissionsItem1, Me.unprotectDocumentItem1, Me.newCommentItem1, Me.deleteCommentsItem1, Me.deleteOneCommentItem1, Me.deleteAllCommentsShownItem1, Me.deleteAllCommentsItem1, Me.previousCommentItem1, Me.nextCommentItem1, Me.changeCommentItem1, Me.reviewersItem1, Me.reviewingPaneItem1, Me.showDocumentPropertiesFormItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 179
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.reviewRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.cbUserName, Me.repositoryItemFontEdit2, Me.repositoryItemRichEditFontSizeEdit2})
			Me.ribbonControl1.Size = New System.Drawing.Size(1030, 141)
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.BindableChecked = True
			Me.barCheckItem1.Caption = "Check As You Type"
			Me.barCheckItem1.Checked = True
			Me.barCheckItem1.Glyph = (CType(resources.GetObject("barCheckItem1.Glyph"), System.Drawing.Image))
			Me.barCheckItem1.Id = 69
			Me.barCheckItem1.LargeGlyph = (CType(resources.GetObject("barCheckItem1.LargeGlyph"), System.Drawing.Image))
			Me.barCheckItem1.Name = "barCheckItem1"
			' 
			' undoItem1
			' 
			Me.undoItem1.Id = 100
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Id = 101
			Me.redoItem1.Name = "redoItem1"
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Id = 102
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Id = 103
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Id = 104
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Id = 105
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Id = 106
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Id = 107
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Id = 108
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Id = 116
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' cutItem1
			' 
			Me.cutItem1.Id = 117
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Id = 118
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteSpecialItem1
			' 
			Me.pasteSpecialItem1.Id = 119
			Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
			' 
			' barButtonGroup1
			' 
			Me.barButtonGroup1.Id = 109
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
			Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
			Me.barButtonGroup1.Name = "barButtonGroup1"
			Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit2
			Me.changeFontNameItem1.Id = 120
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			' 
			' repositoryItemFontEdit2
			' 
			Me.repositoryItemFontEdit2.AutoHeight = False
			Me.repositoryItemFontEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit2
			Me.changeFontSizeItem1.Id = 121
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemRichEditFontSizeEdit2
			' 
			Me.repositoryItemRichEditFontSizeEdit2.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit2.Control = Me.richEditControl
			Me.repositoryItemRichEditFontSizeEdit2.Name = "repositoryItemRichEditFontSizeEdit2"
			' 
			' richEditControl
			' 
			Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl.Location = New System.Drawing.Point(0, 141)
			Me.richEditControl.MenuManager = Me
			Me.richEditControl.Name = "richEditControl"
			Me.richEditControl.Size = New System.Drawing.Size(721, 323)
			Me.richEditControl.TabIndex = 10
			' 
			' fontSizeIncreaseItem1
			' 
			Me.fontSizeIncreaseItem1.Id = 122
			Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			Me.fontSizeDecreaseItem1.Id = 123
			Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' barButtonGroup2
			' 
			Me.barButtonGroup2.Id = 110
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
			' toggleFontBoldItem1
			' 
			Me.toggleFontBoldItem1.Id = 124
			Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			Me.toggleFontItalicItem1.Id = 125
			Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' toggleFontUnderlineItem1
			' 
			Me.toggleFontUnderlineItem1.Id = 126
			Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
			' 
			' toggleFontDoubleUnderlineItem1
			' 
			Me.toggleFontDoubleUnderlineItem1.Id = 127
			Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
			' 
			' toggleFontStrikeoutItem1
			' 
			Me.toggleFontStrikeoutItem1.Id = 128
			Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
			' 
			' toggleFontDoubleStrikeoutItem1
			' 
			Me.toggleFontDoubleStrikeoutItem1.Id = 129
			Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
			' 
			' toggleFontSuperscriptItem1
			' 
			Me.toggleFontSuperscriptItem1.Id = 130
			Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
			' 
			' toggleFontSubscriptItem1
			' 
			Me.toggleFontSubscriptItem1.Id = 131
			Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
			' 
			' barButtonGroup3
			' 
			Me.barButtonGroup3.Id = 111
			Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
			Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
			Me.barButtonGroup3.Name = "barButtonGroup3"
			Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Id = 132
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' changeFontBackColorItem1
			' 
			Me.changeFontBackColorItem1.Id = 133
			Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
			' 
			' changeTextCaseItem1
			' 
			Me.changeTextCaseItem1.Id = 134
			Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
			Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
			' 
			' makeTextUpperCaseItem1
			' 
			Me.makeTextUpperCaseItem1.Id = 135
			Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
			' 
			' makeTextLowerCaseItem1
			' 
			Me.makeTextLowerCaseItem1.Id = 136
			Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
			' 
			' capitalizeEachWordCaseItem1
			' 
			Me.capitalizeEachWordCaseItem1.Id = 137
			Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
			' 
			' toggleTextCaseItem1
			' 
			Me.toggleTextCaseItem1.Id = 138
			Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
			' 
			' clearFormattingItem1
			' 
			Me.clearFormattingItem1.Id = 139
			Me.clearFormattingItem1.Name = "clearFormattingItem1"
			' 
			' barButtonGroup4
			' 
			Me.barButtonGroup4.Id = 112
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
			Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
			Me.barButtonGroup4.Name = "barButtonGroup4"
			Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
			' 
			' toggleBulletedListItem1
			' 
			Me.toggleBulletedListItem1.Id = 140
			Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			' 
			' toggleNumberingListItem1
			' 
			Me.toggleNumberingListItem1.Id = 141
			Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			' 
			' toggleMultiLevelListItem1
			' 
			Me.toggleMultiLevelListItem1.Id = 142
			Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			' 
			' barButtonGroup5
			' 
			Me.barButtonGroup5.Id = 113
			Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
			Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
			Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
			Me.barButtonGroup5.Name = "barButtonGroup5"
			Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
			' 
			' decreaseIndentItem1
			' 
			Me.decreaseIndentItem1.Id = 143
			Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
			' 
			' increaseIndentItem1
			' 
			Me.increaseIndentItem1.Id = 144
			Me.increaseIndentItem1.Name = "increaseIndentItem1"
			' 
			' toggleShowWhitespaceItem1
			' 
			Me.toggleShowWhitespaceItem1.Id = 149
			Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' barButtonGroup6
			' 
			Me.barButtonGroup6.Id = 114
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
			Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
			Me.barButtonGroup6.Name = "barButtonGroup6"
			Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			Me.toggleParagraphAlignmentLeftItem1.Id = 145
			Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			Me.toggleParagraphAlignmentCenterItem1.Id = 146
			Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			Me.toggleParagraphAlignmentRightItem1.Id = 147
			Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			Me.toggleParagraphAlignmentJustifyItem1.Id = 148
			Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' barButtonGroup7
			' 
			Me.barButtonGroup7.Id = 115
			Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
			Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
			Me.barButtonGroup7.Name = "barButtonGroup7"
			Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
			' 
			' changeParagraphLineSpacingItem1
			' 
			Me.changeParagraphLineSpacingItem1.Id = 150
			Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
			Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
			' 
			' setSingleParagraphSpacingItem1
			' 
			Me.setSingleParagraphSpacingItem1.Id = 151
			Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
			' 
			' setSesquialteralParagraphSpacingItem1
			' 
			Me.setSesquialteralParagraphSpacingItem1.Id = 152
			Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
			' 
			' setDoubleParagraphSpacingItem1
			' 
			Me.setDoubleParagraphSpacingItem1.Id = 153
			Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
			' 
			' showLineSpacingFormItem1
			' 
			Me.showLineSpacingFormItem1.Id = 154
			Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
			' 
			' addSpacingBeforeParagraphItem1
			' 
			Me.addSpacingBeforeParagraphItem1.Id = 155
			Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
			' 
			' removeSpacingBeforeParagraphItem1
			' 
			Me.removeSpacingBeforeParagraphItem1.Id = 156
			Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
			' 
			' addSpacingAfterParagraphItem1
			' 
			Me.addSpacingAfterParagraphItem1.Id = 157
			Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
			' 
			' removeSpacingAfterParagraphItem1
			' 
			Me.removeSpacingAfterParagraphItem1.Id = 158
			Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
			' 
			' changeParagraphBackColorItem1
			' 
			Me.changeParagraphBackColorItem1.Id = 159
			Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
			' 
			' findItem1
			' 
			Me.findItem1.Id = 161
			Me.findItem1.Name = "findItem1"
			' 
			' replaceItem1
			' 
			Me.replaceItem1.Id = 162
			Me.replaceItem1.Name = "replaceItem1"
			' 
			' checkSpellingItem1
			' 
			Me.checkSpellingItem1.Id = 163
			Me.checkSpellingItem1.Name = "checkSpellingItem1"
			' 
			' changeLanguageItem1
			' 
			Me.changeLanguageItem1.Id = 164
			Me.changeLanguageItem1.Name = "changeLanguageItem1"
			' 
			' protectDocumentItem1
			' 
			Me.protectDocumentItem1.Id = 165
			Me.protectDocumentItem1.Name = "protectDocumentItem1"
			' 
			' changeRangeEditingPermissionsItem1
			' 
			Me.changeRangeEditingPermissionsItem1.Id = 166
			Me.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1"
			' 
			' unprotectDocumentItem1
			' 
			Me.unprotectDocumentItem1.Id = 167
			Me.unprotectDocumentItem1.Name = "unprotectDocumentItem1"
			' 
			' newCommentItem1
			' 
			Me.newCommentItem1.Id = 168
			Me.newCommentItem1.Name = "newCommentItem1"
			' 
			' deleteCommentsItem1
			' 
			Me.deleteCommentsItem1.Id = 169
			Me.deleteCommentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOneCommentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteAllCommentsShownItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteAllCommentsItem1)})
			Me.deleteCommentsItem1.Name = "deleteCommentsItem1"
			' 
			' deleteOneCommentItem1
			' 
			Me.deleteOneCommentItem1.Id = 170
			Me.deleteOneCommentItem1.Name = "deleteOneCommentItem1"
			' 
			' deleteAllCommentsShownItem1
			' 
			Me.deleteAllCommentsShownItem1.Id = 171
			Me.deleteAllCommentsShownItem1.Name = "deleteAllCommentsShownItem1"
			' 
			' deleteAllCommentsItem1
			' 
			Me.deleteAllCommentsItem1.Id = 172
			Me.deleteAllCommentsItem1.Name = "deleteAllCommentsItem1"
			' 
			' previousCommentItem1
			' 
			Me.previousCommentItem1.Id = 173
			Me.previousCommentItem1.Name = "previousCommentItem1"
			' 
			' nextCommentItem1
			' 
			Me.nextCommentItem1.Id = 174
			Me.nextCommentItem1.Name = "nextCommentItem1"
			' 
			' changeCommentItem1
			' 
			Me.changeCommentItem1.Id = 175
			Me.changeCommentItem1.Name = "changeCommentItem1"
			' 
			' reviewersItem1
			' 
			Me.reviewersItem1.Id = 176
			Me.reviewersItem1.Name = "reviewersItem1"
			' 
			' reviewingPaneItem1
			' 
			Me.reviewingPaneItem1.Id = 177
			Me.reviewingPaneItem1.Name = "reviewingPaneItem1"
			' 
			' showDocumentPropertiesFormItem1
			' 
			Me.showDocumentPropertiesFormItem1.Id = 178
			Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
			' 
			' fileRibbonPage1
			' 
			Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
			Me.fileRibbonPage1.Name = "fileRibbonPage1"
			' 
			' commonRibbonPageGroup1
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
			' infoRibbonPageGroup1
			' 
			Me.infoRibbonPageGroup1.ItemLinks.Add(Me.showDocumentPropertiesFormItem1)
			Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
			' 
			' homeRibbonPage1
			' 
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
			Me.homeRibbonPage1.Name = "homeRibbonPage1"
			reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
			reduceOperation1.Group = Me.stylesRibbonPageGroup1
			reduceOperation1.ItemLinkIndex = 0
			reduceOperation1.ItemLinksCount = 0
			reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
			Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
			' 
			' clipboardRibbonPageGroup1
			' 
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1)
			Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
			Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
			' 
			' fontRibbonPageGroup1
			' 
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
			Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			' 
			' paragraphRibbonPageGroup1
			' 
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
			Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
			Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
			' 
			' editingRibbonPageGroup1
			' 
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
			Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
			Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
			' 
			' reviewRibbonPage1
			' 
			Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentProofingRibbonPageGroup1, Me.documentProtectionRibbonPageGroup1, Me.documentCommentRibbonPageGroup1, Me.documentTrackingRibbonPageGroup1})
			Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
			' 
			' documentProofingRibbonPageGroup1
			' 
			Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1)
			Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.changeLanguageItem1)
			Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
			' 
			' documentProtectionRibbonPageGroup1
			' 
			Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.protectDocumentItem1)
			Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.changeRangeEditingPermissionsItem1)
			Me.documentProtectionRibbonPageGroup1.ItemLinks.Add(Me.unprotectDocumentItem1)
			Me.documentProtectionRibbonPageGroup1.Name = "documentProtectionRibbonPageGroup1"
			' 
			' documentCommentRibbonPageGroup1
			' 
			Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.newCommentItem1)
			Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.deleteCommentsItem1)
			Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.previousCommentItem1)
			Me.documentCommentRibbonPageGroup1.ItemLinks.Add(Me.nextCommentItem1)
			Me.documentCommentRibbonPageGroup1.Name = "documentCommentRibbonPageGroup1"
			' 
			' documentTrackingRibbonPageGroup1
			' 
			Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.changeCommentItem1)
			Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.reviewersItem1)
			Me.documentTrackingRibbonPageGroup1.ItemLinks.Add(Me.reviewingPaneItem1)
			Me.documentTrackingRibbonPageGroup1.Name = "documentTrackingRibbonPageGroup1"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit1.Control = Nothing
			Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' cbUserName
			' 
			Me.cbUserName.AutoHeight = False
			Me.cbUserName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbUserName.Name = "cbUserName"
			' 
			' bottomDockArea
			' 
			Me.bottomDockArea.AutoSize = True
			Me.bottomDockArea.CausesValidation = False
			Me.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.bottomDockArea.Location = New System.Drawing.Point(2, 245)
			Me.bottomDockArea.Name = "bottomDockArea"
			Me.bottomDockArea.Size = New System.Drawing.Size(841, 0)
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Edit = Nothing
			Me.barEditItem1.Id = -1
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.richEditBarController1.BarItems.Add(Me.printItem1)
			Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
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
			Me.richEditBarController1.BarItems.Add(Me.checkSpellingItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeLanguageItem1)
			Me.richEditBarController1.BarItems.Add(Me.protectDocumentItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeRangeEditingPermissionsItem1)
			Me.richEditBarController1.BarItems.Add(Me.unprotectDocumentItem1)
			Me.richEditBarController1.BarItems.Add(Me.newCommentItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteCommentsItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteOneCommentItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteAllCommentsShownItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteAllCommentsItem1)
			Me.richEditBarController1.BarItems.Add(Me.previousCommentItem1)
			Me.richEditBarController1.BarItems.Add(Me.nextCommentItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeCommentItem1)
			Me.richEditBarController1.BarItems.Add(Me.reviewersItem1)
			Me.richEditBarController1.BarItems.Add(Me.reviewingPaneItem1)
			Me.richEditBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
			Me.richEditBarController1.Control = Me.richEditControl
			' 
			' dockManager1
			' 
			Me.dockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() { Me.hideContainerRight})
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
			' 
			' hideContainerRight
			' 
			Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(239))))))
			Me.hideContainerRight.Controls.Add(Me.dockPanel2)
			Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.hideContainerRight.Location = New System.Drawing.Point(1011, 141)
			Me.hideContainerRight.Name = "hideContainerRight"
			Me.hideContainerRight.Size = New System.Drawing.Size(19, 323)
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel2.FloatSize = New System.Drawing.Size(200, 236)
			Me.dockPanel2.ID = New System.Guid("75b8b26c-730f-4e7e-84ce-bfbb5afac311")
			Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(210, 172)
			Me.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel2.SavedIndex = 1
			Me.dockPanel2.Size = New System.Drawing.Size(210, 323)
			Me.dockPanel2.Text = "Comment options"
			Me.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Controls.Add(Me.chkResetColor)
			Me.dockPanel2_Container.Controls.Add(Me.chkHighlightCommentedRange)
			Me.dockPanel2_Container.Controls.Add(Me.colorEdit1)
			Me.dockPanel2_Container.Controls.Add(Me.chkViewComments)
			Me.dockPanel2_Container.Controls.Add(Me.labelControl4)
			Me.dockPanel2_Container.Controls.Add(Me.labelControl2)
			Me.dockPanel2_Container.Controls.Add(Me.labelControl3)
			Me.dockPanel2_Container.Controls.Add(Me.labelControl1)
			Me.dockPanel2_Container.Controls.Add(Me.comboBoxEditAuthors)
			Me.dockPanel2_Container.Location = New System.Drawing.Point(5, 23)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(201, 296)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' chkResetColor
			' 
			Me.chkResetColor.EditValue = True
			Me.chkResetColor.Location = New System.Drawing.Point(3, 181)
			Me.chkResetColor.MenuManager = Me
			Me.chkResetColor.Name = "chkResetColor"
			Me.chkResetColor.Properties.Caption = "Reset color"
			Me.chkResetColor.Size = New System.Drawing.Size(75, 19)
			Me.chkResetColor.TabIndex = 17
'			Me.chkResetColor.CheckedChanged += New System.EventHandler(Me.chkResetColor_CheckedChanged);
			' 
			' chkHighlightCommentedRange
			' 
			Me.chkHighlightCommentedRange.Enabled = False
			Me.chkHighlightCommentedRange.Location = New System.Drawing.Point(5, 96)
			Me.chkHighlightCommentedRange.MenuManager = Me
			Me.chkHighlightCommentedRange.Name = "chkHighlightCommentedRange"
			Me.chkHighlightCommentedRange.Properties.Caption = "Highlight commented range"
			Me.chkHighlightCommentedRange.Size = New System.Drawing.Size(183, 19)
			Me.chkHighlightCommentedRange.TabIndex = 14
'			Me.chkHighlightCommentedRange.CheckedChanged += New System.EventHandler(Me.chkHighlightCommentedRange_CheckedChanged);
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(3, 155)
			Me.colorEdit1.MenuManager = Me
			Me.colorEdit1.Name = "colorEdit1"
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(185, 20)
			Me.colorEdit1.TabIndex = 16
'			Me.colorEdit1.EditValueChanged += New System.EventHandler(Me.colorEdit1_ColorChanged);
			' 
			' chkViewComments
			' 
			Me.chkViewComments.EditValue = True
			Me.chkViewComments.Location = New System.Drawing.Point(6, 71)
			Me.chkViewComments.MenuManager = Me
			Me.chkViewComments.Name = "chkViewComments"
			Me.chkViewComments.Properties.Caption = "Visibility"
			Me.chkViewComments.Size = New System.Drawing.Size(108, 19)
			Me.chkViewComments.TabIndex = 14
'			Me.chkViewComments.CheckedChanged += New System.EventHandler(Me.chkViewComments_CheckedChanged);
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(6, 136)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(75, 13)
			Me.labelControl4.TabIndex = 15
			Me.labelControl4.Text = "Comment color:"
			' 
			' labelControl2
			' 
			Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl2.LineVisible = True
			Me.labelControl2.Location = New System.Drawing.Point(0, 49)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(200, 16)
			Me.labelControl2.TabIndex = 14
			' 
			' labelControl3
			' 
			Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
			Me.labelControl3.LineVisible = True
			Me.labelControl3.Location = New System.Drawing.Point(0, 114)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(200, 16)
			Me.labelControl3.TabIndex = 14
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 7)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(128, 13)
			Me.labelControl1.TabIndex = 14
			Me.labelControl1.Text = "Author of a new comment:"
			' 
			' comboBoxEditAuthors
			' 
			Me.comboBoxEditAuthors.Location = New System.Drawing.Point(6, 26)
			Me.comboBoxEditAuthors.MenuManager = Me
			Me.comboBoxEditAuthors.Name = "comboBoxEditAuthors"
			Me.comboBoxEditAuthors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditAuthors.Size = New System.Drawing.Size(185, 20)
			Me.comboBoxEditAuthors.TabIndex = 13
'			Me.comboBoxEditAuthors.EditValueChanged += New System.EventHandler(Me.comboBoxEditAuthors_EditValueChanged);
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel1.ID = New System.Guid("0fd6bee2-437d-4493-89fe-a4e8dc81360b")
			Me.dockPanel1.Location = New System.Drawing.Point(721, 141)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(290, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(290, 323)
			Me.dockPanel1.Text = "Main document comments"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.richEditCommentControl1)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(5, 23)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(281, 296)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' richEditCommentControl1
			' 
			Me.richEditCommentControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
			Me.richEditCommentControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditCommentControl1.Location = New System.Drawing.Point(0, 0)
			Me.richEditCommentControl1.Name = "richEditCommentControl1"
			Me.richEditCommentControl1.ReadOnly = False
			Me.richEditCommentControl1.RichEditControl = Me.richEditControl
			Me.richEditCommentControl1.Size = New System.Drawing.Size(281, 296)
			Me.richEditCommentControl1.TabIndex = 0
			' 
			' ThirdPartyCommentsModule
			' 
			Me.Controls.Add(Me.richEditControl)
			Me.Controls.Add(Me.dockPanel1)
			Me.Controls.Add(Me.hideContainerRight)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "ThirdPartyCommentsModule"
			Me.Size = New System.Drawing.Size(1030, 464)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbUserName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.hideContainerRight.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			Me.dockPanel2_Container.ResumeLayout(False)
			Me.dockPanel2_Container.PerformLayout()
			CType(Me.chkResetColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkHighlightCommentedRange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkViewComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditAuthors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private bottomDockArea As DevExpress.XtraBars.StandaloneBarDockControl
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
		Private repositoryItemRichEditFontSizeEdit1 As Design.RepositoryItemRichEditFontSizeEdit
		Private barCheckItem1 As XtraBars.BarCheckItem
		'  private RichEditCommentControl richEditCommentControl2;
		Private cbUserName As XtraEditors.Repository.RepositoryItemComboBox
		Private undoItem1 As UI.UndoItem
		Private redoItem1 As UI.RedoItem
		Private fileNewItem1 As UI.FileNewItem
		Private fileOpenItem1 As UI.FileOpenItem
		Private fileSaveItem1 As UI.FileSaveItem
		Private fileSaveAsItem1 As UI.FileSaveAsItem
		Private quickPrintItem1 As UI.QuickPrintItem
		Private printItem1 As UI.PrintItem
		Private printPreviewItem1 As UI.PrintPreviewItem
		Private pasteItem1 As UI.PasteItem
		Private cutItem1 As UI.CutItem
		Private copyItem1 As UI.CopyItem
		Private pasteSpecialItem1 As UI.PasteSpecialItem
		Private barButtonGroup1 As XtraBars.BarButtonGroup
		Private changeFontNameItem1 As UI.ChangeFontNameItem
		Private repositoryItemFontEdit2 As XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit2 As Design.RepositoryItemRichEditFontSizeEdit
		Private richEditControl As RichEditControl
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
		Private capitalizeEachWordCaseItem1 As UI.CapitalizeEachWordCaseItem
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
		Private checkSpellingItem1 As UI.CheckSpellingItem
		Private changeLanguageItem1 As UI.ChangeLanguageItem
		Private protectDocumentItem1 As UI.ProtectDocumentItem
		Private changeRangeEditingPermissionsItem1 As UI.ChangeRangeEditingPermissionsItem
		Private unprotectDocumentItem1 As UI.UnprotectDocumentItem
		Private newCommentItem1 As UI.NewCommentItem
		Private deleteCommentsItem1 As UI.DeleteCommentsItem
		Private deleteOneCommentItem1 As UI.DeleteOneCommentItem
		Private deleteAllCommentsShownItem1 As UI.DeleteAllCommentsShownItem
		Private deleteAllCommentsItem1 As UI.DeleteAllCommentsItem
		Private previousCommentItem1 As UI.PreviousCommentItem
		Private nextCommentItem1 As UI.NextCommentItem
		Private changeCommentItem1 As UI.ChangeCommentItem
		Private reviewersItem1 As UI.ReviewersItem
		Private reviewingPaneItem1 As UI.ReviewingPaneItem
		Private fileRibbonPage1 As UI.FileRibbonPage
		Private commonRibbonPageGroup1 As UI.CommonRibbonPageGroup
		Private homeRibbonPage1 As UI.HomeRibbonPage
		Private clipboardRibbonPageGroup1 As UI.ClipboardRibbonPageGroup
		Private fontRibbonPageGroup1 As UI.FontRibbonPageGroup
		Private paragraphRibbonPageGroup1 As UI.ParagraphRibbonPageGroup
		Private stylesRibbonPageGroup1 As UI.StylesRibbonPageGroup
		Private editingRibbonPageGroup1 As UI.EditingRibbonPageGroup
		Private reviewRibbonPage1 As UI.ReviewRibbonPage
		Private documentProofingRibbonPageGroup1 As UI.DocumentProofingRibbonPageGroup
		Private documentProtectionRibbonPageGroup1 As UI.DocumentProtectionRibbonPageGroup
		Private documentCommentRibbonPageGroup1 As UI.DocumentCommentRibbonPageGroup
		Private documentTrackingRibbonPageGroup1 As UI.DocumentTrackingRibbonPageGroup
		Private barEditItem1 As XtraBars.BarEditItem
		Private richEditBarController1 As UI.RichEditBarController
		Private dockManager1 As XtraBars.Docking.DockManager
		Private showDocumentPropertiesFormItem1 As UI.ShowDocumentPropertiesFormItem
		Private infoRibbonPageGroup1 As UI.InfoRibbonPageGroup
		Private dockPanel2 As XtraBars.Docking.DockPanel
		Private dockPanel2_Container As XtraBars.Docking.ControlContainer
		Private WithEvents chkResetColor As XtraEditors.CheckEdit
		Private WithEvents chkHighlightCommentedRange As XtraEditors.CheckEdit
		Private WithEvents colorEdit1 As XtraEditors.ColorEdit
		Private WithEvents chkViewComments As XtraEditors.CheckEdit
		Private labelControl4 As XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
		Private labelControl1 As XtraEditors.LabelControl
		Private WithEvents comboBoxEditAuthors As XtraEditors.ComboBoxEdit
		Private dockPanel1 As XtraBars.Docking.DockPanel
		Private dockPanel1_Container As XtraBars.Docking.ControlContainer
		Private richEditCommentControl1 As RichEditCommentControl
		Private hideContainerRight As XtraBars.Docking.AutoHideContainer
	End Class
End Namespace
