Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core
Imports System.Diagnostics
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Utils
Imports DevExpress.Mvvm


Namespace GridDemo
    <CodeFile("ModuleResources/RowTemplateClasses.(cs)"), CodeFile("ModuleResources/RowTemplateTemplates(.SL).xaml")>
    Partial Public Class RowTemplate
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            CheckBox.IsChecked = True
            view.Tag = New DelegateCommand(Of Object)(AddressOf OnSendMail)
        End Sub
        Private Sub OnSendMail(ByVal parameter As Object)
            Dim emailUri As String = "mailto:" & parameter.ToString()
            Try
                Process.Start(emailUri)
            Catch
            End Try
        End Sub
        Private Sub CheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If grid IsNot Nothing Then
                colEMail.CellTemplate = CType(Resources("eMailTemplate"), DataTemplate)
            End If
        End Sub

        Private Sub CheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If grid IsNot Nothing Then
                colEMail.CellTemplate = Nothing
            End If
        End Sub

        Private Sub RowTemplateComboBox_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If grid Is Nothing Then
                Return
            End If
            If rowTemplateComboBox.SelectedIndex = 0 Then
                view.DataRowTemplate = CType(Resources("expandableRowDetailTemplate"), DataTemplate)
            End If
            If rowTemplateComboBox.SelectedIndex = 1 Then
                view.DataRowTemplate = CType(Resources("rowDetailTemplate"), DataTemplate)
            End If
            If rowTemplateComboBox.SelectedIndex = 2 Then
                view.DataRowTemplate = CType(Resources("rowToolTipTemplate"), DataTemplate)
            End If
            If rowTemplateComboBox.SelectedIndex = 3 Then
                view.ClearValue(DevExpress.Xpf.Grid.TableView.DataRowTemplateProperty)
            End If
        End Sub

  Protected ReadOnly Property ShouldUseModifiedTheme() As Boolean
   Get
       Return rowTemplateComboBox.SelectedIndex <= 2
   End Get
  End Property
    End Class
End Namespace
