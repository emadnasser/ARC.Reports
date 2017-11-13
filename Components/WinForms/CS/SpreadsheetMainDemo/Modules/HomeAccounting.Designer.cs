namespace DevExpress.XtraSpreadsheet.Demos {
    partial class HomeAccountingModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being usedi
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.addIncomeButton = new DevExpress.XtraEditors.SimpleButton();
            this.addExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.readOnlyCheck = new DevExpress.XtraEditors.CheckEdit();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(0, 0);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(106, 23);
            this.addIncomeButton.TabIndex = 36;
            this.addIncomeButton.Text = "Add income (F7)";
            this.addIncomeButton.Click += new System.EventHandler(this.AddIncomeButtonClick);
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(110, 0);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(108, 23);
            this.addExpenseButton.TabIndex = 59;
            this.addExpenseButton.Text = "Add expense (F8)";
            this.addExpenseButton.Click += new System.EventHandler(this.AddExpensebuttonClick);
            // 
            // readOnlyCheck
            // 
            this.readOnlyCheck.EditValue = true;
            this.readOnlyCheck.Location = new System.Drawing.Point(221, 3);
            this.readOnlyCheck.Name = "readOnlyCheck";
            this.readOnlyCheck.Properties.Caption = "ReadOnly";
            this.readOnlyCheck.Size = new System.Drawing.Size(75, 19);
            this.readOnlyCheck.TabIndex = 60;
            this.readOnlyCheck.CheckedChanged += new System.EventHandler(this.ReadOnlyCheckCheckedChanged);
            // 
            // panel
            // 
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.addExpenseButton);
            this.panel.Controls.Add(this.readOnlyCheck);
            this.panel.Controls.Add(this.addIncomeButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(789, 28);
            this.panel.TabIndex = 61;
            // 
            // HomeAccountingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.panel);
            this.Name = "HomeAccountingModule";
            this.Size = new System.Drawing.Size(789, 611);
            ((System.ComponentModel.ISupportInitialize)(this.readOnlyCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SimpleButton addIncomeButton;
        private DevExpress.XtraEditors.SimpleButton addExpenseButton;
        DevExpress.XtraEditors.CheckEdit readOnlyCheck;
        private XtraEditors.PanelControl panel;
    }
}
