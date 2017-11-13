Imports Microsoft.VisualBasic
Imports System
Namespace PivotGridOlapBrowser
	Partial Public Class MainForm
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barToolbar = New DevExpress.XtraBars.Bar()
			Me.barMenu = New DevExpress.XtraBars.Bar()
			Me.barStatusBar = New DevExpress.XtraBars.Bar()
			Me.bsiStatus = New DevExpress.XtraBars.BarStaticItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.pivotGridBrowser1 = New PivotGridOlapBrowser.PivotGridBrowser()
			Me.notePanel = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.panelError = New DevExpress.XtraEditors.PanelControl()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelError.SuspendLayout()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.barToolbar, Me.barMenu, Me.barStatusBar})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bsiStatus })
			Me.barManager1.MainMenu = Me.barMenu
			Me.barManager1.MaxItemId = 3
			Me.barManager1.StatusBar = Me.barStatusBar
			' 
			' barToolbar
			' 
			Me.barToolbar.BarName = "Tools"
			Me.barToolbar.DockCol = 0
			Me.barToolbar.DockRow = 1
			Me.barToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.barToolbar.OptionsBar.AllowQuickCustomization = False
			Me.barToolbar.OptionsBar.DrawDragBorder = False
			Me.barToolbar.OptionsBar.UseWholeRow = True
			Me.barToolbar.Text = "Tools"
			' 
			' barMenu
			' 
			Me.barMenu.BarName = "Main menu"
			Me.barMenu.DockCol = 0
			Me.barMenu.DockRow = 0
			Me.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.barMenu.OptionsBar.MultiLine = True
			Me.barMenu.OptionsBar.UseWholeRow = True
			Me.barMenu.Text = "Main menu"
			Me.barMenu.Visible = False
			' 
			' barStatusBar
			' 
			Me.barStatusBar.BarName = "Status bar"
			Me.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.barStatusBar.DockCol = 0
			Me.barStatusBar.DockRow = 0
			Me.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.barStatusBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bsiStatus)})
			Me.barStatusBar.OptionsBar.AllowQuickCustomization = False
			Me.barStatusBar.OptionsBar.DrawDragBorder = False
			Me.barStatusBar.OptionsBar.UseWholeRow = True
			Me.barStatusBar.Text = "Status bar"
			' 
			' bsiStatus
			' 
			Me.bsiStatus.Caption = "Ready"
			Me.bsiStatus.Id = 1
			Me.bsiStatus.Name = "bsiStatus"
			Me.bsiStatus.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(786, 51)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 548)
			Me.barDockControlBottom.Size = New System.Drawing.Size(786, 25)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 497)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(786, 51)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 497)
			' 
			' pivotGridBrowser1
			' 
			Me.pivotGridBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridBrowser1.Location = New System.Drawing.Point(0, 43)
			Me.pivotGridBrowser1.Name = "pivotGridBrowser1"
			Me.pivotGridBrowser1.Padding = New System.Windows.Forms.Padding(8)
			Me.pivotGridBrowser1.Size = New System.Drawing.Size(786, 392)
			Me.pivotGridBrowser1.TabIndex = 4
'			Me.pivotGridBrowser1.IsBusyChanged += New System.EventHandler(Me.pivotGridBrowser1_IsBusyChanged);
			' 
			' notePanel
			' 
			Me.notePanel.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.notePanel.Location = New System.Drawing.Point(0, 486)
			Me.notePanel.MaxRows = 15
			Me.notePanel.Name = "notePanel"
			Me.notePanel.Size = New System.Drawing.Size(786, 62)
			Me.notePanel.TabIndex = 5
			Me.notePanel.TabStop = False
			Me.notePanel.Text = resources.GetString("notePanel.Text")
			' 
			' panelError
			' 
			Me.panelError.Controls.Add(Me.hyperLinkEdit1)
			Me.panelError.Controls.Add(Me.labelControl1)
			Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelError.Location = New System.Drawing.Point(0, 0)
			Me.panelError.Name = "panelError"
			Me.panelError.Size = New System.Drawing.Size(786, 43)
			Me.panelError.TabIndex = 16
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ADOMD.NET"
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(469, 19)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
			Me.hyperLinkEdit1.Properties.UseParentBackground = True
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(118, 18)
			Me.hyperLinkEdit1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red
			Me.labelControl1.AutoEllipsis = True
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Location = New System.Drawing.Point(12, 7)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(759, 28)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services ADOMD.NET" & " 9.0 and OLE DB 8.0 (or later)" & Constants.vbCrLf & " installed on your system. You can get the latest" & " version of these providers here:"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.pivotGridBrowser1)
			Me.panel1.Controls.Add(Me.panelError)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 51)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(786, 435)
			Me.panel1.TabIndex = 21
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(786, 573)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.notePanel)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "MainForm"
			Me.Text = "XtraPivotGrid Olap Browser Demo"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelError, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelError.ResumeLayout(False)
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barToolbar As DevExpress.XtraBars.Bar
		Private barMenu As DevExpress.XtraBars.Bar
		Private barStatusBar As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents pivotGridBrowser1 As PivotGridBrowser
		Private bsiStatus As DevExpress.XtraBars.BarStaticItem
		Private notePanel As DevExpress.Utils.Frames.NotePanel8_1
		Private panelError As DevExpress.XtraEditors.PanelControl
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace

