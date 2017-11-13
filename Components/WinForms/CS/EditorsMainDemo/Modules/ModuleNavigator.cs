using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using DevExpress.Tutorials;
// <icbTextLocations>
// <ceShowCustomButtons>
using DevExpress.XtraEditors;
// </ceShowCustomButtons>
using DevExpress.XtraEditors.Controls;
// </icbTextLocations>
using System.Windows.Forms;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleNavigator : TutorialControl {
        public ModuleNavigator() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleNavigator.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.navigator.xml";
        }

        bool updateValues = false;

        private void ModuleNavigator_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(dataNavigatorSample);
            InitComboBoxes();
            InitValues();
            InitData();
        }

        void InitComboBoxes() {
            // <icbTextLocations>
            icbTextLocations.Properties.Items.AddEnum(typeof(NavigatorButtonsTextLocation));
            // </icbTextLocations>
        }


        void InitValues() {
            updateValues = true;
            icbTextLocations.EditValue = dataNavigatorSample.TextLocation;
            ceEnableAutoRepeat.Checked = dataNavigatorSample.Buttons.EnabledAutoRepeat;
            ceShowToolTips.Checked = dataNavigatorSample.ShowToolTips;
            ceShowCustomButtons.Checked = true;
            ceShowEditingButtons.Checked = true;
            ceShowAppendRemove.Checked = true;
            ceShowPageButtons.Checked = true;
            updateValues = false;
        }

        private void InitData() {
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != "") {
                DataSet ds = new DataSet();
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;

                System.Data.OleDb.OleDbDataAdapter dbAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con);
                dbAdapter.Fill(ds, "Products");

                dataNavigatorSample.DataSource = ds.Tables["Products"];
                panelControl1.DataBindings.Add("Text", ds.Tables["Products"], "ProductName");
            }
        }

        // <icbTextLocations>
        private void icbTextLocations_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.TextLocation = (NavigatorButtonsTextLocation)icbTextLocations.EditValue;
            // <skip>
            ShowNavigator();
            // </skip>
        }
        // </icbTextLocations>

        // <ceEnableAutoRepeat>
        private void ceEnableAutoRepeat_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.Buttons.EnabledAutoRepeat = ceEnableAutoRepeat.Checked;
        }
        // </ceEnableAutoRepeat>

        // <ceShowToolTips>
        private void ceShowToolTips_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.ShowToolTips = ceShowToolTips.Checked;
        }
        // </ceShowToolTips>

        void ShowNavigator() {
            dataNavigatorSample.Width = 10;
            ControlUtils.CenterControlInParent(dataNavigatorSample);
        }

        // <ceShowCustomButtons>
        private void ceShowCustomButtons_CheckedChanged(object sender, System.EventArgs e) {
            foreach(NavigatorCustomButton button in dataNavigatorSample.Buttons.CustomButtons)
                button.Visible = ceShowCustomButtons.Checked;
            ShowNavigator();
        }
        // </ceShowCustomButtons>

        // <ceShowEditingButtons>
        private void ceShowEditingButtons_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.CancelEdit.Visible = dataNavigatorSample.Buttons.EndEdit.Visible =
                ceShowEditingButtons.Checked;
            ShowNavigator();
        }
        // </ceShowEditingButtons>

        // <ceShowAppendRemove>
        private void ceShowAppendRemove_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.Append.Visible = dataNavigatorSample.Buttons.Remove.Visible =
                ceShowAppendRemove.Checked;
            ShowNavigator();
        }
        // </ceShowAppendRemove>

        // <ceShowPageButtons>
        private void ceShowPageButtons_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.PrevPage.Visible = dataNavigatorSample.Buttons.NextPage.Visible =
                ceShowPageButtons.Checked;
            ShowNavigator();
        }
        // </ceShowPageButtons>

        // <dataNavigatorSample>
        private void dataNavigatorSample_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            ShowEvent("ButtonClick", e.Button);
        }

        void ShowEvent(string eventString, NavigatorButtonBase button) {
            string type = button.ButtonType.ToString();
            if(type == "Custom") type += " - " + button.Tag.ToString();
            meFiringEvents.Text = string.Format("{0}: {1}\r\n", eventString, type) + meFiringEvents.Text;
        }
        // </dataNavigatorSample>
    }
}

