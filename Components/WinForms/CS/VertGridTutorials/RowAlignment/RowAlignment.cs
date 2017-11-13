using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for RowAlignment.
    /// </summary>
    public partial class RowAlignment : TutorialControl {
        public RowAlignment() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void RowAlignment_Load(object sender, System.EventArgs e) {
            InitData();
            InitComboBoxes();
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Cars.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                vGridControl1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }

        private void AddToComboBox(DevExpress.XtraVerticalGrid.Rows.BaseRow row, DevExpress.XtraEditors.ComboBoxEdit cb) {
            if(row is DevExpress.XtraVerticalGrid.Rows.EditorRow)
                cb.Properties.Items.Add(row.Properties.Caption);
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow cRow in row.ChildRows)
                AddToComboBox(cRow, cb);
        }

        private void InitComboBoxes() {
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow row in vGridControl1.Rows)
                AddToComboBox(row, comboBox1);
            comboBox1.SelectedIndex = 0;
            comboBox2.Properties.Items.AddRange(Enum.GetNames(typeof(DevExpress.Utils.HorzAlignment)));
            comboBox2.SelectedIndex = 0;
        }

        private DevExpress.Utils.HorzAlignment hAlignment(string s) {
            Array arr = Enum.GetValues(typeof(DevExpress.Utils.HorzAlignment));
            for(int i = 0; i < arr.Length; i++) {
                if(s == arr.GetValue(i).ToString())
                    return (DevExpress.Utils.HorzAlignment)arr.GetValue(i);
            }
            return DevExpress.Utils.HorzAlignment.Default;
        }

        //<comboBox2>
        private void SetRowStyle(DevExpress.XtraVerticalGrid.Rows.BaseRow row, string alignment) {
            row.Appearance.TextOptions.HAlignment = hAlignment(alignment);
        }
        //</comboBox2>

        private DevExpress.XtraVerticalGrid.Rows.BaseRow GetRowByCaptionChild(DevExpress.XtraVerticalGrid.Rows.BaseRow row, string s) {
            if(row.Properties.Caption == s) return row;
            DevExpress.XtraVerticalGrid.Rows.BaseRow r;
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow cRow in row.ChildRows) {
                r = GetRowByCaptionChild(cRow, s);
                if(r != null) return r;
            }
            return null;
        }

        private DevExpress.XtraVerticalGrid.Rows.BaseRow GetRowByCaption(string s) {
            DevExpress.XtraVerticalGrid.Rows.BaseRow r;
            foreach(DevExpress.XtraVerticalGrid.Rows.BaseRow row in vGridControl1.Rows) {
                r = GetRowByCaptionChild(row, s);
                if(r != null) return r;
            }
            return null;
        }

        //<comboBox2>
        private void comboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
            try {
                SetRowStyle(GetRowByCaption(comboBox1.SelectedItem.ToString()), comboBox2.SelectedItem.ToString());
            }
            catch { }
        }
        //</comboBox2>
    }
}
