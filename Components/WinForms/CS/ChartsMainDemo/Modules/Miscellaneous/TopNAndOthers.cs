using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	public partial class TopNAndOthersDemo : ChartDemoBase2D {
        ChartControl chart;

        TopNOptions Options { 
            get { 
                return ChartControl.Series.Count > 0 ? ChartControl.Series[0].TopNOptions : null; 
            } 
        }

        public override ChartControl ChartControl { get { return this.chart; } }

		public TopNAndOthersDemo() {
			InitializeComponent();
		}
		
        void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (Options == null)
                return;
            TopNMode mode = (TopNMode)comboBoxMode.SelectedIndex;
            Options.Mode = mode;
            labelValue.Text = (string)comboBoxMode.SelectedItem + ":";
            txtValue.Properties.BeginInit();
            switch (mode) {
                case TopNMode.Count:
                    txtValue.Properties.IsFloatValue = false;
                    txtValue.Properties.MinValue = 1;
                    txtValue.Properties.MaxValue = 20;
                    txtValue.Properties.Increment = 1;
                    txtValue.Properties.Mask.EditMask = "f0";
                    txtValue.EditValue = Options.Count;
                    break;
                case TopNMode.ThresholdValue:
                    txtValue.Properties.IsFloatValue = true;
                    txtValue.Properties.MinValue = 2000;
                    txtValue.Properties.MaxValue = 20000;
                    txtValue.Properties.Increment = 500;
                    txtValue.Properties.Mask.EditMask = "f0";
                    txtValue.EditValue = Options.ThresholdValue;
                    break;
                case TopNMode.ThresholdPercent:
                    txtValue.Properties.IsFloatValue = true;
                    txtValue.Properties.MinValue = new decimal(1.5);
                    txtValue.Properties.MaxValue = 100;
                    txtValue.Properties.Increment = new decimal(0.1);
                    txtValue.Properties.Mask.EditMask = "f1";
                    txtValue.EditValue = Options.ThresholdPercent;
                    break;
                default:
                    txtValue.Enabled = false;
                    break;
            }
            txtValue.Properties.EndInit();
        }
        void txtValue_EditValueChanged(object sender, EventArgs e) {
            if (Options != null)
                switch (Options.Mode) {
                    case TopNMode.Count:
                        Options.Count = Convert.ToInt32(txtValue.EditValue);
                        break;
                    case TopNMode.ThresholdValue:
                        Options.ThresholdValue = Convert.ToDouble(txtValue.EditValue);
                        break;
                    case TopNMode.ThresholdPercent:
                        Options.ThresholdPercent = Convert.ToDouble(txtValue.EditValue);
                        break;
                }
        }
        void checkEditShowOthers_CheckedChanged(object sender, EventArgs e) {
            if (Options == null)
                return;
            Options.ShowOthers = checkEditShowOthers.Checked;
            if (Options.ShowOthers) {
                labelOthersArgument.Enabled = true;
                txtOthersArgument.Enabled = true;
                if (String.IsNullOrEmpty(Options.OthersArgument))
                    txtOthersArgument.EditValue = "Others";
                else
                    txtOthersArgument.EditValue = Options.OthersArgument;
            }
            else {
                labelOthersArgument.Enabled = false;
                txtOthersArgument.Enabled = false;
            }
        }
        void txtOthersArgument_EditValueChanged(object sender, EventArgs e) {
            if (Options != null)
                Options.OthersArgument = (string)txtOthersArgument.EditValue;
        }

        protected override void InitControls() {
            base.InitControls();
            chart.DataSource = dS21.Countries;
            string path = Utils.GetRelativePath("countriesDB.mdb");
            if (path.Length > 0)
                Utils.SetConnectionString(this.oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"countriesDB.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                this.oleDbDataAdapter1.Fill(this.dS21);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboBoxMode.SelectedIndex = 0;
            if (chart.Series.Count > 0)
                checkEditShowOthers.Checked = chart.Series[0].TopNOptions.ShowOthers;
            ShowLabels = true;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (Options != null) {
                comboBoxMode.SelectedIndex = (int)Options.Mode;
                checkEditShowOthers.Checked = Options.ShowOthers;
                txtOthersArgument.EditValue = Options.OthersArgument;
            }
        }
	}
}
