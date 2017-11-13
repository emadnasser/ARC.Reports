Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridVirtualDataDynamic.
    ''' </summary>
    Partial Public Class GridVirtualDataDynamic
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

        Private Sub GridVirtualDataDynamic_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            AddHandler vList.ListChanged, AddressOf ListChanged
            ShowVirtualListDimension()
        End Sub

        '<gridControl1>
        Private vList As VirtualListDynamic = New VirtualListDynamic()
        '</gridControl1>
        Private Sub InitData()
            '<gridControl1>
            gridControl1.DataSource = vList
            '</gridControl1>
            gridControl1.MainView.PopulateColumns()
        End Sub

        Private Sub ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            ShowVirtualListDimension()
        End Sub

        Private Sub ShowVirtualListDimension()
            lbListDimension.Text = String.Format("RowCount = {0}; ColumnCount = {1}", vList.RecordCount, vList.ColumnCount)
        End Sub

        '<gridControl1>
        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            If checkEditAddRows.Checked Then
                gridView1.BeginUpdate()
                Dim index As Integer = e.FocusedRowHandle
                If index = vList.RecordCount - 1 Then
                    vList.AddNewRecord()
                End If
                gridView1.EndUpdate()
            End If
        End Sub

        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
            If checkEditAddColumns.Checked Then
                If Not e.FocusedColumn Is Nothing AndAlso e.FocusedColumn.VisibleIndex = gridView1.VisibleColumns.Count - 1 Then
                    gridView1.BeginUpdate()
                    Dim index As Integer = gridView1.FocusedRowHandle
                    vList.AddColumn()
                    gridView1.Columns.AddField(vList.GetColumnName(vList.ColumnCount - 1)).VisibleIndex = gridView1.VisibleColumns.Count
                    gridView1.FocusedRowHandle = index
                    gridView1.EndUpdate()
                End If
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
            If e.Info.IsRowIndicator AndAlso e.RowHandle = vList.RecordCount - 1 AndAlso checkEditAddRows.Checked Then
                e.Info.ImageIndex = 2
            End If
        End Sub

        Private Sub checkEditAddRows_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAddRows.CheckedChanged
            gridView1.InvalidateRowIndicator(vList.RecordCount - 1)
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
