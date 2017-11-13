Imports System
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Utils
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class TotalsLocation
        Inherits PivotGridDemoModule

        Shared Sub New()
            Dim ownerType As Type = GetType(TotalsLocation)
        End Sub
        Public Sub New()
            InitializeComponent()
            InitComboBoxes()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
        End Sub
        Private Sub InitComboBoxes()
            Dim arr As Array = EnumExtensions.GetValues(GetType(FieldColumnTotalsLocation))
            For Each type As FieldColumnTotalsLocation In arr
                cbColumnTotalsLocation.Items.Add(type)
            Next type
            arr = EnumExtensions.GetValues(GetType(FieldRowTotalsLocation))
            For Each type As FieldRowTotalsLocation In arr
                cbRowTotalsLocation.Items.Add(type)
            Next type
        End Sub
    End Class
End Namespace
