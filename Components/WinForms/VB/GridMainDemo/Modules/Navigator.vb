Imports System.Collections
Imports DevExpress.Data

Namespace DevExpress.XtraGrid.Demos
	Public Class NWTables
		Inherits ArrayList
		Implements DevExpress.Data.IRelationList

		Private dataSet As DataSet
		Public Sub New(ByVal ds As DataSet)
			Add(New NWTable(My.Resources.SuppliersTable, "Suppliers"))
			Add(New NWTable(My.Resources.CategoriesTable, "Categories"))
			Add(New NWTable(My.Resources.EmployeesTable, "Employees"))
			Add(New NWTable(My.Resources.ShippersTable, "Shippers"))
			Add(New NWTable(My.Resources.CustomersTable, "Customers"))
			Add(New NWTable(My.Resources.OrdersTable, "Orders500"))
			dataSet = ds
		End Sub
		'IRelationList
		Private Function IRelationList_GetRelationName(ByVal index As Integer, ByVal relationIndex As Integer) As String Implements IRelationList.GetRelationName
			If index >= 0 AndAlso index < Me.Count Then
				Return Me(index).RelationName
			End If
			Return ""
		End Function

		Private ReadOnly Property IRelationList_RelationCount() As Integer Implements IRelationList.RelationCount
			Get
				Return If(dataSet.Tables.Count > 0, 1, 0)
			End Get
		End Property

		Private Function IRelationList_GetDetailList(ByVal index As Integer, ByVal relationIndex As Integer) As IList Implements IRelationList.GetDetailList
			If dataSet.Tables.Count > 0 Then
				Return dataSet.Tables(CType(Me(index), NWTable).TableName()).DefaultView
			End If
			Return Nothing
		End Function

		Private Function IRelationList_IsMasterRowEmpty(ByVal index As Integer, ByVal relationIndex As Integer) As Boolean Implements IRelationList.IsMasterRowEmpty
			Return False
		End Function
		'IRelationList

		Default Public Overridable Shadows ReadOnly Property Item(ByVal index As Integer) As NWTable
			Get
				Return CType(MyBase.Item(index), NWTable)
			End Get
		End Property
	End Class

	Public Class NWTable

		Private fname As String
		Private ftablename As String

		Public ReadOnly Property Name() As String
			Get
				Return fname
			End Get
		End Property

		Friend ReadOnly Property RelationName() As String
			Get
				Return ftablename
			End Get
		End Property

		Public Function TableName() As String
			Return ftablename
		End Function

		Public Sub New(ByVal fname As String, ByVal ftablename As String)
			Me.fname = fname
			Me.ftablename = ftablename
		End Sub
	End Class
End Namespace
