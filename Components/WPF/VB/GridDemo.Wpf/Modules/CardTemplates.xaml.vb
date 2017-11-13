Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid
Imports System.Diagnostics
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/CardTemplatesClasses.(cs)"), CodeFile("ModuleResources/CardTemplatesResources(.SL).xaml")>
    Partial Public Class CardTemplates
        Inherits GridDemoModule

        Public Shared ReadOnly SendMail As New RoutedCommand("SendMail", GetType(RowTemplate))

        Public Shared ReadOnly SelectedTabIndexProperty As DependencyProperty
        Public Shared ReadOnly IsNotesExpandedProperty As DependencyProperty
        Shared Sub New()
            SelectedTabIndexProperty = DependencyProperty.RegisterAttached("SelectedTabIndex", GetType(Integer), GetType(CardTemplates), New PropertyMetadata(0, Nothing, AddressOf OnSelectedTabIndexCoerce))
            IsNotesExpandedProperty = DependencyProperty.RegisterAttached("IsNotesExpanded", GetType(Boolean), GetType(CardTemplates), New PropertyMetadata(False))
        End Sub
        Private Shared Function OnSelectedTabIndexCoerce(ByVal d As DependencyObject, ByVal baseValue As Object) As Object
            If DirectCast(baseValue, Integer) = -1 Then
                Return GetSelectedTabIndex(d)
            End If
            Return baseValue
        End Function

        Public Shared Sub SetSelectedTabIndex(ByVal element As DependencyObject, ByVal value As Integer)
            element.SetValue(SelectedTabIndexProperty, value)
        End Sub
        Public Shared Function GetSelectedTabIndex(ByVal element As DependencyObject) As Integer
            Return DirectCast(element.GetValue(SelectedTabIndexProperty), Integer)
        End Function
        Public Shared Sub SetIsNotesExpanded(ByVal element As DependencyObject, ByVal value As Boolean)
            element.SetValue(IsNotesExpandedProperty, value)
        End Sub
        Public Shared Function GetIsNotesExpanded(ByVal element As DependencyObject) As Boolean
            Return DirectCast(element.GetValue(IsNotesExpandedProperty), Boolean)
        End Function

        Public Sub New()
            InitializeComponent()
            CommandBindings.Add(New CommandBinding(SendMail, New ExecutedRoutedEventHandler(AddressOf OnSendMail)))
        End Sub
        Private Sub OnSendMail(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
            Try
                Process.Start("mailto:" & e.Parameter.ToString())
            Catch
            End Try
        End Sub
        Private Sub cardHeaderTemplateListBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If cardHeaderTemplateListBox.SelectedIndex = 0 Then
                view.ClearValue(DevExpress.Xpf.Grid.CardView.CardHeaderTemplateProperty)
            End If
            If cardHeaderTemplateListBox.SelectedIndex = 1 Then
                view.CardHeaderTemplate = CType(FindResource("headerTemplateFullName"), DataTemplate)
            End If
            If cardHeaderTemplateListBox.SelectedIndex = 2 Then
                view.CardHeaderTemplate = CType(FindResource("headerTemplateFullNameWithIcon"), DataTemplate)
            End If
        End Sub

        Private Sub eMailTemplateListBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If eMailTemplateListBox.SelectedIndex = 0 Then
                colEMail.CellTemplate = Nothing
            End If
            If eMailTemplateListBox.SelectedIndex = 1 Then
                colEMail.CellTemplate = CType(FindResource("eMailTemplateCards"), DataTemplate)
            End If
            view.CardRowTemplateSelector = Nothing
            If eMailTemplateListBox.SelectedIndex = 2 Then
                view.CardRowTemplateSelector = New EMailCardRowTemplateSelector(CType(FindResource("eMailTemplateCards"), DataTemplate))
            End If
        End Sub

        Private Sub cardTemplateListBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If cardTemplateListBox.SelectedIndex = 0 Then
    view.ClearValue(CardsPanel.FixedSizeProperty)
                view.ClearValue(DevExpress.Xpf.Grid.CardView.CardTemplateProperty)
                eMailTemplateListBox.IsEnabled = True
    Return
            End If
   view.FixedSize = 300
            If cardTemplateListBox.SelectedIndex = 1 Then
                view.CardTemplate = CType(FindResource("cardTemplate1"), DataTemplate)
                eMailTemplateListBox.IsEnabled = False
            End If
            If cardTemplateListBox.SelectedIndex = 2 Then
                view.CardTemplate = CType(FindResource("cardTemplate2"), DataTemplate)
                eMailTemplateListBox.IsEnabled = False
            End If
        End Sub
    End Class
End Namespace
