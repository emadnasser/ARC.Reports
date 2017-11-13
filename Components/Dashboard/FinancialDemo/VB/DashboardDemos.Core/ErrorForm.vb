Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DashboardDemos.Core
	Partial Public Class ErrorForm
		Inherits XtraForm

		Public Sub New(ByVal serverName As String, ByVal ex As Exception)
			InitializeComponent()
			If TypeOf ex Is SqlServerNotFoundException Then
				labelErrorCaption.Text = String.Format("Unable to connect to {0} SQL Server instance:", serverName)
			End If
			If TypeOf ex Is DatabaseCreatingException Then
				labelErrorCaption.Text = String.Format("An error occurred when creating a demo database on the {0} SQL server instance:", serverName)
			End If
		   textEditErrorDetails.Text = ex.Message
		End Sub

		Private Sub labelControl3_HyperlinkClick(ByVal sender As Object, ByVal e As DevExpress.Utils.HyperlinkClickEventArgs) Handles labelControl3.HyperlinkClick
			Dim process As New Process()
			process.StartInfo.FileName = e.Link
			process.StartInfo.Verb = "open"
			process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
			Try
				process.Start()
			Catch
			End Try
		End Sub
	End Class
End Namespace
