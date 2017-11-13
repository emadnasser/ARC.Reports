Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.SessionState
Imports System.Linq

Public Class EmployeeEntry
	Public Sub New()
	End Sub
	Public Sub New(ByVal id As String, ByVal firstName As String, ByVal lastName As String, ByVal hireDate As DateTime, ByVal employerId As String)
		ID = id
		FirstName = firstName
		LastName = lastName
		HireDate = hireDate
		EmployerID = employerId
	End Sub
	Public Property ID() As String
	Public Property EmployerID() As String
	Public Property FirstName() As String
	Public Property LastName() As String
	Public Property HireDate() As DateTime
	Public Sub Assign(ByVal source As EmployeeEntry)
		FirstName = source.FirstName
		LastName = source.LastName
		HireDate = source.HireDate
		EmployerID = source.EmployerID
	End Sub
End Class

Public NotInheritable Class EmployeeSessionProvider
	Private Const Key As String = "DxEmployeeSessionProvider"

	Private Sub New()
	End Sub
	Private Shared Function CreateData() As List(Of EmployeeEntry)
		Dim result As New List(Of EmployeeEntry)()
		result.Add(New EmployeeEntry(GenerateNewID(), "Nancy", "Davolio", New DateTime(1992, 5, 1), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Andrew", "Fuller", New DateTime(1992, 8, 14), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Janet", "Leverling", New DateTime(1992, 4, 1), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Margaret", "Peacock", New DateTime(1993, 5, 3), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Steven", "Buchanan", New DateTime(1993, 10, 17), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Michael", "Suyama", New DateTime(1993, 10, 17), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Robert", "King", New DateTime(1994, 1, 2), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Laura", "Callahan", New DateTime(1994, 3, 5), GetEmployerId(result)))
		result.Add(New EmployeeEntry(GenerateNewID(), "Anne", "Dodsworth", New DateTime(1994, 11, 15), GetEmployerId(result)))
		Return result
	End Function
	Private Shared Function GetEmployerId(ByVal existingEmployees As List(Of EmployeeEntry)) As String
		If (Not existingEmployees.Any()) Then
			Return ""
		End If
		Return existingEmployees(CInt(Fix(existingEmployees.Count / 3))).ID
	End Function
	Private Shared Function GenerateNewID() As String
		Return Guid.NewGuid().ToString()
	End Function

	Public Shared Function [Select]() As IEnumerable(Of EmployeeEntry)
		Dim session As HttpSessionState = HttpContext.Current.Session
		If session(Key) Is Nothing Then
			session(Key) = CreateData()
		End If
		Return CType(session(Key), List(Of EmployeeEntry))
	End Function
End Class
