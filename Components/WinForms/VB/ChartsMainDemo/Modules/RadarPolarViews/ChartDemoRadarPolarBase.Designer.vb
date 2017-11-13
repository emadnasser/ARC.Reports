Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarPolarDemoBase
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
			Me.labelMarkerKind = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditMarkerSize = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelMarkerSize = New DevExpress.XtraEditors.LabelControl()
			Me.labelDiagramStyle = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditDiagramStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxEditMarkerKind)
			Me.panel.Controls.Add(Me.labelMarkerKind)
			Me.panel.Controls.Add(Me.labelMarkerSize)
			Me.panel.Controls.Add(Me.comboBoxEditDiagramStyle)
			Me.panel.Controls.Add(Me.comboBoxEditMarkerSize)
			Me.panel.Controls.Add(Me.labelDiagramStyle)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.labelMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 18)
			' 
			' comboBoxEditMarkerKind
			' 
			Me.comboBoxEditMarkerKind.EditValue = ""
			Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(73, 9)
			Me.comboBoxEditMarkerKind.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
			Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditMarkerKind.TabIndex = 0
'			Me.comboBoxEditMarkerKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerKind_SelectedIndexChanged);
			' 
			' labelMarkerKind
			' 
			Me.labelMarkerKind.Location = New System.Drawing.Point(10, 12)
			Me.labelMarkerKind.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMarkerKind.Name = "labelMarkerKind"
			Me.labelMarkerKind.Size = New System.Drawing.Size(60, 13)
			Me.labelMarkerKind.TabIndex = 1
			Me.labelMarkerKind.Text = "Marker Kind:"
			' 
			' comboBoxEditMarkerSize
			' 
			Me.comboBoxEditMarkerSize.EditValue = ""
			Me.comboBoxEditMarkerSize.Location = New System.Drawing.Point(73, 37)
			Me.comboBoxEditMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize"
			Me.comboBoxEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditMarkerSize.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditMarkerSize.TabIndex = 1
'			Me.comboBoxEditMarkerSize.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditMarkerSize_SelectedIndexChanged);
			' 
			' labelMarkerSize
			' 
			Me.labelMarkerSize.Location = New System.Drawing.Point(10, 40)
			Me.labelMarkerSize.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelMarkerSize.Name = "labelMarkerSize"
			Me.labelMarkerSize.Size = New System.Drawing.Size(59, 13)
			Me.labelMarkerSize.TabIndex = 5
			Me.labelMarkerSize.Text = "Marker Size:"
			' 
			' labelDiagramStyle
			' 
			Me.labelDiagramStyle.Location = New System.Drawing.Point(173, 40)
			Me.labelDiagramStyle.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelDiagramStyle.Name = "labelDiagramStyle"
			Me.labelDiagramStyle.Size = New System.Drawing.Size(70, 13)
			Me.labelDiagramStyle.TabIndex = 6
			Me.labelDiagramStyle.Text = "Diagram Style:"
			' 
			' comboBoxEditDiagramStyle
			' 
			Me.comboBoxEditDiagramStyle.EditValue = ""
			Me.comboBoxEditDiagramStyle.Location = New System.Drawing.Point(245, 37)
			Me.comboBoxEditDiagramStyle.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditDiagramStyle.Name = "comboBoxEditDiagramStyle"
			Me.comboBoxEditDiagramStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditDiagramStyle.Properties.Items.AddRange(New Object() { "Circle", "Polygon"})
			Me.comboBoxEditDiagramStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditDiagramStyle.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditDiagramStyle.TabIndex = 3
'			Me.comboBoxEditDiagramStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditDiagramStyle_SelectedIndexChanged);
			' 
			' ChartDemoRadarPolarBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ChartDemoRadarPolarBase"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelDiagramStyle As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditMarkerKind As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditMarkerSize As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditDiagramStyle As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
