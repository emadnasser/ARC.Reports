Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.AreaViews
	Partial Public Class Area3dDemoBase
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
			Me.comboTransparencies = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelTransparency = New DevExpress.XtraEditors.LabelControl()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(203, 8)
			Me.btnDefaultAngles.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
			Me.btnDefaultAngles.TabIndex = 5
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.labelTransparency)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Controls.Add(Me.comboTransparencies)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboTransparencies, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.labelTransparency, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 6
			' 
			' comboTransparencies
			' 
			Me.comboTransparencies.Location = New System.Drawing.Point(105, 9)
			Me.comboTransparencies.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboTransparencies.Name = "comboTransparencies"
			Me.comboTransparencies.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboTransparencies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboTransparencies.Size = New System.Drawing.Size(78, 20)
			Me.comboTransparencies.TabIndex = 2
'			Me.comboTransparencies.SelectedIndexChanged += New System.EventHandler(Me.comboTransparencies_SelectedIndexChanged);
			' 
			' comboBoxEditPerspective
			' 
			Me.comboBoxEditPerspective.EditValue = ""
			Me.comboBoxEditPerspective.Location = New System.Drawing.Point(105, 37)
			Me.comboBoxEditPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.comboBoxEditPerspective.Name = "comboBoxEditPerspective"
			Me.comboBoxEditPerspective.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditPerspective.Size = New System.Drawing.Size(78, 20)
			Me.comboBoxEditPerspective.TabIndex = 4
'			Me.comboBoxEditPerspective.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditPerspective_SelectedIndexChanged);
			' 
			' labelTransparency
			' 
			Me.labelTransparency.Location = New System.Drawing.Point(12, 12)
			Me.labelTransparency.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelTransparency.Name = "labelTransparency"
			Me.labelTransparency.Size = New System.Drawing.Size(70, 13)
			Me.labelTransparency.TabIndex = 1
			Me.labelTransparency.Text = "Transparency:"
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 40)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 3
			Me.labelPerspective.Text = "Perspective Angle:"
			' 
			' Area3dDemoBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Area3dDemoBase"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboTransparencies.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents comboTransparencies As DevExpress.XtraEditors.ComboBoxEdit
		Protected WithEvents comboBoxEditPerspective As DevExpress.XtraEditors.ComboBoxEdit
		Private labelPerspective As DevExpress.XtraEditors.LabelControl
		Private labelTransparency As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
