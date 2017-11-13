Imports Microsoft.VisualBasic
Imports DevExpress.Internal
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Linq
Imports System.Web

Partial Public Class WebmailClientDataContextExt
	Inherits WebmailClientDataContext
	Private Shared ReadOnly Property ConnectionString() As String
		Get
			Dim sqlExpressString As String = ConfigurationManager.ConnectionStrings("WebmailClientConnectionString").ConnectionString
			Return DbEngineDetector.PatchConnectionString(sqlExpressString)
		End Get
	End Property
	Public Sub New()
		MyBase.New(ConnectionString)
	End Sub
End Class
