using System;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ActionDockPanel : XtraUserControl {
        public ActionDockPanel() {
            InitializeComponent();
        }
        public string TextActions {
            get { return meActions.EditValue.ToString(); }
            set { meActions.EditValue = value; }
        }
        void CustomHeaderButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            IButton button = GetButton(e);
            if(button != null)
                ShowAction(button, "Click");
        }
        void CustomHeaderButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            IButton button = GetButton(e);
            if(button != null)
                ShowAction(button, "Checked");
        }
        void CustomHeaderButtonUnchecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            IButton button = GetButton(e);
            if(button != null)
                ShowAction(button, "Unchecked");
        }
        IButton GetButton(ButtonEventArgs e) {
            ButtonEventArgs es = e as ButtonEventArgs;
            if(es == null) return null;
            return es.Button;
        }
        void ShowAction(IButton button, string action) {
            TextActions = button.Properties.Caption + "\t" + action + "\r\n" + TextActions;
        }
        public DevExpress.XtraBars.Docking2010.ButtonCollection Buttons { get { return dockPanel1.CustomHeaderButtons; } }
        private void simpleButton1_Click(object sender, EventArgs e) {
            meActions.EditValue = string.Empty;
        }
        public IButton Button { get { return dockPanel1.CustomHeaderButtons[0]; } }
    }
}
