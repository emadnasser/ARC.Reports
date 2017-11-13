Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraRichEdit.Demos
	Partial Public Class DocumentProtectionModule
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DocumentProtectionModule))
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.pnlAlert = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.lbLoggedInAs = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.cbUsers = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.documentProtectionBar1 = New DevExpress.XtraRichEdit.UI.DocumentProtectionBar()
			Me.protectDocumentItem1 = New DevExpress.XtraRichEdit.UI.ProtectDocumentItem()
			Me.changeRangeEditingPermissionsItem1 = New DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem()
			Me.unprotectDocumentItem1 = New DevExpress.XtraRichEdit.UI.UnprotectDocumentItem()
			Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.pnlAlert.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.cbUsers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl
			' 
			Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl.Location = New System.Drawing.Point(0, 95)
			Me.richEditControl.MenuManager = Me
			Me.richEditControl.Name = "richEditControl"
			Me.richEditControl.Size = New System.Drawing.Size(738, 332)
			Me.richEditControl.TabIndex = 0
			Me.richEditControl.Text = "richEditControl1"
			' 
			' pnlAlert
			' 
			Me.pnlAlert.BackColor = System.Drawing.Color.LemonChiffon
			Me.pnlAlert.Controls.Add(Me.label2)
			Me.pnlAlert.Controls.Add(Me.label1)
			Me.pnlAlert.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlAlert.Location = New System.Drawing.Point(0, 31)
			Me.pnlAlert.Name = "pnlAlert"
			Me.pnlAlert.Size = New System.Drawing.Size(738, 32)
			Me.pnlAlert.TabIndex = 4
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(146, 10)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(406, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Permission is currently restricted. Only specified users can edit part of this co" & "ntent."
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.label1.Location = New System.Drawing.Point(3, 10)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(108, 13)
			Me.label1.TabIndex = 6
			Me.label1.Text = "Restricted Access"
			' 
			' lbLoggedInAs
			' 
			Me.lbLoggedInAs.Dock = System.Windows.Forms.DockStyle.Left
			Me.lbLoggedInAs.Location = New System.Drawing.Point(2, 5)
			Me.lbLoggedInAs.Name = "lbLoggedInAs"
			Me.lbLoggedInAs.Padding = New System.Windows.Forms.Padding(3, 3, 5, 0)
			Me.lbLoggedInAs.Size = New System.Drawing.Size(108, 21)
			Me.lbLoggedInAs.TabIndex = 1
			Me.lbLoggedInAs.Text = "You are logged in as "
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.cbUsers)
			Me.panelControl2.Controls.Add(Me.lbLoggedInAs)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
			Me.panelControl2.Size = New System.Drawing.Size(738, 31)
			Me.panelControl2.TabIndex = 5
			' 
			' cbUsers
			' 
			Me.cbUsers.Location = New System.Drawing.Point(107, 7)
			Me.cbUsers.MenuManager = Me
			Me.cbUsers.Name = "cbUsers"
			Me.cbUsers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbUsers.Size = New System.Drawing.Size(173, 20)
			Me.cbUsers.TabIndex = 2
'			Me.cbUsers.SelectedValueChanged += New System.EventHandler(Me.cbUsers_SelectedValueChanged);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar3, Me.documentProtectionBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.protectDocumentItem1, Me.changeRangeEditingPermissionsItem1, Me.unprotectDocumentItem1})
			Me.barManager1.MaxItemId = 3
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' documentProtectionBar1
			' 
			Me.documentProtectionBar1.DockCol = 0
			Me.documentProtectionBar1.DockRow = 0
			Me.documentProtectionBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
			Me.documentProtectionBar1.FloatLocation = New System.Drawing.Point(353, 154)
			Me.documentProtectionBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.protectDocumentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeRangeEditingPermissionsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.unprotectDocumentItem1)})
			Me.documentProtectionBar1.StandaloneBarDockControl = Me.standaloneBarDockControl1
			' 
			' protectDocumentItem1
			' 
			Me.protectDocumentItem1.Glyph = (CType(resources.GetObject("protectDocumentItem1.Glyph"), System.Drawing.Image))
			Me.protectDocumentItem1.Id = 0
			Me.protectDocumentItem1.LargeGlyph = (CType(resources.GetObject("protectDocumentItem1.LargeGlyph"), System.Drawing.Image))
			Me.protectDocumentItem1.Name = "protectDocumentItem1"
			' 
			' changeRangeEditingPermissionsItem1
			' 
			Me.changeRangeEditingPermissionsItem1.Glyph = (CType(resources.GetObject("changeRangeEditingPermissionsItem1.Glyph"), System.Drawing.Image))
			Me.changeRangeEditingPermissionsItem1.Id = 1
			Me.changeRangeEditingPermissionsItem1.LargeGlyph = (CType(resources.GetObject("changeRangeEditingPermissionsItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1"
			' 
			' unprotectDocumentItem1
			' 
			Me.unprotectDocumentItem1.Glyph = (CType(resources.GetObject("unprotectDocumentItem1.Glyph"), System.Drawing.Image))
			Me.unprotectDocumentItem1.Id = 2
			Me.unprotectDocumentItem1.LargeGlyph = (CType(resources.GetObject("unprotectDocumentItem1.LargeGlyph"), System.Drawing.Image))
			Me.unprotectDocumentItem1.Name = "unprotectDocumentItem1"
			' 
			' standaloneBarDockControl1
			' 
			Me.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.standaloneBarDockControl1.Location = New System.Drawing.Point(0, 63)
			Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
			Me.standaloneBarDockControl1.Size = New System.Drawing.Size(738, 32)
			Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(738, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 427)
			Me.barDockControlBottom.Size = New System.Drawing.Size(738, 23)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 427)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(738, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 427)
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.protectDocumentItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeRangeEditingPermissionsItem1)
			Me.richEditBarController1.BarItems.Add(Me.unprotectDocumentItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl
			' 
			' DocumentProtectionModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.richEditControl)
			Me.Controls.Add(Me.standaloneBarDockControl1)
			Me.Controls.Add(Me.pnlAlert)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "DocumentProtectionModule"
			Me.Size = New System.Drawing.Size(738, 450)
			Me.pnlAlert.ResumeLayout(False)
			Me.pnlAlert.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			CType(Me.cbUsers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl As RichEditControl
		Private lbLoggedInAs As DevExpress.XtraEditors.LabelControl
		Private pnlAlert As System.Windows.Forms.Panel
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar3 As DevExpress.XtraBars.Bar
		Private documentProtectionBar1 As DevExpress.XtraRichEdit.UI.DocumentProtectionBar
		Private protectDocumentItem1 As DevExpress.XtraRichEdit.UI.ProtectDocumentItem
		Private changeRangeEditingPermissionsItem1 As DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem
		Private unprotectDocumentItem1 As DevExpress.XtraRichEdit.UI.UnprotectDocumentItem
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private WithEvents cbUsers As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
