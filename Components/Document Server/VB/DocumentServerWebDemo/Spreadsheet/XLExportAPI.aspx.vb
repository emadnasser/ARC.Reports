Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web.Demos
Imports System.IO
Imports System.Net
Imports System.Web.UI.HtmlControls
Imports DevExpress.DXperience.Demos
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
Imports System.Reflection
Imports DevExpress.Export.Xl

Partial Public Class Spreadsheet_XLExportAPI
	Inherits System.Web.UI.Page
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
		ShowExamplesInTreeList(ASPxTreeList1, Me.examples)
		InitializeCodePreview()
	End Sub
	Private Sub LoadExamples()
		Dim examplePath As String = MapPath("~/App_Data/ApiExampleCode/XLExport")
		Dim examplesCS As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp)
		Dim examplesVB As Dictionary(Of String, FileInfo) = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB)
		Me.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB)
		SetIdForExamples(examples)
		CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010")
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
		lblSourceName.Text = GetExampleName(example)

		Dim formattedCode As String = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, False)
		Dim csharpCodeHolder As HtmlGenericControl = TryCast(Me.ASPxPageControl1.TabPages(0).FindControl("CSharpCodeHolder"), HtmlGenericControl)
		csharpCodeHolder.InnerHtml = formattedCode

		If String.IsNullOrEmpty(example.CodeVB) Then
			Return
		End If
		Dim vbCodeHolder As HtmlGenericControl = TryCast(Me.ASPxPageControl1.TabPages(1).FindControl("VbCodeHolder"), HtmlGenericControl)

		formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, False)
		vbCodeHolder.InnerHtml = formattedCode
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

		Dim isCSVFormatEnabled As String = If(Me.IsCSVFormatEnabled(example.RegionName), "true", "false")
		Dim isXLSFormatEnabled As String = If(Me.IsXLSFormatEnabled(example.RegionName), "true", "false")
		e.Result = String.Format("{0}|{1}|{2}|CSharpCodeHolder${3}${4}|VBCodeHolder${5}${6}", isCSVFormatEnabled, isXLSFormatEnabled, GetExampleName(example), formattedCode.Length, formattedCode, formattedVbCode.Length, formattedVbCode)
	End Sub
	Private Function IsCSVFormatEnabled(ByVal moduleName As String) As Boolean
		Return Not XLExportForbiddenCSVExamples.Examples.Contains(moduleName)
	End Function
	Private Function IsXLSFormatEnabled(ByVal moduleName As String) As Boolean
		Return Not XLExportForbiddenXLSExamples.Examples.Contains(moduleName)
	End Function
	Private Function GetExampleName(ByVal example As CodeExample) As String
		Return String.Format("{0} example", example.RegionName)
	End Function
	Protected Sub btnExportToXLSX_Click(ByVal sender As Object, ByVal e As EventArgs)
		ExportFile(XlDocumentFormat.Xlsx)
	End Sub
	Protected Sub btnExportToXLS_Click(ByVal sender As Object, ByVal e As EventArgs)
		ExportFile(XlDocumentFormat.Xls)
	End Sub
	Protected Sub btnExportToCSV_Click(ByVal sender As Object, ByVal e As EventArgs)
		ExportFile(XlDocumentFormat.Csv)
	End Sub
	Private Sub ExportFile(ByVal fileFormat As XlDocumentFormat)
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

		Using stream As New MemoryStream()
			RunExample(example.CodeCS, stream, fileFormat)

			stream.Seek(0, SeekOrigin.Begin)
			stream.CopyTo(Response.OutputStream)

			Response.StatusCode = CInt(Fix(HttpStatusCode.OK))
			Response.ContentType = ConvertFileFormatToContentType(fileFormat)
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=XLExportApiExample.{0}", ConvertFileFormatToFileExtension(fileFormat)))
			Response.End()
		End Using
	End Sub
	Private Sub RunExample(ByVal exampleCode As String, ByVal stream As Stream, ByVal documentFormat As XlDocumentFormat)
		Dim evaluator As XLExportExampleCodeEvaluatorBase = New XLExportCSExampleCodeEvaluator()
		Dim imagePath As String = MapPath("~/App_Data/Images")
		Dim result As CodeEvaluationResult = evaluator.ExecuteCodeAndGenerateDocument(exampleCode, New Object() { stream, documentFormat, imagePath })
	End Sub

	Private Function ConvertFileFormatToContentType(ByVal fileFormat As XlDocumentFormat) As String
		Select Case fileFormat
			Case XlDocumentFormat.Xlsx
				Return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
			Case XlDocumentFormat.Xls
				Return "application/vnd.ms-excel"
			Case XlDocumentFormat.Csv
				Return "text/comma-separated-values"
		End Select
		Return String.Empty
	End Function
	Private Function ConvertFileFormatToFileExtension(ByVal fileFormat As XlDocumentFormat) As String
		Select Case fileFormat
			Case XlDocumentFormat.Xlsx
				Return "xlsx"
			Case XlDocumentFormat.Xls
				Return "xls"
			Case XlDocumentFormat.Csv
				Return "csv"
		End Select
		Return String.Empty
	End Function

	#Region "XLExportCSExampleCodeEvaluator"
	Public Class XLExportCSExampleCodeEvaluator
		Inherits XLExportExampleCodeEvaluatorBase

		Private Const codeStart_Renamed As String = "using System;" & Constants.vbCrLf & "using System.Collections.Generic;" & Constants.vbCrLf & "using System.IO;" & Constants.vbCrLf & "using System.Text;" & Constants.vbCrLf & "using System.Diagnostics;" & Constants.vbCrLf & "using System.Xml;" & Constants.vbCrLf & "using System.Data;" & Constants.vbCrLf & "using System.Drawing;" & Constants.vbCrLf & "using System.Windows.Forms;" & Constants.vbCrLf & "using System.Globalization;" & Constants.vbCrLf & "using DevExpress.Export.Xl;" & Constants.vbCrLf & "using DevExpress.XtraExport.Csv;" & Constants.vbCrLf & "using DevExpress.Spreadsheet;" & Constants.vbCrLf & "using DevExpress.Utils;" & Constants.vbCrLf & "namespace XLExportExampleCode { " & Constants.vbCrLf & "public class ExampleItem { " & Constants.vbCrLf & "        public static void Process(Stream stream, XlDocumentFormat documentFormat, string imagesPath) { " & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = "       " & Constants.vbCrLf & " }" & Constants.vbCrLf & "    }" & Constants.vbCrLf & "}" & Constants.vbCrLf

		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property

		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New CSharpCodeProvider()
		End Function
	End Class
	#End Region
	#Region "XLExportVBExampleCodeEvaluator"
	Public Class XLExportVBExampleCodeEvaluator
		Inherits XLExportExampleCodeEvaluatorBase

		Private Const codeStart_Renamed As String = "Imports Microsoft.VisualBasic" & Constants.vbCrLf & "Imports System" & Constants.vbCrLf & "Imports DevExpress.Spreadsheet" & Constants.vbCrLf & "Imports DevExpress.Export.Xl" & Constants.vbCrLf & "Imports DevExpress.XtraExport.Csv" & Constants.vbCrLf & "Imports System.Drawing" & Constants.vbCrLf & "Imports System.Windows.Forms" & Constants.vbCrLf & "Imports DevExpress.Utils" & Constants.vbCrLf & "Imports System.IO" & Constants.vbCrLf & "Imports System.Text" & Constants.vbCrLf & "Imports System.Diagnostics" & Constants.vbCrLf & "Imports System.Xml" & Constants.vbCrLf & "Imports System.Data" & Constants.vbCrLf & "Imports System.Collections.Generic" & Constants.vbCrLf & "Imports System.Globalization" & Constants.vbCrLf & "Namespace XLExportExampleCode" & Constants.vbCrLf & "	Public Class ExampleItem" & Constants.vbCrLf & "		Public Shared Sub Process(ByVal stream As Stream, ByVal documentFormat As XlDocumentFormat, ByVal imagesPath As String)" & Constants.vbCrLf & Constants.vbCrLf

		Private Const codeEnd_Renamed As String = Constants.vbCrLf & "		End Sub" & Constants.vbCrLf & "	End Class" & Constants.vbCrLf & "End Namespace" & Constants.vbCrLf

		Protected Overrides ReadOnly Property CodeStart() As String
			Get
				Return codeStart_Renamed
			End Get
		End Property
		Protected Overrides ReadOnly Property CodeEnd() As String
			Get
				Return codeEnd_Renamed
			End Get
		End Property
		Protected Overrides Function GetCodeDomProvider() As CodeDomProvider
			Return New Microsoft.VisualBasic.VBCodeProvider()
		End Function
	End Class
	#End Region
End Class
