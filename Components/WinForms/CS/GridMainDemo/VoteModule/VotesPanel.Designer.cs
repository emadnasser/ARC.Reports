namespace DevExpress.VoteApp {
    partial class VotesPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbVotesLeft = new DevExpress.XtraEditors.LabelControl();
            this.lbVotesRight = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbVotesLeft
            // 
            this.lbVotesLeft.AllowHtmlString = true;
            this.lbVotesLeft.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVotesLeft.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbVotesLeft.Appearance.Options.UseFont = true;
            this.lbVotesLeft.Appearance.Options.UseForeColor = true;
            this.lbVotesLeft.Appearance.Options.UseTextOptions = true;
            this.lbVotesLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lbVotesLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.lbVotesLeft.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbVotesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVotesLeft.Location = new System.Drawing.Point(0, 0);
            this.lbVotesLeft.Name = "lbVotesLeft";
            this.lbVotesLeft.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lbVotesLeft.Size = new System.Drawing.Size(212, 93);
            this.lbVotesLeft.TabIndex = 1;
            this.lbVotesLeft.Text = "<b>100</b> <size=-5><i>Electoral Votes";
            // 
            // lbVotesRight
            // 
            this.lbVotesRight.AllowHtmlString = true;
            this.lbVotesRight.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVotesRight.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbVotesRight.Appearance.Options.UseFont = true;
            this.lbVotesRight.Appearance.Options.UseForeColor = true;
            this.lbVotesRight.Appearance.Options.UseTextOptions = true;
            this.lbVotesRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbVotesRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lbVotesRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.lbVotesRight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbVotesRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbVotesRight.Location = new System.Drawing.Point(212, 0);
            this.lbVotesRight.Name = "lbVotesRight";
            this.lbVotesRight.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lbVotesRight.Size = new System.Drawing.Size(152, 93);
            this.lbVotesRight.TabIndex = 2;
            this.lbVotesRight.Text = "<size=-5>Electoral Votes</size> <b>100</b>";
            // 
            // VotesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbVotesLeft);
            this.Controls.Add(this.lbVotesRight);
            this.Name = "VotesPanel";
            this.Size = new System.Drawing.Size(364, 93);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VotesPanel_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbVotesLeft;
        private DevExpress.XtraEditors.LabelControl lbVotesRight;
    }
}
