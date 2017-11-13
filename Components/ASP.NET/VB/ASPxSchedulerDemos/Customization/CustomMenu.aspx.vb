Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler

Partial Public Class Customization_CustomMenu
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
'        
'            The following code utilizes the DataHelper class, which is implemented
'            solely for the ASPxScheduler Demo project.
'            It is intended to hide unnecessary details and clarify the main idea.
'            For the recommended data binding techniques, please refer to the
'            Data Binding section modules:
'              ~/DataBinding/BoundMode.aspx for MS Access database
'              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
'              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
'        
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxScheduler1)
		SchedulerDemoUtils.ApplyWorkTime(Me, ASPxScheduler1)
		DataHelper.SetupDefaultMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource)
		DataHelper.SetupStatuses(ASPxScheduler1)
		DataHelper.SetupLabels(ASPxScheduler1)
		ASPxScheduler1.DataBind()
	End Sub

	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As SchedulerCallbackCommandEventArgs)
		If e.CommandId = "MNUVIEW" Then
			e.Command = New CustomMenuViewCallbackCommand(ASPxScheduler1)
		ElseIf e.CommandId = "USRAPTMENU" Then
			e.Command = New CustomMenuAppointmentCallbackCommand(ASPxScheduler1)
		End If
	End Sub
	Protected Sub ASPxScheduler1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.PopupMenuShowingEventArgs)
		Dim menu As ASPxSchedulerPopupMenu = e.Menu
		Dim menuItems As MenuItemCollection = menu.Items
		If menu.MenuId.Equals(SchedulerMenuItemId.DefaultMenu) Then
			ClearUnusedDefaultMenuItems(menu)
			AddScheduleNewEventSubMenu(menu, "Schedule New Event")
		ElseIf menu.MenuId.Equals(SchedulerMenuItemId.AppointmentMenu) Then
			menu.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ DefaultAppointmentMenuHandler({0}, s, e); }}", ASPxScheduler1.ClientID)
			menu.Items.Clear()
			AddScheduleNewEventSubMenu(menu, "Change Event")
			Dim deleteItem As New MenuItem("Delete", "DeleteId")
			deleteItem.BeginGroup = True
			menuItems.Add(deleteItem)
		End If
	End Sub
	Protected Sub AddScheduleNewEventSubMenu(ByVal menu As ASPxSchedulerPopupMenu, ByVal caption As String)
		Dim newWithTemplateItem As New MenuItem(caption, "TemplateEvents")
		newWithTemplateItem.BeginGroup = True
		menu.Items.Insert(0, newWithTemplateItem)
		AddTemplatesSubMenuItems(newWithTemplateItem)
	End Sub
	Private Shared Sub AddTemplatesSubMenuItems(ByVal parentMenuItem As MenuItem)
		parentMenuItem.Items.Add(New MenuItem("Routine", "Routine"))
		parentMenuItem.Items.Add(New MenuItem("Follow-Up", "FollowUp"))
		parentMenuItem.Items.Add(New MenuItem("Urgent", "Urgent"))
		parentMenuItem.Items.Add(New MenuItem("Lab Testing", "LabTesting"))
		parentMenuItem.Items.Add(New MenuItem("Service", "Service"))
	End Sub
	Protected Sub ClearUnusedDefaultMenuItems(ByVal menu As ASPxSchedulerPopupMenu)
		RemoveMenuItem(menu, "NewAppointment")
		RemoveMenuItem(menu, "NewAllDayEvent")
		RemoveMenuItem(menu, "NewRecurringAppointment")
		RemoveMenuItem(menu, "NewRecurringEvent")
		RemoveMenuItem(menu, "GotoToday")
		RemoveMenuItem(menu, "GotoDate")
	End Sub
	Protected Sub RemoveMenuItem(ByVal menu As ASPxSchedulerPopupMenu, ByVal menuItemName As String)
		Dim item As MenuItem = menu.Items.FindByName(menuItemName)
		If item IsNot Nothing Then
			menu.Items.Remove(item)
		End If
	End Sub
End Class

#Region "CustomMenuViewCallbackCommand"
Public Enum CustomLabel
	Routine = 1
	FollowUp = 2
	Urgent = 3
	LabTesting = 4
	Service = 5
End Enum
Public Enum CustomStatus
	Confirmed = 1
	AwaitingConfirmation = 2
	Cancelled = 3
End Enum
Public Class CustomMenuViewCallbackCommand
	Inherits MenuViewCallbackCommand
	Private myMenuItemId_Renamed As String

	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub

	Public ReadOnly Property MyMenuItemId() As String
		Get
			Return myMenuItemId_Renamed
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		Me.myMenuItemId_Renamed = parameters
		MyBase.ParseParameters(parameters)
	End Sub
	Protected Overrides Sub ExecuteCore()
		ExecuteUserMenuCommand(MyMenuItemId)
		MyBase.ExecuteCore()
	End Sub
	Protected Friend Overridable Sub ExecuteUserMenuCommand(ByVal menuItemId As String)
		If menuItemId = "Routine" Then
			CreateAppointment("Name", "Contact info:", CustomStatus.Cancelled, CustomLabel.Routine)
		ElseIf menuItemId = "FollowUp" Then
			CreateAppointment("Name", "Contact info:", CustomStatus.AwaitingConfirmation, CustomLabel.FollowUp)
		ElseIf menuItemId = "Urgent" Then
			CreateAppointment("Name", "Contact info:", CustomStatus.Confirmed, CustomLabel.Urgent)
		ElseIf menuItemId = "LabTesting" Then
			CreateAppointment("Lab Testing", String.Empty, CustomStatus.Confirmed, CustomLabel.LabTesting)
		ElseIf menuItemId = "Service" Then
			CreateAppointment("Routine Maintenance", String.Empty, CustomStatus.Cancelled, CustomLabel.Service)
		End If
	End Sub
	Protected Sub CreateAppointment(ByVal subject As String, ByVal description As String, ByVal statusKey As CustomStatus, ByVal labelKey As CustomLabel)
		Dim apt As Appointment = Control.Storage.CreateAppointment(AppointmentType.Normal)
		apt.Subject = subject
		apt.Description = description
		apt.Start = Control.SelectedInterval.Start
		apt.End = Control.SelectedInterval.End
		apt.ResourceId = Control.SelectedResource.Id
		apt.StatusKey = CInt(Fix(statusKey))
		apt.LabelKey = CInt(Fix(labelKey))
		Control.Storage.Appointments.Add(apt)
	End Sub
End Class
#End Region

#Region "CustomMenuAppointmentCallbackCommand"
Public Class CustomMenuAppointmentCallbackCommand
	Inherits SchedulerCallbackCommand
	Private menuItemId_Renamed As String = String.Empty

	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)
	End Sub

	Public Overrides ReadOnly Property Id() As String
		Get
			Return "USRAPTMENU"
		End Get
	End Property
	Public ReadOnly Property MenuItemId() As String
		Get
			Return menuItemId_Renamed
		End Get
	End Property

	Protected Overrides Sub ParseParameters(ByVal parameters As String)
		Me.menuItemId_Renamed = parameters
	End Sub
	Protected Overrides Sub ExecuteCore()
		Dim apt As Appointment = Control.SelectedAppointments(0)
		If MenuItemId = "DeleteId" Then
			apt.Delete()
		ElseIf MenuItemId = "Routine" Then
			UpdateAppointment(apt, String.Empty, CustomStatus.Cancelled, CustomLabel.Routine)
		ElseIf MenuItemId = "FollowUp" Then
			UpdateAppointment(apt, String.Empty, CustomStatus.AwaitingConfirmation, CustomLabel.FollowUp)
		ElseIf MenuItemId = "Urgent" Then
			UpdateAppointment(apt, String.Empty, CustomStatus.Confirmed, CustomLabel.Urgent)
		ElseIf MenuItemId = "LabTesting" Then
			UpdateAppointment(apt, "Lab Testing", CustomStatus.Confirmed, CustomLabel.LabTesting)
		ElseIf MenuItemId = "Service" Then
			UpdateAppointment(apt, "Routine Maintenance", CustomStatus.Cancelled, CustomLabel.Service)
		End If
	End Sub
	Protected Sub UpdateAppointment(ByVal apt As Appointment, ByVal subject As String, ByVal statusKey As CustomStatus, ByVal labelKey As CustomLabel)
		If labelKey.Equals(CustomLabel.Service) OrElse labelKey.Equals(CustomLabel.LabTesting) Then
			apt.Subject = subject
			apt.Description = String.Empty
		ElseIf (apt.LabelKey.Equals(CInt(Fix(CustomLabel.Service))) OrElse apt.LabelKey.Equals(CInt(Fix(CustomLabel.LabTesting)))) AndAlso (Not labelKey.Equals(CustomLabel.Service)) AndAlso (Not labelKey.Equals(CustomLabel.LabTesting)) Then
			apt.Subject = "Name"
			apt.Description = "Contact info:"
		End If
		apt.StatusKey = CInt(Fix(statusKey))
		apt.LabelKey = CInt(Fix(labelKey))
	End Sub
End Class
#End Region
