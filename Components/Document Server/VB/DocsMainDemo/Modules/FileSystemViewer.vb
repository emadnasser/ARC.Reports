Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Data

Namespace DevExpress.Docs.Demos.Modules
	Partial Public Class FileSystemViewer
		Inherits UserControl
		Private fileCollection As FileCollection
		Public Sub New()
			InitializeComponent()
			AddHandler Load, AddressOf OnFileSystemViewerLoad
		End Sub

		Private Sub OnFileSystemViewerLoad(ByVal sender As Object, ByVal e As EventArgs)
			Me.fileCollection = New FileCollection(System.IO.Directory.GetDirectoryRoot(System.Environment.SystemDirectory))
			Me.gridControl1.DataSource = Me.fileCollection
			Dim drives() As String = System.Environment.GetLogicalDrives()
			For i As Integer = 0 To drives.Length - 1
				Me.cbDrives.Properties.Items.Add(drives(i))
			Next i
			SubscribeCbDrivesEvents()
			Me.fileCollection.FilePath = FindDemoFolder()
			UpdateDriveLetter()
			UpdateUserPath()
			ChangeFolderPath(FindDemoFolder())
		End Sub

		Public Function GetSelectedFiles() As List(Of FileCollectionItem)
			Dim result As New List(Of FileCollectionItem)()
			Dim rowIndeces() As Integer = gridView1.GetSelectedRows()
			If rowIndeces.Length <= 0 Then
				Return result
			End If
			Dim zeroRowIndex As Integer = rowIndeces(0)
			Dim index As Integer = gridView1.ViewRowHandleToDataSourceIndex(zeroRowIndex)
			If rowIndeces.Length = 1 AndAlso index < Me.fileCollection.Count AndAlso Me.fileCollection(index).ItemType = FileCollectionItemType.Up Then
				result.Add(Me.fileCollection(0))
				Return result
			End If

			For Each rowIndex As Integer In rowIndeces
				If (rowIndex < 0) Then
					Continue For
				End If
				Dim sourceIndex As Integer = gridView1.ViewRowHandleToDataSourceIndex(rowIndex)
				If index < Me.fileCollection.Count Then
					result.Add(Me.fileCollection(sourceIndex))
				End If
			Next rowIndex
			Return result
		End Function
		Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView1.MouseDown
			If e.Clicks > 1 Then
				Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = Me.gridView1.CalcHitInfo(New Point(e.X, e.Y))
				If hitInfo.InRow Then
					ChangedFolderPath()
				End If
			End If
		End Sub
		Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridView1.KeyDown
			If e.KeyCode = Keys.Enter Then
				ChangedFolderPath()
			End If
		End Sub
		Private Sub ChangedFolderPath()
			Dim rowIndex As Integer = gridView1.ViewRowHandleToDataSourceIndex(Me.gridView1.FocusedRowHandle)
			If (rowIndex < 0) OrElse (Me.fileCollection.Count <= rowIndex) OrElse (Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.File) Then
				Return
			End If
			Dim newPath As String = If(Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.Up, Me.fileCollection(rowIndex).DirectoryName, String.Empty)
			ChangeFolderPath(Me.fileCollection(rowIndex).FullName)
		End Sub
		Private Sub ChangeFolderPath(ByVal newPath As String)
			Me.gridView1.BeginUpdate()
			Try
				Me.fileCollection.FilePath = newPath
				CType(Me.gridControl1.BindingContext(Me.fileCollection), CurrencyManager).Refresh()
				Dim focusedIndex As Integer = If(newPath IsNot String.Empty, Me.fileCollection.IndexOf(newPath), 0)
				If focusedIndex < 0 Then
					focusedIndex = 0
				End If
				Me.gridView1.FocusedRowHandle = focusedIndex
				UpdateUserPath()
			Finally
				Me.gridView1.EndUpdate()
			End Try
		End Sub
		'</gridControl2>

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			Dim rowIndex As Integer = gridView1.ViewRowHandleToDataSourceIndex(e.RowHandle)
			If rowIndex < 0 OrElse rowIndex >= Me.fileCollection.Count Then
				Return
			End If
			Dim fileItem As FileCollectionItem = Me.fileCollection(rowIndex)
			If e.Column Is Me.gridColumnSize Then
				If fileItem.ItemType = FileCollectionItemType.File Then
					Dim size As Long = fileItem.Size
					If size >= 1024 Then
						e.DisplayText = String.Format("{0:### ### ###} {1}", size \ 1024, "Kb")
					Else
						e.DisplayText = String.Format("{0} {1}", size, "B")
					End If
				Else
					e.DisplayText = String.Empty
				End If
			End If
			If e.Column Is Me.gridColumnModified Then
				If fileItem.ItemType = FileCollectionItemType.Up Then
					e.DisplayText = String.Empty
				End If
			End If
		End Sub

		Private Sub comboBoxDrives_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			ChangeFolderPath(cbDrives.Text.ToString())
		End Sub

		Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
			e.PreviewText = (CType(gridView1.GetRow(e.RowHandle), FileCollectionItem)).FullName
		End Sub

		Private Function FolderComparer(ByVal item1 As FileCollectionItem, ByVal item2 As FileCollectionItem) As Integer
			If item1.ItemType <> item2.ItemType Then
				If item1.ItemType = FileCollectionItemType.Up Then
					Return -1
				End If
				If item2.ItemType = FileCollectionItemType.Up Then
					Return 1
				End If
				If item1.ItemType = FileCollectionItemType.Directory Then
					Return -1
				End If
				If item2.ItemType = FileCollectionItemType.Directory Then
					Return 1
				End If
			End If
			Return 0
		End Function

		Private Function IsFolder(ByVal item1 As FileCollectionItem) As Boolean
			If item1.ItemType = FileCollectionItemType.Up Then
				Return True
			End If
			If item1.ItemType = FileCollectionItemType.Directory Then
				Return True
			End If
			Return False
		End Function

		Private Sub gridView1_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs) Handles gridView1.CustomColumnSort
			Dim item1 As FileCollectionItem = TryCast(e.RowObject1, FileCollectionItem), item2 As FileCollectionItem = TryCast(e.RowObject2, FileCollectionItem)
			Dim res As Integer = FolderComparer(item1, item2)
			If res = 0 Then
				res = Comparer.Default.Compare(e.Value1, e.Value2)
				If e.Column IsNot Me.gridColumnName AndAlso e.Column IsNot gridColumnModified Then
					If IsFolder(item1) Then
						res = Comparer.Default.Compare(item1.Name, item2.Name)
						If res <> 0 AndAlso e.SortOrder = ColumnSortOrder.Descending Then
							res = If(res > 0, -1, 1)
						End If

						e.Result = res
						e.Handled = True
						Return
					End If
				End If
			Else
				If res <> 0 AndAlso e.SortOrder = ColumnSortOrder.Descending Then
					res = If(res > 0, -1, 1)
				End If
			End If
			e.Result = res
			e.Handled = True
		End Sub


		Private Sub GridFolder_Load(ByVal sender As Object, ByVal e As System.EventArgs)
			gridView1.FocusedRowHandle = 0
		End Sub

		Private Sub edtCurrentPath_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles edtCurrentPath.KeyDown
			If e.KeyCode <> Keys.Enter Then
				Return
			End If
			SetNewPath()
		End Sub
		Private Sub SetNewPath()
			Try
				Dim fileName As String = edtCurrentPath.Text.Trim(""""c, " "c)
				Dim dirInfo As New System.IO.DirectoryInfo(fileName)
				If (Not dirInfo.Exists) Then
					edtCurrentPath.Text = fileCollection.FilePath
				Else
					ChangeFolderPath(fileName)
					UpdateDriveLetter()
				End If
			Catch
				UpdateUserPath()
			End Try
		End Sub

		Private Sub UpdateDriveLetter()
			UnsubscribeCbDrivesEvents()
			Me.cbDrives.EditValue = System.IO.Path.GetPathRoot(Me.fileCollection.FilePath)
			SubscribeCbDrivesEvents()
		End Sub

		Private Sub UnsubscribeCbDrivesEvents()
			RemoveHandler Me.cbDrives.SelectedIndexChanged, AddressOf comboBoxDrives_SelectedIndexChanged
		End Sub
		Private Sub SubscribeCbDrivesEvents()
			AddHandler Me.cbDrives.SelectedIndexChanged, AddressOf comboBoxDrives_SelectedIndexChanged
		End Sub
		Private Sub UpdateUserPath()
			edtCurrentPath.Text = fileCollection.FilePath
		End Sub
		Private Function FindDemoFolder() As String
			Dim demoPath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().FullName)
			Dim currentDirInfo As New DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().FullName)
			Do
				If currentDirInfo.Name.Contains("Demos") Then
					Return currentDirInfo.FullName
				End If
				currentDirInfo = currentDirInfo.Parent
			Loop While currentDirInfo IsNot Nothing
			Return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		End Function
	End Class
End Namespace
