Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Logify
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Outlook
Imports DevExpress.XtraScheduler.Outlook.Interop
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos
	''' <summary>
	''' Summary description for DemoUtils.
	''' </summary>
	Public Class DemoUtils
		Public Const aptDataResourceName As String = "Data.appointments.xml"
		Public Const resDataResourceName As String = "Data.resources.xml"
		Public Const aptReportDataResourceName As String = "Data.ReportAppointments.xml"
		Public Const resReportDataResourceName As String = "Data.ReportResources.xml"
		Public Const sportEventsResourceName As String = "Data.sportevents.xml"

		Public Shared RandomInstance As New Random()

		'public static string[] Users = new string[] {"Peter Dolan", "Ryan Fischer", "Richard Fisher",
		'                                         "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain",
		'                                         "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman",
		'                                         "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"};
		Public Shared Users() As String = { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett", "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" }

		Private Shared taskDescriptions() As String = { "Implementing DevExpress MasterView control into Accounting System.", "Web Edition: Data Entry Page. The issue with date validation.", "Payables Due Calculator. It is ready for testing.", "Web Edition: Search Page. It is ready for testing.", "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.", "Receivables Calculator. Where can I found the complete specs", "Ledger: Inconsistency. Please fix it.", "Receivables Printing. It is ready for testing.", "Screen Redraw. Somebody has to look at it.", "Email System. What library we are going to use?", "Adding New Vendors Fails. This module doesn't work completely!", "History. Will we track the sales history in our system?", "Main Menu: Add a File menu. File menu is missed!!!", "Currency Mask. The current currency mask in completely inconvinience.", "Drag & Drop. In the schedule module drag & drop is not available.", "Data Import. What competitors databases will we support?", "Reports. The list of incomplete reports.", "Data Archiving. This features is still missed in our application", "Email Attachments. How to add the multiple attachment? I did not find a way to do it.", "Check Register. We are using different paths for different modules.", "Data Export. Our customers asked for export into Excel"}


		Public Shared [Date] As New DateTime(2016, 6, 15)
		Public Shared ReportPrintColorSchema As PrintColorSchema = PrintColorSchema.FullColor

		Private Shared outlookCalendarPaths_Renamed() As String = Nothing

		Public Shared ReadOnly Property OutlookCalendarPaths() As String()
			Get
				If outlookCalendarPaths_Renamed IsNot Nothing Then
					Return outlookCalendarPaths_Renamed
				End If
				Try
					outlookCalendarPaths_Renamed = OutlookExchangeHelper.GetOutlookCalendarPaths()
				Catch e As System.Exception
					ReportOutlookError("get the list of available calendars from Microsoft Outlook", e.Message)
					outlookCalendarPaths_Renamed = New String(){}
				End Try
				Return outlookCalendarPaths_Renamed
			End Get
		End Property

		Public Shared Sub FillData(ByVal control As SchedulerControl)
			control.DataStorage.EnableReminders = False
			FillStorageData(control.DataStorage)
			control.Start = [Date]
			Dim dayView As DayView = TryCast(control.ActiveView, DayView)
			If dayView IsNot Nothing Then
				dayView.TopRowTime = TimeSpan.FromHours(9)
			End If
			'control.OptionsBehavior.ShowRemindersForm = false;
		End Sub
		Public Shared Sub FillResources(ByVal storage As ISchedulerStorage, ByVal count As Integer)
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
		Public Shared Sub FillAppointmentStatuses(ByVal storage As SchedulerStorage)
			storage.BeginUpdate()
			Try
				Dim statuses As AppointmentStatusCollection = storage.Appointments.Statuses
				statuses.Clear()
				statuses.Add(Color.White, "Free", "Free")
				statuses.Add(Color.SkyBlue, "Wash", "Wash")
				statuses.Add(Color.SteelBlue, "Maintenance", "Maintenance")
				statuses.Add(Color.YellowGreen, "Rent", "Rent")
				statuses.Add(Color.Coral, "CheckUp", "CheckUp")
			Finally
				storage.EndUpdate()
			End Try

		End Sub
		Public Shared Sub FillStorageData(ByVal storage As ISchedulerStorage)
			FillStorageCollection(storage.Resources.Items, resDataResourceName)
			FillStorageCollection(storage.Appointments.Items, aptDataResourceName)
		End Sub
		Public Shared Sub FillReportsStorageData(ByVal storage As ISchedulerStorage)
			FillStorageCollection(storage.Resources.Items, resReportDataResourceName)
			FillStorageCollection(storage.Appointments.Items, aptReportDataResourceName)
		End Sub
		Public Shared Sub FillStorageResources(ByVal storage As ISchedulerStorage)
			FillStorageCollection(storage.Resources.Items, resDataResourceName)
		End Sub

		Public Shared Function FindResourceName(ByVal resourceName As String) As String
			Dim resourceNames() As String = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames()
			If resourceNames.Contains(resourceName) Then
				Return resourceName
			End If
			Dim indx As Integer = resourceName.IndexOf("."c)
			If indx < 0 OrElse indx = resourceName.Length - 1 Then
				Return ""
			End If
			Return FindResourceName(resourceName.Substring(indx + 1))
		End Function

		Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
			Dim result As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
			If result IsNot Nothing Then
				Return result
			End If

			Dim languageString As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
			If languageString = "CS" Then
				Return result
			End If
			Dim indx As Integer = resourceName.IndexOf(".")
			If indx < 0 OrElse indx = resourceName.Length - 1 Then
				Return result
			End If
			Return GetResourceStream(resourceName.Substring(indx + 1))
		End Function


		Private Shared Sub FillStorageCollection(ByVal c As AppointmentCollection, ByVal resourceName As String)
			Using stream As Stream = GetResourceStream(resourceName)
				c.ReadXml(stream)
				stream.Close()
			End Using
		End Sub
		Private Shared Sub FillStorageCollection(ByVal c As ResourceCollection, ByVal resourceName As String)
			Using stream As Stream = GetResourceStream(resourceName)
				c.ReadXml(stream)
				stream.Close()
			End Using
		End Sub
		Public Shared Sub SetConnectionString(ByVal oleDbConnection As System.Data.OleDb.OleDbConnection, ByVal path As String)
			oleDbConnection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path)
		End Sub
		Public Shared Function GetFileRelativePath(ByVal fileName As String) As String
			Return GetRelativePath(fileName, False)
		End Function
		Public Shared Function GetFolderRelativePath(ByVal fileName As String) As String
			Return GetRelativePath(fileName, True)
		End Function
		Private Shared Function GetRelativePath(ByVal name As String, ByVal isFolder As Boolean) As String
			name = "Data\" & name
			Dim path As String = System.Windows.Forms.Application.StartupPath
			Dim s As String = "\"
			For i As Integer = 0 To 10
				If IsObjectExists(path & s & name, isFolder) Then
					Return (path & s & name)
				Else
					s &= "..\"
				End If
			Next i
			Return ""
		End Function
		Private Shared Function IsObjectExists(ByVal name As String, ByVal isFolder As Boolean) As Boolean
			If isFolder Then
				Return System.IO.Directory.Exists(name)
			Else
				Return System.IO.File.Exists(name)
			End If
		End Function

		Public Shared Function TimeVisibilityToCheckState(ByVal visibility As AppointmentTimeVisibility) As CheckState
			If visibility.Equals(AppointmentTimeVisibility.Always) Then
				Return CheckState.Checked
			End If
			If visibility.Equals(AppointmentTimeVisibility.Never) Then
				Return CheckState.Unchecked
			End If
			Return CheckState.Indeterminate
		End Function
		Public Shared Function CheckStateToTimeVisibility(ByVal state As CheckState) As AppointmentTimeVisibility
			If state.Equals(CheckState.Checked) Then
				Return AppointmentTimeVisibility.Always
			End If
			If state.Equals(CheckState.Unchecked) Then
				Return AppointmentTimeVisibility.Never
			End If
			Return AppointmentTimeVisibility.Auto
		End Function

		Public Shared Function GenerateScheduleTasks() As DataTable
			Dim tbl As New DataTable()
			tbl = New DataTable("ScheduleTasks")
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Subject", GetType(String))
			tbl.Columns.Add("Severity", GetType(Integer))
			tbl.Columns.Add("Priority", GetType(Integer))
			tbl.Columns.Add("Duration", GetType(Integer))
			tbl.Columns.Add("Description", GetType(String))
			For i As Integer = 0 To 20
				Dim description As String = taskDescriptions(i)
				Dim index As Integer = description.IndexOf("."c)
				Dim subject As String
				If index <= 0 Then
					subject = "task" & Convert.ToInt32(i + 1)
				Else
					subject = description.Substring(0, index)
				End If
				tbl.Rows.Add(New Object() { i + 1, subject, RandomInstance.Next(3), RandomInstance.Next(3), Math.Max(1, RandomInstance.Next(8)), description })
			Next i
			Return tbl
		End Function
		Public Shared Function GetSportEventsData() As DataTable
			Dim sportEventDS As New DataSet()
			Using stream As Stream = GetResourceStream(sportEventsResourceName)
				sportEventDS.ReadXml(stream)
				stream.Close()
			End Using
			Return sportEventDS.Tables(0)
		End Function
		Public Shared Function FormatAppointmentString(ByVal apt As Appointment) As String
			If apt Is Nothing Then
				Return "Null"
			End If
			Return String.Format("[{0}] {1}", apt.Type, apt.Subject)
		End Function
		Public Shared Function FormatOutlookAppointmentString(ByVal olApt As _AppointmentItem) As String
			If olApt Is Nothing Then
				Return "Null"
			End If

			Dim isRecurring As String = If(olApt.IsRecurring, "Recurring", "NonRecurring")
			Return String.Format("[{0}] {1}", isRecurring, olApt.Subject)
		End Function
		Public Shared Sub ReportOutlookError(ByVal message As String, ByVal exceptionMessage As String)
			DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to {0}. An exception has occured:" & Constants.vbCrLf & "{1}", message, exceptionMessage), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Sub

		Public Shared Function GetLanguageString() As String
			Dim result As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
			If result = "CS" Then
				result = "C#"
			End If
			Return result
		End Function
	End Class

	Public Class SchedulerDemoLogify
		Implements ILogifyCustomDataProvider

		Public Shared Sub Register()
			LogifyState.Instance.AddCustomDataProvider(New SchedulerDemoLogify())
		End Sub

		Private Sub ILogifyCustomDataProvider_CollectCustomData(ByVal data As IDictionary(Of String, String)) Implements ILogifyCustomDataProvider.CollectCustomData
			CollectCustomData(data)
		End Sub

		Public Sub CollectCustomData(ByVal data As System.Collections.Generic.IDictionary(Of String, String))
			Dim dpi As Size = ScaleUtils.GetSystemDPI()
			data.Add("dpi", String.Format("{0} : {1}", dpi.Width, dpi.Height))
			data.Add("skin name", String.Format("{0}", DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName))
			data.Add("module", ModulesInfo.CurrentModuleInfo.Name)
		End Sub
	End Class

End Namespace
