Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class Options
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
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.checkedListBox2 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.label4 = New System.Windows.Forms.Label()
			Me.checkedListBox1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.label3 = New System.Windows.Forms.Label()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkedListBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(162, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(395, 300)
			Me.treeList1.TabIndex = 6
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.checkedListBox2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.checkedListBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(4)
			Me.panel2.Size = New System.Drawing.Size(156, 300)
			Me.panel2.TabIndex = 7
			' 
			' checkedListBox2
			' 
			Me.checkedListBox2.CheckOnClick = True
			Me.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBox2.ItemHeight = 16
			Me.checkedListBox2.Location = New System.Drawing.Point(4, 192)
			Me.checkedListBox2.Name = "checkedListBox2"
			Me.checkedListBox2.Size = New System.Drawing.Size(148, 104)
			Me.checkedListBox2.TabIndex = 2
'			Me.checkedListBox2.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.checkedListBox2_ItemCheck);
			' 
			' label4
			' 
			Me.label4.Dock = System.Windows.Forms.DockStyle.Top
			Me.label4.Location = New System.Drawing.Point(4, 172)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(148, 20)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Behavor Options:"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.CheckOnClick = True
			Me.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.checkedListBox1.ItemHeight = 16
			Me.checkedListBox1.Location = New System.Drawing.Point(4, 24)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(148, 148)
			Me.checkedListBox1.TabIndex = 0
'			Me.checkedListBox1.ItemCheck += New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(Me.checkedListBox1_ItemCheck);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Location = New System.Drawing.Point(4, 4)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(148, 20)
			Me.label3.TabIndex = 1
			Me.label3.Text = "View Options:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(156, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 300)
			Me.splitter1.TabIndex = 8
			Me.splitter1.TabStop = False
			' 
			' Options
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Options"
			Me.Size = New System.Drawing.Size(557, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkedListBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private panel2 As PanelControl
		Private WithEvents checkedListBox1 As DevExpress.XtraEditors.CheckedListBoxControl
		Private label3 As System.Windows.Forms.Label
		Private WithEvents checkedListBox2 As DevExpress.XtraEditors.CheckedListBoxControl
		Private label4 As System.Windows.Forms.Label
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
