Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetMailMergeModule
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
			Me.phone = New DevExpress.XtraEditors.LabelControl()
			Me.state = New DevExpress.XtraEditors.LabelControl()
			Me.email = New DevExpress.XtraEditors.LabelControl()
			Me.phoneTE = New DevExpress.XtraEditors.TextEdit()
			Me.stateAddressTE = New DevExpress.XtraEditors.TextEdit()
			Me.emailTE = New DevExpress.XtraEditors.TextEdit()
			Me.zipCode = New DevExpress.XtraEditors.LabelControl()
			Me.zipCodeTE = New DevExpress.XtraEditors.TextEdit()
			Me.statementNumber = New DevExpress.XtraEditors.LabelControl()
			Me.statementNumberTE = New DevExpress.XtraEditors.TextEdit()
			Me.customerID = New DevExpress.XtraEditors.LabelControl()
			Me.customerIDTE = New DevExpress.XtraEditors.TextEdit()
			Me.namelbl = New DevExpress.XtraEditors.LabelControl()
			Me.nameTE = New DevExpress.XtraEditors.TextEdit()
			Me.streetAddress = New DevExpress.XtraEditors.LabelControl()
			Me.streetAddressTE = New DevExpress.XtraEditors.TextEdit()
			Me.cityAddress = New DevExpress.XtraEditors.LabelControl()
			Me.cityAddressTE = New DevExpress.XtraEditors.TextEdit()
			CType(Me.phoneTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stateAddressTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emailTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zipCodeTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statementNumberTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customerIDTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nameTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.streetAddressTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cityAddressTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' phone
			' 
			Me.phone.Location = New System.Drawing.Point(474, 33)
			Me.phone.Name = "phone"
			Me.phone.Size = New System.Drawing.Size(34, 13)
			Me.phone.TabIndex = 24
			Me.phone.Text = "Phone:"
			' 
			' state
			' 
			Me.state.Location = New System.Drawing.Point(249, 56)
			Me.state.Name = "state"
			Me.state.Size = New System.Drawing.Size(30, 13)
			Me.state.TabIndex = 25
			Me.state.Text = "State:"
			' 
			' email
			' 
			Me.email.Location = New System.Drawing.Point(474, 56)
			Me.email.Name = "email"
			Me.email.Size = New System.Drawing.Size(32, 13)
			Me.email.TabIndex = 26
			Me.email.Text = "E-mail:"
			' 
			' phoneTE
			' 
			Me.phoneTE.EditValue = "(206)555-812"
			Me.phoneTE.Location = New System.Drawing.Point(526, 30)
			Me.phoneTE.Name = "phoneTE"
			Me.phoneTE.Size = New System.Drawing.Size(125, 20)
			Me.phoneTE.TabIndex = 6
'			Me.phoneTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' stateAddressTE
			' 
			Me.stateAddressTE.EditValue = "WA"
			Me.stateAddressTE.Location = New System.Drawing.Point(329, 53)
			Me.stateAddressTE.Name = "stateAddressTE"
			Me.stateAddressTE.Size = New System.Drawing.Size(125, 20)
			Me.stateAddressTE.TabIndex = 5
'			Me.stateAddressTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' emailTE
			' 
			Me.emailTE.EditValue = "mpeacock@example.net"
			Me.emailTE.Location = New System.Drawing.Point(526, 53)
			Me.emailTE.Name = "emailTE"
			Me.emailTE.Size = New System.Drawing.Size(125, 20)
			Me.emailTE.TabIndex = 8
'			Me.emailTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' zipCode
			' 
			Me.zipCode.Location = New System.Drawing.Point(474, 10)
			Me.zipCode.Name = "zipCode"
			Me.zipCode.Size = New System.Drawing.Size(48, 13)
			Me.zipCode.TabIndex = 0
			Me.zipCode.Text = "ZIP Code:"
			' 
			' zipCodeTE
			' 
			Me.zipCodeTE.EditValue = "98052"
			Me.zipCodeTE.Location = New System.Drawing.Point(526, 7)
			Me.zipCodeTE.Name = "zipCodeTE"
			Me.zipCodeTE.Size = New System.Drawing.Size(125, 20)
			Me.zipCodeTE.TabIndex = 6
'			Me.zipCodeTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' statementNumber
			' 
			Me.statementNumber.Location = New System.Drawing.Point(6, 10)
			Me.statementNumber.Name = "statementNumber"
			Me.statementNumber.Size = New System.Drawing.Size(94, 13)
			Me.statementNumber.TabIndex = 12
			Me.statementNumber.Text = "Statement Number:"
			' 
			' statementNumberTE
			' 
			Me.statementNumberTE.EditValue = "No."
			Me.statementNumberTE.Location = New System.Drawing.Point(104, 7)
			Me.statementNumberTE.Name = "statementNumberTE"
			Me.statementNumberTE.Size = New System.Drawing.Size(125, 20)
			Me.statementNumberTE.TabIndex = 0
'			Me.statementNumberTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' customerID
			' 
			Me.customerID.Location = New System.Drawing.Point(6, 33)
			Me.customerID.Name = "customerID"
			Me.customerID.Size = New System.Drawing.Size(64, 13)
			Me.customerID.TabIndex = 14
			Me.customerID.Text = "Customer ID:"
			' 
			' customerIDTE
			' 
			Me.customerIDTE.EditValue = "ABC12345"
			Me.customerIDTE.Location = New System.Drawing.Point(104, 30)
			Me.customerIDTE.Name = "customerIDTE"
			Me.customerIDTE.Size = New System.Drawing.Size(125, 20)
			Me.customerIDTE.TabIndex = 1
'			Me.customerIDTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' name
			' 
			Me.namelbl.Location = New System.Drawing.Point(6, 56)
			Me.namelbl.Name = "name"
			Me.namelbl.Size = New System.Drawing.Size(80, 13)
			Me.namelbl.TabIndex = 16
			Me.namelbl.Text = "Customer Name:"
			' 
			' nameTE
			' 
			Me.nameTE.EditValue = "Margaret Peacock"
			Me.nameTE.Location = New System.Drawing.Point(104, 53)
			Me.nameTE.Name = "nameTE"
			Me.nameTE.Size = New System.Drawing.Size(125, 20)
			Me.nameTE.TabIndex = 2
'			Me.nameTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' streetAddress
			' 
			Me.streetAddress.Location = New System.Drawing.Point(249, 10)
			Me.streetAddress.Name = "streetAddress"
			Me.streetAddress.Size = New System.Drawing.Size(76, 13)
			Me.streetAddress.TabIndex = 20
			Me.streetAddress.Text = "Street Address:"
			' 
			' streetAddressTE
			' 
			Me.streetAddressTE.EditValue = "NE 74th St, Town Center"
			Me.streetAddressTE.Location = New System.Drawing.Point(329, 7)
			Me.streetAddressTE.Name = "streetAddressTE"
			Me.streetAddressTE.Size = New System.Drawing.Size(125, 20)
			Me.streetAddressTE.TabIndex = 3
'			Me.streetAddressTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' cityAddress
			' 
			Me.cityAddress.Location = New System.Drawing.Point(249, 33)
			Me.cityAddress.Name = "cityAddress"
			Me.cityAddress.Size = New System.Drawing.Size(23, 13)
			Me.cityAddress.TabIndex = 22
			Me.cityAddress.Text = "City:"
			' 
			' cityAddressTE
			' 
			Me.cityAddressTE.EditValue = "Redmond"
			Me.cityAddressTE.Location = New System.Drawing.Point(329, 30)
			Me.cityAddressTE.Name = "cityAddressTE"
			Me.cityAddressTE.Size = New System.Drawing.Size(125, 20)
			Me.cityAddressTE.TabIndex = 4
'			Me.cityAddressTE.EditValueChanged += New System.EventHandler(Me.textEdit_EditValueChanged);
			' 
			' MailMergeModule
			' 
			Me.Controls.Add(Me.statementNumber)
			Me.Controls.Add(Me.statementNumberTE)
			Me.Controls.Add(Me.customerID)
			Me.Controls.Add(Me.customerIDTE)
			Me.Controls.Add(Me.namelbl)
			Me.Controls.Add(Me.nameTE)
			Me.Controls.Add(Me.streetAddress)
			Me.Controls.Add(Me.streetAddressTE)
			Me.Controls.Add(Me.cityAddress)
			Me.Controls.Add(Me.cityAddressTE)
			Me.Controls.Add(Me.zipCode)
			Me.Controls.Add(Me.zipCodeTE)
			Me.Controls.Add(Me.phone)
			Me.Controls.Add(Me.state)
			Me.Controls.Add(Me.email)
			Me.Controls.Add(Me.phoneTE)
			Me.Controls.Add(Me.stateAddressTE)
			Me.Controls.Add(Me.emailTE)
			Me.Name = "MailMergeModule"
			Me.Controls.SetChildIndex(Me.emailTE, 0)
			Me.Controls.SetChildIndex(Me.stateAddressTE, 0)
			Me.Controls.SetChildIndex(Me.phoneTE, 0)
			Me.Controls.SetChildIndex(Me.email, 0)
			Me.Controls.SetChildIndex(Me.state, 0)
			Me.Controls.SetChildIndex(Me.phone, 0)
			Me.Controls.SetChildIndex(Me.zipCodeTE, 0)
			Me.Controls.SetChildIndex(Me.zipCode, 0)
			Me.Controls.SetChildIndex(Me.cityAddressTE, 0)
			Me.Controls.SetChildIndex(Me.cityAddress, 0)
			Me.Controls.SetChildIndex(Me.streetAddressTE, 0)
			Me.Controls.SetChildIndex(Me.streetAddress, 0)
			Me.Controls.SetChildIndex(Me.nameTE, 0)
			Me.Controls.SetChildIndex(Me.namelbl, 0)
			Me.Controls.SetChildIndex(Me.customerIDTE, 0)
			Me.Controls.SetChildIndex(Me.customerID, 0)
			Me.Controls.SetChildIndex(Me.statementNumberTE, 0)
			Me.Controls.SetChildIndex(Me.statementNumber, 0)
			CType(Me.phoneTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stateAddressTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emailTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zipCodeTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statementNumberTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customerIDTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nameTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.streetAddressTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cityAddressTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private statementNumber As LabelControl
		Private customerID As LabelControl
		Private namelbl As LabelControl
		Private streetAddress As LabelControl
		Private cityAddress As LabelControl
		Private zipCode As LabelControl
		Private phone As LabelControl
		Private state As LabelControl
		Private email As LabelControl
		Private WithEvents statementNumberTE As TextEdit
		Private WithEvents customerIDTE As TextEdit
		Private WithEvents nameTE As TextEdit
		Private WithEvents streetAddressTE As TextEdit
		Private WithEvents cityAddressTE As TextEdit
		Private WithEvents stateAddressTE As TextEdit
		Private WithEvents zipCodeTE As TextEdit
		Private WithEvents phoneTE As TextEdit
		Private WithEvents emailTE As TextEdit
	End Class
End Namespace
