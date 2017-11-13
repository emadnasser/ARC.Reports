Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Namespace DevExpress.XtraScheduler.Demos.Reporting

	Partial Public Class SingleReportPreviewControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				If Report IsNot Nothing Then
					Report.Dispose()
					report_Renamed = Nothing
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SingleReportPreviewControl))
			Dim timeInterval1 As New DevExpress.XtraScheduler.TimeInterval()
			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fPrintBarManager
			' 
			Me.fPrintBarManager.ImageStream = (CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' storagePrintAdapter
			' 
			Me.fStoragePrintAdapter.SchedulerStorage = Me.fSchedulerStorage
			timeInterval1.Duration = System.TimeSpan.Parse("00:00:00")
			Me.fStoragePrintAdapter.TimeInterval = timeInterval1
			' 
			' StoragePreviewControl
			' 
			Me.Name = "StoragePreviewControl"
			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region               


	End Class
End Namespace
