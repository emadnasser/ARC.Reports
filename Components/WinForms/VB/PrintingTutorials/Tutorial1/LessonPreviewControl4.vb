Imports System
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports DevExpress.Utils

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl4
        Inherits LessonPreviewControl3

        Public Sub New()
        End Sub

        Protected Overrides Sub DrawRow(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            MyBase.DrawRow(graph, rowIndex)
            DrawRowPrice(graph, rowIndex)
        End Sub

        Protected Sub DrawRowPrice(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            Dim bounds As RectangleF = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Price)
            bounds.Y = rowIndex * bounds.Height
            Dim brick As TextBrick = graph.DrawString(TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Price.ToString("c"), bounds)
            brick.HorzAlignment = HorzAlignment.Center
        End Sub
    End Class
End Namespace
