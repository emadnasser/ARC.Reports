Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ContactManagement
	Public Class EditObjectEventArgs
		Inherits EventArgs
        Private _objectToEdit As Object
        Public Sub New(ByVal _objectToEdit As Object)
            Me._objectToEdit = _objectToEdit
        End Sub
        Public ReadOnly Property ObjectToEdit() As Object
            Get
                Return _objectToEdit
            End Get
        End Property
	End Class
	Public Delegate Sub InsertObjectEventHandler(ByVal sender As Object)
	Public Delegate Sub EditObjectEventHandler(ByVal sender As Object, ByVal e As EditObjectEventArgs)


	Public Class Address
		Inherits XPObject
		<Association("PersonAddresses")> _
		Public Owner As Person
		Public City As String = ""
		Public Street As String = ""
		Public ReadOnly Property IsDefault() As Boolean
			Get
				Return Not Owner Is Nothing AndAlso Owner.DefaultAddress Is Me
			End Get
		End Property
		Public Sub New(ByVal otherAddress As Address)
			MyBase.New(otherAddress.Session)
			Me.City = otherAddress.City
			Me.Street = otherAddress.Street
		End Sub
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class Attachment
		Inherits XPObject
		Public Name As String = ""
		<Association("PersonAttachments")> _
		Public Owner As Person
        Private _document As XPDelayedProperty = New XPDelayedProperty()
        <Delayed("document")> _
        Public Property Document() As Byte()
            Get
                Return CType(_document.Value, Byte())
            End Get
            Set(ByVal value As Byte())
                _document.Value = Value
            End Set
        End Property
		'		public Attachment() : base() {}
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	<Persistent("T_Person")> _
	Public MustInherit Class Person
		Inherits XPObject
		Public PhoneNumber As String = ""
		<Aggregated> _
		Public DefaultAddress As Address = Nothing
		<Aggregated, Association("PersonAddresses", GetType(Address))> _
		Public ReadOnly Property Addresses() As XPCollection
			Get
				Return GetCollection("Addresses")
			End Get
		End Property
		<Aggregated, Association("PersonAttachments", GetType(Attachment))> _
		Public ReadOnly Property Attachments() As XPCollection
			Get
				Return GetCollection("Attachments")
			End Get
		End Property
		<Persistent("CreatedOn")> _
		Private mCreatedOn As DateTime = DateTime.Today
		Public ReadOnly Property CreatedOn() As DateTime
			Get
				Return mCreatedOn
			End Get
		End Property
		Public MustOverride ReadOnly Property DisplayName() As String
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	<MapInheritance(MapInheritanceType.OwnTable)> _
	Public Class Contact
		Inherits Person
		Public FirstName As String = ""
		Public LastName As String = ""
		Public Email As String = ""
        Private _employer As Company = Nothing
        <Persistent("CompanyID")> _
        Public Property Employer() As Company
            Get
                Return _employer
            End Get
            Set(ByVal value As Company)
                _employer = Value
                If (Not IsLoading) AndAlso Not _employer Is Nothing AndAlso Not _employer.DefaultAddress Is Nothing Then
                    Addresses.Remove(DefaultAddress)
                    DefaultAddress = New Address(_employer.DefaultAddress)
                    Addresses.Add(DefaultAddress)
                End If
            End Set
        End Property
		<Persistent> _
		Public ReadOnly Property FullName() As String
			Get
				Return String.Format("{0}, {1}", LastName, FirstName)
			End Get
		End Property
		Public Overrides ReadOnly Property DisplayName() As String
			Get
				Return FullName
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
        Public Sub New(ByVal session As Session, ByVal _employer As Company)
            MyBase.New(session)
            Me.Employer = _employer
        End Sub
	End Class

	Public Class RequiredPropertyValueMissing
		Inherits Exception
		Public Sub New(ByVal theObject As XPObject, ByVal propertyName As String)
			MyBase.New(String.Format("The {0} property of the {1} object with id {2} must have a value", propertyName, theObject.GetType().Name, theObject.Oid))
		End Sub
	End Class

	<MapInheritance(MapInheritanceType.OwnTable)> _
	Public Class Company
		Inherits Person
		Public Name As String = ""
		Public WebSite As String = ""
		Public Overrides ReadOnly Property DisplayName() As String
			Get
				Return Name
			End Get
		End Property
		Protected Overrides Sub OnSaving()
			If (Not IsDeleted) Then
				If Name = "" Then
					Throw New RequiredPropertyValueMissing(Me, "Name")
				End If
			End If
		End Sub
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
End Namespace
