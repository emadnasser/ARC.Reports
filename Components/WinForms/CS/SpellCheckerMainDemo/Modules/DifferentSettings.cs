using System;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;
using DevExpress.Utils;
using DevExpress.XtraEditors;


namespace DevExpress.XtraSpellChecker.Demos {
    public partial class DifferentSettings : DevExpress.XtraSpellChecker.Demos.BaseTutorialControl {
        public DifferentSettings() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        protected override void DoCheck() {
            spellChecker1.CheckContainer(panelControl2);
        }

        protected override bool ProcessDialogKey(Keys keyData) {
            if (keyData == Keys.F7 && Control.ModifierKeys == Keys.None)
                DoCheck();
            return base.ProcessDialogKey(keyData);
        }

        private void DifferentSettings_Load(object sender, EventArgs e) {
            picPhoto.Image = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraSpellChecker.Demos.Images.ferrari_360_spider.gif", System.Reflection.Assembly.GetExecutingAssembly());
        }
        protected override void OnCheckedChanged(object sender, EventArgs e) {
            bool isChecked = (sender as CheckEdit).Checked;
            spellChecker1.SpellCheckMode = isChecked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
            btnCheckSpelling.Enabled = !isChecked;
        }
    }
}
