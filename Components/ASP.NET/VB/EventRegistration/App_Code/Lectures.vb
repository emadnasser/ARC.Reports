Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq

Public Class SessionList
	Inherits BindingList(Of Session)
	Public Sub New()
		MyBase.New()
	End Sub
	Public Sub New(ByVal sessions As List(Of Session))
		MyBase.New()
		Me.AddRange(sessions)
	End Sub
	Public Sub New(ByVal sessions As SessionList)
		MyBase.New()
		Me.AddRange(sessions)
	End Sub
	Public Sub AddRange(ByVal sessions As List(Of Session))
		For Each session As Session In sessions
			Me.Add(session)
		Next session
	End Sub
	Public Sub AddRange(ByVal sessions As SessionList)
		For Each session As Session In sessions
			Me.Add(session)
		Next session
	End Sub
	Public Function GetById(ByVal id As String) As Session
		For Each session As Session In Items
			If session.Id = id Then
				Return session
			End If
		Next session
		Return Nothing
	End Function
	Public Function GetFeaturedSessions() As SessionList
		Return New SessionList(SelectMany(Me, Function(s) (s.Featured = True)))
	End Function
	Shared Function SelectMany(ByVal source As SessionList, ByVal selector As Func(Of Session, Boolean)) As List(Of Session)
		Return ( _
				From session In source _
				Where selector(session) _
				Select session).ToList()
	End Function

	Public Function CreateCopy() As SessionList
		Dim result As New SessionList()
		For Each session As Session In Me
			result.Add(New Session(session))
		Next session
		Return result
	End Function
End Class

Public Class SessionDataSource
	Private sessions_Renamed As SessionList

	Public Sub New(ByVal sessions As SessionList)
		If sessions Is Nothing Then
			DevExpress.XtraScheduler.Native.Exceptions.ThrowArgumentNullException("sessions")
		End If
		Me.sessions_Renamed = sessions
	End Sub
	Public Sub New()
		Me.New(New SessionList())
	End Sub

	Private ReadOnly Property Sessions() As SessionList
		Get
			Return sessions_Renamed
		End Get
	End Property

	Public Sub UpdateMethodHandler(ByVal session As Session)
		Dim eventIndex As Integer = session.Index
		If eventIndex >= 0 Then
			Sessions.RemoveAt(eventIndex)
			Sessions.Insert(eventIndex, session)
		End If
	End Sub
	Public Function SelectMethodHandler() As IEnumerable
		Dim result As New SessionList()
		result.AddRange(Sessions)
		Return result
	End Function
End Class
