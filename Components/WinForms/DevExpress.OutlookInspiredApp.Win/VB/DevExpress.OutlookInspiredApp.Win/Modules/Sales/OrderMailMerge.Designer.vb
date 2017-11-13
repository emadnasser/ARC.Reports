Namespace DevExpress.DevAV.Modules
    Partial Public Class OrderMailMerge
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrderMailMerge))
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim dataSourceInfo1 As New DevExpress.Snap.Core.API.DataSourceInfo()
            Dim dataSourceInfo2 As New DevExpress.Snap.Core.API.DataSourceInfo()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.snapControl = New DevExpress.Snap.SnapControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
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
            Me.bbiThisMonth = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiPrevMonth = New DevExpress.XtraBars.BarButtonItem()
            Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.toggleSpellCheckAsYouTypeItem1 = New DevExpress.XtraRichEdit.UI.ToggleSpellCheckAsYouType()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleFieldHighlightingItem1 = New DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem()
            Me.fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.rpbReportRange = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.mailMergeRibbonPage1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.MailMergeRibbonPageGroup()
            Me.viewFieldsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup()
            Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForSnapControl = New DevExpress.XtraLayout.LayoutControlItem()
            Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForSnapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Order)
            Me.stylesRibbonPageGroup1.Glyph = (CType(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 87
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.biClose, Me.commandBarCheckItem1, Me.commandBarCheckItem2, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem4, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.bbiThisMonth, Me.bbiPrevMonth, Me.checkSpellingItem1, Me.toggleSpellCheckAsYouTypeItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleFieldHighlightingItem1})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.Margin = New System.Windows.Forms.Padding(2)
            Me.ribbonControl.MaxItemId = 117
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.mailMergeRibbonPage1})
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMailMergeCurrentRecordEdit1, Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1})
            Me.ribbonControl.Size = New System.Drawing.Size(1280, 141)
            Me.biClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.Name = "biClose"
            Me.commandBarCheckItem1.Id = 6
            Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
            Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
            Me.commandBarCheckItem2.Id = 7
            Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
            Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
            Me.undoItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.undoItem1.Id = 13
            Me.undoItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.undoItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Undo.svg"
            Me.undoItem1.Name = "undoItem1"
            Me.redoItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.redoItem1.Id = 14
            Me.redoItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.redoItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Redo.svg"
            Me.redoItem1.Name = "redoItem1"
            Me.fileNewItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.fileNewItem1.Id = 15
            Me.fileNewItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.fileNewItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.New.svg"
            Me.fileNewItem1.Name = "fileNewItem1"
            Me.fileOpenItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.fileOpenItem1.Id = 16
            Me.fileOpenItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.fileOpenItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Open.svg"
            Me.fileOpenItem1.Name = "fileOpenItem1"
            Me.fileSaveItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.fileSaveItem1.Id = 17
            Me.fileSaveItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.fileSaveItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.fileSaveItem1.Name = "fileSaveItem1"
            Me.fileSaveAsItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.fileSaveAsItem1.Id = 18
            Me.fileSaveAsItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.fileSaveAsItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAs.svg"
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            Me.commandBarItem4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.commandBarItem4.Id = 19
            Me.commandBarItem4.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.commandBarItem4.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.commandBarItem4.Name = "commandBarItem4"
            Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
            Me.quickPrintItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.quickPrintItem1.Id = 20
            Me.quickPrintItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.quickPrintItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintQuick.svg"
            Me.quickPrintItem1.Name = "quickPrintItem1"
            Me.printItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.printItem1.Id = 21
            Me.printItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.printItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.printItem1.Name = "printItem1"
            Me.printPreviewItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.printPreviewItem1.Id = 22
            Me.printPreviewItem1.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.printPreviewItem1.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg"
            Me.printPreviewItem1.Name = "printPreviewItem1"
            Me.pasteItem1.Id = 43
            Me.pasteItem1.Name = "pasteItem1"
            Me.cutItem1.Id = 44
            Me.cutItem1.Name = "cutItem1"
            Me.copyItem1.Id = 45
            Me.copyItem1.Name = "copyItem1"
            Me.pasteSpecialItem1.Id = 46
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            Me.barButtonGroup1.Id = 36
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1, "FF")
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1, "FG")
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1, "FK")
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 47
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 48
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.snapControl
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            Me.snapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            dataSourceInfo1.DataSource = Nothing
            dataSourceInfo1.DataSourceName = ""
            dataSourceInfo2.DataSource = Me.bindingSource
            dataSourceInfo2.DataSourceName = "Employee"
            Me.snapControl.DataSources.Add(dataSourceInfo1)
            Me.snapControl.DataSources.Add(dataSourceInfo2)
            Me.snapControl.Location = New System.Drawing.Point(0, 0)
            Me.snapControl.MenuManager = Me.ribbonControl
            Me.snapControl.Modified = True
            Me.snapControl.Name = "snapControl"
            Me.snapControl.Options.Comments.ShowAllAuthors = False
            Me.snapControl.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
            Me.snapControl.Options.SnapMailMergeVisualOptions.DataSource = Me.bindingSource
            Me.snapControl.Options.SnapMailMergeVisualOptions.DataSourceName = "Employee"
            Me.snapControl.Size = New System.Drawing.Size(1280, 659)
            Me.snapControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.snapControl, optionsSpelling1)
            Me.snapControl.TabIndex = 18
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            Me.fontSizeIncreaseItem1.Id = 49
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            Me.fontSizeDecreaseItem1.Id = 50
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            Me.barButtonGroup2.Id = 37
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            Me.toggleFontBoldItem1.Id = 51
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            Me.toggleFontItalicItem1.Id = 52
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            Me.toggleFontUnderlineItem1.Id = 53
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            Me.toggleFontDoubleUnderlineItem1.Id = 54
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            Me.toggleFontStrikeoutItem1.Id = 55
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            Me.toggleFontDoubleStrikeoutItem1.Id = 56
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            Me.toggleFontSuperscriptItem1.Id = 57
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            Me.toggleFontSubscriptItem1.Id = 58
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            Me.barButtonGroup3.Id = 38
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontBackColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            Me.changeFontColorItem1.Id = 59
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            Me.changeFontBackColorItem1.Id = 60
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            Me.changeTextCaseItem1.Id = 61
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1)
            })
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            Me.changeTextCaseItem1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.makeTextUpperCaseItem1.Id = 62
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            Me.makeTextLowerCaseItem1.Id = 63
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            Me.capitalizeEachWordCaseItem1.Id = 64
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            Me.toggleTextCaseItem1.Id = 65
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            Me.clearFormattingItem1.Id = 66
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            Me.barButtonGroup4.Id = 39
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1, "M")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            Me.toggleBulletedListItem1.Id = 67
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            Me.toggleNumberingListItem1.Id = 68
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            Me.toggleMultiLevelListItem1.Id = 69
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            Me.barButtonGroup5.Id = 40
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            Me.decreaseIndentItem1.Id = 70
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            Me.increaseIndentItem1.Id = 71
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            Me.toggleShowWhitespaceItem1.Id = 76
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            Me.barButtonGroup6.Id = 41
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1, "AJ")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            Me.toggleParagraphAlignmentLeftItem1.Id = 72
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            Me.toggleParagraphAlignmentCenterItem1.Id = 73
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            Me.toggleParagraphAlignmentRightItem1.Id = 74
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            Me.toggleParagraphAlignmentJustifyItem1.Id = 75
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            Me.barButtonGroup7.Id = 42
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1, "K")
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            Me.changeParagraphLineSpacingItem1.Id = 77
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1),
                New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""),
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)
            })
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            Me.changeParagraphLineSpacingItem1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True
            Me.setSingleParagraphSpacingItem1.Id = 78
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            Me.setSesquialteralParagraphSpacingItem1.Id = 79
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            Me.setDoubleParagraphSpacingItem1.Id = 80
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            Me.showLineSpacingFormItem1.Id = 81
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            Me.addSpacingBeforeParagraphItem1.Id = 82
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            Me.removeSpacingBeforeParagraphItem1.Id = 83
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            Me.addSpacingAfterParagraphItem1.Id = 84
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            Me.removeSpacingAfterParagraphItem1.Id = 85
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            Me.changeParagraphBackColorItem1.Id = 86
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            Me.findItem1.Id = 88
            Me.findItem1.Name = "findItem1"
            Me.replaceItem1.Id = 89
            Me.replaceItem1.Name = "replaceItem1"
            Me.bbiThisMonth.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bbiThisMonth.Caption = "This Month"
            Me.bbiThisMonth.Id = 90
            Me.bbiThisMonth.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bbiThisMonth.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodMonth.svg"
            Me.bbiThisMonth.Name = "bbiThisMonth"
            Me.bbiPrevMonth.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False
            Me.bbiPrevMonth.Caption = "Last Month"
            Me.bbiPrevMonth.Id = 91
            Me.bbiPrevMonth.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bbiPrevMonth.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodMonth.svg"
            Me.bbiPrevMonth.Name = "bbiPrevMonth"
            Me.checkSpellingItem1.Id = 92
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            Me.toggleSpellCheckAsYouTypeItem1.Id = 116
            Me.toggleSpellCheckAsYouTypeItem1.Name = "toggleSpellCheckAsYouTypeItem1"
            Me.showAllFieldCodesItem1.Id = 113
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            Me.showAllFieldResultsItem1.Id = 114
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            Me.toggleFieldHighlightingItem1.Glyph = (CType(resources.GetObject("toggleFieldHighlightingItem1.Glyph"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.Id = 115
            Me.toggleFieldHighlightingItem1.LargeGlyph = (CType(resources.GetObject("toggleFieldHighlightingItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1"
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.rpbReportRange, Me.ribbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            Me.fileRibbonPage1.Text = "FILE"
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1, "N")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1, "O")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1, "S")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1, "A")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1, "P")
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup1.MergeOrder = 0
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            Me.rpbReportRange.AllowTextClipping = False
            Me.rpbReportRange.ItemLinks.Add(Me.bbiThisMonth)
            Me.rpbReportRange.ItemLinks.Add(Me.bbiPrevMonth)
            Me.rpbReportRange.MergeOrder = 0
            Me.rpbReportRange.Name = "rpbReportRange"
            Me.rpbReportRange.ShowCaptionButton = False
            Me.rpbReportRange.Text = "Report Range"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Close"
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.documentProofingRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation1.Group = Me.stylesRibbonPageGroup1
            reduceOperation1.ItemLinkIndex = 0
            reduceOperation1.ItemLinksCount = 0
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
            Me.homeRibbonPage1.Text = "HOME"
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1, "V")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1, "X")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1, "C")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            Me.documentProofingRibbonPageGroup1.AllowTextClipping = False
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1, "S")
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.toggleSpellCheckAsYouTypeItem1)
            Me.documentProofingRibbonPageGroup1.MergeOrder = 0
            Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1, "E")
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1, "FD")
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1, "R")
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1, Me.viewFieldsRibbonPageGroup1})
            Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
            Me.mailMergeRibbonPage1.Text = "MAIL MERGE"
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.toggleFieldHighlightingItem1)
            Me.viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1"
            Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
            Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev, Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next, Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First, Nothing, True),
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleRight, (CType(resources.GetObject("repositoryItemMailMergeCurrentRecordEdit1.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last, Nothing, True)
            })
            Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
            Me.dataLayoutControl1.AllowCustomization = False
            Me.dataLayoutControl1.Controls.Add(Me.snapControl)
            Me.dataLayoutControl1.DataSource = Me.bindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 141)
            Me.dataLayoutControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(1280, 659)
            Me.dataLayoutControl1.TabIndex = 1
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1280, 659)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForSnapControl})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup2.Size = New System.Drawing.Size(1280, 659)
            Me.ItemForSnapControl.Control = Me.snapControl
            Me.ItemForSnapControl.CustomizationFormText = "layoutControlItem1"
            Me.ItemForSnapControl.Location = New System.Drawing.Point(0, 0)
            Me.ItemForSnapControl.Name = "layoutControlItem1"
            Me.ItemForSnapControl.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForSnapControl.Size = New System.Drawing.Size(1280, 659)
            Me.ItemForSnapControl.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForSnapControl.TextVisible = False
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
            Me.snapBarController1.BarItems.Add(Me.undoItem1)
            Me.snapBarController1.BarItems.Add(Me.redoItem1)
            Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
            Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
            Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.snapBarController1.BarItems.Add(Me.printItem1)
            Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.snapBarController1.BarItems.Add(Me.pasteItem1)
            Me.snapBarController1.BarItems.Add(Me.cutItem1)
            Me.snapBarController1.BarItems.Add(Me.copyItem1)
            Me.snapBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.snapBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.findItem1)
            Me.snapBarController1.BarItems.Add(Me.replaceItem1)
            Me.snapBarController1.BarItems.Add(Me.checkSpellingItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleSpellCheckAsYouTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFieldHighlightingItem1)
            Me.snapBarController1.Control = Me.snapControl
            Me.snapBarController1.RibbonControl = Me.ribbonControl
            Me.snapBarController1.SnapDockManager = Nothing
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "OrderMailMerge"
            Me.Size = New System.Drawing.Size(1280, 800)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForSnapControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biClose As XtraBars.BarButtonItem
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private dataLayoutControl1 As XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private bindingSource As System.Windows.Forms.BindingSource
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private snapControl As DevExpress.Snap.SnapControl
        Private ItemForSnapControl As XtraLayout.LayoutControlItem
        Private commandBarCheckItem1 As Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem2 As Snap.Extensions.UI.CommandBarCheckItem
        Private repositoryItemMailMergeCurrentRecordEdit1 As Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
        Private undoItem1 As XtraRichEdit.UI.UndoItem
        Private redoItem1 As XtraRichEdit.UI.RedoItem
        Private fileNewItem1 As XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As XtraRichEdit.UI.FileSaveAsItem
        Private commandBarItem4 As Snap.Extensions.UI.CommandBarItem
        Private quickPrintItem1 As XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As XtraRichEdit.UI.PrintPreviewItem
        Private mailMergeRibbonPage1 As Snap.Extensions.UI.MailMergeRibbonPage
        Private mailMergeRibbonPageGroup1 As Snap.Extensions.UI.MailMergeRibbonPageGroup
        Private fileRibbonPage1 As XtraRichEdit.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As XtraRichEdit.UI.CommonRibbonPageGroup
        Private snapBarController1 As Snap.Extensions.SnapBarController
        Private pasteItem1 As XtraRichEdit.UI.PasteItem
        Private cutItem1 As XtraRichEdit.UI.CutItem
        Private copyItem1 As XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As XtraRichEdit.UI.PasteSpecialItem
        Private barButtonGroup1 As XtraBars.BarButtonGroup
        Private changeFontNameItem1 As XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
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
        Private homeRibbonPage1 As XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As XtraRichEdit.UI.EditingRibbonPageGroup
        Private bbiThisMonth As XtraBars.BarButtonItem
        Private bbiPrevMonth As XtraBars.BarButtonItem
        Private rpbReportRange As XtraBars.Ribbon.RibbonPageGroup
        Private checkSpellingItem1 As XtraRichEdit.UI.CheckSpellingItem
        Private toggleSpellCheckAsYouTypeItem1 As XtraRichEdit.UI.ToggleSpellCheckAsYouType
        Private documentProofingRibbonPageGroup1 As XtraRichEdit.UI.DocumentProofingRibbonPageGroup
        Private showAllFieldCodesItem1 As XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleFieldHighlightingItem1 As Snap.Extensions.UI.ToggleFieldHighlightingItem
        Private viewFieldsRibbonPageGroup1 As Snap.Extensions.UI.ViewFieldsRibbonPageGroup
        Private spellChecker1 As XtraSpellChecker.SpellChecker
    End Class
End Namespace
