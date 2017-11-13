Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class ScrollVisibilitySample
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
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.panel2 = New PanelControl()
			Me.radioGroup2 = New DevExpress.XtraEditors.RadioGroup()
			Me.label4 = New System.Windows.Forms.Label()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.label3 = New System.Windows.Forms.Label()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.panel3.SuspendLayout()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.radioGroup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.dataNavigator1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel3.Location = New System.Drawing.Point(162, 302)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(588, 20)
			Me.panel3.TabIndex = 17
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(588, 20)
			Me.dataNavigator1.TabIndex = 0
			Me.dataNavigator1.Text = "dataNavigator1"
			Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
			Me.vGridControl1.Location = New System.Drawing.Point(162, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.ScrollVisibility = DevExpress.XtraVerticalGrid.ScrollVisibility.Vertical
			Me.vGridControl1.Size = New System.Drawing.Size(588, 302)
			Me.vGridControl1.TabIndex = 16
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.radioGroup2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.radioGroup1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(8)
			Me.panel2.Size = New System.Drawing.Size(156, 322)
			Me.panel2.TabIndex = 14
			' 
			' radioGroup2
			' 
			Me.radioGroup2.Dock = System.Windows.Forms.DockStyle.Top
			Me.radioGroup2.Location = New System.Drawing.Point(8, 162)
			Me.radioGroup2.Name = "radioGroup2"
			Me.radioGroup2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Bands View"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Single Record View"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Multi Record View")})
			Me.radioGroup2.Size = New System.Drawing.Size(140, 68)
			Me.radioGroup2.TabIndex = 5
'			Me.radioGroup2.SelectedIndexChanged += New System.EventHandler(Me.radioGroup2_SelectedIndexChanged);
			' 
			' label4
			' 
			Me.label4.Dock = System.Windows.Forms.DockStyle.Top
			Me.label4.Location = New System.Drawing.Point(8, 139)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(140, 23)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Layout Style:"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radioGroup1.Location = New System.Drawing.Point(8, 31)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Never"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Auto"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Both"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Horizontal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Vertical")})
			Me.radioGroup1.Size = New System.Drawing.Size(140, 108)
			Me.radioGroup1.TabIndex = 3
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Top
			Me.label3.Location = New System.Drawing.Point(8, 8)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(140, 23)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Scroll Visibility:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(156, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 322)
			Me.splitter1.TabIndex = 15
			Me.splitter1.TabStop = False
			' 
			' ScrollVisibilitySample
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "ScrollVisibilitySample"
			Me.Size = New System.Drawing.Size(750, 322)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.ScrollVisibilitySample_Load);
			Me.panel3.ResumeLayout(False)
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.radioGroup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel3 As System.Windows.Forms.Panel
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private panel2 As PanelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private label3 As System.Windows.Forms.Label
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private WithEvents radioGroup2 As DevExpress.XtraEditors.RadioGroup
		Private label4 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
