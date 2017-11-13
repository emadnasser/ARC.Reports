using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.Diagram.Core;
using System.Data.OleDb;
using DevExpress.Diagram.Demos;
using System.Collections.ObjectModel;
using DevExpress.Utils;
using DevExpress.Data.Filtering;

namespace DevExpress.XtraDiagram.Demos {
    public partial class ProductFlowDiagramModule : DiagramTutorialControl {
        readonly DiagramItemStyleId[] styles = DiagramShapeStyleId.Styles.ToArray();
        readonly ProductFlowInfo info;


        public ProductFlowDiagramModule() {
            InitializeComponent();
            info = OrderDataGenerator.GenerateProductFlowInfo();
            diagramDataBindingController1.BeginInit();
            diagramDataBindingController1.DataSource = info.Items;
            diagramDataBindingController1.ConnectorsSource = info.ProductFlows;
            diagramDataBindingController1.EndInit();
            gridControl.DataSource = info.Orders;
            Diagram.SelectionChanged += OnDiagramSelectionChanged;
            Diagram.SelectItem(Diagram.Items.First());
        }
        void OnDiagramSelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            var selectedDiagramItem = Diagram.PrimarySelection;
            gridView.ClearGrouping();
            gridView.ActiveFilterCriteria = null;

            if(selectedDiagramItem == null)
                return;

            var customer = selectedDiagramItem.DataContext as CustomerData;
            if(customer != null) {
                gridView.ActiveFilterCriteria = new BinaryOperator("Customer.Name", customer.Name, BinaryOperatorType.Equal);
                gridView.Columns["Category.Name"].Group();
                gridView.ExpandAllGroups();
            }

            var category = selectedDiagramItem.DataContext as CategoryData;
            if(category != null) {
                gridView.ActiveFilterCriteria = new BinaryOperator("Category.Name", category.Name, BinaryOperatorType.Equal);
                gridView.Columns["Customer.Name"].Group();
                gridView.ExpandAllGroups();
            }

            var connector = selectedDiagramItem.DataContext as ProductFlowData;
            if(connector != null) {
                var productFilter = new BinaryOperator("Category.Name", connector.Category.Name, BinaryOperatorType.Equal);
                var customerFilter = new BinaryOperator("Customer.Name", connector.Customer.Name, BinaryOperatorType.Equal);
                gridView.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.And, productFilter, customerFilter);
            }
        }
        private void diagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e) {
            var templateName = (e.DataObject is CustomerData) ? "CustomerTemplate" : "CategoryTemplate";
            e.Item = e.CreateItemFromTemplate(templateName);
        }

        private void diagramDataBindingController1_CustomLayoutItems(object sender, DiagramCustomLayoutItemsEventArgs e) {
            ArrangeItemsInLine<CategoryData>(e.Items, new PointFloat(600, 50), new Size(150, 105), 20);
            ArrangeItemsInLine<CustomerData>(e.Items, new PointFloat(50, 100), new Size(150, 105), 20);
            foreach(var item in e.Items) {
                var customer = item.DataContext as CustomerData;
                if(customer != null) {
                    item.ThemeStyleId = styles[Array.IndexOf(info.Customers, customer)];
                }
            }
            foreach(var connector in e.Connectors) {
                var connectorData = (ProductFlowData)connector.DataContext;
                connector.ThemeStyleId = styles[Array.IndexOf(info.Customers, connectorData.Customer)];
            }
            e.Handled = true;
        }
        void ArrangeItemsInLine<TDataContext>(IEnumerable<DiagramItem> items, PointFloat startPosition, Size itemSize, int margin) {
            PointFloat position = startPosition;
            foreach(var diagramItem in items.Where(x => x.DataContext is TDataContext)) {
                diagramItem.Position = position;
                position.Offset(0, itemSize.Height + margin);
            }
        }

        private void diagramDataBindingController1_UpdateConnector(object sender, DiagramUpdateConnectorEventArgs e) {
            var connectorData = (ProductFlowData)e.DataObject;
            e.Connector.Appearance.BorderSize = (int)connectorData.Weight;
        }
    }
}
