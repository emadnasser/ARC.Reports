using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Rules;
using System.Collections.Generic;
using DevExpress.XtraBars;

namespace DevExpress.XtraSpellChecker.Demos {
	/// <summary>
	/// Summary description for Employees.
	/// </summary>
	public partial class CheckTextBox : BaseTutorialControl {
		public CheckTextBox() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}

        protected override void OnCheckedChanged(object sender, EventArgs e) {
            base.OnCheckedChanged(sender, e);
            if(spellChecker1.SpellCheckMode == SpellCheckMode.AsYouType)
                barManager1.SetPopupContextMenu(textBox1, popupMenu1);
            else
                barManager1.SetPopupContextMenu(textBox1, null);
        }
		protected override Control GetActiveControl() {
			return textBox1;
		}
        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }

        private void barManager1_QueryShowPopupMenu(object sender, DevExpress.XtraBars.QueryShowPopupMenuEventArgs e) {
            Point position = e.Control.PointToClient(e.Position);
            SpellCheckErrorBase error = spellChecker1.CalcError(position);
            e.Cancel = error == null;
            List<SpellCheckerCommand> commands = spellChecker1.GetCommandsByError(error);
            if(commands != null) {
                popupMenu1.ItemLinks.Clear();
                foreach(SpellCheckerCommand command in commands) {
                    BarButtonItem item = new BarButtonItem(barManager1, command.Caption);
                    item.Enabled = command.Enabled;
                    item.Tag = command;
                    item.ItemClick += new ItemClickEventHandler(OnPopupMenuItemClick);
                    popupMenu1.ItemLinks.Add(item);
                }
            }
        }

        void OnPopupMenuItemClick(object sender, ItemClickEventArgs e) {
            (e.Item.Tag as SpellCheckerCommand).DoCommand();
        }
	}
}
