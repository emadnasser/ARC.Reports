Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Xml
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraScheduler.Reporting

Partial Public Class ReportsDataSource
	Inherits System.Web.UI.UserControl
	Public ReadOnly Property SchedulerStorageAdapter() As SchedulerPrintAdapter
		Get
			Return ASPxStoragePrintAdapter.SchedulerAdapter
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SchedulerDemoUtils.ApplyDefaults(Me, ASPxSchedulerControl)
		DataHelper.SetupDefaultMappings(ASPxSchedulerControl)
		ASPxSchedulerControl.AppointmentDataSource = Me.efAppointmentDataSource
		ASPxSchedulerControl.ResourceDataSource = Me.efResourceDataSource
		SetupStatuses(ASPxSchedulerControl)
		SetupLabels(ASPxSchedulerControl)
		ASPxSchedulerControl.DataBind()
	End Sub
	Public Sub SetupLabels(ByVal control As ASPxScheduler)
		Dim labels As DevExpress.Web.ASPxScheduler.AppointmentLabelCollection = control.Storage.Appointments.Labels
		labels.Clear()
		labels.Add(1, "Routine", "Routine", Color.FromArgb(100, 75, 194, 80))
		labels.Add(2, "Follow-Up", "Follow-Up", Color.FromArgb(100, 58, 159, 254))
		labels.Add(3, "Urgent", "Urgent", Color.FromArgb(100, 255, 89, 50))
		labels.Add(4, "Lab Testing", "Lab Testing", Color.FromArgb(100, 92, 107, 192))
		labels.Add(5, "Service", "Service", Color.FromArgb(100, 159, 159, 159))
	End Sub
	Public Sub SetupStatuses(ByVal control As ASPxScheduler)
		Dim statuses As DevExpress.Web.ASPxScheduler.AppointmentStatusCollection = control.Storage.Appointments.Statuses
		statuses.Clear()
		statuses.Add(1, AppointmentStatusType.Custom, "Confirmed", "Confirmed", Color.FromArgb(200, 0, 171, 71))
		statuses.Add(1, AppointmentStatusType.Custom, "Awaiting Confirmation", "Awaiting Confirmation", Color.FromArgb(200, 94, 53, 177))
		statuses.Add(3, AppointmentStatusType.Custom, "Cancelled", "Cancelled", Color.FromArgb(200, 255, 255, 255))
	End Sub
End Class
