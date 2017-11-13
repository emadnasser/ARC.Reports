Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class DocumentRestrictionsModule
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
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.rgrpViewType = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.documentViewsBar1 = New DevExpress.XtraRichEdit.UI.DocumentViewsBar()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager = New DevExpress.XtraBars.BarManager()
            Me.fontBar1 = New DevExpress.XtraRichEdit.UI.FontBar()
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
            Me.standaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.paragraphBar1 = New DevExpress.XtraRichEdit.UI.ParagraphBar()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.linksBar1 = New DevExpress.XtraRichEdit.UI.LinksBar()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.illustrationsBar1 = New DevExpress.XtraRichEdit.UI.IllustrationsBar()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.textBar1 = New DevExpress.XtraRichEdit.UI.TextBar()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.stylesBar1 = New DevExpress.XtraRichEdit.UI.StylesBar()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.headerFooterBar1 = New DevExpress.XtraRichEdit.UI.HeaderFooterBar()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
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
            Me.rowsAndColumnsBar1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsBar()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.pageSetupBar1 = New DevExpress.XtraRichEdit.UI.PageSetupBar()
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
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
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
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.cutItem2 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem2 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem2 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.switchToSimpleViewItem2 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem2 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem2 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.gcOthers = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowTables = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowHeadersFooters = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowSections = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.gcNumbering = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowMultiLevelNumbering = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowBulletNumbering = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowSimpleNumbering = New DevExpress.XtraEditors.CheckEdit()
            Me.gcPage = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowSymbolTabs = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowPicture = New DevExpress.XtraEditors.CheckEdit()
            Me.edtHideDisabled = New DevExpress.XtraEditors.CheckEdit()
            Me.gcLinks = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowHyperlinks = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowBookmarks = New DevExpress.XtraEditors.CheckEdit()
            Me.gcParagraph = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowParagraphTabs = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowParagraphStyle = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowParagraph = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowParagraphPraperties = New DevExpress.XtraEditors.CheckEdit()
            Me.gcCharacter = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowCharacterFormatting = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowCharacterStyle = New DevExpress.XtraEditors.CheckEdit()
            Me.FileInfoBar1 = New DevExpress.XtraRichEdit.UI.FileInfoBar()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.rgrpViewType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType(Me.gcOthers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcOthers.SuspendLayout()
            CType(Me.edtAllowTables.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowHeadersFooters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowSections.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcNumbering, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcNumbering.SuspendLayout()
            CType(Me.edtAllowMultiLevelNumbering.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowBulletNumbering.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowSimpleNumbering.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcPage.SuspendLayout()
            CType(Me.edtAllowSymbolTabs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtHideDisabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcLinks, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcLinks.SuspendLayout()
            CType(Me.edtAllowHyperlinks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowBookmarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcParagraph, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcParagraph.SuspendLayout()
            CType(Me.edtAllowParagraphTabs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowParagraphStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowParagraph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowParagraphPraperties.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcCharacter.SuspendLayout()
            CType(Me.edtAllowCharacterFormatting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowCharacterStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.rgrpViewType)
            Me.panelControl2.Controls.Add(Me.labelControl1)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(780, 38)
            Me.panelControl2.TabIndex = 13
            '
            'rgrpViewType
            '
            Me.rgrpViewType.Location = New System.Drawing.Point(62, 6)
            Me.rgrpViewType.Name = "rgrpViewType"
            Me.rgrpViewType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgrpViewType.Properties.Appearance.Options.UseBackColor = True
            Me.rgrpViewType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgrpViewType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.rgrpViewType.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.rgrpViewType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.Simple, "Simple"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.Draft, "Draft"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.PrintLayout, "Print Layout")})
            Me.rgrpViewType.Size = New System.Drawing.Size(282, 25)
            Me.rgrpViewType.TabIndex = 0
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(5, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(51, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "View type:"
            '
            'documentViewsBar1
            '
            Me.documentViewsBar1.BarName = ""
            Me.documentViewsBar1.Control = Nothing
            Me.documentViewsBar1.DockCol = 0
            Me.documentViewsBar1.DockRow = 0
            Me.documentViewsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.documentViewsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchToSimpleViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToDraftViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToPrintLayoutViewItem1)})
            Me.documentViewsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            Me.documentViewsBar1.Text = ""
            '
            'switchToSimpleViewItem1
            '
            Me.switchToSimpleViewItem1.Caption = "Simple View"
            Me.switchToSimpleViewItem1.Enabled = False
            Me.switchToSimpleViewItem1.Id = 19
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ToolTipTitleItem1.Text = "Simple View"
            ToolTipItem1.Text = "View the document as a simple memo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This view ignores the page layout to draw " & _
        "attention to text editing."
            SuperToolTip1.Items.Add(ToolTipTitleItem1)
            SuperToolTip1.Items.Add(ToolTipItem1)
            Me.switchToSimpleViewItem1.SuperTip = SuperToolTip1
            '
            'switchToDraftViewItem1
            '
            Me.switchToDraftViewItem1.Caption = "Draft View"
            Me.switchToDraftViewItem1.Enabled = False
            Me.switchToDraftViewItem1.Id = 20
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ToolTipTitleItem2.Text = "Draft View"
            ToolTipItem2.Text = "View the document as a draft to quickly edit the text." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Certain elements of the" & _
        " document such as headers and footers will not be visible in this view."
            SuperToolTip2.Items.Add(ToolTipTitleItem2)
            SuperToolTip2.Items.Add(ToolTipItem2)
            Me.switchToDraftViewItem1.SuperTip = SuperToolTip2
            '
            'switchToPrintLayoutViewItem1
            '
            Me.switchToPrintLayoutViewItem1.Caption = "Print Layout"
            Me.switchToPrintLayoutViewItem1.Id = 21
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ToolTipTitleItem3.Text = "Print Layout"
            ToolTipItem3.Text = "View the document as it will appear on the printed page."
            SuperToolTip3.Items.Add(ToolTipTitleItem3)
            SuperToolTip3.Items.Add(ToolTipItem3)
            Me.switchToPrintLayoutViewItem1.SuperTip = SuperToolTip3
            '
            'standaloneBarDockControl1
            '
            Me.standaloneBarDockControl1.AutoSize = True
            Me.standaloneBarDockControl1.CausesValidation = False
            Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            Me.standaloneBarDockControl1.Size = New System.Drawing.Size(776, 1)
            Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Caption = "Paste"
            Me.pasteItem1.Enabled = False
            Me.pasteItem1.Id = 18
            Me.pasteItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
            Me.pasteItem1.Name = "pasteItem1"
            ToolTipTitleItem4.Text = "Paste (Ctrl+V)"
            ToolTipItem4.Text = "Paste the contents of the Clipboard."
            SuperToolTip4.Items.Add(ToolTipTitleItem4)
            SuperToolTip4.Items.Add(ToolTipItem4)
            Me.pasteItem1.SuperTip = SuperToolTip4
            '
            'copyItem1
            '
            Me.copyItem1.Caption = "Copy"
            Me.copyItem1.Enabled = False
            Me.copyItem1.Id = 17
            Me.copyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.copyItem1.Name = "copyItem1"
            ToolTipTitleItem5.Text = "Copy (Ctrl+C)"
            ToolTipItem5.Text = "Copy the selection and put it on the Clipboard."
            SuperToolTip5.Items.Add(ToolTipTitleItem5)
            SuperToolTip5.Items.Add(ToolTipItem5)
            Me.copyItem1.SuperTip = SuperToolTip5
            '
            'cutItem1
            '
            Me.cutItem1.Caption = "Cut"
            Me.cutItem1.Enabled = False
            Me.cutItem1.Id = 16
            Me.cutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
            Me.cutItem1.Name = "cutItem1"
            ToolTipTitleItem6.Text = "Cut (Ctrl+X)"
            ToolTipItem6.Text = "Cut the selection from the document and put it on the Clipboard."
            SuperToolTip6.Items.Add(ToolTipTitleItem6)
            SuperToolTip6.Items.Add(ToolTipItem6)
            Me.cutItem1.SuperTip = SuperToolTip6
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlBottom.Size = New System.Drawing.Size(0, 0)
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(0, 0)
            '
            'richEditBarController1
            '
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
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem2)
            Me.richEditBarController1.BarItems.Add(Me.copyItem2)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem2)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem2)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem2)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem2)
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
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
            Me.richEditBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 0
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
            Me.changeFontSizeItem1.Id = 15
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
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 65)
            Me.richEditControl.MenuManager = Me.barManager
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Export.Doc.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.Html.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.Mht.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.OpenDocument.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.OpenXml.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.PlainText.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.Rtf.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Options.Export.WordML.ExportedDocumentProperties = CType(((((((((((((((((DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Category Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentStatus) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.ContentType) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Created) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Creator) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Description) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Identifier) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Keywords) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Language) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastModifiedBy) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.LastPrinted) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Modified) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Revision) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Subject) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Title) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.Version) _
                Or DevExpress.XtraRichEdit.Export.DocumentPropertyNames.CustomProperties), DevExpress.XtraRichEdit.Export.DocumentPropertyNames)
            Me.richEditControl.Size = New System.Drawing.Size(794, 261)
            Me.richEditControl.TabIndex = 0
            Me.richEditControl.Text = "richEditControl1"
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.fontBar1, Me.paragraphBar1, Me.linksBar1, Me.commonBar1, Me.illustrationsBar1, Me.textBar1, Me.stylesBar1, Me.headerFooterBar1, Me.headerFooterToolsDesignNavigationBar1, Me.headerFooterToolsDesignOptionsBar1, Me.headerFooterToolsDesignCloseBar1, Me.rowsAndColumnsBar1, Me.pageSetupBar1, Me.FileInfoBar1})
            Me.barManager.DockControls.Add(Me.barDockControl1)
            Me.barManager.DockControls.Add(Me.barDockControl2)
            Me.barManager.DockControls.Add(Me.barDockControl3)
            Me.barManager.DockControls.Add(Me.barDockControl4)
            Me.barManager.DockControls.Add(Me.standaloneBarDockControl2)
            Me.barManager.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.cutItem2, Me.copyItem2, Me.pasteItem2, Me.findItem1, Me.replaceItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.changeStyleItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.switchToSimpleViewItem2, Me.switchToDraftViewItem2, Me.switchToPrintLayoutViewItem2, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.goToNextHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.mergeTableCellsItem1, Me.insertTableItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.barManager.MaxItemId = 172
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
            '
            'fontBar1
            '
            Me.fontBar1.Control = Me.richEditControl
            Me.fontBar1.DockCol = 0
            Me.fontBar1.DockRow = 1
            Me.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.fontBar1.FloatLocation = New System.Drawing.Point(85, 243)
            Me.fontBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.changeFontNameItem1, "", False, True, True, 102), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.changeFontSizeItem1, "", False, True, True, 53), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontBackColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontBoldItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontItalicItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSuperscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSubscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeIncreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeDecreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.clearFormattingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showFontFormItem1)})
            Me.fontBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'changeFontColorItem1
            '
            Me.changeFontColorItem1.Id = 1
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            '
            'changeFontBackColorItem1
            '
            Me.changeFontBackColorItem1.Id = 2
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            '
            'toggleFontBoldItem1
            '
            Me.toggleFontBoldItem1.Id = 3
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            '
            'toggleFontItalicItem1
            '
            Me.toggleFontItalicItem1.Id = 4
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            '
            'toggleFontUnderlineItem1
            '
            Me.toggleFontUnderlineItem1.Id = 5
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            '
            'toggleFontDoubleUnderlineItem1
            '
            Me.toggleFontDoubleUnderlineItem1.Id = 6
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            '
            'toggleFontStrikeoutItem1
            '
            Me.toggleFontStrikeoutItem1.Id = 7
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            '
            'toggleFontDoubleStrikeoutItem1
            '
            Me.toggleFontDoubleStrikeoutItem1.Id = 8
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            '
            'toggleFontSuperscriptItem1
            '
            Me.toggleFontSuperscriptItem1.Id = 9
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            '
            'toggleFontSubscriptItem1
            '
            Me.toggleFontSubscriptItem1.Id = 10
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            '
            'fontSizeIncreaseItem1
            '
            Me.fontSizeIncreaseItem1.Id = 11
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            '
            'fontSizeDecreaseItem1
            '
            Me.fontSizeDecreaseItem1.Id = 12
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            '
            'clearFormattingItem1
            '
            Me.clearFormattingItem1.Id = 13
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            '
            'showFontFormItem1
            '
            Me.showFontFormItem1.Id = 14
            Me.showFontFormItem1.Name = "showFontFormItem1"
            '
            'standaloneBarDockControl2
            '
            Me.standaloneBarDockControl2.CausesValidation = False
            Me.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl2.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl2.Name = "standaloneBarDockControl2"
            Me.standaloneBarDockControl2.Size = New System.Drawing.Size(794, 63)
            Me.standaloneBarDockControl2.Text = "standaloneBarDockControl2"
            '
            'paragraphBar1
            '
            Me.paragraphBar1.Control = Me.richEditControl
            Me.paragraphBar1.DockCol = 2
            Me.paragraphBar1.DockRow = 0
            Me.paragraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.paragraphBar1.FloatLocation = New System.Drawing.Point(158, 254)
            Me.paragraphBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentLeftItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentCenterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentRightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentJustifyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleNumberingListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleBulletedListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleMultiLevelListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.decreaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.increaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowWhitespaceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showParagraphFormItem1)})
            Me.paragraphBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'toggleParagraphAlignmentLeftItem1
            '
            Me.toggleParagraphAlignmentLeftItem1.Id = 16
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            '
            'toggleParagraphAlignmentCenterItem1
            '
            Me.toggleParagraphAlignmentCenterItem1.Id = 17
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            '
            'toggleParagraphAlignmentRightItem1
            '
            Me.toggleParagraphAlignmentRightItem1.Id = 18
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            '
            'toggleParagraphAlignmentJustifyItem1
            '
            Me.toggleParagraphAlignmentJustifyItem1.Id = 19
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            '
            'toggleNumberingListItem1
            '
            Me.toggleNumberingListItem1.Id = 20
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            '
            'toggleBulletedListItem1
            '
            Me.toggleBulletedListItem1.Id = 21
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            '
            'toggleMultiLevelListItem1
            '
            Me.toggleMultiLevelListItem1.Id = 22
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            '
            'decreaseIndentItem1
            '
            Me.decreaseIndentItem1.Id = 23
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            '
            'increaseIndentItem1
            '
            Me.increaseIndentItem1.Id = 24
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            '
            'toggleShowWhitespaceItem1
            '
            Me.toggleShowWhitespaceItem1.Id = 25
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            '
            'showParagraphFormItem1
            '
            Me.showParagraphFormItem1.Id = 26
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            '
            'linksBar1
            '
            Me.linksBar1.Control = Me.richEditControl
            Me.linksBar1.DockCol = 3
            Me.linksBar1.DockRow = 0
            Me.linksBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.linksBar1.FloatLocation = New System.Drawing.Point(468, 206)
            Me.linksBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertBookmarkItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertHyperlinkItem1)})
            Me.linksBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Id = 27
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Id = 28
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'commonBar1
            '
            Me.commonBar1.Control = Me.richEditControl
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar1.FloatLocation = New System.Drawing.Point(323, 168)
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1)})
            Me.commonBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 29
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 30
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 31
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 32
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'undoItem1
            '
            Me.undoItem1.Id = 33
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Id = 34
            Me.redoItem1.Name = "redoItem1"
            '
            'illustrationsBar1
            '
            Me.illustrationsBar1.Control = Me.richEditControl
            Me.illustrationsBar1.DockCol = 8
            Me.illustrationsBar1.DockRow = 0
            Me.illustrationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.illustrationsBar1.FloatLocation = New System.Drawing.Point(631, 239)
            Me.illustrationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPictureItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertFloatingPictureItem1)})
            Me.illustrationsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Id = 35
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Id = 168
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'textBar1
            '
            Me.textBar1.Control = Me.richEditControl
            Me.textBar1.DockCol = 4
            Me.textBar1.DockRow = 0
            Me.textBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.textBar1.FloatLocation = New System.Drawing.Point(631, 239)
            Me.textBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTextBoxItem1)})
            Me.textBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Id = 169
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'stylesBar1
            '
            Me.stylesBar1.Control = Me.richEditControl
            Me.stylesBar1.DockCol = 1
            Me.stylesBar1.DockRow = 1
            Me.stylesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.stylesBar1.FloatLocation = New System.Drawing.Point(608, 283)
            Me.stylesBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.changeStyleItem1, "", False, True, True, 91)})
            Me.stylesBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'changeStyleItem1
            '
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 44
            Me.changeStyleItem1.Name = "changeStyleItem1"
            '
            'repositoryItemRichEditStyleEdit1
            '
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            '
            'headerFooterBar1
            '
            Me.headerFooterBar1.Control = Me.richEditControl
            Me.headerFooterBar1.DockCol = 5
            Me.headerFooterBar1.DockRow = 0
            Me.headerFooterBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterBar1.FloatLocation = New System.Drawing.Point(-1086, 314)
            Me.headerFooterBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editPageFooterItem1)})
            Me.headerFooterBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'editPageFooterItem1
            '
            Me.editPageFooterItem1.Id = 134
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            '
            'headerFooterToolsDesignNavigationBar1
            '
            Me.headerFooterToolsDesignNavigationBar1.Control = Me.richEditControl
            Me.headerFooterToolsDesignNavigationBar1.DockCol = 2
            Me.headerFooterToolsDesignNavigationBar1.DockRow = 1
            Me.headerFooterToolsDesignNavigationBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignNavigationBar1.FloatLocation = New System.Drawing.Point(-842, 318)
            Me.headerFooterToolsDesignNavigationBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPreviousHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToNextHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleLinkToPreviousItem1)})
            Me.headerFooterToolsDesignNavigationBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'goToPageHeaderItem1
            '
            Me.goToPageHeaderItem1.Id = 135
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            '
            'goToPageFooterItem1
            '
            Me.goToPageFooterItem1.Id = 136
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            '
            'goToPreviousHeaderFooterItem1
            '
            Me.goToPreviousHeaderFooterItem1.Id = 137
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            '
            'goToNextHeaderFooterItem1
            '
            Me.goToNextHeaderFooterItem1.Id = 138
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            '
            'toggleLinkToPreviousItem1
            '
            Me.toggleLinkToPreviousItem1.Id = 139
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            '
            'headerFooterToolsDesignOptionsBar1
            '
            Me.headerFooterToolsDesignOptionsBar1.Control = Me.richEditControl
            Me.headerFooterToolsDesignOptionsBar1.DockCol = 3
            Me.headerFooterToolsDesignOptionsBar1.DockRow = 1
            Me.headerFooterToolsDesignOptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignOptionsBar1.FloatLocation = New System.Drawing.Point(-842, 280)
            Me.headerFooterToolsDesignOptionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentFirstPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentOddAndEvenPagesItem1)})
            Me.headerFooterToolsDesignOptionsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'toggleDifferentFirstPageItem1
            '
            Me.toggleDifferentFirstPageItem1.Id = 140
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            '
            'toggleDifferentOddAndEvenPagesItem1
            '
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 141
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            '
            'headerFooterToolsDesignCloseBar1
            '
            Me.headerFooterToolsDesignCloseBar1.Control = Me.richEditControl
            Me.headerFooterToolsDesignCloseBar1.DockCol = 4
            Me.headerFooterToolsDesignCloseBar1.DockRow = 1
            Me.headerFooterToolsDesignCloseBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignCloseBar1.FloatLocation = New System.Drawing.Point(-841, 271)
            Me.headerFooterToolsDesignCloseBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.closePageHeaderFooterItem1)})
            Me.headerFooterToolsDesignCloseBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'closePageHeaderFooterItem1
            '
            Me.closePageHeaderFooterItem1.Id = 142
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            '
            'rowsAndColumnsBar1
            '
            Me.rowsAndColumnsBar1.Control = Me.richEditControl
            Me.rowsAndColumnsBar1.DockCol = 7
            Me.rowsAndColumnsBar1.DockRow = 0
            Me.rowsAndColumnsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.rowsAndColumnsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableRowAboveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableRowBelowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.mergeTableCellsItem1)})
            Me.rowsAndColumnsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'insertTableItem1
            '
            Me.insertTableItem1.Id = 154
            Me.insertTableItem1.Name = "insertTableItem1"
            '
            'insertTableRowAboveItem1
            '
            Me.insertTableRowAboveItem1.Id = 151
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            '
            'insertTableRowBelowItem1
            '
            Me.insertTableRowBelowItem1.Id = 152
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            '
            'mergeTableCellsItem1
            '
            Me.mergeTableCellsItem1.Id = 153
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            '
            'pageSetupBar1
            '
            Me.pageSetupBar1.Control = Me.richEditControl
            Me.pageSetupBar1.DockCol = 6
            Me.pageSetupBar1.DockRow = 0
            Me.pageSetupBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.pageSetupBar1.FloatLocation = New System.Drawing.Point(409, 211)
            Me.pageSetupBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPaperKindItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionLineNumberingItem1)})
            Me.pageSetupBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'changeSectionPageMarginsItem1
            '
            Me.changeSectionPageMarginsItem1.Id = 125
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1)})
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            Me.changeSectionPageMarginsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'setNormalSectionPageMarginsItem1
            '
            Me.setNormalSectionPageMarginsItem1.Id = 126
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            '
            'setNarrowSectionPageMarginsItem1
            '
            Me.setNarrowSectionPageMarginsItem1.Id = 127
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            '
            'setModerateSectionPageMarginsItem1
            '
            Me.setModerateSectionPageMarginsItem1.Id = 128
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            '
            'setWideSectionPageMarginsItem1
            '
            Me.setWideSectionPageMarginsItem1.Id = 129
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            '
            'showPageMarginsSetupFormItem1
            '
            Me.showPageMarginsSetupFormItem1.Id = 461
            Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            '
            'changeSectionPageOrientationItem1
            '
            Me.changeSectionPageOrientationItem1.Id = 130
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            Me.changeSectionPageOrientationItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'setPortraitPageOrientationItem1
            '
            Me.setPortraitPageOrientationItem1.Id = 131
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            '
            'setLandscapePageOrientationItem1
            '
            Me.setLandscapePageOrientationItem1.Id = 132
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            '
            'changeSectionPaperKindItem1
            '
            Me.changeSectionPaperKindItem1.Id = 200
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            '
            'changeSectionColumnsItem1
            '
            Me.changeSectionColumnsItem1.Id = 160
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1)})
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            Me.changeSectionColumnsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'setSectionOneColumnItem1
            '
            Me.setSectionOneColumnItem1.Id = 161
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            '
            'setSectionTwoColumnsItem1
            '
            Me.setSectionTwoColumnsItem1.Id = 162
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            '
            'setSectionThreeColumnsItem1
            '
            Me.setSectionThreeColumnsItem1.Id = 163
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            '
            'showColumnsSetupFormItem1
            '
            Me.showColumnsSetupFormItem1.Id = 163
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            '
            'insertBreakItem1
            '
            Me.insertBreakItem1.Id = 247
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
            Me.insertBreakItem1.Name = "insertBreakItem1"
            Me.insertBreakItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Id = 49
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            '
            'insertColumnBreakItem1
            '
            Me.insertColumnBreakItem1.Id = 248
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            '
            'insertSectionBreakNextPageItem1
            '
            Me.insertSectionBreakNextPageItem1.Id = 249
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            '
            'insertSectionBreakEvenPageItem1
            '
            Me.insertSectionBreakEvenPageItem1.Id = 250
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            '
            'insertSectionBreakOddPageItem1
            '
            Me.insertSectionBreakOddPageItem1.Id = 251
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            '
            'changeSectionLineNumberingItem1
            '
            Me.changeSectionLineNumberingItem1.Id = 252
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1)})
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            Me.changeSectionLineNumberingItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'setSectionLineNumberingNoneItem1
            '
            Me.setSectionLineNumberingNoneItem1.Id = 253
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            '
            'setSectionLineNumberingContinuousItem1
            '
            Me.setSectionLineNumberingContinuousItem1.Id = 254
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            '
            'setSectionLineNumberingRestartNewPageItem1
            '
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 255
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            '
            'setSectionLineNumberingRestartNewSectionItem1
            '
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 256
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            '
            'toggleParagraphSuppressLineNumbersItem1
            '
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 257
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            '
            'showLineNumberingFormItem1
            '
            Me.showLineNumberingFormItem1.Id = 258
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            '
            'barDockControl1
            '
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(798, 0)
            '
            'barDockControl2
            '
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 421)
            Me.barDockControl2.Size = New System.Drawing.Size(798, 0)
            '
            'barDockControl3
            '
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 421)
            '
            'barDockControl4
            '
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(798, 0)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 421)
            '
            'cutItem2
            '
            Me.cutItem2.Id = 36
            Me.cutItem2.Name = "cutItem2"
            '
            'copyItem2
            '
            Me.copyItem2.Id = 37
            Me.copyItem2.Name = "copyItem2"
            '
            'pasteItem2
            '
            Me.pasteItem2.Id = 38
            Me.pasteItem2.Name = "pasteItem2"
            '
            'findItem1
            '
            Me.findItem1.Id = 39
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Id = 40
            Me.replaceItem1.Name = "replaceItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 41
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 42
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 43
            Me.printPreviewItem1.Name = "printPreviewItem1"
            '
            'insertMergeFieldItem1
            '
            Me.insertMergeFieldItem1.Id = 45
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            '
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 46
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 47
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'toggleViewMergedDataItem1
            '
            Me.toggleViewMergedDataItem1.Id = 48
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            '
            'switchToSimpleViewItem2
            '
            Me.switchToSimpleViewItem2.Id = 50
            Me.switchToSimpleViewItem2.Name = "switchToSimpleViewItem2"
            '
            'switchToDraftViewItem2
            '
            Me.switchToDraftViewItem2.Id = 51
            Me.switchToDraftViewItem2.Name = "switchToDraftViewItem2"
            '
            'switchToPrintLayoutViewItem2
            '
            Me.switchToPrintLayoutViewItem2.Id = 52
            Me.switchToPrintLayoutViewItem2.Name = "switchToPrintLayoutViewItem2"
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Id = 53
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            '
            'editPageHeaderItem1
            '
            Me.editPageHeaderItem1.Id = 133
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            '
            'insertPageNumberItem1
            '
            Me.insertPageNumberItem1.Id = 155
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            '
            'insertPageCountItem1
            '
            Me.insertPageCountItem1.Id = 156
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.standaloneBarDockControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 93)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(798, 328)
            Me.panelControl1.TabIndex = 0
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.gcOthers)
            Me.panelControl3.Controls.Add(Me.gcNumbering)
            Me.panelControl3.Controls.Add(Me.gcPage)
            Me.panelControl3.Controls.Add(Me.edtHideDisabled)
            Me.panelControl3.Controls.Add(Me.gcLinks)
            Me.panelControl3.Controls.Add(Me.gcParagraph)
            Me.panelControl3.Controls.Add(Me.gcCharacter)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl3.Location = New System.Drawing.Point(0, 0)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(798, 93)
            Me.panelControl3.TabIndex = 1
            '
            'gcOthers
            '
            Me.gcOthers.Controls.Add(Me.edtAllowTables)
            Me.gcOthers.Controls.Add(Me.edtAllowHeadersFooters)
            Me.gcOthers.Controls.Add(Me.edtAllowSections)
            Me.gcOthers.Controls.Add(Me.checkEdit1)
            Me.gcOthers.Location = New System.Drawing.Point(532, 5)
            Me.gcOthers.Name = "gcOthers"
            Me.gcOthers.Size = New System.Drawing.Size(150, 73)
            Me.gcOthers.TabIndex = 17
            Me.gcOthers.Text = "Other"
            '
            'edtAllowTables
            '
            Me.edtAllowTables.EditValue = True
            Me.edtAllowTables.Location = New System.Drawing.Point(80, 25)
            Me.edtAllowTables.MenuManager = Me
            Me.edtAllowTables.Name = "edtAllowTables"
            Me.edtAllowTables.Properties.Caption = "Tables"
            Me.edtAllowTables.Size = New System.Drawing.Size(65, 19)
            Me.edtAllowTables.TabIndex = 20
            '
            'edtAllowHeadersFooters
            '
            Me.edtAllowHeadersFooters.EditValue = True
            Me.edtAllowHeadersFooters.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowHeadersFooters.Name = "edtAllowHeadersFooters"
            Me.edtAllowHeadersFooters.Properties.Caption = "Headers/Footers"
            Me.edtAllowHeadersFooters.Size = New System.Drawing.Size(102, 19)
            Me.edtAllowHeadersFooters.TabIndex = 19
            '
            'edtAllowSections
            '
            Me.edtAllowSections.EditValue = True
            Me.edtAllowSections.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowSections.MenuManager = Me
            Me.edtAllowSections.Name = "edtAllowSections"
            Me.edtAllowSections.Properties.Caption = "Sections"
            Me.edtAllowSections.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowSections.TabIndex = 18
            '
            'checkEdit1
            '
            Me.checkEdit1.Location = New System.Drawing.Point(5, 25)
            Me.checkEdit1.MenuManager = Me
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Sections"
            Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
            Me.checkEdit1.TabIndex = 0
            '
            'gcNumbering
            '
            Me.gcNumbering.Controls.Add(Me.edtAllowMultiLevelNumbering)
            Me.gcNumbering.Controls.Add(Me.edtAllowBulletNumbering)
            Me.gcNumbering.Controls.Add(Me.edtAllowSimpleNumbering)
            Me.gcNumbering.Location = New System.Drawing.Point(229, 5)
            Me.gcNumbering.Name = "gcNumbering"
            Me.gcNumbering.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcNumbering.Size = New System.Drawing.Size(130, 73)
            Me.gcNumbering.TabIndex = 8
            Me.gcNumbering.Text = "Numbering"
            '
            'edtAllowMultiLevelNumbering
            '
            Me.edtAllowMultiLevelNumbering.EditValue = True
            Me.edtAllowMultiLevelNumbering.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowMultiLevelNumbering.Name = "edtAllowMultiLevelNumbering"
            Me.edtAllowMultiLevelNumbering.Properties.Caption = "Multi level"
            Me.edtAllowMultiLevelNumbering.Size = New System.Drawing.Size(76, 19)
            Me.edtAllowMultiLevelNumbering.TabIndex = 10
            '
            'edtAllowBulletNumbering
            '
            Me.edtAllowBulletNumbering.EditValue = True
            Me.edtAllowBulletNumbering.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowBulletNumbering.Name = "edtAllowBulletNumbering"
            Me.edtAllowBulletNumbering.Properties.Caption = "Bulleted"
            Me.edtAllowBulletNumbering.Size = New System.Drawing.Size(62, 19)
            Me.edtAllowBulletNumbering.TabIndex = 9
            '
            'edtAllowSimpleNumbering
            '
            Me.edtAllowSimpleNumbering.EditValue = True
            Me.edtAllowSimpleNumbering.Location = New System.Drawing.Point(73, 25)
            Me.edtAllowSimpleNumbering.Name = "edtAllowSimpleNumbering"
            Me.edtAllowSimpleNumbering.Properties.Caption = "Simple"
            Me.edtAllowSimpleNumbering.Size = New System.Drawing.Size(51, 19)
            Me.edtAllowSimpleNumbering.TabIndex = 11
            '
            'gcPage
            '
            Me.gcPage.Controls.Add(Me.edtAllowSymbolTabs)
            Me.gcPage.Controls.Add(Me.edtAllowPicture)
            Me.gcPage.Location = New System.Drawing.Point(365, 5)
            Me.gcPage.Name = "gcPage"
            Me.gcPage.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcPage.Size = New System.Drawing.Size(73, 73)
            Me.gcPage.TabIndex = 12
            Me.gcPage.Text = "Content"
            '
            'edtAllowSymbolTabs
            '
            Me.edtAllowSymbolTabs.EditValue = True
            Me.edtAllowSymbolTabs.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowSymbolTabs.Name = "edtAllowSymbolTabs"
            Me.edtAllowSymbolTabs.Properties.Caption = "Tabs"
            Me.edtAllowSymbolTabs.Size = New System.Drawing.Size(64, 19)
            Me.edtAllowSymbolTabs.TabIndex = 14
            '
            'edtAllowPicture
            '
            Me.edtAllowPicture.EditValue = True
            Me.edtAllowPicture.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowPicture.Name = "edtAllowPicture"
            Me.edtAllowPicture.Properties.Caption = "Pictures"
            Me.edtAllowPicture.Size = New System.Drawing.Size(64, 19)
            Me.edtAllowPicture.TabIndex = 13
            '
            'edtHideDisabled
            '
            Me.edtHideDisabled.Location = New System.Drawing.Point(688, 51)
            Me.edtHideDisabled.Name = "edtHideDisabled"
            Me.edtHideDisabled.Properties.Appearance.Options.UseTextOptions = True
            Me.edtHideDisabled.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.edtHideDisabled.Properties.Caption = "Hide disabled bar items"
            Me.edtHideDisabled.Size = New System.Drawing.Size(86, 30)
            Me.edtHideDisabled.TabIndex = 22
            '
            'gcLinks
            '
            Me.gcLinks.Controls.Add(Me.edtAllowHyperlinks)
            Me.gcLinks.Controls.Add(Me.edtAllowBookmarks)
            Me.gcLinks.Location = New System.Drawing.Point(444, 5)
            Me.gcLinks.Name = "gcLinks"
            Me.gcLinks.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcLinks.Size = New System.Drawing.Size(82, 73)
            Me.gcLinks.TabIndex = 15
            Me.gcLinks.Text = "Links"
            '
            'edtAllowHyperlinks
            '
            Me.edtAllowHyperlinks.EditValue = True
            Me.edtAllowHyperlinks.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowHyperlinks.Name = "edtAllowHyperlinks"
            Me.edtAllowHyperlinks.Properties.Caption = "Hyperlinks"
            Me.edtAllowHyperlinks.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowHyperlinks.TabIndex = 16
            '
            'edtAllowBookmarks
            '
            Me.edtAllowBookmarks.EditValue = True
            Me.edtAllowBookmarks.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowBookmarks.Name = "edtAllowBookmarks"
            Me.edtAllowBookmarks.Properties.Caption = "Bookmarks"
            Me.edtAllowBookmarks.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowBookmarks.TabIndex = 17
            '
            'gcParagraph
            '
            Me.gcParagraph.Controls.Add(Me.edtAllowParagraphTabs)
            Me.gcParagraph.Controls.Add(Me.edtAllowParagraphStyle)
            Me.gcParagraph.Controls.Add(Me.edtAllowParagraph)
            Me.gcParagraph.Controls.Add(Me.edtAllowParagraphPraperties)
            Me.gcParagraph.Location = New System.Drawing.Point(93, 5)
            Me.gcParagraph.Name = "gcParagraph"
            Me.gcParagraph.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcParagraph.Size = New System.Drawing.Size(130, 73)
            Me.gcParagraph.TabIndex = 3
            Me.gcParagraph.Text = "Paragraph"
            '
            'edtAllowParagraphTabs
            '
            Me.edtAllowParagraphTabs.EditValue = True
            Me.edtAllowParagraphTabs.Location = New System.Drawing.Point(80, 25)
            Me.edtAllowParagraphTabs.Name = "edtAllowParagraphTabs"
            Me.edtAllowParagraphTabs.Properties.Caption = "Tabs"
            Me.edtAllowParagraphTabs.Size = New System.Drawing.Size(48, 19)
            Me.edtAllowParagraphTabs.TabIndex = 6
            '
            'edtAllowParagraphStyle
            '
            Me.edtAllowParagraphStyle.EditValue = True
            Me.edtAllowParagraphStyle.Location = New System.Drawing.Point(80, 49)
            Me.edtAllowParagraphStyle.Name = "edtAllowParagraphStyle"
            Me.edtAllowParagraphStyle.Properties.Caption = "Style"
            Me.edtAllowParagraphStyle.Size = New System.Drawing.Size(45, 19)
            Me.edtAllowParagraphStyle.TabIndex = 7
            '
            'edtAllowParagraph
            '
            Me.edtAllowParagraph.EditValue = True
            Me.edtAllowParagraph.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowParagraph.Name = "edtAllowParagraph"
            Me.edtAllowParagraph.Properties.Caption = "Insert new"
            Me.edtAllowParagraph.Size = New System.Drawing.Size(84, 19)
            Me.edtAllowParagraph.TabIndex = 4
            '
            'edtAllowParagraphPraperties
            '
            Me.edtAllowParagraphPraperties.EditValue = True
            Me.edtAllowParagraphPraperties.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowParagraphPraperties.Name = "edtAllowParagraphPraperties"
            Me.edtAllowParagraphPraperties.Properties.Caption = "Formatting"
            Me.edtAllowParagraphPraperties.Size = New System.Drawing.Size(84, 19)
            Me.edtAllowParagraphPraperties.TabIndex = 5
            '
            'gcCharacter
            '
            Me.gcCharacter.Controls.Add(Me.edtAllowCharacterFormatting)
            Me.gcCharacter.Controls.Add(Me.edtAllowCharacterStyle)
            Me.gcCharacter.Location = New System.Drawing.Point(5, 5)
            Me.gcCharacter.Name = "gcCharacter"
            Me.gcCharacter.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcCharacter.Size = New System.Drawing.Size(82, 73)
            Me.gcCharacter.TabIndex = 0
            Me.gcCharacter.Text = "Character"
            '
            'edtAllowCharacterFormatting
            '
            Me.edtAllowCharacterFormatting.EditValue = True
            Me.edtAllowCharacterFormatting.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowCharacterFormatting.Name = "edtAllowCharacterFormatting"
            Me.edtAllowCharacterFormatting.Properties.Caption = "Formatting"
            Me.edtAllowCharacterFormatting.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowCharacterFormatting.TabIndex = 1
            '
            'edtAllowCharacterStyle
            '
            Me.edtAllowCharacterStyle.EditValue = True
            Me.edtAllowCharacterStyle.Location = New System.Drawing.Point(5, 49)
            Me.edtAllowCharacterStyle.Name = "edtAllowCharacterStyle"
            Me.edtAllowCharacterStyle.Properties.Caption = "Style"
            Me.edtAllowCharacterStyle.Size = New System.Drawing.Size(57, 19)
            Me.edtAllowCharacterStyle.TabIndex = 2
            '
            'FileInfoBar1
            '
            Me.FileInfoBar1.Control = Me.richEditControl
            Me.FileInfoBar1.DockCol = 1
            Me.FileInfoBar1.DockRow = 0
            Me.FileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.FileInfoBar1.FloatLocation = New System.Drawing.Point(215, 199)
            Me.FileInfoBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ShowDocumentPropertiesFormItem1)})
            Me.FileInfoBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 171
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'DocumentRestrictionsModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panelControl3)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Name = "DocumentRestrictionsModule"
            Me.Size = New System.Drawing.Size(798, 421)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            CType(Me.rgrpViewType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            CType(Me.gcOthers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcOthers.ResumeLayout(False)
            CType(Me.edtAllowTables.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowHeadersFooters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowSections.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcNumbering, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcNumbering.ResumeLayout(False)
            CType(Me.edtAllowMultiLevelNumbering.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowBulletNumbering.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowSimpleNumbering.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcPage.ResumeLayout(False)
            CType(Me.edtAllowSymbolTabs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtHideDisabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcLinks, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcLinks.ResumeLayout(False)
            CType(Me.edtAllowHyperlinks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowBookmarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcParagraph, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcParagraph.ResumeLayout(False)
            CType(Me.edtAllowParagraphTabs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowParagraphStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowParagraph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowParagraphPraperties.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcCharacter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcCharacter.ResumeLayout(False)
            CType(Me.edtAllowCharacterFormatting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowCharacterStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private rgrpViewType As DevExpress.XtraEditors.RadioGroup
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private documentViewsBar1 As DevExpress.XtraRichEdit.UI.DocumentViewsBar
        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private panelControl3 As DevExpress.XtraEditors.PanelControl
        Private richEditControl As RichEditControl
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private barManager As DevExpress.XtraBars.BarManager
        Private fontBar1 As DevExpress.XtraRichEdit.UI.FontBar
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
        Private standaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl
        Private barDockControl1 As DevExpress.XtraBars.BarDockControl
        Private barDockControl2 As DevExpress.XtraBars.BarDockControl
        Private barDockControl3 As DevExpress.XtraBars.BarDockControl
        Private barDockControl4 As DevExpress.XtraBars.BarDockControl
        Private paragraphBar1 As DevExpress.XtraRichEdit.UI.ParagraphBar
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private linksBar1 As DevExpress.XtraRichEdit.UI.LinksBar
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private illustrationsBar1 As DevExpress.XtraRichEdit.UI.IllustrationsBar
        Private textBar1 As DevExpress.XtraRichEdit.UI.TextBar
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Private cutItem2 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem2 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteItem2 As DevExpress.XtraRichEdit.UI.PasteItem
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Private switchToSimpleViewItem2 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem2 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem2 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private gcCharacter As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowCharacterFormatting As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowCharacterStyle As DevExpress.XtraEditors.CheckEdit
        Private gcParagraph As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowParagraph As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowParagraphPraperties As DevExpress.XtraEditors.CheckEdit
        Private gcLinks As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowHyperlinks As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowBookmarks As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowParagraphStyle As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtHideDisabled As DevExpress.XtraEditors.CheckEdit
        Private gcPage As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowPicture As DevExpress.XtraEditors.CheckEdit
        Private gcNumbering As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowMultiLevelNumbering As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowBulletNumbering As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowSimpleNumbering As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowParagraphTabs As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowSymbolTabs As DevExpress.XtraEditors.CheckEdit
        Private stylesBar1 As DevExpress.XtraRichEdit.UI.StylesBar
        Private gcOthers As DevExpress.XtraEditors.GroupControl
        Private WithEvents edtAllowHeadersFooters As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtAllowSections As DevExpress.XtraEditors.CheckEdit
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
		Private showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
        Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
        Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
        Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
        Private headerFooterBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterBar
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
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
        Private WithEvents edtAllowTables As DevExpress.XtraEditors.CheckEdit
        Private rowsAndColumnsBar1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsBar
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Private pageSetupBar1 As DevExpress.XtraRichEdit.UI.PageSetupBar
        Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
        Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
        Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
        Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
        Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
        Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
        Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
        Private WithEvents FileInfoBar1 As DevExpress.XtraRichEdit.UI.FileInfoBar
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
    End Class
End Namespace
