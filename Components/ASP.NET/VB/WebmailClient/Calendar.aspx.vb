Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar
Imports System.Collections

Partial Public Class Calendar
	Inherits System.Web.UI.Page
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Utils.ApplyTheme(Me)
	End Sub

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			Scheduler.Start = New DateTime(DateTime.Now.Year, 04, 06)
		End If
		CType(New SchedulerRowInsertionHelper(), SchedulerRowInsertionHelper).ProvideRowInsertion(Scheduler, AppointmentDataSource)
		ResourceNavBar.DataBind()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not SchedulerData.GetAppointments().Any()) Then
			ImportCalendarData()
		End If
		If Utils.CurrentTheme Is "iOS" OrElse Utils.CurrentTheme Is "Material" Then
			DateNavigator.Properties.Rows = 1
		End If
	End Sub

	Protected Sub Scheduler_FilterAppointment(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
		If _selectedResourceNameCache Is Nothing Then
			_selectedResourceNameCache = FindSelectedResourceNames()
		End If

		Dim resourceId As Integer
		Dim appointment As Appointment = CType(e.Object, Appointment)
		If Integer.TryParse(appointment.ResourceId.ToString(), resourceId) Then
			Dim resource = SchedulerData.GetResources().First(Function(r) r.ID = resourceId)
			e.Cancel = Not _selectedResourceNameCache.Contains(resource.Name)
		End If
	End Sub

	Protected Function GetResourceCheckedState(ByVal container As NavBarItemTemplateContainer) As Boolean
		Return container.Item.Group.VisibleIndex = 0 AndAlso container.Item.VisibleIndex = 0
	End Function

	Private Sub ImportCalendarData()
		Scheduler.DataBind()
		CType(New iCalendarImporter(Scheduler.Storage), iCalendarImporter).Import(Server.MapPath("~/App_Data/CalendarData.ics"))
	End Sub

	Private _selectedResourceNameCache As ISet(Of String)
	Private Function FindSelectedResourceNames() As ISet(Of String)
		Dim result = New HashSet(Of String)()
		For i As Integer = 0 To ResourceNavBar.Items.Count - 1
			Dim checkbox = TryCast(ResourceNavBar.Items(i).FindControl("CheckBox"), ASPxCheckBox)
			If checkbox IsNot Nothing AndAlso checkbox.Checked Then
				result.Add(checkbox.Text)
			End If
		Next i
		Return result
	End Function

End Class
