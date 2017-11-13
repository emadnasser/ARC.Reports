Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridDoubleClickRow.
    ''' </summary>
    Partial Public Class GridDoubleClickRow
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

        Private Sub InitGrid()
            advBandedGridView1.OptionsBehavior.Editable = False
            advBandedGridView1.Columns("Transmiss Speed Count").GroupIndex = 0
            advBandedGridView1.ExpandAllGroups()
        End Sub

        Private Sub GridDoubleClickRow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitHelper.InitAdvBandedView(gridControl1)
            InitGrid()
        End Sub

        '<gridControl1>
        Private Sub gridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.DoubleClick
            Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = advBandedGridView1.CalcHitInfo((TryCast(sender, Control)).PointToClient(Control.MousePosition))

            If hi.RowHandle >= 0 Then
                ShowDataRow(advBandedGridView1.GetDataRow(hi.RowHandle), "", Color.White)
            ElseIf advBandedGridView1.FocusedRowHandle >= 0 Then
                ShowDataRow(advBandedGridView1.GetDataRow(advBandedGridView1.FocusedRowHandle), "Focused Row: ", Color.Yellow)
            Else
                ShowDataRow(Nothing, "Empty...", Color.DeepSkyBlue)
            End If
        End Sub
        '</gridControl1>

        Private Sub ShowDataRow(ByVal dr As DataRow, ByVal fs As String, ByVal c As Color)
            Dim s As String = ""
            If Not dr Is Nothing Then
                Dim items As Object() = dr.ItemArray
                For Each o As Object In items
                    If s = "" Then
                        s = ("") + o.ToString()
                    Else
                        s = (s & "; ") + o.ToString()
                    End If
                Next o
            End If
            lbRow.BackColor = c
            lbRow.Text = fs & s
        End Sub
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
