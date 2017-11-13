Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports System.Drawing
Imports System.Web
Imports System.Xml.Linq
Imports System.Linq
Imports System.Xml.Serialization
Imports System.IO
Imports System.Globalization

Public Class CustomFileldNames
	Public Const Speaker As String = "Speaker"
	Public Const CategoryName As String = "CategoryName"
	Public Const Level As String = "Level"
End Class

Public Enum SessionInterest
	NotInterest
	Interest
	HighInterest
End Enum

Public Class Speaker
	Public Property Name() As String
	Public Property ImageName() As String
	Public Property Description() As String
End Class

Public Class Section
	Public Property Name() As String
End Class

Public Class Category
	Public Property Name() As String
	Public Property Key() As String

	Public Property Id() As Integer
	Public Property Color() As Color
End Class
Public Class PersonalData
	Public Property Completed() As Boolean
	Public Property FirstName() As String
	Public Property LastName() As String
	Public Property JobTitle() As String
	Public Property CompanyName() As String
	Public Property City() As String
	Public Property Phone() As String
	Public Property Email() As String
	Public Property Address() As String
	Public Property FullName() As String

	Public Sub New()
		Completed = False
	End Sub
End Class

Public Class Session
	Public Sub New()
	End Sub
	Public Sub New(ByVal session As Session)
		Subject = session.Subject
		Description = session.Description
		Location = session.Location
		Speaker = session.Speaker
		CategoryKey = session.CategoryKey
		StartTime = session.StartTime
		EndTime = session.EndTime
		Level = session.Level
		Featured = session.Featured
		Image = session.Image
		SpeakerDescription = session.SpeakerDescription

		Id = session.Id
		Interest = session.Interest
	End Sub

	Public Property Subject() As String
	Public Property Description() As String
	Public Property Location() As String
	Public Property Speaker() As String
	Public Property CategoryKey() As String
	Public Property StartTimeString() As String
	Public Property EndTimeString() As String
	Public Property Level() As Integer
	Public Property Featured() As Boolean
	Public Property Image() As String
	Public Property SpeakerDescription() As String

	Private id_Renamed As String
	<XmlIgnore> _
	Public Property Id() As String
		Get
			If Me.id_Renamed Is Nothing Then
				Me.id_Renamed = HttpUtility.UrlEncode(Subject.Replace(" "c, "_"c))
			End If
			Return Me.id_Renamed
		End Get
		Set(ByVal value As String)
			Me.id_Renamed = value
		End Set
	End Property
	<XmlIgnore> _
	Public ReadOnly Property Index() As Integer
		Get
			Return DataHelper.Data.Sessions.IndexOf(Me)
		End Get
	End Property
	<XmlIgnore> _
	Public ReadOnly Property Category() As Category
		Get
			Dim category_Renamed As Category = DataHelper.Data.Categories.Find(Function(c) c.Key = CategoryKey)
			Return If(category_Renamed Is Nothing, DataHelper.Data.Categories(1), category_Renamed)
		End Get
	End Property
	<XmlIgnore> _
	Public Property CategoryId() As Integer
		Get
			Return Category.Id
		End Get
		Set(ByVal value As Integer)
		End Set
	End Property
	<XmlIgnore> _
	Public Property CategoryName() As String
		Get
			Return Category.Name
		End Get
		Set(ByVal value As String)
		End Set
	End Property
	Public Property StartTime() As DateTime
	Public Property EndTime() As DateTime

	Public Property Interest() As Integer
End Class

Public Class Break
	Public Property Subject() As String
	Public Property StartTimeString() As String
	Public Property EndTimeString() As String
End Class

Public Class ConferenceDay
	Public Sub New()
		Sessions = New List(Of Session)()
	End Sub
	Public Property Sessions() As List(Of Session)
	Public Property Breaks() As List(Of Break)
End Class

<XmlRoot("EventRegistration")> _
Public Class EventRegistrationData
	Private Shared ReadOnly DefaultColors As New List(Of Color)() From {Color.FromArgb(55, 186, 255), Color.FromArgb(212, 98, 180), Color.FromArgb(100, 203, 16), Color.FromArgb(168, 99, 255), Color.MediumPurple, Color.Aqua, Color.Firebrick}
	Private Shared ReadOnly StartDate As DateTime = DateTime.Now.Date.AddDays(15)

	Public Sub New()
		Speakers = New List(Of Speaker)()
		Sections = New List(Of Section)()
		Categories = New List(Of Category)()
		Days = New List(Of ConferenceDay)()
		Sessions = New SessionList()
		Breaks = New List(Of TimeInterval)()
	End Sub
	Public Property Speakers() As List(Of Speaker)
	Public Property Sections() As List(Of Section)
	Public Property Categories() As List(Of Category)
	Public Property Days() As List(Of ConferenceDay)

	Public Property Sessions() As SessionList
	Public Property Breaks() As List(Of TimeInterval)

	Public Function GetDate(ByVal day As Integer) As DateTime
		Return StartDate.AddDays(day)
	End Function
	Public Function GetDay(ByVal [date] As DateTime) As Integer
		Return ([date].Subtract(StartDate)).Days
	End Function

	Public Sub Initialize()
		InitializeCategories()
		InitializeSessions()
		InitializeBreaks()
	End Sub
	Private Sub InitializeCategories()
		For i As Integer = 0 To Categories.Count - 1
			Dim category As Category = Categories(i)
			category.Id = i
			category.Color = If((i >= 0 AndAlso i < DefaultColors.Count), DefaultColors(i), Color.Transparent)
		Next i
	End Sub
	Private Sub InitializeSessions()
		For i As Integer = 0 To Days.Count - 1
			Dim day As ConferenceDay = Days(i)
			For Each session As Session In day.Sessions
				Sessions.Add(session)
				session.StartTime = GetDate(i).Add(ParseDateTime(session.StartTimeString).TimeOfDay)
				session.EndTime = GetDate(i).Add(ParseDateTime(session.EndTimeString).TimeOfDay)
			Next session
		Next i
	End Sub
	Private Sub InitializeBreaks()
		For i As Integer = 0 To Days.Count - 1
			Dim day As ConferenceDay = Days(i)
			For Each _break As Break In day.Breaks
				Breaks.Add(New TimeInterval(GetDate(i).Add(ParseDateTime(_break.StartTimeString).TimeOfDay), GetDate(i).Add(ParseDateTime(_break.EndTimeString).TimeOfDay)))
			Next _break
		Next i
	End Sub
	Private Function ParseDateTime(ByVal val As String) As DateTime
		Return DateTime.Parse(val, CultureInfo.InvariantCulture)
	End Function
End Class

Public NotInheritable Class DataHelper
	Public Const StarsPhotoFolder As String = "~/Images/Stars/"
	Public Const FeaturedSessionsFolder As String = "~/Images/FeaturedSessions/"
	Private Const xmlDataBaseFilePath As String = "~\App_Data\Sessions.xml"
	Private Const xmlSpeakersFilePath As String = "~\App_Data\Speakers.xml"

	Private Shared data_Renamed As EventRegistrationData
	Private Sub New()
	End Sub
	Public Shared Property Data() As EventRegistrationData
		Get
			Return data_Renamed
		End Get
		Private Set(ByVal value As EventRegistrationData)
			data_Renamed = value
		End Set
	End Property

	'load
	Public Shared Sub LoadDataBase()
		Dim serializer As New XmlSerializer(GetType(EventRegistrationData))
		Using dataFile As FileStream = File.OpenRead(HttpContext.Current.Server.MapPath(xmlDataBaseFilePath))
			Data = CType(serializer.Deserialize(dataFile), EventRegistrationData)
			Data.Initialize()
		End Using
	End Sub

   'setup scheduler
	Public Shared Sub Setup(ByVal storage As ASPxSchedulerStorage)
		storage.BeginUpdate()
		Try
			SetLabelCollection(storage.Appointments.Labels)
			SetStatusCollection(storage.Appointments.Statuses)
			FillResources(storage.Resources.Items)
		Finally
			storage.EndUpdate()
		End Try
	End Sub

	Private Shared Sub FillResources(ByVal resources As ResourceCollection)
		For i As Integer = 0 To Data.Sections.Count - 1
			Dim sectionName As String = Data.Sections(i).Name
			Dim resource As Resource = resources.Storage.CreateResource(sectionName)
			resource.Caption = sectionName
			resources.Add(resource)
		Next i
	End Sub

	Private Shared Sub SetStatusCollection(ByVal statuses As AppointmentStatusCollection)
		statuses.Clear()
		For Each category As Category In Data.Categories
			Dim status As IAppointmentStatus = statuses.CreateNewStatus(category.Key)
			status.SetColor(category.Color)
		Next category
	End Sub

	Private Shared Sub SetLabelCollection(ByVal labels As AppointmentLabelCollection)
		labels.Clear()
		Dim notInterestLabel As IAppointmentLabel = labels.CreateNewLabel(SessionInterest.NotInterest.ToString())
		notInterestLabel.SetColor(ColorTranslator.FromHtml("#FFFFFF"))

		Dim interestLabel As IAppointmentLabel = labels.CreateNewLabel(SessionInterest.Interest.ToString())
		interestLabel.SetColor(ColorTranslator.FromHtml("#FFF8CA"))

		Dim highInterestLabel As IAppointmentLabel = labels.CreateNewLabel(SessionInterest.HighInterest.ToString())
		highInterestLabel.SetColor(ColorTranslator.FromHtml("#FFD2E0"))

		labels.Add(notInterestLabel)
		labels.Add(interestLabel)
		labels.Add(highInterestLabel)
	End Sub
End Class
