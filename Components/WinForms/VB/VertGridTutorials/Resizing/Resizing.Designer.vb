Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class Resizing
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.checkBox3 = New DevExpress.XtraEditors.CheckEdit()
			Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
			Me.label5 = New System.Windows.Forms.Label()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.label4 = New System.Windows.Forms.Label()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.label3 = New System.Windows.Forms.Label()
			Me.checkBox2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.checkBox3)
			Me.panel2.Controls.Add(Me.spinEdit3)
			Me.panel2.Controls.Add(Me.label5)
			Me.panel2.Controls.Add(Me.spinEdit2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.spinEdit1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Controls.Add(Me.checkBox2)
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(410, 92)
			Me.panel2.TabIndex = 10
			' 
			' checkBox3
			' 
			Me.checkBox3.Location = New System.Drawing.Point(12, 60)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Properties.Caption = "Resize Header Panel"
			Me.checkBox3.Size = New System.Drawing.Size(140, 18)
			Me.checkBox3.TabIndex = 10
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox3_CheckedChanged);
			' 
			' spinEdit3
			' 
			Me.spinEdit3.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit3.Location = New System.Drawing.Point(280, 60)
			Me.spinEdit3.Name = "spinEdit3"
			Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit3.Properties.IsFloatValue = False
			Me.spinEdit3.Properties.Mask.EditMask = "N00"
			Me.spinEdit3.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinEdit3.Size = New System.Drawing.Size(80, 20)
			Me.spinEdit3.TabIndex = 9
'			Me.spinEdit3.EditValueChanged += New System.EventHandler(Me.spinEdit3_ValueChanged);
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(168, 63)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(91, 13)
			Me.label5.TabIndex = 8
			Me.label5.Text = "Records Interval:"
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(280, 36)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Properties.IsFloatValue = False
			Me.spinEdit2.Properties.Mask.EditMask = "N00"
			Me.spinEdit2.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.spinEdit2.Size = New System.Drawing.Size(80, 20)
			Me.spinEdit2.TabIndex = 7
'			Me.spinEdit2.EditValueChanged += New System.EventHandler(Me.spinEdit2_ValueChanged);
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(168, 39)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(101, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Row Header Width:"
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(280, 12)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.IsFloatValue = False
			Me.spinEdit1.Properties.Mask.EditMask = "N00"
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.spinEdit1.Size = New System.Drawing.Size(80, 20)
			Me.spinEdit1.TabIndex = 5
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit1_ValueChanged);
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(168, 15)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(76, 13)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Record Width:"
			' 
			' checkBox2
			' 
			Me.checkBox2.Location = New System.Drawing.Point(12, 36)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Properties.Caption = "Resize Row Values"
			Me.checkBox2.Size = New System.Drawing.Size(140, 18)
			Me.checkBox2.TabIndex = 3
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox2_CheckedChanged);
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(12, 12)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Resize Row Headers"
			Me.checkBox1.Size = New System.Drawing.Size(140, 18)
			Me.checkBox1.TabIndex = 2
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 100)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordsInterval = 2
			Me.vGridControl1.RowHeaderWidth = 185
			Me.vGridControl1.Size = New System.Drawing.Size(410, 458)
			Me.vGridControl1.TabIndex = 11
'			Me.vGridControl1.RowHeaderWidthChanged += New System.EventHandler(Me.vGridControl1_RowHeaderWidthChanged);
'			Me.vGridControl1.RecordWidthChanged += New System.EventHandler(Me.vGridControl1_RecordWidthChanged);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 92)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(410, 8)
			Me.panelControl1.TabIndex = 14
			' 
			' Resizing
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "Resizing"
			Me.Size = New System.Drawing.Size(410, 558)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.Resizing_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private WithEvents checkBox2 As DevExpress.XtraEditors.CheckEdit
		Private label3 As System.Windows.Forms.Label
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private label4 As System.Windows.Forms.Label
		Private WithEvents spinEdit3 As DevExpress.XtraEditors.SpinEdit
		Private label5 As System.Windows.Forms.Label
		Private WithEvents checkBox3 As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace
