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
    Partial Public Class MultipleTotals
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            fieldYear.FilterValues.FilterType = FieldFilterType.Included
            fieldYear.FilterValues.Add(fieldYear.GetUniqueValues()(0))
        End Sub
    End Class
End Namespace
