using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Snap.Core.API;

namespace SnapDemos.Modules {
    public partial class ColumnChooserDialog : Form {

        DataFieldInfo[] fieldList;
        List<DataFieldInfo> result;

        public ColumnChooserDialog() {
            fieldList = null;
            result = null;
            InitializeComponent();
        }

        public void SetFieldList(IEnumerable<DataFieldInfo> fieldList) {
            this.fieldList = fieldList.ToArray();
            panel1.Controls.Clear();
            if(fieldList == null)
                return;
            this.Height = 117 + 24 * fieldList.Count();
            int i = 0;
            foreach(DataFieldInfo field in fieldList) {
                panel1.Controls.Add(new CheckBox() { Text = String.Join(".", field.DataPaths), Top = 4 + 24 * (i), AutoSize = true, Checked = true });
                i++;
            }
        }

        public List<DataFieldInfo> Result { get { return result; } }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.result = new List<DataFieldInfo>(fieldList.Length);
            for(int i = 0; i < fieldList.Length; i++) {
                CheckBox chk = panel1.Controls[i] as CheckBox;
                if(chk != null && chk.Checked)
                    this.result.Add(fieldList[i]);
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.result = null;
            Close();
        }
    }
}
