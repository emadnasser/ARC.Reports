using DevExpress.XtraLayout.Demos.Modules;
using System;

namespace DevExpress.XtraLayout.Demos {
    public partial class Multilanguage : TutorialControl {
        public Multilanguage() {
            InitializeComponent();
            showFormButton.Click += new System.EventHandler(showButton_Click);
            sizeModeRadioGroup.SelectedIndex = 1;
            dpiModeRadioGroup.SelectedIndex = 1;
        }
        private void showButton_Click(object sender, EventArgs e) {
            AppDomain ad = AppDomain.CreateDomain("New domain");
            MultilanguageFormLoader l = (MultilanguageFormLoader)ad.CreateInstanceAndUnwrap(typeof(MultilanguageFormLoader).Assembly.FullName, "DevExpress.XtraLayout.Demos.Modules.MultilanguageFormLoader");
            l.Load(localizationModeRadioGroup.SelectedIndex, layoutModeRadioGroup.SelectedIndex, sizeModeRadioGroup.SelectedIndex, dpiModeRadioGroup.SelectedIndex);
        }
    }
}
