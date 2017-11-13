Imports System
Imports System.Drawing
Imports DevExpress.XtraPrinting

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl3
        Inherits LessonPreviewControl2

        Protected Const NameColumnWidth As Single = 300
        Protected Const PriceColumnWidth As Single = 75
        Protected Const DiscontinuedColumnWidth As Single = 100
        Protected Const IconColumnWidth As Single = 50
        Protected ReadOnly borderColor As Color = Color.FromArgb(189, 177, 183)

        Public Sub New()
            AddHandler Me.link.CreateDetailArea, AddressOf CreateDetailArea
        End Sub

        Protected Sub CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            SetGraphStylesForRow(e.Graph)
            DrawTable(e.Graph)
        End Sub

        Protected Overridable Sub DrawTable(ByVal graph As BrickGraphics)
            DrawRow(graph, 0)
        End Sub

        Protected Overridable Sub DrawRow(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            If rowIndex Mod 2 = 0 Then
                graph.BackColor = Color.LightBlue
            Else
                graph.BackColor = Color.White
            End If
            DrawRowName(graph, rowIndex)
        End Sub

        Protected Sub DrawRowName(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            Dim bounds As RectangleF = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Name)
            bounds.Y = rowIndex * bounds.Height
            Dim brick As TextBrick = graph.DrawString(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Name, bounds)
            Const LeftPadding As Integer = 4
            brick.Padding = New PaddingInfo(LeftPadding, brick.Padding.Right, brick.Padding.Top, brick.Padding.Bottom)
        End Sub

        Private Sub SetGraphStylesForRow(ByVal graph As BrickGraphics)
            graph.Font = New Font("Arial", 9F)
            graph.BorderColor = borderColor
            graph.BorderWidth = 1F
            graph.StringFormat = graph.StringFormat.ChangeAlignment(StringAlignment.Near)
        End Sub
    End Class
End Namespace
