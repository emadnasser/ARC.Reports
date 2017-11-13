using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTokenEdit : TutorialControl {
        RepositoryItemTokenEdit properties;
        public ModuleTokenEdit() {
            InitializeComponent();
            this.properties = tokenEdit.Properties;
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleTokenEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.tokenEdit.xml";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitValues();
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        void InitValues() {
            this.ceShowDropDown.Checked = this.properties.ShowDropDown;
            this.seDropDownRowCount.Value = this.properties.DropDownRowCount;
            this.cbeCheckMode.Properties.Items.AddEnum(typeof(TokenEditCheckMode));
            this.cbeCheckMode.EditValue = this.properties.CheckMode;
            this.seMaxExpandLines.Value = this.properties.MaxExpandLines;
            this.ceShowPopupPanel.Checked = this.properties.PopupPanelOptions.ShowPopupPanel;
            this.cbePopupPanelLocation.Properties.Items.AddEnum(typeof(TokenEditPopupPanelLocation));
            this.cbePopupPanelLocation.EditValue = this.properties.PopupPanelOptions.Location;
            this.cbeDropDownMode.Properties.Items.AddEnum(typeof(TokenEditDropDownShowMode));
            this.cbeDropDownMode.EditValue = this.properties.DropDownShowMode;
            this.cbeEditMode.Properties.Items.AddEnum(typeof(TokenEditMode));
            this.cbeEditMode.EditValue = this.properties.EditMode;
            this.cbeFontSize.Properties.Items.AddEnum(typeof(TokenEditFontSize));
            this.cbeFontSize.EditValue = TokenEditFontSize.Default;
            this.ceShowItemRemoveButton.Checked = this.properties.ShowRemoveTokenButtons;
            this.cePopupSizeable.Checked = this.properties.PopupSizeable;
            this.cbeGlyphLocation.Properties.Items.AddEnum(typeof(TokenEditGlyphLocation));
            this.cbeGlyphLocation.EditValue = this.properties.TokenGlyphLocation;
            if(this.cbeEditValueSep.Properties.Items.Count > 0) this.cbeEditValueSep.SelectedIndex = 0;
            this.tokenEdit.EditValue = "January";
        }
        // <ceShowDropDown>
        void OnShowDropDownCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.properties.ShowDropDown = checkEdit.Checked;
        }
        // </ceShowDropDown>
        // <btnClearEventLog>
        void OnClearEventLogClick(object sender, EventArgs e) {
            this.eventsLog.Text = string.Empty;
        }
        // </btnClearEventLog>
        // <tokenEdit>
        void OnTokenEditBeforeShowPopupPanel(object sender, TokenEditBeforeShowPopupPanelEventArgs e) {
            AddEventEntry("BeforeShowPopupPanel", e.Description);
            this.tokenLabelValue.Text = e.Description;
        }
        void OnTokenEditTokenMouseEnter(object sender, TokenEditTokenMouseEnterEventArgs e) {
            AddEventEntry("TokenMouseEnter", e.Description);
        }
        void OnTokenEditTokenMouseHover(object sender, TokenEditTokenMouseHoverEventArgs e) {
            AddEventEntry("TokenMouseHover", e.Description);
        }
        void OnTokenEditTokenMouseLeave(object sender, TokenEditTokenMouseLeaveEventArgs e) {
            AddEventEntry("TokenMouseLeave", e.Description);
        }
        void OnTokenEditValueChanged(object sender, EventArgs e) {
            TokenEdit tokenEdit = (TokenEdit)sender;
            AddEventEntry("EditValueChanged", tokenEdit.EditValue);
            UpdateEditValue();
        }
        void OnTokenEditTokenClick(object sender, TokenEditTokenClickEventArgs e) {
            TokenEdit tokenEdit = (TokenEdit)sender;
            AddEventEntry("TokenClick", e.Description);
        }
        void OnTokenEditTokenDoubleClick(object sender, TokenEditTokenClickEventArgs e) {
            TokenEdit tokenEdit = (TokenEdit)sender;
            AddEventEntry("TokenDoubleClick", e.Description);
        }
        void OnTokenEditCheckStateChanged(object sender, EventArgs e) {
            TokenEdit tokenEdit = (TokenEdit)sender;
            AddEventEntry("TokenCheckStateChanged", null);
        }
        // </tokenEdit>
        // <seDropDownRowCount>
        void OnDropDownRowCountEditValueChanged(object sender, EventArgs e) {
            SpinEdit spinEdit = (SpinEdit)sender;
            this.properties.DropDownRowCount = (int)spinEdit.Value;
        }
        // </seDropDownRowCount>
        // <cbeCheckMode>
        void OnCheckModeSelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.CheckMode = (TokenEditCheckMode)comboBox.EditValue;
        }
        // </cbeCheckMode>
        // <seMaxExpandLines>
        void OnMaxExpandLinesEditValueChanged(object sender, EventArgs e) {
            SpinEdit spinEdit = (SpinEdit)sender;
            this.properties.MaxExpandLines = (int)spinEdit.Value;
        }
        // </seMaxExpandLines>
        // <ceShowPopupPanel>
        void OnShowPopupPanelCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.properties.PopupPanelOptions.ShowPopupPanel = checkEdit.Checked;
        }
        // </ceShowPopupPanel>
        // <cbePopupPanelLocation>
        void OnPopupPanelLocationSelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.PopupPanelOptions.Location = (TokenEditPopupPanelLocation)comboBox.EditValue;
        }
        // </cbePopupPanelLocation>
        // <ceShowItemRemoveButton>
        void OnShowItemRemoveButtonCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.properties.ShowRemoveTokenButtons = checkEdit.Checked;
        }
        // </ceShowItemRemoveButton>
        // <cePopupSizeable>
        void OnPopupSizeableCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            this.properties.PopupSizeable = checkEdit.Checked;
        }
        // </cePopupSizeable>
        // <cbeEditValueSep>
        void OnEditValueSepSelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.EditValueSeparatorChar = char.Parse(comboBox.EditValue.ToString());
        }
        // </cbeEditValueSep>
        // <cbeDropDownMode>
        void OnDropDownModeSelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.DropDownShowMode = (TokenEditDropDownShowMode)comboBox.EditValue;
        }
        // </cbeDropDownMode>
        void UpdateEditValue() {
            string value = tokenEdit.EditValue as string;
            this.editValueLabel.Text = string.Format("Edit Value: {0}", string.IsNullOrEmpty(value) ? "(empty)" : value);
        }
        // <cbeEditMode>
        void OnEditModeSelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.EditMode = (TokenEditMode)comboBox.EditValue;
        }
        // </cbeEditMode>
        // <cbeGlyphLocation>
        void OnGlyphAlignmentMode_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.TokenGlyphLocation = (TokenEditGlyphLocation)comboBox.EditValue;
        }
        // </cbeGlyphLocation>
        // <cbeFontSize>
        void OnFontSizeSelectedIndexChanged(object sender, EventArgs e) {
            Font defaultFont = AppearanceObject.DefaultFont, newFont = null;
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            TokenEditFontSize fontSize = (TokenEditFontSize)comboBox.EditValue;
            switch(fontSize) {
                case TokenEditFontSize.Default:
                    newFont = defaultFont;
                    break;
                case TokenEditFontSize.Medium:
                    newFont = new Font(defaultFont.FontFamily, defaultFont.SizeInPoints + 2.5f);
                    break;
                case TokenEditFontSize.Large:
                    newFont = new Font(defaultFont.FontFamily, defaultFont.SizeInPoints + 3.75f);
                    break;
            }
            this.properties.Appearance.Font = this.properties.AppearanceDropDown.Font = newFont;
        }
        // </cbeFontSize>
        void AddEventEntry(string entry, object obj) {
            string val = string.Empty;
            if(obj != null) {
                val = (obj is TokenEdit) ? typeof(TokenEdit).Name : obj.ToString();
            }
            else {
                val = "(null)";
            }
            this.eventsLog.Text = string.Format("{0}: {1}{2}", entry, val, Environment.NewLine) + eventsLog.Text;
        }
    }

    internal enum TokenEditFontSize { Default, Medium, Large }
}
