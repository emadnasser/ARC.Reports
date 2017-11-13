Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports System.Windows.Markup
Imports System.Windows.Data
Imports DevExpress.Xpf.Editors.Helpers
Imports System.Windows.Media
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class ConditionalFormatting
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
      fieldOrderYear.FilterValues.FilterType = FieldFilterType.Included
            fieldOrderYear.FilterValues.Add(1996)
   fieldOrderYear.FilterValues.Add(1997)
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub

        Private Sub OnModuleLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(fieldSalesPerson, True, False)
        End Sub

    End Class
End Namespace
