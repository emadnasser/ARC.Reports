Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports System.Configuration
Imports System.Threading
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo

Namespace MainDemo.Win
	Partial Public Class MainDemoWinApplication
		Inherits WinApplication
		Public Sub New()
            InitializeComponent()
            DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderControllerBase.ScriptRecorderEnabled = True
        End Sub
        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
        Private Sub MainDemoWinApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
		Private Sub MainDemoWebApplication_LastLogonParametersRead(ByVal sender As Object, ByVal e As LastLogonParametersReadEventArgs) Handles MyBase.LastLogonParametersRead
			' Just to read demo user name for logon.
			Dim logonParameters As AuthenticationStandardLogonParameters = TryCast(e.LogonObject, AuthenticationStandardLogonParameters)
			If logonParameters IsNot Nothing Then
				If String.IsNullOrEmpty(logonParameters.UserName) Then
					logonParameters.UserName = "Sam"
				End If
			End If
		End Sub
	End Class
End Namespace
