using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for GridUnboundMasterViewDynamic.
    /// </summary>
    public partial class GridUnboundMasterViewDynamic : TutorialControl {
        public GridUnboundMasterViewDynamic() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private object[,] relations = {{ 
			"Products", "Customers", "Shippers"}, { 
			null, null, null}, {
			"Employees", null, null}};

        private void GridUnboundMasterViewDynamic_Load(object sender, System.EventArgs e) {
            InitData();
            ShowMasterDetailRows();
        }
        private void InitData() {
            ArrayList records = new ArrayList();
            records.Add(new GridUnboundMasterViewDynamicRecord("first"));
            records.Add(new GridUnboundMasterViewDynamicRecord("second"));
            records.Add(new GridUnboundMasterViewDynamicRecord("third"));

            gridControl1.DataSource = records;
        }
        private void ShowMasterDetailRows() {
            for(int i = 0; i < gridView1.RowCount; i++)
                gridView1.SetMasterRowExpanded(i, true);

            DevExpress.XtraGrid.Views.Grid.GridView gv =
                gridView1.GetVisibleDetailView(2) as DevExpress.XtraGrid.Views.Grid.GridView;
            if(gv != null) gv.SetMasterRowExpanded(0, true);
        }



        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e) {
            e.IsEmpty = IsRelationEmpty(GetRelationByRowHandle(e.RowHandle), e.RelationIndex);
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            int relation = GetRelationByRowHandle(e.RowHandle);
            if(IsRelationEmpty(relation, e.RelationIndex)) return;
            string s = relations[relation, e.RelationIndex].ToString();
            switch(s) {
                case "Products":
                    e.ChildList = new ChildRecordsProductsDynamic();
                    break;
                case "Customers":
                    e.ChildList = new ChildRecordsCustomersDynamic();
                    break;
                case "Shippers":
                    e.ChildList = new ChildRecordsShippersDynamic();
                    break;
                case "Employees":
                    e.ChildList = new GridUnboundMasterViewDynamicRecords();
                    break;
            }
        }

        // The following MasterRowGetLevelDefaultView event handler is not required and can be commented out.
        // The code is intended to show how pattern views can be retrieved from the LevelTree tree.
        private void gridView1_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e) {
            int relation = GetRelationByRowHandle(e.RowHandle);
            if(IsRelationEmpty(relation, e.RelationIndex)) return;
            string s = relations[relation, e.RelationIndex].ToString();
            switch(s) {
                case "Products":
                    e.DefaultView = gridControl1.LevelTree.Nodes["Products"].LevelTemplate;
                    break;
                case "Customers":
                    e.DefaultView = gridControl1.LevelTree.Nodes["Customers"].LevelTemplate;
                    break;
                case "Employees":
                    e.DefaultView = gridControl1.LevelTree.Nodes["Employees"].LevelTemplate;
                    break;
            }
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 3; //max relation count
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e) {
            int relation = GetRelationByRowHandle(e.RowHandle);
            if(IsRelationEmpty(relation, e.RelationIndex)) e.RelationName = "";
            else e.RelationName = relations[relation, e.RelationIndex].ToString();
        }

        bool IsRelationEmpty(int relation, int relationIndex) {
            return relation == GridControl.InvalidRowHandle || relations[relation, relationIndex] == null;
        }

        int GetRelationByRowHandle(int rowHandle) {
            GridUnboundMasterViewDynamicRecord record = gridView1.GetRow(rowHandle) as GridUnboundMasterViewDynamicRecord;
            if(record != null) {
                switch(record.Name) {
                    case "first": return 0;
                    case "second": return 1;
                    case "third": return 2;
                }
            }
            return GridControl.InvalidRowHandle;
        }
    }
}
