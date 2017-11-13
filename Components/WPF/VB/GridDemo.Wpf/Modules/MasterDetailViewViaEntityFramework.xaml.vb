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
Imports GridDemo.Controls
Imports System.Data.EntityClient
Imports System.Data.Common
Imports DevExpress.DemoData.Helpers
Imports System.Data
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.DemoData.Models
Imports System.Data.Entity
Imports DevExpress.DemoData

Namespace GridDemo
    Partial Public Class MasterDetailViewViaEntityFramework
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Try
                grid.ItemsSource = (New NWindDataLoader()).Customers
            Catch e As EntityException
                MessageBox.Show("Connection could not be established." & Environment.NewLine & e.Message, "Connection Error", MessageBoxButton.OK)
            End Try
        End Sub
    End Class
End Namespace
