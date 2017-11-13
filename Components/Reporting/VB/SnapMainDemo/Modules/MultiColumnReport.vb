Imports Microsoft.VisualBasic
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Public Class MultiColumnReport
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				LoadDocument()
				SetDataSource()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("MultiColumnReport")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New MultiColumnReportDataProvider().GetDataSource()
			Me.snapControl1.DataSource = dataSource
		End Sub
	End Class
End Namespace
