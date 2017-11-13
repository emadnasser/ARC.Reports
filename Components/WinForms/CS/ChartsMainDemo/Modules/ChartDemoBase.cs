using System;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class ChartDemoBase : TutorialControl {
        protected PanelControl panel;
        protected CheckEdit checkEditShowLabels;

        protected bool CheckEditShowLabelsVisible {
            get { return checkEditShowLabels.Visible; }
            set { checkEditShowLabels.Visible = value; }
        }
        protected bool ShowLabels { 
            get { return checkEditShowLabels.Checked; } 
            set { checkEditShowLabels.Checked = value; } 
        }
        protected virtual DefaultBoolean CrosshairEnabled { get { return DefaultBoolean.Default; } }
        protected virtual DefaultBoolean ToolTipEnabled { get { return DefaultBoolean.Default; } }

        public virtual bool AnimateChartControlOnDemoAppear { get { return true; } }
        public string AppearanceName {
            get { return ChartControl == null ? String.Empty : ChartControl.AppearanceName; }
            set { SetAppearanceName(value); }
        }
        public string PaletteName {
            get { return ChartControl == null ? String.Empty : ChartControl.PaletteName; }
            set { SetPaletteName(value); }
        }

        public ChartDemoBase() {
            InitializeComponent();
        }
        protected virtual void ChartDemoBase_Load(object sender, EventArgs e) {
            if (ChartControl != null && !DesignMode) {
                InitControls();
                UpdateControls();
            }
        }
        protected virtual void SetAppearanceName(string appearanceName) {
            if (ChartControl != null)
                ChartControl.AppearanceName = appearanceName;
        }
        protected virtual void SetPaletteName(string paletteName) {
            if (ChartControl != null)
                ChartControl.PaletteName = paletteName;
        }
        protected virtual void checkEditShowLabels_CheckedChanged(object sender, EventArgs e) {
            foreach (Series series in ChartControl.Series)
                if (series.Label != null)
                    series.LabelsVisibility = checkEditShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            if (!string.IsNullOrWhiteSpace(ChartControl.SeriesDataMember) && ChartControl.DataSource != null)
                ChartControl.SeriesTemplate.LabelsVisibility = checkEditShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            ChartControl.CrosshairEnabled = checkEditShowLabels.Checked ? DefaultBoolean.False : CrosshairEnabled;
            ChartControl.ToolTipEnabled = checkEditShowLabels.Checked ? DefaultBoolean.False : ToolTipEnabled;
            UpdateControls();
        }        
        protected virtual void InitControls() {
        }
        public virtual void UpdateControls() {
        }
    }
}
