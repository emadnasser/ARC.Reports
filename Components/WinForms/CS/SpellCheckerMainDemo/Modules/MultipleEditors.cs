using System;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraEditors;
using DevExpress.Utils;


namespace DevExpress.XtraSpellChecker.Demos {
    public partial class MultipleEditors : DevExpress.XtraSpellChecker.Demos.BaseTutorialControl {
        public MultipleEditors() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        private void MultipleEditors_Load(object sender, System.EventArgs e) {
            picPhoto.Image = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraSpellChecker.Demos.Images.nancy.png", System.Reflection.Assembly.GetExecutingAssembly());
        }

        protected override bool ProcessDialogKey(Keys keyData) {
            if (keyData == Keys.F7 && Control.ModifierKeys == Keys.None)
                DoCheck();
            return base.ProcessDialogKey(keyData);
        }
        protected override void DoCheck() {
            spellChecker1.CheckContainer();
        }
        protected override void OnCheckedChanged(object sender, EventArgs e) {
            bool isChecked = (sender as CheckEdit).Checked;
            spellChecker1.SpellCheckMode = isChecked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
            btnCheckSpelling.Enabled = !isChecked;
        }
    }
}
