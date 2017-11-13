Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Docs.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetSportResultsModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub
		Public Overrides Function CreateBook() As IWorkbook
			Dim example As New SportResultsDocumentGenerator(DefaultCulture)
			Return example.Generate()
		End Function
		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "SportResults"
			End Get
		End Property
	End Class
End Namespace
