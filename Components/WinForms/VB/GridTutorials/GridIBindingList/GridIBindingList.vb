Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridIBindingList.
    ''' </summary>
    Partial Public Class GridIBindingList
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

        Private Sub GridIBindingList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            lbEvent.Text = "Ctrl+Del - Delete focused record."
            InitData()
        End Sub

        '<gridControl1>
        Private Sub InitData()
            Dim collection As GridIBindingListRecords = New GridIBindingListRecords()
            collection.Add(New GridIBindingListRecord(collection, "John Doe", 99.99, New DateTime(2003, 5, 30)))
            collection.Add(New GridIBindingListRecord(collection, "Alfred Newman", 50, New DateTime(2003, 7, 24)))

            gridControl1.DataSource = collection
        End Sub

        Private Sub gridControl1_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridControl1.ProcessGridKey
            If e.KeyCode = Keys.Delete AndAlso e.Control Then
                If gridView1.FocusedRowHandle >= 0 Then
                    Dim r As GridIBindingListRecord = CType(gridView1.GetRow(gridView1.FocusedRowHandle), GridIBindingListRecord)
                    Dim collection As GridIBindingListRecords = CType(gridControl1.DataSource, GridIBindingListRecords)
                    Dim index As Integer = collection.IndexOf(r)
                    If index <> -1 Then
                        collection.RemoveAt(index)
                    End If
                End If
            End If
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
