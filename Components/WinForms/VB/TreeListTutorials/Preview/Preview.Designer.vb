Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class Preview
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
			Me.checkBox3 = New DevExpress.XtraEditors.CheckEdit()
			Me.comboBox1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label3 = New System.Windows.Forms.Label()
			Me.checkBox2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 70)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsView.AutoCalcPreviewLineCount = True
			Me.treeList1.OptionsView.ShowPreview = True
			Me.treeList1.Size = New System.Drawing.Size(558, 230)
			Me.treeList1.TabIndex = 6
'			Me.treeList1.GetPreviewText += New DevExpress.XtraTreeList.GetPreviewTextEventHandler(Me.treeList1_GetPreviewText);
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.checkBox3)
			Me.panel2.Controls.Add(Me.comboBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Controls.Add(Me.checkBox2)
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(558, 62)
			Me.panel2.TabIndex = 7
			' 
			' checkBox3
			' 
			Me.checkBox3.Location = New System.Drawing.Point(401, 30)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Properties.Caption = "Get Preview Text"
			Me.checkBox3.Size = New System.Drawing.Size(136, 18)
			Me.checkBox3.TabIndex = 4
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox3_CheckedChanged);
			' 
			' comboBox1
			' 
			Me.comboBox1.Location = New System.Drawing.Point(216, 30)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox1.Size = New System.Drawing.Size(168, 20)
			Me.comboBox1.TabIndex = 3
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(216, 14)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(120, 16)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Preview Field Name:"
			' 
			' checkBox2
			' 
			Me.checkBox2.Location = New System.Drawing.Point(12, 36)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Properties.Caption = "Auto Calc Preview Line Count"
			Me.checkBox2.Size = New System.Drawing.Size(164, 18)
			Me.checkBox2.TabIndex = 1
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox2_CheckedChanged);
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(12, 12)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Show Preview"
			Me.checkBox1.Size = New System.Drawing.Size(148, 18)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 62)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(558, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' Preview
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Preview"
			Me.Size = New System.Drawing.Size(558, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private panel2 As PanelControl
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox2 As DevExpress.XtraEditors.CheckEdit
		Private label3 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkBox3 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
