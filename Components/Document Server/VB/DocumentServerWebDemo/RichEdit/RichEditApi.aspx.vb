Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Docs.Demos
Imports DevExpress.Web.Demos
Imports System.IO
Imports System.Net
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraRichEdit
Imports System.Text
Imports DevExpress.DXperience.Demos

Partial Public Class RichEdit_RichEditApi
	Inherits System.Web.UI.Page
	Private evaluator As ExampleEvaluatorByTimer
	Private docServer As RichEditDocumentServer
	Private examples As List(Of CodeExampleGroup)
	Private currentExampleLanguage_Renamed As ExampleLanguage

	Private Property CurrentExampleLanguage() As ExampleLanguage
		Get
			Return ExampleLanguage.Csharp
		End Get
		Set(ByVal value As ExampleLanguage)
			currentExampleLanguage_Renamed = value
		End Set
	End Property
	Private ReadOnly Property AlternateExampleLanguage() As ExampleLanguage
		Get
			Return If((CurrentExampleLanguage = ExampleLanguage.Csharp), ExampleLanguage.VB, ExampleLanguage.Csharp)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadExamples()
		If Request.QueryString.Count > 0 Then
			RenderHTMLPreview()
			Return
		End If
		ShowExamplesInTreeList(Me.ASPxTreeList1, examples)
		InitializeCodePreview()
	End Sub
	Private Sub RenderHTMLPreview()
		Me.evaluator = New RichEditExampleEvaluatorNoTimer()
		AddHandler Me.evaluator.QueryEvaluate, AddressOf OnQueryEvaluate
		Me.docServer = New RichEditDocumentServer()
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"
		Session("UploadedFile") = docServer

		docServer.BeginUpdate()
		docServer.CreateNewDocument()
		evaluator.CompileExample(Nothing, New EventArgs())
		docServer.EndUpdate()
		If docServer Is Nothing Then
			Response.BinaryWrite(Encoding.ASCII.GetBytes("Cannot display a preview."))
		Else
			Dim result As Stream = Nothing
			result = New MemoryStream()
			docServer.SaveDocument(result, DocumentFormat.Html)
			If result IsNot Nothing Then
				result.Seek(0, SeekOrigin.Begin)
				result.CopyTo(Response.OutputStream)
			End If
		End If
		Response.End()
	End Sub
	Private Sub LoadExamples()
		Dim examplePath As String = MapPath("~/App_Data/RichEditApiExampleCode")
		Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
		Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)
		Me.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)
		SetIdForExamples(examples)
		CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010")
	End Sub
	Private Sub OnQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
		Dim example As New CodeExample()
		Dim sourceIndxString As String = Request.Params("preview")
		Dim sourceIndx As Integer = Convert.ToInt32(sourceIndxString)
		example = GetExampleById(examples, sourceIndx)
		e.Result = True
		e.Code = example.CodeCS
		e.Language = ExampleLanguage.Csharp
		e.EvaluationParameter = docServer.Document
	End Sub
	Private Sub SetIdForExamples(ByVal examples As List(Of CodeExampleGroup))
		Dim indx As Integer = 0
		For Each group As CodeExampleGroup In examples
			group.Id = indx
			indx += 1
			For Each example As CodeExample In group.Examples
				example.Id = indx
				indx += 1
			Next example
		Next group
	End Sub
	Private Function GetExampleById(ByVal exmpls As List(Of CodeExampleGroup), ByVal id As Integer) As CodeExample
		For Each group As CodeExampleGroup In exmpls
			If group.Id = id AndAlso group.Examples.Count > 0 Then
				Return group.Examples(0)
			End If
			For Each example In group.Examples
				If example.Id = id Then
					Return example
				End If
			Next example
		Next group
		Return Nothing
	End Function
	Private Sub ShowExamplesInTreeList(ByVal aSPxTreeList As ASPxTreeList, ByVal examples As List(Of CodeExampleGroup))
		For Each group As CodeExampleGroup In examples
			Dim node As TreeListNode = CreateNodeCore(group.Id, group.Name, Nothing, Nothing)
			For Each example As CodeExample In group.Examples
				CreateNodeCore(example.Id, example.RegionName, node, example)
			Next example
		Next group
		If (Not IsPostBack) Then
			ASPxTreeList1.ExpandAll()
		End If
	End Sub
	Private Function CreateNodeCore(ByVal key As Object, ByVal text As String, ByVal parentNode As TreeListNode, ByVal example As CodeExample) As TreeListNode
		Dim node As TreeListNode = ASPxTreeList1.AppendNode(key, parentNode)
		node("Name") = text
		node("Value") = example
		Return node
	End Function

	Private Sub InitializeCodePreview()
		Dim activeExampleId As Integer = 0
		Dim focusedNode As TreeListNode = Me.ASPxTreeList1.FocusedNode
		If IsPostBack AndAlso focusedNode IsNot Nothing Then
			activeExampleId = Convert.ToInt32(focusedNode.Key)
		End If

		Dim example As CodeExample = GetExampleById(examples, activeExampleId)
		Dim formattedCode As String = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, False)

		Dim csharpCodeHolder As HtmlGenericControl = TryCast(Me.ASPxPageControl1.TabPages(0).FindControl("CSharpCodeHolder"), HtmlGenericControl)
		csharpCodeHolder.InnerHtml = formattedCode
		lblSourceName.Text = GetExampleName(example)

		If String.IsNullOrEmpty(example.CodeVB) Then
			Return
		End If
		Dim vbCodeHolder As HtmlGenericControl = TryCast(Me.ASPxPageControl1.TabPages(0).FindControl("VbCodeHolder"), HtmlGenericControl)

		formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, False)
		vbCodeHolder.InnerHtml = formattedCode
		lblSourceName.Text = GetExampleName(example)
	End Sub
	Protected Sub treeList_CustomDataCallback(ByVal sender As Object, ByVal e As TreeListCustomDataCallbackEventArgs)
		Dim key As String = e.Argument
		If Me.examples Is Nothing Then
			Return
		End If
		Dim example As CodeExample = GetExampleById(examples, Convert.ToInt32(key))
		If example Is Nothing Then
			Return
		End If
		Dim formattedCode As String = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, False)
		Dim formattedVbCode As String = If((String.IsNullOrEmpty(example.CodeVB)), String.Empty, CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, False))
		e.Result = String.Format("{0}|CSharpCodeHolder${1}${2}|VBCodeHolder${3}${4}", GetExampleName(example), formattedCode.Length, formattedCode, formattedVbCode.Length, formattedVbCode)
	End Sub
	Private Function GetExampleName(ByVal example As CodeExample) As String
		Return String.Format("{0} example", example.RegionName)
	End Function
	Protected Sub btnDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
		Using stream As New MemoryStream()
			Dim docServer As RichEditDocumentServer = CType(Session("UploadedFile"), RichEditDocumentServer)
			Dim value As Integer = CInt(Fix(cbDownloadType.Value))

			If docServer IsNot Nothing Then
				If value = 4 Then
					docServer.ExportToPdf(stream)
				Else
					Dim format As DocumentFormat = ConvertIndexToFormat(value)
					docServer.SaveDocument(stream, format)
				End If
				stream.Seek(0, SeekOrigin.Begin)
				stream.CopyTo(Response.OutputStream)
			End If
			Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			Response.ContentType = ConvertIndexToContentType(value)
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Search.{0}", ConvertIndexToFileExtension(value)))
			Response.End()
		End Using
	End Sub
	Private Function ConvertIndexToFormat(ByVal value As Integer) As DocumentFormat
		Select Case value
			Case 1
				Return DocumentFormat.Rtf
			Case 2
				Return DocumentFormat.Doc
			Case 3
				Return DocumentFormat.OpenXml
			Case 5
				Return DocumentFormat.PlainText
			Case 6
				Return DocumentFormat.Mht
			Case 7
				Return DocumentFormat.OpenDocument
			Case 8
				Return DocumentFormat.WordML
			Case 9
				Return DocumentFormat.ePub

		End Select
		Return DocumentFormat.Undefined
	End Function
	Private Function ConvertIndexToContentType(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "application/msword"
			Case 2
				Return "application/msword"
			Case 3
				Return "application/msword"
			Case 4
				Return "application/msword"
			Case 5
				Return "text/plain"
			Case 6
				Return "message/rfc822"
			Case 7
				Return "application/msword"
			Case 8
				Return "text/xml"
			Case 9
				Return "application/msword"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertIndexToFileExtension(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "rtf"
			Case 2
				Return "doc"
			Case 3
				Return "docx"
			Case 4
				Return "pdf"
			Case 5
				Return "txt"
			Case 6
				Return "mht"
			Case 7
				Return "odt"
			Case 8
				Return "xml"
			Case 9
				Return "epub"
		End Select
		Return String.Empty
	End Function
	#Region "RichEditExampleEvaluatorNoTimer"
	Public Class RichEditExampleEvaluatorNoTimer
		Inherits ExampleEvaluatorByTimer
		Public Sub New()
			MyBase.New(False)
		End Sub
		Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
			If language = ExampleLanguage.VB Then
				Return New RichEditVbExampleCodeEvaluator()
			End If
			Return New RichEditCsExampleCodeEvaluator()
		End Function
	End Class
	#End Region
End Class
