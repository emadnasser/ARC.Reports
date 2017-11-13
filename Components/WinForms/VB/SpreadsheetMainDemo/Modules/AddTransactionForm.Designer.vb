Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class AddTransactionForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.categoryComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.categoryLabel = New DevExpress.XtraEditors.LabelControl()
			Me.sumEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.sumLabel = New DevExpress.XtraEditors.LabelControl()
			Me.monthLabel = New DevExpress.XtraEditors.LabelControl()
			Me.monthComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.dayLabel = New DevExpress.XtraEditors.LabelControl()
			Me.OKButton = New DevExpress.XtraEditors.SimpleButton()
			Me.CnclButton = New DevExpress.XtraEditors.SimpleButton()
			Me.dayTextEdit = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.categoryComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sumEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.monthComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dayTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' categoryComboBox
			' 
			Me.categoryComboBox.EditValue = ""
			Me.categoryComboBox.Location = New System.Drawing.Point(65, 12)
			Me.categoryComboBox.Name = "categoryComboBox"
			Me.categoryComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.categoryComboBox.Size = New System.Drawing.Size(138, 20)
			Me.categoryComboBox.TabIndex = 55
			' 
			' categoryLabel
			' 
			Me.categoryLabel.Location = New System.Drawing.Point(12, 15)
			Me.categoryLabel.Name = "categoryLabel"
			Me.categoryLabel.Size = New System.Drawing.Size(49, 13)
			Me.categoryLabel.TabIndex = 56
			Me.categoryLabel.Text = "Category:"
			' 
			' sumEdit
			' 
			Me.sumEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.sumEdit.Location = New System.Drawing.Point(65, 38)
			Me.sumEdit.Name = "sumEdit"
			Me.sumEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.sumEdit.Properties.Mask.EditMask = "c"
			Me.sumEdit.Size = New System.Drawing.Size(138, 20)
			Me.sumEdit.TabIndex = 57
			' 
			' sumLabel
			' 
			Me.sumLabel.Location = New System.Drawing.Point(12, 41)
			Me.sumLabel.Name = "sumLabel"
			Me.sumLabel.Size = New System.Drawing.Size(24, 13)
			Me.sumLabel.TabIndex = 58
			Me.sumLabel.Text = "Sum:"
			' 
			' monthLabel
			' 
			Me.monthLabel.Location = New System.Drawing.Point(209, 15)
			Me.monthLabel.Name = "monthLabel"
			Me.monthLabel.Size = New System.Drawing.Size(34, 13)
			Me.monthLabel.TabIndex = 59
			Me.monthLabel.Text = "Month:"
			' 
			' monthComboBox
			' 
			Me.monthComboBox.EditValue = ""
			Me.monthComboBox.Location = New System.Drawing.Point(249, 12)
			Me.monthComboBox.Name = "monthComboBox"
			Me.monthComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.monthComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.monthComboBox.Size = New System.Drawing.Size(138, 20)
			Me.monthComboBox.TabIndex = 60
'			Me.monthComboBox.EditValueChanged += New System.EventHandler(Me.MonthComboBoxEditValueChanged);
			' 
			' dayLabel
			' 
			Me.dayLabel.Location = New System.Drawing.Point(209, 41)
			Me.dayLabel.Name = "dayLabel"
			Me.dayLabel.Size = New System.Drawing.Size(23, 13)
			Me.dayLabel.TabIndex = 61
			Me.dayLabel.Text = "Day:"
			' 
			' OKButton
			' 
			Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.OKButton.Location = New System.Drawing.Point(231, 64)
			Me.OKButton.Name = "OKButton"
			Me.OKButton.Size = New System.Drawing.Size(75, 23)
			Me.OKButton.TabIndex = 63
			Me.OKButton.Text = "OK"
'			Me.OKButton.Click += New System.EventHandler(Me.OkButtonClick);
			' 
			' CnclButton
			' 
			Me.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.CnclButton.Location = New System.Drawing.Point(312, 64)
			Me.CnclButton.Name = "CnclButton"
			Me.CnclButton.Size = New System.Drawing.Size(75, 23)
			Me.CnclButton.TabIndex = 64
			Me.CnclButton.Text = "Cancel"
			' 
			' dayTextEdit
			' 
			Me.dayTextEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.dayTextEdit.Location = New System.Drawing.Point(249, 38)
			Me.dayTextEdit.Name = "dayTextEdit"
			Me.dayTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dayTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.dayTextEdit.Properties.Mask.EditMask = "n0"
			Me.dayTextEdit.Size = New System.Drawing.Size(138, 20)
			Me.dayTextEdit.TabIndex = 62
			' 
			' AddTransactionForm
			' 
			Me.AcceptButton = Me.OKButton
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.CnclButton
			Me.ClientSize = New System.Drawing.Size(399, 99)
			Me.Controls.Add(Me.CnclButton)
			Me.Controls.Add(Me.OKButton)
			Me.Controls.Add(Me.dayLabel)
			Me.Controls.Add(Me.monthComboBox)
			Me.Controls.Add(Me.monthLabel)
			Me.Controls.Add(Me.sumLabel)
			Me.Controls.Add(Me.sumEdit)
			Me.Controls.Add(Me.categoryLabel)
			Me.Controls.Add(Me.categoryComboBox)
			Me.Controls.Add(Me.dayTextEdit)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "AddTransactionForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Add transaction"
			CType(Me.categoryComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sumEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.monthComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dayTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		#End Region

		Private categoryComboBox As DevExpress.XtraEditors.ComboBoxEdit
		Private categoryLabel As DevExpress.XtraEditors.LabelControl
		Private sumEdit As DevExpress.XtraEditors.SpinEdit
		Private sumLabel As DevExpress.XtraEditors.LabelControl
		Private monthLabel As DevExpress.XtraEditors.LabelControl
		Private WithEvents monthComboBox As DevExpress.XtraEditors.ComboBoxEdit
		Private dayLabel As DevExpress.XtraEditors.LabelControl
		Private WithEvents OKButton As DevExpress.XtraEditors.SimpleButton
		Private CnclButton As DevExpress.XtraEditors.SimpleButton
		Private dayTextEdit As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
