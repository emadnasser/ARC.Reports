Imports System
Imports System.Linq
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class Groups
        Inherits PivotGridDemoModule

        Private isExpanded As Boolean

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub UpdateGroupsExpanded()
            pivotGrid.BeginUpdate()
            Try
                For Each group As PivotGridGroup In pivotGrid.Groups
                    For Each field As PivotGridField In group
                        field.ExpandedInFieldsGroup = isExpanded
                    Next field
                Next group
            Finally
                pivotGrid.EndUpdate()
            End Try
        End Sub


        Private Sub Collapse_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            isExpanded = True
            UpdateGroupsExpanded()
        End Sub

        Private Sub Expand_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            isExpanded = False
            UpdateGroupsExpanded()
        End Sub
    End Class
End Namespace
