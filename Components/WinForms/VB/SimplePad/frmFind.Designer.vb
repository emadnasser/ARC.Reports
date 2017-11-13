Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.SimplePad
	Public Partial Class frmFind

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.chWholeword = New DevExpress.XtraEditors.CheckEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.btnFindNext = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.txtFind = New DevExpress.XtraEditors.TextEdit()
			Me.chCase = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.chWholeword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chWholeword
			' 
			Me.chWholeword.Location = New System.Drawing.Point(8, 32)
			Me.chWholeword.Name = "chWholeword"
			Me.chWholeword.Properties.Caption = "Match whole word only"
			Me.chWholeword.Size = New System.Drawing.Size(164, 19)
			Me.chWholeword.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(51, 13)
			Me.label1.TabIndex = 10
			Me.label1.Text = "Find what:"
			' 
			' btnFindNext
			' 
			Me.btnFindNext.Location = New System.Drawing.Point(248, 4)
			Me.btnFindNext.Name = "btnFindNext"
			Me.btnFindNext.Size = New System.Drawing.Size(92, 24)
			Me.btnFindNext.TabIndex = 3
			Me.btnFindNext.Text = "&Find Next"
'			Me.btnFindNext.Click += New System.EventHandler(Me.btnFindNext_Click);
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(248, 36)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(92, 24)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "&Cancel"
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click);
			' 
			' txtFind
			' 
			Me.txtFind.EditValue = ""
			Me.txtFind.Location = New System.Drawing.Point(80, 4)
			Me.txtFind.Name = "txtFind"
			Me.txtFind.Size = New System.Drawing.Size(156, 20)
			Me.txtFind.TabIndex = 0
'			Me.txtFind.TextChanged += New System.EventHandler(Me.txtFind_TextChanged);
			' 
			' chCase
			' 
			Me.chCase.Location = New System.Drawing.Point(8, 56)
			Me.chCase.Name = "chCase"
			Me.chCase.Properties.Caption = "Match case"
			Me.chCase.Size = New System.Drawing.Size(164, 19)
			Me.chCase.TabIndex = 2
			' 
			' frmFind
			' 
			Me.AcceptButton = Me.btnFindNext
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(349, 82)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnFindNext)
			Me.Controls.Add(Me.chCase)
			Me.Controls.Add(Me.chWholeword)
			Me.Controls.Add(Me.txtFind)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.Name = "frmFind"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "Find "
			Me.TopMost = True
			CType(Me.chWholeword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private chWholeword As DevExpress.XtraEditors.CheckEdit
		Private WithEvents txtFind As DevExpress.XtraEditors.TextEdit
		Private WithEvents btnFindNext As DevExpress.XtraEditors.SimpleButton
		Private chCase As DevExpress.XtraEditors.CheckEdit
		Private WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
		Private label1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace