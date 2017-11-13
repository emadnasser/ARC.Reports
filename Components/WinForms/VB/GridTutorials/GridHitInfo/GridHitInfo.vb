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
    ''' Summary description for GridHitInfoForm.
    ''' </summary>
    Partial Public Class GridHitInfoForm
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

        Private Sub GridHitInfoForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitHelper.InitAdvBandedView(gridControl1)
        End Sub

        '<gridControl1>
        Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridControl1.MouseMove
            ShowHitInfo(advBandedGridView1.CalcHitInfo(New Point(e.X, e.Y)))
        End Sub

        Private Sub ShowHitInfo(ByVal hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo)
            Dim cgv As DevExpress.XtraGrid.Views.Base.ColumnView = CType(gridControl1.MainView, DevExpress.XtraGrid.Views.Base.ColumnView)
            lbHitTest.Text = hi.HitTest.ToString()
            If hi.Band Is Nothing Then
                lbBand.Text = "No band"
            Else
                lbBand.Text = hi.Band.Caption
            End If
            If hi.Column Is Nothing Then
                lbColumn.Text = "No column"
            Else
                lbColumn.Text = hi.Column.GetTextCaption()
            End If
            lbRow.Text = hi.RowHandle.ToString()
            If hi.Column Is Nothing OrElse hi.RowHandle = -1 Then
                lbCellValue.Text = " "
            Else
                If hi.Column.FieldName = "Picture" Then
                    lbCellValue.Text = ("Picture")
                Else
                    lbCellValue.Text = (cgv.GetRowCellDisplayText(hi.RowHandle, hi.Column))
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
