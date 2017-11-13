Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetShiftScheduleModule
		Inherits SpreadsheetTutorialControl
		Public Sub New()
			InitializeComponent()
			RefreshPreview()
			SpreadsheetTutorialPanel.Dock = DockStyle.Fill
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "ShiftSchedule"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			InitializePreviewControl()
			Dim generator As New ShiftScheduleGenerator(DefaultCulture)
			Return generator.Generate()
		End Function

		Private Sub InitializePreviewControl()
			SpreadsheetTutorialPanel.Location = Point.Empty
		End Sub

	End Class

End Namespace
