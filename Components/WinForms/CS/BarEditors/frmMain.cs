using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraBars.Demos.BarEditors {
    /// <summary>
    /// Summary description for frmMain.
    /// </summary>
    public partial class frmMain : System.Windows.Forms.Form {
        public frmMain() {
            //
            // Required for Windows Form Designer support
            //
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Products.xml");
            InitializeComponent();
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                gridControl1.DataSource = dataView = dataSet.Tables[0].DefaultView;
            }
            string[] s = new String[] {"Beverages", "Condiments", "Confections", "Dairy Products", 
										  "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood"};
            for(int i = 0; i < s.Length; i++)
                repositoryImageComboBox1.Items.Add(new ImageComboBoxItem(s[i], i + 1, i));
            RepositoryItem ri = repositoryImageComboBox1.Clone() as RepositoryItem;
            gridControl1.RepositoryItems.Add(ri);
            colCategoryID.ColumnEdit = ri;
            SetFilter();
            ips_Init();
            InitSkins();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #region Skins

        void InitSkins() {
            barManager1.ForceInitialize();
            foreach(DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins) {
                BarButtonItem item = new BarButtonItem(barManager1, skinMask + cnt.SkinName);
                iPaintStyle.AddItem(item);
                item.ItemClick += new ItemClickEventHandler(OnSkinClick);
            }
        }
        void OnSkinClick(object sender, ItemClickEventArgs e) {
            string skinName = e.Item.Caption.Replace(skinMask, "");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
            barManager1.GetController().PaintStyleName = "Skin";
            iPaintStyle.Caption = iPaintStyle.Hint = e.Item.Caption;
            iPaintStyle.Hint = iPaintStyle.Caption;
            iPaintStyle.ImageIndex = -1;
        }
        #endregion
        string DBFileName;
        DataView dataView;
        string[] filter = new string[3];
        string skinMask = "Skin: ";

        private void SetFilter() {
            string f = "";
            foreach(string s in filter) {
                if(f != "" && (s != null && s != "")) f += " AND ";
                if(s != "") f += s;
            }
            dataView.RowFilter = f;
            iFilter.Caption = (f == "") ? "No Filter" : "Filter: " + f;
            iRecords.Caption = "Records: " + dataView.Count.ToString();
        }

        private void discontinued_EditValueChanged(object sender, System.EventArgs e) {
            if(discontinued.EditValue == null)
                filter[0] = "";
            else
                filter[0] = "[Discontinued] = " + discontinued.EditValue.ToString();
            SetFilter();
        }

        private void lastOrder_EditValueChanged(object sender, System.EventArgs e) {
            if(lastOrder.EditValue == null)
                filter[1] = "";
            else
                filter[1] = "[LastOrder] < #" + StringDateToUFormat(lastOrder.EditValue.ToString()) + "#";
            SetFilter();
        }

        private void iClearFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            discontinued.EditValue = null;
            lastOrder.EditValue = null;
            categories.EditValue = null;
        }

        private void categories_EditValueChanged(object sender, System.EventArgs e) {
            if(categories.EditValue == null)
                filter[2] = "";
            else
                filter[2] = "[CategoryID] = " + categories.EditValue.ToString();
            SetFilter();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }

        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }

        private static string StringDateToUFormat(string s) {
            try {
                return DateTime.Parse(s).ToString("d", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch { return s; }
        }

        private void ips_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            barManager1.GetController().PaintStyleName = e.Item.Description;
            InitPaintStyle(e.Item);
            barManager1.GetController().ResetStyleDefaults();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle();
        }

        private void InitPaintStyle(BarItem item) {
            if(item == null) return;
            iPaintStyle.ImageIndex = item.ImageIndex;
            iPaintStyle.Caption = item.Caption;
            iPaintStyle.Hint = item.Description;
        }

        private void ips_Init() {
            BarItem item = null;
            for(int i = 0; i < barManager1.Items.Count; i++)
                if(barManager1.Items[i].Description == barManager1.GetController().PaintStyleName)
                    item = barManager1.Items[i];
            InitPaintStyle(item);
        }
    }
}
