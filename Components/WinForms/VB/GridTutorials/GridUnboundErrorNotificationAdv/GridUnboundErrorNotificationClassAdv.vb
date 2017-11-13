Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.XtraGrid.Demos.Tutorials
	'<gridControl1>
	Public Class Person
		Implements IDXDataErrorInfo
	'...    
	'</gridControl1>
		Private firstName_Renamed As String
		Private lastName_Renamed As String
		Private address_Renamed As String
		Private phoneNumber_Renamed As String
		Private email_Renamed As String
		Public Sub New(ByVal firstName_Renamed As String, ByVal lastName_Renamed As String, ByVal address_Renamed As String, ByVal phoneNumber_Renamed As String, ByVal email_Renamed As String)
			Me.firstName_Renamed = firstName_Renamed
			Me.lastName_Renamed = lastName_Renamed
			Me.address_Renamed = address_Renamed
			Me.phoneNumber_Renamed = phoneNumber_Renamed
			Me.email_Renamed = email_Renamed
		End Sub
		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set
				firstName_Renamed = Value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set
				lastName_Renamed = Value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set
				address_Renamed = Value
			End Set
		End Property
		Public Property PhoneNumber() As String
			Get
				Return phoneNumber_Renamed
			End Get
			Set
				phoneNumber_Renamed = Value
			End Set
		End Property
		Public Property Email() As String
			Get
				Return email_Renamed
			End Get
			Set
				email_Renamed = Value
			End Set
		End Property
		#Region "IDXDataErrorInfo Members"
		'<gridControl1>
        Private Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            Select Case propertyName
                Case "FirstName", "LastName"
                    If IsStringEmpty(CType(IIf(propertyName = "FirstName", FirstName, LastName), String)) Then
                        SetErrorInfo(info, propertyName & " field can't be empty", ErrorType.Critical)
                    End If
                Case "Address"
                    If IsStringEmpty(Address) Then
                        SetErrorInfo(info, "Address hasn't been entered", ErrorType.Information)
                    End If
                Case "Email"
                    If IsStringEmpty(Email) Then
                        SetErrorInfo(info, "Email hasn't been entered", ErrorType.Information)
                    ElseIf Email <> "none" AndAlso (Not IsEmailCorrect(Email)) Then
                        SetErrorInfo(info, "Wrong email address", ErrorType.Warning)
                    End If
            End Select
        End Sub
        Private Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        End Sub
        '</gridControl1>
#End Region
        Private Function IsStringEmpty(ByVal str As String) As Boolean
            Return (Not str Is Nothing AndAlso str.Trim().Length = 0)
        End Function
        Private Function IsEmailCorrect(ByVal email_Renamed As String) As Boolean
            Return Not (Not email_Renamed Is Nothing AndAlso email_Renamed.IndexOf("@") < 1)
        End Function
        Private Sub SetErrorInfo(ByVal info As ErrorInfo, ByVal errorText As String, ByVal errorType As ErrorType)
            info.ErrorText = errorText
            info.ErrorType = errorType
        End Sub
    End Class
	Public Class Persons
		Inherits CollectionBase
		'Provides access to items
		Public ReadOnly Default Property Item(ByVal index As Integer) As Person
			Get
				Return CType(List(index), Person)
			End Get
		End Property
		'The method is called after a new item is added or inserted
		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			MyBase.OnInsertComplete (index, value)
			Dim customer As Person = TryCast(value, Person)
		End Sub
		'Adds a new item to the collection
		Public Function Add(ByVal person As Person) As Integer
			Dim index As Integer = List.Add(person)
			Return index
		End Function
		'Checks the item's membership
		Public Function IndexOf(ByVal person As Person) As Integer
			Return List.IndexOf(person)
		End Function
	End Class
End Namespace
