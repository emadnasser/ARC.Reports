using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.FilterEditor;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for FilterControl.
	/// </summary>
	public partial class FilterControl : TutorialControl {
		public FilterControl() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\FilterControl.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.FilterControl.xml";
			// TODO: Add any initialization after the InitForm call

		}
        bool initProperties = false;
		private void FilterControl_Load(object sender, System.EventArgs e) {
			filterControl1.MenuManager = gridControl1.MenuManager;
			InitNWindData();
			gridColumnProduct.FilterInfo = new ColumnFilterInfo("[ProductID] between ('Alice Munton', 'Iqura')");
			gridColumnDiscount.FilterInfo = new ColumnFilterInfo("[Discount] >= 0.05");
			InitOptions();
			InitCustomFilterControl();
			gridColumnImplemented.FilterInfo = new ColumnFilterInfo("[Implemented] >= 50");
			gridColumnSuspended.FilterInfo = new ColumnFilterInfo("[Suspended] = False");
			ResetCustomFilter();
            //<filterControl1>
            /*
            ~Note: the following code is set at design-time and is listed here for educational purposes only.
            filterControl1.SourceControl = gridControl1;
            */
            //</filterControl1>
		}

		
		void InitOptions() {
			initProperties = true;
			ceEmptyValue.Color = filterControl1.AppearanceEmptyValueColor;
			ceFieldName.Color = filterControl1.AppearanceFieldNameColor;
			ceGroupOperator.Color = filterControl1.AppearanceGroupOperatorColor;
			ceOperator.Color = filterControl1.AppearanceOperatorColor;
			ceValue.Color = filterControl1.AppearanceValueColor;
			seLevelIndent.Value = filterControl1.LevelIndent;
			seSeparatorHeight.Value = filterControl1.NodeSeparatorHeight;
			ceGroupCommandsIcon.Checked = filterControl1.ShowGroupCommandsIcon;
			ceOperandTypeIcon.Checked = filterControl1.ShowOperandTypeIcon;
			ceToolTips.Checked = filterControl1.ShowToolTips;
			initProperties = false;
		}
        string tblGrid = "[Order Details]";
        string tblLookUp = "Products";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblGrid, connectionString);
            oleDbDataAdapter.Fill(ds, tblGrid);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblLookUp, connectionString);
            oleDbDataAdapter.Fill(ds, tblLookUp);

            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[tblGrid]);

            gridControl1.DataSource = dv;
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);

            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
        }
        protected override void InitNWindData() {
            base.InitNWindData();
			gridControl2.DataSource = OutlookData.CreateIssueList();
		}

        //<sbApply>
		private void sbApply_Click(object sender, System.EventArgs e) {
			filterControl1.ApplyFilter();
		}
        //</sbApply>

        //<ceEmptyValue>
		private void ceEmptyValue_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceEmptyValueColor = ceEmptyValue.Color;
		}
        //</ceEmptyValue>
        //<ceFieldName>
		private void ceFieldName_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceFieldNameColor = ceFieldName.Color;
		}
        //</ceFieldName>
        //<ceGroupOperator>
		private void ceGroupOperator_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceGroupOperatorColor = ceGroupOperator.Color;
		}
        //</ceGroupOperator>
        //<ceOperator>
		private void ceOperator_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceOperatorColor = ceOperator.Color;
		}
        //</ceOperator>
        //<ceValue>
		private void ceValue_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceValueColor = ceValue.Color;
		}
        //</ceValue>
        //<seLevelIndent>
		private void seLevelIndent_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.LevelIndent = Convert.ToInt32(seLevelIndent.Value);
		}
        //</seLevelIndent>
        //<seSeparatorHeight>
		private void seSeparatorHeight_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.NodeSeparatorHeight = Convert.ToInt32(seSeparatorHeight.Value);
		}
        //</seSeparatorHeight>
        //<ceGroupCommandsIcon>
		private void ceGroupCommandsIcon_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowGroupCommandsIcon = ceGroupCommandsIcon.Checked;
		}
        //</ceGroupCommandsIcon>
        //<ceOperandTypeIcon>
		private void ceOperandTypeIcon_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowOperandTypeIcon = ceOperandTypeIcon.Checked;
		}
        //</ceOperandTypeIcon>
        //<ceToolTips>
		private void ceToolTips_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowToolTips = ceToolTips.Checked;
		}
        //</ceToolTips>
		void InitCustomFilterControl() {
			ViewFilterColumnCollection columnCollection = new ViewFilterColumnCollection(gridView2);
			CustomizationFilterColumnCollection(columnCollection);
			filterControl2.SetFilterColumnsCollection(columnCollection, gridControl2.MenuManager);
			filterControl2.SetDefaultColumn(GridCriteriaHelper.GetFilterColumnByGridColumn(filterControl2.FilterColumns, gridColumnImplemented));
			filterControl2.FilterString = gridView2.ActiveFilterString;
		}
        //<sbApplyFilter2>
		private void sbApplyFilter2_Click(object sender, System.EventArgs e) {
			gridView2.ActiveFilterString = filterControl2.FilterString; 
		}
        //</sbApplyFilter2>
        //<sbReset>
		private void sbReset_Click(object sender, System.EventArgs e) {
			ResetCustomFilter();
		}

		void ResetCustomFilter() {
			filterControl2.FilterString = gridView2.ActiveFilterString;
		}
        //</sbReset>
		void CustomizationFilterColumnCollection(ViewFilterColumnCollection columnCollection) {
			columnCollection.RemoveAt(0);
			GridFilterColumn col = columnCollection["Implemented"] as GridFilterColumn;
			RepositoryItemTrackBar tbItem = new RepositoryItemTrackBar();
			tbItem.Maximum = 100;
			tbItem.TickFrequency = 10;
			col.SetRepositoryItem(tbItem);
			col = columnCollection["Suspended"] as GridFilterColumn;
			RepositoryItemImageComboBox icbItem = new RepositoryItemImageComboBox();
			icbItem.SmallImages = imageList1;
			icbItem.Items.Add(new ImageComboBoxItem("Checked", true, 1));
			icbItem.Items.Add(new ImageComboBoxItem("Unchecked", false, 2));
			col.SetRepositoryItem(icbItem);
			col = columnCollection["Subject"] as GridFilterColumn;
			col.SetImage(imageList1.Images[3]);
		}
	}
}
