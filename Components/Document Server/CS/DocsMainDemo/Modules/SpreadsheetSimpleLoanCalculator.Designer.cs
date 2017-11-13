using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetSimpleLoanCalculatorModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent() {
            this.loanAmount = new DevExpress.XtraEditors.LabelControl();
            this.annualInterestRate = new DevExpress.XtraEditors.LabelControl();
            this.loanPeriodinYears = new DevExpress.XtraEditors.LabelControl();
            this.startDateofLoan = new DevExpress.XtraEditors.LabelControl();
            this.loanAmountSE = new DevExpress.XtraEditors.SpinEdit();
            this.annualInterestRateSE = new DevExpress.XtraEditors.SpinEdit();
            this.startDateofLoanDE = new DevExpress.XtraEditors.DateEdit();
            this.loanPeriodinYearsSE = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.loanAmountSE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualInterestRateSE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateofLoanDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateofLoanDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanPeriodinYearsSE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loanAmount
            // 
            this.loanAmount.Location = new System.Drawing.Point(5, 15);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(67, 13);
            this.loanAmount.TabIndex = 8;
            this.loanAmount.Text = "Loan Amount:";
            // 
            // annualInterestRate
            // 
            this.annualInterestRate.Location = new System.Drawing.Point(5, 47);
            this.annualInterestRate.Name = "annualInterestRate";
            this.annualInterestRate.Size = new System.Drawing.Size(105, 13);
            this.annualInterestRate.TabIndex = 10;
            this.annualInterestRate.Text = "Annual Interest Rate:";
            // 
            // loanPeriodinYears
            // 
            this.loanPeriodinYears.Location = new System.Drawing.Point(251, 15);
            this.loanPeriodinYears.Name = "loanPeriodinYears";
            this.loanPeriodinYears.Size = new System.Drawing.Size(101, 13);
            this.loanPeriodinYears.TabIndex = 11;
            this.loanPeriodinYears.Text = "Loan Period in Years:";
            // 
            // startDateofLoan
            // 
            this.startDateofLoan.Location = new System.Drawing.Point(251, 47);
            this.startDateofLoan.Name = "startDateofLoan";
            this.startDateofLoan.Size = new System.Drawing.Size(93, 13);
            this.startDateofLoan.TabIndex = 12;
            this.startDateofLoan.Text = "Start Date of Loan:";
            // 
            // loanAmountSE
            // 
            this.loanAmountSE.EditValue = new decimal(new int[] {
            19900,
            0,
            0,
            0});
            this.loanAmountSE.Location = new System.Drawing.Point(121, 12);
            this.loanAmountSE.Name = "loanAmountSE";
            this.loanAmountSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.loanAmountSE.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.loanAmountSE.Properties.IsFloatValue = false;
            this.loanAmountSE.Properties.Mask.EditMask = "N00";
            this.loanAmountSE.Properties.MaxValue = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.loanAmountSE.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.loanAmountSE.Size = new System.Drawing.Size(100, 20);
            this.loanAmountSE.TabIndex = 34;
            this.loanAmountSE.ValueChanged += new System.EventHandler(this.loanAmountSE_EditValueChanged);
            // 
            // annualInterestRateSE
            // 
            this.annualInterestRateSE.EditValue = new decimal(new int[] {
            55,
            0,
            0,
            196608});
            this.annualInterestRateSE.Location = new System.Drawing.Point(121, 44);
            this.annualInterestRateSE.Name = "annualInterestRateSE";
            this.annualInterestRateSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.annualInterestRateSE.Properties.DisplayFormat.FormatString = "p";
            this.annualInterestRateSE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.annualInterestRateSE.Properties.EditFormat.FormatString = "p";
            this.annualInterestRateSE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.annualInterestRateSE.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.annualInterestRateSE.Properties.Mask.EditMask = "p";
            this.annualInterestRateSE.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.annualInterestRateSE.Size = new System.Drawing.Size(100, 20);
            this.annualInterestRateSE.TabIndex = 34;
            this.annualInterestRateSE.ValueChanged += new System.EventHandler(this.annualInterestRateSE_ValueChanged);
            // 
            // startDateofLoanDE
            // 
            this.startDateofLoanDE.EditValue = new System.DateTime(2013, 5, 15, 0, 0, 0, 0);
            this.startDateofLoanDE.Location = new System.Drawing.Point(361, 44);
            this.startDateofLoanDE.Name = "startDateofLoanDE";
            this.startDateofLoanDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateofLoanDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDateofLoanDE.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.startDateofLoanDE.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.startDateofLoanDE.Size = new System.Drawing.Size(100, 20);
            this.startDateofLoanDE.TabIndex = 16;
            this.startDateofLoanDE.EditValueChanged += new System.EventHandler(this.startDateofLoanTE_EditValueChanged);
            // 
            // loanPeriodinYearsSE
            // 
            this.loanPeriodinYearsSE.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.loanPeriodinYearsSE.Location = new System.Drawing.Point(361, 12);
            this.loanPeriodinYearsSE.Name = "loanPeriodinYearsSE";
            this.loanPeriodinYearsSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.loanPeriodinYearsSE.Properties.IsFloatValue = false;
            this.loanPeriodinYearsSE.Properties.Mask.EditMask = "N00";
            this.loanPeriodinYearsSE.Properties.MaxValue = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.loanPeriodinYearsSE.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loanPeriodinYearsSE.Size = new System.Drawing.Size(100, 20);
            this.loanPeriodinYearsSE.TabIndex = 34;
            this.loanPeriodinYearsSE.ValueChanged += new System.EventHandler(this.loanPeriodinYearsSE_ValueChanged);
            // 
            // SpreadsheetSimpleLoanCalculatorModule
            // 
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.annualInterestRate);
            this.Controls.Add(this.loanPeriodinYears);
            this.Controls.Add(this.startDateofLoan);
            this.Controls.Add(this.loanAmountSE);
            this.Controls.Add(this.startDateofLoanDE);
            this.Controls.Add(this.loanPeriodinYearsSE);
            this.Controls.Add(this.annualInterestRateSE);
            this.Name = "SpreadsheetSimpleLoanCalculatorModule";
            this.Controls.SetChildIndex(this.annualInterestRateSE, 0);
            this.Controls.SetChildIndex(this.loanPeriodinYearsSE, 0);
            this.Controls.SetChildIndex(this.startDateofLoanDE, 0);
            this.Controls.SetChildIndex(this.loanAmountSE, 0);
            this.Controls.SetChildIndex(this.startDateofLoan, 0);
            this.Controls.SetChildIndex(this.loanPeriodinYears, 0);
            this.Controls.SetChildIndex(this.annualInterestRate, 0);
            this.Controls.SetChildIndex(this.loanAmount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.loanAmountSE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualInterestRateSE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateofLoanDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateofLoanDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanPeriodinYearsSE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        LabelControl loanAmount;
        LabelControl annualInterestRate;
        LabelControl loanPeriodinYears;
        LabelControl startDateofLoan;
        SpinEdit loanAmountSE;
        SpinEdit annualInterestRateSE;
        SpinEdit loanPeriodinYearsSE;
        DateEdit startDateofLoanDE;
    }
}
