Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class OperationRestrictionsModule
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
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.edtReadOnly = New DevExpress.XtraEditors.CheckEdit()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.edtReadOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Size = New System.Drawing.Size(789, 290)
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Size = New System.Drawing.Size(789, 117)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.edtReadOnly)
			Me.panelControl1.Controls.Add(Me.propertyGridControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl1.Location = New System.Drawing.Point(789, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(248, 432)
			Me.panelControl1.TabIndex = 1
			' 
			' edtReadOnly
			' 
			Me.edtReadOnly.Location = New System.Drawing.Point(6, 3)
			Me.edtReadOnly.Name = "edtReadOnly"
			Me.edtReadOnly.Properties.Caption = "ReadOnly"
			Me.edtReadOnly.Size = New System.Drawing.Size(120, 19)
			Me.edtReadOnly.TabIndex = 17
'			Me.edtReadOnly.CheckedChanged += New System.EventHandler(Me.edtReadOnly_CheckedChanged);
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.propertyGridControl1.Location = New System.Drawing.Point(8, 28)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.Size = New System.Drawing.Size(240, 404)
			Me.propertyGridControl1.TabIndex = 2
			' 
			' OperationRestrictionsModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "OperationRestrictionsModule"
			Me.Size = New System.Drawing.Size(1037, 432)
			Me.Controls.SetChildIndex(Me.panelControl1, 0)
			Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
			Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.edtReadOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private panelControl1 As XtraEditors.PanelControl
		Private WithEvents edtReadOnly As XtraEditors.CheckEdit
		Private propertyGridControl1 As XtraVerticalGrid.PropertyGridControl
	End Class
End Namespace
