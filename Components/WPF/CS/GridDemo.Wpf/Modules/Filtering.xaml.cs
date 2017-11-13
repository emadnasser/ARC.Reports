using System;
using DevExpress.Data.Filtering;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using DevExpress.XtraExport.Helpers;
using DevExpress.Xpf.Grid.Printing;
using System.Collections.Generic;

namespace GridDemo {
    [CodeFile("ModuleResources/FilteringTemplates(.SL).xaml")]
    [CodeFile("ModuleResources/FilteringClasses.(cs)")]
    public partial class Filtering : GridDemoModule {
        public Filtering() {
            InitializeComponent();

            grid.FilterCriteria = new OperandProperty("City") == "Bergamo";
            grid.FilterCriteria = new OperandProperty("UnboundOrderDate") >= new DateTime(DateTime.Today.Year, 1, 1);
            viewsListBox.EditValueChanging += ViewsListBox_EditValueChanging;
        }

        private void ViewsListBox_EditValueChanging(object sender, EditValueChangingEventArgs e) {
            grid.View.IncrementalSearchEnd();
        }

        protected override DataViewBase GetExportView() {
            return null;
        }
        protected override IGridViewFactory<ColumnWrapper, RowBaseWrapper> GetReportView() {
            return null;
        }
    }
}
