Imports Microsoft.VisualBasic
Imports DevExpress.Export.Xl
Imports System
Imports System.CodeDom.Compiler
Imports System.Reflection

Namespace DevExpress.DXperience.Demos
	#Region "CodeEvaluationResult"
	Public Enum CodeEvaluationResult
		Success
		CompileErrors
		ExecuteErrors
	End Enum
	#End Region
	#Region "XLExportExampleCodeEvaluatorBase"
	Public MustInherit Class XLExportExampleCodeEvaluatorBase
		Protected MustOverride ReadOnly Property CodeStart() As String
		Protected MustOverride ReadOnly Property CodeEnd() As String
		Protected MustOverride Function GetCodeDomProvider() As CodeDomProvider
		Protected Function GetModuleAssembly() As String
			Return AssemblyInfo.SRAssemblySpreadsheetCore
		End Function
		Protected Function GetExampleClassName() As String
			Return "XLExportExampleCode.ExampleItem"
		End Function

		Public Function ExecuteCodeAndGenerateDocument(ByVal exampleCode As String, ByVal parameters() As Object) As CodeEvaluationResult
			Dim theCode As String = String.Concat(CodeStart, exampleCode, CodeEnd)
			Dim linesOfCode() As String = { theCode }
			Return CompileAndRun(linesOfCode, parameters)
		End Function

		Protected Friend Function CompileAndRun(ByVal linesOfCode() As String, ByVal parameters() As Object) As CodeEvaluationResult
			Dim CompilerParams As New CompilerParameters()

			CompilerParams.GenerateInMemory = True
			CompilerParams.TreatWarningsAsErrors = False
			CompilerParams.GenerateExecutable = False

			Dim referencesSystem() As String = { "System.dll", "System.Windows.Forms.dll", "System.Data.dll", "System.Xml.dll", "System.Drawing.dll" }

			Dim referencesDX() As String = { AssemblyInfo.SRAssemblyData, GetModuleAssembly(), AssemblyInfo.SRAssemblyOfficeCore, AssemblyInfo.SRAssemblyPrintingCore, AssemblyInfo.SRAssemblyPrinting, AssemblyInfo.SRAssemblyDocs, AssemblyInfo.SRAssemblyUtils }
			Dim references(referencesSystem.Length + referencesDX.Length - 1) As String

			For referenceIndex As Integer = 0 To referencesSystem.Length - 1
				references(referenceIndex) = referencesSystem(referenceIndex)
			Next referenceIndex

			Dim i As Integer = 0
			Dim initial As Integer = referencesSystem.Length
			Do While i < referencesDX.Length
				Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.Load(referencesDX(i) + AssemblyInfo.FullAssemblyVersionExtension)
				If [assembly] IsNot Nothing Then
					references(i + initial) = [assembly].Location
				End If
				i += 1
			Loop
			CompilerParams.ReferencedAssemblies.AddRange(references)


			Dim provider As CodeDomProvider = GetCodeDomProvider()
			Dim compile As CompilerResults = provider.CompileAssemblyFromSource(CompilerParams, linesOfCode)

			If compile.Errors.HasErrors Then
				Return CodeEvaluationResult.CompileErrors
			End If

			Dim [module] As System.Reflection.Module = Nothing
			Try
				[module] = compile.CompiledAssembly.GetModules()(0)
			Catch
			End Try

			Dim moduleType As Type = Nothing

			If [module] Is Nothing Then
				Return CodeEvaluationResult.CompileErrors
			End If

			moduleType = [module].GetType(GetExampleClassName())

			Dim methInfo As MethodInfo = Nothing
			If moduleType Is Nothing Then
				Return CodeEvaluationResult.CompileErrors
			End If

			methInfo = moduleType.GetMethod("Process")

			If methInfo Is Nothing Then
				Return CodeEvaluationResult.CompileErrors
			End If
			Try
				methInfo.Invoke(Nothing, parameters)
			Catch ex As Exception
				ShowErrorMessage(ex.InnerException.Message)
				Return CodeEvaluationResult.ExecuteErrors
			End Try
			Return CodeEvaluationResult.Success
		End Function
		Protected Overridable Sub ShowErrorMessage(ByVal message As String)
		End Sub
	End Class
	#End Region
End Namespace
