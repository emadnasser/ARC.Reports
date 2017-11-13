Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class CustomTreeListNode
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Me.treeList1 = New DevExpress.XtraTreeList.Demos.Tutorials.CustomTreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.button3 = New DevExpress.XtraEditors.SimpleButton()
			Me.button2 = New DevExpress.XtraEditors.SimpleButton()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 52)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsView.ShowColumns = False
			Me.treeList1.OptionsView.ShowHorzLines = False
			Me.treeList1.OptionsView.ShowIndicator = False
			Me.treeList1.OptionsView.ShowVertLines = False
			Me.treeList1.Size = New System.Drawing.Size(551, 248)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.button3)
			Me.panel2.Controls.Add(Me.button2)
			Me.panel2.Controls.Add(Me.button1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(551, 44)
			Me.panel2.TabIndex = 6
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(204, 8)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(92, 28)
			Me.button3.TabIndex = 2
			Me.button3.Text = "&Delete"
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(106, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(92, 28)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Add &Child"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(8, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(92, 28)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Add &Root"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 44)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(551, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' CustomTreeListNode
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "CustomTreeListNode"
			Me.Size = New System.Drawing.Size(551, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As CustomTreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private panel2 As PanelControl
		Private WithEvents button1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents button3 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
