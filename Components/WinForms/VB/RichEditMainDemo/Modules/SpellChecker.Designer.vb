Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class SpellCheckerModule
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
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SpellCheckerModule))
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bottomDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.checkSpellingItem = New DevExpress.XtraBars.BarButtonItem()
			Me.topDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
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
			Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl
			' 
			Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl.Location = New System.Drawing.Point(2, 29)
			Me.richEditControl.MenuManager = Me
			Me.richEditControl.Name = "richEditControl"
			Me.spellChecker1.SetShowSpellCheckMenu(Me.richEditControl, False)
			Me.richEditControl.Size = New System.Drawing.Size(841, 295)
			Me.richEditControl.SpellChecker = Me.spellChecker1
			Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, optionsSpelling1)
			Me.richEditControl.TabIndex = 1
			Me.richEditControl.Text = "richEditControl"
'			Me.richEditControl.ReadOnlyChanged += New System.EventHandler(Me.richEditControl_ReadOnlyChanged);
			' 
			' spellChecker1
			' 
			Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spellChecker1.ParentContainer = Nothing
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.commonBar1, Me.clipboardBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockControls.Add(Me.topDockArea)
			Me.barManager1.DockControls.Add(Me.bottomDockArea)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.checkSpellingItem, Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1})
			Me.barManager1.MaxItemId = 31
			' 
			' bottomDockArea
			' 
			Me.bottomDockArea.AutoSize = True
			Me.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.bottomDockArea.Location = New System.Drawing.Point(2, 324)
			Me.bottomDockArea.Name = "bottomDockArea"
			Me.bottomDockArea.Size = New System.Drawing.Size(841, 25)
			Me.bottomDockArea.Text = "standaloneBarDockControl2"
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 5"
			Me.bar1.DockCol = 2
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.checkSpellingItem)})
			Me.bar1.StandaloneBarDockControl = Me.topDockArea
			Me.bar1.Text = "Check spelling"
			' 
			' checkSpellingItem
			' 
			Me.checkSpellingItem.Caption = "Spelling"
			Me.checkSpellingItem.Glyph = (CType(resources.GetObject("checkSpellingItem.Glyph"), System.Drawing.Image))
			Me.checkSpellingItem.Id = 18
			Me.checkSpellingItem.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
			Me.checkSpellingItem.LargeGlyph = (CType(resources.GetObject("checkSpellingItem.LargeGlyph"), System.Drawing.Image))
			Me.checkSpellingItem.Name = "checkSpellingItem"
			toolTipTitleItem1.Text = "Spelling (F7)"
			toolTipItem1.LeftIndent = 6
			toolTipItem1.Text = "Check the spelling of text in the document."
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			Me.checkSpellingItem.SuperTip = superToolTip1
'			Me.checkSpellingItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.checkSpellingItem_ItemClick);
			' 
			' topDockArea
			' 
			Me.topDockArea.AutoSize = True
			Me.topDockArea.Dock = System.Windows.Forms.DockStyle.Top
			Me.topDockArea.Location = New System.Drawing.Point(2, 2)
			Me.topDockArea.Name = "topDockArea"
			Me.topDockArea.Size = New System.Drawing.Size(841, 27)
			Me.topDockArea.Text = "standaloneBarDockControl1"
			' 
			' commonBar1
			' 
			Me.commonBar1.DockCol = 0
			Me.commonBar1.DockRow = 0
			Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.commonBar1.FloatLocation = New System.Drawing.Point(315, 184)
			Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
			Me.commonBar1.StandaloneBarDockControl = Me.topDockArea
			' 
			' undoItem1
			' 
			Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
			Me.undoItem1.Id = 26
			Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
			Me.redoItem1.Id = 27
			Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
			Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
			Me.redoItem1.Name = "redoItem1"
			' 
			' clipboardBar1
			' 
			Me.clipboardBar1.DockCol = 1
			Me.clipboardBar1.DockRow = 0
			Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.clipboardBar1.FloatLocation = New System.Drawing.Point(388, 178)
			Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
			Me.clipboardBar1.StandaloneBarDockControl = Me.topDockArea
			' 
			' cutItem1
			' 
			Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
			Me.cutItem1.Id = 28
			Me.cutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
			Me.copyItem1.Id = 29
			Me.copyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
			Me.pasteItem1.Id = 30
			Me.pasteItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.richEditControl)
			Me.panelControl1.Controls.Add(Me.bottomDockArea)
			Me.panelControl1.Controls.Add(Me.topDockArea)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 38)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(845, 351)
			Me.panelControl1.TabIndex = 4
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.checkEdit1)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(845, 38)
			Me.panelControl2.TabIndex = 6
			' 
			' checkEdit1
			' 
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(5, 11)
			Me.checkEdit1.MenuManager = Me
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.AutoWidth = True
			Me.checkEdit1.Properties.Caption = "Check spelling as you type"
			Me.checkEdit1.Size = New System.Drawing.Size(150, 19)
			Me.checkEdit1.TabIndex = 1
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.cutItem1)
			Me.richEditBarController1.BarItems.Add(Me.copyItem1)
			Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl
			' 
			' SpellCheckerModule
			' 
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "SpellCheckerModule"
			Me.Size = New System.Drawing.Size(845, 389)
'			Me.Load += New System.EventHandler(Me.SpellCheckerModule_Load);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl As RichEditControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents checkSpellingItem As DevExpress.XtraBars.BarButtonItem
		Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
		Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage
		Private topDockArea As DevExpress.XtraBars.StandaloneBarDockControl
		Private bottomDockArea As DevExpress.XtraBars.StandaloneBarDockControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
	End Class
End Namespace
