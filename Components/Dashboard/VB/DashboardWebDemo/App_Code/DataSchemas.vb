Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Reflection
Imports DashboardMainDemo

Namespace DashboardMainDemo

	Public MustInherit Class DataSchemaDataSet
		Inherits DataSet
		Public Sub New(ByVal type As Type)
			Dim table As New DataTable(type.Name)
			For Each info As PropertyInfo In type.GetProperties()
				table.Columns.Add(New DataColumn(info.Name, info.PropertyType))
			Next info
			Tables.Add(table)
		End Sub
	End Class

	Public Class SalesPerformanceDataGeneratorKeyMetricsItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(SalesPerformanceDataGenerator.KeyMetricsItem))
		End Sub
	End Class

	Public Class SalesPerformanceDataGeneratorMonthlySalesItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(SalesPerformanceDataGenerator.MonthlySalesItem))
		End Sub
	End Class

	Public Class SalesPerformanceDataGeneratorTotalSalesItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(SalesPerformanceDataGenerator.TotalSalesItem))
		End Sub
	End Class

	Public Class SalesOverviewDataGeneratorDataItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(SalesOverviewDataGenerator.DataItem))
		End Sub
	End Class

	Public Class SalesDetailsDataGeneratorDataItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(SalesDetailsDataGenerator.DataItem))
		End Sub
	End Class

	Public Class RevenueAnalysisDataGeneratorDataItem
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(RevenueAnalysisDataGenerator.DataItem))
		End Sub
	End Class

	Public Class DepartmentDataSet
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(DepartmentData))
		End Sub
	End Class

	Public Class EmployeeDataSet
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(EmployeeData))
		End Sub
	End Class

	Public Class CustomerSupportDataSet
		Inherits DataSchemaDataSet
		Public Sub New()
			MyBase.New(GetType(CustomerSupportData.CustomerSupportItem))
		End Sub
	End Class
End Namespace
