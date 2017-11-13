Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.About
Imports DevExpress.XtraReports.Web.Native.ClientControls.Services

Namespace DevExpress.Web.Demos
	Public Class DemoLoggingService
		Inherits ExtendedLoggingService
		Public Sub New()
			MyBase.New(Function() DefaultLoggingService.Instance)
		End Sub
		Public Overrides Sub LogException(ByVal exception As Exception, ByVal message As String)
			MyBase.LogException(exception, message)
			UAlgo.Default.DoEventException(exception)
		End Sub
	End Class
End Namespace
