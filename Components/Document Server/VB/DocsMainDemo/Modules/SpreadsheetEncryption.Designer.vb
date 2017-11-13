Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetEncryption
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.passwordLabel = New DevExpress.XtraEditors.LabelControl()
			Me.typeLabel = New DevExpress.XtraEditors.LabelControl()
			Me.passwordEdit = New DevExpress.XtraEditors.TextEdit()
			Me.typeEdit = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.passwordEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.typeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' passwordLabel
			' 
			Me.passwordLabel.Location = New System.Drawing.Point(5, 8)
			Me.passwordLabel.Name = "passwordLabel"
			Me.passwordLabel.Size = New System.Drawing.Size(50, 13)
			Me.passwordLabel.TabIndex = 8
			Me.passwordLabel.Text = "Password:"
			' 
			' typeLabel
			' 
			Me.typeLabel.Location = New System.Drawing.Point(215, 8)
			Me.typeLabel.Name = "typeLabel"
			Me.typeLabel.Size = New System.Drawing.Size(28, 13)
			Me.typeLabel.TabIndex = 10
			Me.typeLabel.Text = "Type:"
			' 
			' passwordEdit
			' 
			Me.passwordEdit.Location = New System.Drawing.Point(60, 5)
			Me.passwordEdit.Name = "passwordEdit"
			Me.passwordEdit.Properties.MaxLength = 255
			Me.passwordEdit.Size = New System.Drawing.Size(120, 20)
			Me.passwordEdit.TabIndex = 34
			' 
			' typeEdit
			' 
			Me.typeEdit.Location = New System.Drawing.Point(248, 5)
			Me.typeEdit.Name = "typeEdit"
			Me.typeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.typeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.typeEdit.Size = New System.Drawing.Size(120, 20)
			Me.typeEdit.TabIndex = 34
			' 
			' SpreadsheetEncryption
			' 
			Me.Controls.Add(Me.passwordLabel)
			Me.Controls.Add(Me.typeLabel)
			Me.Controls.Add(Me.passwordEdit)
			Me.Controls.Add(Me.typeEdit)
			Me.Name = "SpreadsheetEncryption"
			Me.Controls.SetChildIndex(Me.typeEdit, 0)
			Me.Controls.SetChildIndex(Me.passwordEdit, 0)
			Me.Controls.SetChildIndex(Me.typeLabel, 0)
			Me.Controls.SetChildIndex(Me.passwordLabel, 0)
			CType(Me.passwordEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.typeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private passwordLabel As LabelControl
		Private typeLabel As LabelControl
		Private passwordEdit As TextEdit
		Private typeEdit As ComboBoxEdit
	End Class
End Namespace
