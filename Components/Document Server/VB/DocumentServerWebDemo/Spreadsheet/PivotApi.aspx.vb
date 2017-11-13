Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Docs.Demos
Imports DevExpress.Web.Demos
Imports System.IO
Imports System.Net
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Charts
Imports DevExpress.Spreadsheet.Drawings
Imports System.Text
Imports System.Web.UI.HtmlControls
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation
Imports DevExpress.Office.Services
Imports DevExpress.Web.Office

Partial Public Class Pivot_Api
	Inherits System.Web.UI.Page
	Private evaluator As ExampleEvaluatorByTimer
	Private workbook As Workbook
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
		ShowExamplesInTreeList(ASPxTreeList1, Me.examples)
		InitializeCodePreview()
	End Sub
	Private Sub RenderHTMLPreview()
		Me.workbook = New Workbook()
		workbook.ReplaceService(Of IUriStreamService)(New ASPxOfficeUriStreamService())
		workbook.AddService(GetType(IChartControllerFactoryService), New ChartControllerFactoryService())
		workbook.AddService(GetType(IChartImageService), New ChartImageService())
		Me.evaluator = New SpreadsheetExampleEvaluatorNoTimer()
		AddHandler evaluator.QueryEvaluate, AddressOf OnEvaluatorQueryEvaluate
		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"

		workbook.BeginUpdate()
		workbook.Options.Culture = CultureInfo.InvariantCulture
		Dim loaded As Boolean = workbook.LoadDocument(MapPath("~/App_Data/PivotTableTemplate.xlsx"))
		evaluator.CompileExample(Nothing, New EventArgs())
		workbook.EndUpdate()

		Dim firstSheet As Worksheet = workbook.Worksheets(0)
		Dim usedRange As Range = firstSheet.GetUsedRange()
		firstSheet.SelectedCell = usedRange(usedRange.RowCount * usedRange.ColumnCount - 1).Offset(1, 1)
		If workbook Is Nothing Then
			Response.BinaryWrite(Encoding.ASCII.GetBytes("Cannot display a preview."))
		Else
			workbook.Worksheets.ActiveWorksheet.Visible = True
			Dim htmlGenerator As New HtmlContentGenerator(Response.OutputStream)
			htmlGenerator.Generate(workbook, workbook.Worksheets.ActiveWorksheet.Index)
		End If
		Response.End()
		Return
	End Sub
	Private Sub LoadExamples()
		Dim examplePath As String = MapPath("~/App_Data/ApiExampleCode/Pivots")
		Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
		Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)
		Me.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)
		RearrangeExamples(examples)
		SetIdForExamples(examples)
		CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010")
	End Sub
	Private Sub RearrangeExamples(ByVal examples As List(Of CodeExampleGroup))
		Dim i As Integer = 0
		Do While i < examples.Count
			Dim group As CodeExampleGroup = examples(i)
			If group.Name = "Pivot Table Actions" Then
				examples.RemoveAt(i)
				examples.Insert(0, group)
				Exit Do
			End If
			i += 1
		Loop
	End Sub
	Private Sub OnEvaluatorQueryEvaluate(ByVal sender As Object, ByVal e As CodeEvaluationEventArgs)
		Dim example As New CodeExample()
		Dim sourceIndxString As String = Request.Params("preview")
		Dim sourceIndx As Integer = Convert.ToInt32(sourceIndxString)
		example = GetExampleById(examples, sourceIndx)
		e.Result = True
		e.Code = example.CodeCS
		e.Language = ExampleLanguage.Csharp
		e.EvaluationParameter = workbook
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
		Dim activeExampleId As Integer = 0
		Dim focusedNode As TreeListNode = Me.ASPxTreeList1.FocusedNode
		If focusedNode IsNot Nothing Then
			activeExampleId = Convert.ToInt32(focusedNode.Key)
		End If

		Dim example As CodeExample = GetExampleById(examples, activeExampleId)
		If example Is Nothing Then
			Return
		End If

		Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
		Response.ContentType = "text/html"

		workbook = New Workbook()
		workbook.ReplaceService(Of IUriStreamService)(New ASPxOfficeUriStreamService())
		workbook.BeginUpdate()
		workbook.Options.Culture = CultureInfo.InvariantCulture
		workbook.LoadDocument(MapPath("~/App_Data/PivotTableTemplate.xlsx"))
		evaluator = New SpreadsheetExampleEvaluatorNoTimer()
		Dim codeEvalArgs As New CodeEvaluationEventArgs()
		codeEvalArgs.Result = True
		codeEvalArgs.Code = example.CodeCS
		codeEvalArgs.Language = ExampleLanguage.Csharp
		codeEvalArgs.EvaluationParameter = workbook
		evaluator.ForceCompile(codeEvalArgs)
		workbook.EndUpdate()
		workbook.Worksheets.ActiveWorksheet.Visible = True

		Using stream As New MemoryStream()
			Dim value As Integer = CInt(Fix(cbDownloadType.Value))

			If value = 4 Then
				workbook.ExportToPdf(stream)
			Else
				Dim format As DocumentFormat = ConvertIndexToFormat(value)
				workbook.SaveDocument(stream, format)
			End If
			stream.Seek(0, SeekOrigin.Begin)
			stream.CopyTo(Response.OutputStream)
			Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			Response.ContentType = ConvertIndexToContentType(value)
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=SpreadsheetApiExample.{0}", ConvertIndexToFileExtension(value)))
			Response.End()
		End Using
	End Sub
	Private Function ConvertIndexToFormat(ByVal value As Integer) As DocumentFormat
		Select Case value
			Case 1
				Return DocumentFormat.OpenXml
			Case 2
				Return DocumentFormat.Xls
			Case 3
				Return DocumentFormat.Csv
		End Select
		Return DocumentFormat.Undefined
	End Function
	Private Function ConvertIndexToContentType(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
			Case 2
				Return "application/vnd.ms-excel"
			Case 3
				Return "text/comma-separated-values"
			Case 4
				Return "application/pdf"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertIndexToFileExtension(ByVal value As Integer) As String
		Select Case value
			Case 1
				Return "xlsx"
			Case 2
				Return "xls"
			Case 3
				Return "csv"
			Case 4
				Return "pdf"
		End Select
		Return String.Empty
	End Function

	#Region "SpreadsheetExampleEvaluator"
	Public Class SpreadsheetExampleEvaluatorNoTimer
		Inherits ExampleEvaluatorByTimer
		Public Sub New()
			MyBase.New(False)
		End Sub
		Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
			If language = ExampleLanguage.VB Then
				Return New SpreadsheetVbExampleCodeEvaluator()
			End If
			Return New SpreadsheetCSExampleCodeEvaluator()
		End Function
	End Class
	#End Region
End Class
