Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Partial Public Class Report
		Inherits XtraSchedulerReport


		Private allowInitAppointmentText_Renamed As Boolean
		Private allowInitAppointmentImages_Renamed As Boolean
		Private showStartTime_Renamed As Boolean
		Private showEndTime_Renamed As Boolean
		Private statusDisplayType_Renamed As AppointmentStatusDisplayType
		Private timeDisplayType_Renamed As AppointmentTimeDisplayType
		Private showBell_Renamed As Boolean
		Private showRecurrence_Renamed As Boolean


		Private fCustomImages As ImageCollection
		Private Const CustomImagesOccurenceIndex As Integer = 0
		Private Const CustomImagesExceptionIndex As Integer = 1
		Private Const CustomImagesBizTripIndex As Integer = 2
		Private Const CustomImagesHolidayIndex As Integer = 3

		Public Sub New()

			InitializeComponent()
			Me.fCustomImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.appointment_icons.png"), System.Reflection.Assembly.GetExecutingAssembly(), New Size(15, 15))
		End Sub

		Public Property AllowInitAppointmentText() As Boolean
			Get
				Return allowInitAppointmentText_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowInitAppointmentText_Renamed = value
			End Set
		End Property
		Public Property AllowInitAppointmentImages() As Boolean
			Get
				Return allowInitAppointmentImages_Renamed
			End Get
			Set(ByVal value As Boolean)
				allowInitAppointmentImages_Renamed = value
			End Set
		End Property
		Public Property ShowStartTime() As Boolean
			Get
				Return showStartTime_Renamed
			End Get
			Set(ByVal value As Boolean)
				showStartTime_Renamed = value
			End Set
		End Property
		Public Property ShowEndTime() As Boolean
			Get
				Return showEndTime_Renamed
			End Get
			Set(ByVal value As Boolean)
				showEndTime_Renamed = value
			End Set
		End Property
		Public Property StatusDisplayType() As AppointmentStatusDisplayType
			Get
				Return statusDisplayType_Renamed
			End Get
			Set(ByVal value As AppointmentStatusDisplayType)
				statusDisplayType_Renamed = value
			End Set
		End Property
		Public Property TimeDisplayType() As AppointmentTimeDisplayType
			Get
				Return timeDisplayType_Renamed
			End Get
			Set(ByVal value As AppointmentTimeDisplayType)
				timeDisplayType_Renamed = value
			End Set
		End Property
		Public Property ShowBell() As Boolean
			Get
				Return showBell_Renamed
			End Get
			Set(ByVal value As Boolean)
				showBell_Renamed = value
			End Set
		End Property
		Public Property ShowRecurrence() As Boolean
			Get
				Return showRecurrence_Renamed
			End Get
			Set(ByVal value As Boolean)
				showRecurrence_Renamed = value
			End Set
		End Property

		Private Sub dayViewTimeCells1_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As AppointmentViewInfoCustomizingEventArgs) Handles dayViewTimeCells1.AppointmentViewInfoCustomizing
			Dim vi As AppointmentViewInfo = CType(e.ViewInfo, AppointmentViewInfo)
			vi.ShowStartTime = ShowStartTime
			vi.ShowEndTime = ShowEndTime
			vi.StatusDisplayType = StatusDisplayType
			vi.ShowTimeAsClock = TimeDisplayType.Equals(AppointmentTimeDisplayType.Clock)
			vi.ShowBell = ShowBell
			vi.ShowRecurrence = ShowRecurrence
		End Sub

		Private Sub dayViewTimeCells1_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs) Handles dayViewTimeCells1.InitAppointmentImages
			If (Not AllowInitAppointmentImages) Then
				Return
			End If

			Dim apt As Appointment = e.Appointment
			Dim c As AppointmentImageInfoCollection = e.ImageInfoList

			c.Clear()
			c.Images = fCustomImages
			If showBell_Renamed Then
				c.AddStandard(AppointmentImageType.Reminder)
			End If

			If e.Appointment.IsRecurring Then
				SetRecurrentAppointmentImages(c, e.Appointment.IsException)
			Else
				SetNotRecurrentAppointmentImages(c, e.Appointment)
			End If
		End Sub
		Private Sub SetRecurrentAppointmentImages(ByVal c As AppointmentImageInfoCollection, ByVal isException As Boolean)
			If (Not showRecurrence_Renamed) Then
				Return
			End If

			If isException Then
				AddImageByIndex(c, CustomImagesExceptionIndex)
			Else
				AddImageByIndex(c, CustomImagesOccurenceIndex)
			End If
		End Sub
		Private Sub SetNotRecurrentAppointmentImages(ByVal c As AppointmentImageInfoCollection, ByVal apt As Appointment)
			AddImageByIndex(c, CustomImagesBizTripIndex)
			AddImageByIndex(c, CustomImagesHolidayIndex)
		End Sub
		Private Sub AddImageByIndex(ByVal c As AppointmentImageInfoCollection, ByVal index As Integer)
			Dim info As New AppointmentImageInfo()
			info.ImageIndex = index
			c.Add(info)
		End Sub

		Private Sub dayViewTimeCells1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs) Handles dayViewTimeCells1.InitAppointmentDisplayText
			If (Not AllowInitAppointmentText) Then
				Return
			End If
			e.Text = String.Format("{0} [{1:F2} h]", e.Text, e.Appointment.Duration.TotalHours)
		End Sub
	End Class
End Namespace
