Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CellInfo
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
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.panelControl2)
			Me.groupControl1.Controls.Add(Me.panelControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(598, 68)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "Cell Info"
			' 
			' textEdit4
			' 
			Me.textEdit4.Dock = System.Windows.Forms.DockStyle.Top
			Me.textEdit4.EditValue = "textEdit4"
			Me.textEdit4.Location = New System.Drawing.Point(0, 26)
			Me.textEdit4.Name = "textEdit4"
			Me.textEdit4.Properties.ReadOnly = True
			Me.textEdit4.Size = New System.Drawing.Size(192, 20)
			Me.textEdit4.TabIndex = 14
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(262, 31)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(59, 13)
			Me.label4.TabIndex = 13
			Me.label4.Text = "Data Field:"
			Me.label4.BackColor = System.Drawing.Color.Transparent
			' 
			' textEdit3
			' 
			Me.textEdit3.Dock = System.Windows.Forms.DockStyle.Top
			Me.textEdit3.EditValue = "textEdit3"
			Me.textEdit3.Location = New System.Drawing.Point(0, 2)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Properties.ReadOnly = True
			Me.textEdit3.Size = New System.Drawing.Size(192, 20)
			Me.textEdit3.TabIndex = 12
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(262, 7)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(116, 13)
			Me.label3.TabIndex = 11
			Me.label3.Text = "Column, Row Indexes:"
			Me.label3.BackColor = System.Drawing.Color.Transparent
			' 
			' textEdit2
			' 
			Me.textEdit2.EditValue = "textEdit2"
			Me.textEdit2.Location = New System.Drawing.Point(98, 27)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.ReadOnly = True
			Me.textEdit2.Size = New System.Drawing.Size(152, 20)
			Me.textEdit2.TabIndex = 10
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "textEdit1"
			Me.textEdit1.Location = New System.Drawing.Point(98, 3)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.ReadOnly = True
			Me.textEdit1.Size = New System.Drawing.Size(152, 20)
			Me.textEdit1.TabIndex = 9
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(6, 31)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(37, 13)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Value:"
			Me.label2.BackColor = System.Drawing.Color.Transparent
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(6, 7)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(70, 13)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Display Text:"
			Me.label1.BackColor = System.Drawing.Color.Transparent
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.label3)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.label4)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.textEdit1)
			Me.panelControl1.Controls.Add(Me.textEdit2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(2, 20)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(398, 46)
			Me.panelControl1.TabIndex = 15
			Me.panelControl1.Text = "panelControl1"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.textEdit4)
			Me.panelControl2.Controls.Add(Me.panelControl3)
			Me.panelControl2.Controls.Add(Me.textEdit3)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(400, 20)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Padding = New System.Windows.Forms.Padding(0, 2, 4, 0)
			Me.panelControl2.Size = New System.Drawing.Size(196, 46)
			Me.panelControl2.TabIndex = 16
			Me.panelControl2.Text = "panelControl2"
			' 
			' panelControl3
			' 
			Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl3.Location = New System.Drawing.Point(0, 22)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(192, 4)
			Me.panelControl3.TabIndex = 15
			Me.panelControl3.Text = "panelControl3"
			' 
			' CellInfo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "CellInfo"
			Me.Size = New System.Drawing.Size(598, 68)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private textEdit4 As DevExpress.XtraEditors.TextEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl3 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
