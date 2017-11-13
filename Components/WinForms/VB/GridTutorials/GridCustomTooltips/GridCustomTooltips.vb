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
    ''' Summary description for GridCustomTooltips.
    ''' </summary>
    Partial Public Class GridCustomTooltips
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

        '<gridControl1>    
        Private ColumnHints As String() = New String() {"Number automatically assigned to new product.", "", "Quantity per unit (e.g., 24-count case, 1-liter bottle).", "", "", "", "Minimum units to maintain in stock.", "Yes - means item is no longer available."}
        '</gridControl1>
        Private Sub GridCustomTooltips_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Private Function GetCellHintText(ByVal view As GridView, ByVal rowHandle As Integer, ByVal column As DevExpress.XtraGrid.Columns.GridColumn) As String
            Dim ret As String = view.GetRowCellDisplayText(rowHandle, column)
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In view.Columns
                If col.VisibleIndex < 0 Then
                    ret &= String.Format(Constants.vbCrLf & " {0}: {1}", col.GetTextCaption(), view.GetRowCellDisplayText(rowHandle, col))
                End If
            Next col
            Return ret
        End Function

        Private Function GetColumnHintText(ByVal column As DevExpress.XtraGrid.Columns.GridColumn) As String
            Dim ret As String = ColumnHints(gridView1.Columns.IndexOf(column))
            If ret = "" Then
                ret = column.GetTextCaption()
            End If
            Return ret
        End Function

        '<gridControl1>
        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
            If Not e.SelectedControl Is gridControl1 Then
                Return
            End If
            Dim info As ToolTipControlInfo = Nothing
            Try
                Dim view As GridView = TryCast(gridControl1.GetViewAt(e.ControlMousePosition), GridView)
                If view Is Nothing Then
                    Return
                End If
                Dim hi As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
                If hi.InRowCell Then
                    info = New ToolTipControlInfo(New CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), GetCellHintText(view, hi.RowHandle, hi.Column))
                    Return
                End If
                If Not hi.Column Is Nothing Then
                    info = New ToolTipControlInfo(hi.Column, GetColumnHintText(hi.Column))
                    Return
                End If
                If hi.HitTest = GridHitTest.GroupPanel Then
                    info = New ToolTipControlInfo(hi.HitTest, "Group panel")
                    Return
                End If

                If hi.HitTest = GridHitTest.RowIndicator Then
                    info = New ToolTipControlInfo(GridHitTest.RowIndicator.ToString() & hi.RowHandle.ToString(), "Row Handle: " & hi.RowHandle.ToString())
                    Return
                End If
            Finally
                e.Info = info
            End Try
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
