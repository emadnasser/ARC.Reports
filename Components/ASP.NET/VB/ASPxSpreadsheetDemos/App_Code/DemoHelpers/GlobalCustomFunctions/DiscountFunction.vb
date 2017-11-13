Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports DevExpress.Spreadsheet.Functions

Public Class DiscountFunction
	Implements ICustomFunction
	Private Const functionName As String = "Discount"
	Private ReadOnly functionParameters() As ParameterInfo

	Public Sub New()
		Me.functionParameters = New ParameterInfo() { New ParameterInfo(ParameterType.Value, ParameterAttributes.Required), New ParameterInfo(ParameterType.Value, ParameterAttributes.Required)}
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
	' Reevaluate cells on every recalculation. 
	' The SpreadsheetControl ignores this value and assumes that the Volatile is always true.
	Private ReadOnly Property Volatile() As Boolean Implements IFunction.Volatile
		Get
			Return True
		End Get
	End Property

	Private Function Evaluate(ByVal parameters As IList(Of ParameterValue), ByVal context As EvaluationContext) As ParameterValue Implements IFunction.Evaluate
		Dim quantity As Double
		Dim price As Double
		Dim quantityParameter As ParameterValue
		Dim priceParameter As ParameterValue

		quantityParameter = parameters(0)
		If quantityParameter.IsError Then
			Return quantityParameter
		Else
			quantity = quantityParameter.NumericValue
		End If

		priceParameter = parameters(1)
		If priceParameter.IsError Then
			Return priceParameter
		Else
			price = priceParameter.NumericValue
		End If

		If quantity >= 50 Then
			Return Math.Round(quantity * price * 0.25, 2)
		End If
		If quantity >= 20 Then
			Return Math.Round(quantity * price * 0.1, 2)
		End If
		Return 0

	End Function
	Private Function GetName(ByVal culture As System.Globalization.CultureInfo) As String Implements IFunction.GetName
		Return functionName
	End Function
End Class
