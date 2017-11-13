Imports Microsoft.VisualBasic
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Public Class CalculatedFields
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				LoadDocument()
				SetDataSource()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("CalculatedFields")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New CalculatedFieldsDataProvider().GetDataSource()
			Me.snapControl1.DataSources.Add(New DataSourceInfo("Orders", dataSource))
		End Sub
	End Class
End Namespace
