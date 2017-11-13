Imports Microsoft.VisualBasic
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Public Class IListDatasource
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				LoadDocument()
				SetDataSource()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("IListDatasource")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New IListDatasourceProvider().GetDataSource()
			Me.snapControl1.DataSources.Add(New DataSourceInfo("Fishes", dataSource))
		End Sub
	End Class
End Namespace
