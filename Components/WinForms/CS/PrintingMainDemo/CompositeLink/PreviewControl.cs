using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;

namespace XtraPrintingDemos.CompositeLink {
    public partial class PreviewControl : XtraPrintingDemos.PreviewControl {
        public PreviewControl() {
            InitializeComponent();
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
        }
        protected override void CreateDocumentCore() {
            printingSystem.Graph.PageUnit = GraphicsUnit.Pixel;
            compositeLink.CreateDocument();
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToWholePage);
        }
        private void gridView1_MasterRowExpandedCollapsed(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e) {
            CreateDocument();
        }
    }
}
