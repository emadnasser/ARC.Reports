Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    Public Class ConditionalGroupSummaryItemTemplateSelector
        Inherits DataTemplateSelector

        Private ReadOnly smallValueTemplate As DataTemplate
        Private ReadOnly largeValueTemplate As DataTemplate
        Public Sub New(ByVal smallValueTemplate As DataTemplate, ByVal largeValueTemplate As DataTemplate)
            Me.smallValueTemplate = smallValueTemplate
            Me.largeValueTemplate = largeValueTemplate
        End Sub
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim data As GridGroupSummaryData = DirectCast(item, GridGroupSummaryData)
            If data.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum Then
                Dim value As Double = Convert.ToDouble(data.Value)
                If value < 5000 Then
                    Return smallValueTemplate
                End If
                If value >= 10000 Then
                    Return largeValueTemplate
                End If
            End If
            Return Nothing
        End Function
    End Class
End Namespace
