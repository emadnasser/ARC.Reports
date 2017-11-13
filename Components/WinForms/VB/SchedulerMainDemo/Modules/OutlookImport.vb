Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.Xpo
Imports DevExpress.XtraScheduler.Exchange
Imports DevExpress.XtraScheduler.Outlook

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class OutlookImportModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property
		Protected ReadOnly Property IsCancelForRecurring() As Boolean
			Get
				Return (CType(cbCancelingTypes.EditValue, UsedAppointmentType)).Equals(UsedAppointmentType.Recurring)
			End Get
		End Property
		Protected ReadOnly Property IsCancelForNonRecurring() As Boolean
			Get
				Return (CType(cbCancelingTypes.EditValue, UsedAppointmentType)).Equals(UsedAppointmentType.NonRecurring)
			End Get
		End Property
		Protected ReadOnly Property CalendarName() As String
			Get
				Return Me.cbCalendarFolderPaths.Text
			End Get
		End Property

		Private Sub OutlookImportModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			schedulerControl.Start = DateTime.Today
			UpdateControls()
		End Sub
		Private Sub OutlookImportModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
			If Visible Then
				xpCollectionEvents.Session.DropIdentityMap()
				xpCollectionEvents.Reload()
			End If
		End Sub
		Private Sub UpdateControls()
			cbCancelingTypes.EditValue = UsedAppointmentType.None
			FillCalendarNamesCombo()
		End Sub
		Private Sub FillCalendarNamesCombo()
			cbCalendarFolderPaths.Properties.BeginUpdate()
			Try
				cbCalendarFolderPaths.Properties.Items.Clear()
				cbCalendarFolderPaths.Properties.Items.AddRange(DemoUtils.OutlookCalendarPaths)
			Finally
				cbCalendarFolderPaths.Properties.EndUpdate()
				cbCalendarFolderPaths.SelectedIndex = 0
			End Try
		End Sub
		Private Sub schedulerStorage_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsChanged
			session1.BeginTransaction()
			Try
				For Each apt As Appointment In e.Objects
					Dim o As XPBaseObject = TryCast(apt.GetSourceObject(schedulerStorage), XPBaseObject)
					If o IsNot Nothing Then
						o.Save()
					End If
				Next apt
				session1.CommitTransaction()
			Catch
				session1.RollbackTransaction()
			End Try
		End Sub

		#Region "supplementary functionality"
		Private Sub AddToLog(ByVal s As String)
			Me.lbcLog.Items.Add(s)
		End Sub
		Private Sub SuspendLog()
			Me.lbcLog.Items.BeginUpdate()
		End Sub
		Private Sub ResumeLog()
			Me.lbcLog.SelectedIndex = Me.lbcLog.Items.Count - 1
			Me.lbcLog.Items.EndUpdate()
		End Sub
		Private Sub ClearLog()
			Me.lbcLog.Items.Clear()
		End Sub
		Private Sub BeforeImport(ByVal objectCount As Integer)
			AddToLog(String.Format("{0} - Start importing from '{1}' calendar...", DateTime.Now.ToLongTimeString(), CalendarName))
			Application.DoEvents()
			SuspendLog()
			ProgressBarControl1.Position = 0
			ProgressBarControl1.Properties.Maximum = objectCount
		End Sub
		Private Sub AfterImport()
			AddToLog(String.Format("{0} - Import complete!", DateTime.Now.ToLongTimeString()))
			AddToLog(New String("-"c, 60))
			ResumeLog()
			ProgressBarControl1.Properties.Maximum = 100
			ProgressBarControl1.Position = 0
		End Sub
		Private Function CreateImportLogString(ByVal e As AppointmentImportingEventArgs) As String
			Dim args As OutlookAppointmentImportingEventArgs = CType(e, OutlookAppointmentImportingEventArgs)
			Return String.Format("Trying to import: apt={0}, olApt={1} ...", DemoUtils.FormatAppointmentString(args.Appointment), DemoUtils.FormatOutlookAppointmentString(args.OutlookAppointment))
		End Function
		#End Region

		Private Sub btnClearLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearLog.Click
			ClearLog()

		End Sub
		Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
			Try
				Import()
			Catch ex As Exception
				DemoUtils.ReportOutlookError("import appointments from Microsoft Outlook", ex.Message)
			End Try
		End Sub
		Private Sub Import()
			Dim importer As AppointmentImporter = schedulerStorage.CreateOutlookImporter()
			CType(importer, ISupportCalendarFolders).CalendarFolderName = CalendarName
			AddHandler importer.AppointmentImporting, AddressOf importer_AppointmentImporting
			AddHandler importer.AppointmentImported, AddressOf importer_AppointmentImported
			AddHandler importer.OnException, AddressOf importer_OnException

			Dim oldCur As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			BeforeImport(importer.SourceObjectCount)
			Try
				importer.Import(System.IO.Stream.Null)
			Finally
				AfterImport()
				Cursor.Current = oldCur
			End Try
		End Sub

		Private Sub importer_OnException(ByVal sender As Object, ByVal e As ExchangeExceptionEventArgs)
			Dim errText As String = e.OriginalException.Message
			Dim canTerminate As Boolean = True
			Dim occurrenceArgs As OutlookExchangeChangedOccurrenceExceptionEventArgs = TryCast(e, OutlookExchangeChangedOccurrenceExceptionEventArgs)
			If occurrenceArgs IsNot Nothing Then
				canTerminate = False
				If occurrenceArgs.OutlookAppointment IsNot Nothing AndAlso occurrenceArgs.Occurrence IsNot Nothing Then
					errText &= String.Format(Constants.vbCrLf & "Changed occurrence with index {0} is imported as normal occurrence '{1}' started on {2:D} at {3}" & Constants.vbLf, occurrenceArgs.Occurrence.RecurrenceIndex, occurrenceArgs.Occurrence.Subject, occurrenceArgs.Occurrence.Start, occurrenceArgs.Occurrence.Start.TimeOfDay)
				End If
			Else
				Dim args As OutlookExchangeExceptionEventArgs = TryCast(e, OutlookExchangeExceptionEventArgs)
				If args IsNot Nothing Then
					If args.OutlookAppointment IsNot Nothing Then
						errText &= String.Format(Constants.vbCrLf & "Event '{0}' started on {1:D} at {2}" & Constants.vbLf, args.OutlookAppointment.Subject, args.OutlookAppointment.Start, args.OutlookAppointment.Start.TimeOfDay)
					End If
				End If
			End If

			AddToLog(errText)
			Dim importer As AppointmentImporter = CType(sender, AppointmentImporter)

			e.Handled = True
			If canTerminate Then
				importer.Terminate()
				Throw e.OriginalException
			End If
		End Sub
		Private Sub importer_AppointmentImporting(ByVal sender As Object, ByVal e As AppointmentImportingEventArgs)
			Dim args As OutlookAppointmentImportingEventArgs = CType(e, OutlookAppointmentImportingEventArgs)
			AddToLog(CreateImportLogString(args))

			ProgressBarControl1.Position += 1
			ProgressBarControl1.Update()

			Dim cancel As Boolean = If(args.OutlookAppointment.IsRecurring, IsCancelForRecurring, IsCancelForNonRecurring)
			If cancel Then
				e.Cancel = True
				AddToLog("Cancelled because of the appointment type")
			End If
		End Sub
		Private Sub importer_AppointmentImported(ByVal sender As Object, ByVal e As AppointmentImportedEventArgs)
			AddToLog(String.Format("Successfully imported: {0}", DemoUtils.FormatAppointmentString(e.Appointment)))
		End Sub
	End Class
End Namespace
