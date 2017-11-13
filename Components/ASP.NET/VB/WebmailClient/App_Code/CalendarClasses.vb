Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.Xml.Linq
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Public Class SchedulerRowInsertionHelper
	Private lastInsertedIdList As New List(Of Object)()

	Public Sub ProvideRowInsertion(ByVal control As ASPxScheduler, ByVal dataSource As ObjectDataSource)
		AddHandler control.AppointmentsInserted, AddressOf control_AppointmentsInserted
		AddHandler control.AppointmentCollectionCleared, AddressOf control_AppointmentCollectionCleared
		AddHandler dataSource.Inserted, AddressOf dataSource_Inserted
	End Sub

	Private Sub control_AppointmentCollectionCleared(ByVal sender As Object, ByVal e As EventArgs)
		Me.lastInsertedIdList.Clear()
	End Sub
	Private Sub dataSource_Inserted(ByVal sender As Object, ByVal e As ObjectDataSourceStatusEventArgs)
		Me.lastInsertedIdList.Add(e.ReturnValue)
	End Sub
	Private Sub control_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		Dim storage As ASPxSchedulerStorage = CType(sender, ASPxSchedulerStorage)
		Dim count As Integer = e.Objects.Count
		For i As Integer = 0 To count - 1
			Dim apt As Appointment = CType(e.Objects(i), Appointment)
			storage.SetAppointmentId(apt, Me.lastInsertedIdList(i))
		Next i
		Me.lastInsertedIdList.Clear()
	End Sub
End Class

Public NotInheritable Class SchedulerData
	Private Shared _resources As List(Of SchedulerResourceObject)
	Private Shared _nextId As Integer = 0

	Private Sub New()
	End Sub
	Private Shared ReadOnly Property Context() As HttpContext
		Get
			Return HttpContext.Current
		End Get
	End Property

	Private Shared Function GenerateResources() As List(Of SchedulerResourceObject)
		Dim doc = XDocument.Load(Context.Server.MapPath("~/App_Data/Resources.xml"))
		Return ( _
				From node In doc.Descendants("Resource") _
				Select New SchedulerResourceObject With {.ID = Convert.ToInt32(node.Attribute("ID").Value), .Name = node.Attribute("Name").Value}).ToList()
	End Function

	Public Shared Function GetAppointments() As List(Of SchedulerAppointmentObject)
		Const key As String = "C74C8B5B-5765-460C-B998-43B75246547A"
		If Context.Session(key) Is Nothing Then
			Context.Session(key) = New List(Of SchedulerAppointmentObject)()
		End If
		Return CType(Context.Session(key), List(Of SchedulerAppointmentObject))
	End Function

	Public Shared Function GetResources() As List(Of SchedulerResourceObject)
		If _resources Is Nothing Then
			_resources = GenerateResources()
		End If
		Return _resources
	End Function

	Public Shared Function Find(ByVal id As Object) As SchedulerAppointmentObject
		Return GetAppointments().First(Function(a) a.ID = id)
	End Function

	Public Shared Function Insert(ByVal item As SchedulerAppointmentObject) As Object
		item.ID = _nextId
		_nextId += 1
		GetAppointments().Add(item)
		Return item.ID
	End Function

	Public Shared Sub Update(ByVal item As SchedulerAppointmentObject)
		Delete(item)
		GetAppointments().Add(item)
	End Sub

	Public Shared Sub Delete(ByVal item As SchedulerAppointmentObject)
		GetAppointments().Remove(Find(item.ID))
	End Sub

End Class

Public Class SchedulerAppointmentObject
	Public Property ID() As Object
	Public Property Type() As Integer
	Public Property StartDate() As DateTime
	Public Property EndDate() As DateTime
	Public Property AllDay() As Boolean
	Public Property Subject() As String
	Public Property Location() As String
	Public Property Description() As String
	Public Property Status() As Integer
	Public Property Label() As Integer
	Public Property ResourceID() As Object
	Public Property RecurrenceInfo() As String
End Class

Public Class SchedulerResourceObject
	Public Property ID() As Integer
	Public Property Name() As String
End Class

