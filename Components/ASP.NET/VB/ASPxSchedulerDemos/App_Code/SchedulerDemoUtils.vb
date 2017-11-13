Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml.XPath
Imports DevExpress.Schedule
Imports DevExpress.Schedule.Serializing
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Xml
Imports System.Web.UI

Public Class SchedulerDemoUtils
	Private Shared baseDate_Renamed As New DateTime(2016, 10, 10)
	Public Shared RandomInstance As New Random()
	Public Shared Users() As String = { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett", "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" }

	Public Shared ReadOnly Property BaseDate() As DateTime
		Get
			Return baseDate_Renamed
		End Get
	End Property
	Public Shared Sub FillResources(ByVal storage As ASPxSchedulerStorage, ByVal count As Integer)
		Dim resources As ResourceCollection = storage.Resources.Items
		storage.BeginUpdate()
		Try
			Dim cnt As Integer = Math.Min(count, Users.Length)
			For i As Integer = 1 To cnt
				Dim resource As Resource = storage.CreateResource(i)
				resource.Caption = Users(i - 1)
				resources.Add(resource)
			Next i
		Finally
			storage.EndUpdate()
		End Try
	End Sub
	Public Shared Sub ApplyDefaults(ByVal page As UserControl, ByVal scheduler As ASPxScheduler)
		If page.IsPostBack Then
			Return
		End If
		ApplyDefaultsCore(scheduler)
	End Sub
	Public Shared Sub ApplyDefaults(ByVal page As Page, ByVal scheduler As ASPxScheduler)
		If page.IsPostBack Then
			Return
		End If
		ApplyDefaultsCore(scheduler)
	End Sub
	Private Shared Sub ApplyDefaultsCore(ByVal scheduler As ASPxScheduler)
		scheduler.Start = BaseDate
		scheduler.OptionsView.ResourceHeaders.ImageAlign = HeaderImageAlign.Top
	End Sub
	Public Shared Sub ApplyWorkTime(ByVal page As Page, ByVal scheduler As ASPxScheduler)
		If page.IsPostBack Then
			Return
		End If
		ApplyWorkTime(scheduler.Views.DayView)
		ApplyWorkTime(scheduler.Views.WorkWeekView)
		ApplyWorkTime(scheduler.Views.FullWeekView)
	End Sub
	Private Shared Sub ApplyWorkTime(ByVal view As DevExpress.Web.ASPxScheduler.DayView)
		view.WorkTime.Start = TimeSpan.FromHours(7)
		view.WorkTime.End = TimeSpan.FromHours(20)
		view.ShowWorkTimeOnly = True
	End Sub
	Public Shared Function LoadHolidaysFromXml(ByVal uri As String, ByVal location As String) As HolidayBaseCollection
		Dim document As New XPathDocument(uri)
		Dim navigator As XPathNavigator = document.CreateNavigator()

		Dim xPath As String = String.Format("/Holidays/Holiday[@Location='{0}']", location)
		Dim nodes As XPathNodeIterator = navigator.Select(xPath)

		Dim sb As New StringBuilder()
		sb.AppendLine("<Holidays>")
		Do While nodes.MoveNext()
			sb.AppendLine(nodes.Current.OuterXml)
		Loop
		sb.AppendLine("</Holidays>")

		Return HolidayCollectionXmlPersistenceHelper.ObjectFromXml(sb.ToString())
	End Function


	#Region "Custom Events"
	Public Shared Function CreateCustomEvents() As CustomEventList
		Return CreateCustomEvents(False)
	End Function
	Public Shared Function CreateCustomEvents(ByVal resourceSharing As Boolean) As CustomEventList
		Dim events As New CustomEventList()
		PopulateRentals(events, resourceSharing)
		PopulateMaintenance(events, resourceSharing)
		Return events
	End Function
	Private Shared Sub PopulateRentals(ByVal events As CustomEventList, ByVal resourceSharing As Boolean)
		Dim customers() As String = { "Mr.Brown", "Mr.White", "Mrs.Black", "Mr.Green" }
		Dim locations() As String = { "city", "out of town" }
		Dim count As Integer = 20
		For i As Integer = 0 To count - 1
			events.Add(CreateRental(customers, locations, resourceSharing))
		Next i
		CreatePriorityRentals(events, resourceSharing, customers, locations)
	End Sub
	Private Shared Sub CreatePriorityRentals(ByVal events As CustomEventList, ByVal resourceSharing As Boolean, ByVal customers() As String, ByVal locations() As String)
		Dim priorityDates As New List(Of DateTime)()
		For i As Integer = -5 To 2
			priorityDates.Add(baseDate_Renamed.AddDays(i))
		Next i

		Dim startHourSectors() As Integer = {11}
		For resourceId As Integer = 0 To ResourceCount - 1
			For Each priorityDate As DateTime In priorityDates
				For Each startHourSector As Integer In startHourSectors
					events.Add(CreateRental(resourceId, customers, locations, resourceSharing, priorityDate, startHourSector))
				Next startHourSector
			Next priorityDate
		Next resourceId
	End Sub
	Private Shared Function CreateRental(ByVal resourceId As Integer, ByVal customers() As String, ByVal locations() As String, ByVal resourceSharing As Boolean, ByVal baseDate As DateTime, ByVal startHourSector As Integer) As CustomEvent
		Dim rnd As Random = SchedulerDemoUtils.RandomInstance

		Dim result As New CustomEvent()
		result.Subject = customers(rnd.Next(0, customers.Length))
		result.Location = locations(rnd.Next(0, locations.Length))
		result.Description = "Rent this car"

		Dim offset As TimeSpan = TimeSpan.FromHours(rnd.Next(startHourSector, startHourSector + 4))
		result.StartTime = baseDate.Add(offset)
		result.EndTime = result.StartTime + TimeSpan.FromHours(rnd.Next(1, 4))
		result.OwnerId = CalculateResourceIdOrIds(resourceSharing, resourceId)
		result.Status = 2
		result.Label = rnd.Next(0, 7)
		result.ID = Guid.NewGuid()
		AddEventAdditionalInfo(result)
		Return result
	End Function
	Private Shared Function CreateRental(ByVal customers() As String, ByVal locations() As String, ByVal resourceSharing As Boolean) As CustomEvent
		Dim rnd As Random = SchedulerDemoUtils.RandomInstance

		Dim result As New CustomEvent()
		result.Subject = customers(rnd.Next(0, customers.Length))
		result.Location = locations(rnd.Next(0, locations.Length))
		result.Description = "Rent this car"

		Dim rangeInDays As Integer = 7
		Dim rangeInHours As Integer = 18
		Dim offset As TimeSpan = TimeSpan.FromDays(rnd.Next(0, rangeInDays)) + TimeSpan.FromHours(rnd.Next(0, rangeInHours))
		result.StartTime = baseDate_Renamed.Add(offset)
		result.EndTime = result.StartTime + TimeSpan.FromHours(rnd.Next(1, rangeInHours))
		result.OwnerId = CalculateResourceIdOrIds(resourceSharing)
		result.Status = 2
		result.Label = rnd.Next(0, 7)
		result.ID = Guid.NewGuid()
		AddEventAdditionalInfo(result)
		Return result
	End Function
	Private Shared Sub PopulateMaintenance(ByVal events As CustomEventList, ByVal resourceSharing As Boolean)
		Dim wash As New CustomEvent()
		wash.Subject = "Wash"
		wash.Description = "Wash this car in the garage"
		wash.Location = "Garage"
		wash.StartTime = baseDate_Renamed + TimeSpan.FromHours(7)
		wash.EndTime = baseDate_Renamed + TimeSpan.FromHours(8)
		wash.OwnerId = CalculateResourceIdOrIds(resourceSharing)
		wash.Status = 1
		wash.Label = 2
		wash.EventType = 1
		wash.RecurrenceInfo = "<RecurrenceInfo AllDay=""False"" DayNumber=""1"" DayOfMonth=""0"" WeekDays=""42"" Id=""51c81018-53fa-4d10-925f-2ed7f8408c75"" Month=""12"" OccurenceCount=""19"" Periodicity=""1"" Range=""2"" Start=""7/11/2008 7:00:00"" End=""8/24/2008 1:00:00"" Type=""1"" />"
		wash.ID = Guid.NewGuid()
		AddEventAdditionalInfo(wash)
		events.Add(wash)
	End Sub
	Private Shared Sub AddEventAdditionalInfo(ByVal ev As CustomEvent)
		Dim info() As String = { "Email: info{0}@wash_garage.com", "cellular: +530145961{0}", "Address: WA Seattle {0} - 24th Ave. S.Suite 4B phone: (206) 555-4{0}", "Contact: Address: OR Elgin City Center Plaza {0} Main St.", "Phone: (262) 946-9{0}; w ({0}) 723-2678 x22, cell (253) 713-0{0}, fax (361) 733-2{0}" }
		Dim rnd As Random = SchedulerDemoUtils.RandomInstance

		Dim infoTemplate As String = info(rnd.Next(0, info.Length))
		Dim ch As Char = Char.Parse(rnd.Next(1, 9).ToString())
		ev.ContactInfo = String.Format(infoTemplate, New String(ch, 3))
	End Sub
	Private Shared Function CalculateResourceIdOrIds(ByVal resourceSharing As Boolean) As Object
		If resourceSharing Then
			Dim resourceIdList As List(Of Integer) = GetRandomResourceIdSequence()
			Return GenerateResourceIdsString(resourceIdList.ToArray())
		Else
			Return GetRandomResourceId()
		End If
	End Function
	Private Shared Function CalculateResourceIdOrIds(ByVal resourceSharing As Boolean, ByVal resourceId As Integer) As Object
		If resourceSharing Then
			Dim resourceIdList As New List(Of Integer)()
			resourceIdList.Add(resourceId)
			Return GenerateResourceIdsString(resourceIdList.ToArray())
		Else
			Return resourceId
		End If
	End Function
	Private Shared Function GetRandomResourceIdSequence() As List(Of Integer)
		Dim expectedCount As Integer = GetRandomResourceId()
		Dim result As New List(Of Integer)()
		For i As Integer = 0 To expectedCount - 1
			Dim tryCounter As Integer = 0
			Do
				Dim id As Integer = GetRandomResourceId()
				If result.IndexOf(id) = -1 Then
					result.Add(id)
					Exit Do
				End If
				If tryCounter > 10 Then
					Exit Do
				End If
				tryCounter += 1
			Loop
		Next i
		Return result
	End Function
	Private Shared Function GetRandomResourceId() As Integer
		Return SchedulerDemoUtils.RandomInstance.Next(1, 6)
	End Function
	Private Shared Function GenerateResourceIdsString(ByVal resourceIds() As Integer) As String
		Dim resourceIdCollection As New ResourceIdCollection()
		Dim count As Integer = resourceIds.Length
		For i As Integer = 0 To count - 1
			resourceIdCollection.Add(resourceIds(i))
		Next i
		Dim helper As New AppointmentResourceIdCollectionXmlPersistenceHelper(resourceIdCollection)
		Return helper.ToXml()
	End Function
	#End Region

	#Region "Custom Resources"
	Private Const ResourceCount As Integer = 5
	Public Shared Function CreateCustomResurces() As CustomResourceList
		Dim resources As New CustomResourceList()
		resources.Add(CreateCustomResource(1, "SL500 Roadster"))
		resources.Add(CreateCustomResource(2, "CLK55 AMG Cabriolet"))
		resources.Add(CreateCustomResource(3, "C230 Kompressor Sport Coupe"))
		resources.Add(CreateCustomResource(4, "530i"))
		resources.Add(CreateCustomResource(5, "Corniche"))
		Return resources
	End Function
	Private Shared Function CreateCustomResource(ByVal id As Integer, ByVal caption As String) As CustomResource
		Dim result As New CustomResource()
		result.ID = id
		result.Caption = caption
		Return result
	End Function
	#End Region
End Class
