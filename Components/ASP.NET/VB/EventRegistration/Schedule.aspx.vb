Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Web
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.Web.Internal
Imports DevExpress.XtraScheduler
Imports EventRegistration

Partial Public Class Schedule
	Inherits System.Web.UI.Page
	Private ReadOnly Property Storage() As ASPxSchedulerStorage
		Get
			Return ASPxScheduler1.Storage
		End Get
	End Property
	Private lastInsertedAppointmentId As Object

	Private ReadOnly Property Attending() As Boolean
		Get
			Return (Not IsCallback) AndAlso AttendingSession IsNot Nothing
		End Get
	End Property
	Private ReadOnly Property AttendingSession() As Session
		Get
			Return CurrentData.Sessions.GetById(HttpUtility.UrlEncode(Request.QueryString("attend")))
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SetupMappings()
		SetupSchedule()
		FillCategoriesView(DataHelper.Data.Categories)

		If Attending Then
			AttendingSession.Interest = 2
		End If

		ASPxScheduler1.DataBind()

		If Attending Then
			ShowSessionDetails()
		End If
	End Sub
	Private Sub SetupSchedule()
		For i As Integer = 0 To DataHelper.Data.Days.Count - 1
			Dim [date] As DateTime = DataHelper.Data.GetDate(i)
			ASPxTabControl1.Tabs.Add(String.Format("{0:MMMM d}", [date]), [date].ToString("d", CultureInfo.InvariantCulture))
		Next i

		SelectEventDay(CurrentData.SelectedDayIndex)
		DataHelper.Setup(Storage)
	End Sub
	Private Sub SelectEventDay(ByVal dayIndex As Integer)
		ASPxTabControl1.ActiveTabIndex = dayIndex
		ASPxScheduler1.Start = DataHelper.Data.GetDate(ASPxTabControl1.ActiveTabIndex)
	End Sub

	Private Sub FillCategoriesView(ByVal categories As List(Of Category))
		rpCategories.DataSource = categories
		rpCategories.DataBind()
	End Sub

	Private Sub ShowSessionDetails()
		SelectEventDay(DataHelper.Data.GetDay(AttendingSession.StartTime.Date))
		Items("attending") = True
		Dim showAppFormCallbackCommand As New ShowAppointmentFormByServerIdCallbackCommand(ASPxScheduler1)
		showAppFormCallbackCommand.Execute(AttendingSession.Id)
	End Sub
	#Region "#setupmappings"
	Private Sub SetupMappings()
		Dim mappings As ASPxAppointmentMappingInfo = Storage.Appointments.Mappings
		Storage.BeginUpdate()
		Try
			mappings.AppointmentId = "Id"
			mappings.Start = "StartTime"
			mappings.End = "EndTime"
			mappings.Subject = "Subject"
			mappings.Description = "Description"
			mappings.Label = "Interest"
			mappings.ResourceId = "Location"
			mappings.Status = "CategoryId"
		Finally
			Storage.EndUpdate()
		End Try
		Dim customMappings As ASPxAppointmentCustomFieldMappingCollection = Storage.Appointments.CustomFieldMappings
		customMappings.BeginUpdate()
		Try
			customMappings.Add(New AppointmentCustomFieldMapping(CustomFileldNames.Speaker, "Speaker", FieldValueType.String))
			customMappings.Add(New AppointmentCustomFieldMapping(CustomFileldNames.CategoryName, "CategoryName", FieldValueType.String))
			customMappings.Add(New AppointmentCustomFieldMapping(CustomFileldNames.Level, "Level", FieldValueType.Integer))
		Finally
			customMappings.EndUpdate()
		End Try
	End Sub
	#End Region ' #setupmappings

	'Initializing ObjectDataSource
	#Region "#objectcreated"
	Protected Sub appointmentsDataSource_ObjectCreated(ByVal sender As Object, ByVal e As ObjectDataSourceEventArgs)
		e.ObjectInstance = New SessionDataSource(CurrentData.Sessions)
	End Sub
	#End Region ' #objectcreated

	' User generated appointment id
	#Region "#appointmentid"
	Protected Sub ASPxScheduler1_AppointmentInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		SetAppointmentId(sender, e)
	End Sub
	Protected Sub appointmentsDataSource_Inserted(ByVal sender As Object, ByVal e As ObjectDataSourceStatusEventArgs)
		Me.lastInsertedAppointmentId = e.ReturnValue
	End Sub
	Private Sub SetAppointmentId(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
		Dim storage As ASPxSchedulerStorage = CType(sender, ASPxSchedulerStorage)
		Dim apt As Appointment = CType(e.Objects(0), Appointment)
		storage.SetAppointmentId(apt, Me.lastInsertedAppointmentId)
	End Sub
	#End Region ' #appointmentid

	Protected Sub ASPxScheduler1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
		e.Menu.Items.Clear()
	End Sub

	Protected Sub ASPxScheduler1_PrepareAppointmentFormPopupContainer(ByVal sender As Object, ByVal e As ASPxSchedulerPrepareFormPopupContainerEventArgs)
		e.Popup.HeaderText = e.Popup.HeaderText.Replace(" - Appointment", "")
		e.Popup.Height = 0
		e.Popup.ShowShadow = False
	End Sub

	Protected Sub ASPxScheduler1_HtmlTimeCellPrepared(ByVal sender As Object, ByVal e As ASPxSchedulerTimeCellPreparedEventArgs)
		Dim scheduler As ASPxScheduler = TryCast(sender, ASPxScheduler)
		Dim isBreak As Boolean = False
		Dim i As Integer = 0
		Do While i < DataHelper.Data.Breaks.Count AndAlso Not isBreak
			isBreak = e.Interval.IntersectsWithExcludingBounds(DataHelper.Data.Breaks(i))
			i += 1
		Loop
		Dim cellCssClass As String = If(isBreak, "breakCell ", "")

		Dim resources As ASPxResourceStorage = scheduler.Storage.Resources
		If e.Resource.MatchIds(resources(0)) Then
			cellCssClass &= "leftCell "
		End If
		If e.Resource.MatchIds(resources(resources.Count - 1)) Then
			cellCssClass &= "rightCell "
		End If
		If e.Interval.End.Minute = 0 Then
			cellCssClass &= "lastInHourCell"
		End If
		e.Cell.CssClass = RenderUtils.CombineCssClasses(cellCssClass, e.Cell.CssClass)
	End Sub
	Protected Sub ASPxScheduler1_VisibleIntervalChanged(ByVal sender As Object, ByVal e As EventArgs)
		CurrentData.SelectedDayIndex = DataHelper.Data.GetDay((TryCast(sender, ASPxScheduler)).Start)
	End Sub
End Class
