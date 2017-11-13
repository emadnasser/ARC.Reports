using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridUnboundModeViaCollection.
    /// </summary>
    public partial class GridUnboundModeViaCollection : TutorialControl {
        public GridUnboundModeViaCollection() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        //<gridControl1>
        private void GridUnboundModeViaCollection_Load(object sender, System.EventArgs e) {
            InitData();
        }

        private void InitData() {
            GridUnboundModeViaCollectionRecord[] records = new GridUnboundModeViaCollectionRecord[5];
            records[0] = new GridUnboundModeViaCollectionRecord(1, "Chai", "Beverages", true, 18);
            records[1] = new GridUnboundModeViaCollectionRecord(2, "Aniseed Syrup", "Condiments", false, 10);
            records[2] = new GridUnboundModeViaCollectionRecord(3, "Ikura", "Seafood", false, 30.5);
            records[3] = new GridUnboundModeViaCollectionRecord(4, "Queso Cabrales", "Dairy Products", true, 21);
            records[4] = new GridUnboundModeViaCollectionRecord(5, "Carnarvon Tigers", "Seafood", true, 62.5);
            gridControl1.DataSource = records;
        }
        //</gridControl1>
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
