Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace ContactManagement
	Public Partial Class ContactDetail
		Inherits System.Windows.Forms.Form
		Private Sub SetupBindings()
			txtOID.DataBindings.Add("Text", theContact, "Oid")
			txtFirstName.DataBindings.Add("Text", theContact, "FirstName")
			txtLastName.DataBindings.Add("Text", theContact, "LastName")
			txtPhoneNumber.DataBindings.Add("Text", theContact, "PhoneNumber")
			txtEmail.DataBindings.Add("Text", theContact, "Email")
			Dim collection As XPCollection = New XPCollection(theContact.Session, GetType(Company))
			collection.DisplayableProperties = "Name;This"
			cmbEmployer.DataSource = collection
			cmbEmployer.DisplayMember = "Name"
			cmbEmployer.ValueMember = "This"
			cmbEmployer.DataBindings.Add("SelectedValue", theContact, "Employer!")
		End Sub

		Public Property Contact() As Contact
			Get
				Return theContact
			End Get
			Set
				theContact = Value
				SetupBindings()
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal theContact As Contact)
			Me.New()
			Me.Contact = theContact
		End Sub

		Private Sub btnAddresses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddresses.Click
			Dim list As ObjectList = New ObjectList("Addresses", Me.Contact.Addresses, "Owner.DisplayName;Street;City;IsDefault")
			AddHandler list.OnInsertObject, AddressOf OnInsertAddress
			AddHandler list.OnEditObject, AddressOf OnEditAddress
			list.ShowDialog(Me)
		End Sub

		Private Sub btnDocs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocs.Click
			Dim list As ObjectList = New ObjectList("Attachments", Me.Contact.Attachments, "Owner.DisplayName;Name")
			AddHandler list.OnInsertObject, AddressOf OnInsertAttachment
			AddHandler list.OnEditObject, AddressOf OnEditAttachment
			list.ShowDialog(Me)
		End Sub
		Private Sub OnEditAttachment(ByVal sender As Object, ByVal e As EditObjectEventArgs)
			Dim attachmentDetailForm As AttachmentDetail = New AttachmentDetail()
			attachmentDetailForm.Attachment = CType(e.ObjectToEdit, Attachment)
			If attachmentDetailForm.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK Then
				CType(e.ObjectToEdit, Attachment).Reload()
			End If
		End Sub
		Private Sub OnInsertAttachment(ByVal sender As Object)
			Dim attachmentDetailForm As AttachmentDetail = New AttachmentDetail()
			Dim attach As Attachment = New Attachment(Contact.Session)
			attach.Owner = Contact
			attachmentDetailForm.Attachment = attach
			If attachmentDetailForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Me.Contact.Attachments.Add(attach)
			End If
		End Sub
		Private Sub OnEditAddress(ByVal sender As Object, ByVal e As EditObjectEventArgs)
			Dim addressDetailForm As AddressDetail = New AddressDetail()
			addressDetailForm.Address = CType(e.ObjectToEdit, Address)
			If addressDetailForm.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK Then
				CType(e.ObjectToEdit, Address).Reload()
			End If
		End Sub
		Private Sub OnInsertAddress(ByVal sender As Object)
			Dim addressDetailForm As AddressDetail = New AddressDetail()
			Dim address As Address = New Address(Contact.Session)
			address.Owner = Contact
			addressDetailForm.Address = address
			If addressDetailForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Me.Contact.Addresses.Add(address)
			End If
		End Sub
	End Class
End Namespace
