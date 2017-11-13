using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	/// <summary>
	/// Summary description for MultiEditorsRow.
	/// </summary>
	public partial class MultiEditorsRow : TutorialControl {
		public MultiEditorsRow() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        bool update = false;
		private void MultiEditorsRow_Load(object sender, System.EventArgs e) {
			InitData();
			vGridControl1.FocusedRow = vGridControl1.Rows[0].ChildRows[0];
		}

		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(DBFileName);
				vGridControl1.DataSource = dataSet.Tables[0].DefaultView;
			}
		}

  
        //<checkBox1>
        Color[] customColors = new Color[] { Color.Wheat, Color.PapayaWhip, Color.FloralWhite };
        private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e) {
			if(checkBox1.Checked) {
				if(e.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow && !e.Focused) {
					e.Appearance.BackColor = customColors[e.CellIndex];
					e.Appearance.ForeColor = SystemColors.WindowText;
				}
			}
		}
		
		private void vGridControl1_CustomDrawSeparator(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs e) {
			if(checkBox1.Checked) {
				e.Appearance.BackColor = Color.Wheat;
				e.Appearance.BackColor2 = Color.PapayaWhip;
				e.Appearance.ForeColor = SystemColors.WindowText;
			}
		}

		private void vGridControl1_CustomDrawRowHeaderIndent(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderIndentEventArgs e) {
			if(checkBox1.Checked)
				if(e.Row is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow) {
					e.Appearance.BackColor = Color.Wheat;
					e.Appearance.ForeColor = SystemColors.WindowText;
				}
		}
        
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			vGridControl1.LayoutChanged();
		}
        //</checkBox1>

		private void vGridControl1_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e) {
			SetSeparatorStyle();
		}

		
		private void SetSeparatorStyle() {
			update = true;
			if(vGridControl1.FocusedRow is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow) {
				DevExpress.XtraVerticalGrid.Rows.MultiEditorRow row = vGridControl1.FocusedRow as DevExpress.XtraVerticalGrid.Rows.MultiEditorRow;
				if(row.SeparatorKind == DevExpress.XtraVerticalGrid.Rows.SeparatorKind.VertLine) 
					comboBox1.SelectedIndex = 0;
				else comboBox1.SelectedIndex = 1;
				textBox1.Text = row.SeparatorString;
				comboBox1.Enabled = textBox1.Enabled = true;
			} 
			else 
				comboBox1.Enabled = textBox1.Enabled = false;
			update = false;
		}
		
        //<comboBox1>
        //<textBox1>
		private void Separator_Changed(object sender, System.EventArgs e) {
			if(!update) {
				DevExpress.XtraVerticalGrid.Rows.MultiEditorRow row = vGridControl1.FocusedRow as DevExpress.XtraVerticalGrid.Rows.MultiEditorRow;
				row.SeparatorKind = (comboBox1.SelectedIndex == 0 ? DevExpress.XtraVerticalGrid.Rows.SeparatorKind.VertLine : DevExpress.XtraVerticalGrid.Rows.SeparatorKind.String);
				row.SeparatorString = textBox1.Text;
			}
		}
        //</textBox1>
        //</comboBox1>
	}
}
