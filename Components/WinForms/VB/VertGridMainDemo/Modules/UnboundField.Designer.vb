Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class UnboundField
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.cbNameOrder = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbNameOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 50)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(650, 431)
			Me.vGridControl1.TabIndex = 0
'			Me.vGridControl1.CustomUnboundData += New DevExpress.XtraVerticalGrid.Events.CustomDataEventHandler(Me.vGridControl1_CustomUnboundData)
			' 
			' cbNameOrder
			' 
			Me.cbNameOrder.EditValue = "First Name + Last Name"
			Me.cbNameOrder.Location = New System.Drawing.Point(115, 11)
			Me.cbNameOrder.Name = "cbNameOrder"
			Me.cbNameOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbNameOrder.Properties.Items.AddRange(New Object() { "First Name + Last Name", "Last Name + First Name", "First Name only", "Last Name only", "None"})
			Me.cbNameOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbNameOrder.Size = New System.Drawing.Size(149, 20)
			Me.cbNameOrder.TabIndex = 1
'			Me.cbNameOrder.SelectedIndexChanged += New System.EventHandler(Me.cbFirst_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(14, 14)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(85, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Full Name format:"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.cbNameOrder)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(650, 42)
			Me.panelControl1.TabIndex = 4
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 42)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(650, 8)
			Me.panelControl2.TabIndex = 5
			' 
			' UnboundField
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundField"
			Me.Size = New System.Drawing.Size(650, 481)
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbNameOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents vGridControl1 As VGridControl
		Private WithEvents cbNameOrder As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
