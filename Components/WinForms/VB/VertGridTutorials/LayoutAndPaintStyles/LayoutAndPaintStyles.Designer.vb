Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class LayoutAndPaintStyles
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
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.radioGroup1)
			Me.panel2.Controls.Add(Me.spinEdit1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(162, 318)
			Me.panel2.TabIndex = 9
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radioGroup1.Location = New System.Drawing.Point(10, 31)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Bands View"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Single Record View"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Multi Record View")})
			Me.radioGroup1.Size = New System.Drawing.Size(146, 68)
			Me.radioGroup1.TabIndex = 0
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' spinEdit1
			' 
			Me.spinEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(88, 112)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.IsFloatValue = False
			Me.spinEdit1.Properties.Mask.EditMask = "N00"
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 30, 0, 0, 0})
			Me.spinEdit1.Size = New System.Drawing.Size(66, 20)
			Me.spinEdit1.TabIndex = 2
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit1_ValueChanged);
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 116)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(84, 20)
			Me.label3.TabIndex = 4
			Me.label3.Text = "BandsInterval:"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(8, 14)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(144, 24)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Layout Style:"
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(162, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 318)
			Me.splitter1.TabIndex = 10
			Me.splitter1.TabStop = False
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
			Me.vGridControl1.Location = New System.Drawing.Point(168, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Size = New System.Drawing.Size(596, 318)
			Me.vGridControl1.TabIndex = 3
			' 
			' LayoutAndPaintStyles
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "LayoutAndPaintStyles"
			Me.Size = New System.Drawing.Size(764, 318)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.LayoutAndPaintStyles_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private label3 As System.Windows.Forms.Label
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private label4 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
