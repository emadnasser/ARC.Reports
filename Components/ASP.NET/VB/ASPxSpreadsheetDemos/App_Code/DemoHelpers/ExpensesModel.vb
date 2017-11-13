Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Xml.Serialization

Namespace DevExpress.Web.Demos
	<XmlRoot("Expenses")> _
	Public Class ExpensesReport
		Public Sub New()
			Info = New ExpensesInfo()
			Expenses = New List(Of Expense)()
		End Sub

		Public Property Info() As ExpensesInfo
		Public Property Expenses() As List(Of Expense)
	End Class

	Public Class ExpensesInfo
		Public Property Purpose() As String
		Public Property StatementNumber() As Integer
		Public Property EmployeeID() As Integer
		Public Property EmployeeName() As String
		Public Property EmployeePosition() As String
		Public Property SSN() As String
		Public Property EmployeeDepartment() As String
		Public Property Manager() As String
	End Class

	Public Class Expense
		Public Property CreationDate() As DateTime
		Public Property Account() As Integer
		Public Property Description() As String
		Public Property Hotel() As Double
		Public Property Transport() As Double
		Public Property Fuel() As Double
		Public Property Meals() As Double
		Public Property Phone() As Double
		Public Property Misc() As Double
		Public Property Entertainment() As Double
	End Class
End Namespace
