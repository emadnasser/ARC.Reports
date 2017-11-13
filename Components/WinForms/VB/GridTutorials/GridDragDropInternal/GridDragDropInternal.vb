Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridDragDropInternal.
    ''' </summary>
    Partial Public Class GridDragDropInternal
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
        Private hitInfo As GridHitInfo = Nothing
        Private Sub GridDragDropInternal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            gridView1.SetRowExpanded(-1, True)
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Contacts.xml")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                ds.ReadXml(DBFileName)
                gridControl1.DataSource = ds.Tables(0)
            End If
        End Sub


        '<gridControl1>
        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseDown
            hitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
            If hitInfo.RowHandle < 0 Then
                hitInfo = Nothing
            End If
        End Sub

        Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseMove
            If hitInfo Is Nothing Then
                Return
            End If
            If e.Button <> Windows.Forms.MouseButtons.Left Then
                Return
            End If
            Dim dragRect As Rectangle = New Rectangle(New Point(hitInfo.HitPoint.X - SystemInformation.DragSize.Width \ 2, hitInfo.HitPoint.Y - SystemInformation.DragSize.Height \ 2), SystemInformation.DragSize)
            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                If hitInfo.InRow Then
                    gridControl1.DoDragDrop(New Object() {hitInfo.RowHandle, gridControl1}, DragDropEffects.All)
                End If
            End If
        End Sub
        '</gridControl1>

        Private Function GetDragObject(ByVal sender As Object, ByVal data As IDataObject) As Integer
            Dim obj As Object() = TryCast(data.GetData(GetType(Object())), Object())
            If obj Is Nothing OrElse (Not sender.Equals(gridControl1)) Then
                Return -2
            End If
            If TypeOf obj(0) Is Int32 Then
                Return CInt(Fix(obj(0)))
            Else
                Return -1
            End If
        End Function

        '<gridControl1>
        Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gridControl1.DragOver
            Dim hi As GridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(New Point(e.X, e.Y)))
            Dim handle As Integer = GetDragObject(sender, e.Data)
            If hi.InRow AndAlso handle >= 0 AndAlso handle <> hi.RowHandle Then
                If (e.KeyState And 8) <> 0 Then
                    e.Effect = DragDropEffects.Copy
                Else
                    e.Effect = DragDropEffects.Move
                End If
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub

        Private Sub gridControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gridControl1.DragDrop
            Dim hi As GridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(New Point(e.X, e.Y)))
            Dim handle As Integer = GetDragObject(sender, e.Data)
            If handle < 0 Then
                Return
            End If
            If hi.InRow Then
                Dim i As Integer = 0
                Dim row As DataRowView = TryCast(gridView1.GetRow(handle), DataRowView)
                'the following code determines whether the target row is a group row and if a group row is detected, 
                'it retrieves the actual data row corresponding to it.
                Dim newHandle As Integer = hi.RowHandle
                If newHandle < 0 Then
                    gridView1.SetRowExpanded(newHandle, True, True)
                    newHandle = gridView1.GetDataRowHandleByGroupRowHandle(newHandle)
                End If
                Dim rowReciever As DataRow = gridView1.GetDataRow(newHandle)
                'the following code implements actual data moving or copying
                Dim newRow As DataRowView = Nothing
                If e.Effect = DragDropEffects.Copy Then
                    newRow = (CType(gridView1.DataSource, DataView)).AddNew()
                    i = 0
                    Do While i < gridView1.Columns.Count
                        newRow.Row(gridView1.Columns(i).FieldName) = row(gridView1.Columns(i).FieldName)
                        i += 1
                    Loop
                    row = newRow
                End If
                i = 0
                Do While i < gridView1.SortInfo.GroupCount
                    row.Row(gridView1.GroupedColumns(i).FieldName) = rowReciever(gridView1.GroupedColumns(i).FieldName)
                    i += 1
                Loop
                If Not newRow Is Nothing Then
                    newRow.Row("id") = (CType(gridView1.DataSource, DataView)).Count
                End If
                row.EndEdit()
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridView1.ShowingEditor
            If (Not MouseButtons.Equals(Windows.Forms.MouseButtons.None)) Then
                e.Cancel = True
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
