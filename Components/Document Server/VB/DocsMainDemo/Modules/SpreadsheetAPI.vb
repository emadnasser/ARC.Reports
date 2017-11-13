Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports System
Imports System.Diagnostics
Imports System.Globalization

Namespace DevExpress.Docs.Demos
	Public Class SpreadsheetAPIModule
		Inherits ApiModuleBase
		Private workbook As IWorkbook

		Public Sub New()
			MyBase.New()

		End Sub
		Public Overrides ReadOnly Property ExamplesFolderName() As String
			Get
				Return "CodeExamples"
			End Get
		End Property
		Public Overrides ReadOnly Property DemoProjectName() As String
			Get
				Return "DocsMainDemo"
			End Get
		End Property
		Public ReadOnly Property TestDocumentName() As String
			Get
				Return "Document.xlsx"
			End Get
		End Property

		Protected Overrides Sub CreateDemoComponent()
			Me.workbook = New Workbook()
		End Sub
		Protected Overrides Function GetEvaluationParameter() As Object
			Return workbook
		End Function
		Protected Overrides Function CreateEvaluator() As ExampleEvaluatorByTimer
			Dim evaluator As ExampleEvaluatorByTimer = New SpreadsheetExampleEvaluatorByTimer()

			AddHandler evaluator.QueryEvaluate, AddressOf evaluator_QueryEvaluate
			AddHandler evaluator.OnBeforeCompile, AddressOf evaluator_OnBeforeCompile
			AddHandler evaluator.OnAfterCompile, AddressOf evaluator_OnAfterCompile
			Return evaluator
		End Function

		Private Sub evaluator_QueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
			OnExampleEvaluatorQueryEvaluate(sender, e)
		End Sub

		Private Sub evaluator_OnAfterCompile(ByVal sender As Object, ByVal args As OnAfterCompileEventArgs)
			For Each sheet As Worksheet In workbook.Worksheets
				sheet.PrintOptions.PrintGridlines = True
			Next sheet

			Dim activeSheet As Worksheet = workbook.Worksheets.ActiveWorksheet
			Dim printableRange As Range = activeSheet.GetPrintableRange()
			activeSheet.SelectedCell = printableRange(printableRange.RowCount * printableRange.ColumnCount - 1).Offset(1, 1)
			activeSheet.Visible = True

			CodeEditor.AfterCompile(args.Result)
			workbook.EndUpdate()
			If args.Result Then
				PrintableComponentLink.Component = TryCast(workbook.Worksheets.ActiveWorksheet, DevExpress.XtraPrinting.IPrintable)
				PrintableComponentLink.CreateDocument()
			End If
		End Sub

		Private Sub evaluator_OnBeforeCompile(ByVal sender As Object, ByVal e As EventArgs)
			workbook.BeginUpdate()
			CodeEditor.BeforeCompile()

			workbook.Options.Culture = CultureInfo.InvariantCulture
			Dim loaded As Boolean = workbook.LoadDocument(DemoUtils.GetRelativePath(TestDocumentName))
			Debug.Assert(loaded)
		End Sub
	End Class
End Namespace
