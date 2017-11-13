Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewControl7
        Inherits LessonPreviewControl6

        Private Shared columnsNames As Dictionary(Of TutorialHelper.ProductsHelper.ProductColumn, String)

        Shared Sub New()
            columnsNames = New Dictionary(Of TutorialHelper.ProductsHelper.ProductColumn, String)()
            columnsNames(TutorialHelper.ProductsHelper.ProductColumn.Name) = "Name"
            columnsNames(TutorialHelper.ProductsHelper.ProductColumn.Price) = "Price"
            columnsNames(TutorialHelper.ProductsHelper.ProductColumn.Discontinued) = "Discontinued"
            columnsNames(TutorialHelper.ProductsHelper.ProductColumn.Icon) = "Type"
        End Sub

        Public Sub New()
            AddHandler link.CreateDetailHeaderArea, AddressOf CreateDetailHeaderArea
        End Sub

        Private Shared ReadOnly headerBackColor As Color = Color.FromArgb(224, 214, 211)

        Private Sub CreateDetailHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            e.Graph.Font = New Font("Arial", 10F, FontStyle.Bold)
            e.Graph.BorderWidth = 1F
            e.Graph.BorderColor = borderColor
            e.Graph.BackColor = headerBackColor

            For Each column As TutorialHelper.ProductsHelper.ProductColumn In System.Enum.GetValues(GetType(TutorialHelper.ProductsHelper.ProductColumn))
                Dim columnName As String = columnsNames(column)
                Dim bounds As RectangleF = TutorialHelper.ProductsHelper.GetBoundsForColumn(column)
                Dim brick As TextBrick = e.Graph.DrawString(columnName, bounds)
                brick.HorzAlignment = HorzAlignment.Center
            Next column
        End Sub
    End Class
End Namespace
