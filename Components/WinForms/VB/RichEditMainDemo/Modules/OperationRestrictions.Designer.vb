Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class OperationRestrictionsModule
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
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.edtReadOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowShowPopupMenu = New DevExpress.XtraEditors.CheckEdit()
            Me.edtHideDisabled = New DevExpress.XtraEditors.CheckEdit()
            Me.gcZoom = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowZoom = New DevExpress.XtraEditors.CheckEdit()
            Me.lblMinZoomFactor = New DevExpress.XtraEditors.LabelControl()
            Me.edtMaxZoomFactor = New DevExpress.XtraEditors.SpinEdit()
            Me.lblMaxZoomFactor = New DevExpress.XtraEditors.LabelControl()
            Me.edtMinZoomFactor = New DevExpress.XtraEditors.SpinEdit()
            Me.gcCommon = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowOpen = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowCreateNew = New DevExpress.XtraEditors.CheckEdit()
            Me.edtSave = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowPrinting = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowSaveAs = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowDrag = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowDrop = New DevExpress.XtraEditors.CheckEdit()
            Me.gcClipBoard = New DevExpress.XtraEditors.GroupControl()
            Me.edtAllowCut = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowCopy = New DevExpress.XtraEditors.CheckEdit()
            Me.edtAllowPaste = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
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
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.edtReadOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowShowPopupMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtHideDisabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcZoom, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcZoom.SuspendLayout()
            CType(Me.edtAllowZoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtMaxZoomFactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtMinZoomFactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcCommon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcCommon.SuspendLayout()
            CType(Me.edtAllowOpen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowCreateNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowPrinting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowSaveAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowDrag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gcClipBoard, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gcClipBoard.SuspendLayout()
            CType(Me.edtAllowCut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowCopy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtAllowPaste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.edtReadOnly)
            Me.panelControl1.Controls.Add(Me.edtAllowShowPopupMenu)
            Me.panelControl1.Controls.Add(Me.edtHideDisabled)
            Me.panelControl1.Controls.Add(Me.gcZoom)
            Me.panelControl1.Controls.Add(Me.gcCommon)
            Me.panelControl1.Controls.Add(Me.gcClipBoard)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(691, 120)
            Me.panelControl1.TabIndex = 0
            '
            'edtReadOnly
            '
            Me.edtReadOnly.Location = New System.Drawing.Point(547, 25)
            Me.edtReadOnly.MenuManager = Me
            Me.edtReadOnly.Name = "edtReadOnly"
            Me.edtReadOnly.Properties.Caption = "ReadOnly"
            Me.edtReadOnly.Size = New System.Drawing.Size(120, 19)
            Me.edtReadOnly.TabIndex = 17
            '
            'edtAllowShowPopupMenu
            '
            Me.edtAllowShowPopupMenu.EditValue = True
            Me.edtAllowShowPopupMenu.Location = New System.Drawing.Point(547, 50)
            Me.edtAllowShowPopupMenu.MenuManager = Me
            Me.edtAllowShowPopupMenu.Name = "edtAllowShowPopupMenu"
            Me.edtAllowShowPopupMenu.Properties.Caption = "Show popup menu"
            Me.edtAllowShowPopupMenu.Size = New System.Drawing.Size(120, 19)
            Me.edtAllowShowPopupMenu.TabIndex = 15
            '
            'edtHideDisabled
            '
            Me.edtHideDisabled.Location = New System.Drawing.Point(547, 76)
            Me.edtHideDisabled.MenuManager = Me
            Me.edtHideDisabled.Name = "edtHideDisabled"
            Me.edtHideDisabled.Properties.Caption = "Hide disabled bar items"
            Me.edtHideDisabled.Size = New System.Drawing.Size(140, 19)
            Me.edtHideDisabled.TabIndex = 14
            '
            'gcZoom
            '
            Me.gcZoom.Controls.Add(Me.edtAllowZoom)
            Me.gcZoom.Controls.Add(Me.lblMinZoomFactor)
            Me.gcZoom.Controls.Add(Me.edtMaxZoomFactor)
            Me.gcZoom.Controls.Add(Me.lblMaxZoomFactor)
            Me.gcZoom.Controls.Add(Me.edtMinZoomFactor)
            Me.gcZoom.Location = New System.Drawing.Point(382, 5)
            Me.gcZoom.Name = "gcZoom"
            Me.gcZoom.Size = New System.Drawing.Size(159, 98)
            Me.gcZoom.TabIndex = 12
            Me.gcZoom.Text = "Zoom"
            '
            'edtAllowZoom
            '
            Me.edtAllowZoom.EditValue = True
            Me.edtAllowZoom.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowZoom.MenuManager = Me
            Me.edtAllowZoom.Name = "edtAllowZoom"
            Me.edtAllowZoom.Properties.Caption = "Zoom"
            Me.edtAllowZoom.Size = New System.Drawing.Size(84, 19)
            Me.edtAllowZoom.TabIndex = 13
            '
            'lblMinZoomFactor
            '
            Me.lblMinZoomFactor.Location = New System.Drawing.Point(7, 53)
            Me.lblMinZoomFactor.Name = "lblMinZoomFactor"
            Me.lblMinZoomFactor.Size = New System.Drawing.Size(80, 13)
            Me.lblMinZoomFactor.TabIndex = 0
            Me.lblMinZoomFactor.Text = "Min zoom factor:"
            '
            'edtMaxZoomFactor
            '
            Me.edtMaxZoomFactor.EditValue = New Decimal(New Integer() {3, 0, 0, 0})
            Me.edtMaxZoomFactor.Location = New System.Drawing.Point(93, 75)
            Me.edtMaxZoomFactor.MenuManager = Me
            Me.edtMaxZoomFactor.Name = "edtMaxZoomFactor"
            Me.edtMaxZoomFactor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtMaxZoomFactor.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.edtMaxZoomFactor.Size = New System.Drawing.Size(58, 20)
            Me.edtMaxZoomFactor.TabIndex = 13
            '
            'lblMaxZoomFactor
            '
            Me.lblMaxZoomFactor.Location = New System.Drawing.Point(7, 78)
            Me.lblMaxZoomFactor.Name = "lblMaxZoomFactor"
            Me.lblMaxZoomFactor.Size = New System.Drawing.Size(84, 13)
            Me.lblMaxZoomFactor.TabIndex = 0
            Me.lblMaxZoomFactor.Text = "Max zoom factor:"
            '
            'edtMinZoomFactor
            '
            Me.edtMinZoomFactor.EditValue = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.edtMinZoomFactor.Location = New System.Drawing.Point(93, 50)
            Me.edtMinZoomFactor.MenuManager = Me
            Me.edtMinZoomFactor.Name = "edtMinZoomFactor"
            Me.edtMinZoomFactor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtMinZoomFactor.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.edtMinZoomFactor.Properties.MaxValue = New Decimal(New Integer() {276447232, 23283, 0, 0})
            Me.edtMinZoomFactor.Properties.MinValue = New Decimal(New Integer() {9, 0, 0, 131072})
            Me.edtMinZoomFactor.Size = New System.Drawing.Size(58, 20)
            Me.edtMinZoomFactor.TabIndex = 12
            '
            'gcCommon
            '
            Me.gcCommon.Controls.Add(Me.edtAllowOpen)
            Me.gcCommon.Controls.Add(Me.edtAllowCreateNew)
            Me.gcCommon.Controls.Add(Me.edtSave)
            Me.gcCommon.Controls.Add(Me.edtAllowPrinting)
            Me.gcCommon.Controls.Add(Me.edtAllowSaveAs)
            Me.gcCommon.Controls.Add(Me.edtAllowDrag)
            Me.gcCommon.Controls.Add(Me.edtAllowDrop)
            Me.gcCommon.Location = New System.Drawing.Point(170, 5)
            Me.gcCommon.Name = "gcCommon"
            Me.gcCommon.Size = New System.Drawing.Size(206, 98)
            Me.gcCommon.TabIndex = 4
            Me.gcCommon.Text = "Common"
            '
            'edtAllowOpen
            '
            Me.edtAllowOpen.EditValue = True
            Me.edtAllowOpen.Location = New System.Drawing.Point(147, 25)
            Me.edtAllowOpen.MenuManager = Me
            Me.edtAllowOpen.Name = "edtAllowOpen"
            Me.edtAllowOpen.Properties.Caption = "Open"
            Me.edtAllowOpen.Size = New System.Drawing.Size(54, 19)
            Me.edtAllowOpen.TabIndex = 11
            '
            'edtAllowCreateNew
            '
            Me.edtAllowCreateNew.EditValue = True
            Me.edtAllowCreateNew.Location = New System.Drawing.Point(73, 76)
            Me.edtAllowCreateNew.Name = "edtAllowCreateNew"
            Me.edtAllowCreateNew.Properties.Caption = "Create New"
            Me.edtAllowCreateNew.Size = New System.Drawing.Size(79, 19)
            Me.edtAllowCreateNew.TabIndex = 10
            '
            'edtSave
            '
            Me.edtSave.EditValue = True
            Me.edtSave.Location = New System.Drawing.Point(5, 75)
            Me.edtSave.MenuManager = Me
            Me.edtSave.Name = "edtSave"
            Me.edtSave.Properties.Caption = "Save"
            Me.edtSave.Size = New System.Drawing.Size(52, 19)
            Me.edtSave.TabIndex = 7
            '
            'edtAllowPrinting
            '
            Me.edtAllowPrinting.EditValue = True
            Me.edtAllowPrinting.Location = New System.Drawing.Point(73, 50)
            Me.edtAllowPrinting.MenuManager = Me
            Me.edtAllowPrinting.Name = "edtAllowPrinting"
            Me.edtAllowPrinting.Properties.Caption = "Printing"
            Me.edtAllowPrinting.Size = New System.Drawing.Size(60, 19)
            Me.edtAllowPrinting.TabIndex = 9
            '
            'edtAllowSaveAs
            '
            Me.edtAllowSaveAs.EditValue = True
            Me.edtAllowSaveAs.Location = New System.Drawing.Point(73, 25)
            Me.edtAllowSaveAs.MenuManager = Me
            Me.edtAllowSaveAs.Name = "edtAllowSaveAs"
            Me.edtAllowSaveAs.Properties.Caption = "Save as"
            Me.edtAllowSaveAs.Size = New System.Drawing.Size(68, 19)
            Me.edtAllowSaveAs.TabIndex = 8
            '
            'edtAllowDrag
            '
            Me.edtAllowDrag.EditValue = True
            Me.edtAllowDrag.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowDrag.MenuManager = Me
            Me.edtAllowDrag.Name = "edtAllowDrag"
            Me.edtAllowDrag.Properties.Caption = "Drag"
            Me.edtAllowDrag.Size = New System.Drawing.Size(52, 19)
            Me.edtAllowDrag.TabIndex = 5
            '
            'edtAllowDrop
            '
            Me.edtAllowDrop.EditValue = True
            Me.edtAllowDrop.Location = New System.Drawing.Point(5, 50)
            Me.edtAllowDrop.MenuManager = Me
            Me.edtAllowDrop.Name = "edtAllowDrop"
            Me.edtAllowDrop.Properties.Caption = "Drop"
            Me.edtAllowDrop.Size = New System.Drawing.Size(52, 19)
            Me.edtAllowDrop.TabIndex = 6
            '
            'gcClipBoard
            '
            Me.gcClipBoard.Controls.Add(Me.edtAllowCut)
            Me.gcClipBoard.Controls.Add(Me.edtAllowCopy)
            Me.gcClipBoard.Controls.Add(Me.edtAllowPaste)
            Me.gcClipBoard.Location = New System.Drawing.Point(5, 5)
            Me.gcClipBoard.Name = "gcClipBoard"
            Me.gcClipBoard.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gcClipBoard.Size = New System.Drawing.Size(159, 98)
            Me.gcClipBoard.TabIndex = 0
            Me.gcClipBoard.Text = "Clipboard"
            '
            'edtAllowCut
            '
            Me.edtAllowCut.EditValue = True
            Me.edtAllowCut.Location = New System.Drawing.Point(5, 25)
            Me.edtAllowCut.MenuManager = Me
            Me.edtAllowCut.Name = "edtAllowCut"
            Me.edtAllowCut.Properties.Caption = "Cut"
            Me.edtAllowCut.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowCut.TabIndex = 1
            '
            'edtAllowCopy
            '
            Me.edtAllowCopy.EditValue = True
            Me.edtAllowCopy.Location = New System.Drawing.Point(5, 50)
            Me.edtAllowCopy.MenuManager = Me
            Me.edtAllowCopy.Name = "edtAllowCopy"
            Me.edtAllowCopy.Properties.Caption = "Copy"
            Me.edtAllowCopy.Size = New System.Drawing.Size(75, 19)
            Me.edtAllowCopy.TabIndex = 2
            '
            'edtAllowPaste
            '
            Me.edtAllowPaste.EditValue = True
            Me.edtAllowPaste.Location = New System.Drawing.Point(5, 75)
            Me.edtAllowPaste.MenuManager = Me
            Me.edtAllowPaste.Name = "edtAllowPaste"
            Me.edtAllowPaste.Properties.Caption = "Paste"
            Me.edtAllowPaste.Size = New System.Drawing.Size(84, 19)
            Me.edtAllowPaste.TabIndex = 3
            '
            'panelControl2
            '
            Me.panelControl2.Controls.Add(Me.richEditControl)
            Me.panelControl2.Controls.Add(Me.standaloneBarDockControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl2.Location = New System.Drawing.Point(0, 120)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(691, 309)
            Me.panelControl2.TabIndex = 1
            '
            'richEditControl
            '
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(2, 32)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(687, 275)
            Me.richEditControl.TabIndex = 1
            Me.richEditControl.Text = "richEditControl1"
            Me.richEditControl.DragDropMode = DevExpress.XtraRichEdit.DragDropMode.Manual
            '
            'standaloneBarDockControl2
            '
            Me.standaloneBarDockControl2.CausesValidation = False
            Me.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.standaloneBarDockControl2.Location = New System.Drawing.Point(2, 2)
            Me.standaloneBarDockControl2.Name = "standaloneBarDockControl2"
            Me.standaloneBarDockControl2.Size = New System.Drawing.Size(687, 30)
            Me.standaloneBarDockControl2.Text = "standaloneBarDockControl2"
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.clipboardBar1, Me.zoomBar1, Me.commonBar2, Me.FileInfoBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl2)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.findItem1, Me.replaceItem1, Me.changeStyleItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.insertPictureItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.insertPageBreakItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.insertSymbolItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.ShowDocumentPropertiesFormItem1})
            Me.barManager1.MaxItemId = 30
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
            'FileInfoBar1
            '
            Me.FileInfoBar1.Control = Me.richEditControl
            Me.FileInfoBar1.DockCol = 1
            Me.FileInfoBar1.DockRow = 0
            Me.FileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.FileInfoBar1.FloatLocation = New System.Drawing.Point(369, 269)
            Me.FileInfoBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ShowDocumentPropertiesFormItem1)})
            Me.FileInfoBar1.StandaloneBarDockControl = Me.standaloneBarDockControl2
            '
            'ShowDocumentPropertiesFormItem1
            '
            Me.ShowDocumentPropertiesFormItem1.Id = 29
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
            'insertPictureItem1
            '
            Me.insertPictureItem1.Id = 17
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertMergeFieldItem1
            '
            Me.insertMergeFieldItem1.Id = 18
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            '
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 19
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 20
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'toggleViewMergedDataItem1
            '
            Me.toggleViewMergedDataItem1.Id = 21
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            '
            'insertPageBreakItem1
            '
            Me.insertPageBreakItem1.Id = 22
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
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
            'insertSymbolItem1
            '
            Me.insertSymbolItem1.Id = 26
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
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
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.ShowDocumentPropertiesFormItem1)
            Me.richEditBarController1.Control = Me.richEditControl
            '
            'OperationRestrictionsModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "OperationRestrictionsModule"
            Me.Size = New System.Drawing.Size(691, 429)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.edtReadOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowShowPopupMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtHideDisabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcZoom, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcZoom.ResumeLayout(False)
            Me.gcZoom.PerformLayout()
            CType(Me.edtAllowZoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtMaxZoomFactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtMinZoomFactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcCommon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcCommon.ResumeLayout(False)
            CType(Me.edtAllowOpen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowCreateNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowPrinting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowSaveAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowDrag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gcClipBoard, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gcClipBoard.ResumeLayout(False)
            CType(Me.edtAllowCut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowCopy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtAllowPaste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private richEditControl As RichEditControl
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
		Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
		Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
		Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
		Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private WithEvents edtAllowPaste As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowCopy As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowCut As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowDrop As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowDrag As DevExpress.XtraEditors.CheckEdit
		Private lblMaxZoomFactor As DevExpress.XtraEditors.LabelControl
		Private lblMinZoomFactor As DevExpress.XtraEditors.LabelControl
		Private WithEvents edtMaxZoomFactor As DevExpress.XtraEditors.SpinEdit
		Private WithEvents edtMinZoomFactor As DevExpress.XtraEditors.SpinEdit
		Private gcClipBoard As DevExpress.XtraEditors.GroupControl
		Private gcCommon As DevExpress.XtraEditors.GroupControl
		Private WithEvents edtAllowSaveAs As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowPrinting As DevExpress.XtraEditors.CheckEdit
		Private commonBar2 As DevExpress.XtraRichEdit.UI.CommonBar
		Private gcZoom As DevExpress.XtraEditors.GroupControl
		Private WithEvents edtAllowZoom As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtSave As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtHideDisabled As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowShowPopupMenu As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowOpen As DevExpress.XtraEditors.CheckEdit
		Private WithEvents edtAllowCreateNew As DevExpress.XtraEditors.CheckEdit
        Private WithEvents edtReadOnly As DevExpress.XtraEditors.CheckEdit
        Private WithEvents FileInfoBar1 As DevExpress.XtraRichEdit.UI.FileInfoBar
        Friend WithEvents ShowDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
	End Class
End Namespace
