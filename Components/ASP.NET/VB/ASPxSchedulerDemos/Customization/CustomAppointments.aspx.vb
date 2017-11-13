Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Partial Public Class Customization_CustomAppointments
	Inherits System.Web.UI.Page
	Private Const CustomImagesOccurenceIndex As Integer = 0
	Private Const CustomImagesExceptionIndex As Integer = 1
	Private Const CustomImagesBizTripIndex As Integer = 2
	Private Const CustomImagesHolidayIndex As Integer = 3
	Private Const ImagePath As String = "~/Content/CustomAppointments/"
	Private customImages_Renamed As ImagePropertiesCollection

	Public Sub New()
		Me.customImages_Renamed = CreateCustomImages()
	End Sub

	Private ReadOnly Property IsCustomText() As Boolean
		Get
			Return chkCustomText.Checked
		End Get
	End Property
	Private ReadOnly Property IsDefaultImages() As Boolean
		Get
			Return rbListCustomImages.SelectedIndex = 0
		End Get
	End Property
	Private ReadOnly Property IsExternalImages() As Boolean
		Get
			Return rbListCustomImages.SelectedIndex = 1
		End Get
	End Property
	Private ReadOnly Property IsCustomImages() As Boolean
		Get
			Return rbListCustomImages.SelectedIndex = 2
		End Get
	End Property

	Private ReadOnly Property CustomImages() As ImagePropertiesCollection
		Get
			Return customImages_Renamed
		End Get
	End Property
	Private ReadOnly Property DisplayOptions() As AppointmentDisplayOptions
		Get
			Return ASPxScheduler1.ActiveView.GetAppointmentDisplayOptions()
		End Get
	End Property

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

		InitializeSchedulerControl()
	End Sub
	Protected Sub InitializeSchedulerControl()
		If IsExternalImages Then
			InitializeExternalImages()
		End If
		ApplyOptions()
	End Sub
	Protected Sub ApplyOptions()
		ASPxScheduler1.BeginUpdate()
		Try
			Dim options As AppointmentDisplayOptions = ASPxScheduler1.ActiveView.GetAppointmentDisplayOptions()
			options.TimeDisplayType = CType(cbTime.Value, AppointmentTimeDisplayType)
			options.StatusDisplayType = CType(cbStatus.Value, AppointmentStatusDisplayType)
			options.StartTimeVisibility = CType(cbStartTime.Value, AppointmentTimeVisibility)
			options.EndTimeVisibility = CType(cbEndTime.Value, AppointmentTimeVisibility)
			options.ContinueArrowDisplayType = CType(cbContinueArrow.Value, AppointmentContinueArrowDisplayType)
			options.ShowRecurrence = chkRecurrence.Checked
		Finally
			ASPxScheduler1.EndUpdate()
		End Try
		ASPxScheduler1.ApplyChanges(ASPxSchedulerChangeAction.RenderAppointments)
	End Sub
	Protected Sub InitializeExternalImages()
		Dim images As AppointmentImages = ASPxScheduler1.Images.Appointment
		images.DayClock.Url = ImagePath & "ExternalDayClock.png"
		images.NightClock.Url = ImagePath & "ExternalNightClock.png"
		images.Recurrence.Url = ImagePath & "ExternalRecurrence.png"
		images.NoRecurrence.Url = ImagePath & "ExternalException.png"
	End Sub
	Protected Function CreateCustomImages() As ImagePropertiesCollection
		Dim images As New ImagePropertiesCollection()
		AddCustomImage(images, "CustomReccurence.png")
		AddCustomImage(images, "CustomException.png")
		AddCustomImage(images, "CustomBizTrip.png")
		AddCustomImage(images, "CustomHoliday.png")
		Return images
	End Function
	Protected Sub AddCustomImage(ByVal target As ImagePropertiesCollection, ByVal fileName As String)
		Dim url As String = ImagePath & fileName
		Dim image As New ImageProperties(url)
		image.Width = Unit.Pixel(15)
		image.Height = Unit.Pixel(15)
		target.Add(image)
	End Sub
	Protected Sub ASPxSchedulerControl1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
		If IsCustomText Then
			Dim apt As Appointment = e.Appointment
			e.Text = String.Format("[{0}] {1}", apt.Location, apt.Subject)
			e.Description = String.Format("Details: {0}", apt.Description)
		End If
	End Sub
	Protected Sub ASPxSchedulerControl1_InitAppointmentImages(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.AppointmentImagesEventArgs)
		If IsCustomImages Then
			Dim apt As Appointment = e.Appointment
			Dim c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection = e.ImageInfoList

			c.Clear()
			c.Images = CustomImages

			If e.Appointment.IsRecurring Then
				AddRecurrentAppointmentImages(c, e.Appointment.IsException)
			Else
				AddNotRecurrentAppointmentImages(c)
			End If

			If DisplayOptions.ShowReminder AndAlso apt.HasReminder Then
				AddImageByType(c, AppointmentImageType.Reminder)
			End If
		End If
	End Sub
	Private Sub AddNotRecurrentAppointmentImages(ByVal c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection)
		AddImageByIndex(c, CustomImagesBizTripIndex)
		AddImageByIndex(c, CustomImagesHolidayIndex)
	End Sub
	Private Sub AddRecurrentAppointmentImages(ByVal c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection, ByVal isException As Boolean)
		If (Not DisplayOptions.ShowRecurrence) Then
			Return
		End If
		If isException Then
			AddImageByIndex(c, CustomImagesExceptionIndex)
			AddImageByUrl(c, "~/Content/CustomAppointments/Warning.png", Unit.Pixel(24), Unit.Pixel(24))
		Else
			AddImageByIndex(c, CustomImagesOccurenceIndex)
		End If
	End Sub
	Private Sub AddImageByIndex(ByVal c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection, ByVal index As Integer)
		Dim info As New DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo()
		info.ImageIndex = index
		c.Add(info)
	End Sub
	Private Sub AddImageByUrl(ByVal c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection, ByVal url As String, ByVal width As Unit, ByVal height As Unit)
		Dim imageProperties As New ImageProperties(url)
		imageProperties.Width = width
		imageProperties.Height = height
		Dim info As New DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfo()
		info.ImageProperties = imageProperties
		c.Add(info)
	End Sub
	Private Sub AddImageByType(ByVal c As DevExpress.Web.ASPxScheduler.Drawing.AppointmentImageInfoCollection, ByVal type As AppointmentImageType)
		c.AddStandard(type)
	End Sub

	Protected Sub ASPxScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyOptions()
	End Sub
End Class
