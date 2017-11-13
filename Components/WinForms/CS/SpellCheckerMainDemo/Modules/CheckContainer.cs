using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System.Text;
using System.Collections.Generic;


namespace DevExpress.XtraSpellChecker.Demos {
    /// <summary>
    /// Summary description for Employees.
    /// </summary>
    public partial class CheckContainer : BaseTutorialControl {
        BaseEdit inplaceEditor;
        public CheckContainer() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            string path = DemoUtils.GetRelativePath("nwind.mdb");
            if (path.Length > 0)
                DemoUtils.SetConnectionString(oleDbEmployeesConnection, path);
            // TODO: Add any initialization after the InitForm call

        }

        protected void OnEditControlKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            OnEditorKeyDown(sender, e);
        }
        private void CheckContainer_Load(object sender, System.EventArgs e) {
            daEmployees.Fill(dsEmployees1);
            DoMistakes(dsEmployees1.Employees);
        }
        protected override Control GetActiveControl() {
            return gridControl1.FocusedView.IsEditing ? gridControl1.FocusedView.ActiveEditor : ActiveControl;
        }
        private void gridView1_ShownEditor(object sender, EventArgs e) {
            BaseEdit activeEditor = ((GridView)sender).ActiveEditor;
            if (!spellChecker1.CanCheck(activeEditor))
                return;
            spellChecker1.SetShowSpellCheckMenu(activeEditor, true);
            if (spellChecker1.SpellCheckMode == SpellCheckMode.AsYouType && !Object.ReferenceEquals(activeEditor, this.inplaceEditor))
                DoCheck();
            this.inplaceEditor = activeEditor;
        }

        private void gridView1_HiddenEditor(object sender, EventArgs e) {
            //
        }
        void DoMistakes(DataTable dataTable) {
            foreach (DataRow row in dataTable.Rows) {
                StringBuilder text = new StringBuilder(row["Notes"].ToString());
                List<char> charSet = CreateCharSet(text);
                for (int i = text.Length - 1; i >= 0; i -= 30) {
                    if (!Char.IsLetter(text[i]))
                        continue;
                    char ch = GetRandomChar(charSet);
                    if (Char.IsUpper(text[i]))
                        ch = Char.ToUpper(ch);
                    if (text[i] == ch)
                        text.Remove(i, 1);
                    else
                        text[i] = ch;
                }
                row["Notes"] = text.ToString();
            }
        }
        List<char> CreateCharSet(StringBuilder text) {
            List<char> result = new List<char>();
            int length = text.Length;
            for (int i = 0; i < length; i++) {
                char ch = text[i];
                if (!Char.IsLetter(ch))
                    continue;
                ch = Char.ToLower(ch);
                int index = result.BinarySearch(ch);
                if (index < 0)
                    result.Insert(~index, ch);
            }
            return result;
        }
        char GetRandomChar(List<char> charSet) {
            Random random = new Random(Environment.TickCount);
            int index = random.Next(0, charSet.Count - 1);
            return charSet[index];
        }
    }
}
