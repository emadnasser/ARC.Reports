Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Xml
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Schedule
Imports DevExpress.Schedule.Serializing
Imports DevExpress.XtraScheduler.Internal
Imports System.Collections
Imports System.Linq

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class HolidaysModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private Const OutlookHolidaysFileName As String = "OUTLOOK.HOL"
		Private Const SchedulerHolidaysFileName As String = "holidays.xml"
		Private Const defaultLocationName As String = "united states"

		Private allHolidays_Renamed As New HolidayBaseCollection()


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
		Protected ReadOnly Property AllHolidays() As HolidayBaseCollection
			Get
				Return allHolidays_Renamed
			End Get
		End Property

		Private Sub HolidaysModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim filePath As String = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName)
			ImportHolidaysFromXmlFile(filePath)
			UpdateControls()
			Dim defaultLocationIndex As Integer = Math.Max(0, clbLocations.FindStringExact(defaultLocationName))
			If clbLocations.ItemCount >= 0 Then
				clbLocations.SetItemChecked(defaultLocationIndex, True)
				GenerateHolidayAppointments(False)
			End If
			Me.schedulerControl.Start = FindNearHoliday()
			ActiveControl = Me.clbLocations
		End Sub
		Private Sub UpdateControls()
			FillLocationListBox(SelectHolidayLocations(AllHolidays))
			FillHolidaysListBox(New List(Of HolidayListBoxItem)(0))
			UpdateStatusLabel(0, 0)
		End Sub
		Private Function SelectHolidayLocations(ByVal holidays As HolidayBaseCollection) As String()
			Dim locations As New List(Of String)()
			For Each item As Holiday In holidays
				If (Not locations.Contains(item.Location)) Then
					locations.Add(item.Location)
				End If
			Next item
			Return locations.ToArray()
		End Function
		Private Sub FillLocationListBox(ByVal locations() As String)
			clbLocations.Items.BeginUpdate()
			Try
				clbLocations.Items.Clear()
				For i As Integer = 0 To locations.Length - 1
					clbLocations.Items.Add(locations(i), False)
				Next i
				clbLocations.SelectedIndex = 0
			Finally
				clbLocations.Items.EndUpdate()
			End Try
		End Sub
		Private Function CreateListBoxData(ByVal items As HolidayBaseCollection) As List(Of HolidayListBoxItem)
			Dim data As New List(Of HolidayListBoxItem)()
			For i As Integer = 0 To items.Count - 1
				data.Add(New HolidayListBoxItem(items(i)))
			Next i
			Return data
		End Function
		Private Sub FillHolidaysListBox(ByVal data As List(Of HolidayListBoxItem))
			lbHolidays.Items.BeginUpdate()
			Try
				lbHolidays.DataSource = data
				lbHolidays.DisplayMember = "DisplayText"
			Finally
				lbHolidays.Items.EndUpdate()
			End Try
		End Sub
		Private Sub UpdateStatusLabel(ByVal holidayCount As Integer, ByVal locationCount As Integer)
			lblStatus.Text = String.Format("Loaded {0} holiday(s) for {1} location(s)", holidayCount, locationCount)
		End Sub
		Private Sub clbLocations_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbLocations.ItemCheck
			Dim locations As List(Of String) = GetSelectedLocations()
			Dim holidays As HolidayBaseCollection = GetSelectedHolidays(locations)

			AddHolidaysToScheduler(holidays)
			FillHolidaysListBox(CreateListBoxData(holidays))
			UpdateStatusLabel(holidays.Count, locations.Count)
		End Sub
		Private Function GetSelectedHolidays(ByVal locations As List(Of String)) As HolidayBaseCollection
			Dim result As New HolidayBaseCollection()
			If locations.Count = 0 Then
				Return result
			End If

			For Each item As Holiday In AllHolidays
				If locations.Contains(item.Location) Then
					result.Add(item)
				End If
			Next item
			Return result
		End Function
		Private Function GetSelectedLocations() As List(Of String)
			Dim result As New List(Of String)()
			For i As Integer = 0 To clbLocations.Items.Count - 1
				Dim item As CheckedListBoxItem = clbLocations.Items(i)
				If item.CheckState = CheckState.Checked Then
					result.Add(item.Value.ToString())
				End If
			Next i
			Return result
		End Function
		Private Sub lbHolidays_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lbHolidays.DoubleClick
			Dim item As HolidayListBoxItem = TryCast(lbHolidays.SelectedItem, HolidayListBoxItem)
			If item IsNot Nothing Then
				schedulerControl.GoToDate(item.Holiday.Date)
			End If
		End Sub
		Private Sub AddHolidaysToScheduler(ByVal items As HolidayBaseCollection)
			schedulerControl.BeginUpdate()
			Try
				schedulerControl.WorkDays.Clear()
				schedulerControl.WorkDays.Add(WeekDays.WorkDays)
				schedulerControl.WorkDays.AddRange(items)
			Finally
				schedulerControl.EndUpdate()
			End Try
		End Sub
		Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
			GenerateHolidayAppointments(True)
		End Sub
		Private Sub GenerateHolidayAppointments(ByVal showMessage As Boolean)
			If chkClearBeforGenerate.Checked Then
				schedulerStorage.Appointments.Clear()
			End If
			Dim apts As AppointmentBaseCollection = HolidaysHelper.GenerateHolidayAppointments(schedulerStorage, schedulerControl.WorkDays)
			schedulerStorage.BeginUpdate()
			Try
				schedulerStorage.Appointments.Items.AddRange(apts)
				If showMessage Then
					XtraMessageBox.Show(String.Format("{0} appointment(s) were added", apts.Count), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			Finally
				schedulerStorage.EndUpdate()
			End Try
		End Sub
		Private Sub btnImportFromXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFromXml.Click
			Dim dlg As New OpenFileDialog()
			dlg.Filter = "Scheduler holidays files (*.xml)|*.xml|All files (*.*)|*.*"
			dlg.FilterIndex = 1
			dlg.FileName = SchedulerHolidaysFileName
			Dim filePath As String = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName)
			dlg.InitialDirectory = New FileInfo(filePath).DirectoryName
			dlg.DefaultExt = "*.xml"
			dlg.CheckFileExists = True

			If dlg.ShowDialog() = DialogResult.OK Then
				ImportHolidaysFromXmlFile(dlg.FileName)
				UpdateControls()
			End If
		End Sub
		Private Sub ImportHolidaysFromXmlFile(ByVal path As String)
			If (Not File.Exists(path)) Then
				Return
			End If

			Dim doc As New XmlDocument()
			doc.Load(path)
			Me.allHolidays_Renamed = HolidayCollectionXmlPersistenceHelper.ObjectFromXml(doc.OuterXml)
		End Sub

		Private Function FindNearHoliday() As DateTime
			Dim now As DateTime = DateTime.Today
			Dim holidays As IEnumerable(Of Holiday) = Me.schedulerControl.WorkDays.OfType(Of Holiday)().Where(Function(hol) hol.Date >= now)
			If holidays.Count() = 0 Then
				Return now
			End If
			Dim minDistance As TimeSpan = holidays.Min(Function(hol) (hol.Date - now).Duration())
			Return holidays.First(Function(hol) (hol.Date - now).Duration() = minDistance).Date
		End Function

		Private Sub btnImportFromOutlook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFromOutlook.Click
			Dim dlg As New OpenFileDialog()
			dlg.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*"
			dlg.FilterIndex = 1
			dlg.FileName = OutlookHolidaysFileName
			dlg.DefaultExt = "*.hol"
			dlg.CheckFileExists = True

			If dlg.ShowDialog() = DialogResult.OK Then
				ImportHolidaysFromOutlookFile(dlg.FileName)
				UpdateControls()
			End If
		End Sub
		Private Sub ImportHolidaysFromOutlookFile(ByVal path As String)
			If (Not File.Exists(path)) Then
				Return
			End If

			Dim loader As New OutlookHolidaysLoader()
			Me.allHolidays_Renamed = loader.FromFile(path)
		End Sub

		Private Sub schedulerControl_LayoutViewInfoCustomizing(ByVal sender As Object, ByVal e As LayoutViewInfoCustomizingEventArgs) Handles schedulerControl.LayoutViewInfoCustomizing
			Dim header As SchedulerHeader = Nothing
			If e.Kind = LayoutElementKind.DateHeader Then
				header = CType(e.ViewInfo, SchedulerHeader)
			End If
			If e.Kind = LayoutElementKind.Cell AndAlso schedulerControl.ActiveViewType = SchedulerViewType.Month Then
				header = (CType(e.ViewInfo, SingleWeekCellBase)).Header
			End If

			If header IsNot Nothing Then
				Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
				If hol IsNot Nothing Then
					header.Caption = String.Format("{0} ({1})", hol.DisplayName, hol.Location)
					header.Appearance.HeaderCaption.ForeColor = Color.Red
					header.Appearance.AlternateHeaderCaption.ForeColor = Color.Red
					header.ToolTipText = header.Caption
					header.ShouldShowToolTip = True
				End If
			End If
		End Sub

		' This method finds a holiday for the specified date.
		Private Function FindHoliday(ByVal [date] As DateTime) As Holiday
			For Each item As WorkDay In Me.schedulerControl.WorkDays
				If TypeOf item Is Holiday Then
					Dim hol As Holiday = CType(item, Holiday)
					If hol.Date = [date] Then
						Return hol
					End If
				End If
			Next item
			Return Nothing
		End Function

	End Class

	#Region "HolidayListBoxItem class"
	Public Class HolidayListBoxItem
		Private holiday_Renamed As Holiday
		Public Sub New(ByVal holiday As Holiday)
			Me.holiday_Renamed = holiday
		End Sub
		Public ReadOnly Property Holiday() As Holiday
			Get
				Return holiday_Renamed
			End Get
		End Property
		Public ReadOnly Property DisplayText() As String
			Get
				Return String.Format("{0} ({1}) {2}", holiday_Renamed.DisplayName, holiday_Renamed.Location, holiday_Renamed.Date.ToShortDateString())
			End Get
		End Property
	End Class
	#End Region
End Namespace
