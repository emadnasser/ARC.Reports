Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Snap.Core.API
Imports DevExpress.Utils

Namespace SnapDemos.Modules
	Public Class TableOfContents
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				SubscribeEvents()
				LoadDocument()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("TableOfContents")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SubscribeEvents()
			AddHandler snapControl1.Document.ConfigureDataConnection, AddressOf OnConfigureDataConnection
		End Sub
		Private Sub OnConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionEventArgs)
			Dim parameters As Access97ConnectionParameters = TryCast(e.ConnectionParameters, Access97ConnectionParameters)
			If parameters Is Nothing Then
				Return
			End If
			Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\nwind.mdb", False)
			parameters.FileName = path
		End Sub
	End Class
End Namespace
