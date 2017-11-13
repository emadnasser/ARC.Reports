Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class DockPanels
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Simple Dock Panel", 1, 1)
			Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dock Panels", New System.Windows.Forms.TreeNode() { treeNode7})
			Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tab Container", 2, 2)
			Dim treeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Horizontal Container", 3, 3)
			Dim treeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vertical Container", 4, 4)
			Dim treeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dock Containers", New System.Windows.Forms.TreeNode() { treeNode9, treeNode10, treeNode11})
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DockPanels))
			Me.treeView1 = New System.Windows.Forms.TreeView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.pnlContainer = New DevExpress.XtraEditors.PanelControl()
			Me.pnlLeft = New DevExpress.XtraEditors.PanelControl()
			Me.splitter2 = New DevExpress.XtraEditors.SplitterControl()
			Me.pnlControls = New DevExpress.XtraEditors.PanelControl()
			Me.AutoHideMouseClick = New DevExpress.XtraEditors.CheckEdit()
			Me.icbDock = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.sbAutoHide = New DevExpress.XtraEditors.SimpleButton()
			Me.sbAddPanel = New DevExpress.XtraEditors.SimpleButton()
			Me.lbCaption = New System.Windows.Forms.Label()
			CType(Me.pnlContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLeft.SuspendLayout()
			CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlControls.SuspendLayout()
			CType(Me.AutoHideMouseClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbDock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.HideSelection = False
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.imageList1
			Me.treeView1.Location = New System.Drawing.Point(2, 2)
			Me.treeView1.Name = "treeView1"
			treeNode7.ImageIndex = 1
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 1
			treeNode7.Text = "Simple Dock Panel"
			treeNode8.Name = ""
			treeNode8.Text = "Dock Panels"
			treeNode9.ImageIndex = 2
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 2
			treeNode9.Text = "Tab Container"
			treeNode10.ImageIndex = 3
			treeNode10.Name = ""
			treeNode10.SelectedImageIndex = 3
			treeNode10.Text = "Horizontal Container"
			treeNode11.ImageIndex = 4
			treeNode11.Name = ""
			treeNode11.SelectedImageIndex = 4
			treeNode11.Text = "Vertical Container"
			treeNode12.Name = ""
			treeNode12.Text = "Dock Containers"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode8, treeNode12})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.ShowRootLines = False
			Me.treeView1.Size = New System.Drawing.Size(72, 229)
			Me.treeView1.TabIndex = 0
'			Me.treeView1.AfterSelect += New System.Windows.Forms.TreeViewEventHandler(Me.treeView1_AfterSelect);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(76, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(12, 356)
			Me.splitter1.TabIndex = 1
			Me.splitter1.TabStop = False
			' 
			' pnlContainer
			' 
			Me.pnlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlContainer.Location = New System.Drawing.Point(88, 28)
			Me.pnlContainer.Name = "pnlContainer"
			Me.pnlContainer.Size = New System.Drawing.Size(568, 328)
			Me.pnlContainer.TabIndex = 2
			' 
			' pnlLeft
			' 
			Me.pnlLeft.Controls.Add(Me.treeView1)
			Me.pnlLeft.Controls.Add(Me.splitter2)
			Me.pnlLeft.Controls.Add(Me.pnlControls)
			Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
			Me.pnlLeft.Name = "pnlLeft"
			Me.pnlLeft.Size = New System.Drawing.Size(76, 356)
			Me.pnlLeft.TabIndex = 3
			' 
			' splitter2
			' 
			Me.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.splitter2.Enabled = False
			Me.splitter2.Location = New System.Drawing.Point(2, 231)
			Me.splitter2.Name = "splitter2"
			Me.splitter2.Size = New System.Drawing.Size(72, 12)
			Me.splitter2.TabIndex = 2
			Me.splitter2.TabStop = False
			' 
			' pnlControls
			' 
			Me.pnlControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlControls.Controls.Add(Me.AutoHideMouseClick)
			Me.pnlControls.Controls.Add(Me.icbDock)
			Me.pnlControls.Controls.Add(Me.sbAutoHide)
			Me.pnlControls.Controls.Add(Me.sbAddPanel)
			Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pnlControls.Location = New System.Drawing.Point(2, 243)
			Me.pnlControls.Name = "pnlControls"
			Me.pnlControls.Size = New System.Drawing.Size(72, 111)
			Me.pnlControls.TabIndex = 1
			' 
			' AutoHideMouseClick
			' 
			Me.AutoHideMouseClick.Location = New System.Drawing.Point(6, 90)
			Me.AutoHideMouseClick.Name = "AutoHideMouseClick"
			Me.AutoHideMouseClick.Properties.Caption = "AutoHide by Mouse Click"
			Me.AutoHideMouseClick.Size = New System.Drawing.Size(138, 19)
			Me.AutoHideMouseClick.TabIndex = 0
'			Me.AutoHideMouseClick.CheckedChanged += New System.EventHandler(Me.checkAutoHideMouseClick_CheckedChanged);
			' 
			' icbDock
			' 
			Me.icbDock.EditValue = "imageComboBoxEdit1"
			Me.icbDock.Location = New System.Drawing.Point(28, 36)
			Me.icbDock.Name = "icbDock"
			Me.icbDock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbDock.Size = New System.Drawing.Size(116, 20)
			Me.icbDock.TabIndex = 1
			' 
			' sbAutoHide
			' 
			Me.sbAutoHide.Location = New System.Drawing.Point(8, 60)
			Me.sbAutoHide.Name = "sbAutoHide"
			Me.sbAutoHide.Size = New System.Drawing.Size(140, 24)
			Me.sbAutoHide.TabIndex = 2
			Me.sbAutoHide.Text = "AutoHide Root Panels"
'			Me.sbAutoHide.Click += New System.EventHandler(Me.sbAutoHide_Click);
			' 
			' sbAddPanel
			' 
			Me.sbAddPanel.Location = New System.Drawing.Point(8, 8)
			Me.sbAddPanel.Name = "sbAddPanel"
			Me.sbAddPanel.Size = New System.Drawing.Size(96, 24)
			Me.sbAddPanel.TabIndex = 0
			Me.sbAddPanel.Text = "Add Panel To:"
'			Me.sbAddPanel.Click += New System.EventHandler(Me.sbAddPanel_Click);
			' 
			' lbCaption
			' 
			Me.lbCaption.BackColor = System.Drawing.SystemColors.Highlight
			Me.lbCaption.Dock = System.Windows.Forms.DockStyle.Top
			Me.lbCaption.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
			Me.lbCaption.ForeColor = System.Drawing.SystemColors.HighlightText
			Me.lbCaption.Location = New System.Drawing.Point(88, 0)
			Me.lbCaption.Name = "lbCaption"
			Me.lbCaption.Size = New System.Drawing.Size(568, 28)
			Me.lbCaption.TabIndex = 4
			Me.lbCaption.Text = "label1"
			Me.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' DockPanels
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pnlContainer)
			Me.Controls.Add(Me.lbCaption)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.pnlLeft)
			Me.Name = "DockPanels"
			Me.Size = New System.Drawing.Size(656, 356)
'			Me.Load += New System.EventHandler(Me.DockPanels_Load);
			CType(Me.pnlContainer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLeft.ResumeLayout(False)
			CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlControls.ResumeLayout(False)
			CType(Me.AutoHideMouseClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbDock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private pnlContainer As DevExpress.XtraEditors.PanelControl
		Private pnlLeft As DevExpress.XtraEditors.PanelControl
		Private pnlControls As DevExpress.XtraEditors.PanelControl
		Private splitter2 As DevExpress.XtraEditors.SplitterControl
		Private lbCaption As System.Windows.Forms.Label
		Private WithEvents sbAddPanel As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbAutoHide As DevExpress.XtraEditors.SimpleButton
		Private icbDock As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer
		Private WithEvents AutoHideMouseClick As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
