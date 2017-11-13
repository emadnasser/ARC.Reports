Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridMultiEditors.
    ''' </summary>
    Partial Public Class GridMultiEditors
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

        Private Sub GridMultiEditors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim records As GridMultiEditorsRecord() = New GridMultiEditorsRecord(8) {}
            records(0) = New GridMultiEditorsRecord("Product Name", "Chai", "Teatime Chocolate Biscuits", "Ipoh Coffee")
            records(1) = New GridMultiEditorsRecord("Category", "1", "2", "1")
            records(2) = New GridMultiEditorsRecord("Supplier", "Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading")
            records(3) = New GridMultiEditorsRecord("Quantity Per Unit", "10 boxes x 20 bags", "10 boxes x 12 pieces", "16 - 500 g tins")
            records(4) = New GridMultiEditorsRecord("Unit Price", 18.0, 9.2, 46.0)
            records(5) = New GridMultiEditorsRecord("Units in Stock", 39, 25, 17)
            records(6) = New GridMultiEditorsRecord("Discontinued", True, False, True)
            records(7) = New GridMultiEditorsRecord("Last Order", New DateTime(2004, 12, 14), New DateTime(2003, 7, 20), New DateTime(2002, 1, 7))
            records(8) = New GridMultiEditorsRecord("Relevance", 70, 90, 50)

            gridControl1.DataSource = records
        End Sub

        '<gridControl1>
        Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
            If e.Column.FieldName <> "Category" Then
                Select Case e.RowHandle
                    Case 1
                        e.RepositoryItem = repositoryItemImageComboBox1
                    Case 2
                        e.RepositoryItem = repositoryItemComboBox1
                    Case 4
                        e.RepositoryItem = repositoryItemCalcEdit1
                    Case 5
                        e.RepositoryItem = repositoryItemSpinEdit1
                    Case 6
                        e.RepositoryItem = repositoryItemCheckEdit1
                    Case 7
                        e.RepositoryItem = repositoryItemDateEdit1
                    Case 8
                        e.RepositoryItem = repositoryItemProgressBar1
                End Select
            End If
        End Sub
        '</gridControl1>

        Private Sub gridView1_RowCellDefaultAlignment(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs) Handles gridView1.RowCellDefaultAlignment
            If e.Column.FieldName <> "Category" Then
                If e.RowHandle = 4 OrElse e.RowHandle = 5 Then
                    e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
                End If
            End If
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
