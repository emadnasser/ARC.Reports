Imports System
Imports System.Linq
Imports System.Windows
Imports System.Globalization
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class Prefilter
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            deFromDate.EditValue = New Date(1994, 8, 4, 11, 25, 54, 0)
            deToDate.EditValue = New Date(1996, 6, 5, 11, 26, 19, 0)
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddHandler deFromDate.EditValueChanged, AddressOf deFromTo_EditValueChanged
            AddHandler deToDate.EditValueChanged, AddressOf deFromTo_EditValueChanged
        End Sub
        Private Sub deFromTo_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            ApplyPrefilter()
        End Sub
        Private Sub ApplyPrefilter()
            Dim str1 As String = GetCriteria(deFromDate.DateTime, True), str2 As String = GetCriteria(deToDate.DateTime, False)
            If (Not String.IsNullOrEmpty(str1)) AndAlso (Not String.IsNullOrEmpty(str2)) Then
                pivotGrid.PrefilterCriteria = CriteriaOperator.Parse(str1 & " And " & str2)
            Else
                pivotGrid.PrefilterCriteria = CriteriaOperator.Parse(str1 & str2)
            End If
        End Sub
        Private Function GetCriteria(ByVal [date] As Date, ByVal isGreater As Boolean) As String
            If [date].Ticks = 0 Then
                Return ""
            End If
            Return String.Format("{0} {1} #{2}#", fieldOrderDate.Name,If(isGreater, ">=", "<="), Convert.ToString([date], CultureInfo.InvariantCulture))
        End Function
    End Class
End Namespace
