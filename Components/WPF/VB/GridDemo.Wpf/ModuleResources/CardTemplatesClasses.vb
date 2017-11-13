Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Controls
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    Public Class EMailCardRowTemplateSelector
        Inherits DataTemplateSelector

        Private template As DataTemplate
        Public Sub New(ByVal template As DataTemplate)
            Me.template = template
        End Sub
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim data As GridCellData = DirectCast(item, GridCellData)
            Return If(data.Column.FieldName = "EMail", template, Nothing)
        End Function
    End Class
End Namespace
