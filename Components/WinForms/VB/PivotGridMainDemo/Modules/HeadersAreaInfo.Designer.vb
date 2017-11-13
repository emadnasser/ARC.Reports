Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class HeadersAreaInfo
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
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' textEdit2
			' 
			Me.textEdit2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textEdit2.EditValue = "textEdit2"
			Me.textEdit2.Location = New System.Drawing.Point(66, 49)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.ReadOnly = True
			Me.textEdit2.Size = New System.Drawing.Size(515, 20)
			Me.textEdit2.TabIndex = 10
			' 
			' textEdit1
			' 
			Me.textEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textEdit1.EditValue = "textEdit1"
			Me.textEdit1.Location = New System.Drawing.Point(66, 25)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.ReadOnly = True
			Me.textEdit1.Size = New System.Drawing.Size(515, 20)
			Me.textEdit1.TabIndex = 9
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Appearance.Options.UseBackColor = True
			Me.label2.Location = New System.Drawing.Point(8, 52)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(26, 13)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Field:"
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Options.UseBackColor = True
			Me.label1.Location = New System.Drawing.Point(8, 28)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(27, 13)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Area:"
			' 
			' groupControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.groupControl1.Controls.Add(Me.textEdit2)
			Me.groupControl1.Controls.Add(Me.textEdit1)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(589, 68)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "HeadersArea Info"
			' 
			' HeadersAreaInfo
			' 
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "HeadersAreaInfo"
			Me.Size = New System.Drawing.Size(589, 68)
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
