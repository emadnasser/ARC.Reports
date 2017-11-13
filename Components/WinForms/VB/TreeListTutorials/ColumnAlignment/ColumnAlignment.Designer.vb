Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class ColumnAlignment
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
			Me.comboBox2 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label4 = New System.Windows.Forms.Label()
			Me.comboBox1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label3 = New System.Windows.Forms.Label()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 47)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(553, 253)
			Me.treeList1.TabIndex = 6
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.comboBox2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.comboBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(553, 39)
			Me.panel2.TabIndex = 7
			' 
			' comboBox2
			' 
			Me.comboBox2.Location = New System.Drawing.Point(297, 9)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox2.Size = New System.Drawing.Size(128, 20)
			Me.comboBox2.TabIndex = 8
'			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox_SelectedIndexChanged);
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(227, 12)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(64, 16)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Alignment:"
			' 
			' comboBox1
			' 
			Me.comboBox1.Location = New System.Drawing.Point(74, 9)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox1.Size = New System.Drawing.Size(128, 20)
			Me.comboBox1.TabIndex = 6
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(12, 12)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(56, 16)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Column:"
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 39)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(553, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' ColumnAlignment
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "ColumnAlignment"
			Me.Size = New System.Drawing.Size(553, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private panel2 As PanelControl
		Private WithEvents comboBox2 As DevExpress.XtraEditors.ComboBoxEdit
		Private label4 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As DevExpress.XtraEditors.ComboBoxEdit
		Private label3 As System.Windows.Forms.Label
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace
