using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.Data;

namespace XtraPrintingDemos.XtraGrid {
    public partial class PreviewControl : XtraPrintingDemos.PreviewControl {
        public PreviewControl() {
            InitializeComponent();
            categoriesTableAdapter.Fill(nwindDataSet.Categories);
            productsTableAdapter.Fill(nwindDataSet.Products);
            gridView1.Columns[nwindDataSet.Categories.CategoryNameColumn.ColumnName].SortOrder = ColumnSortOrder.Ascending;
            this.gridView1.EndSorting += new System.EventHandler(this.gridView_EndSorting);
        }
        protected override void CreateDocumentCore() {
            printingSystem.Graph.PageUnit = GraphicsUnit.Pixel;
            gridLink.CreateDocument();
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage);
        }
        private void gridView_EndSorting(object sender, EventArgs e) {
            CreateDocument();
        }
    }
}
