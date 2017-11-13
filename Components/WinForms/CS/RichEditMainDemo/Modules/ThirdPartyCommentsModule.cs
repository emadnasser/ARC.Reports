using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraSpellChecker.Parser;
using DevExpress.XtraRichEdit.SpellChecker;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ThirdPartyCommentsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ThirdPartyCommentsModule() {
            InitializeComponent();
            this.ribbonControl1.SelectedPage = this.ribbonControl1.Pages["Review"];
            richEditControl.EmptyDocumentCreated += new EventHandler(OnRichEditControlEmptyDocumentCreated);
            richEditControl.DocumentLoaded += new EventHandler(OnRichEditControlDocumentLoaded);
            UpdateAuthor(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            UpdateCommentVisibility();
            UpdateHighlightCommentedRange();
            UpdateCommentColor();
            richEditControl.ShowReviewingPaneForm();
            dockPanel2.Options.ShowCloseButton = false;
            OpenXmlLoadHelper.Load("Comments.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        void OnRichEditControlEmptyDocumentCreated(object sender, EventArgs e) {
            FillComboBoxEditAuthors();
        }
        void OnRichEditControlDocumentLoaded(object sender, EventArgs e) {
            FillComboBoxEditAuthors();          
        }
        void FillComboBoxEditAuthors() {
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox properties = comboBoxEditAuthors.Properties;
            properties.Items.Clear();
            properties.Items.Add(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            properties.Items.AddRange(richEditControl.Options.Comments.VisibleAuthors);
            comboBoxEditAuthors.SelectedIndex = 0;
            UpdateAuthor(this.comboBoxEditAuthors.EditValue.ToString());
            properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;           
        }
        void UpdateAuthor(string author) {
            richEditControl.Options.Comments.Author = author;
        }
        void UpdateHighlightCommentedRange() {
            richEditControl.Options.Comments.HighlightCommentedRange = chkHighlightCommentedRange.Checked;
        }
        private void UpdateCommentVisibility() {
            this.richEditControl.Options.Comments.Visibility = chkViewComments.Checked ? RichEditCommentVisibility.Visible : RichEditCommentVisibility.Hidden;
        }
        private void UpdateCommentColor() {
            if (chkResetColor.Checked)
                this.richEditControl.Options.Comments.ResetColor();
            else
                this.richEditControl.Options.Comments.Color = colorEdit1.Color;
        }
        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        private void comboBoxEditAuthors_EditValueChanged(object sender, EventArgs e) {
            UpdateAuthor(this.comboBoxEditAuthors.EditValue.ToString());
        }

        private void chkViewComments_CheckedChanged(object sender, EventArgs e) {
            UpdateCommentVisibility();
            chkHighlightCommentedRange.Enabled = !chkViewComments.Checked;
        }

        private void chkHighlightCommentedRange_CheckedChanged(object sender, EventArgs e) {
            UpdateHighlightCommentedRange();
        }

        private void colorEdit1_ColorChanged(object sender, EventArgs e) {
            chkResetColor.Checked = false;
            UpdateCommentColor();
        }

        private void chkResetColor_CheckedChanged(object sender, EventArgs e) {
            UpdateCommentColor();
        }            
    }
}
