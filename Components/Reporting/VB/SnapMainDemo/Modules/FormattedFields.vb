Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Partial Public Class FormattedFields
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				SetDataSource()
				LoadDocument()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("FormattedFields")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New FormattedFieldsDataProvider().GetDataSource()
			Me.snapControl1.DataSources.Add(New DataSourceInfo("HtmlTags", dataSource))
		End Sub
	End Class

	Public Class HtmlTag
		Public Property Tag() As String
		<DisplayName("Markup Example")> _
		Public Property MarkupExample() As String
		Public Property Description() As String
	End Class
End Namespace
