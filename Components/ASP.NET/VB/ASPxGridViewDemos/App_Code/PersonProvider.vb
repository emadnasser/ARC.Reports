Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.SessionState

Public Class InMemoryPerson
	Private _id As Integer
	Private _firstName, _lastName As String
	Private _age As Integer
	Private _email As String
	Private _arrivalDate As DateTime

	Public Sub New()
	End Sub

	Public Sub New(ByVal id As Integer)
		_id = id
	End Sub

	Public Sub New(ByVal id As Integer, ByVal firstName As String, ByVal lastName As String, ByVal age As Integer, ByVal email As String, ByVal arrivalDate As DateTime)
		Me.New(id)
		_firstName = firstName
		_lastName = lastName
		_age = age
		_email = email
		_arrivalDate = arrivalDate
	End Sub

	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set(ByVal value As Integer)
			_id = value
		End Set
	End Property
	Public Property FirstName() As String
		Get
			Return _firstName
		End Get
		Set(ByVal value As String)
			_firstName = value
		End Set
	End Property
	Public Property LastName() As String
		Get
			Return _lastName
		End Get
		Set(ByVal value As String)
			_lastName = value
		End Set
	End Property
	Public Property Email() As String
		Get
			Return _email
		End Get
		Set(ByVal value As String)
			_email = value
		End Set
	End Property
	Public Property Age() As Integer
		Get
			Return _age
		End Get
		Set(ByVal value As Integer)
			_age = value
		End Set
	End Property
	Public Property ArrivalDate() As DateTime
		Get
			Return _arrivalDate
		End Get
		Set(ByVal value As DateTime)
			_arrivalDate = value
		End Set
	End Property

	Friend Sub Assign(ByVal data As InMemoryPerson)
		_firstName = data.FirstName
		_lastName = data.LastName
		_email = data.Email
		_age = data.Age
		_arrivalDate = data.ArrivalDate
	End Sub
End Class
Public Class InMemoryPersonProvider
	Private ReadOnly Property Session() As HttpSessionState
		Get
			Return HttpContext.Current.Session
		End Get
	End Property

	Private Const SessionKey As String = "DXPersonProviderData"

	Public Function GetList() As List(Of InMemoryPerson)
		If Session(SessionKey) Is Nothing Then
			Session(SessionKey) = CreateData()
		End If
		Return CType(Session(SessionKey), List(Of InMemoryPerson))
	End Function

	Private Function CreateData() As List(Of InMemoryPerson)
		Dim list As New List(Of InMemoryPerson)()
		list.Add(New InMemoryPerson(list.Count + 1, "Andrew", "Fuller", 42, "andrew.fuller@devexpress.com", DateTime.Today.AddDays(-32)))
		list.Add(New InMemoryPerson(list.Count + 1, "Nancy", "Davolio", 34, "nancy.davolio@devexpress.com", DateTime.Today.AddDays(4)))
		list.Add(New InMemoryPerson(list.Count + 1, "Margaret", "Peackop", 48, "margaret.peackop.devexpress.com", DateTime.Today.AddDays(6)))
		list.Add(New InMemoryPerson(list.Count + 1, "Robert", "K", 29, "robert.king@devexpress.com", DateTime.Today.AddDays(5)))
		list.Add(New InMemoryPerson(list.Count + 1, "Anne", "Dodsworth", 17, "anne.dodsworth@devexpress.com", DateTime.Today.AddDays(4)))
		Return list
	End Function

	Public Sub Insert(ByVal data As InMemoryPerson)
		GetList().Add(data)
		data.Id = GetList().Count
	End Sub

	Public Sub Update(ByVal data As InMemoryPerson)
		Dim list As List(Of InMemoryPerson) = GetList()
		For Each item As InMemoryPerson In list
			If item.Id = data.Id Then
				item.Assign(data)
				Return
			End If
		Next item
	End Sub
End Class



