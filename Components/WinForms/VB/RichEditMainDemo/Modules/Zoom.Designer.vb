Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class ZoomModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ZoomModule))
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.lblZoom = New DevExpress.XtraBars.BarStaticItem()
			Me.zoomTrackBar = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.bottomDockArea = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
			Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			Me.zoomBar1 = New DevExpress.XtraRichEdit.UI.ZoomBar()
			Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
			Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
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
			Me.richEditControl.Size = New System.Drawing.Size(841, 333)
			Me.richEditControl.TabIndex = 1
			Me.richEditControl.Text = "richEditControl"
'			Me.richEditControl.ZoomChanged += New System.EventHandler(Me.richEditControl_ZoomChanged);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar3, Me.commonBar1, Me.clipboardBar1, Me.zoomBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockControls.Add(Me.bottomDockArea)
			Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.zoomTrackBar, Me.lblZoom, Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.zoomOutItem1, Me.zoomInItem1})
			Me.barManager1.MaxItemId = 37
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemZoomTrackBar1})
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.lblZoom), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.zoomTrackBar, "", False, True, True, 206)})
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.StandaloneBarDockControl = Me.bottomDockArea
			Me.bar3.Text = "Status bar"
			' 
			' lblZoom
			' 
			Me.lblZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.lblZoom.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.lblZoom.Caption = "lblZoom"
			Me.lblZoom.Id = 21
			Me.lblZoom.Name = "lblZoom"
			Me.lblZoom.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' zoomTrackBar
			' 
			Me.zoomTrackBar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.zoomTrackBar.Caption = "barEditItem1"
			Me.zoomTrackBar.Edit = Me.repositoryItemZoomTrackBar1
			Me.zoomTrackBar.Id = 20
			Me.zoomTrackBar.Name = "zoomTrackBar"
			' 
			' repositoryItemZoomTrackBar1
			' 
			Me.repositoryItemZoomTrackBar1.LargeChange = 10
			Me.repositoryItemZoomTrackBar1.Maximum = 500
			Me.repositoryItemZoomTrackBar1.Minimum = 10
			Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
			Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			' 
			' bottomDockArea
			' 
			Me.bottomDockArea.AutoSize = True
			Me.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.bottomDockArea.Location = New System.Drawing.Point(2, 362)
			Me.bottomDockArea.Name = "bottomDockArea"
			Me.bottomDockArea.Size = New System.Drawing.Size(841, 25)
			Me.bottomDockArea.Text = "standaloneBarDockControl2"
			' 
			' commonBar1
			' 
			Me.commonBar1.DockCol = 0
			Me.commonBar1.DockRow = 0
			Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.commonBar1.FloatLocation = New System.Drawing.Point(268, 184)
			Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
			Me.commonBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
			' 
			' undoItem1
			' 
			Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
			Me.undoItem1.Id = 30
			Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
			Me.redoItem1.Id = 31
			Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
			Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
			Me.redoItem1.Name = "redoItem1"
			' 
			' clipboardBar1
			' 
			Me.clipboardBar1.DockCol = 1
			Me.clipboardBar1.DockRow = 0
			Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.clipboardBar1.FloatLocation = New System.Drawing.Point(360, 179)
			Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
			Me.clipboardBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
			' 
			' cutItem1
			' 
			Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
			Me.cutItem1.Id = 32
			Me.cutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
			Me.copyItem1.Id = 33
			Me.copyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
			Me.pasteItem1.Id = 34
			Me.pasteItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' zoomBar1
			' 
			Me.zoomBar1.DockCol = 2
			Me.zoomBar1.DockRow = 0
			Me.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.zoomBar1.FloatLocation = New System.Drawing.Point(488, 152)
			Me.zoomBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.zoomOutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomInItem1)})
			Me.zoomBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
			' 
			' zoomOutItem1
			' 
			Me.zoomOutItem1.Glyph = (CType(resources.GetObject("zoomOutItem1.Glyph"), System.Drawing.Image))
			Me.zoomOutItem1.Id = 35
			Me.zoomOutItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Subtract))
			Me.zoomOutItem1.LargeGlyph = (CType(resources.GetObject("zoomOutItem1.LargeGlyph"), System.Drawing.Image))
			Me.zoomOutItem1.Name = "zoomOutItem1"
			' 
			' zoomInItem1
			' 
			Me.zoomInItem1.Glyph = (CType(resources.GetObject("zoomInItem1.Glyph"), System.Drawing.Image))
			Me.zoomInItem1.Id = 36
			Me.zoomInItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Add))
			Me.zoomInItem1.LargeGlyph = (CType(resources.GetObject("zoomInItem1.LargeGlyph"), System.Drawing.Image))
			Me.zoomInItem1.Name = "zoomInItem1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.richEditControl)
			Me.panelControl1.Controls.Add(Me.bottomDockArea)
			Me.panelControl1.Controls.Add(Me.standaloneBarDockControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(845, 389)
			Me.panelControl1.TabIndex = 4
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.cutItem1)
			Me.richEditBarController1.BarItems.Add(Me.copyItem1)
			Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
			Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
			Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl
			' 
			' standaloneBarDockControl1
			' 
			Me.standaloneBarDockControl1.AutoSize = True
			Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.standaloneBarDockControl1.Location = New System.Drawing.Point(2, 2)
			Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
			Me.standaloneBarDockControl1.Size = New System.Drawing.Size(841, 27)
			Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
			' 
			' ZoomModule
			' 
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ZoomModule"
			Me.Size = New System.Drawing.Size(845, 389)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl As RichEditControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private zoomTrackBar As DevExpress.XtraBars.BarEditItem
		Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private lblZoom As DevExpress.XtraBars.BarStaticItem
		Private bottomDockArea As DevExpress.XtraBars.StandaloneBarDockControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private zoomBar1 As DevExpress.XtraRichEdit.UI.ZoomBar
		Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
		Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
	End Class
End Namespace
