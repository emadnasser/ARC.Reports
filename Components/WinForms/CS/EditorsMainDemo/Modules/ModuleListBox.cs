using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using DevExpress.Tutorials;
using System.Windows.Forms;
// <imageListBoxControlSample>
using DevExpress.XtraEditors;
// </imageListBoxControlSample>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleListBox : TutorialControl {
        public ModuleListBox() {
            InitializeComponent();
            InitListBox();
            InitValues();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleListBox.cs;CS\\EditorsMainDemo\\Modules\\ListBoxProperties.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.listbox.xml";
        }
        SizeF scaleFactor = new SizeF(1f, 1f);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            this.scaleFactor = factor;
        }
        protected override bool AllowCenterControls { get { return false; } }
        ListBoxProperties properties = null;

        BaseListBoxControl CurrentListBox {
            get {
                switch(xtraTabControl1.SelectedTabPageIndex) {
                    case 1: return checkedListBoxControlSample;
                    case 2: return imageListBoxControlSample;
                }
                return listBoxControlSample;
            }
        }
                
        void InitValues() {
            if(properties == null) {
                properties = new ListBoxProperties(CurrentListBox);
                TurnSearch(true);
                properties.SearchControlPropertyChanged += new PropertyChangedEventHandler(properties_SearchControlPropertyChanged);                
                properties.Dock = DockStyle.Fill;
                xtraTabPage5.Controls.Add(properties);
            }
            else {
                properties.InitListBox(CurrentListBox);
            }
        }

        void properties_SearchControlPropertyChanged(object sender, PropertyChangedEventArgs e) {
            PropertyValueChangedEventArgs args = e as PropertyValueChangedEventArgs;
            switch(args.PropertyName) {
                case "AllowAutoApply":
                    // <ceAllowAutoApply>
                    searchControlSample.Properties.AllowAutoApply = (bool)args.Value;
                    // </ceAllowAutoApply>
                    return;
                case "ShowSearchButton":
                    // <ceShowSearchButton>
                    searchControlSample.Properties.ShowSearchButton = (bool)args.Value;
                    // </ceShowSearchButton>
                    return;
                case "ShowClearButton":
                    // <ceShowClearButton>
                    searchControlSample.Properties.ShowClearButton = (bool)args.Value;
                    // </ceShowClearButton>
                    return;
                case "ShowMRUButton":
                    // <ceShowMRUButton>
                    searchControlSample.Properties.ShowMRUButton = (bool)args.Value;
                    // </ceShowMRUButton>
                    return;
                case "FindDelay":
                    // <tbFindDelay>
                    searchControlSample.Properties.FindDelay = (int)args.Value;
                    // </tbFindDelay>
                    return;
                case "FilterCondition":
                    // <cbFilterCondition>
                    searchControlSample.Properties.FilterCondition = (DevExpress.Data.Filtering.FilterCondition)args.Value;
                    // </cbFilterCondition>
                    return;
                case "ShowDefaultButtonsMode":
                    // <cbShowDefaultButtonsMode>
                    searchControlSample.Properties.ShowDefaultButtonsMode = (Repository.ShowDefaultButtonsMode)args.Value;
                    // <cbShowDefaultButtonsMode>
                    break;
                case "TurnSearch":
                    splitContainerControl.PanelVisibility = (bool)args.Value ? SplitPanelVisibility.Both : SplitPanelVisibility.Panel2;
                    // <searchControlSample>
                    TurnSearch((bool)args.Value);
                    // </searchControlSample>
                    return;
            }
        }        
        // <searchControlSample>
        void TurnSearch(bool allowSearch) {            
            ListBoxControl listBoxControl = CurrentListBox as ListBoxControl;
            if(allowSearch && listBoxControl != null)
                searchControlSample.Client = listBoxControl;
            else
                searchControlSample.Client = null;            
        }
        // </searchControlSample>        

        void InitListBox() {
            listBoxControlSample.DataSource = TutorialHelper.Countries;
            //
            // <checkedListBoxControlSample>
            checkedListBoxControlSample.DataSource = GetData();
            if(checkedListBoxControlSample.DataSource != null) {
                checkedListBoxControlSample.DisplayMember = "ProductName";
                checkedListBoxControlSample.ValueMember = "Discontinued";
                int i = 0;
                while(checkedListBoxControlSample.GetItem(i) != null) {
                    checkedListBoxControlSample.SetItemCheckState(i, (true.Equals(checkedListBoxControlSample.GetItemValue(i)) ? CheckState.Unchecked : CheckState.Checked));
                    i++;
                }
            }
            // </checkedListBoxControlSample>
            //
            Size imageSize = new System.Drawing.Size((int)(25 * scaleFactor.Width), (int)(16 * scaleFactor.Height));
            DevExpress.Tutorials.TutorialHelper.InitFont(imageListBoxControlSample, imageSize);
            imageListBoxControlSample.SelectedIndex = 0;
        }

        // <checkedListBoxControlSample>
        DataTable GetData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                DataSet ds = new DataSet();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;

                System.Data.OleDb.OleDbDataAdapter dbAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con);
                dbAdapter.Fill(ds, "Products");
                return ds.Tables["Products"];
            }
            return null;
        }
        // </checkedListBoxControlSample>


        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            InitValues();
        }

        // <ceCustomDraw>
        private void checkedListBoxControlSample_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e) {
            if(!ceCustomDraw.Checked) return;
            if(checkedListBoxControlSample.GetItemChecked(e.Index)) return;
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
        }

        private void ceCustomDraw_CheckedChanged(object sender, System.EventArgs e) {
            checkedListBoxControlSample.Refresh();
        }
        // </ceCustomDraw>

        // <imageListBoxControlSample>
        private void imageListBoxControlSample_SelectedIndexChanged(object sender, System.EventArgs e) {
            ImageListBoxControl ilb = sender as ImageListBoxControl;
            object fontName = ilb.SelectedValue;
            lbSample.Visible = fontName != null;
            if(fontName == null) return;
            lbSample.Font = new Font(fontName.ToString(), 12);
        }
        // </imageListBoxControlSample>

        // <seInvert>
        private void seInvert_Click(object sender, System.EventArgs e) {
            checkedListBoxControlSample.BeginUpdate();
            try {
                int i = 0;
                while(checkedListBoxControlSample.GetItem(i) != null) {
                    checkedListBoxControlSample.SetItemCheckState(i, (checkedListBoxControlSample.GetItemChecked(i) ? CheckState.Unchecked : CheckState.Checked));
                    i++;
                }
            }
            finally {
                checkedListBoxControlSample.EndUpdate();
            }
        }
        // </seInvert>
    }
}

