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


namespace DevExpress.XtraTreeList.Demos {
    public partial class NodesFiltering : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList ExportControl { get { return treeList1; } }
        public NodesFiltering() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\NodesFiltering.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.NodesFiltering.xml";
            InitData();
            InitEditors();
            InitFilter();
            treeList1.Columns["JobTitle"].AllNodesSummary = true;
            treeList1.Columns["JobTitle"].SummaryFooter = SummaryItemType.Count;
            treeList1.Columns["JobTitle"].OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList;
            treeList1.OptionsView.ShowSummaryFooter = true;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            treeList1.ShowFindPanel();
        }
        private void InitEditors() {
            ceAllowFilter.Checked = treeList1.OptionsBehavior.EnableFiltering;
            ceAutoFilterRow.Checked = treeList1.OptionsView.ShowAutoFilterRow;
            ceFilterEditor.Checked = treeList1.OptionsFilter.AllowFilterEditor;
            ceFilterList.Checked = treeList1.OptionsFilter.AllowMRUFilterList;
            ceAllowFindPanel.Checked = treeList1.OptionsFind.AllowFindPanel;
            ceColumnFilterList.Checked = treeList1.OptionsFilter.AllowColumnMRUFilterList;
            cbFilterMode.Properties.Items.AddEnum(typeof(FilterMode));
            cbFilterMode.EditValue = treeList1.OptionsFilter.FilterMode;
            InitEnabled();
        }
        private void InitEnabled() {
            ceFilterEditor.Enabled = ceFilterList.Enabled = ceAutoFilterRow.Enabled = ceColumnFilterList.Enabled = ceAllowFindPanel.Enabled = cbFilterMode.Enabled = labelControl.Enabled = ceAllowFilter.Checked;
            btnFindPanelOptions.Enabled = ceAllowFilter.Checked && ceAllowFindPanel.Checked;
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
        //<treeList1>
        private void InitFilter() {
            CriteriaOperator opLeftDate = new BinaryOperator("BirthDate", new DateTime(1957, 5, 1), BinaryOperatorType.GreaterOrEqual);
            CriteriaOperator opRightDate = new BinaryOperator("BirthDate", new DateTime(1980, 10, 1), BinaryOperatorType.LessOrEqual);
            CriteriaOperator opDate = new GroupOperator(GroupOperatorType.And, opLeftDate, opRightDate);
            BinaryOperator opCountry = new BinaryOperator("StateProvinceName", "California", BinaryOperatorType.Equal);
            treeList1.MRUFilters.Add(new TreeListFilterInfo(opCountry));
            treeList1.MRUFilters.Add(new TreeListFilterInfo(opDate));
            treeList1.Columns["StateProvinceName"].MRUFilters.Add(new TreeListFilterInfo(opCountry));
            treeList1.ActiveFilterCriteria = treeList1.MRUFilters[1].FilterCriteria;
        }
        //</treeList1>

        //<ceAllowFilter>
        private void ceAllowFilter_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsBehavior.EnableFiltering = ceAllowFilter.Checked;
            if(!treeList1.OptionsBehavior.EnableFiltering)
                treeList1.HideFindPanel();
            InitEnabled();
        }
        //</ceAllowFilter>
        //<ceFilterEditor>
        private void ceFilterEditor_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked;
        }
        //</ceFilterEditor>
        //<ceFilterList>
        private void ceFilterList_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked;
        }
        //</ceFilterList>
        //<ceColumnFilterList>
        private void ceColumnFilterList_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked;
        }
        //</ceColumnFilterList>
        //<ceAutoFilterRow>
        private void ceAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            treeList1.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked;
        }
        //</ceAutoFilterRow>
        string currentGroupName;
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            string[] groupNames = new string[] { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" };
            currentGroupName =  (string)e.Node.GetValue("GroupName");
            e.NodeImageIndex = Array.FindIndex(groupNames, new Predicate<string>(IsCurrentGroupName));
        }
        private bool IsCurrentGroupName(string groupName) { return currentGroupName.Contains(groupName); }

        //<cbFilterMode>
        private void cbFilterMode_SelectedIndexChanged(object sender, EventArgs e) {
            treeList1.OptionsFilter.FilterMode = (FilterMode)cbFilterMode.EditValue;
        }
        //</cbFilterMode>
        //<ceAllowFindPanel>
        private void ceFindPanel_CheckedChanged(object sender, EventArgs e) {
            treeList1.OptionsFind.AllowFindPanel = ceAllowFindPanel.Checked;
            btnFindPanelOptions.Enabled = treeList1.OptionsFind.AllowFindPanel;
            if(treeList1.OptionsFind.AllowFindPanel)
                treeList1.ShowFindPanel();
            else
                treeList1.HideFindPanel();
        }
        //</ceAllowFindPanel>
        private void btnFindPanelOptions_Click(object sender, EventArgs e) {
            FindPanelOptions opt = new FindPanelOptions(treeList1);
            opt.ShowDialog();
        }
    }
}

