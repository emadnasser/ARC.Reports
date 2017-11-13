Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Printing.Parameters
Imports DevExpress.Xpf.Printing.Parameters.Models
Imports DevExpress.Xpf.Printing
Imports DevExpress.Utils
Imports DevExpress.XtraPrinting

Namespace ReportWpfDemo
    Public Class DemoParameterTemplateSelector
        Inherits ParameterTemplateSelector


        Private templates_Renamed As New Dictionary(Of Object, DataTemplate)()
        Public ReadOnly Property Templates() As Dictionary(Of Object, DataTemplate)
            Get
                Return templates_Renamed
            End Get
        End Property

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim parameter = TryCast(item, ParameterModel)
            If parameter Is Nothing Then
                Return Nothing
            End If
            If Templates.ContainsKey(parameter.Name) Then
                Return Templates(parameter.Name)
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class

    Public Class DemoEditingFieldTemplateSelector
        Inherits EditingFieldTemplateSelector


        Private templates_Renamed As New Dictionary(Of Object, DataTemplate)()
        Public ReadOnly Property Templates() As Dictionary(Of Object, DataTemplate)
            Get
                Return templates_Renamed
            End Get
        End Property

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim editingField = Guard.ArgumentMatchType(Of TextEditingField)(item, "item")

            If Templates.ContainsKey(editingField.EditorName) Then
                Return Templates(editingField.EditorName)
            End If
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
