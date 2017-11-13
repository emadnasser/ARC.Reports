using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;
using DevExpress.XtraTreeList.ViewInfo;

namespace DevExpress.XtraTreeList.Demos {
    public partial class LookUp : TutorialControl {
        RepositoryItemTreeListLookUpEdit lookUpProperties;
        TreeList treeList;
        public LookUp() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\TreeListMainDemo\\Modules\\LookUp.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraTreeList.Demos.CodeInfo.LookUp.xml";
            InitProjectsData();
            InitSpaceObjectsData();
            InitProperties();
            CreateTimer();
            //<treeList1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            ~Assign a TreeListLookUpEdit control as an in-place editor to the Owner column:
            colOwner.ColumnEdit = repositoryItemTreeListLookUpEdit1;
            ~Set key fields to create a data hierarchy:
            repositoryItemTreeListLookUpEdit1.TreeList.KeyFieldName = "ID";
            repositoryItemTreeListLookUpEdit1.TreeList.ParentFieldName = "ParentID";
            */
            //</treeList1>
        }
        protected override void OnTick() {
            if(DemosInfo.CurrentModule == this) {
                treeListLookUpEdit1.MenuManager = RibbonMenuManager.Manager;
                treeListLookUpEdit1.ShowPopup();
            }
            base.OnTick();
        }
        bool updateValues = false;
        private void InitProperties() {
            this.lookUpProperties = treeListLookUpEdit1.Properties;
            this.treeList = treeListLookUpEdit1TreeList;
            updateValues = true;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle;
            foreach(TextEditStyles style in Enum.GetValues(typeof(TextEditStyles)))
                icbTextEditStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<TextEditStyles>.GetTitle(style), style, -1));
            ceAutoComplete.Checked = lookUpProperties.AutoComplete;
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup;
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable;
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter;
            ceShowAutoFilterRow.Checked = treeList.OptionsView.ShowAutoFilterRow;
            ceShowColumnHeaders.Checked = treeList.OptionsView.ShowColumns;
            ceShowIndicator.Checked = treeList.OptionsView.ShowIndicator;
            ceEnableAppearanceEvenRow.Checked = treeList.OptionsView.EnableAppearanceEvenRow;
            ceEnableAppearanceOddRow.Checked = treeList.OptionsView.EnableAppearanceOddRow;
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter;
            updateValues = false;
        }

        //<treeList1>
        private void InitProjectsData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\EmployeesGroups.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                dataSet.Tables[0].Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");

                repositoryItemTreeListLookUpEdit1.DataSource = dataSet.Tables[0].DefaultView;
                repositoryItemTreeListLookUpEdit1.DisplayMember = "FullName";
                repositoryItemTreeListLookUpEdit1.ValueMember = "Id";

                treeList1.ExpandAll();
            }
        }
        //</treeList1>

        //<treeListLookUpEdit1>
        DataTable spaceObjectsTable;
        private void InitSpaceObjectsData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\SpaceObjects.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                spaceObjectsTable = dataSet.Tables[0];
                spaceObjectsTable.PrimaryKey = new DataColumn[] { spaceObjectsTable.Columns["ObjectId"] };

                treeListLookUpEdit1.Properties.TreeList.KeyFieldName = "ObjectId";
                treeListLookUpEdit1.Properties.TreeList.ParentFieldName = "ParentId";

                treeListLookUpEdit1.Properties.DataSource = spaceObjectsTable;
                treeListLookUpEdit1.Properties.DisplayMember = "Name";
                treeListLookUpEdit1.Properties.ValueMember = "ObjectId";

                dataNavigator1.DataSource = spaceObjectsTable;
                treeListLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", spaceObjectsTable, "ObjectId", false, DataSourceUpdateMode.Never));
            }
        }

        void treeListLookUpEdit1_EditValueChanged(object sender, EventArgs e) {
            object editvalue = treeListLookUpEdit1.EditValue;
            if(editvalue == null || editvalue.GetType() != typeof(int)) return;
            int position = spaceObjectsTable.Rows.IndexOf(spaceObjectsTable.Rows.Find((int)editvalue));
            if(position > -1)
                dataNavigator1.Position = position;
        }
        //</treeListLookUpEdit1>

        string currentGroupName;
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            string[] groupNames = new string[] { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" };
            currentGroupName = (string)e.Node.GetValue("GroupName");
            e.NodeImageIndex = Array.FindIndex(groupNames, new Predicate<string>(IsCurrentGroupName));
        }
        private bool IsCurrentGroupName(string groupName) { return currentGroupName.Contains(groupName); }

        //<icbTextEditStyle>
        private void icbTextEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.TextEditStyle = (TextEditStyles)icbTextEditStyle.EditValue;
        }
        //</icbTextEditStyle>
        //<ceAutoComplete>
        private void ceAutoComplete_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.AutoComplete = ceAutoComplete.Checked;
        }
        //</ceAutoComplete>
        //<ceImmediatePopup>
        private void ceImmediatePopup_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked;
        }
        //</ceImmediatePopup>
        //<cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked;
        }
        //</cePopupSizeable>
        //<ceShowPopupFooter>
        private void ceShowPopupFooter_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked;
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter;
        }
        //</ceShowPopupFooter>
        //<ceShowAutoFilterRow>
        private void ceShowAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            treeList.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked;
        }
        //</ceShowAutoFilterRow>
        //<ceShowColumnHeaders>
        private void ceShowColumnHeaders_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            treeList.OptionsView.ShowColumns = ceShowColumnHeaders.Checked;
        }
        //</ceShowColumnHeaders>
        //<ceShowIndicator>
        private void ceShowIndicator_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            treeList.OptionsView.ShowIndicator = ceShowIndicator.Checked;
        }
        //</ceShowIndicator>
        //<ceEnableAppearanceEvenRow>
        private void ceEnableAppearanceEvenRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            treeList.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked;
        }
        //</ceEnableAppearanceEvenRow>
        //<ceEnableAppearanceOddRow>
        private void ceEnableAppearanceOddRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            treeList.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked;
        }
        //</ceEnableAppearanceOddRow>

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.SelectedControl is TreeList) {
                TreeList tree = (TreeList)e.SelectedControl;
                TreeListHitInfo hit = tree.CalcHitInfo(e.ControlMousePosition);
                if(hit.HitInfoType == HitInfoType.Cell) {
                    string tooltip;
                    if(hit.Column == tree.Columns["Name"] || hit.Column == tree.Columns["TypeOfObject"])
                        tooltip = string.Format("{0}", hit.Column.Caption);
                    else if(hit.Column == tree.Columns["ImageData"])
                        tooltip = "Image: Courtesy NASA/JPL-Caltec";
                    else
                        tooltip = string.Format("{0} by Earth", hit.Column.Caption);
                    e.Info = new DevExpress.Utils.ToolTipControlInfo(new TreeListCellToolTipInfo(hit.Node, hit.Column, null), tooltip);
                }
            }
        }
    }
}
