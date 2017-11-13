Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class EmployeeInformationModule
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(EmployeeInformationModule))
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.btnCalculate = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.btnCalculate)
			resources.ApplyResources(Me.panel, "panel")
			Me.panel.Name = "panel"
			' 
			' btnCalculate
			' 
			resources.ApplyResources(Me.btnCalculate, "btnCalculate")
			Me.btnCalculate.Name = "btnCalculate"
'			Me.btnCalculate.Click += New System.EventHandler(Me.btnCalculate_Click);
			' 
			' EmployeeInformationModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel)
			Me.Name = "EmployeeInformationModule"
			resources.ApplyResources(Me, "$this")
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		Private panel As XtraEditors.PanelControl
		Protected WithEvents btnCalculate As XtraEditors.SimpleButton
	End Class
End Namespace
