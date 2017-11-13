Imports System
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.Windows.Forms

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl6
        Inherits LessonPreviewControl5

        Public Sub New()
        End Sub

        Protected Overrides Sub DrawRow(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            MyBase.DrawRow(graph, rowIndex)
            DrawRowIcon(graph, rowIndex)
        End Sub

        Private Sub DrawRowIcon(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            Dim bounds As RectangleF = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Icon)
            bounds.Y = rowIndex * bounds.Height
            Dim brick As ImageBrick = graph.DrawImage(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Icon, bounds)
            brick.SizeMode = ImageSizeMode.CenterImage
        End Sub
    End Class
End Namespace
