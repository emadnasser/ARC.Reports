Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection

Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ContactManagement
	Public Partial Class MainForm
		Inherits System.Windows.Forms.Form
		Public Sub New()
			InitializeComponent()
			UpdateMenu()
		End Sub

		Private Sub UpdateMenu()
			mnuDeleteContact.Enabled = gridContacts.CurrentRowIndex >= 0
			mnuProperties.Enabled = mnuDeleteContact.Enabled
		End Sub
		Private Sub RefreshGrid()
			contacts.Reload()
			gridContacts.Refresh()
		End Sub
		Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
			Close()
		End Sub

		Private Sub EditContact(ByVal theContact As Contact)
			Dim detailForm As ContactDetail = New ContactDetail(theContact)
			If detailForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				theContact.Save()
				RefreshGrid()
			Else
				If (Not session.IsNewObject(theContact)) Then
					theContact.Reload()
				End If
			End If
		End Sub

		Private Sub mnuAddContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAddContact.Click
			EditContact(New Contact(session))
			UpdateMenu()
		End Sub

		Private Sub mnuProperties_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuProperties.Click
			If gridContacts.CurrentRowIndex >= 0 Then
				EditContact(CType(contacts(gridContacts.CurrentRowIndex), Contact))
			End If
		End Sub

		Private Sub gridContacts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridContacts.KeyDown
			If e.KeyCode = Keys.Enter Then
				mnuProperties_Click(Nothing, Nothing)
			End If
		End Sub

		Private Sub OnEditCompany(ByVal sender As Object, ByVal e As EditObjectEventArgs)
			Dim companyDetailForm As CompanyDetail = New CompanyDetail()
			companyDetailForm.Company = CType(e.ObjectToEdit, Company)
			If companyDetailForm.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK Then
				CType(e.ObjectToEdit, Company).Reload()
			End If
		End Sub
		Private Sub OnInsertCompany(ByVal sender As Object)
			Dim companyDetailForm As CompanyDetail = New CompanyDetail()
			companyDetailForm.Company = New Company(session)
			companyDetailForm.ShowDialog(Me)
		End Sub

		Private Sub mnuCompanies_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCompanies.Click
			Try
				Dim list As ObjectList = New ObjectList("Companies", session, GetType(Company), Nothing, "Name;WebSite;PhoneNumber;CreatedOn")
				AddHandler list.OnInsertObject, AddressOf OnInsertCompany
				AddHandler list.OnEditObject, AddressOf OnEditCompany
				list.ShowDialog(Me)
				RefreshGrid()
			Catch ex As RequiredPropertyValueMissing
				System.Windows.Forms.MessageBox.Show(Me, ex.Message)
			End Try
		End Sub

		Private Sub mnuDeleteContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDeleteContact.Click
			Dim contact As Contact = (CType(contacts(gridContacts.CurrentRowIndex), Contact))
			contact.Delete()
			contact.Save()
			contacts.Remove(contact)
			UpdateMenu()
		End Sub

		Private Sub mnuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
			CType(New About(), About).ShowDialog(Me)
		End Sub

		Private Sub mnuCompact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCompact.Click
			Dim cur As System.Windows.Forms.Cursor = Me.Cursor
			Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
			Try
				session.PurgeDeletedObjects()
				MessageBox.Show(Me, "Compacting done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Finally
				Me.Cursor = cur
			End Try
		End Sub

		Private Sub gridContacts_Navigate(ByVal sender As Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles gridContacts.Navigate

		End Sub
	End Class
End Namespace
