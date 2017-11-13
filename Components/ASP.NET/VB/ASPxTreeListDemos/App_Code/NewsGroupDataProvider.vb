Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Linq


Public NotInheritable Class NewsGroupDataProvider
	Private Shared ReadOnly Key As String = "NewsGroupDataProvider"

	Private Sub New()
	End Sub
	Private Shared ReadOnly Property Session() As HttpSessionState
		Get
			Return HttpContext.Current.Session
		End Get
	End Property
	Private Shared ReadOnly Property Data() As List(Of Thread)
		Get
			If Session(Key) Is Nothing Then
				Restore()
			End If
			Return CType(Session(Key), List(Of Thread))
		End Get
	End Property

	Public Shared Function [Select]() As IEnumerable
		Return Data
	End Function

	Public Shared Sub Insert(ByVal item As Thread)
		Data.Add(item)
		item.ID = Data.Count
	End Sub

	Public Shared Sub Update(ByVal item As Thread)
		Dim storedItem As Thread = FindItem(item.ID)
		Assign(item, storedItem)
	End Sub

	Private Shared Sub Assign(ByVal source As Thread, ByVal target As Thread)
		target.ParentID = source.ParentID
		target.From = source.From
		target.Subject = source.Subject
		target.Text = source.Text
		target.DateCreated = source.DateCreated
		target.HasAttachment = source.HasAttachment
	End Sub

	Public Shared Sub Delete(ByVal item As Thread)
		Dim storedItem As Thread = FindItem(item.ID)
		Data.Remove(storedItem)
	End Sub

	Public Shared Sub Corrupt()
		Dim count As Integer = 0
		For Each item As Thread In Data
			Dim [mod] As Integer = count Mod 5
			If [mod] = 0 Then
				item.Subject = ""
			End If
			If [mod] = 2 Then
				item.From = ""
			End If
			If [mod] = 4 Then
				item.DateCreated = DateTime.Now.AddYears(-30 - count)
			End If
			count += 1
		Next item
	End Sub

	Public Shared Sub Restore()
		Session(Key) = CreateData()
	End Sub

	Private Shared Function FindItem(ByVal id As Integer) As Thread
		Return Data.SingleOrDefault(Function(t) t.ID = id)
	End Function

	Private Shared Function CreateData() As List(Of Thread)
		Using context = New NewsGroupsContext()
			Return context.Threads.ToList()
		End Using
	End Function
End Class
