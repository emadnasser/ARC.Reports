Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Web.Demos

<Persistent("Persons")> _
Friend Class XpoPersonEntity
	Inherits XPLiteObject
	Private _id As Integer
	Private _lastName As String
	Private _firstName As String
	Private _phone As String

	Public Sub New(ByVal session As Session)
		MyBase.New(session)
	End Sub

	<Key(True)> _
	Public Property ID() As Integer
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
	Public Property Phone() As String
		Get
			Return _phone
		End Get
		Set(ByVal value As String)
			_phone = value
		End Set
	End Property

	Protected Overrides Sub OnSaving()
		Utils.AssertNotReadOnly()
	End Sub

	Protected Overrides Sub OnDeleting()
		Utils.AssertNotReadOnly()
	End Sub
End Class
