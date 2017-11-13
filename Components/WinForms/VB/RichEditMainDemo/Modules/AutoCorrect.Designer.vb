Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class AutoCorrectModule
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
            Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.edtReplaceAsYouType = New DevExpress.XtraEditors.CheckEdit()
            Me.edtCustomAutoCorrect = New DevExpress.XtraEditors.CheckEdit()
            Me.edtUseSpellCheckerSuggestions = New DevExpress.XtraEditors.CheckEdit()
            Me.edtCorrectTwoInitialCapitals = New DevExpress.XtraEditors.CheckEdit()
            Me.edtDetectUrls = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker()
            Me.standaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.zoomBar1 = New DevExpress.XtraRichEdit.UI.ZoomBar()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.commonBar2 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.linksBar1 = New DevExpress.XtraRichEdit.UI.LinksBar()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.FileInfoBar1 = New DevExpress.XtraRichEdit.UI.FileInfoBar()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.edtReplaceAsYouType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtCustomAutoCorrect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtUseSpellCheckerSuggestions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtCorrectTwoInitialCapitals.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtDetectUrls.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.edtReplaceAsYouType)
            Me.panelControl1.Controls.Add(Me.edtCustomAutoCorrect)
            Me.panelControl1.Controls.Add(Me.edtUseSpellCheckerSuggestions)
            Me.panelControl1.Controls.Add(Me.edtCorrectTwoInitialCapitals)
            Me.panelControl1.Controls.Add(Me.edtDetectUrls)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(691, 60)
            Me.panelControl1.TabIndex = 0
            '
            'edtReplaceAsYouType
            '
            Me.edtReplaceAsYouType.EditValue = True
            Me.edtReplaceAsYouType.Location = New System.Drawing.Point(5, 5)
            Me.edtReplaceAsYouType.MenuManager = Me
            Me.edtReplaceAsYouType.Name = "edtReplaceAsYouType"
            Me.edtReplaceAsYouType.Properties.AutoWidth = True
            Me.edtReplaceAsYouType.Properties.Caption = "Replace As You Type"
            Me.edtReplaceAsYouType.Size = New System.Drawing.Size(123, 19)
            Me.edtReplaceAsYouType.TabIndex = 17
            '
            'edtCustomAutoCorrect
            '
            Me.edtCustomAutoCorrect.EditValue = True
            Me.edtCustomAutoCorrect.Location = New System.Drawing.Point(341, 5)
            Me.edtCustomAutoCorrect.Name = "edtCustomAutoCorrect"
            Me.edtCustomAutoCorrect.Properties.AutoWidth = True
            Me.edtCustomAutoCorrect.Properties.Caption = "Custom AutoCorrect"
            Me.edtCustomAutoCorrect.Size = New System.Drawing.Size(120, 19)
            Me.edtCustomAutoCorrect.TabIndex = 15
            '
            'edtUseSpellCheckerSuggestions
            '
            Me.edtUseSpellCheckerSuggestions.EditValue = True
            Me.edtUseSpellCheckerSuggestions.Location = New System.Drawing.Point(146, 30)
            Me.edtUseSpellCheckerSuggestions.Name = "edtUseSpellCheckerSuggestions"
            Me.edtUseSpellCheckerSuggestions.Properties.AutoWidth = True
            Me.edtUseSpellCheckerSuggestions.Properties.Caption = "Use SpellChecker suggestions"
            Me.edtUseSpellCheckerSuggestions.Size = New System.Drawing.Size(164, 19)
            Me.edtUseSpellCheckerSuggestions.TabIndex = 15
            '
            'edtCorrectTwoInitialCapitals
            '
            Me.edtCorrectTwoInitialCapitals.EditValue = True
            Me.edtCorrectTwoInitialCapitals.Location = New System.Drawing.Point(146, 5)
            Me.edtCorrectTwoInitialCapitals.Name = "edtCorrectTwoInitialCapitals"
            Me.edtCorrectTwoInitialCapitals.Properties.AutoWidth = True
            Me.edtCorrectTwoInitialCapitals.Properties.Caption = "Correct TWo INitial CApitals"
            Me.edtCorrectTwoInitialCapitals.Size = New System.Drawing.Size(155, 19)
            Me.edtCorrectTwoInitialCapitals.TabIndex = 15
            '
            'edtDetectUrls
            '
            Me.edtDetectUrls.EditValue = True
            Me.edtDetectUrls.Location = New System.Drawing.Point(5, 30)
            Me.edtDetectUrls.MenuManager = Me
            Me.edtDetectUrls.Name = "edtDetectUrls"
            Me.edtDetectUrls.Properties.AutoWidth = True
            Me.edtDetectUrls.Properties.Caption = "Detect URLs"
            Me.edtDetectUrls.Size = New System.Drawing.Size(81, 19)
            Me.edtDetectUrls.TabIndex = 15
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.richEditControl)
            Me.panelControl2.Controls.Add(Me.standaloneBarDockControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 60)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(691, 369)
            Me.panelControl2.TabIndex = 1
            '
            'richEditControl
            '
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 28)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(687, 339)
            Me.richEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, OptionsSpelling1)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl1"
            '
            'spellChecker1
            '
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            '
            'standaloneBarDockControl2
            '
            Me.standaloneBarDockControl2.CausesValidation = False
            Me.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl2.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl2.Name = "standaloneBarDockControl2"
            Me.standaloneBarDockControl2.Size = New System.Drawing.Size(687, 26)
            Me.standaloneBarDockControl2.Text = "standaloneBarDockControl2"
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.clipboardBar1, Me.zoomBar1, Me.commonBar2, Me.linksBar1, Me.FileInfoBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl2)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.findItem1, Me.replaceItem1, Me.changeStyleItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.barManager1.MaxItemId = 35
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemRichEditStyleEdit1})
            '
            'clipboardBar1
            '
            Me.clipboardBar1.Control = Me.richEditControl
            Me.clipboardBar1.DockCol = 2
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(41, 296)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            Me.clipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'cutItem1
            '
            Me.cutItem1.Id = 0
            Me.cutItem1.Name = "cutItem1"
            '
            'copyItem1
            '
            Me.copyItem1.Id = 1
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Id = 2
            Me.pasteItem1.Name = "pasteItem1"
            '
            'zoomBar1
            '
            Me.zoomBar1.Control = Me.richEditControl
            Me.zoomBar1.DockCol = 3
            Me.zoomBar1.DockRow = 0
            Me.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.zoomBar1.FloatLocation = New System.Drawing.Point(147, 240)
            Me.zoomBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.zoomOutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomInItem1)})
            Me.zoomBar1.Offset = 332
            Me.zoomBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'zoomOutItem1
            '
            Me.zoomOutItem1.Id = 9
            Me.zoomOutItem1.Name = "zoomOutItem1"
            '
            'zoomInItem1
            '
            Me.zoomInItem1.Id = 10
            Me.zoomInItem1.Name = "zoomInItem1"
            '
            'commonBar2
            '
            Me.commonBar2.Control = Me.richEditControl
            Me.commonBar2.DockCol = 0
            Me.commonBar2.DockRow = 0
            Me.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar2.FloatLocation = New System.Drawing.Point(46, 275)
            Me.commonBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar2.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 3
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 4
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 5
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 6
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 11
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 12
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 13
            Me.printPreviewItem1.Name = "printPreviewItem1"
            '
            'undoItem1
            '
            Me.undoItem1.Id = 7
            Me.undoItem1.Name = "undoItem1"
            '
            'redoItem1
            '
            Me.redoItem1.Id = 8
            Me.redoItem1.Name = "redoItem1"
            '
            'linksBar1
            '
            Me.linksBar1.Control = Me.richEditControl
            Me.linksBar1.DockCol = 4
            Me.linksBar1.DockRow = 0
            Me.linksBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.linksBar1.FloatLocation = New System.Drawing.Point(675, 448)
            Me.linksBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertBookmarkItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertHyperlinkItem1)})
            Me.linksBar1.Offset = 399
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
            'FileInfoBar1
            '
            Me.FileInfoBar1.Control = Me.richEditControl
            Me.FileInfoBar1.DockCol = 1
            Me.FileInfoBar1.DockRow = 0
            Me.FileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.FileInfoBar1.FloatLocation = New System.Drawing.Point(466, 202)
            Me.FileInfoBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ShowDocumentPropertiesFormItem1)})
            Me.FileInfoBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 34
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(691, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 429)
            Me.barDockControlBottom.Size = New System.Drawing.Size(691, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 429)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(691, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 429)
            '
            'findItem1
            '
            Me.findItem1.Id = 14
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Id = 15
            Me.replaceItem1.Name = "replaceItem1"
            '
            'changeStyleItem1
            '
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 16
            Me.changeStyleItem1.Name = "changeStyleItem1"
            '
            'repositoryItemRichEditStyleEdit1
            '
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            '
            'switchToSimpleViewItem1
            '
            Me.switchToSimpleViewItem1.Id = 23
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            '
            'switchToDraftViewItem1
            '
            Me.switchToDraftViewItem1.Id = 24
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            '
            'switchToPrintLayoutViewItem1
            '
            Me.switchToPrintLayoutViewItem1.Id = 25
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.richEditBarController1.BarItems.Add(Me.printItem1)
            Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.richEditBarController1.BarItems.Add(Me.undoItem1)
            Me.richEditBarController1.BarItems.Add(Me.redoItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'AutoCorrectModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "AutoCorrectModule"
            Me.Size = New System.Drawing.Size(691, 429)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.edtReplaceAsYouType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtCustomAutoCorrect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtUseSpellCheckerSuggestions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtCorrectTwoInitialCapitals.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtDetectUrls.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents richEditControl As RichEditControl
        Private standaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private zoomBar1 As DevExpress.XtraRichEdit.UI.ZoomBar
        Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
        Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private commonBar2 As DevExpress.XtraRichEdit.UI.CommonBar
        Private WithEvents edtDetectUrls As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtReplaceAsYouType As DevExpress.XtraEditors.CheckEdit
        Private linksBar1 As DevExpress.XtraRichEdit.UI.LinksBar
        Private WithEvents edtCustomAutoCorrect As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtCorrectTwoInitialCapitals As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtUseSpellCheckerSuggestions As DevExpress.XtraEditors.CheckEdit
        Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Private WithEvents FileInfoBar1 As DevExpress.XtraRichEdit.UI.FileInfoBar
	End Class
End Namespace
