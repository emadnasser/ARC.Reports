Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class HyperlinksModule
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
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.commonBar2 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.topDockControl = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.linksBar1 = New DevExpress.XtraRichEdit.UI.LinksBar()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.FileInfoBar1 = New DevExpress.XtraRichEdit.UI.FileInfoBar()
            Me.ShowDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.chkShift = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAlt = New DevExpress.XtraEditors.CheckEdit()
            Me.chkCtrl = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.chkShowToolTip = New DevExpress.XtraEditors.CheckEdit()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.chkShowBookmarks = New DevExpress.XtraEditors.CheckEdit()
            Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.chkShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAlt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkCtrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowToolTip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.chkShowBookmarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.commonBar2, Me.clipboardBar1, Me.linksBar1, Me.FileInfoBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.topDockControl)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.insertPageBreakItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.findItem1, Me.replaceItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.barManager1.MaxItemId = 18
            '
            'commonBar2
            '
            Me.commonBar2.Control = Me.richEditControl
            Me.commonBar2.DockCol = 0
            Me.commonBar2.DockRow = 0
            Me.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.commonBar2.FloatLocation = New System.Drawing.Point(0, 189)
            Me.commonBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar2.StandaloneBarDockControl = Me.topDockControl
            '
            'richEditControl
            '
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 33)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(841, 260)
            Me.richEditControl.TabIndex = 6
            Me.richEditControl.Text = "richEditControl1"
            '
            'fileNewItem1
            '
            Me.fileNewItem1.Id = 0
            Me.fileNewItem1.Name = "fileNewItem1"
            '
            'fileOpenItem1
            '
            Me.fileOpenItem1.Id = 1
            Me.fileOpenItem1.Name = "fileOpenItem1"
            '
            'fileSaveItem1
            '
            Me.fileSaveItem1.Id = 2
            Me.fileSaveItem1.Name = "fileSaveItem1"
            '
            'fileSaveAsItem1
            '
            Me.fileSaveAsItem1.Id = 3
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            '
            'quickPrintItem1
            '
            Me.quickPrintItem1.Id = 4
            Me.quickPrintItem1.Name = "quickPrintItem1"
            '
            'printItem1
            '
            Me.printItem1.Id = 5
            Me.printItem1.Name = "printItem1"
            '
            'printPreviewItem1
            '
            Me.printPreviewItem1.Id = 6
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
            'topDockControl
            '
            Me.topDockControl.AutoSize = True
            Me.topDockControl.CausesValidation = False
            Me.topDockControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.topDockControl.Location = New System.Drawing.Point(2, 2)
            Me.topDockControl.Name = "topDockControl"
            Me.topDockControl.Size = New System.Drawing.Size(841, 31)
            Me.topDockControl.Text = "standaloneBarDockControl1"
            '
            'clipboardBar1
            '
            Me.clipboardBar1.Control = Me.richEditControl
            Me.clipboardBar1.DockCol = 2
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.clipboardBar1.FloatLocation = New System.Drawing.Point(303, 191)
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
            Me.clipboardBar1.Offset = 233
            Me.clipboardBar1.StandaloneBarDockControl = Me.topDockControl
            '
            'cutItem1
            '
            Me.cutItem1.Id = 10
            Me.cutItem1.Name = "cutItem1"
            '
            'copyItem1
            '
            Me.copyItem1.Id = 11
            Me.copyItem1.Name = "copyItem1"
            '
            'pasteItem1
            '
            Me.pasteItem1.Id = 12
            Me.pasteItem1.Name = "pasteItem1"
            '
            'linksBar1
            '
            Me.linksBar1.Control = Me.richEditControl
            Me.linksBar1.DockCol = 3
            Me.linksBar1.DockRow = 0
            Me.linksBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.linksBar1.FloatLocation = New System.Drawing.Point(443, 191)
            Me.linksBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.insertBookmarkItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertHyperlinkItem1)})
            Me.linksBar1.StandaloneBarDockControl = Me.topDockControl
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Id = 15
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Id = 16
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'FileInfoBar1
            '
            Me.FileInfoBar1.Control = Me.richEditControl
            Me.FileInfoBar1.DockCol = 1
            Me.FileInfoBar1.DockRow = 0
            Me.FileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.FileInfoBar1.FloatLocation = New System.Drawing.Point(329, 245)
            Me.FileInfoBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ShowDocumentPropertiesFormItem1)})
            Me.FileInfoBar1.StandaloneBarDockControl = Me.topDockControl
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 17
            Me.ShowDocumentPropertiesFormItem1.Name = "ShowDocumentPropertiesFormItem1"
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
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Id = 9
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            '
            'findItem1
            '
            Me.findItem1.Id = 13
            Me.findItem1.Name = "findItem1"
            '
            'replaceItem1
            '
            Me.replaceItem1.Id = 14
            Me.replaceItem1.Name = "replaceItem1"
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
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
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.topDockControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 94)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(845, 295)
            Me.panelControl1.TabIndex = 5
            '
            'commonBar1
            '
            Me.commonBar1.BarName = ""
            Me.commonBar1.Control = Nothing
            Me.commonBar1.DockCol = 0
            Me.commonBar1.DockRow = 0
            Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
            Me.commonBar1.Text = ""
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.groupControl2)
            Me.panelControl2.Controls.Add(Me.groupControl1)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(845, 94)
            Me.panelControl2.TabIndex = 5
            '
            'groupControl2
            '
            Me.groupControl2.Controls.Add(Me.chkShift)
            Me.groupControl2.Controls.Add(Me.chkAlt)
            Me.groupControl2.Controls.Add(Me.chkCtrl)
            Me.groupControl2.Controls.Add(Me.labelControl2)
            Me.groupControl2.Controls.Add(Me.chkShowToolTip)
            Me.groupControl2.Location = New System.Drawing.Point(261, 5)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(250, 76)
            Me.groupControl2.TabIndex = 4
            Me.groupControl2.Text = "Hyperlinks"
            '
            'chkShift
            '
            Me.chkShift.Location = New System.Drawing.Point(179, 48)
            Me.chkShift.MenuManager = Me
            Me.chkShift.Name = "chkShift"
            Me.chkShift.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.chkShift.Properties.Appearance.Options.UseBackColor = True
            Me.chkShift.Properties.Caption = "Shift"
            Me.chkShift.Size = New System.Drawing.Size(45, 19)
            Me.chkShift.TabIndex = 6
            '
            'chkAlt
            '
            Me.chkAlt.Location = New System.Drawing.Point(128, 48)
            Me.chkAlt.MenuManager = Me
            Me.chkAlt.Name = "chkAlt"
            Me.chkAlt.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.chkAlt.Properties.Appearance.Options.UseBackColor = True
            Me.chkAlt.Properties.Caption = "Alt"
            Me.chkAlt.Size = New System.Drawing.Size(45, 19)
            Me.chkAlt.TabIndex = 5
            '
            'chkCtrl
            '
            Me.chkCtrl.EditValue = True
            Me.chkCtrl.Location = New System.Drawing.Point(80, 48)
            Me.chkCtrl.MenuManager = Me
            Me.chkCtrl.Name = "chkCtrl"
            Me.chkCtrl.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.chkCtrl.Properties.Appearance.Options.UseBackColor = True
            Me.chkCtrl.Properties.Caption = "Ctrl"
            Me.chkCtrl.Size = New System.Drawing.Size(45, 19)
            Me.chkCtrl.TabIndex = 4
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(7, 50)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(67, 13)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "Modifier keys:"
            '
            'chkShowToolTip
            '
            Me.chkShowToolTip.EditValue = True
            Me.chkShowToolTip.Location = New System.Drawing.Point(5, 25)
            Me.chkShowToolTip.MenuManager = Me
            Me.chkShowToolTip.Name = "chkShowToolTip"
            Me.chkShowToolTip.Properties.Caption = "Show tooltip"
            Me.chkShowToolTip.Size = New System.Drawing.Size(105, 19)
            Me.chkShowToolTip.TabIndex = 1
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.chkShowBookmarks)
            Me.groupControl1.Controls.Add(Me.colorEdit1)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Location = New System.Drawing.Point(5, 5)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(250, 77)
            Me.groupControl1.TabIndex = 3
            Me.groupControl1.Text = "Bookmarks"
            '
            'chkShowBookmarks
            '
            Me.chkShowBookmarks.EditValue = True
            Me.chkShowBookmarks.Location = New System.Drawing.Point(5, 25)
            Me.chkShowBookmarks.MenuManager = Me
            Me.chkShowBookmarks.Name = "chkShowBookmarks"
            Me.chkShowBookmarks.Properties.Caption = "Show bookmarks"
            Me.chkShowBookmarks.Size = New System.Drawing.Size(105, 19)
            Me.chkShowBookmarks.TabIndex = 0
            '
            'colorEdit1
            '
            Me.colorEdit1.EditValue = System.Drawing.Color.SteelBlue
            Me.colorEdit1.Location = New System.Drawing.Point(89, 47)
            Me.colorEdit1.MenuManager = Me
            Me.colorEdit1.Name = "colorEdit1"
            Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEdit1.Size = New System.Drawing.Size(100, 20)
            Me.colorEdit1.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(7, 50)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(76, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Bookmark color:"
            '
            'HyperlinksModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "HyperlinksModule"
            Me.Size = New System.Drawing.Size(845, 389)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            Me.groupControl2.PerformLayout()
            CType(Me.chkShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAlt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkCtrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowToolTip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.chkShowBookmarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
		Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private WithEvents chkShowBookmarks As DevExpress.XtraEditors.CheckEdit
		Private topDockControl As DevExpress.XtraBars.StandaloneBarDockControl
		Private commonBar2 As DevExpress.XtraRichEdit.UI.CommonBar
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
		Private linksBar1 As DevExpress.XtraRichEdit.UI.LinksBar
		Private richEditControl As RichEditControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents chkCtrl As DevExpress.XtraEditors.CheckEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkShowToolTip As DevExpress.XtraEditors.CheckEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents chkShift As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkAlt As DevExpress.XtraEditors.CheckEdit
        Private WithEvents FileInfoBar1 As DevExpress.XtraRichEdit.UI.FileInfoBar
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
	End Class
End Namespace
