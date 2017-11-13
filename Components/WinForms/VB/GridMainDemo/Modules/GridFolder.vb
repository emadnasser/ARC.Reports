Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Data

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridFolder
		Inherits TutorialControl

		'<gridControl2>
		Private fileCollection As FileCollection
		'</gridControl2>
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\GridFolder.vb;VB\GridMainDemo\Modules\Directories.vb"
			TutorialInfo.WhatsThisXMLFile = "GridFolder.xml"
			'<gridControl2>
			Me.fileCollection = New FileCollection(System.IO.Directory.GetDirectoryRoot(System.Environment.SystemDirectory))
			Me.gridControl2.DataSource = Me.fileCollection
			'</gridControl2>
			Dim drives() As String = System.Environment.GetLogicalDrives()
			For i As Integer = 0 To drives.Length - 1
				Me.comboBoxDrives.Properties.Items.Add(drives(i))
			Next i
			Me.comboBoxDrives.SelectedIndex = Me.comboBoxDrives.Properties.Items.IndexOf(Me.fileCollection.FilePath)
			Me.labelCurrentPath.Text = Me.fileCollection.FilePath
			Me.gridColumnImage.Caption = " "
			AddHandler comboBoxDrives.SelectedIndexChanged, AddressOf comboBoxDrives_SelectedIndexChanged
		End Sub


		Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
			Get
				Return gridView1
			End Get
		End Property
		
		'<gridControl2>
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
			If (rowIndex < 0) OrElse (Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.File) Then
				Return
			End If
			Dim newPath As String = If(Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.Up, Me.fileCollection(rowIndex).DirectoryName, String.Empty)
			ChangeFolderPath(Me.fileCollection(rowIndex).FullName)
		End Sub
		Private Sub ChangeFolderPath(ByVal newPath As String)
			Me.gridView1.BeginUpdate()
			Try
				Me.fileCollection.FilePath = newPath
				CType(Me.gridControl2.BindingContext(Me.fileCollection), CurrencyManager).Refresh()
				Dim focusedIndex As Integer = If(newPath <> String.Empty, Me.fileCollection.IndexOf(newPath), 0)
				If focusedIndex < 0 Then
					focusedIndex = 0
				End If
				Me.gridView1.FocusedRowHandle = focusedIndex
				Me.labelCurrentPath.Text = Me.fileCollection.FilePath
			Finally
				Me.gridView1.EndUpdate()
			End Try
		End Sub
		'</gridControl2>

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
            Dim rowIndex As Integer = gridView1.ViewRowHandleToDataSourceIndex(e.RowHandle)
            If rowIndex < 0 Then Return
            If e.Column Is Me.gridColumnSize Then
                If Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.File Then
                    Dim size As Long = Me.fileCollection(rowIndex).Size
                    If size >= 1024 Then
                        e.DisplayText = String.Format("{0:### ### ###} {1}", size \ 1024, My.Resources.Kilobytes)
                    Else
                        e.DisplayText = String.Format("{0} {1}", size, My.Resources.Bytes)
                    End If
                Else
                    e.DisplayText = String.Empty
                End If
            End If
			If e.Column Is Me.gridColumnModified Then
				If Me.fileCollection(rowIndex).ItemType = FileCollectionItemType.Up Then
					e.DisplayText = String.Empty
				End If
			End If
		End Sub

		Private Sub comboBoxDrives_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			ChangeFolderPath(comboBoxDrives.Text.ToString())
		End Sub

		Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs) Handles gridView1.CalcPreviewText
			e.PreviewText = CType(gridView1.GetRow(e.RowHandle), FileCollectionItem).FullName
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
				If e.Column IsNot gridColumnName AndAlso e.Column IsNot gridColumnModified Then
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


		Private Sub GridFolder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridView1.FocusedRowHandle = 0
		End Sub
	End Class
End Namespace

