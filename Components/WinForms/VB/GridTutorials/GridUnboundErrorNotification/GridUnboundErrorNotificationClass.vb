Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class NoteInfo
		Implements System.ComponentModel.IDataErrorInfo
		Private fDay As Integer
		Private fMonth As Integer
		Private fYear As Integer
		Private fNoteID As Integer
		'References the item's owner
		Private owner_Renamed As ProjectNotes
		'Stores error descriptions for the Day, Month, Year and NoteID properties
		Private propertyErrors As Hashtable
		'Stores an error description for the item
		Private fNoteError As String


		Public Sub New(ByVal noteID As Integer, ByVal day As Integer, ByVal month As Integer, ByVal year As Integer)
			fNoteID = noteID
			fDay = day
			fMonth = month
			fYear = year
			'Set errors to empty strings
			propertyErrors = New Hashtable()
			propertyErrors.Add("Day", "")
			propertyErrors.Add("Month", "")
			propertyErrors.Add("Year", "")
			propertyErrors.Add("NoteID", "")
			fNoteError = ""
			Owner = Nothing
		End Sub

		Public Property NoteID() As Integer
			Get
				Return fNoteID
			End Get
			Set
				If fNoteID = Value Then
				Return
				End If
				fNoteID = Value
			End Set
		End Property

		Public Property Day() As Integer
			Get
				Return fDay
			End Get
			Set
				If fDay = Value Then
				Return
				End If
				fDay = Value
			End Set
		End Property

		Public Property Month() As Integer
			Get
				Return fMonth
			End Get
			Set
				If fMonth = Value Then
				Return
				End If
				fMonth = Value
			End Set
		End Property

		Public Property Year() As Integer
			Get
				Return fYear
			End Get
			Set
				If fYear = Value Then
				Return
				End If
				fYear = Value
			End Set
		End Property

		'Gets and sets an error for the current item
		Friend Property NoteError() As String
			Get
				Return fNoteError
			End Get
			Set
				If fNoteError = Value Then
				Return
				End If
				fNoteError = Value
			End Set
		End Property

		Public Sub ClearErrors()
			SetColumnError("Day", "")
			SetColumnError("Month", "")
			SetColumnError("Year", "")
			NoteError = ""
		End Sub

		'Sets an error for an item's property
		Public Sub SetColumnError(ByVal elem As String, ByVal [error] As String)
			If propertyErrors.ContainsKey(elem) Then
				If CStr(propertyErrors(elem)) = [error] Then
				Return
				End If
				propertyErrors(elem) = [error]
			End If
		End Sub

		'Gets an error for an item's property
		Public Function GetColumnError(ByVal elem As String) As String
			If propertyErrors.ContainsKey(elem) Then
				Return CStr(propertyErrors(elem))
			Else
				Return ""
			End If
		End Function

		'The owner collection
		Friend Property Owner() As ProjectNotes
			Get
				Return owner_Renamed
			End Get
			Set
				owner_Renamed = Value
			End Set
		End Property


	#Region "IDataErrorInfo Members"

		'Returns an error description set for the item's property
        Default ReadOnly Property Item(ByVal columnName As String) As String Implements IDataErrorInfo.Item
            Get
                Return GetColumnError(columnName)
            End Get
        End Property

		'Returns an error description set for the current item
		Private ReadOnly Property [Error]() As String Implements IDataErrorInfo.Error
			Get
				Return NoteError
			End Get
		End Property
	#End Region
	End Class

	Public Class ProjectNotes
		Inherits CollectionBase
		'Provides access to items
		Public ReadOnly Default Property Item(ByVal index As Integer) As NoteInfo
			Get
				Return CType(List(index), NoteInfo)
			End Get
		End Property

		'The method is called after a new item is added or inserted
		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			MyBase.OnInsertComplete (index, value)
			Dim nInfo As NoteInfo = TryCast(value, NoteInfo)
			'Set the item's owner
			If Not nInfo Is Nothing Then
			nInfo.Owner = Me
			End If
		End Sub

		'Adds a new item to the collection
		Public Function Add(ByVal nInfo As NoteInfo) As Integer
			Dim index As Integer = List.Add(nInfo)
			Return index
		End Function
		'Checks the item's membership
		Public Function IndexOf(ByVal nInfo As NoteInfo) As Integer
			Return List.IndexOf(nInfo)
		End Function
	End Class
End Namespace
