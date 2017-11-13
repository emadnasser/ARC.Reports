Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class TopTradingPartnersModule
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
		Private Sub InitializeComponent()
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.chkExports = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAsiaRegion = New DevExpress.XtraEditors.CheckEdit()
			Me.chkBalance = New DevExpress.XtraEditors.CheckEdit()
			Me.chkImports = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.chkExports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAsiaRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkImports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 202)
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(697, 208)
			' 
			' panel
			' 
			Me.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel.Controls.Add(Me.chkExports)
			Me.panel.Controls.Add(Me.chkAsiaRegion)
			Me.panel.Controls.Add(Me.chkBalance)
			Me.panel.Controls.Add(Me.chkImports)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Size = New System.Drawing.Size(697, 35)
			Me.panel.TabIndex = 55
			' 
			' chkExports
			' 
			Me.chkExports.EditValue = True
			Me.chkExports.Location = New System.Drawing.Point(98, 8)
			Me.chkExports.Name = "chkExports"
			Me.chkExports.Properties.AutoWidth = True
			Me.chkExports.Properties.Caption = "Exports"
			Me.chkExports.Size = New System.Drawing.Size(59, 19)
			Me.chkExports.TabIndex = 1
'			Me.chkExports.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' chkAsiaRegion
			' 
			Me.chkAsiaRegion.EditValue = True
			Me.chkAsiaRegion.Location = New System.Drawing.Point(298, 8)
			Me.chkAsiaRegion.Name = "chkAsiaRegion"
			Me.chkAsiaRegion.Properties.AutoWidth = True
			Me.chkAsiaRegion.Properties.Caption = "Asia Region"
			Me.chkAsiaRegion.Size = New System.Drawing.Size(78, 19)
			Me.chkAsiaRegion.TabIndex = 3
'			Me.chkAsiaRegion.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' chkBalance
			' 
			Me.chkBalance.EditValue = True
			Me.chkBalance.Location = New System.Drawing.Point(198, 8)
			Me.chkBalance.Name = "chkBalance"
			Me.chkBalance.Properties.AutoWidth = True
			Me.chkBalance.Properties.Caption = "Balance"
			Me.chkBalance.Size = New System.Drawing.Size(59, 19)
			Me.chkBalance.TabIndex = 2
'			Me.chkBalance.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' chkImports
			' 
			Me.chkImports.EditValue = True
			Me.chkImports.Location = New System.Drawing.Point(0, 8)
			Me.chkImports.Name = "chkImports"
			Me.chkImports.Properties.AutoWidth = True
			Me.chkImports.Properties.Caption = "Imports"
			Me.chkImports.Size = New System.Drawing.Size(59, 19)
			Me.chkImports.TabIndex = 0
'			Me.chkImports.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' TopTradingPartnersModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel)
			Me.Name = "TopTradingPartnersModule"
			Me.Size = New System.Drawing.Size(697, 410)
			Me.Controls.SetChildIndex(Me.panel, 0)
			Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.chkExports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAsiaRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkImports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panel As XtraEditors.PanelControl
		Protected WithEvents chkImports As XtraEditors.CheckEdit
		Protected WithEvents chkBalance As XtraEditors.CheckEdit
		Protected WithEvents chkAsiaRegion As XtraEditors.CheckEdit
		Protected WithEvents chkExports As XtraEditors.CheckEdit
	End Class
End Namespace
