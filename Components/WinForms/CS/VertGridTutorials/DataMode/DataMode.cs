using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    /// <summary>
    /// Summary description for DataMode.
    /// </summary>
    public partial class DataMode : TutorialControl {
        public DataMode() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        //<vGridControl1>
        private void DataMode_Load(object sender, System.EventArgs e) {
            InitData();
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Cars.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                vGridControl1.DataSource = dataSet.Tables[0].DefaultView;
            }
        }
        //</vGridControl1>
    }
}
