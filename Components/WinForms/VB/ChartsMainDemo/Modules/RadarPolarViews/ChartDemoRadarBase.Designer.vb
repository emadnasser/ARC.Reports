Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.RadarPolarViews
	Partial Public Class RadarDemoBase
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
			Me.comboBoxEditTextDirection = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelTextDirection = New DevExpress.XtraEditors.LabelControl()
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.panel.Controls.Add(Me.comboBoxEditTextDirection)
			Me.panel.Controls.Add(Me.labelTextDirection)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerSize, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditDiagramStyle, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditMarkerKind, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.labelTextDirection, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditTextDirection, 0)
			' 
			' checkEditShowLabels
			' 
			' 
			' comboBoxEditTextDirection
			' 
			Me.comboBoxEditTextDirection.EditValue = ""
			Me.comboBoxEditTextDirection.Location = New System.Drawing.Point(245, 9)
			Me.comboBoxEditTextDirection.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
			Me.comboBoxEditTextDirection.Name = "comboBoxEditTextDirection"
			Me.comboBoxEditTextDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditTextDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditTextDirection.Size = New System.Drawing.Size(80, 20)
			Me.comboBoxEditTextDirection.TabIndex = 9
'			Me.comboBoxEditTextDirection.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditTextDirection_SelectedIndexChanged);
			' 
			' labelTextDirection
			' 
			Me.labelTextDirection.Location = New System.Drawing.Point(173, 12)
			Me.labelTextDirection.Margin = New System.Windows.Forms.Padding(10, 10, 3, 10)
			Me.labelTextDirection.Name = "labelTextDirection"
			Me.labelTextDirection.Size = New System.Drawing.Size(71, 13)
			Me.labelTextDirection.TabIndex = 10
			Me.labelTextDirection.Text = "Text Direction:"
			' 
			' ChartDemoRadarBase
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ChartDemoRadarBase"
			CType(Me.comboBoxEditMarkerKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditMarkerSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditDiagramStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.comboBoxEditTextDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private labelTextDirection As DevExpress.XtraEditors.LabelControl
		Protected WithEvents comboBoxEditTextDirection As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
