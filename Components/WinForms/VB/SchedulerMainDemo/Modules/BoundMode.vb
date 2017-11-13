Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class BoundModeModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			FillData()

		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub BoundModeModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			schedulerControl.Start = New DateTime(2016, 11, 16)

			schedulerControl.DataStorage.EnableReminders = False

			InitCustomAppointmentStatuses()
		End Sub

		Private Sub FillData()
			Dim connectionString As String = DemoUtils.GetFileRelativePath("CarsDB.mdb")
			If connectionString.Length <= 0 Then
				Return
			End If

			DemoUtils.SetConnectionString(usageTypeTableAdapter.Connection, connectionString)
			DemoUtils.SetConnectionString(carsTableAdapter.Connection, connectionString)
			DemoUtils.SetConnectionString(carSchedulingTableAdapter.Connection, connectionString)

			usageTypeTableAdapter.Fill(Me.carsDBDataSet.UsageType)
			carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)

			AddHandler carSchedulingTableAdapter.DataAdapter.RowUpdated, AddressOf carSchedulingTableAdapter_RowUpdated
		End Sub
		Private Sub InitCustomAppointmentStatuses()
			schedulerStorage.Appointments.Statuses.Clear()
			For i As Integer = 0 To Me.carsDBDataSet.UsageType.Rows.Count - 1
				Dim text As String = Me.carsDBDataSet.UsageType.Rows(i)("Name").ToString()
				schedulerStorage.Appointments.Statuses.Add(GetStatusColor(i), text, text)
			Next i
		End Sub
		Private Function GetStatusColor(ByVal rowIndex As Integer) As System.Drawing.Color
			Dim obj As Object = Me.carsDBDataSet.UsageType.Rows(rowIndex)("Color")
			Dim statusColor As Integer = If(obj IsNot DBNull.Value, Convert.ToInt32(obj), &HFFFFFF)
			Dim b As Integer = statusColor And &HFF
			statusColor >>= 8
			Dim g As Integer = statusColor And &HFF
			statusColor >>= 8
			Dim r As Integer = statusColor And &HFF
			Return Color.FromArgb(r, g, b)
		End Function
		Private Sub schedulerStorage_AppointmentsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsChanged, schedulerStorage.AppointmentsDeleted
			' Uncomment the code below to apply changes.

			'carSchedulingTableAdapter.Update(this.carsDBDataSet);
			'this.carsDBDataSet.AcceptChanges();
		End Sub

		Private Sub schedulerStorage_FilterResource(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles schedulerStorage.FilterResource
			e.Cancel = FilterCar(CType(e.Object, Resource))
		End Sub
		Private Function FilterCar(ByVal car As Resource) As Boolean
			If CInt(Fix(car.Id)) > 5 Then
				Return True
			Else
				Dim tradeMark As String = CStr(schedulerStorage.GetObjectValue(car, "Trademark"))
				Dim model As String = CStr(schedulerStorage.GetObjectValue(car, "Model"))
				car.Caption = String.Format("{0} {1}", tradeMark, model)
				Return False
			End If
		End Function
		Private Sub carSchedulingTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
			If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
				Dim id As Integer = 0
				Using cmd As New OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)
					id = CInt(Fix(cmd.ExecuteScalar()))
				End Using
				e.Row("ID") = id
			End If
		End Sub
	End Class
End Namespace

