Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class ContactDetail

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
			Me.txtFirstName = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtLastName = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txtEmail = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.txtOID = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.cmbEmployer = New System.Windows.Forms.ComboBox()
			Me.btnAddresses = New System.Windows.Forms.Button()
			Me.btnDocs = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' txtFirstName
			' 
			Me.txtFirstName.Location = New System.Drawing.Point(96, 32)
			Me.txtFirstName.Name = "txtFirstName"
			Me.txtFirstName.Size = New System.Drawing.Size(128, 20)
			Me.txtFirstName.TabIndex = 0
			Me.txtFirstName.Text = "txtFirstName"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(88, 16)
			Me.label1.TabIndex = 14
			Me.label1.Text = "First Name:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 56)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(88, 16)
			Me.label2.TabIndex = 13
			Me.label2.Text = "Last Name:"
			' 
			' txtLastName
			' 
			Me.txtLastName.Location = New System.Drawing.Point(96, 56)
			Me.txtLastName.Name = "txtLastName"
			Me.txtLastName.Size = New System.Drawing.Size(128, 20)
			Me.txtLastName.TabIndex = 1
			Me.txtLastName.Text = "txtLastName"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 80)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(88, 16)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Phone Number:"
			' 
			' txtPhoneNumber
			' 
			Me.txtPhoneNumber.Location = New System.Drawing.Point(96, 80)
			Me.txtPhoneNumber.Name = "txtPhoneNumber"
			Me.txtPhoneNumber.Size = New System.Drawing.Size(128, 20)
			Me.txtPhoneNumber.TabIndex = 2
			Me.txtPhoneNumber.Text = "txtPhoneNumber"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(8, 104)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(88, 16)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Email:"
			' 
			' txtEmail
			' 
			Me.txtEmail.Location = New System.Drawing.Point(96, 104)
			Me.txtEmail.Name = "txtEmail"
			Me.txtEmail.Size = New System.Drawing.Size(128, 20)
			Me.txtEmail.TabIndex = 3
			Me.txtEmail.Text = "txtEmail"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(8, 8)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(88, 16)
			Me.label5.TabIndex = 9
			Me.label5.Text = "ID:"
			' 
			' txtOID
			' 
			Me.txtOID.Location = New System.Drawing.Point(96, 8)
			Me.txtOID.Name = "txtOID"
			Me.txtOID.ReadOnly = True
			Me.txtOID.Size = New System.Drawing.Size(128, 20)
			Me.txtOID.TabIndex = 9
			Me.txtOID.Text = "txtOID"
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(8, 128)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(88, 16)
			Me.label6.TabIndex = 11
			Me.label6.Text = "Employer:"
			' 
			' btnSave
			' 
			Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnSave.Location = New System.Drawing.Point(232, 8)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(70, 20)
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(232, 40)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(70, 20)
			Me.btnCancel.TabIndex = 6
			Me.btnCancel.Text = "&Cancel"
			' 
			' cmbEmployer
			' 
			Me.cmbEmployer.Location = New System.Drawing.Point(96, 128)
			Me.cmbEmployer.Name = "cmbEmployer"
			Me.cmbEmployer.Size = New System.Drawing.Size(128, 21)
			Me.cmbEmployer.TabIndex = 4
			Me.cmbEmployer.Text = "cmbEmployer"
			' 
			' btnAddresses
			' 
			Me.btnAddresses.Location = New System.Drawing.Point(232, 72)
			Me.btnAddresses.Name = "btnAddresses"
			Me.btnAddresses.Size = New System.Drawing.Size(70, 20)
			Me.btnAddresses.TabIndex = 7
			Me.btnAddresses.Text = "Addresses"
'			Me.btnAddresses.Click += New System.EventHandler(Me.btnAddresses_Click);
			' 
			' btnDocs
			' 
			Me.btnDocs.Location = New System.Drawing.Point(232, 104)
			Me.btnDocs.Name = "btnDocs"
			Me.btnDocs.Size = New System.Drawing.Size(70, 20)
			Me.btnDocs.TabIndex = 8
			Me.btnDocs.Text = "Docs"
'			Me.btnDocs.Click += New System.EventHandler(Me.btnDocs_Click);
			' 
			' ContactDetail
			' 
			Me.AcceptButton = Me.btnSave
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(315, 155)
			Me.Controls.Add(Me.btnDocs)
			Me.Controls.Add(Me.btnAddresses)
			Me.Controls.Add(Me.cmbEmployer)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtOID)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.txtEmail)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.txtPhoneNumber)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txtLastName)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtFirstName)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ContactDetail"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Contact Details"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private theContact As Contact
		Private label1 As System.Windows.Forms.Label
		Private txtFirstName As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txtLastName As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private txtPhoneNumber As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private txtEmail As System.Windows.Forms.TextBox
		Private label5 As System.Windows.Forms.Label
		Private txtOID As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private btnSave As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private cmbEmployer As System.Windows.Forms.ComboBox
		Private WithEvents btnAddresses As System.Windows.Forms.Button
		Private WithEvents btnDocs As System.Windows.Forms.Button
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
