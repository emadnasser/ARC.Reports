Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.SimplePad
	Public Partial Class frmReplace

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.btnReplace = New DevExpress.XtraEditors.SimpleButton()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.chCase = New DevExpress.XtraEditors.CheckEdit()
			Me.txtFind = New DevExpress.XtraEditors.TextEdit()
			Me.chWholeword = New DevExpress.XtraEditors.CheckEdit()
			Me.btnReplaceAll = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFindNext = New DevExpress.XtraEditors.SimpleButton()
			Me.txtReplace = New DevExpress.XtraEditors.TextEdit()
			CType(Me.chCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chWholeword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtReplace.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnReplace
			' 
			Me.btnReplace.Location = New System.Drawing.Point(256, 32)
			Me.btnReplace.Name = "btnReplace"
			Me.btnReplace.Size = New System.Drawing.Size(92, 24)
			Me.btnReplace.TabIndex = 5
			Me.btnReplace.Text = "&Replace"
'			Me.btnReplace.Click += New System.EventHandler(Me.btnReplace_Click);
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(51, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Find what:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 36)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(65, 13)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Replace with:"
			' 
			' chCase
			' 
			Me.chCase.Location = New System.Drawing.Point(8, 88)
			Me.chCase.Name = "chCase"
			Me.chCase.Properties.Caption = "Match case"
			Me.chCase.Size = New System.Drawing.Size(164, 19)
			Me.chCase.TabIndex = 3
			' 
			' txtFind
			' 
			Me.txtFind.EditValue = ""
			Me.txtFind.Location = New System.Drawing.Point(88, 4)
			Me.txtFind.Name = "txtFind"
			Me.txtFind.Size = New System.Drawing.Size(156, 20)
			Me.txtFind.TabIndex = 0
'			Me.txtFind.TextChanged += New System.EventHandler(Me.txtFind_TextChanged);
			' 
			' chWholeword
			' 
			Me.chWholeword.Location = New System.Drawing.Point(8, 64)
			Me.chWholeword.Name = "chWholeword"
			Me.chWholeword.Properties.Caption = "Match whole word only"
			Me.chWholeword.Size = New System.Drawing.Size(164, 19)
			Me.chWholeword.TabIndex = 2
			' 
			' btnReplaceAll
			' 
			Me.btnReplaceAll.Location = New System.Drawing.Point(256, 60)
			Me.btnReplaceAll.Name = "btnReplaceAll"
			Me.btnReplaceAll.Size = New System.Drawing.Size(92, 24)
			Me.btnReplaceAll.TabIndex = 6
			Me.btnReplaceAll.Text = "Replace A&ll"
'			Me.btnReplaceAll.Click += New System.EventHandler(Me.btnReplaceAll_Click);
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(256, 92)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(92, 24)
			Me.btnCancel.TabIndex = 7
			Me.btnCancel.Text = "&Cancel"
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click);
			' 
			' btnFindNext
			' 
			Me.btnFindNext.Location = New System.Drawing.Point(256, 4)
			Me.btnFindNext.Name = "btnFindNext"
			Me.btnFindNext.Size = New System.Drawing.Size(92, 24)
			Me.btnFindNext.TabIndex = 4
			Me.btnFindNext.Text = "&Find Next"
'			Me.btnFindNext.Click += New System.EventHandler(Me.btnFindNext_Click);
			' 
			' txtReplace
			' 
			Me.txtReplace.EditValue = ""
			Me.txtReplace.Location = New System.Drawing.Point(88, 32)
			Me.txtReplace.Name = "txtReplace"
			Me.txtReplace.Size = New System.Drawing.Size(156, 20)
			Me.txtReplace.TabIndex = 1
			' 
			' frmReplace
			' 
			Me.AcceptButton = Me.btnFindNext
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(360, 130)
			Me.Controls.Add(Me.btnReplaceAll)
			Me.Controls.Add(Me.btnReplace)
			Me.Controls.Add(Me.txtReplace)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnFindNext)
			Me.Controls.Add(Me.chCase)
			Me.Controls.Add(Me.chWholeword)
			Me.Controls.Add(Me.txtFind)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.Name = "frmReplace"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "Replace"
			Me.TopMost = True
			CType(Me.chCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtFind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chWholeword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtReplace.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private chWholeword As DevExpress.XtraEditors.CheckEdit
		Private WithEvents txtFind As DevExpress.XtraEditors.TextEdit
		Private WithEvents btnFindNext As DevExpress.XtraEditors.SimpleButton
		Private chCase As DevExpress.XtraEditors.CheckEdit
		Private WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private txtReplace As DevExpress.XtraEditors.TextEdit
		Private WithEvents btnReplaceAll As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnReplace As DevExpress.XtraEditors.SimpleButton
		Private label1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
