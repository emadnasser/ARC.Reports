Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class FinancialSeriesViewDemoBase
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.comboBoxEditReductionLevel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditLabelLevel = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelLabelLevel = New DevExpress.XtraEditors.LabelControl()
			Me.labelReductionLevel = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditWorkdaysOnly = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditReductionLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditWorkdaysOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditWorkdaysOnly)
			Me.panel.Controls.Add(Me.labelReductionLevel)
			Me.panel.Controls.Add(Me.labelLabelLevel)
			Me.panel.Controls.Add(Me.comboBoxEditLabelLevel)
			Me.panel.Controls.Add(Me.comboBoxEditReductionLevel)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditReductionLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.labelLabelLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.labelReductionLevel, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditWorkdaysOnly, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 11
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' comboBoxEditReductionLevel
			' 
			Me.comboBoxEditReductionLevel.EditValue = ""
			Me.comboBoxEditReductionLevel.Location = New System.Drawing.Point(245, 9)
			Me.comboBoxEditReductionLevel.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditReductionLevel.Name = "comboBoxEditReductionLevel"
			Me.comboBoxEditReductionLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditReductionLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditReductionLevel.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditReductionLevel.TabIndex = 4
'			Me.comboBoxEditReductionLevel.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditReductionLevel_SelectedIndexChanged);
			' 
			' comboBoxEditLabelLevel
			' 
			Me.comboBoxEditLabelLevel.EditValue = ""
			Me.comboBoxEditLabelLevel.Location = New System.Drawing.Point(72, 9)
			Me.comboBoxEditLabelLevel.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditLabelLevel.Name = "comboBoxEditLabelLevel"
			Me.comboBoxEditLabelLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditLabelLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditLabelLevel.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditLabelLevel.TabIndex = 2
'			Me.comboBoxEditLabelLevel.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditLabelLevel_SelectedIndexChanged);
			' 
			' labelLabelLevel
			' 
			Me.labelLabelLevel.Location = New System.Drawing.Point(12, 12)
			Me.labelLabelLevel.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelLabelLevel.Name = "labelLabelLevel"
			Me.labelLabelLevel.Size = New System.Drawing.Size(57, 13)
			Me.labelLabelLevel.TabIndex = 1
			Me.labelLabelLevel.Text = "Label Level:"
			' 
			' labelReductionLevel
			' 
			Me.labelReductionLevel.Location = New System.Drawing.Point(162, 12)
			Me.labelReductionLevel.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelReductionLevel.Name = "labelReductionLevel"
			Me.labelReductionLevel.Size = New System.Drawing.Size(80, 13)
			Me.labelReductionLevel.TabIndex = 3
			Me.labelReductionLevel.Text = "Reduction Level:"
			' 
			' checkEditWorkdaysOnly
			' 
			Me.checkEditWorkdaysOnly.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditWorkdaysOnly.Location = New System.Drawing.Point(501, 9)
			Me.checkEditWorkdaysOnly.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.checkEditWorkdaysOnly.Name = "checkEditWorkdaysOnly"
			Me.checkEditWorkdaysOnly.Properties.Caption = "Workdays Only"
			Me.checkEditWorkdaysOnly.Size = New System.Drawing.Size(95, 19)
			Me.checkEditWorkdaysOnly.TabIndex = 10
'			Me.checkEditWorkdaysOnly.CheckedChanged += New System.EventHandler(Me.checkEditWorkdaysOnly_CheckedChanged);
			' 
			' FinancialSeriesViewDemoBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "FinancialSeriesViewDemoBase"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditReductionLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditWorkdaysOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelReductionLevel As DevExpress.XtraEditors.LabelControl
		Private labelLabelLevel As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditReductionLevel As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditLabelLevel As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents checkEditWorkdaysOnly As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
