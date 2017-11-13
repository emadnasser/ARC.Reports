Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
    ''' <summary>
    ''' Summary description for GridVerticalHeaders.
    ''' </summary>
    Partial Public Class GridVerticalHeaders
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

        Private Sub GridVerticalHeaders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitData()
            radioGroup1.SelectedIndex = 1
        End Sub

        Private Sub InitData()
            Dim xv As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
        End Sub

        '<radioGroup1>
        Private vertical As Boolean = False
        Private diagonal As Boolean = False
        Private Sub SetParameters(ByVal vertical As Boolean, ByVal diagonal As Boolean, ByVal h As Integer)
            Me.vertical = vertical
            Me.diagonal = diagonal
            gridView1.ColumnPanelRowHeight = h
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
            Dim i As Integer = CInt(Fix(radioGroup1.EditValue))
            If i = 0 Then
                SetParameters(False, False, -1)
            End If
            If i = 1 Then
                SetParameters(True, False, 85)
            End If
            If i = 2 Then
                SetParameters(False, True, 60)
            End If
        End Sub
        '</radioGroup1>

        Private Function Transform(ByVal g As Graphics, ByVal degree As Integer, ByVal r As Rectangle) As Rectangle
            g.RotateTransform(degree)
            Dim cos As Single = CSng(Math.Round(Math.Cos(degree * (Math.PI / 180)), 2))
            Dim sin As Single = CSng(Math.Round(Math.Sin(degree * (Math.PI / 180)), 2))
            Dim r1 As Rectangle = r
            r1.X = CInt(Fix(r.X * cos + r.Y * sin))
            r1.Y = CInt(Fix(r.X * (-sin) + r.Y * cos))
            r1.Offset(7, 0)
            Return r1
        End Function

        '<gridControl1>
        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            Dim r As Rectangle = e.Info.CaptionRect
            e.Info.Caption = ""
            e.Painter.DrawObject(e.Info)
            If Not e.Column Is Nothing Then
                Dim state As System.Drawing.Drawing2D.GraphicsState = e.Graphics.Save()
                Dim sf As StringFormat = New StringFormat()
                sf.Trimming = StringTrimming.EllipsisCharacter
                sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.NoWrap
                If vertical Then
                    sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionVertical
                End If
                If diagonal Then
                    r = Transform(e.Graphics, 30, r)
                End If
                e.Graphics.DrawString(e.Column.GetTextCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf)
                e.Graphics.Restore(state)
            End If
            e.Handled = True
        End Sub
        '</gridControl1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
