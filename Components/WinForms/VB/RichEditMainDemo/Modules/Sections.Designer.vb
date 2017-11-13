Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
    Partial Public Class SectionsModule
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SectionsModule))
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
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
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 33)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(841, 354)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.standaloneBarDockControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(845, 389)
            Me.panelControl1.TabIndex = 4
            ' 
            ' standaloneBarDockControl1
            ' 
            Me.standaloneBarDockControl1.AutoSize = True
            Me.standaloneBarDockControl1.CausesValidation = False
            Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            Me.standaloneBarDockControl1.Size = New System.Drawing.Size(841, 31)
            Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.commonBar1, Me.clipboardBar1, Me.headerFooterBar1, Me.headerFooterToolsDesignNavigationBar1, Me.headerFooterToolsDesignOptionsBar1, Me.headerFooterToolsDesignCloseBar1, Me.pageSetupBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.goToNextHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1})
            Me.barManager1.MaxItemId = 38
            ' 
            ' commonBar1
            ' 
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar1.FloatLocation = New System.Drawing.Point(277, 185)
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
            Me.undoItem1.Id = 7
            Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
            Me.redoItem1.Id = 8
            Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' clipboardBar1
            ' 
            Me.clipboardBar1.DockCol = 1
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(379, 150)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            Me.clipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
            Me.cutItem1.Id = 9
            Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
            Me.copyItem1.Id = 10
            Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
            Me.pasteItem1.Id = 11
            Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' headerFooterBar1
            ' 
            Me.headerFooterBar1.DockCol = 2
            Me.headerFooterBar1.DockRow = 0
            Me.headerFooterBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterBar1.FloatLocation = New System.Drawing.Point(-1403, 233)
            Me.headerFooterBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editPageHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.editPageFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageNumberItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageCountItem1)})
            Me.headerFooterBar1.Offset = 166
            Me.headerFooterBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' editPageHeaderItem1
            ' 
            Me.editPageHeaderItem1.Glyph = (CType(resources.GetObject("editPageHeaderItem1.Glyph"), System.Drawing.Image))
            Me.editPageHeaderItem1.Id = 12
            Me.editPageHeaderItem1.LargeGlyph = (CType(resources.GetObject("editPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            Me.editPageFooterItem1.Glyph = (CType(resources.GetObject("editPageFooterItem1.Glyph"), System.Drawing.Image))
            Me.editPageFooterItem1.Id = 13
            Me.editPageFooterItem1.LargeGlyph = (CType(resources.GetObject("editPageFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            Me.insertPageNumberItem1.Glyph = (CType(resources.GetObject("insertPageNumberItem1.Glyph"), System.Drawing.Image))
            Me.insertPageNumberItem1.Id = 30
            Me.insertPageNumberItem1.LargeGlyph = (CType(resources.GetObject("insertPageNumberItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            Me.insertPageCountItem1.Glyph = (CType(resources.GetObject("insertPageCountItem1.Glyph"), System.Drawing.Image))
            Me.insertPageCountItem1.Id = 31
            Me.insertPageCountItem1.LargeGlyph = (CType(resources.GetObject("insertPageCountItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' headerFooterToolsDesignNavigationBar1
            ' 
            Me.headerFooterToolsDesignNavigationBar1.DockCol = 4
            Me.headerFooterToolsDesignNavigationBar1.DockRow = 0
            Me.headerFooterToolsDesignNavigationBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignNavigationBar1.FloatLocation = New System.Drawing.Point(-1095, 206)
            Me.headerFooterToolsDesignNavigationBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPageFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToPreviousHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.goToNextHeaderFooterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleLinkToPreviousItem1)})
            Me.headerFooterToolsDesignNavigationBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' goToPageHeaderItem1
            ' 
            Me.goToPageHeaderItem1.Glyph = (CType(resources.GetObject("goToPageHeaderItem1.Glyph"), System.Drawing.Image))
            Me.goToPageHeaderItem1.Id = 22
            Me.goToPageHeaderItem1.LargeGlyph = (CType(resources.GetObject("goToPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            ' 
            ' goToPageFooterItem1
            ' 
            Me.goToPageFooterItem1.Glyph = (CType(resources.GetObject("goToPageFooterItem1.Glyph"), System.Drawing.Image))
            Me.goToPageFooterItem1.Id = 23
            Me.goToPageFooterItem1.LargeGlyph = (CType(resources.GetObject("goToPageFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            ' 
            ' goToPreviousHeaderFooterItem1
            ' 
            Me.goToPreviousHeaderFooterItem1.Glyph = (CType(resources.GetObject("goToPreviousHeaderFooterItem1.Glyph"), System.Drawing.Image))
            Me.goToPreviousHeaderFooterItem1.Id = 24
            Me.goToPreviousHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("goToPreviousHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            ' 
            ' goToNextHeaderFooterItem1
            ' 
            Me.goToNextHeaderFooterItem1.Glyph = (CType(resources.GetObject("goToNextHeaderFooterItem1.Glyph"), System.Drawing.Image))
            Me.goToNextHeaderFooterItem1.Id = 25
            Me.goToNextHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("goToNextHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            ' 
            ' toggleLinkToPreviousItem1
            ' 
            Me.toggleLinkToPreviousItem1.Glyph = (CType(resources.GetObject("toggleLinkToPreviousItem1.Glyph"), System.Drawing.Image))
            Me.toggleLinkToPreviousItem1.Id = 26
            Me.toggleLinkToPreviousItem1.LargeGlyph = (CType(resources.GetObject("toggleLinkToPreviousItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            ' 
            ' headerFooterToolsDesignOptionsBar1
            ' 
            Me.headerFooterToolsDesignOptionsBar1.DockCol = 5
            Me.headerFooterToolsDesignOptionsBar1.DockRow = 0
            Me.headerFooterToolsDesignOptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignOptionsBar1.FloatLocation = New System.Drawing.Point(-919, 184)
            Me.headerFooterToolsDesignOptionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentFirstPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleDifferentOddAndEvenPagesItem1)})
            Me.headerFooterToolsDesignOptionsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' toggleDifferentFirstPageItem1
            ' 
            Me.toggleDifferentFirstPageItem1.Glyph = (CType(resources.GetObject("toggleDifferentFirstPageItem1.Glyph"), System.Drawing.Image))
            Me.toggleDifferentFirstPageItem1.Id = 27
            Me.toggleDifferentFirstPageItem1.LargeGlyph = (CType(resources.GetObject("toggleDifferentFirstPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            ' 
            ' toggleDifferentOddAndEvenPagesItem1
            ' 
            Me.toggleDifferentOddAndEvenPagesItem1.Glyph = (CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.Glyph"), System.Drawing.Image))
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 28
            Me.toggleDifferentOddAndEvenPagesItem1.LargeGlyph = (CType(resources.GetObject("toggleDifferentOddAndEvenPagesItem1.LargeGlyph"), System.Drawing.Image))
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            ' 
            ' headerFooterToolsDesignCloseBar1
            ' 
            Me.headerFooterToolsDesignCloseBar1.DockCol = 6
            Me.headerFooterToolsDesignCloseBar1.DockRow = 0
            Me.headerFooterToolsDesignCloseBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.headerFooterToolsDesignCloseBar1.FloatLocation = New System.Drawing.Point(-793, 144)
            Me.headerFooterToolsDesignCloseBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.closePageHeaderFooterItem1)})
            Me.headerFooterToolsDesignCloseBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' closePageHeaderFooterItem1
            ' 
            Me.closePageHeaderFooterItem1.Glyph = (CType(resources.GetObject("closePageHeaderFooterItem1.Glyph"), System.Drawing.Image))
            Me.closePageHeaderFooterItem1.Id = 29
            Me.closePageHeaderFooterItem1.LargeGlyph = (CType(resources.GetObject("closePageHeaderFooterItem1.LargeGlyph"), System.Drawing.Image))
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            ' 
            ' pageSetupBar1
            ' 
            Me.pageSetupBar1.DockCol = 3
            Me.pageSetupBar1.DockRow = 0
            Me.pageSetupBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.pageSetupBar1.FloatLocation = New System.Drawing.Point(420, 151)
            Me.pageSetupBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPaperKindItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionLineNumberingItem1)})
            Me.pageSetupBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            ' 
            ' changeSectionPageMarginsItem1
            ' 
            Me.changeSectionPageMarginsItem1.Glyph = (CType(resources.GetObject("changeSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPageMarginsItem1.Id = 14
            Me.changeSectionPageMarginsItem1.LargeGlyph = (CType(resources.GetObject("changeSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1)})
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            Me.changeSectionPageMarginsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' setNormalSectionPageMarginsItem1
            ' 
            Me.setNormalSectionPageMarginsItem1.Glyph = (CType(resources.GetObject("setNormalSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setNormalSectionPageMarginsItem1.Id = 15
            Me.setNormalSectionPageMarginsItem1.LargeGlyph = (CType(resources.GetObject("setNormalSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            ' 
            ' setNarrowSectionPageMarginsItem1
            ' 
            Me.setNarrowSectionPageMarginsItem1.Glyph = (CType(resources.GetObject("setNarrowSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setNarrowSectionPageMarginsItem1.Id = 16
            Me.setNarrowSectionPageMarginsItem1.LargeGlyph = (CType(resources.GetObject("setNarrowSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            ' 
            ' setModerateSectionPageMarginsItem1
            ' 
            Me.setModerateSectionPageMarginsItem1.Glyph = (CType(resources.GetObject("setModerateSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setModerateSectionPageMarginsItem1.Id = 17
            Me.setModerateSectionPageMarginsItem1.LargeGlyph = (CType(resources.GetObject("setModerateSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            ' 
            ' setWideSectionPageMarginsItem1
            ' 
            Me.setWideSectionPageMarginsItem1.Glyph = (CType(resources.GetObject("setWideSectionPageMarginsItem1.Glyph"), System.Drawing.Image))
            Me.setWideSectionPageMarginsItem1.Id = 18
            Me.setWideSectionPageMarginsItem1.LargeGlyph = (CType(resources.GetObject("setWideSectionPageMarginsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            ' 
			' showPageMarginsSetupFormItem1
			' 
			Me.showPageMarginsSetupFormItem1.Id = 461
			Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
			' 
            ' changeSectionPageOrientationItem1
            ' 
            Me.changeSectionPageOrientationItem1.Glyph = (CType(resources.GetObject("changeSectionPageOrientationItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPageOrientationItem1.Id = 19
            Me.changeSectionPageOrientationItem1.LargeGlyph = (CType(resources.GetObject("changeSectionPageOrientationItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            Me.changeSectionPageOrientationItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' setPortraitPageOrientationItem1
            ' 
            Me.setPortraitPageOrientationItem1.Id = 20
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            ' 
            ' setLandscapePageOrientationItem1
            ' 
            Me.setLandscapePageOrientationItem1.Id = 21
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            ' 
            ' changeSectionPaperKindItem1
            ' 
            Me.changeSectionPaperKindItem1.Glyph = (CType(resources.GetObject("changeSectionPaperKindItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionPaperKindItem1.Id = 36
            Me.changeSectionPaperKindItem1.LargeGlyph = (CType(resources.GetObject("changeSectionPaperKindItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            ' 
            ' changeSectionColumnsItem1
            ' 
            Me.changeSectionColumnsItem1.Glyph = (CType(resources.GetObject("changeSectionColumnsItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionColumnsItem1.Id = 32
            Me.changeSectionColumnsItem1.LargeGlyph = (CType(resources.GetObject("changeSectionColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1)})
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            Me.changeSectionColumnsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' setSectionOneColumnItem1
            ' 
            Me.setSectionOneColumnItem1.Glyph = (CType(resources.GetObject("setSectionOneColumnItem1.Glyph"), System.Drawing.Image))
            Me.setSectionOneColumnItem1.Id = 33
            Me.setSectionOneColumnItem1.LargeGlyph = (CType(resources.GetObject("setSectionOneColumnItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            ' 
            ' setSectionTwoColumnsItem1
            ' 
            Me.setSectionTwoColumnsItem1.Glyph = (CType(resources.GetObject("setSectionTwoColumnsItem1.Glyph"), System.Drawing.Image))
            Me.setSectionTwoColumnsItem1.Id = 34
            Me.setSectionTwoColumnsItem1.LargeGlyph = (CType(resources.GetObject("setSectionTwoColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            ' 
            ' setSectionThreeColumnsItem1
            ' 
            Me.setSectionThreeColumnsItem1.Glyph = (CType(resources.GetObject("setSectionThreeColumnsItem1.Glyph"), System.Drawing.Image))
            Me.setSectionThreeColumnsItem1.Id = 35
            Me.setSectionThreeColumnsItem1.LargeGlyph = (CType(resources.GetObject("setSectionThreeColumnsItem1.LargeGlyph"), System.Drawing.Image))
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            ' 
            ' showColumnsSetupFormItem1
            ' 
            Me.showColumnsSetupFormItem1.Id = 35
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            ' 
            ' insertBreakItem1
            ' 
            Me.insertBreakItem1.Glyph = (CType(resources.GetObject("insertBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertBreakItem1.Id = 147
            Me.insertBreakItem1.LargeGlyph = (CType(resources.GetObject("insertBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
            Me.insertBreakItem1.Name = "insertBreakItem1"
            Me.insertBreakItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' insertPageBreakItem1
            ' 
            Me.insertPageBreakItem1.Glyph = (CType(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Id = 37
            Me.insertPageBreakItem1.LargeGlyph = (CType(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertColumnBreakItem1
            ' 
            Me.insertColumnBreakItem1.Glyph = (CType(resources.GetObject("insertColumnBreakItem1.Glyph"), System.Drawing.Image))
            Me.insertColumnBreakItem1.Id = 148
            Me.insertColumnBreakItem1.LargeGlyph = (CType(resources.GetObject("insertColumnBreakItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            ' 
            ' insertSectionBreakNextPageItem1
            ' 
            Me.insertSectionBreakNextPageItem1.Glyph = (CType(resources.GetObject("insertSectionBreakNextPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakNextPageItem1.Id = 149
            Me.insertSectionBreakNextPageItem1.LargeGlyph = (CType(resources.GetObject("insertSectionBreakNextPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            ' 
            ' insertSectionBreakEvenPageItem1
            ' 
            Me.insertSectionBreakEvenPageItem1.Glyph = (CType(resources.GetObject("insertSectionBreakEvenPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakEvenPageItem1.Id = 150
            Me.insertSectionBreakEvenPageItem1.LargeGlyph = (CType(resources.GetObject("insertSectionBreakEvenPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            ' 
            ' insertSectionBreakOddPageItem1
            ' 
            Me.insertSectionBreakOddPageItem1.Glyph = (CType(resources.GetObject("insertSectionBreakOddPageItem1.Glyph"), System.Drawing.Image))
            Me.insertSectionBreakOddPageItem1.Id = 151
            Me.insertSectionBreakOddPageItem1.LargeGlyph = (CType(resources.GetObject("insertSectionBreakOddPageItem1.LargeGlyph"), System.Drawing.Image))
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            ' 
            ' changeSectionLineNumberingItem1
            ' 
            Me.changeSectionLineNumberingItem1.Glyph = (CType(resources.GetObject("changeSectionLineNumberingItem1.Glyph"), System.Drawing.Image))
            Me.changeSectionLineNumberingItem1.Id = 152
            Me.changeSectionLineNumberingItem1.LargeGlyph = (CType(resources.GetObject("changeSectionLineNumberingItem1.LargeGlyph"), System.Drawing.Image))
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1)})
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            Me.changeSectionLineNumberingItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' setSectionLineNumberingNoneItem1
            ' 
            Me.setSectionLineNumberingNoneItem1.Id = 153
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            ' 
            ' setSectionLineNumberingContinuousItem1
            ' 
            Me.setSectionLineNumberingContinuousItem1.Id = 154
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            ' 
            ' setSectionLineNumberingRestartNewPageItem1
            ' 
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 155
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            ' 
            ' setSectionLineNumberingRestartNewSectionItem1
            ' 
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 156
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            ' 
            ' toggleParagraphSuppressLineNumbersItem1
            ' 
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 157
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            ' 
            ' showLineNumberingFormItem1
            ' 
            Me.showLineNumberingFormItem1.Id = 158
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(845, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 389)
            Me.barDockControlBottom.Size = New System.Drawing.Size(845, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 389)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(845, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 389)
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.goToPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.richEditBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
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
            Me.richEditBarController1.RichEditControl = Me.richEditControl
            ' 
            ' SectionsModule
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "SectionsModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private richEditControl As RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
        Private headerFooterBar1 As DevExpress.XtraRichEdit.UI.HeaderFooterBar
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
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
    End Class
End Namespace
