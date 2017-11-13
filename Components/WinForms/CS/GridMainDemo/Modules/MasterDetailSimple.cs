﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
    public partial class MasterDetailSimple : TutorialControl {
        public MasterDetailSimple() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MasterDetailSimple.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.MasterDetailSimple.xml";
            InitNWindData();
            InitRowHeightOptions();
            InitDetailOptions();
        }

        public override Views.Base.BaseView ExportView { get { return MainView; } }
        GridView MainView { get { return gridView1; } }
        protected override void InitMDBData(string connectionString) {
            new OleDbDataAdapter("SELECT * FROM Categories", connectionString).Fill(dsNWindCategories1.Categories);
            new OleDbDataAdapter("SELECT * FROM Products", connectionString).Fill(dsNWindCategories1.Products);
        }
        private void gridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e) {
            GridView view = sender as GridView;
            if(view != null) {
                GridView detailView = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
                if(detailView != null) detailView.ExpandGroupRow(-1);
            }
        }

        private void gridView2_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e) {
            if(e.Column.FieldName == colReorderLevel.FieldName) e.RepositoryItem = repositoryItemSpinEdit2;
        }

        void InitRowHeightOptions() {
            ceRowAutoHeight.Checked = MainView.OptionsView.RowAutoHeight;
            seRowHeight.Value = MainView.RowHeight;
            seRowHeight.Enabled = !MainView.OptionsView.RowAutoHeight;
            sbBestFit.Enabled = MainView.OptionsView.RowAutoHeight;
        }

        //<seRowHeight>
        private void seRowHeight_EditValueChanged(object sender, EventArgs e) {
            MainView.RowHeight = Convert.ToInt32(seRowHeight.Value);
            InitRowHeightOptions();
        }
        //</seRowHeight>
        int rowHeightValue = -1;

        //<ceRowAutoHeight>
        private void ceRowAutoHeight_CheckedChanged(object sender, EventArgs e) {
            MainView.OptionsView.RowAutoHeight = ceRowAutoHeight.Checked;
            if(MainView.OptionsView.RowAutoHeight) {
                InitRowHeightOptions();
                rowHeightValue = Convert.ToInt32(seRowHeight.Value);
                MainView.RowHeight = -1;
            } else {
                MainView.RowHeight = rowHeightValue;
                InitRowHeightOptions();
            }
        }
        //</ceRowAutoHeight>

        //<sbBestFit>
        private void sbBestFit_Click(object sender, EventArgs e) {
            MainView.BestFitColumns();
        }
        //</sbBestFit>
        void InitDetailOptions() {
            ceEnabledMasterViewMode.Checked = MainView.OptionsDetail.EnableMasterViewMode;
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1);
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1);
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode;
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent != Utils.DefaultBoolean.False;
            EnabledDetailOptions();
        }

        //<ceEnabledMasterViewMode>
        private void ceEnabledMasterViewMode_CheckedChanged(object sender, EventArgs e) {
            MainView.OptionsDetail.EnableMasterViewMode = sbExpandDetails.Enabled = ceEnabledMasterViewMode.Checked;
            ExpandDemoGroup();
            EnabledDetailOptions();
            MainView.TopRowIndex = 0;
        }
        void ExpandDemoGroup() {
            if(MainView.OptionsDetail.EnableMasterViewMode)
                MainView.SetMasterRowExpanded(1, true);
        }
        void EnabledDetailOptions() {
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode == DetailMode.Embedded && MainView.OptionsDetail.EnableMasterViewMode;
            icbDetailMode.Enabled = MainView.OptionsDetail.EnableMasterViewMode;
        }
        //</ceEnabledMasterViewMode>
        //<sbExpandDetails>
        private void sbExpandDetails_Click(object sender, EventArgs e) {
            if(MainView.GroupCount > 0) MainView.ExpandAllGroups();
            MainView.BeginUpdate();
            try {
                for(int i = 0; i < MainView.RowCount; i++)
                    MainView.SetMasterRowExpanded(i, true);
            } finally {
                MainView.EndUpdate();
            }
        }
        //</sbExpandDetails>
        private void icbDetailMode_SelectedIndexChanged(object sender, EventArgs e) {
            //<icbDetailMode>
            MainView.OptionsDetail.DetailMode = (DetailMode)icbDetailMode.EditValue;
            //</icbDetailMode>
            EnabledDetailOptions();
            ExpandDemoGroup();
            MainView.TopRowIndex = 0;
        }

        //<ceShowEmbeddedDetailIndent>
        private void ceShowEmbeddedDetailIndent_CheckedChanged(object sender, EventArgs e) {
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = ceShowEmbeddedDetailIndent.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowEmbeddedDetailIndent>
    }
}
