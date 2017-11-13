Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridCustomMenu.
    ''' </summary>
    Partial Public Class GridCustomMenu
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

        Private Sub GridCustomMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim tblGrid As String = "Products"
                Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tblGrid, con)
                oleDbDataAdapter.Fill(ds, tblGrid)

                Dim dvManager As DataViewManager = New DataViewManager(ds)
                Dim dv As DataView = dvManager.CreateDataView(ds.Tables(tblGrid))

                gridControl1.DataSource = dv
            End If
        End Sub

        '<gridControl1>
        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Right Then
                DoShowMenu(gridView1.CalcHitInfo(New Point(e.X, e.Y)))
            End If
        End Sub

        Private Sub DoShowMenu(ByVal hi As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo)
            Dim menu As DevExpress.XtraGrid.Menu.GridViewMenu = Nothing
            If hi.HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.ColumnButton Then
                menu = New GridViewColumnButtonMenu(gridView1)
                menu.Init(hi)
                menu.Show(hi.HitPoint)
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
            If e.RowHandle = GridControl.InvalidRowHandle Then
                e.Handled = True
                e.Painter.DrawObject(e.Info)

                Dim r As Rectangle = e.Bounds
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(100, 255, 0, 0)), r)
                r.Height -= 1
                r.Width -= 1
                e.Graphics.DrawRectangle(Pens.Red, r)
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
