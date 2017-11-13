using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraTreeList.Demos.Tutorials {
    /// <summary>
    /// Summary description for ColumnAlignment.
    /// </summary>
    public partial class ColumnAlignment : TutorialControl {
        public ColumnAlignment() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitData();
            InitComboBoxes();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void InitData() {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            treeList1.OptionsBehavior.Editable = true;
        }

        private void InitComboBoxes() {
            foreach(DevExpress.XtraTreeList.Columns.TreeListColumn col in treeList1.Columns)
                comboBox1.Properties.Items.Add(col.FieldName);
            comboBox1.SelectedIndex = 1;
            comboBox2.Properties.Items.AddRange(Enum.GetNames(typeof(DevExpress.Utils.HorzAlignment)));
            comboBox2.SelectedIndex = 0;
        }

        //<comboBox1>
        //<comboBox2>
        private DevExpress.Utils.HorzAlignment hAlignment(string s) {
            Array arr = Enum.GetValues(typeof(DevExpress.Utils.HorzAlignment));
            for(int i = 0; i < arr.Length; i++) {
                if(s == arr.GetValue(i).ToString())
                    return (DevExpress.Utils.HorzAlignment)arr.GetValue(i);
            }
            return DevExpress.Utils.HorzAlignment.Default;
        }

        private void SetColumnStyle(DevExpress.XtraTreeList.Columns.TreeListColumn col, string alignment) {
            col.AppearanceCell.TextOptions.HAlignment = hAlignment(alignment);
        }

        private void comboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
            try {
                SetColumnStyle(treeList1.Columns[comboBox1.SelectedItem.ToString()], comboBox2.SelectedItem.ToString());
            }
            catch { }
        }
        //</comboBox1>
        //</comboBox2>
    }
}
