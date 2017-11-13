Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase
Imports System.Collections
Imports DevExpress.Xpf.Core
Imports DevExpress.Utils
Imports System.Data
Imports DevExpress.Xpf.Editors
Imports DevExpress.DemoData
Imports System.Collections.Generic
Imports DevExpress.DemoData.Models
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports EditorsDemo.SCService
Imports EditorsDemo.ViewModels


Namespace EditorsDemo
    <CodeFile("ModuleResources/LookUpEditTemplates(.SL).xaml")>
    Partial Public Class LookUpEditWithWcfSource
        Inherits EditorsDemoModule

        Public Sub New()
            InitializeComponent()
            Dim viewModel As New WCFInstantFeedbackViewModel()
            DataContext = viewModel
        End Sub

        Private Sub viewModel_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
        End Sub

    End Class
End Namespace
