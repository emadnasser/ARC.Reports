using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for StyleConditions.
	/// </summary>
	public partial class StyleConditions : TutorialControl {
		public StyleConditions() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\StyleConditions.cs;CS\\GridMainDemo\\Modules\\ExpressionConditionsEditor.cs;CS\\GridMainDemo\\Modules\\ConditionsEditor.cs;CS\\GridMainDemo\\Modules\\ConditionsItem.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.StyleConditions.xml";
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { 
            get { 
                if(xtraTabControl1.SelectedTabPage == xtraTabPage1)
                    return gridView1;
                return gridView2;
            } 
        }
		private void StyleConditions_Load(object sender, System.EventArgs e) {
			InitNWindData();
			gridView1.SetIcons();
			CreateTimer();
			ceTranslucentColors.Checked = true;
            expressionConditionsEditor1.Init(gridView2);
            //<gridControl1>
            /*
            ~Note: the following code is set at design-time and listed here for educational purposes only.
            
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            gridFormatRule5.Column = this.colUnitPrice;
            gridFormatRule5.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor2")));
            formatConditionRuleValue1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor3")));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual;
            formatConditionRuleValue1.Value1 = 18;
            gridFormatRule5.Rule = formatConditionRuleValue1;
            gridFormatRule6.Column = this.colUnitPrice;
            gridFormatRule6.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor3")));
            formatConditionRuleValue2.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor4")));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.GreaterOrEqual;
            formatConditionRuleValue2.Value1 = 40;
            gridFormatRule6.Rule = formatConditionRuleValue2;
            gridFormatRule7.ApplyToRow = true;
            gridFormatRule7.Column = this.colDiscontinued;
            gridFormatRule7.Name = "Format2";
            formatConditionRuleValue3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            formatConditionRuleValue3.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor5")));
            formatConditionRuleValue3.Appearance.Options.UseFont = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = true;
            gridFormatRule7.Rule = formatConditionRuleValue3;
            gridFormatRule8.Column = this.colProductName;
            gridFormatRule8.Name = "Format3";
            formatConditionRuleValue4.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor4")));
            formatConditionRuleValue4.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("resource.ForeColor6")));
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Between;
            formatConditionRuleValue4.Value1 = "c";
            formatConditionRuleValue4.Value2 = "d";
            gridFormatRule8.Rule = formatConditionRuleValue4;
            this.gridView1.FormatRules.Add(gridFormatRule5);
            this.gridView1.FormatRules.Add(gridFormatRule6);
            this.gridView1.FormatRules.Add(gridFormatRule7);
            this.gridView1.FormatRules.Add(gridFormatRule8);
        */
            //</gridControl1>
		}

		protected override void OnTick() {
			gridView1.SetIcons();
		}

        string tblName = "Products";
        string tblName2 = "[Order Details]";
        protected override void InitMDBData(string connectionString) {
            DataSet ds = new DataSet();
            
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, connectionString);
            oleDbDataAdapter.Fill(ds, tblName);
            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName2, connectionString);
            oleDbDataAdapter.Fill(ds, tblName2);

            DataViewManager dvManager = new DataViewManager(ds);
            DataView dv = dvManager.CreateDataView(ds.Tables[tblName]);

            gridControl1.DataSource = dv;
            gridControl2.DataSource = ds.Tables[tblName2];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblName];
        }

        private void gridView1_ShowFilterPopupListBox(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs e) {
			for(int i = 0; i < e.ComboBox.Items.Count; i++)
				if(e.ComboBox.Items[i] is FilterItem)
					if(((FilterItem)e.ComboBox.Items[i]).Text == GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom)) {
						e.ComboBox.Items.Insert(i, new FilterItem(Properties.Resources.ConditionsName, 4));
						break;
					}
		}

		private void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
			if(MyGridView.IsCondition(e.Column)) {
				Font headerFont = gridView1.PaintAppearance.HeaderPanel.Font;
				e.Appearance.Font = new Font(headerFont, headerFont.Bold ? FontStyle.Underline | FontStyle.Bold : FontStyle.Underline);
			}
		}

		private void ceTranslucentColors_CheckedChanged(object sender, System.EventArgs e) {
			if(ceTranslucentColors.Checked) 
				gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
			else 
				gridView1.Appearance.FocusedRow.Reset();
		}

        //<simpleBUtton1>
        private void simpleButton1_Click(object sender, EventArgs e) {
            ConditionsEditor editor = new ConditionsEditor(gridView1.FocusedColumn, this.FindForm());
            this.FindForm().Refresh();
            editor.ShowDialog();
        }
        //</simpleButton1>
	}
}
