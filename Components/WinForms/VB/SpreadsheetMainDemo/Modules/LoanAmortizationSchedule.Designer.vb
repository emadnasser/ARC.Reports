Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class LoanAmortizationScheduleModule
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

		#Region "InitializeComponent"
		Private Sub InitializeComponent()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 31)
			Me.ribbonControl1.Size = New System.Drawing.Size(1178, 142)
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 198)
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(1178, 234)
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(0, 0)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Columns = 2
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Annuity payments"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Scaled payments")})
			Me.radioGroup1.Size = New System.Drawing.Size(275, 25)
			Me.radioGroup1.TabIndex = 51
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.radioGroup1)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(1178, 31)
			Me.panel.TabIndex = 52
			' 
			' LoanAmortizationScheduleModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel)
			Me.Name = "LoanAmortizationScheduleModule"
			Me.Size = New System.Drawing.Size(1178, 432)
			Me.Controls.SetChildIndex(Me.panel, 0)
			Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
			Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private panel As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
