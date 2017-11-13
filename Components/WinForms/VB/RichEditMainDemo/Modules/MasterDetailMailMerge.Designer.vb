﻿Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class MasterDetailMailMergeModule
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
            Dim OptionsSpelling4 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim OptionsSpelling2 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim OptionsSpelling3 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDetailMailMergeModule))
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
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
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.templateRichEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
            Me.masterRichEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.detailRichEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.resultingRichEditControl = New DevExpress.XtraRichEdit.RichEditControl()
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
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.FileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.CommonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.InfoRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.mergeToNewDocumentPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.mergeToNewDocumentItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.templateTabPage = New DevExpress.XtraTab.XtraTabPage()
            Me.masterTabPage = New DevExpress.XtraTab.XtraTabPage()
            Me.detailTabPage = New DevExpress.XtraTab.XtraTabPage()
            Me.resultingDocumentTabPage = New DevExpress.XtraTab.XtraTabPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl.SuspendLayout()
            Me.templateTabPage.SuspendLayout()
            Me.masterTabPage.SuspendLayout()
            Me.detailTabPage.SuspendLayout()
            Me.resultingDocumentTabPage.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 68
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.homeRibbonPage1, Me.mailingsRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(750, 141)
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 9
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 10
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 11
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 12
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 13
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 14
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 15
            Me.printPreviewItem1.Name = "printPreviewItem1"
            '
            'undoItem1
            '
            Me.undoItem1.Id = 16
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Id = 17
            Me.redoItem1.Name = "redoItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Id = 18
            Me.pasteItem1.Name = "pasteItem1"
            '
            'cutItem1
            '
            Me.cutItem1.Id = 19
            Me.cutItem1.Name = "cutItem1"
            '
            'copyItem1
            '
            Me.copyItem1.Id = 20
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteSpecialItem1
            '
            Me.pasteSpecialItem1.Id = 21
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            '
            'barButtonGroup1
            '
            Me.barButtonGroup1.Id = 1
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 22
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
            Me.changeFontSizeItem1.Id = 23
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            '
            'repositoryItemRichEditFontSizeEdit1
            '
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.templateRichEditControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            '
            'templateRichEditControl
            '
            Me.templateRichEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.templateRichEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.templateRichEditControl.Location = New System.Drawing.Point(0, 0)
            Me.templateRichEditControl.MenuManager = Me
            Me.templateRichEditControl.Name = "templateRichEditControl"
            Me.templateRichEditControl.Options.Comments.ShowAllAuthors = False
            Me.templateRichEditControl.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
            Me.templateRichEditControl.Size = New System.Drawing.Size(740, 327)
            Me.templateRichEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.templateRichEditControl, OptionsSpelling4)
            Me.templateRichEditControl.TabIndex = 1
            Me.templateRichEditControl.Text = "richEditControl"
            '
            'spellChecker1
            '
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            '
            'masterRichEditControl
            '
            Me.masterRichEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.masterRichEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.masterRichEditControl.Location = New System.Drawing.Point(0, 0)
            Me.masterRichEditControl.MenuManager = Me
            Me.masterRichEditControl.Name = "masterRichEditControl"
            Me.masterRichEditControl.Options.Comments.ShowAllAuthors = False
            Me.masterRichEditControl.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
            Me.masterRichEditControl.Size = New System.Drawing.Size(740, 327)
            Me.masterRichEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.masterRichEditControl, OptionsSpelling1)
            Me.masterRichEditControl.TabIndex = 2
            Me.masterRichEditControl.Text = "richEditControl"
            '
            'detailRichEditControl
            '
            Me.detailRichEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.detailRichEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.detailRichEditControl.Location = New System.Drawing.Point(0, 0)
            Me.detailRichEditControl.MenuManager = Me
            Me.detailRichEditControl.Name = "detailRichEditControl"
            Me.detailRichEditControl.Options.Comments.ShowAllAuthors = False
            Me.detailRichEditControl.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
            Me.detailRichEditControl.Size = New System.Drawing.Size(740, 327)
            Me.detailRichEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.detailRichEditControl, OptionsSpelling2)
            Me.detailRichEditControl.TabIndex = 3
            Me.detailRichEditControl.Text = "richEditControl"
            '
            'resultingRichEditControl
            '
            Me.resultingRichEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.resultingRichEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resultingRichEditControl.Location = New System.Drawing.Point(0, 0)
            Me.resultingRichEditControl.MenuManager = Me
            Me.resultingRichEditControl.Name = "resultingRichEditControl"
            Me.resultingRichEditControl.Options.Comments.ShowAllAuthors = False
            Me.resultingRichEditControl.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Never
            Me.resultingRichEditControl.Options.MailMerge.ViewMergedData = True
            Me.resultingRichEditControl.Size = New System.Drawing.Size(740, 327)
            Me.resultingRichEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.resultingRichEditControl, OptionsSpelling3)
            Me.resultingRichEditControl.TabIndex = 4
            Me.resultingRichEditControl.Text = "richEditControl"
            '
            'fontSizeIncreaseItem1
            '
            Me.fontSizeIncreaseItem1.Id = 24
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            '
            'fontSizeDecreaseItem1
            '
            Me.fontSizeDecreaseItem1.Id = 25
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            '
            'barButtonGroup2
            '
            Me.barButtonGroup2.Id = 2
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
            Me.toggleFontBoldItem1.Id = 26
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            '
            'toggleFontItalicItem1
            '
            Me.toggleFontItalicItem1.Id = 27
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            '
            'toggleFontUnderlineItem1
            '
            Me.toggleFontUnderlineItem1.Id = 28
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            '
            'toggleFontDoubleUnderlineItem1
            '
            Me.toggleFontDoubleUnderlineItem1.Id = 29
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            '
            'toggleFontStrikeoutItem1
            '
            Me.toggleFontStrikeoutItem1.Id = 30
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            '
            'toggleFontDoubleStrikeoutItem1
            '
            Me.toggleFontDoubleStrikeoutItem1.Id = 31
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            '
            'toggleFontSuperscriptItem1
            '
            Me.toggleFontSuperscriptItem1.Id = 32
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            '
            'toggleFontSubscriptItem1
            '
            Me.toggleFontSubscriptItem1.Id = 33
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            '
            'barButtonGroup3
            '
            Me.barButtonGroup3.Id = 3
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            '
            'changeFontColorItem1
            '
            Me.changeFontColorItem1.Id = 34
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            '
            'changeFontBackColorItem1
            '
            Me.changeFontBackColorItem1.Id = 35
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            '
            'changeTextCaseItem1
            '
            Me.changeTextCaseItem1.Id = 36
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)})
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            '
            'makeTextUpperCaseItem1
            '
            Me.makeTextUpperCaseItem1.Id = 37
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            '
            'makeTextLowerCaseItem1
            '
            Me.makeTextLowerCaseItem1.Id = 38
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
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
            Me.barButtonGroup4.Id = 4
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1)
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
            Me.barButtonGroup5.Id = 5
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1)
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1)
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
            Me.toggleShowWhitespaceItem1.Id = 46
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            '
            'barButtonGroup6
            '
            Me.barButtonGroup6.Id = 6
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            '
            'toggleParagraphAlignmentLeftItem1
            '
            Me.toggleParagraphAlignmentLeftItem1.Id = 47
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            '
            'toggleParagraphAlignmentCenterItem1
            '
            Me.toggleParagraphAlignmentCenterItem1.Id = 48
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            '
            'toggleParagraphAlignmentRightItem1
            '
            Me.toggleParagraphAlignmentRightItem1.Id = 49
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            '
            'toggleParagraphAlignmentJustifyItem1
            '
            Me.toggleParagraphAlignmentJustifyItem1.Id = 50
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            '
            'barButtonGroup7
            '
            Me.barButtonGroup7.Id = 7
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1)
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1)
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            '
            'changeParagraphLineSpacingItem1
            '
            Me.changeParagraphLineSpacingItem1.Id = 51
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
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
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 64
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 65
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 67
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
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
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
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
            'stylesRibbonPageGroup1
            '
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            '
            'editingRibbonPageGroup1
            '
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            '
            'mailingsRibbonPage1
            '
            Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeRibbonPageGroup1, Me.mergeToNewDocumentPageGroup1})
            Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            '
            'mailMergeRibbonPageGroup1
            '
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            '
            'mergeToNewDocumentPageGroup1
            '
            Me.mergeToNewDocumentPageGroup1.ItemLinks.Add(Me.mergeToNewDocumentItem1)
            Me.mergeToNewDocumentPageGroup1.Name = "mergeToNewDocumentPageGroup1"
            Me.mergeToNewDocumentPageGroup1.ShowCaptionButton = False
            Me.mergeToNewDocumentPageGroup1.Text = "Merge to New Document"
            '
            'mergeToNewDocumentItem1
            '
            Me.mergeToNewDocumentItem1.Caption = "Merge to New Document"
            Me.mergeToNewDocumentItem1.Glyph = CType(resources.GetObject("mergeToNewDocumentItem1.Glyph"), System.Drawing.Image)
            Me.mergeToNewDocumentItem1.Id = 67
            Me.mergeToNewDocumentItem1.LargeGlyph = CType(resources.GetObject("mergeToNewDocumentItem1.LargeGlyph"), System.Drawing.Image)
            Me.mergeToNewDocumentItem1.Name = "mergeToNewDocumentItem1"
            ToolTipTitleItem1.Text = "Merge to New Document"
            SuperToolTip1.Items.Add(ToolTipTitleItem1)
            Me.mergeToNewDocumentItem1.SuperTip = SuperToolTip1
            '
            'tabControl
            '
            Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControl.Location = New System.Drawing.Point(2, 2)
            Me.tabControl.Name = "tabControl"
            Me.tabControl.SelectedTabPage = Me.templateTabPage
            Me.tabControl.Size = New System.Drawing.Size(746, 355)
            Me.tabControl.TabIndex = 0
            Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.templateTabPage, Me.masterTabPage, Me.detailTabPage, Me.resultingDocumentTabPage})
            Me.tabControl.Tag = ""
            '
            'templateTabPage
            '
            Me.templateTabPage.Controls.Add(Me.templateRichEditControl)
            Me.templateTabPage.Name = "templateTabPage"
            Me.templateTabPage.Size = New System.Drawing.Size(740, 327)
            Me.templateTabPage.Tag = Me.templateRichEditControl
            Me.templateTabPage.Text = "Template"
            '
            'masterTabPage
            '
            Me.masterTabPage.Controls.Add(Me.masterRichEditControl)
            Me.masterTabPage.Name = "masterTabPage"
            Me.masterTabPage.Size = New System.Drawing.Size(740, 327)
            Me.masterTabPage.Tag = Me.masterRichEditControl
            Me.masterTabPage.Text = "Master"
            '
            'detailTabPage
            '
            Me.detailTabPage.Controls.Add(Me.detailRichEditControl)
            Me.detailTabPage.Name = "detailTabPage"
            Me.detailTabPage.Size = New System.Drawing.Size(740, 327)
            Me.detailTabPage.Tag = Me.detailRichEditControl
            Me.detailTabPage.Text = "Detail"
            '
            'resultingDocumentTabPage
            '
            Me.resultingDocumentTabPage.Controls.Add(Me.resultingRichEditControl)
            Me.resultingDocumentTabPage.Name = "resultingDocumentTabPage"
            Me.resultingDocumentTabPage.Size = New System.Drawing.Size(740, 327)
            Me.resultingDocumentTabPage.Tag = Me.resultingRichEditControl
            Me.resultingDocumentTabPage.Text = "Resulting document"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.tabControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 141)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(750, 359)
            Me.panelControl1.TabIndex = 1
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
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.templateRichEditControl
            '
            'MasterDetailMailMergeModule
            '
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MasterDetailMailMergeModule"
            Me.Size = New System.Drawing.Size(750, 500)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl.ResumeLayout(False)
            Me.templateTabPage.ResumeLayout(False)
            Me.masterTabPage.ResumeLayout(False)
            Me.detailTabPage.ResumeLayout(False)
            Me.resultingDocumentTabPage.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private templateRichEditControl As RichEditControl
        Private masterRichEditControl As RichEditControl
        Private detailRichEditControl As RichEditControl
        Private WithEvents resultingRichEditControl As RichEditControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
        Private templateTabPage As DevExpress.XtraTab.XtraTabPage
        Private masterTabPage As DevExpress.XtraTab.XtraTabPage
        Private detailTabPage As DevExpress.XtraTab.XtraTabPage
        Private resultingDocumentTabPage As DevExpress.XtraTab.XtraTabPage
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
        Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Private mergeToNewDocumentPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents mergeToNewDocumentItem1 As DevExpress.XtraBars.BarButtonItem
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Friend WithEvents FileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Friend WithEvents InfoRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
    End Class
End Namespace
