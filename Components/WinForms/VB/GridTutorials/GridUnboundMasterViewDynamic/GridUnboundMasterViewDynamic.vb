Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridUnboundMasterViewDynamic.
	''' </summary>
	Partial Public Class GridUnboundMasterViewDynamic
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Private relations(,) As Object = {{ "Products", "Customers", "Shippers"}, { Nothing, Nothing, Nothing}, { "Employees", Nothing, Nothing}}

		Private Sub GridUnboundMasterViewDynamic_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			ShowMasterDetailRows()
		End Sub
		Private Sub InitData()
			Dim records As New ArrayList()
			records.Add(New GridUnboundMasterViewDynamicRecord("first"))
			records.Add(New GridUnboundMasterViewDynamicRecord("second"))
			records.Add(New GridUnboundMasterViewDynamicRecord("third"))

			gridControl1.DataSource = records
		End Sub
		Private Sub ShowMasterDetailRows()
			For i As Integer = 0 To gridView1.RowCount - 1
				gridView1.SetMasterRowExpanded(i, True)
			Next i

			Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(gridView1.GetVisibleDetailView(2), DevExpress.XtraGrid.Views.Grid.GridView)
			If gv IsNot Nothing Then
			gv.SetMasterRowExpanded(0, True)
			End If
		End Sub



		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			e.IsEmpty = IsRelationEmpty(GetRelationByRowHandle(e.RowHandle), e.RelationIndex)
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim relation As Integer = GetRelationByRowHandle(e.RowHandle)
			If IsRelationEmpty(relation, e.RelationIndex) Then
			Return
			End If
			Dim s As String = relations(relation, e.RelationIndex).ToString()
			Select Case s
				Case "Products"
					e.ChildList = New ChildRecordsProductsDynamic()
				Case "Customers"
					e.ChildList = New ChildRecordsCustomersDynamic()
				Case "Shippers"
					e.ChildList = New ChildRecordsShippersDynamic()
				Case "Employees"
					e.ChildList = New GridUnboundMasterViewDynamicRecords()
			End Select
		End Sub

		' The following MasterRowGetLevelDefaultView event handler is not required and can be commented out.
		' The code is intended to show how pattern views can be retrieved from the LevelTree tree.
		Private Sub gridView1_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles gridView1.MasterRowGetLevelDefaultView
			Dim relation As Integer = GetRelationByRowHandle(e.RowHandle)
			If IsRelationEmpty(relation, e.RelationIndex) Then
			Return
			End If
			Dim s As String = relations(relation, e.RelationIndex).ToString()
			Select Case s
				Case "Products"
					e.DefaultView = gridControl1.LevelTree.Nodes("Products").LevelTemplate
				Case "Customers"
					e.DefaultView = gridControl1.LevelTree.Nodes("Customers").LevelTemplate
				Case "Employees"
					e.DefaultView = gridControl1.LevelTree.Nodes("Employees").LevelTemplate
			End Select
		End Sub

		Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gridView1.MasterRowGetRelationCount
			e.RelationCount = 3 'max relation count
		End Sub

		Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles gridView1.MasterRowGetRelationName
			Dim relation As Integer = GetRelationByRowHandle(e.RowHandle)
			If IsRelationEmpty(relation, e.RelationIndex) Then
			e.RelationName = ""
			Else
				e.RelationName = relations(relation, e.RelationIndex).ToString()
			End If
		End Sub

		Private Function IsRelationEmpty(ByVal relation As Integer, ByVal relationIndex As Integer) As Boolean
			Return relation = GridControl.InvalidRowHandle OrElse relations(relation, relationIndex) Is Nothing
		End Function

		Private Function GetRelationByRowHandle(ByVal rowHandle As Integer) As Integer
			Dim record As GridUnboundMasterViewDynamicRecord = TryCast(gridView1.GetRow(rowHandle), GridUnboundMasterViewDynamicRecord)
			If record IsNot Nothing Then
				Select Case record.Name
					Case "first"
						Return 0
					Case "second"
						Return 1
					Case "third"
						Return 2
				End Select
			End If
			Return GridControl.InvalidRowHandle
		End Function
	End Class
End Namespace
