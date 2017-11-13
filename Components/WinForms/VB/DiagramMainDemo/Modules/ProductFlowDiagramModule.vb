Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraDiagram.Demos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Diagram.Core
Imports System.Data.OleDb
Imports DevExpress.Diagram.Demos
Imports System.Collections.ObjectModel
Imports DevExpress.Utils
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class ProductFlowDiagramModule
        Inherits DiagramTutorialControl

        Private ReadOnly styles() As DiagramItemStyleId = DiagramShapeStyleId.Styles.ToArray()
        Private ReadOnly info As ProductFlowInfo


        Public Sub New()
            InitializeComponent()
            info = OrderDataGenerator.GenerateProductFlowInfo()
            diagramDataBindingController1.BeginInit()
            diagramDataBindingController1.DataSource = info.Items
            diagramDataBindingController1.ConnectorsSource = info.ProductFlows
            diagramDataBindingController1.EndInit()
            gridControl.DataSource = info.Orders
            AddHandler Diagram.SelectionChanged, AddressOf OnDiagramSelectionChanged
            Diagram.SelectItem(Diagram.Items.First())
        End Sub
        Private Sub OnDiagramSelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            Dim selectedDiagramItem = Diagram.PrimarySelection
            gridView.ClearGrouping()
            gridView.ActiveFilterCriteria = Nothing

            If selectedDiagramItem Is Nothing Then
                Return
            End If

            Dim customer = TryCast(selectedDiagramItem.DataContext, CustomerData)
            If customer IsNot Nothing Then
                gridView.ActiveFilterCriteria = New BinaryOperator("Customer.Name", customer.Name, BinaryOperatorType.Equal)
                gridView.Columns("Category.Name").Group()
                gridView.ExpandAllGroups()
            End If

            Dim category = TryCast(selectedDiagramItem.DataContext, CategoryData)
            If category IsNot Nothing Then
                gridView.ActiveFilterCriteria = New BinaryOperator("Category.Name", category.Name, BinaryOperatorType.Equal)
                gridView.Columns("Customer.Name").Group()
                gridView.ExpandAllGroups()
            End If

            Dim connector = TryCast(selectedDiagramItem.DataContext, ProductFlowData)
            If connector IsNot Nothing Then
                Dim productFilter = New BinaryOperator("Category.Name", connector.Category.Name, BinaryOperatorType.Equal)
                Dim customerFilter = New BinaryOperator("Customer.Name", connector.Customer.Name, BinaryOperatorType.Equal)
                gridView.ActiveFilterCriteria = New GroupOperator(GroupOperatorType.And, productFilter, customerFilter)
            End If
        End Sub
        Private Sub diagramDataBindingController1_GenerateItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs) Handles diagramDataBindingController1.GenerateItem
            Dim templateName = If(TypeOf e.DataObject Is CustomerData, "CustomerTemplate", "CategoryTemplate")
            e.Item = e.CreateItemFromTemplate(templateName)
        End Sub

        Private Sub diagramDataBindingController1_CustomLayoutItems(ByVal sender As Object, ByVal e As DiagramCustomLayoutItemsEventArgs) Handles diagramDataBindingController1.CustomLayoutItems
            ArrangeItemsInLine(Of CategoryData)(e.Items, New PointFloat(600, 50), New Size(150, 105), 20)
            ArrangeItemsInLine(Of CustomerData)(e.Items, New PointFloat(50, 100), New Size(150, 105), 20)
            For Each item In e.Items
                Dim customer = TryCast(item.DataContext, CustomerData)
                If customer IsNot Nothing Then
                    item.ThemeStyleId = styles(Array.IndexOf(info.Customers, customer))
                End If
            Next item
            For Each connector In e.Connectors
                Dim connectorData = CType(connector.DataContext, ProductFlowData)
                connector.ThemeStyleId = styles(Array.IndexOf(info.Customers, connectorData.Customer))
            Next connector
            e.Handled = True
        End Sub
        Private Sub ArrangeItemsInLine(Of TDataContext)(ByVal items As IEnumerable(Of DiagramItem), ByVal startPosition As PointFloat, ByVal itemSize As Size, ByVal margin As Integer)
            Dim position As PointFloat = startPosition
            For Each diagramItem In items.Where(Function(x) TypeOf x.DataContext Is TDataContext)
                diagramItem.Position = position
                position.Offset(0, itemSize.Height + margin)
            Next diagramItem
        End Sub

        Private Sub diagramDataBindingController1_UpdateConnector(ByVal sender As Object, ByVal e As DiagramUpdateConnectorEventArgs) Handles diagramDataBindingController1.UpdateConnector
            Dim connectorData = CType(e.DataObject, ProductFlowData)
            e.Connector.Appearance.BorderSize = CInt((connectorData.Weight))
        End Sub
    End Class
End Namespace
