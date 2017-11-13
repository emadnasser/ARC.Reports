Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class CharacterFormattingModule
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterFormattingModule))
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem
            Me.fontBar1 = New DevExpress.XtraRichEdit.UI.FontBar
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
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem
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
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.commonBar1, Me.clipboardBar1, Me.fontBar1, Me.illustrationsBar1, Me.textBar1, Me.symbolsBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.showFontFormItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.clearFormattingItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1})
            Me.barManager1.MaxItemId = 32
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1})
            '
            'commonBar1
            '
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar1.FloatLocation = New System.Drawing.Point(275, 174)
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
            'clipboardBar1
            '
            Me.clipboardBar1.DockCol = 1
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(375, 175)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            Me.clipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
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
            'fontBar1
            '
            Me.fontBar1.DockCol = 2
            Me.fontBar1.DockRow = 0
            Me.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.fontBar1.FloatLocation = New System.Drawing.Point(484, 178)
            Me.fontBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontNameItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontSizeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontBackColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontBoldItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontItalicItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.clearFormattingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSuperscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSubscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeIncreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeDecreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showFontFormItem1)})
            Me.fontBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'changeFontNameItem1
            '
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 12
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            Me.changeFontNameItem1.Width = 100
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
            'clearFormattingItem1
            '
            Me.clearFormattingItem1.Glyph = CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image)
            Me.clearFormattingItem1.Id = 29
            Me.clearFormattingItem1.LargeGlyph = CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image)
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
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
            'showFontFormItem1
            '
            Me.showFontFormItem1.Glyph = CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image)
            Me.showFontFormItem1.Id = 26
            Me.showFontFormItem1.LargeGlyph = CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image)
            Me.showFontFormItem1.Name = "showFontFormItem1"
            '
            'illustrationsBar1
            '
            Me.illustrationsBar1.DockCol = 3
            Me.illustrationsBar1.DockRow = 0
            Me.illustrationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.illustrationsBar1.FloatLocation = New System.Drawing.Point(981, 152)
            Me.illustrationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertPictureItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertFloatingPictureItem1)})
            Me.illustrationsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Glyph = CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image)
            Me.insertPictureItem1.Id = 27
            Me.insertPictureItem1.LargeGlyph = CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Glyph = CType(resources.GetObject("insertFloatingPictureItem1.Glyph"), System.Drawing.Image)
            Me.insertFloatingPictureItem1.Id = 30
            Me.insertFloatingPictureItem1.LargeGlyph = CType(resources.GetObject("insertFloatingPictureItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'textBar1
            '
            Me.textBar1.DockCol = 5
            Me.textBar1.DockRow = 0
            Me.textBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.textBar1.FloatLocation = New System.Drawing.Point(981, 152)
            Me.textBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertTextBoxItem1)})
            Me.textBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Glyph = CType(resources.GetObject("insertTextBoxItem1.Glyph"), System.Drawing.Image)
            Me.insertTextBoxItem1.Id = 31
            Me.insertTextBoxItem1.LargeGlyph = CType(resources.GetObject("insertTextBoxItem1.LargeGlyph"), System.Drawing.Image)
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'symbolsBar1
            '
            Me.symbolsBar1.DockCol = 4
            Me.symbolsBar1.DockRow = 0
            Me.symbolsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.symbolsBar1.FloatLocation = New System.Drawing.Point(-795, 151)
            Me.symbolsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertSymbolItem1)})
            Me.symbolsBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
            '
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Glyph = CType(resources.GetObject("insertSymbolItem1.Glyph"), System.Drawing.Image)
            Me.insertSymbolItem1.Id = 28
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
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.RichEditControl = Me.richEditControl
            '
            'CharacterFormattingModule
            '
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "CharacterFormattingModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private fontBar1 As DevExpress.XtraRichEdit.UI.FontBar
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
		Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private illustrationsBar1 As DevExpress.XtraRichEdit.UI.IllustrationsBar
        Private textBar1 As DevExpress.XtraRichEdit.UI.TextBar
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
        Private symbolsBar1 As DevExpress.XtraRichEdit.UI.SymbolsBar
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
	End Class
End Namespace
