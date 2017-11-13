Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class AttachmentDetail
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
			Me.label5 = New System.Windows.Forms.Label()
			Me.txtOID = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtAttachmentName = New System.Windows.Forms.TextBox()
			Me.txtDocument = New System.Windows.Forms.RichTextBox()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.btnLoad = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(8, 8)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(88, 16)
			Me.label5.TabIndex = 17
			Me.label5.Text = "ID:"
			' 
			' txtOID
			' 
			Me.txtOID.Location = New System.Drawing.Point(96, 8)
			Me.txtOID.Name = "txtOID"
			Me.txtOID.ReadOnly = True
			Me.txtOID.Size = New System.Drawing.Size(128, 20)
			Me.txtOID.TabIndex = 5
			Me.txtOID.Text = "txtOID"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(88, 16)
			Me.label1.TabIndex = 18
			Me.label1.Text = "Name"
			' 
			' txtAttachmentName
			' 
			Me.txtAttachmentName.Location = New System.Drawing.Point(96, 32)
			Me.txtAttachmentName.Name = "txtAttachmentName"
			Me.txtAttachmentName.Size = New System.Drawing.Size(328, 20)
			Me.txtAttachmentName.TabIndex = 0
			' 
			' txtDocument
			' 
			Me.txtDocument.AcceptsTab = True
			Me.txtDocument.Location = New System.Drawing.Point(8, 56)
			Me.txtDocument.Name = "txtDocument"
			Me.txtDocument.Size = New System.Drawing.Size(416, 336)
			Me.txtDocument.TabIndex = 1
			Me.txtDocument.Text = ""
			' 
			' btnSave
			' 
			Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnSave.Location = New System.Drawing.Point(272, 400)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(70, 20)
			Me.btnSave.TabIndex = 3
			Me.btnSave.Text = "&Save"
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(352, 400)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(70, 20)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "&Cancel"
			' 
			' btnLoad
			' 
			Me.btnLoad.Location = New System.Drawing.Point(192, 400)
			Me.btnLoad.Name = "btnLoad"
			Me.btnLoad.Size = New System.Drawing.Size(70, 20)
			Me.btnLoad.TabIndex = 2
			Me.btnLoad.Text = "&Load"
'			Me.btnLoad.Click += New System.EventHandler(Me.btnLoad_Click);
			' 
			' AttachmentDetail
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(433, 429)
			Me.Controls.Add(Me.btnLoad)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.txtDocument)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtOID)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtAttachmentName)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "AttachmentDetail"
			Me.Text = "Attachment Detail"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private theAttachment As Attachment
		Private label5 As System.Windows.Forms.Label
		Private txtOID As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private txtAttachmentName As System.Windows.Forms.TextBox
		Private txtDocument As System.Windows.Forms.RichTextBox
		Private WithEvents btnSave As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private WithEvents btnLoad As System.Windows.Forms.Button
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
