using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.Utils;
using DevExpress.XtraTab;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class PropertiesBase : TutorialControl {
        public PropertiesBase() {
            InitializeComponent();
            InitData();
            InitDemoGrid();
            treeView1.ExpandAll();
            RowsCreator.CreateRows(0, vGridControl3);
        }
        string[] aboutBinding = new string[] {
			"DataView obtained from the Cars.xml XML table via DataSet is used as a data source for this VerticalGrid.", 
			"This VerticalGrid uses the Contacts class inherited from ArrayList as a data source. Public properties of arraylist objects are used as grid rows.", 
			"This Grid creates rows at runtime and does not have any data source (unbound mode).", 
			"This sample uses the XML table included in the XtraVerticalGrid demo application for its data source."
		};
        DataView dataView;
        public override VGridControlBase ExportControl {
            get {
                if(tcMain.SelectedTabPage == tabPage1) return vGridControl1;
                if(tcMain.SelectedTabPage == tabPage5) return vGridControl2;
                if(tcMain.SelectedTabPage == tabPage7) return vGridControl3;
                if(tcMain.SelectedTabPage == tabPage8) return vGridControl4;
                return vGridControl1;
            }
        }

        #region Init

        private void PropertiesBase_Load(object sender, System.EventArgs e) {
            InitStyles();
            AdjustmentGrid();
        }

        protected virtual void InitStyles() { }
        protected virtual void AdjustmentGrid() {
            if(tcMain.SelectedTabPageIndex == -1) return;
            lbHint.Text = aboutBinding[tcMain.SelectedTabPageIndex];
        }
        protected virtual void InitAppearanceList(VGridControl vg) { }


        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Cars.xml", false);
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                dataView = dataSet.Tables[0].DefaultView;
                vGridControl1.DataSource = dataView;
            }
            vGridControl2.DataSource = new Contacts();
            repositoryItemLookUpEdit1.DataSource = new Products();
        }

        private void InitDemoGrid() {
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl4);
        }

        protected static void InitOptions(object options, DevExpress.XtraEditors.CheckedListBoxControl checkedListBox) {
            checkedListBox.Items.Clear();
            ArrayList arr = DevExpress.Utils.SetOptions.GetOptionNames(options);
            for(int i = 0; i < arr.Count; i++)
                checkedListBox.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    (arr[i], DevExpress.Utils.SetOptions.OptionValueByString(arr[i].ToString(), options)));
        }
        #endregion
        #region Editing
        private void tcMain_SelectedIndexChanged(object sender, TabPageChangedEventArgs e) {
            InitAppearanceList(CurrentGrid);
            CloseCustomizationForm();
            AdjustmentGrid();
            if(VertGridRibbonMenuManager != null)
                VertGridRibbonMenuManager.AllowExport(ExportControl);
        }

        private void CloseCustomizationForm() {
            vGridControl1.DestroyCustomization();
            vGridControl2.DestroyCustomization();
            vGridControl3.DestroyCustomization();
            vGridControl4.DestroyCustomization();
        }

        protected AppearanceObject GetAppearanceObjectByName(VGridControl vg, string name) {
            if(vg.Appearance == null) return null;
            else return vg.Appearance.GetAppearance(name);
        }

        private void treeView1_AfterExpand(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count > 0) {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 2;
            }
        }

        private void treeView1_AfterCollapse(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count > 0) {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            if(e.Node.Nodes.Count == 0) {
                foreach(TreeNode node in treeView1.Nodes[0].Nodes) {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                }
                e.Node.ImageIndex = 3;
                e.Node.SelectedImageIndex = 3;
                RowsCreator.CreateRows(e.Node.Index, vGridControl3);
            }
        }
        protected virtual bool ShowCustomization {
            get { return false; }
            set { }
        }
        #endregion
        #region VertGrid events
        private void vGridControl3_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e) {
            if(!e.Row.Tag.Equals(e.Row.Properties.Value)) {
                e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
            }
        }

        private void vGridControl_HideCustomizationForm(object sender, System.EventArgs e) {
            ShowCustomization = false;
        }
        #endregion
        #region CurrentGrid
        protected VGridControl GridByIndex(int index) {
            switch(index) {
                case 1:
                    return vGridControl2;
                case 2:
                    return vGridControl3;
                case 3:
                    return vGridControl4;
            }
            return vGridControl1;
        }

        protected VGridControl CurrentGrid {
            get { return GridByIndex(tcMain.SelectedTabPageIndex); }
        }
        #endregion

        protected int SelectedPageIndex { get { return tcMain.SelectedTabPageIndex; } }
        protected bool IsLayoutGrid { get { return CurrentGrid == vGridControl1; } }
        protected EditorRow EditorRowDescription { get { return rowDescription; } }
        protected EditorRow EditorRowAutomaticTransmission { get { return rowTransmiss_Automatic; } }
        protected void HideRows() {
            categoryRow3.Visible = false;
            categoryRow6.Visible = false;
        }
    }
}
