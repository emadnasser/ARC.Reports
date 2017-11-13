Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridRowCellStyle.
    ''' </summary>
    Partial Public Class GridRowCellStyle
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

        Private Sub GridRowCellStyle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\cars.xml")
            If DBFileName <> "" Then
                Dim ds As DataSet = New DataSet()
                ds.ReadXml(DBFileName)
                gridControl1.DataSource = ds.Tables(0)
            End If
        End Sub

        '<gridControl1>
        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
            If e.RowHandle <> gridView1.FocusedRowHandle AndAlso ((e.RowHandle Mod 2 = 0 AndAlso e.Column.VisibleIndex Mod 2 = 1) OrElse (e.Column.VisibleIndex Mod 2 = 0 AndAlso e.RowHandle Mod 2 = 1)) Then
                e.Appearance.ForeColor = SystemColors.Window
                e.Appearance.BackColor = SystemColors.WindowText
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
