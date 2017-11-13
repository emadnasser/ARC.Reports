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
Imports DevExpress.Xpf.Core.ServerMode

Namespace EditorsDemo
    <CodeFile("ModuleResources/LookUpEditTemplates(.SL).xaml")>
    Partial Public Class EditorsAsyncServerMode
        Inherits EditorsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            Return DataContext
        End Function
    End Class
    <POCOViewModel>
    Public Class EditorsAsyncServerModeViewModel
        Public Overridable Property LinqSource() As LinqInstantFeedbackDataSource
        Public Overridable Property EditValue() As Object

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

            Dim linqSource_Renamed = New LinqInstantFeedbackDataSource()
            AddHandler linqSource_Renamed.GetQueryable, Sub(sender, args)
                args.KeyExpression = "PersonID"
                args.QueryableSource = If(ServerModeOptions.IsCorrectConnection, (New PersonDataContext(ServerModeOptions.SQLConnectionString)).Person, Nothing)
                args.Handled = True
            End Sub
            LinqSource = linqSource_Renamed
        End Sub
    End Class
End Namespace
