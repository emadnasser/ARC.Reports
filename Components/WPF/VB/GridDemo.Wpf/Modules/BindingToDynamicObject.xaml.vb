Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Dynamic
Imports System.Collections.ObjectModel
Imports DevExpress.Data
Imports System.ComponentModel
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Mvvm.POCO
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/BindingToDynamicObjectClasses.(cs)")>
    Partial Public Class BindingToDynamicObject
        Inherits GridDemoModule

        Private list As New DynamicBindingList()
        Public Sub New()
            InitializeComponent()
            optionsPanel.DataContext = ViewModelSource.Create(Of NewColumnModel)()
            For i As Integer = 0 To 49
                Dim dictionary As New DynamicDictionary()
                dictionary.SetValue("Id", i)
                dictionary.SetValue("FirstName", DataGenerator.GetFirstName())
                dictionary.SetValue("LastName", DataGenerator.GetLastName())
                list.Add(dictionary)
            Next i
            grid.ItemsSource = list
        End Sub
        Private Sub CreateNewColBtn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CreateNewColumn()
            FieldNameBox.Text = ""
        End Sub

        Private Sub CreateNewColumn()
            Dim fieldName As String = FieldNameBox.Text
            For i As Integer = 0 To list.Count - 1
                CType(list(i), DynamicDictionary).SetValue(fieldName, GetDefaultValue())
            Next i
            Dim column As New GridColumn()
            column.Binding = New Binding("RowData.Row." & fieldName) With {.Mode = BindingMode.TwoWay}
            column.Header = fieldName
            grid.Columns.Add(column)
        End Sub

        Private Function GetDefaultValue() As Object
            Select Case TypeBox.SelectedIndex
                Case 0
                    Return (CInt((DefaultValueBoxSpin.Value)))
                Case 1
                    Return DefaultValueBoxText.Text
                Case 2
                    Return DefaultValueBoxDate.DateTime
                Case 3
                    Return DefaultValueBoxCheck.IsChecked
            End Select
            Return Nothing
        End Function

        Private Function GetNewColunUnboundType() As UnboundColumnType
            Select Case TypeBox.SelectedIndex
                Case 0
                    Return UnboundColumnType.Integer
                Case 1
                    Return UnboundColumnType.String
                Case 2
                    Return UnboundColumnType.DateTime
                Case 3
                    Return UnboundColumnType.Boolean
            End Select
            Return UnboundColumnType.Object
        End Function

        Private Sub FieldNameBox_Validate(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.ValidationEventArgs)
            Dim value As Object = e.Value
            If value IsNot Nothing Then
                If Not IsValidFieldName(value.ToString()) Then
                    e.ErrorContent = "A column bound to the same field in the data source already exists."
                    e.IsValid = False
                    Return
                End If
            End If
        End Sub
        Private Function IsValidFieldName(ByVal name As String) As Boolean
            If grid Is Nothing Then
                Return False
            End If
            For Each column As GridColumn In grid.Columns
                Dim path As String = CType(column.Binding, Binding).Path.Path
                path = path.Substring(12)
                If path = name Then
                    Return False
                End If
            Next column
            Return True
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
