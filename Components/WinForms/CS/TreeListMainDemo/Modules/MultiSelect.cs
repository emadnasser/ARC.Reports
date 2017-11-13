using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;


namespace DevExpress.XtraTreeList.Demos {
    public partial class MultiSelect : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList ExportControl { get { return treeList1; } }
        public MultiSelect() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\MultiSelect.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.MultiSelect.xml";
            InitEditors();
            InitData();
            InitSelection();
        }
        private void InitSelection() {
            treeList1.ForceInitialize();
            treeList1.SelectCells(treeList1.Nodes[0].Nodes[0].Nodes[3], treeList1.VisibleColumns[1], treeList1.Nodes[0].Nodes[3] , treeList1.VisibleColumns[3]);
            treeList1.SelectCells(treeList1.Nodes[0].Nodes[0].Nodes[3], treeList1.VisibleColumns[6], treeList1.Nodes[0].Nodes[3], treeList1.VisibleColumns[6]);
        }
        private void InitEditors() {
            ceAllowMultiSelect.Checked = treeList1.OptionsSelection.MultiSelect;
            cbMultiSelectMode.Properties.Items.AddEnum(typeof(TreeListMultiSelectMode));
            cbMultiSelectMode.EditValue = treeList1.OptionsSelection.MultiSelectMode;
            InitEnabled();         
        }
        private void InitEnabled() {
            cbMultiSelectMode.Enabled = labelControl.Enabled = btnShowSelectedValues.Enabled = ceAllowMultiSelect.Checked;
        }
        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\EmployeesGroups.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.ForceInitialize();
                treeList1.ExpandAll();
                treeList1.BestFitColumns();
            }
        }
        string currentGroupName;
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            string[] groupNames = new string[] { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" };
            currentGroupName =  (string)e.Node.GetValue("GroupName");
            e.NodeImageIndex = Array.FindIndex(groupNames, new Predicate<string>(IsCurrentGroupName));
        }
        private bool IsCurrentGroupName(string groupName) { return currentGroupName.Contains(groupName); }
        private void cbMultiSelectMode_SelectedIndexChanged(object sender, EventArgs e) {
            treeList1.OptionsSelection.MultiSelectMode = (TreeListMultiSelectMode)cbMultiSelectMode.EditValue;
        }
        private void ceAllowMultiSelect_CheckedChanged(object sender, EventArgs e) {
            treeList1.OptionsSelection.MultiSelect = ceAllowMultiSelect.Checked;
            InitEnabled();  
        }
        private void btnShowSelectedValues_Click(object sender, EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectionString(treeList1), treeList1.OptionsSelection.MultiSelectMode == TreeListMultiSelectMode.CellSelect ? "Selected Cells" : "Selected Rows");
        }
        string GetSelectionString(TreeList treeList) {
            string result = "";
            foreach(TreeListNode node in treeList.Selection) {
                if(result != "") result += Environment.NewLine;
                result += string.Format("#{0}: {1} {2}", treeList.GetVisibleIndexByNode(node), node.GetDisplayText("FirstName"), node.GetDisplayText("LastName"));
                if(treeList.OptionsSelection.MultiSelectMode == TreeListMultiSelectMode.CellSelect) {
                    foreach(TreeListColumn cell in treeList.GetSelectedCells(node)) {
                        result += Environment.NewLine + "   " + string.Format("{0}: {1}", cell.FieldName, node.GetDisplayText(cell));
                    }
                }
            }
            return result;
        }
    }
}

