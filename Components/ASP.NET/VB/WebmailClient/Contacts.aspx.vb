Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Helpers
Imports DevExpress.Web
Imports DevExpress.Web.Data
Imports DevExpress.Xpo

Partial Public Class Contacts
	Inherits System.Web.UI.Page
	Shared Sub New()
		GetAddressFunction.Register()
	End Sub

	Protected ReadOnly Property SearchText() As String
		Get
			Return Utils.GetSearchText(Me)
		End Get
	End Property

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ContactForm.Visible = False
		End If
		BindCardView()
	End Sub

	Protected Sub ContactCountryEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
		If ContactFormPanel.IsCallback OrElse IsPostBack AndAlso (Not IsCallback) Then
			Dim combo = CType(sender, ASPxComboBox)
			combo.DataSource = CountryDataSource
			combo.DataBindItems()
		End If
	End Sub

	Protected Sub ContactCityEditor_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		If String.IsNullOrEmpty(e.Parameter) Then
			Return
		End If
		Dim combo = CType(sender, ASPxComboBox)
		CitiesDataSource.CommandParameters(0).DefaultValue = e.Parameter
		combo.DataSource = CitiesDataSource
		combo.DataBindItems()
	End Sub

	Protected Sub ContactDataView_CustomCallback(ByVal sender As Object, ByVal e As ASPxCardViewCustomCallbackEventArgs)
		If String.IsNullOrEmpty(e.Parameters) Then
			Return
		End If
		Dim args = e.Parameters.Split("|"c)
		If args(0) = "Delete" AndAlso args.Length = 2 Then
			Dim id As Integer
			If (Not Integer.TryParse(args(1), id)) Then
				Return
			End If
			DemoModel.DataProvider.DeleteContact(id)
			BindCardView()
		End If
		If args(0) = "SaveContact" Then
			Dim name = ContactNameEditor.Text
			Dim email = ContactEmailEditor.Text
			Dim address = ContactAddressEditor.Text
			Dim country = ContactCountryEditor.Text
			Dim city = ContactCityEditor.Text
			Dim phone = ContactPhoneEditor.Text

			Dim id As Integer
			Dim needUpdatePhoto As Boolean
			If args.Length = 4 AndAlso args(1) = "Edit" AndAlso Integer.TryParse(args(2), id) AndAlso Boolean.TryParse(args(3), needUpdatePhoto) Then
				Dim photoUrl = If(needUpdatePhoto, Utils.SaveContactPhoto(ContactPhotoImage.ContentBytes), DataProviderBase.NoUpdateContactPhoto)
				DemoModel.DataProvider.UpdateContact(id, name, email, address, country, city, phone, photoUrl)
			ElseIf args.Length = 2 AndAlso args(1) = "New" Then
				DemoModel.DataProvider.AddContact(name, email, address, country, city, phone, Utils.SaveContactPhoto(ContactPhotoImage.ContentBytes))
			End If

			BindCardView()
		End If
	End Sub

	Protected Sub ContactPhotoImage_CustomCallback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
		ContactPhotoImage.JSProperties("cpContactInfoUpdating") = False

		Dim args = e.Parameter.Split("|"c)
		If args(0) = "Edit" AndAlso args.Length = 2 Then
			Dim id As Integer
			If (Not Integer.TryParse(args(1), id)) Then
				Return
			End If

			Dim contact = DemoModel.DataProvider.Contacts.FirstOrDefault(Function(c) c.ID = id)
			If contact Is Nothing Then
				Return
			End If

			Dim dict = New Dictionary(Of String, Object)()
			dict("Name") = contact.Name
			dict("Email") = contact.Email
			dict("Address") = contact.Address
			dict("City") = contact.City
			dict("Country") = contact.Country
			dict("Phone") = contact.Phone
			ContactPhotoImage.Value = Utils.GetContactPhotoContentBytes(contact.PhotoUrl)

			ContactPhotoImage.JSProperties("cpContactInfo") = dict
			ContactPhotoImage.JSProperties("cpContactInfoUpdating") = True
			ContactPhotoImage.JSProperties("cpNeedUpdateContactPhoto") = False

		End If
	End Sub

	Private Sub BindCardView()
		ContactCardView.DataSource = SelectContacts()
		ContactCardView.DataBind()
	End Sub

	Private Function SelectContacts() As List(Of Contact)
		Dim result = DemoModel.DataProvider.Contacts.AsQueryable()
		Dim showCollectedAdresses = Convert.ToInt32(FindAddressBookList().Value) = 1
		result = result.Where(Function(c) Object.Equals(c.Collected, showCollectedAdresses))

		If (Not String.IsNullOrEmpty(SearchText)) Then
			result = ApplySearch(result)
		End If

		Dim sortedFieldName = FindSortByCombo().Value.ToString()
		Dim isDescending = Convert.ToInt32(FindSortDirectionCombo().Value) = 1
		result = Utils.MakeContactsOrderBy(result, sortedFieldName, isDescending)
		Return result.ToList()
	End Function

	Private Function ApplySearch(ByVal contacts As IQueryable(Of Contact)) As IQueryable(Of Contact)
		Dim text = SearchText.ToLower()
		Return contacts.Where(Function(c) c.Name IsNot Nothing AndAlso c.Name.ToLower().Contains(text) OrElse c.Address IsNot Nothing AndAlso c.Address.ToLower().Contains(text) OrElse c.City IsNot Nothing AndAlso c.City.ToLower().Contains(text) OrElse c.Country IsNot Nothing AndAlso c.Country.ToLower().Contains(text))
	End Function
	Private Function FindAddressBookList() As ASPxRadioButtonList
		Return TryCast(ContactViewBar.Groups.FindByName("AddressBooks").FindControl("AddressBookList"), ASPxRadioButtonList)
	End Function

	Private Function FindSortByCombo() As ASPxComboBox
		Return TryCast(ContactViewBar.Groups.FindByName("Sort").FindControl("SortByCombo"), ASPxComboBox)
	End Function

	Private Function FindSortDirectionCombo() As ASPxComboBox
		Return TryCast(ContactViewBar.Groups.FindByName("Sort").FindControl("SortDirectionCombo"), ASPxComboBox)
	End Function

	Protected Function GetContactImageUrl(ByVal container As CardViewCardBaseTemplateContainer) As String
		Dim photoUrl = GetDataItemProperty(Of String)(container, "PhotoUrl")
		Return Utils.GetContactPhotoUrl(photoUrl)
	End Function

	Protected Sub EditContactImage_Load(ByVal sender As Object, ByVal e As EventArgs)
		PrepareContactCommandImage(CType(sender, ASPxImage))
	End Sub

	Protected Sub DeleteContactImage_Load(ByVal sender As Object, ByVal e As EventArgs)
		PrepareContactCommandImage(CType(sender, ASPxImage))
	End Sub

	Protected Sub PrepareContactCommandImage(ByVal image As ASPxImage)
		Dim container = CType(image.NamingContainer, CardViewCardBaseTemplateContainer)
		image.JSProperties("cpContactKey") = GetDataItemProperty(Of Integer)(container, "ID")
	End Sub

	Private Function GetDataItemProperty(Of T)(ByVal container As CardViewCardBaseTemplateContainer, ByVal propertyName As String) As T
		Dim dataRow = CType(container.DataItem, WebDescriptorRowBase)
		Return CType(dataRow(propertyName), T)
	End Function
End Class
