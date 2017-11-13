Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextSearchResultsForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			Icon = ResourceImageHelper.CreateIconFromResources("MainDemo.ico", GetType(frmMain).Assembly)
			CenterToParent()
		End Sub
		Public Sub SetItems(ByVal items As List(Of String))
			Dim itemCollection As ListBoxItemCollection = listBoxControl.Items
			itemCollection.Clear()
			itemCollection.AddRange(items.ToArray())
		End Sub
	End Class
End Namespace
