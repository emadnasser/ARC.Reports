Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Functions
Imports DevExpress.XtraSpreadsheet.Demos
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DocumentPropertiesModule
		Inherits SpreadsheetRibbonTutorialControlBase

		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			RegisterCustomFunctions()
			InitializeWorkbook()
			GenerateCustomPropertiesWorksheet()
			AddHandler spreadsheetControl1.DocumentPropertiesChanged, AddressOf spreadsheetControl1_DocumentPropertiesChanged
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return fileRibbonPage1
			End Get
		End Property
		#End Region

		Private Sub spreadsheetControl1_DocumentPropertiesChanged(ByVal sender As Object, ByVal e As DocumentPropertiesChangedEventArgs)
			If e.BuiltInPropertiesChanged Then
				spreadsheetControl1.Document.CalculateFull()
				spreadsheetControl1.Refresh()
			End If
			If e.CustomPropertiesChanged Then
				GenerateCustomPropertiesWorksheet()
			End If
		End Sub

		Private Sub InitializeWorkbook()
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DocumentProperties_template.xlsx"))
			spreadsheetControl1.Document.Unit = DevExpress.Office.DocumentUnit.Point
		End Sub

		Private Sub RegisterCustomFunctions()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			Dim customFunction As New DocumentPropertyFunction()
			If (Not workbook.GlobalCustomFunctions.Contains((CType(customFunction, ICustomFunction)).Name)) Then
				workbook.GlobalCustomFunctions.Add(customFunction)
			End If
		End Sub

		Private Sub GenerateCustomPropertiesWorksheet()
			If (Not ShouldGenerateCustomPropertiesWorksheet()) Then
				Return
			End If

			Dim workbook As IWorkbook = spreadsheetControl1.Document
			Dim worksheet As Worksheet = workbook.Worksheets("Custom")
			Dim properties As DocumentProperties = workbook.DocumentProperties
			workbook.BeginUpdate()
			Try
				Dim rowIndex As Integer = 3
				Cleanup(worksheet, rowIndex)
				For Each propertyName As String In properties.Custom.Names
					Dim propertyValue As CellValue = properties.Custom(propertyName)
					worksheet(rowIndex, 1).Value = propertyName
					worksheet(rowIndex, 2).Formula = String.Format("=DOCPROP(""{0}"")", propertyName)
					If rowIndex Mod 2 <> 0 Then
						worksheet(rowIndex, 1).Style = workbook.Styles("PropName1")
						worksheet(rowIndex, 2).Style = workbook.Styles("PropValue1")
					Else
						worksheet(rowIndex, 1).Style = workbook.Styles("PropName2")
						worksheet(rowIndex, 2).Style = workbook.Styles("PropValue2")
					End If
					worksheet(rowIndex, 2).NumberFormat = If(propertyValue.IsDateTime, "m/d/yyyy", String.Empty)
					worksheet.Rows(rowIndex).Height = 21
					rowIndex += 1
				Next propertyName
				SetLastRowBorder(worksheet, rowIndex)
			Finally
				workbook.EndUpdate()
			End Try
		End Sub

		Private Function ShouldGenerateCustomPropertiesWorksheet() As Boolean
			Return spreadsheetControl1.Document.Worksheets.Contains("Custom")
		End Function

		Private Sub Cleanup(ByVal worksheet As Worksheet, ByVal rowIndex As Integer)
			Dim usedRange As Range = worksheet.GetUsedRange()
			If usedRange.BottomRowIndex >= rowIndex Then
				Dim range As Range = worksheet.Range.FromLTRB(1, rowIndex, 2, usedRange.BottomRowIndex)
				range.ClearContents()
				range.ClearFormats()
				range.Fill.BackgroundColor = Color.White
			End If
		End Sub

		Private Sub SetLastRowBorder(ByVal worksheet As Worksheet, ByVal rowIndex As Integer)
			Dim range As Range = worksheet.Range.FromLTRB(1, rowIndex - 1, 2, rowIndex - 1)
			range.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
			range.Borders.BottomBorder.Color = Color.Gray
		End Sub
	End Class
	#Region "DocumentPropertyFunction"
	Public Class DocumentPropertyFunction
		Inherits Object
		Implements ICustomFunction
		Private Const functionName As String = "DOCPROP"
		Private ReadOnly functionParameters() As ParameterInfo

		Public Sub New()
			Me.functionParameters = New ParameterInfo() { New ParameterInfo(ParameterType.Value) }
		End Sub

		Private ReadOnly Property Name() As String Implements IFunction.Name
			Get
				Return functionName
			End Get
		End Property
		Private ReadOnly Property Parameters() As ParameterInfo() Implements IFunction.Parameters
			Get
				Return functionParameters
			End Get
		End Property
		Private ReadOnly Property ReturnType() As ParameterType Implements IFunction.ReturnType
			Get
				Return ParameterType.Value
			End Get
		End Property
		Private ReadOnly Property Volatile() As Boolean Implements IFunction.Volatile
			Get
				Return True
			End Get
		End Property

		Private Function Evaluate(ByVal parameters As IList(Of ParameterValue), ByVal context As EvaluationContext) As ParameterValue Implements IFunction.Evaluate
			Dim propertyNameParam As ParameterValue = parameters(0)
			If propertyNameParam.IsError Then
				Return propertyNameParam
			End If
			If propertyNameParam.IsText Then
				Dim propertyName As String = propertyNameParam.TextValue
				Dim properties As DocumentProperties = context.Sheet.Workbook.DocumentProperties
				' Application properties
				If propertyName.Equals("Application", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Application
				End If
				If propertyName.Equals("Manager", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Manager
				End If
				If propertyName.Equals("Company", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Company
				End If
				If propertyName.Equals("Version", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Version
				End If
				If propertyName.Equals("Security", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Security.ToString()
				End If
				' Core properties
				If propertyName.Equals("Title", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Title
				End If
				If propertyName.Equals("Subject", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Subject
				End If
				If propertyName.Equals("Author", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Author
				End If
				If propertyName.Equals("Keywords", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Keywords
				End If
				If propertyName.Equals("Description", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Description
				End If
				If propertyName.Equals("LastModifiedBy", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.LastModifiedBy
				End If
				If propertyName.Equals("Category", StringComparison.InvariantCultureIgnoreCase) Then
					Return properties.Category
				End If
				If propertyName.Equals("Created", StringComparison.InvariantCultureIgnoreCase) Then
					If properties.Created <> DateTime.MinValue Then
						Return properties.Created
					End If
					Return String.Empty
				End If
				If propertyName.Equals("Modified", StringComparison.InvariantCultureIgnoreCase) Then
					If properties.Modified <> DateTime.MinValue Then
						Return properties.Modified
					End If
					Return String.Empty
				End If
				If propertyName.Equals("Printed", StringComparison.InvariantCultureIgnoreCase) Then
					If properties.Printed <> DateTime.MinValue Then
						Return properties.Printed
					End If
					Return String.Empty
				End If
				Return properties.Custom(propertyName)
			End If
			Return ParameterValue.ErrorInvalidValueInFunction
		End Function
		Private Function GetName(ByVal culture As CultureInfo) As String Implements IFunction.GetName
			Return functionName
		End Function
	End Class
	#End Region
End Namespace