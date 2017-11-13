Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.Xpf.Reports.UserDesigner.Extensions
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.IO
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
Imports DevExpress.Mvvm.UI
Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.Editors
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports DevExpress.Mvvm

Namespace GridDemo
    Partial Public Class ReportsSideBarControl
        Inherits UserControl

        Public Shared ReadOnly ServiceProperty As DependencyProperty

        Shared Sub New()
            Dim ownerclass As Type = GetType(GridReportManagerService)
            ServiceProperty = DependencyProperty.Register("Service", GetType(GridReportManagerService), ownerclass, New PropertyMetadata(Nothing))
        End Sub

        Public Property Service() As GridReportManagerService
            Get
                Return DirectCast(GetValue(ServiceProperty), GridReportManagerService)
            End Get
            Set(ByVal value As GridReportManagerService)
                SetValue(ServiceProperty, value)
            End Set
        End Property

        Public Sub New(ByVal moduleName As String, ByVal reportWrapper As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper))
            InitializeComponent()
            DataContext = Me
            CreateService(moduleName, reportWrapper)
        End Sub

        Private Sub CreateService(ByVal moduleName As String, ByVal reportWrapper As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper))
            Service = New GridReportManagerService() With {.Name = moduleName}
            Interaction.GetBehaviors(TryCast(reportWrapper, DependencyObject)).Add(Service)
        End Sub
    End Class

    Public Class ListBoxEditReportBehavior
        Inherits Behavior(Of ListBoxEdit)

        Public Shared ReadOnly ReportsProperty As DependencyProperty
        Shared Sub New()
            Dim ownerclass As Type = GetType(ListBoxEditReportBehavior)
            ReportsProperty = DependencyProperty.Register("Reports", GetType(ObservableCollection(Of ReportInfoViewModel)), ownerclass, New PropertyMetadata(Nothing, Sub(d, e) CType(d, ListBoxEditReportBehavior).OnReportsChanged(e.OldValue, e.NewValue)))
        End Sub

        Private Sub OnReportsChanged(ByVal oldValue As Object, ByVal newValue As Object)
            Dim oldReports As ObservableCollection(Of ReportInfoViewModel) = TryCast(oldValue, ObservableCollection(Of ReportInfoViewModel))
            If oldValue IsNot Nothing Then
                RemoveHandler oldReports.CollectionChanged, AddressOf Reports_CollectionChanged
            End If
            Dim newReports As ObservableCollection(Of ReportInfoViewModel) = TryCast(newValue, ObservableCollection(Of ReportInfoViewModel))
            If oldValue IsNot Nothing Then
                AddHandler newReports.CollectionChanged, AddressOf Reports_CollectionChanged
            End If
        End Sub

        Public Property Reports() As ObservableCollection(Of ReportInfoViewModel)
            Get
                Return CType(GetValue(ReportsProperty), ObservableCollection(Of ReportInfoViewModel))
            End Get
            Set(ByVal value As ObservableCollection(Of ReportInfoViewModel))
                SetValue(ReportsProperty, value)
            End Set
        End Property

        Protected Overrides Sub OnDetaching()
            MyBase.OnDetaching()
            If Reports IsNot Nothing Then
                RemoveHandler Reports.CollectionChanged, AddressOf Reports_CollectionChanged
            End If
        End Sub

        Private Sub Reports_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            If e.OldItems.Count = 0 AndAlso AssociatedObject IsNot Nothing Then
                AssociatedObject.SelectedIndex = 0
            End If
        End Sub
    End Class
End Namespace
