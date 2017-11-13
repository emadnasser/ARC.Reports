Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Threading
Imports System.Web
Imports System.Web.Hosting
Imports DevExpress.XtraReports.UI

Namespace ReportWebDemo.ReportCaching
	Public NotInheritable Class CacheReportHelper
		Private Shared currentContext As HttpContext
		Private Shared cancellation As CancellationTokenSource

		Private Sub New()
		End Sub
		Public Shared Sub StartCreatingReports()
			currentContext = HttpContext.Current
			cancellation = New CancellationTokenSource()
			StartCreatingReports(Directory.GetFiles(HostingEnvironment.MapPath("~/App_Data/Dictionaries"), "*.txt"))
		End Sub

		Public Shared Sub EndCreatingReports()
			cancellation.Cancel()
		End Sub

		Private Shared Sub StartCreatingReports(ByVal files() As String)
			Dim thread = New Thread(AddressOf ThreadStart) With {.Priority = ThreadPriority.BelowNormal, .IsBackground = True}
			thread.Start(files)
		End Sub

		Private Shared Sub ThreadStart(ByVal arg As Object)
			Dim fileNames = CType(arg, String())
			For Each fileName As String In fileNames
				If File.Exists(Path.ChangeExtension(fileName, "sav")) Then
					Continue For
				End If
				If cancellation.IsCancellationRequested Then
					Exit For
				End If
				Dim savingFile As String = Path.ChangeExtension(fileName, "saving")
				Using stream As FileStream = File.Create(savingFile)
					Using report As XtraReport = New XtraReportsDemos.DictionaryReport.Report(fileName)
						report.CreateDocument()
						DevExpress.XtraPrinting.InternalAccess.PrintingSystemAccessor.SaveIndependentPages(report.PrintingSystem, stream)
					End Using
					stream.Flush()
				End Using
				SyncLock GetType(CacheReportHelper)
					File.Move(savingFile, Path.ChangeExtension(fileName, "sav"))
				End SyncLock
			Next fileName
		End Sub
	End Class
End Namespace
