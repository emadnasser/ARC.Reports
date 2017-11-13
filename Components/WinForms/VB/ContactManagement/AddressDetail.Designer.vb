Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class AddressDetail
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
			Me.txtOwner = New System.Windows.Forms.TextBox()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.label2 = New System.Windows.Forms.Label()
			Me.txtStreet = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.txtCity = New System.Windows.Forms.TextBox()
			Me.chkDefault = New System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(8, 8)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(56, 16)
			Me.label5.TabIndex = 17
			Me.label5.Text = "ID:"
			' 
			' txtOID
			' 
			Me.txtOID.Location = New System.Drawing.Point(96, 8)
			Me.txtOID.Name = "txtOID"
			Me.txtOID.ReadOnly = True
			Me.txtOID.Size = New System.Drawing.Size(128, 20)
			Me.txtOID.TabIndex = 7
			Me.txtOID.Text = "txtOID"
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(56, 16)
			Me.label1.TabIndex = 18
			Me.label1.Text = "Owner:"
			' 
			' txtOwner
			' 
			Me.txtOwner.Location = New System.Drawing.Point(96, 32)
			Me.txtOwner.Name = "txtOwner"
			Me.txtOwner.ReadOnly = True
			Me.txtOwner.Size = New System.Drawing.Size(128, 20)
			Me.txtOwner.TabIndex = 1
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
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 56)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(56, 16)
			Me.label2.TabIndex = 24
			Me.label2.Text = "Street:"
			' 
			' txtStreet
			' 
			Me.txtStreet.Location = New System.Drawing.Point(96, 56)
			Me.txtStreet.Name = "txtStreet"
			Me.txtStreet.Size = New System.Drawing.Size(128, 20)
			Me.txtStreet.TabIndex = 2
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 80)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(56, 16)
			Me.label3.TabIndex = 26
			Me.label3.Text = "City:"
			' 
			' txtCity
			' 
			Me.txtCity.Location = New System.Drawing.Point(96, 80)
			Me.txtCity.Name = "txtCity"
			Me.txtCity.Size = New System.Drawing.Size(128, 20)
			Me.txtCity.TabIndex = 3
			' 
			' chkDefault
			' 
			Me.chkDefault.Location = New System.Drawing.Point(96, 104)
			Me.chkDefault.Name = "chkDefault"
			Me.chkDefault.Size = New System.Drawing.Size(168, 24)
			Me.chkDefault.TabIndex = 4
			Me.chkDefault.Text = "Is Default"
			' 
			' AddressDetail
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(316, 135)
			Me.Controls.Add(Me.chkDefault)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.txtCity)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txtStreet)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.txtOID)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.txtOwner)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "AddressDetail"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Address Detail"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private theAddress As Address
		Private label5 As System.Windows.Forms.Label
		Private txtOID As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents btnSave As System.Windows.Forms.Button
		Private btnCancel As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private txtOwner As System.Windows.Forms.TextBox
		Private txtStreet As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private txtCity As System.Windows.Forms.TextBox
		Private chkDefault As System.Windows.Forms.CheckBox
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
