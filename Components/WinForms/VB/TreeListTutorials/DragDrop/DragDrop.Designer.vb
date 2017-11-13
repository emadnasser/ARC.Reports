Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class DragDrop
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
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.panel2.SuspendLayout()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.listBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(337, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(4)
			Me.panel2.Size = New System.Drawing.Size(216, 300)
			Me.panel2.TabIndex = 6
			' 
			' listBox1
			' 
			Me.listBox1.AllowDrop = True
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.ItemHeight = 16
			Me.listBox1.Location = New System.Drawing.Point(4, 46)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(208, 250)
			Me.listBox1.TabIndex = 2
'			Me.listBox1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.listBox1_DragDrop);
'			Me.listBox1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.listBox1_DragEnter);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.label3.Location = New System.Drawing.Point(4, 22)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(208, 24)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Drag && Drop here"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' checkBox1
			' 
			Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.checkBox1.Location = New System.Drawing.Point(4, 4)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "DragNodes"
			Me.checkBox1.Size = New System.Drawing.Size(208, 18)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoChangeParent = False
			Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
            Me.treeList1.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ShowToolTips = False
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.Size = New System.Drawing.Size(331, 300)
			Me.treeList1.TabIndex = 7
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(331, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 300)
			Me.splitter1.TabIndex = 8
			Me.splitter1.TabStop = False
			' 
			' DragDrop
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "DragDrop"
			Me.Size = New System.Drawing.Size(553, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			Me.panel2.ResumeLayout(False)
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As System.Windows.Forms.Panel
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private label3 As System.Windows.Forms.Label
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
