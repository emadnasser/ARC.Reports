Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class FormLayout_DataBindingToSingleObject
	Inherits Page
	Private Const DataObjectName As String = "Person"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			formLayout.DataSource = GetData()
			formLayout.DataBind()
		End If
	End Sub

	Protected Sub submitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		UpdateData(CStr(formLayout.GetNestedControlValueByFieldName("FirstName")), CStr(formLayout.GetNestedControlValueByFieldName("LastName")), CType(formLayout.GetNestedControlValueByFieldName("Gender"), Gender), CType(formLayout.GetNestedControlValueByFieldName("BirthDate"), DateTime?), CStr(formLayout.GetNestedControlValueByFieldName("Country")), CStr(formLayout.GetNestedControlValueByFieldName("Address")), CStr(formLayout.GetNestedControlValueByFieldName("PhoneNumber")))

	End Sub

	Private Sub UpdateData(ByVal firstName As String, ByVal lastName As String, ByVal gender As Gender, ByVal birthDate? As DateTime, ByVal country As String, ByVal address As String, ByVal phoneNumber As String)
		Dim person As Person = GetData()
		person.FirstName = firstName
		person.LastName = lastName
		person.Gender = gender
		person.BirthDate = birthDate
		person.Country = country
		person.Address = address
		person.PhoneNumber = phoneNumber
	End Sub

	Private Function GetData() As Person
		If Session(DataObjectName) Is Nothing Then
			Session(DataObjectName) = New Person() With {.FirstName = "John", .LastName = "Smith", .Gender = Gender.Male, .BirthDate = New DateTime(1970, 5, 3), .Country = "United States", .Address = "City Center Plaza 516 Main St.", .PhoneNumber = "(503) 555-6874"}
		End If
		Return CType(Session(DataObjectName), Person)
	End Function
End Class
