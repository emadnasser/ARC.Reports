Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class CompanyDetail
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
			Me.txtName = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtWebSite = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.txtCreatedOn = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.txtOID = New System.Windows.Forms.TextBox()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' txtName
			' 
			Me.txtName.Location = New System.Drawing.Point(96, 32)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New System.Drawing.Size(128, 20)
			Me.txtName.TabIndex = 0
			Me.txtName.Text = "txtName"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(88, 16)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Name:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 56)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(88, 16)
			Me.label2.TabIndex = 13
			Me.label2.Text = "WebSite:"
			' 
			' txtWebSite
			' 
			Me.txtWebSite.Location = New System.Drawing.Point(96, 56)
			Me.txtWebSite.Name = "txtWebSite"
			Me.txtWebSite.Size = New System.Drawing.Size(128, 20)
			Me.txtWebSite.TabIndex = 1
			Me.txtWebSite.Text = "txtWebSite"
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
			Me.label4.Text = "CreatedOn:"
			' 
			' txtCreatedOn
			' 
			Me.txtCreatedOn.Location = New System.Drawing.Point(96, 104)
			Me.txtCreatedOn.Name = "txtCreatedOn"
			Me.txtCreatedOn.ReadOnly = True
			Me.txtCreatedOn.Size = New System.Drawing.Size(128, 20)
			Me.txtCreatedOn.TabIndex = 3
			Me.txtCreatedOn.Text = "txtCreatedOn"
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
			' btnSave
			' 
			Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnSave.Location = New System.Drawing.Point(232, 8)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(70, 20)
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
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
			' CompanyDetail
			' 
			Me.AcceptButton = Me.btnSave
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(315, 135)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtOID)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.txtCreatedOn)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.txtPhoneNumber)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txtWebSite)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtName)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "CompanyDetail"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Company Details"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private theCompany As Company
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private txtPhoneNumber As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private txtOID As System.Windows.Forms.TextBox
		Private WithEvents btnSave As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private txtName As System.Windows.Forms.TextBox
		Private txtWebSite As System.Windows.Forms.TextBox
		Private txtCreatedOn As System.Windows.Forms.TextBox
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
