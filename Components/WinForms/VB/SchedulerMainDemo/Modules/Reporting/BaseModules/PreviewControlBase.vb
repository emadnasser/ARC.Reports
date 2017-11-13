Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraLayout
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraScheduler.Demos.Reporting

	''' <summary>
	''' Summary description for ModuleControl.
	''' </summary>
	''' 
	Public Class ReportPreviewControlBase
		Inherits TutorialControl
		Implements IDemoSchedulerReport

		Private baseDate_Renamed As DateTime
		Public Class DesignForm
			Inherits DevExpress.XtraReports.UserDesigner.XRDesignFormEx
			Protected Overrides Sub SaveLayout()
			End Sub
			Protected Overrides Sub RestoreLayout()
			End Sub
		End Class
		#Region "Fields"
		Private components As System.ComponentModel.IContainer
		Private preventUpdate_Renamed As Boolean
		Protected fPrintBarManager As PrintBarManager
		Protected WithEvents printControl As PrintControl

		Protected fSchedulerStorage As SchedulerStorage
		Protected WithEvents fStoragePrintAdapter As SchedulerStoragePrintAdapter
		#End Region        

		Public Sub New()
			InitializeComponent()
			Me.fPrintBarManager = CreatePrintBarManager(printControl)
			Me.baseDate_Renamed = CarsDataHelper.GetStartDate()
			FillReportSourceData()
			InitAdapterTimeInterval()
			CreateReports()
		End Sub
		#Region "Properties"
		Protected Property PreventUpdate() As Boolean
			Get
				Return preventUpdate_Renamed
			End Get
			Set(ByVal value As Boolean)
				preventUpdate_Renamed = value
			End Set
		End Property
		Public ReadOnly Property StoragePrintAdapter() As SchedulerStoragePrintAdapter
			Get
				Return Me.fStoragePrintAdapter
			End Get
		End Property
		Public ReadOnly Property SchedulerStorage() As SchedulerStorage
			Get
				Return Me.fSchedulerStorage
			End Get
		End Property
		Public ReadOnly Property BaseDate() As DateTime
			Get
				Return Me.baseDate_Renamed
			End Get
		End Property
		#End Region
		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		''' 
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.printControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.fStoragePrintAdapter = New DevExpress.XtraScheduler.Reporting.SchedulerStoragePrintAdapter()
			Me.fSchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl.IsMetric = False
			Me.printControl.Location = New System.Drawing.Point(0, 0)
			Me.printControl.Name = "printControl"
			Me.printControl.Size = New System.Drawing.Size(455, 396)
			Me.printControl.TabIndex = 1
			Me.printControl.TabStop = False
'			Me.printControl.VisibleChanged += New System.EventHandler(Me.printControl_VisibleChanged);
			' 
			' fStoragePrintAdapter
			' 
			Me.fStoragePrintAdapter.SchedulerStorage = Me.fSchedulerStorage
			Me.fStoragePrintAdapter.TimeInterval.Duration = System.TimeSpan.Parse("1.00:00:00")
			Me.fStoragePrintAdapter.TimeInterval.Start = New System.DateTime(2016, 5, 6, 0, 0, 0, 0)
'			Me.fStoragePrintAdapter.ValidateAppointments += New DevExpress.XtraScheduler.Reporting.AppointmentsValidationEventHandler(Me.fStoragePrintAdapter_ValidateAppointments);
			' 
			' ReportPreviewControlBase
			' 
			Me.Controls.Add(Me.printControl)
			Me.Name = "ReportPreviewControlBase"
			Me.Size = New System.Drawing.Size(700, 396)
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region        

		Private Sub InitializePrintingSystem(ByVal printingSystem As PrintingSystemBase)
			printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
		End Sub
		Protected Overridable Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(60))
		End Sub

		Protected Overridable Sub FillReportSourceData()
			CarsDataHelper.FillStorageData(SchedulerStorage, BaseDate)
		End Sub
		Protected Overridable Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			otherReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema
			otherReport.SchedulerAdapter = StoragePrintAdapter
		End Sub
		Protected Function CreatePrintBarManager(ByVal pc As PrintControl) As PrintBarManager
			Dim printBarManager As New PrintBarManager()
			printBarManager.Form = printControl
			printBarManager.Initialize(pc)
			printBarManager.MainMenu.Visible = False
			printBarManager.AllowCustomization = False
			Return printBarManager
		End Function
		Protected Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
			designForm.MinimumSize = parentForm.MinimumSize
			If parentForm.WindowState = FormWindowState.Normal Then
				designForm.Bounds = parentForm.Bounds
			End If
			designForm.WindowState = parentForm.WindowState
			parentForm.Visible = False
			designForm.ShowDialog()
			parentForm.Visible = True
		End Sub
		Private Sub printControl_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printControl.VisibleChanged
			If Visible AndAlso (Not preventUpdate_Renamed) Then
				UpdateActiveReport()
			End If
		End Sub

		Private Sub UpdatePrintingSystemDocument(ByVal report As XtraSchedulerReport)
			If report Is Nothing OrElse report.PrintingSystem.Document.IsCreating = True Then
				Return
			End If
			Invalidate()
			Update()
			InitializePrintingSystem(report.PrintingSystem)
			printControl.PrintingSystem = report.PrintingSystem
			report.CreateDocument(True)
		End Sub
		#Region "IDemoSchedulerReport Members"
		Public Sub UpdateActiveReport() Implements IDemoSchedulerReport.UpdateActiveReport
			Dim localReport As XtraSchedulerReport = GetActiveReport()
			If localReport Is Nothing Then
				Return
			End If
			UpdateReportProperties(localReport)
			UpdatePrintingSystemDocument(localReport)
		End Sub

		#End Region
		Protected Overridable Sub CreateReports()
		End Sub
		Protected Overridable Function GetActiveReport() As XtraSchedulerReport
			Return Nothing
		End Function

		Private Sub fStoragePrintAdapter_ValidateAppointments(ByVal sender As Object, ByVal e As AppointmentsValidationEventArgs) Handles fStoragePrintAdapter.ValidateAppointments
			DoValidateAppointments(e)
		End Sub

		Protected Overridable Sub DoValidateAppointments(ByVal e As AppointmentsValidationEventArgs)
		End Sub
	End Class
End Namespace
