Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.PivotGrid.Internal
Imports System.Windows.Data
Imports System.Collections.Generic
Imports System.Collections
Imports DevExpress.Xpf.Bars
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class UnboundExpressions
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            cbSalesPerson.SelectedIndex = 0
        End Sub
        Private Sub pivotGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.BestFit(True, False)
            NamesController = CreateNamesController()
            teBonusName.Text = NamesController.GetNextDefaultName()
        End Sub
        Private Property NamesController() As NamesController
        Private Function CreateNamesController() As NamesController
            Dim controller As New NamesController("NewBonus")
            For Each field As PivotGridField In pivotGrid.Fields
                controller.RegisterAvailableName(field.FieldName)
                controller.RegisterAvailableName(field.Name)
                controller.RegisterAvailableName(field.ExpressionFieldName)
                controller.RegisterAvailableName(field.UnboundFieldName)
            Next field
            Return controller
        End Function
        Private Function GetNewInvisibleBonusField() As PivotGridField
            Dim newBonusField As New PivotGridField("", FieldArea.DataArea)
            newBonusField.ValueTemplate = CType(Resources("UnboundFieldTemplate"), DataTemplate)
            newBonusField.Name = NamesController.GetNextDefaultName()
   newBonusField.Caption = teBonusName.Text
            newBonusField.Visible = False
            newBonusField.UnboundType = FieldUnboundColumnType.Object
            newBonusField.UnboundExpression = beExpression.Text
            Return newBonusField
        End Function
        Private Sub beExpression_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
            pivotGrid.Fields.Add(newBonus)
            pivotGrid.ShowUnboundExpressionEditor(newBonus)
            beExpression.Text = newBonus.UnboundExpression
            pivotGrid.Fields.Remove(newBonus)
        End Sub
        Private Sub btnAddField_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
            newBonus.Visible = True
            pivotGrid.Fields.Add(newBonus)
            NamesController.RegisterAvailableName(newBonus.Name)
            teBonusName.Text = NamesController.GetNextDefaultName()
            beExpression.Text = String.Empty
        End Sub
        Private Sub teBonusName_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangingEventArgs)
            btnAddField.IsEnabled = Not String.IsNullOrEmpty(TryCast(e.NewValue, String))
        End Sub
        Private Sub pivotGrid_FieldUnboundExpressionChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
            If e.Field IsNot Nothing AndAlso (Not e.Field.Visible) AndAlso btnAddField.IsEnabled Then
                beExpression.Text = e.Field.UnboundExpression
            End If
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If TypeOf sender Is Control Then
                Dim fieldValueItem As FieldValueItem = TryCast(((TryCast(sender, Control)).DataContext), FieldValueItem)
                If fieldValueItem IsNot Nothing AndAlso fieldValueItem.Field IsNot Nothing Then
                    pivotGrid.ShowUnboundExpressionEditor(fieldValueItem.Field)
                End If
            End If
        End Sub
        Private Sub removeBonus_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            If TypeOf sender Is BarButtonItem Then
                Dim fieldValueItem As FieldValueItem = TryCast(((TryCast(sender, BarButtonItem)).Tag), FieldValueItem)
                If fieldValueItem IsNot Nothing AndAlso fieldValueItem.Field IsNot Nothing Then
                    NamesController.UnRegisterAvailableName(fieldValueItem.Field.FieldName)
                    pivotGrid.Fields.Remove(fieldValueItem.Field)
                End If
            End If
        End Sub
    End Class

    Public Class FieldValueItemToBooleanConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim item As FieldValueItem = DirectCast(value, FieldValueItem)
            Return item.Field IsNot Nothing AndAlso item.Field.Area = FieldArea.DataArea AndAlso item.Field.UnboundType <> FieldUnboundColumnType.Bound
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class

    Public Class NamesController
        Private ReadOnly DefaultName As String
        Public Sub New(ByVal defaultName As String)
            Me.DefaultName = defaultName
            AvailableNames = New List(Of String)()
        End Sub
        Private Property AvailableNames() As List(Of String)

        Public Function GetNextDefaultName() As String
            Dim i As Integer = 0
            Dim name As String
            Do
                name = DefaultName & i
                i += 1
            Loop While AvailableNames.Contains(name)
            Return name
        End Function

        Public Sub RegisterAvailableName(ByVal name As String)
            AvailableNames.Add(name)
        End Sub

        Public Sub UnRegisterAvailableName(ByVal name As String)
            AvailableNames.RemoveAll(Function(availableName As String) name = availableName)
        End Sub
    End Class
End Namespace
