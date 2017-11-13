Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.SessionState

Namespace EventRegistration

	Public Class FeaturedSessionsRotator
		Private list_Renamed As SessionList

		Public Sub New(ByVal list As SessionList)
			Me.list_Renamed = list
			CurrentId = New Random(CInt(Fix(DateTime.Now.Millisecond))).Next(Me.List.Count)
		End Sub

		Private ReadOnly Property List() As SessionList
			Get
				Return list_Renamed
			End Get
		End Property
		Private Property CurrentId() As Integer

		Public ReadOnly Property Current() As Session
			Get
				Return List(CurrentId)
			End Get
		End Property
		Public ReadOnly Property [Next]() As Session
			Get
				CurrentId += 1
				If CurrentId = List.Count Then
					CurrentId = 0
				End If
				Return List(CurrentId)
			End Get
		End Property
		Public ReadOnly Property Prev() As Session
			Get
				CurrentId -= 1
				If CurrentId < 0 Then
					CurrentId = List.Count - 1
				End If
				Return List(CurrentId)
			End Get
		End Property
	End Class

End Namespace
