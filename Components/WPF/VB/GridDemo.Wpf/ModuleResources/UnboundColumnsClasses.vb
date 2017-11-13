Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    Public Class TotalCellTemplateSelector
        Inherits DataTemplateSelector

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim cellData As GridCellData = TryCast(item, GridCellData)
            If cellData IsNot Nothing Then
                Try
                    Dim value As Decimal = Convert.ToDecimal(cellData.Value)
                    If value >= 500 Then
                        Return TotalCellTemplate
                    End If
                Catch e1 As Exception
                End Try
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function
        Public Property TotalCellTemplate() As DataTemplate
    End Class
End Namespace
