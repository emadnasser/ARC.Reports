Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ValueInfo
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
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.panelControl2)
			Me.groupControl1.Controls.Add(Me.panelControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(632, 68)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "Value Info"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Controls.Add(Me.textEdit3)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(350, 22)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Padding = New System.Windows.Forms.Padding(0, 3, 6, 0)
			Me.panelControl2.Size = New System.Drawing.Size(280, 44)
			Me.panelControl2.TabIndex = 14
			' 
			' textEdit3
			' 
			Me.textEdit3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.textEdit3.EditValue = "textEdit3"
			Me.textEdit3.Location = New System.Drawing.Point(0, 3)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Properties.ReadOnly = True
			Me.textEdit3.Size = New System.Drawing.Size(274, 20)
			Me.textEdit3.TabIndex = 12
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.textEdit2)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.label3)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.textEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(2, 22)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(348, 44)
			Me.panelControl1.TabIndex = 13
			' 
			' textEdit2
			' 
			Me.textEdit2.EditValue = "textEdit2"
			Me.textEdit2.Location = New System.Drawing.Point(64, 27)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.ReadOnly = True
			Me.textEdit2.Size = New System.Drawing.Size(186, 20)
			Me.textEdit2.TabIndex = 10
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Options.UseBackColor = True
			Me.label1.Location = New System.Drawing.Point(6, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(30, 13)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Value:"
			' 
			' label3
			' 
			Me.label3.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label3.Appearance.Options.UseBackColor = True
			Me.label3.Location = New System.Drawing.Point(262, 7)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(57, 13)
			Me.label3.TabIndex = 11
			Me.label3.Text = "Value Type:"
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Appearance.Options.UseBackColor = True
			Me.label2.Location = New System.Drawing.Point(6, 30)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(26, 13)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Field:"
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "textEdit1"
			Me.textEdit1.Location = New System.Drawing.Point(64, 3)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.ReadOnly = True
			Me.textEdit1.Size = New System.Drawing.Size(186, 20)
			Me.textEdit1.TabIndex = 9
			' 
			' ValueInfo
			' 
			Me.Controls.Add(Me.groupControl1)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ValueInfo"
			Me.Size = New System.Drawing.Size(632, 68)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
