Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridDragDropExternal.
    ''' </summary>
    Partial Public Class GridDragDropExternal
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

        Private Sub GridDragDropExternal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            gridView1.BestFitColumns()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tbl As String = "Customers"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tbl, con)
                oleDbDataAdapter.Fill(ds, tbl)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tbl))

                gridControl1.DataSource = dv
                gridControl1.MainView.PopulateColumns()
            End If
        End Sub

        Private Function DataRow(ByVal dr As DataRow) As String
            Dim s As String = ""
            If Not dr Is Nothing Then
                For Each o As Object In dr.ItemArray
                    If s = "" Then
                        s = ("") + o.ToString()
                    Else
                        s = (s & "; ") + o.ToString()
                    End If
                Next o
            End If
            Return s
        End Function

        '<gridControl1>
        Private hitInfo As GridHitInfo = Nothing
        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseDown
            hitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
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
                If hitInfo.InRowCell Then
                    gridControl1.DoDragDrop((gridView1.GetRowCellDisplayText(hitInfo.RowHandle, hitInfo.Column)), DragDropEffects.Copy)
                End If
                If hitInfo.HitTest = GridHitTest.RowIndicator Then
                    Dim data As String = DataRow(gridView1.GetDataRow(hitInfo.RowHandle))
                    gridControl1.DoDragDrop(data, DragDropEffects.Copy)
                End If
            End If
        End Sub
        '</gridControl1>

        Private Sub listBoxControl1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBoxControl1.DragEnter
            e.Effect = DragDropEffects.Copy
        End Sub

        Private Sub listBoxControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listBoxControl1.DragDrop
            Dim lb As ListBoxControl = TryCast(sender, ListBoxControl)
            Dim dragString As String = CStr(e.Data.GetData(GetType(String)))
            Dim ind As Integer = lb.IndexFromPoint(lb.PointToClient(New Point(e.X, e.Y)))
            If ind = -1 Then
                lb.Items.Add(dragString)
            Else
                lb.Items.Insert(ind, dragString)
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
