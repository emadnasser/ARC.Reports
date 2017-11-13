using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class AutoSizeModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        //bool trackBarEditValue;
        //bool autoSizeModulSizeChange;
        public AutoSizeModule() {
            InitializeComponent();
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }
        
        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }
       
        private void rgrpAutoSizeType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (rgrpAutoSizeType.SelectedIndex) {
                case 0:
                    richEditControl.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.None;
                    break;
                case 1:
                    richEditControl.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Both;
                    break;
                case 2:
                    richEditControl.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Vertical;
                    break;
                case 3:
                    richEditControl.AutoSizeMode = DevExpress.XtraRichEdit.AutoSizeMode.Horizontal;
                    break;
            }
        }
        protected override void DoShow() {
            base.DoShow();
            richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richEditControl.MaximumSize = new System.Drawing.Size(richEditControl.Width, richEditControl.Height);
            richEditControl.Focus();
        }
        
        private void chedWordWrap_CheckedChanged(object sender, EventArgs e) {
            richEditControl.Views.SimpleView.WordWrap = chedWordWrap.Checked;
        }

        private void richEditControl_Resize(object sender, EventArgs e) {
            //richEditControl.MaximumSize = new System.Drawing.Size(richEditControl.Width, richEditControl.Height);
            //if (!trackBarEditValue) {
            //    trackBarControl1.Properties.Minimum = 0;
            //    trackBarControl1.Properties.Maximum = richEditControl.Width;
            //    trackBarControl2.Properties.Minimum = 0;
            //    trackBarControl2.Properties.Maximum = richEditControl.Height;
            //}
            
            //trackBarControl1.Value = richEditControl.Width;
            //trackBarControl2.Value = trackBarControl2.Properties.Maximum - richEditControl.Height;
            //trackBarEditValue = false;
        }

        private void trackBarControl1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
           // richEditControl.Dock = System.Windows.Forms.DockStyle.None;
            //trackBarEditValue = true;
            richEditControl.MaximumSize = new System.Drawing.Size(trackBarControlHorizontal.Value, richEditControl.MaximumSize.Height);
            richEditControl.Resize += new System.EventHandler(richEditControl_Resize);
            //trackBarEditValue = false;
        }

        private void trackBarControl2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
            //trackBarEditValue = true;
            richEditControl.MaximumSize = new System.Drawing.Size(richEditControl.MaximumSize.Width, trackBarControlVertical.Properties.Maximum - trackBarControlVertical.Value);
            richEditControl.Resize += new System.EventHandler(richEditControl_Resize);
        }

        private void AutoSizeModule_SizeChanged(object sender, EventArgs e) {
            trackBarControlHorizontal.Properties.Maximum = panelControl1.Width - panelControl3.Width;
            trackBarControlHorizontal.Value = richEditControl.MaximumSize.Width;
            trackBarControlVertical.Properties.Maximum = panelControl1.Height - panelControl4.Height;
            trackBarControlVertical.Value = trackBarControlVertical.Properties.Maximum - richEditControl.MaximumSize.Height;

        }
                        
    }
}
