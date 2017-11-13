Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class PolarDemoBase
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
			Me.comboBoxEditFunctionType = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelFunction = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEditMarkerKind
			' 
			' 
			' comboBoxEditMarkerSize
			' 
			' 
			' comboBoxEditDiagramStyle
			' 
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.comboBoxEditFunctionType)
			Me.panel.Controls.Add(Me.labelFunction)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelFunction, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditFunctionType, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 18)
			' 
			' comboBoxEditFunctionType
			' 
			Me.comboBoxEditFunctionType.EditValue = ""
			Me.comboBoxEditFunctionType.Location = New System.Drawing.Point(245, 9)
			Me.comboBoxEditFunctionType.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType"
			Me.comboBoxEditFunctionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditFunctionType.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditFunctionType.TabIndex = 4
'			Me.comboBoxEditFunctionType.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditFunctionType_SelectedIndexChanged);
			' 
			' labelFunction
			' 
			Me.labelFunction.Location = New System.Drawing.Point(173, 12)
			Me.labelFunction.Margin = New System.Windows.Forms.Padding(7)
			Me.labelFunction.Name = "labelFunction"
			Me.labelFunction.Size = New System.Drawing.Size(45, 13)
			Me.labelFunction.TabIndex = 8
			Me.labelFunction.Text = "Function:"
			' 
			' ChartDemoPolarBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ChartDemoPolarBase"
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditFunctionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelFunction As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditFunctionType As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
