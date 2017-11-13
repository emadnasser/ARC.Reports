Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections
Imports DevExpress.XtraReports.Web
Imports DevExpress.Web

Partial Public Class PrintContacts
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected ReadOnly Property SelectedAddressBook() As String
		Get
			Dim result As String = Nothing
			If Utils.TryGetClientStateValue(Of String)(Me, "AddressBook", result) Then
				Return result
			End If
			Return "Personal"
		End Get
	End Property

	Protected ReadOnly Property ShowAllContacts() As Boolean
		Get
			Return SelectedAddressBook = "All"
		End Get
	End Property
	Protected ReadOnly Property ShowOnlyPersonalAddresses() As Boolean
		Get
			Return SelectedAddressBook = "Personal"
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ContactReportViewer.Report = New ContactReport(GetContacts())
	End Sub

	Protected Function GetContacts() As IEnumerable
		Dim contacts = DemoModel.DataProvider.Contacts
		If (Not ShowAllContacts) Then
			Dim showOnlyPersonal = ShowOnlyPersonalAddresses
			contacts = contacts.Where(Function(c) (Not Object.Equals(c.Collected, showOnlyPersonal)))
		End If
		Return contacts.Select(Function(c) New With {Key .PhotoUrl = "~/" & Utils.GetContactPhotoUrl(c.PhotoUrl), Key .Name = c.Name, Key .Email = c.Email, Key .Address = Utils.GetAddressString(c), Key .Phone = c.Phone})
	End Function

	Private Function GetPhotoUrl(ByVal contact As Contact) As String
		Dim relativePath = Utils.GetContactPhotoUrl(contact.PhotoUrl)
		Return Server.MapPath(relativePath)
	End Function
End Class
