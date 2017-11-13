Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Data
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridDrawColumnObjects.
	''' </summary>
	Public Partial Class GridDrawColumnObjects
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

		#Region "Init"
		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim tblGrid As String = "[Order Details]"
				Dim tblLookUp As String = "Products"
				Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
				oleDbDataAdapter.Fill(ds, tblGrid)
				oleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblLookUp, con)
				oleDbDataAdapter.Fill(ds, tblLookUp)

				Dim dvManager As DataViewManager = New DataViewManager(ds)
				Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

				gridControl1.DataSource = dv
				repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
			End If
		End Sub

		Private Sub InitGrid()
			gridView1.Columns("OrderID").FilterInfo = New ColumnFilterInfo(ColumnFilterType.Custom, Nothing, "[OrderID] = 11077")
			gridView1.Columns("ProductID").SortOrder = ColumnSortOrder.Ascending
		End Sub
		#End Region
		Private Sub GridDrawColumnObjects_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			InitGrid()
		End Sub

	  '<checkEdit2>
		Private Shared Sub DrawCustomSortedShape(ByVal g As Graphics, ByVal r As Rectangle, ByVal so As ColumnSortOrder, ByVal iml As ImageList)
			If so = ColumnSortOrder.None Then
			Return
			End If
			Dim i As Integer = 0
			If so = ColumnSortOrder.Descending Then
			i = 1
			End If
            g.DrawImageUnscaled(iml.Images(i), r.X + (r.Width - iml.ImageSize.Width) \ 2, r.Y + (r.Height - iml.ImageSize.Height) \ 2)
		End Sub
	  '</checkEdit2>

	  '<checkEdit1>
		Private Shared Sub DrawCustomFilterButton(ByVal g As Graphics, ByVal column As GridColumn, ByVal filterInfo As ObjectInfoArgs, ByVal iml As ImageList)
			Dim i As Integer = 0
			If (filterInfo.State And ObjectState.Hot) <> 0 Then
			i = 1
			End If
			If (filterInfo.State And ObjectState.Pressed) <> 0 Then
			i = 2
			End If
			If column.FilterInfo.Type <> ColumnFilterType.None Then
			i += 3
			End If
            g.DrawImageUnscaled(iml.Images(i), filterInfo.Bounds.X + (filterInfo.Bounds.Width - iml.ImageSize.Width) \ 2, filterInfo.Bounds.Y + (filterInfo.Bounds.Height - iml.ImageSize.Height) \ 2)
		End Sub

	  '<checkEdit2>
		Private Sub checkEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit2.CheckedChanged, checkEdit1.CheckedChanged
			gridView1.InvalidateColumnHeader(Nothing)
		End Sub
	  '</checkEdit1>
	  '</checkEdit2>

		Private Sub UpdateInnerElements(ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs, ByVal restore As Boolean, ByRef sortBounds As Rectangle, ByRef filterBounds As Rectangle, ByRef filterInfo As ObjectInfoArgs)
			For Each item As DrawElementInfo In e.Info.InnerElements
				If TypeOf item.ElementPainter Is SortedShapeObjectPainter Then
					If (Not checkEdit2.Checked) Then
						If restore Then
							item.ElementInfo.Bounds = sortBounds
						Else
							sortBounds = item.ElementInfo.Bounds
							item.ElementInfo.Bounds = Rectangle.Empty
						End If
					End If
				End If
                If TypeOf item.ElementInfo Is DevExpress.XtraEditors.Drawing.GridFilterButtonInfoArgs Then
                    If (Not checkEdit1.Checked) Then
                        If restore Then
                            item.ElementInfo.Bounds = filterBounds
                        Else
                            filterInfo = item.ElementInfo
                            filterBounds = item.ElementInfo.Bounds
                            item.ElementInfo.Bounds = Rectangle.Empty
                        End If
                    End If
                End If
			Next item
		End Sub

	  '<checkEdit1>
	  '<checkEdit2>
		Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
			If e.Column Is Nothing Then
			Return
			End If
			Dim filterInfo As ObjectInfoArgs = Nothing
			Dim filterBounds, sortBounds As Rectangle
			sortBounds = Rectangle.Empty
			filterBounds = sortBounds
			Try
				UpdateInnerElements(e, False, sortBounds, filterBounds, filterInfo)
				e.Painter.DrawObject(e.Info)
			Finally
				UpdateInnerElements(e, True, sortBounds, filterBounds, filterInfo)
			End Try
			If (Not sortBounds.IsEmpty) Then
				DrawCustomSortedShape(e.Graphics, sortBounds, e.Column.SortOrder, SortingGlyphsImageList)
			End If
			If (Not filterBounds.IsEmpty) AndAlso Not filterInfo Is Nothing Then
				DrawCustomFilterButton(e.Graphics, e.Column, filterInfo, FilterButtonImageList)
			End If
			e.Handled = True
		End Sub
	  '</checkEdit2>
	  '</checkEdit1>

		Private ReadOnly Property FilterButtonImageList() As ImageList
			Get
				If checkEdit1.Checked Then
					Return Nothing
				Else
					Return imageList1
				End If
			End Get
		End Property

		Private ReadOnly Property SortingGlyphsImageList() As ImageList
			Get
				If checkEdit2.Checked Then
					Return Nothing
				Else
					Return imageList2
				End If
			End Get
		End Property
	End Class
End Namespace
