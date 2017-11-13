Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class PointDemoBase
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
			Me.comboBoxEditMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditLabelAngle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditMarkerSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelAngle = New DevExpress.XtraEditors.LabelControl()
			Me.labelMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.labelMarkerSize = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelMarkerSize)
			Me.panel.Controls.Add(Me.labelMarkerKind)
			Me.panel.Controls.Add(Me.labelAngle)
			Me.panel.Controls.Add(Me.comboBoxEditLabelAngle)
			Me.panel.Controls.Add(Me.comboBoxEditMarkerKind)
			Me.panel.Controls.Add(Me.comboBoxEditMarkerSize)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditLabelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelAngle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 57
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.EditValue = ""
			Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(75, 9)
			Me.comboBoxEditMarkerKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
			Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(100, 20)
			Me.comboBoxEditMarkerKind.TabIndex = 51
'			Me.comboBoxEditMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerKind_SelectedIndexChanged);
			' 
			' comboBoxEditLabelAngle
			' 
			Me.comboBoxEditLabelAngle.EditValue = ""
			Me.comboBoxEditLabelAngle.Location = New System.Drawing.Point(257, 9)
			Me.comboBoxEditLabelAngle.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditLabelAngle.Name = "comboBoxEditLabelAngle"
			Me.comboBoxEditLabelAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditLabelAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditLabelAngle.Size = New System.Drawing.Size(60, 20)
			Me.comboBoxEditLabelAngle.TabIndex = 53
'			Me.comboBoxEditLabelAngle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditLabelAngle_SelectedIndexChanged);
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.EditValue = ""
			Me.comboBoxEditMarkerSize.Location = New System.Drawing.Point(75, 37)
			Me.comboBoxEditMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize"
			Me.comboBoxEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerSize.Size = New System.Drawing.Size(60, 20)
			Me.comboBoxEditMarkerSize.TabIndex = 55
'			Me.comboBoxEditMarkerSize.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerSize_SelectedIndexChanged);
			' 
			' labelAngle
			' 
			Me.labelAngle.Location = New System.Drawing.Point(195, 12)
			Me.labelAngle.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelAngle.Name = "labelAngle"
			Me.labelAngle.Size = New System.Drawing.Size(59, 13)
			Me.labelAngle.TabIndex = 52
			Me.labelAngle.Text = "Label Angle:"
			' 
			' labelMarkerKind
			' 
			Me.labelMarkerKind.Location = New System.Drawing.Point(12, 12)
			Me.labelMarkerKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMarkerKind.Name = "labelMarkerKind"
			Me.labelMarkerKind.Size = New System.Drawing.Size(60, 13)
			Me.labelMarkerKind.TabIndex = 50
			Me.labelMarkerKind.Text = "Marker Kind:"
			' 
			' labelMarkerSize
			' 
			Me.labelMarkerSize.Location = New System.Drawing.Point(12, 40)
			Me.labelMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMarkerSize.Name = "labelMarkerSize"
			Me.labelMarkerSize.Size = New System.Drawing.Size(59, 13)
			Me.labelMarkerSize.TabIndex = 54
			Me.labelMarkerSize.Text = "Marker Size:"
			' 
			' PointDemoBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "PointDemoBase"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditLabelAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents comboBoxEditMarkerKind As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditLabelAngle As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditMarkerSize As DevExpress.XtraEditors.ComboBoxEdit
		Protected labelMarkerKind As DevExpress.XtraEditors.LabelControl
		Protected labelAngle As DevExpress.XtraEditors.LabelControl
		Protected labelMarkerSize As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
