Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ParagraphFormattingModule
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParagraphFormattingModule))
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem
            Me.illustrationsBar1 = New DevExpress.XtraRichEdit.UI.IllustrationsBar
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
            Me.textBar1 = New DevExpress.XtraRichEdit.UI.TextBar
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem
            Me.symbolsBar1 = New DevExpress.XtraRichEdit.UI.SymbolsBar
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController
            Me.ClipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar
            Me.PasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem
            Me.CutItem1 = New DevExpress.XtraRichEdit.UI.CutItem
            Me.CopyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem
            Me.PasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem
            Me.ParagraphBar1 = New DevExpress.XtraRichEdit.UI.ParagraphBar
            Me.ToggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
            Me.ToggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
            Me.ToggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
            Me.DecreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem
            Me.IncreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem
            Me.ToggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
            Me.ToggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
            Me.ToggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
            Me.ToggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
            Me.ToggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
            Me.ChangeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
            Me.SetSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
            Me.SetSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
            Me.SetDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
            Me.ShowLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
            Me.AddSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
            Me.RemoveSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
            Me.AddSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
            Me.RemoveSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
            Me.ChangeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
            Me.ShowParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richEditControl
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
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.standaloneBarDockControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(845, 389)
            Me.panelControl1.TabIndex = 4
            '
            'standaloneBarDockControl1
            '
            Me.standaloneBarDockControl1.AutoSize = True
            Me.standaloneBarDockControl1.CausesValidation = False
            Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            Me.standaloneBarDockControl1.Size = New System.Drawing.Size(841, 31)
            Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.commonBar1, Me.illustrationsBar1, Me.textBar1, Me.symbolsBar1, Me.ClipboardBar1, Me.ParagraphBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.undoItem1, Me.redoItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.PasteItem1, Me.CutItem1, Me.CopyItem1, Me.PasteSpecialItem1, Me.ToggleBulletedListItem1, Me.ToggleNumberingListItem1, Me.ToggleMultiLevelListItem1, Me.DecreaseIndentItem1, Me.IncreaseIndentItem1, Me.ToggleParagraphAlignmentLeftItem1, Me.ToggleParagraphAlignmentCenterItem1, Me.ToggleParagraphAlignmentRightItem1, Me.ToggleParagraphAlignmentJustifyItem1, Me.ToggleShowWhitespaceItem1, Me.ChangeParagraphLineSpacingItem1, Me.SetSingleParagraphSpacingItem1, Me.SetSesquialteralParagraphSpacingItem1, Me.SetDoubleParagraphSpacingItem1, Me.ShowLineSpacingFormItem1, Me.AddSpacingBeforeParagraphItem1, Me.RemoveSpacingBeforeParagraphItem1, Me.AddSpacingAfterParagraphItem1, Me.RemoveSpacingAfterParagraphItem1, Me.ChangeParagraphBackColorItem1, Me.ShowParagraphFormItem1})
            Me.barManager1.MaxItemId = 76
            '
            'commonBar1
            '
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
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
            'illustrationsBar1
            '
            Me.illustrationsBar1.DockCol = 3
            Me.illustrationsBar1.DockRow = 0
            Me.illustrationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.illustrationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPictureItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertFloatingPictureItem1)})
            Me.illustrationsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Glyph = CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image)
            Me.insertPictureItem1.Id = 23
            Me.insertPictureItem1.LargeGlyph = CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Glyph = CType(resources.GetObject("insertFloatingPictureItem1.Glyph"), System.Drawing.Image)
            Me.insertFloatingPictureItem1.Id = 26
            Me.insertFloatingPictureItem1.LargeGlyph = CType(resources.GetObject("insertFloatingPictureItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'textBar1
            '
            Me.textBar1.DockCol = 5
            Me.textBar1.DockRow = 0
            Me.textBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.textBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTextBoxItem1)})
            Me.textBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Glyph = CType(resources.GetObject("insertTextBoxItem1.Glyph"), System.Drawing.Image)
            Me.insertTextBoxItem1.Id = 27
            Me.insertTextBoxItem1.LargeGlyph = CType(resources.GetObject("insertTextBoxItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'symbolsBar1
            '
            Me.symbolsBar1.DockCol = 4
            Me.symbolsBar1.DockRow = 0
            Me.symbolsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.symbolsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertSymbolItem1)})
            Me.symbolsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Glyph = CType(resources.GetObject("insertSymbolItem1.Glyph"), System.Drawing.Image)
            Me.insertSymbolItem1.Id = 24
            Me.insertSymbolItem1.LargeGlyph = CType(resources.GetObject("insertSymbolItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(845, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 389)
            Me.barDockControlBottom.Size = New System.Drawing.Size(845, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 389)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(845, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 389)
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.PasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.CutItem1)
            Me.richEditBarController1.BarItems.Add(Me.CopyItem1)
            Me.richEditBarController1.BarItems.Add(Me.PasteSpecialItem1)
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
            Me.richEditBarController1.RichEditControl = Me.richEditControl
            '
            'ClipboardBar1
            '
            Me.ClipboardBar1.DockCol = 1
            Me.ClipboardBar1.DockRow = 0
            Me.ClipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.ClipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PasteItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CopyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PasteSpecialItem1)})
            Me.ClipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'PasteItem1
            '
            Me.PasteItem1.Glyph = CType(resources.GetObject("PasteItem1.Glyph"), System.Drawing.Image)
            Me.PasteItem1.Id = 28
            Me.PasteItem1.LargeGlyph = CType(resources.GetObject("PasteItem1.LargeGlyph"), System.Drawing.Image)
            Me.PasteItem1.Name = "PasteItem1"
            '
            'CutItem1
            '
            Me.CutItem1.Glyph = CType(resources.GetObject("CutItem1.Glyph"), System.Drawing.Image)
            Me.CutItem1.Id = 29
            Me.CutItem1.LargeGlyph = CType(resources.GetObject("CutItem1.LargeGlyph"), System.Drawing.Image)
            Me.CutItem1.Name = "CutItem1"
            '
            'CopyItem1
            '
            Me.CopyItem1.Glyph = CType(resources.GetObject("CopyItem1.Glyph"), System.Drawing.Image)
            Me.CopyItem1.Id = 30
            Me.CopyItem1.LargeGlyph = CType(resources.GetObject("CopyItem1.LargeGlyph"), System.Drawing.Image)
            Me.CopyItem1.Name = "CopyItem1"
            '
            'PasteSpecialItem1
            '
            Me.PasteSpecialItem1.Glyph = CType(resources.GetObject("PasteSpecialItem1.Glyph"), System.Drawing.Image)
            Me.PasteSpecialItem1.Id = 31
            Me.PasteSpecialItem1.LargeGlyph = CType(resources.GetObject("PasteSpecialItem1.LargeGlyph"), System.Drawing.Image)
            Me.PasteSpecialItem1.Name = "PasteSpecialItem1"
            '
            'ParagraphBar1
            '
            Me.ParagraphBar1.DockCol = 2
            Me.ParagraphBar1.DockRow = 0
            Me.ParagraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.ParagraphBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleBulletedListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleNumberingListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleMultiLevelListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DecreaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.IncreaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphAlignmentLeftItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphAlignmentCenterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphAlignmentRightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleParagraphAlignmentJustifyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ToggleShowWhitespaceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ChangeParagraphLineSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ChangeParagraphBackColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowParagraphFormItem1)})
            Me.ParagraphBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'ToggleBulletedListItem1
            '
            Me.ToggleBulletedListItem1.Glyph = CType(resources.GetObject("ToggleBulletedListItem1.Glyph"), System.Drawing.Image)
            Me.ToggleBulletedListItem1.Id = 32
            Me.ToggleBulletedListItem1.LargeGlyph = CType(resources.GetObject("ToggleBulletedListItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleBulletedListItem1.Name = "ToggleBulletedListItem1"
            '
            'ToggleNumberingListItem1
            '
            Me.ToggleNumberingListItem1.Glyph = CType(resources.GetObject("ToggleNumberingListItem1.Glyph"), System.Drawing.Image)
            Me.ToggleNumberingListItem1.Id = 33
            Me.ToggleNumberingListItem1.LargeGlyph = CType(resources.GetObject("ToggleNumberingListItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleNumberingListItem1.Name = "ToggleNumberingListItem1"
            '
            'ToggleMultiLevelListItem1
            '
            Me.ToggleMultiLevelListItem1.Glyph = CType(resources.GetObject("ToggleMultiLevelListItem1.Glyph"), System.Drawing.Image)
            Me.ToggleMultiLevelListItem1.Id = 34
            Me.ToggleMultiLevelListItem1.LargeGlyph = CType(resources.GetObject("ToggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleMultiLevelListItem1.Name = "ToggleMultiLevelListItem1"
            '
            'DecreaseIndentItem1
            '
            Me.DecreaseIndentItem1.Glyph = CType(resources.GetObject("DecreaseIndentItem1.Glyph"), System.Drawing.Image)
            Me.DecreaseIndentItem1.Id = 35
            Me.DecreaseIndentItem1.LargeGlyph = CType(resources.GetObject("DecreaseIndentItem1.LargeGlyph"), System.Drawing.Image)
            Me.DecreaseIndentItem1.Name = "DecreaseIndentItem1"
            '
            'IncreaseIndentItem1
            '
            Me.IncreaseIndentItem1.Glyph = CType(resources.GetObject("IncreaseIndentItem1.Glyph"), System.Drawing.Image)
            Me.IncreaseIndentItem1.Id = 36
            Me.IncreaseIndentItem1.LargeGlyph = CType(resources.GetObject("IncreaseIndentItem1.LargeGlyph"), System.Drawing.Image)
            Me.IncreaseIndentItem1.Name = "IncreaseIndentItem1"
            '
            'ToggleParagraphAlignmentLeftItem1
            '
            Me.ToggleParagraphAlignmentLeftItem1.Glyph = CType(resources.GetObject("ToggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentLeftItem1.Id = 37
            Me.ToggleParagraphAlignmentLeftItem1.LargeGlyph = CType(resources.GetObject("ToggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentLeftItem1.Name = "ToggleParagraphAlignmentLeftItem1"
            '
            'ToggleParagraphAlignmentCenterItem1
            '
            Me.ToggleParagraphAlignmentCenterItem1.Glyph = CType(resources.GetObject("ToggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentCenterItem1.Id = 38
            Me.ToggleParagraphAlignmentCenterItem1.LargeGlyph = CType(resources.GetObject("ToggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentCenterItem1.Name = "ToggleParagraphAlignmentCenterItem1"
            '
            'ToggleParagraphAlignmentRightItem1
            '
            Me.ToggleParagraphAlignmentRightItem1.Glyph = CType(resources.GetObject("ToggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentRightItem1.Id = 39
            Me.ToggleParagraphAlignmentRightItem1.LargeGlyph = CType(resources.GetObject("ToggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentRightItem1.Name = "ToggleParagraphAlignmentRightItem1"
            '
            'ToggleParagraphAlignmentJustifyItem1
            '
            Me.ToggleParagraphAlignmentJustifyItem1.Glyph = CType(resources.GetObject("ToggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentJustifyItem1.Id = 40
            Me.ToggleParagraphAlignmentJustifyItem1.LargeGlyph = CType(resources.GetObject("ToggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleParagraphAlignmentJustifyItem1.Name = "ToggleParagraphAlignmentJustifyItem1"
            '
            'ToggleShowWhitespaceItem1
            '
            Me.ToggleShowWhitespaceItem1.Glyph = CType(resources.GetObject("ToggleShowWhitespaceItem1.Glyph"), System.Drawing.Image)
            Me.ToggleShowWhitespaceItem1.Id = 41
            Me.ToggleShowWhitespaceItem1.LargeGlyph = CType(resources.GetObject("ToggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image)
            Me.ToggleShowWhitespaceItem1.Name = "ToggleShowWhitespaceItem1"
            '
            'ChangeParagraphLineSpacingItem1
            '
            Me.ChangeParagraphLineSpacingItem1.Glyph = CType(resources.GetObject("ChangeParagraphLineSpacingItem1.Glyph"), System.Drawing.Image)
            Me.ChangeParagraphLineSpacingItem1.Id = 42
            Me.ChangeParagraphLineSpacingItem1.LargeGlyph = CType(resources.GetObject("ChangeParagraphLineSpacingItem1.LargeGlyph"), System.Drawing.Image)
            Me.ChangeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SetSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SetDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ShowLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.AddSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.RemoveSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.AddSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.RemoveSpacingAfterParagraphItem1)})
            Me.ChangeParagraphLineSpacingItem1.Name = "ChangeParagraphLineSpacingItem1"
            Me.ChangeParagraphLineSpacingItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            '
            'SetSingleParagraphSpacingItem1
            '
            Me.SetSingleParagraphSpacingItem1.Id = 43
            Me.SetSingleParagraphSpacingItem1.Name = "SetSingleParagraphSpacingItem1"
            '
            'SetSesquialteralParagraphSpacingItem1
            '
            Me.SetSesquialteralParagraphSpacingItem1.Id = 44
            Me.SetSesquialteralParagraphSpacingItem1.Name = "SetSesquialteralParagraphSpacingItem1"
            '
            'SetDoubleParagraphSpacingItem1
            '
            Me.SetDoubleParagraphSpacingItem1.Id = 45
            Me.SetDoubleParagraphSpacingItem1.Name = "SetDoubleParagraphSpacingItem1"
            '
            'ShowLineSpacingFormItem1
            '
            Me.ShowLineSpacingFormItem1.Id = 46
            Me.ShowLineSpacingFormItem1.Name = "ShowLineSpacingFormItem1"
            '
            'AddSpacingBeforeParagraphItem1
            '
            Me.AddSpacingBeforeParagraphItem1.Id = 47
            Me.AddSpacingBeforeParagraphItem1.Name = "AddSpacingBeforeParagraphItem1"
            '
            'RemoveSpacingBeforeParagraphItem1
            '
            Me.RemoveSpacingBeforeParagraphItem1.Id = 48
            Me.RemoveSpacingBeforeParagraphItem1.Name = "RemoveSpacingBeforeParagraphItem1"
            '
            'AddSpacingAfterParagraphItem1
            '
            Me.AddSpacingAfterParagraphItem1.Id = 49
            Me.AddSpacingAfterParagraphItem1.Name = "AddSpacingAfterParagraphItem1"
            '
            'RemoveSpacingAfterParagraphItem1
            '
            Me.RemoveSpacingAfterParagraphItem1.Id = 50
            Me.RemoveSpacingAfterParagraphItem1.Name = "RemoveSpacingAfterParagraphItem1"
            '
            'ChangeParagraphBackColorItem1
            '
            Me.ChangeParagraphBackColorItem1.Glyph = CType(resources.GetObject("ChangeParagraphBackColorItem1.Glyph"), System.Drawing.Image)
            Me.ChangeParagraphBackColorItem1.Id = 51
            Me.ChangeParagraphBackColorItem1.LargeGlyph = CType(resources.GetObject("ChangeParagraphBackColorItem1.LargeGlyph"), System.Drawing.Image)
            Me.ChangeParagraphBackColorItem1.Name = "ChangeParagraphBackColorItem1"
            '
            'ShowParagraphFormItem1
            '
            Me.ShowParagraphFormItem1.Glyph = CType(resources.GetObject("ShowParagraphFormItem1.Glyph"), System.Drawing.Image)
            Me.ShowParagraphFormItem1.Id = 52
            Me.ShowParagraphFormItem1.LargeGlyph = CType(resources.GetObject("ShowParagraphFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.ShowParagraphFormItem1.Name = "ShowParagraphFormItem1"
            '
            'ParagraphFormattingModule
            '
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ParagraphFormattingModule"
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
        Private illustrationsBar1 As DevExpress.XtraRichEdit.UI.IllustrationsBar
        Private textBar1 As DevExpress.XtraRichEdit.UI.TextBar
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
        Private symbolsBar1 As DevExpress.XtraRichEdit.UI.SymbolsBar
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Friend WithEvents ClipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
        Friend WithEvents PasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Friend WithEvents CutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Friend WithEvents CopyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Friend WithEvents PasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Friend WithEvents ParagraphBar1 As DevExpress.XtraRichEdit.UI.ParagraphBar
        Friend WithEvents ToggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Friend WithEvents ToggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Friend WithEvents ToggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Friend WithEvents DecreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Friend WithEvents IncreaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Friend WithEvents ToggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Friend WithEvents ToggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Friend WithEvents ToggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Friend WithEvents ToggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Friend WithEvents ToggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
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
        Friend WithEvents ShowParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
    End Class
End Namespace
