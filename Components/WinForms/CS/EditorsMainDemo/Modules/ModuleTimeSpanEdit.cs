using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTimeSpanEdit: TutorialControl {
        TimeSpanEdit TimeSpanEdit { get { return timeSpanEdit; } }
        public ModuleTimeSpanEdit() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleTimeSpanEdit.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.timespanedit.xml";
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        void OnModuleLoad(object sender, EventArgs e) {
            SetDisplayFormat();
            ShowValue();
        }
        void OnTimeSpanEditEditValueChanged(object sender, EventArgs e) {
            ShowValue();
        }
        void ShowValue() {
            string result = string.Empty;
            if(TimeSpanEdit.EditValue != null)
                result = TimeSpanEdit.EditValue.ToString();
            lbValue.Text = result;
        }
        // <cbEditFormat>
        void OnEditFormatChanged(object sender, EventArgs e) {
            SetEditFormat();
        }
        void SetEditFormat() {
            string[] formats = new string[] { 
                "",
                "dd.HH:mm:ss",
                "dd.HH:mm",
                "HH:mm:ss",
                "HH:mm", 
                "mm:ss", 
                "dd", 
                "HH", 
                "mm", 
                "ss" 
            };
            int index = cbEditFormat.SelectedIndex;
            TimeSpanEdit.Properties.Mask.MaskType = Mask.MaskType.Custom;
            teEditFormatString.Text = TimeSpanEdit.Properties.Mask.EditMask = formats[index];
        }
        // </cbEditFormat>
        // <cbDisplayFormat>
        void OnDisplayFormatChanged(object sender, EventArgs e) {
            SetDisplayFormat();
        }
        void SetDisplayFormat() {
            string[] formats = new string[] { 
                "",
                "{0:dd}.{0:hh}:{0:mm}:{0:ss}",
                "{0:dd}.{0:hh}:{0:mm}", 
                "{0:hh}:{0:mm}:{0:ss}",
                "{0:hh}:{0:mm}", 
                "{0:mm}:{0:ss}", 
                "{0:dd} days", 
                "{0:hh} hours", 
                "{0:mm} minutes", 
                "{0:ss} seconds" 
            };
            int index = cbDisplayFormat.SelectedIndex;
            TimeSpanEdit.Properties.DisplayFormat.FormatType = Utils.FormatType.Custom;
            teDisplayFormatString.Text = TimeSpanEdit.Properties.DisplayFormat.FormatString = formats[index];
        }
        // </cbDisplayFormat>
        // <seMaxDays>
        void OnMaxDaysValueChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.MaxDays = (int)seMaxDays.Value;
        }
        // </seMaxDays>
        // <seMaxHours>
        void OnMaxHoursValueChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.MaxHours = (int)seMaxHours.Value;
        }
        // </seMaxHours>
        // <seMaxMinutes>
        void OnMaxMinutesValueChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.MaxMinutes = (int)seMaxMinutes.Value;
        }
        // </seMaxMinutes>
        // <seMaxSeconds>
        void OnMaxSecondsValueChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.MaxSeconds = (int)seMaxSeconds.Value;
        }
        // </seMaxSeconds>
        // <ceAllowEditDays>
        void OnAllowEditDaysChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.AllowEditDays = !TimeSpanEdit.Properties.AllowEditDays;
        }
        // </ceAllowEditDays>
        // <ceAllowEditHours>
        void OnAllowEditHoursChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.AllowEditHours = !TimeSpanEdit.Properties.AllowEditHours;
        }
        // </ceAllowEditHours>
        // <ceAllowEditMinutes>
        void OnAllowEditMinutesChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.AllowEditMinutes = !TimeSpanEdit.Properties.AllowEditMinutes;
        }
        // </ceAllowEditMinutes>
        // <ceAllowEditSeconds>
        void OnAllowEditSecondsChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.AllowEditSeconds = !TimeSpanEdit.Properties.AllowEditSeconds;
        }
        // </ceAllowEditSeconds>
        // <ceReadOnly>
        void OnReadOnlyChanged(object sender, EventArgs e) {
            TimeSpanEdit.Properties.ReadOnly = !TimeSpanEdit.Properties.ReadOnly;
            cbEditFormat.Enabled = !cbEditFormat.Enabled;
        }
        // </ceReadOnly>
    }
}
