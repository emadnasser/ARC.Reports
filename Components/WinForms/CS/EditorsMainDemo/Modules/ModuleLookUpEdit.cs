using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Text;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleLookUpEdit : TutorialControl  {
        public ModuleLookUpEdit() {
            InitializeComponent();
            InitData();
            InitArrayData();
            InitLookUp();
            InitValues();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleLookUpEdit.cs;CS\\EditorsMainDemo\\Modules\\LookUpProperties.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.lookupedit.xml";
        }

        protected override bool AllowCenterControls { get { return false; } }
        LookUpProperties properties = null;

        private void ModuleLookUpEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(lookUpEdit1);
            ControlUtils.CenterControlInParent(lookUpEdit2);
            ControlUtils.CenterControlInParent(lookUpEdit3);
            ControlUtils.CenterControlInParent(lookUpEdit4);
            notePanel1.Text = "This sample demonstrates how to use a DataView as a data source for a Lookup editor.";
            notePanel2.Text = "This sample demonstrates how to bind a class inherited from Collection Base within a Lookup edit.";
            notePanel3.Text = "This sample demonstrates how to use an ArrayList-based object as a data source within a Lookup editor.";
            notePanel4.Text = "This sample illustrates how to use the Properties.GetNotInListValue event of the Lookup Edit. Use it to display virtual data within an unbound column of your control.";
            notePanel1.Visible = true;
        }

        LookUpEdit CurrentEdit {
            get {
                switch(xtraTabControl1.SelectedTabPageIndex) {
                    case 1: return lookUpEdit2;
                    case 2: return lookUpEdit3;
                    case 3: return lookUpEdit4;
                }
                return lookUpEdit1;
            }
        }


        void InitValues() {
            if(properties == null) {
                properties = new LookUpProperties(CurrentEdit);
                properties.Dock = DockStyle.Fill;
                xtraTabPage5.Controls.Add(properties);
            }
            else {
                properties.InitLookUp(CurrentEdit);
            }
        }

        //<lookUpEdit1>
        //<dataNavigator1>
        DataView dvMain, dvProducts;

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                DataSet ds = new DataSet();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;

                System.Data.OleDb.OleDbDataAdapter dbAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [Order Details]", con);
                dbAdapter.Fill(ds, "Order Details");
                dbAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con);
                dbAdapter.Fill(ds, "Products");
                DataViewManager dvm = new DataViewManager(ds);

                dvMain = dvm.CreateDataView(ds.Tables["Order Details"]);
                dvProducts = dvm.CreateDataView(ds.Tables["Products"]);
            }
        }
        //</dataNavigator1>
        // </lookUpEdit1>

        // <lookUpEdit3>
        Record[] records = null;
        private void InitArrayData() {
            records = new Record[TutorialHelper.Countries.Length];
            for(int i = 0; i < TutorialHelper.Countries.Length; i++)
                records[i] = new Record(StringPainter.Default.RemoveFormat(TutorialHelper.Countries[i]));
        }
        // </lookUpEdit3>

        private void InitLookUp() {
            //data binding
            // <lookUpEdit1>
            if(dvMain != null)
                lookUpEdit1.DataBindings.Add("EditValue", dvMain, "ProductID");
            lookUpEdit1.Properties.DataSource = dvProducts;
            // </lookUpEdit1>
            //<dataNavigator1>
            dataNavigator1.DataSource = dvMain;
            //</dataNavigator1>
            //simple binding
            // <lookUpEdit2>
            lookUpEdit2.Properties.DataSource = ContactList.GetContacts();
            lookUpEdit2.EditValue = "2";
            // </lookUpEdit2>
            //array list
            // <lookUpEdit3>
            lookUpEdit3.Properties.ValueMember = "Country";
            lookUpEdit3.Properties.DisplayMember = "Country";
            lookUpEdit3.Properties.DataSource = records;
            lookUpEdit3.Properties.PopulateColumns();
            lookUpEdit3.EditValue = records[0].Country;
            // </lookUpEdit3>
            //not in list
            // <lookUpEdit4>
            lookUpEdit4.Properties.DataSource = records;
            lookUpEdit4.EditValue = records[0].Country;
            lookUpEdit4.Properties.GetNotInListValue += new DevExpress.XtraEditors.Controls.GetNotInListValueEventHandler(GetNotInListValue);
            // </lookUpEdit4>
        }

        // <lookUpEdit4>
        private void GetNotInListValue(object sender, DevExpress.XtraEditors.Controls.GetNotInListValueEventArgs e) {
            e.Value = (e.RecordIndex + 1).ToString() + ".";
        }
        // </lookUpEdit4>

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            InitValues();
        }
    }
}

