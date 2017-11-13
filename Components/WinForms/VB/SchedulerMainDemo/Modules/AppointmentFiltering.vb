Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraScheduler.Drawing

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class AppointmentFilteringModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private sportsImages As ImageCollection
		Private channelsImages As ImageCollection

		Public Sub New()
			Me.sportsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.sports.png"), System.Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
			Me.channelsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.channels.png"), System.Reflection.Assembly.GetExecutingAssembly(), New Size(60, 40))
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub ResourceSharingModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			schedulerControl.GroupType = SchedulerGroupType.Resource
			FillFilterComboBox()
			AddSportChanels()
			FillData()
		End Sub
		Private Sub AddAppointmentLabel(ByVal id As Object, ByVal displayName As String, ByVal menuCaption As String, ByVal color As Color)
			Dim label As IAppointmentLabel = Me.schedulerStorage.Appointments.Labels.CreateNewLabel(id, displayName, menuCaption)
			label.SetColor(color)
			Me.schedulerStorage.Appointments.Labels.Add(label)
		End Sub
		Private Sub FillData()
			schedulerStorage.EnableReminders = False
			Me.schedulerStorage.Appointments.Mappings.End = "Finish"
			Me.schedulerStorage.Appointments.Mappings.Label = "SportID"
			Me.schedulerStorage.Appointments.Mappings.ResourceId = "ResourceID"
			Me.schedulerStorage.Appointments.Mappings.Start = "Start"
			Me.schedulerStorage.Appointments.Mappings.Subject = "Caption"
			Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"

			schedulerStorage.Appointments.DataSource = DemoUtils.GetSportEventsData()
			schedulerControl.Start = New DateTime(2016, 09, 15, 9, 0, 0)
		End Sub
		Private Sub AddSportChanels()
			schedulerStorage.BeginUpdate()
			AddResource(0, "SPORT TV 1")
			AddResource(1, "SPORT TV 2")
			AddResource(2, "SPORT TV 3")
			AddResource(3, "SPORT TV 4")
			AddResource(4, "TV 5")
			AddResource(5, "TV 6")
			AddResource(6, "TV 7")
			AddResource(7, "TV 8")
			schedulerStorage.EndUpdate()
		End Sub
		Private Sub AddResource(ByVal index As Integer, ByVal caption As String)
			Dim r As Resource = schedulerStorage.CreateResource(index.ToString())
			r.Caption = caption
			r.SetImage(Me.channelsImages.Images(index))
			r.SetColor(schedulerControl.ResourceColorSchemas.GetSchema(index).CellLight)
			schedulerStorage.Resources.Add(r)
		End Sub
		Private Sub FillFilterComboBox()
			Me.imcbSports.Properties.SmallImages = Me.sportsImages
			Me.imcbSports.Properties.LargeImages = Me.sportsImages
			Me.imcbSports.Properties.Items.Clear()
			Me.imcbSports.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem("All sports", -1, -1))
			For i As Integer = 0 To schedulerStorage.Appointments.Labels.Count - 1
				Dim lab As IAppointmentLabel = schedulerStorage.Appointments.Labels.GetByIndex(i)
				Me.imcbSports.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(lab.DisplayName, i, i))
			Next i
			Me.imcbSports.SelectedIndex = 0
		End Sub
		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			schedulerControl.BeginUpdate()
			Try
				AdjustResourceHeaders()
			Finally
				schedulerControl.EndUpdate()
			End Try
		End Sub
		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
		End Sub
		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			schedulerControl.BeginUpdate()
			Try
				AdjustResourceHeaders()
			Finally
				schedulerControl.EndUpdate()
			End Try
		End Sub
		Private Sub AdjustResourceHeaders()
			Dim height As Integer = 0
			Dim groupType As SchedulerGroupType = schedulerControl.GroupType
			If (TypeOf schedulerControl.ActiveView Is WeekView AndAlso groupType.Equals(SchedulerGroupType.Date)) OrElse (TypeOf schedulerControl.ActiveView Is TimelineView AndAlso (Not groupType.Equals(SchedulerGroupType.None))) Then
				height = 90
			End If

			schedulerControl.OptionsView.ResourceHeaders.Height = height
		End Sub
		Private Sub schedulerStorage_FilterAppointment(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage.FilterAppointment
			Dim sportId As Integer = Convert.ToInt32(Me.imcbSports.EditValue)
			If sportId < 0 Then
				Return
			End If

			Dim apt As Appointment = CType(e.Object, Appointment)
			e.Cancel = Convert.ToInt32(apt.LabelKey) <> sportId
		End Sub

		Private Sub imcbSports_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imcbSports.SelectedIndexChanged
			schedulerStorage.RefreshData()
		End Sub

		Private Sub schedulerControl_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs) Handles schedulerControl.InitAppointmentImages
			Dim info As New AppointmentImageInfo()
			info.Image = Me.sportsImages.Images(Convert.ToInt32(e.Appointment.LabelKey))
			e.ImageInfoList.Add(info)
		End Sub
	End Class
End Namespace
