Imports System
Imports DevExpress.XtraPrinting
Imports System.Drawing

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl8
        Inherits LessonPreviewControl7

        Public Sub New()
            AddHandler link.CreateMarginalHeaderArea, AddressOf CreateMarginalHeaderArea
        End Sub

        Protected Overrides Sub DrawTable(ByVal graph As BrickGraphics)
            Const RowsCount As Integer = 60
            For i As Integer = 0 To RowsCount - 1
                DrawRow(graph, i)
            Next i
        End Sub

        Private Sub CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            Const PageNumberFormat As String = "Page {0} of {1}"

            Dim dateTimeBounds As New RectangleF(0, 0, 0, e.Graph.Font.Height)

            Dim pageNumberBrick As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, PageNumberFormat, Color.Black, dateTimeBounds, BorderSide.None)
            pageNumberBrick.Alignment = BrickAlignment.Far
            pageNumberBrick.AutoWidth = True

            Dim dateTimeBrick As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.DateTime, String.Empty, e.Graph.ForeColor, dateTimeBounds, BorderSide.None)
            dateTimeBrick.Alignment = BrickAlignment.Near
            dateTimeBrick.AutoWidth = True
        End Sub
    End Class
End Namespace
