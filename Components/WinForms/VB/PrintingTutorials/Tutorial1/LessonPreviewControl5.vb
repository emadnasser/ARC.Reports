Imports System
Imports DevExpress.XtraPrinting
Imports System.Drawing

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl5
        Inherits LessonPreviewControl4

        Public Sub New()
        End Sub

        Protected Overrides Sub DrawRow(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            MyBase.DrawRow(graph, rowIndex)
            DrawRowDiscontinued(graph, rowIndex)
        End Sub

        Protected Sub DrawRowDiscontinued(ByVal graph As BrickGraphics, ByVal rowIndex As Integer)
            Dim bounds As RectangleF = TutorialHelper.ProductsHelper.GetBoundsForColumn(TutorialHelper.ProductsHelper.ProductColumn.Discontinued)
            bounds.Y = rowIndex * bounds.Height
            graph.DrawCheckBox(bounds, TutorialHelper.ProductsHelper.GetProductByIndex(rowIndex).Discontinued)
        End Sub
    End Class
End Namespace
