Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Native
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq

Namespace DevExpress.XtraScheduler.Demos
	Public NotInheritable Class MedicScheduleDataHelper

		Public Shared BaseDate As DateTime = DateTime.Today

		Public Shared AppointmentTypes() As String = { "Hospital", "Office", "Phone Consultation", "Home", "Hospice" }
		Public Shared AppointmentColorTypes() As Color = { Color.FromArgb(168, 213, 255), Color.FromArgb(255, 194, 190), Color.FromArgb(255, 247, 165), Color.FromArgb(193, 244, 156), Color.FromArgb(244, 206, 147) }

		Public Shared PaymentStates() As String = { "Paid", "Unpaid" }
		Public Shared PaymentColorStates() As Color = { Color.Green, Color.Red }

		Public Shared PatientNames() As String = { "Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith", "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell", "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander", "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer", "Samantha Piper", "Maggie Boxter", "Terry Bradley", "Stu Pizaro", "Greta Sims", "Sandra Johnson", "Cindy Stanwick", "Marcus Orbison", "Sandy Bright", "Ken Samuelson", "Brett Wade", "Wally Hobbs", "Brad Jameson", "Karen Goodson", "Morgan Kennedy", "Violet Bailey", "John Heart", "Arthur Miller", "Robert Reagan", "Ed Holmes", "Sammy Hill", "Olivia Peyton", "Jim Packard", "Hannah Brookly", "Harv Mudd", "Todd Hoffman", "Kevin Carter","Mary Stern", "Robin Cosworth","Jenny Hobbs", "Dallas Lou"}

		Public Shared departmentCache As New Dictionary(Of String, String())()

		Private Shared rnd As New Random()

		Private Sub New()
		End Sub
		Shared Sub New()
			departmentCache.Add("Therapy", New String() { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" })
			departmentCache.Add("Ophthalmology", New String() { "Lucy Ball" })
			departmentCache.Add("Dentistry", New String() { "ClarkMorgan", "Leah Simpson" })
			departmentCache.Add("Surgery", New String() { "Davey Jones" })
			departmentCache.Add("Neurology", New String() { "Samantha Bright" })
		End Sub

		Public Shared Function CreatePatients() As List(Of Patient)
			Dim patients As New List(Of Patient)()
			Dim patientCount As Integer = PatientNames.Length
			Dim patientId As Integer = 1
			Dim birthday As New DateTime(1975, 2, 5)
			For i As Integer = 0 To patientCount - 1
				Dim patient As New Patient()
				patient.Id = patientId
				patientId += 1
				patient.Name = PatientNames(i)
				patient.Birthday = birthday.AddMonths(rnd.Next(1, 12)).AddYears(rnd.Next(0, 20))
				patient.Phone = "(" & rnd.Next(10, 99) & ") " & rnd.Next(100, 999) & "-" & rnd.Next(1000, 9999)
				patients.Add(patient)
			Next i
			Return patients
		End Function

		Public Shared Function CreateHospitalDepartments() As List(Of HospitalDepartment)
			Dim departments As New List(Of HospitalDepartment)()
			Dim departmentId As Integer = 1
			For Each name As String In departmentCache.Keys
				Dim department As New HospitalDepartment()
				department.Id = departmentId
				departmentId += 1
				department.Name = name
				departments.Add(department)
			Next name
			Return departments
		End Function

		Public Shared Function CreateMedics(ByVal hospitalDepartments As List(Of HospitalDepartment)) As List(Of Medic)
			Dim departmentCache As Dictionary(Of String, String()) = MedicScheduleDataHelper.departmentCache
			Dim medics As New List(Of Medic)()
			Dim departmentId As Integer = 1
			Dim medicId As Integer = 1
			For Each department As KeyValuePair(Of String, String()) In departmentCache
				Dim medicNames() As String = department.Value
				Dim medicCount As Integer = medicNames.Length
				For i As Integer = 0 To medicCount - 1
					Dim medic As New Medic()
					medic.Id = medicId
					medicId += 1
					medic.Name = medicNames(i)
					medic.Phone = "(" & rnd.Next(10, 99) & ") " & rnd.Next(100, 999) & "-" & rnd.Next(1000, 9999)
					medic.DepartmentId = departmentId
					Dim imageName As String = String.Format("MedicData.Images.{0}.png", medic.Name.Replace(" ", ""))
					If DemoUtils.FindResourceName(imageName) IsNot String.Empty Then
						Dim image As Image = ResourceImageHelper.CreateImageFromResources(DemoUtils.FindResourceName(imageName), System.Reflection.Assembly.GetExecutingAssembly())
						medic.SetPhoto(image)
					End If
					medics.Add(medic)
				Next i
				departmentId += 1
			Next department
			Return medics
		End Function

		Public Shared Function CreateMedicalAppointments(ByVal resources As List(Of Medic)) As List(Of MedicalAppointment)
			Dim appointments As New List(Of MedicalAppointment)()
			Dim patients As List(Of Patient) = CreatePatients()
			Dim appointmentId As Integer = 1
			Dim patientIndex As Integer = 0
			Dim [date] As DateTime = DateTimeHelper.GetStartOfWeek(BaseDate)
			For Each medic As Medic In resources
				Dim duration As TimeSpan = CalculateAppointmentDuration(medic)
				Dim firstDate As New DateTime([date].Year, [date].Month, [date].Day, rnd.Next(9, 11), 0, 0)
				Dim startDate As DateTime = firstDate
				Do While startDate < firstDate.AddDays(10)
					Dim endTime As New TimeSpan(18, 0, 0)
					endTime = endTime.Add(-duration)
					Dim endDate As New DateTime(startDate.Year, startDate.Month, startDate.Day, endTime.Hours, endTime.Minutes, 0)
					Dim room As Integer = rnd.Next(1, 100)
					Dim startTime As DateTime = startDate
					Do While startTime < endDate
						appointments.Add(CreateMedicAppointment(appointmentId, medic.Id, patients(patientIndex), startTime, duration, room))
						appointmentId += 1
						patientIndex += 1
						If patientIndex >= patients.Count() - 1 Then
							patientIndex = 1
						End If
						startTime = startTime.Add(duration).Add(New TimeSpan(0, rnd.Next(2, 4) * 10, 0))
					Loop
					startDate = startDate + TimeSpan.FromDays(1)
				Loop
			Next medic
			Return appointments
		End Function

		Public Shared Sub CreateLabels(ByVal storage As SchedulerStorage)
			Dim labels As AppointmentLabelCollection = storage.Appointments.Labels
			labels.Clear()
			Dim count As Integer = AppointmentTypes.Length
			For i As Integer = 0 To count - 1
				labels.Add(AppointmentColorTypes(i), AppointmentTypes(i))
			Next i
		End Sub

		Public Shared Sub CreateStatuses(ByVal storage As SchedulerStorage)
			Dim statuses As AppointmentStatusCollection = storage.Appointments.Statuses
			statuses.Clear()
			Dim count As Integer = PaymentStates.Length
			For i As Integer = 0 To count - 1
				statuses.Add(PaymentColorStates(i), PaymentStates(i))
			Next i
		End Sub

		Private Shared Function CalculateAppointmentDuration(ByVal resource As Medic) As TimeSpan
			Select Case resource.DepartmentId
				Case 1
					Return New TimeSpan(0, rnd.Next(2, 4) * 10, 0)
				Case 2
					Return New TimeSpan(0, rnd.Next(3, 6) * 10, 0)
				Case 3
					Return New TimeSpan(rnd.Next(0, 1), rnd.Next(3, 4) * 10, 0)
				Case 4
					Return New TimeSpan(rnd.Next(0, 1), rnd.Next(2, 5) * 10, 0)
				Case 5
					Return New TimeSpan(0, rnd.Next(2, 3) * 10, 0)
				Case Else
					Return New TimeSpan(0, rnd.Next(2, 3) * 10, 0)
			End Select
		End Function

		Private Shared Function CreateMedicAppointment(ByVal appointmentId As Long, ByVal resourceId As Long, ByVal patient As Patient, ByVal start As DateTime, ByVal duration As TimeSpan, ByVal room As Integer) As MedicalAppointment
			Dim medicalAppointment As New MedicalAppointment()
			medicalAppointment.Id = appointmentId
			medicalAppointment.StartTime = start
			medicalAppointment.EndTime = start.Add(duration)
			medicalAppointment.IssueId = rnd.Next(0, 5)
			medicalAppointment.PaymentStatusId = rnd.Next(0, 2)
			medicalAppointment.PatientId = patient.Id
			medicalAppointment.MedicId = resourceId
			If medicalAppointment.IssueId <> 3 Then
				medicalAppointment.Location = String.Format("{0}", room)
			End If
			Return medicalAppointment
		End Function
	End Class
End Namespace
