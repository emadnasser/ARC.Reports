Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HomeAccountingModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being usedi
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.addIncomeButton = New DevExpress.XtraEditors.SimpleButton()
			Me.addExpenseButton = New DevExpress.XtraEditors.SimpleButton()
			Me.readOnlyCheck = New DevExpress.XtraEditors.CheckEdit()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.readOnlyCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' addIncomeButton
			' 
			Me.addIncomeButton.Location = New System.Drawing.Point(0, 0)
			Me.addIncomeButton.Name = "addIncomeButton"
			Me.addIncomeButton.Size = New System.Drawing.Size(106, 23)
			Me.addIncomeButton.TabIndex = 36
			Me.addIncomeButton.Text = "Add income (F7)"
'			Me.addIncomeButton.Click += New System.EventHandler(Me.AddIncomeButtonClick);
			' 
			' addExpenseButton
			' 
			Me.addExpenseButton.Location = New System.Drawing.Point(110, 0)
			Me.addExpenseButton.Name = "addExpenseButton"
			Me.addExpenseButton.Size = New System.Drawing.Size(108, 23)
			Me.addExpenseButton.TabIndex = 59
			Me.addExpenseButton.Text = "Add expense (F8)"
'			Me.addExpenseButton.Click += New System.EventHandler(Me.AddExpensebuttonClick);
			' 
			' readOnlyCheck
			' 
			Me.readOnlyCheck.EditValue = True
			Me.readOnlyCheck.Location = New System.Drawing.Point(221, 3)
			Me.readOnlyCheck.Name = "readOnlyCheck"
			Me.readOnlyCheck.Properties.Caption = "ReadOnly"
			Me.readOnlyCheck.Size = New System.Drawing.Size(75, 19)
			Me.readOnlyCheck.TabIndex = 60
'			Me.readOnlyCheck.CheckedChanged += New System.EventHandler(Me.ReadOnlyCheckCheckedChanged);
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.addExpenseButton)
			Me.panel.Controls.Add(Me.readOnlyCheck)
			Me.panel.Controls.Add(Me.addIncomeButton)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(789, 28)
			Me.panel.TabIndex = 61
			' 
			' HomeAccountingModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.panel)
			Me.Name = "HomeAccountingModule"
			Me.Size = New System.Drawing.Size(789, 611)
			CType(Me.readOnlyCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		Private WithEvents addIncomeButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents addExpenseButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents readOnlyCheck As DevExpress.XtraEditors.CheckEdit
		Private panel As XtraEditors.PanelControl
	End Class
End Namespace
