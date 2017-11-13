using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for OrderReports.
    /// </summary>
    public partial class OrderReports : TutorialControl {
        public OrderReports() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\OrderReports.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.OrderReports.xml";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        private void OrderReports_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("OrderReports");
            InitComboBox();
            rgReport.SelectedIndex = 0;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldOrderID.ImageIndex = 1;
            fieldSum.ImageIndex = 3;
        }

        void InitComboBox() {
            object[] values = fieldOrderID.GetUniqueValues();
            foreach(object obj in values)
                cbeOrder.Properties.Items.Add(obj);
            cbeOrder.SelectedIndex = 0;
        }

        protected override void DoShow() {
            SetCaption();
            OnSetDescription(ReportsDescriptions.OrderReportsDescriptions[rgReport.SelectedIndex]);
            base.DoShow();
        }
        //<rgReport>
        void SetReport() {
            DoShow();
            pivotGridControl1.BeginUpdate();
            try {
                fieldOrderID.FilterValues.Clear();
                pcOrder.Visible = rgReport.SelectedIndex == 1;
                pivotGridControl1.OptionsView.ShowRowGrandTotals = rgReport.SelectedIndex != 1;
                fieldOrderID.FilterValues.FilterType = rgReport.SelectedIndex == 1 ? PivotFilterType.Included : PivotFilterType.Excluded;
                DefaultBoolean parameter = (rgReport.SelectedIndex == 1) ? DefaultBoolean.False : DefaultBoolean.Default;
                fieldOrderID.Options.AllowFilter = fieldOrderID.Options.AllowSort = parameter;
                foreach(PivotGridField field in pivotGridControl1.Fields)
                    field.Area = PivotArea.FilterArea;
                switch(rgReport.SelectedIndex) {
                    case 0:
                    case 1:
                        fieldOrderID.Area = PivotArea.RowArea;
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldUnitPrice.Area = PivotArea.DataArea;
                        fieldQuantity.Area = PivotArea.DataArea;
                        fieldDiscount.Area = PivotArea.DataArea;
                        fieldSum.Area = PivotArea.DataArea;
                        if(rgReport.SelectedIndex == 1)
                            SetOrderFilter();
                        break;
                    case 2:
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldQuantity.Area = PivotArea.DataArea;
                        break;
                    case 3:
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldUnitPrice.Area = PivotArea.DataArea;
                        break;
                }
            } finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</rgReport>
        //<cbeOrder>
        void SetOrderFilter() {
            pivotGridControl1.BeginUpdate();
            try {
                fieldOrderID.FilterValues.Clear();
                fieldOrderID.FilterValues.Add(cbeOrder.SelectedItem);
            } finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</cbeOrder>

        private void rgReport_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetReport();
        }

        private void cbeOrder_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetOrderFilter();
        }

        void SetCaption() {
            if(rgReport.SelectedIndex > -1)
                OnSetCaption(rgReport.Properties.Items[rgReport.SelectedIndex].Description);
        }
        protected override void OnSetCaption(string fCaption) {
            Caption.Text = string.Format("{0}: {1}", TutorialName, fCaption);
        }
    }
}
