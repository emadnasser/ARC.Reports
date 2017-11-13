using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;
using DevExpress.Utils;
namespace DevExpress.Xpo.Demos
{
    partial class frmMain
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // pnlCaption
            // 
            this.pnlCaption.Size = new System.Drawing.Size(800, 64);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Name = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;

    }
}
