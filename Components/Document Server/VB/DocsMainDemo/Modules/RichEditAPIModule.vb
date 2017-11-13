Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting.Control
Imports System.IO
Imports System
Imports System.Drawing
Imports DevExpress.XtraTreeList.Columns
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraRichEdit.API.Native


Namespace DevExpress.Docs.Demos
	Public Class RichEditAPIModule
		Inherits ApiModuleBase
		Private docServer As RichEditDocumentServer

		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property ExamplesFolderName() As String
			Get
				Return "RichEditCodeExamples"
			End Get
		End Property
		Public Overrides ReadOnly Property DemoProjectName() As String
			Get
				Return "DocsMainDemo"
			End Get
		End Property

		Protected Overrides Sub CreateDemoComponent()
			Me.docServer = New RichEditDocumentServer()
		End Sub
		Protected Overrides Function GetEvaluationParameter() As Object
			Return docServer.Document
		End Function
		Protected Overrides Function CreateEvaluator() As ExampleEvaluatorByTimer
			Dim result As New RichEditExampleEvaluatorByTimer() 'this.components
			AddHandler result.QueryEvaluate, AddressOf result_QueryEvaluate
			AddHandler result.OnBeforeCompile, AddressOf result_OnBeforeCompile
			AddHandler result.OnAfterCompile, AddressOf result_OnAfterCompile
			Return result
		End Function

		Private Sub result_QueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
			OnExampleEvaluatorQueryEvaluate(sender, e)
		End Sub

		Private Sub result_OnAfterCompile(ByVal sender As Object, ByVal args As OnAfterCompileEventArgs)
			If args.Result Then
				PrintableComponentLink.Component = docServer
				PrintableComponentLink.CreateDocument()
			End If
			CodeEditor.AfterCompile(args.Result)
			docServer.EndUpdate()
		End Sub

		Private Sub result_OnBeforeCompile(ByVal sender As Object, ByVal args As EventArgs)
			docServer.BeginUpdate()
			docServer.CreateNewDocument()
			CodeEditor.BeforeCompile()
		End Sub
	End Class
	#Region "RichEditExampleEvaluatorByTimer"
	Public Class RichEditExampleEvaluatorByTimer
		Inherits ExampleEvaluatorByTimer
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
			If language = ExampleLanguage.VB Then
				Return New RichEditVbExampleCodeEvaluator()
			End If
			Return New RichEditCsExampleCodeEvaluator()
		End Function
	End Class
	#End Region
End Namespace
