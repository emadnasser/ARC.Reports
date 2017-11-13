Imports System
Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports EditorsDemo.ViewModels
Imports GridDemo
Imports GridDemo.Controls
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.Generic

Namespace EditorsDemo
    <CodeFile("ModuleResources/LookUpEditTemplates(.SL).xaml")>
    Partial Public Class EditorsServerModeSource
        Inherits EditorsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            Return DataContext
        End Function
    End Class
    <POCOViewModel>
    Public Class EditorsServerModeViewModel
        Public Overridable Property People() As IQueryable

        Public Sub OnLoaded()
            If String.IsNullOrEmpty(ServerModeOptions.SQLConnectionString) Then
                ShowConnectionWizard("Return")
            End If
            UpdatePeopleSource()
        End Sub
        Public Sub Configure()
            ShowConnectionWizard("Start Demo")
            UpdatePeopleSource()
        End Sub
        Private Sub ShowConnectionWizard(ByVal demoString As String)
            If DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting Then
                Return
            End If
            Dim window As New SQLConnectionWindow("Return", New PeopleGeneratorProvider()) With {.Description = ServerModeOptions.GetComboBoxDescription()}
            If System.Windows.Application.Current IsNot Nothing Then
                window.Owner = System.Windows.Application.Current.MainWindow
            End If
            Dim result = window.ShowDialog()
            If result IsNot Nothing Then
                ServerModeOptions.SQLConnectionString = window.GetDataBaseConnectionString()
            End If
        End Sub

        Private Sub UpdatePeopleSource()
            People = If(ServerModeOptions.IsCorrectConnection, (New PersonDataContext(ServerModeOptions.SQLConnectionString)).Person, Nothing)
        End Sub
    End Class
End Namespace
