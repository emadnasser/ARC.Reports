Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ValidationControl
		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
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
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.label1.Location = New System.Drawing.Point(10, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(0, 13)
			Me.label1.TabIndex = 0
			' 
			' imageComboBoxEdit1
			' 
			Me.imageComboBoxEdit1.EditValue = 0
			Me.imageComboBoxEdit1.Location = New System.Drawing.Point(173, 10)
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is greater than", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is greater than or equal to", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than", 2, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than or equal to", 3, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("does not equal", 4, -1)})
			Me.imageComboBoxEdit1.Size = New System.Drawing.Size(167, 20)
			Me.imageComboBoxEdit1.TabIndex = 1
'			Me.imageComboBoxEdit1.SelectedIndexChanged += New System.EventHandler(Me.imageComboBoxEdit1_SelectedIndexChanged);
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(348, 10)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.ValidateOnEnterKey = True
			Me.spinEdit1.Size = New System.Drawing.Size(64, 20)
			Me.spinEdit1.TabIndex = 2
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged);
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(585, 10)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Properties.ValidateOnEnterKey = True
			Me.spinEdit2.Size = New System.Drawing.Size(64, 20)
			Me.spinEdit2.TabIndex = 6
'			Me.spinEdit2.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged);
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label2.Location = New System.Drawing.Point(420, 13)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(22, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "and:"
			' 
			' imageComboBoxEdit2
			' 
			Me.imageComboBoxEdit2.EditValue = 2
			Me.imageComboBoxEdit2.Location = New System.Drawing.Point(447, 10)
			Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
			Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.imageComboBoxEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than", 2, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("is less than or equal to", 3, -1)})
			Me.imageComboBoxEdit2.Size = New System.Drawing.Size(132, 20)
			Me.imageComboBoxEdit2.TabIndex = 4
'			Me.imageComboBoxEdit2.SelectedIndexChanged += New System.EventHandler(Me.imageComboBoxEdit2_SelectedIndexChanged);
			' 
			' ValidationControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.imageComboBoxEdit2)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.spinEdit2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.imageComboBoxEdit1)
			Me.Controls.Add(Me.label1)
			Me.Name = "ValidationControl"
			Me.Size = New System.Drawing.Size(723, 30)
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private label1 As DevExpress.XtraEditors.LabelControl
		Public WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Public WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Public WithEvents spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Public WithEvents imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit
	End Class
End Namespace
