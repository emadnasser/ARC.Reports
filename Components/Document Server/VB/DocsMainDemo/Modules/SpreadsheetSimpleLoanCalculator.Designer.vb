Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetSimpleLoanCalculatorModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		''' 
		Private Sub InitializeComponent()
			Me.loanAmount = New DevExpress.XtraEditors.LabelControl()
			Me.annualInterestRate = New DevExpress.XtraEditors.LabelControl()
			Me.loanPeriodinYears = New DevExpress.XtraEditors.LabelControl()
			Me.startDateofLoan = New DevExpress.XtraEditors.LabelControl()
			Me.loanAmountSE = New DevExpress.XtraEditors.SpinEdit()
			Me.annualInterestRateSE = New DevExpress.XtraEditors.SpinEdit()
			Me.startDateofLoanDE = New DevExpress.XtraEditors.DateEdit()
			Me.loanPeriodinYearsSE = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.loanAmountSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.annualInterestRateSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.startDateofLoanDE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.startDateofLoanDE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.loanPeriodinYearsSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' loanAmount
			' 
			Me.loanAmount.Location = New System.Drawing.Point(5, 15)
			Me.loanAmount.Name = "loanAmount"
			Me.loanAmount.Size = New System.Drawing.Size(67, 13)
			Me.loanAmount.TabIndex = 8
			Me.loanAmount.Text = "Loan Amount:"
			' 
			' annualInterestRate
			' 
			Me.annualInterestRate.Location = New System.Drawing.Point(5, 47)
			Me.annualInterestRate.Name = "annualInterestRate"
			Me.annualInterestRate.Size = New System.Drawing.Size(105, 13)
			Me.annualInterestRate.TabIndex = 10
			Me.annualInterestRate.Text = "Annual Interest Rate:"
			' 
			' loanPeriodinYears
			' 
			Me.loanPeriodinYears.Location = New System.Drawing.Point(251, 15)
			Me.loanPeriodinYears.Name = "loanPeriodinYears"
			Me.loanPeriodinYears.Size = New System.Drawing.Size(101, 13)
			Me.loanPeriodinYears.TabIndex = 11
			Me.loanPeriodinYears.Text = "Loan Period in Years:"
			' 
			' startDateofLoan
			' 
			Me.startDateofLoan.Location = New System.Drawing.Point(251, 47)
			Me.startDateofLoan.Name = "startDateofLoan"
			Me.startDateofLoan.Size = New System.Drawing.Size(93, 13)
			Me.startDateofLoan.TabIndex = 12
			Me.startDateofLoan.Text = "Start Date of Loan:"
			' 
			' loanAmountSE
			' 
			Me.loanAmountSE.EditValue = New Decimal(New Integer() { 19900, 0, 0, 0})
			Me.loanAmountSE.Location = New System.Drawing.Point(121, 12)
			Me.loanAmountSE.Name = "loanAmountSE"
			Me.loanAmountSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.loanAmountSE.Properties.Increment = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.loanAmountSE.Properties.IsFloatValue = False
			Me.loanAmountSE.Properties.Mask.EditMask = "N00"
			Me.loanAmountSE.Properties.MaxValue = New Decimal(New Integer() { 200000, 0, 0, 0})
			Me.loanAmountSE.Properties.MinValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.loanAmountSE.Size = New System.Drawing.Size(100, 20)
			Me.loanAmountSE.TabIndex = 34
'			Me.loanAmountSE.ValueChanged += New System.EventHandler(Me.loanAmountSE_EditValueChanged);
			' 
			' annualInterestRateSE
			' 
			Me.annualInterestRateSE.EditValue = New Decimal(New Integer() { 55, 0, 0, 196608})
			Me.annualInterestRateSE.Location = New System.Drawing.Point(121, 44)
			Me.annualInterestRateSE.Name = "annualInterestRateSE"
			Me.annualInterestRateSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.annualInterestRateSE.Properties.DisplayFormat.FormatString = "p"
			Me.annualInterestRateSE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.annualInterestRateSE.Properties.EditFormat.FormatString = "p"
			Me.annualInterestRateSE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.annualInterestRateSE.Properties.Increment = New Decimal(New Integer() { 1, 0, 0, 196608})
			Me.annualInterestRateSE.Properties.Mask.EditMask = "p"
			Me.annualInterestRateSE.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.annualInterestRateSE.Size = New System.Drawing.Size(100, 20)
			Me.annualInterestRateSE.TabIndex = 34
'			Me.annualInterestRateSE.ValueChanged += New System.EventHandler(Me.annualInterestRateSE_ValueChanged);
			' 
			' startDateofLoanDE
			' 
			Me.startDateofLoanDE.EditValue = New System.DateTime(2013, 5, 15, 0, 0, 0, 0)
			Me.startDateofLoanDE.Location = New System.Drawing.Point(361, 44)
			Me.startDateofLoanDE.Name = "startDateofLoanDE"
			Me.startDateofLoanDE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.startDateofLoanDE.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.startDateofLoanDE.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
			Me.startDateofLoanDE.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default
			Me.startDateofLoanDE.Size = New System.Drawing.Size(100, 20)
			Me.startDateofLoanDE.TabIndex = 16
'			Me.startDateofLoanDE.EditValueChanged += New System.EventHandler(Me.startDateofLoanTE_EditValueChanged);
			' 
			' loanPeriodinYearsSE
			' 
			Me.loanPeriodinYearsSE.EditValue = New Decimal(New Integer() { 2, 0, 0, 0})
			Me.loanPeriodinYearsSE.Location = New System.Drawing.Point(361, 12)
			Me.loanPeriodinYearsSE.Name = "loanPeriodinYearsSE"
			Me.loanPeriodinYearsSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.loanPeriodinYearsSE.Properties.IsFloatValue = False
			Me.loanPeriodinYearsSE.Properties.Mask.EditMask = "N00"
			Me.loanPeriodinYearsSE.Properties.MaxValue = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.loanPeriodinYearsSE.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.loanPeriodinYearsSE.Size = New System.Drawing.Size(100, 20)
			Me.loanPeriodinYearsSE.TabIndex = 34
'			Me.loanPeriodinYearsSE.ValueChanged += New System.EventHandler(Me.loanPeriodinYearsSE_ValueChanged);
			' 
			' SpreadsheetSimpleLoanCalculatorModule
			' 
			Me.Controls.Add(Me.loanAmount)
			Me.Controls.Add(Me.annualInterestRate)
			Me.Controls.Add(Me.loanPeriodinYears)
			Me.Controls.Add(Me.startDateofLoan)
			Me.Controls.Add(Me.loanAmountSE)
			Me.Controls.Add(Me.startDateofLoanDE)
			Me.Controls.Add(Me.loanPeriodinYearsSE)
			Me.Controls.Add(Me.annualInterestRateSE)
			Me.Name = "SpreadsheetSimpleLoanCalculatorModule"
			Me.Controls.SetChildIndex(Me.annualInterestRateSE, 0)
			Me.Controls.SetChildIndex(Me.loanPeriodinYearsSE, 0)
			Me.Controls.SetChildIndex(Me.startDateofLoanDE, 0)
			Me.Controls.SetChildIndex(Me.loanAmountSE, 0)
			Me.Controls.SetChildIndex(Me.startDateofLoan, 0)
			Me.Controls.SetChildIndex(Me.loanPeriodinYears, 0)
			Me.Controls.SetChildIndex(Me.annualInterestRate, 0)
			Me.Controls.SetChildIndex(Me.loanAmount, 0)
			CType(Me.loanAmountSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.annualInterestRateSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.startDateofLoanDE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.startDateofLoanDE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.loanPeriodinYearsSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private loanAmount As LabelControl
		Private annualInterestRate As LabelControl
		Private loanPeriodinYears As LabelControl
		Private startDateofLoan As LabelControl
		Private WithEvents loanAmountSE As SpinEdit
		Private WithEvents annualInterestRateSE As SpinEdit
		Private WithEvents loanPeriodinYearsSE As SpinEdit
		Private WithEvents startDateofLoanDE As DateEdit
	End Class
End Namespace
