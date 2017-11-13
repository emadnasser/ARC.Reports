Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class GroupContainer
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GroupContainer))
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.button1 = New DevExpress.XtraEditors.SimpleButton()
			Me.comboBox1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.textBox1 = New DevExpress.XtraEditors.TextEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.navBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.dateTimePicker2 = New DevExpress.XtraEditors.DateEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.dateTimePicker1 = New DevExpress.XtraEditors.DateEdit()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBox2 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.radioButton5 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton4 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton3 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton2 = New DevExpress.XtraEditors.CheckEdit()
			Me.radioButton1 = New DevExpress.XtraEditors.CheckEdit()
			Me.navBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.checkBox5 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox4 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox3 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarControl1.SuspendLayout()
			Me.navBarGroupControlContainer1.SuspendLayout()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarGroupControlContainer3.SuspendLayout()
			CType(Me.dateTimePicker2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateTimePicker2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateTimePicker1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateTimePicker1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButton1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarGroupControlContainer4.SuspendLayout()
			CType(Me.checkBox5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Margin = New Padding(2)
			Me.contentPanel_Renamed.Padding = New Padding(3)
			Me.contentPanel_Renamed.Size = New Size(268, 507)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.Appearance.GroupHeader.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
			Me.navBarControl1.Appearance.GroupHeader.Options.UseFont = True
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer3)
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer4)
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Location = New Point(4, 5)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 246
			Me.navBarControl1.Size = New Size(246, 467)
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Search"
			Me.navBarGroup1.ControlContainer = Me.navBarGroupControlContainer1
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupClientHeight = 127
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup1.LargeImage = (CType(resources.GetObject("navBarGroup1.LargeImage"), Image))
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarGroupControlContainer1
			' 
			Me.navBarGroupControlContainer1.Controls.Add(Me.button1)
			Me.navBarGroupControlContainer1.Controls.Add(Me.comboBox1)
			Me.navBarGroupControlContainer1.Controls.Add(Me.label2)
			Me.navBarGroupControlContainer1.Controls.Add(Me.textBox1)
			Me.navBarGroupControlContainer1.Controls.Add(Me.label1)
			Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
			Me.navBarGroupControlContainer1.Size = New Size(238, 120)
			Me.navBarGroupControlContainer1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.button1.Location = New Point(8, 92)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(225, 24)
			Me.button1.TabIndex = 4
			Me.button1.Text = "Search"
			' 
			' comboBox1
			' 
			Me.comboBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.comboBox1.Location = New Point(8, 60)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox1.Size = New Size(225, 20)
			Me.comboBox1.TabIndex = 3
			' 
			' label2
			' 
			Me.label2.Appearance.BackColor = Color.Transparent
			Me.label2.Location = New Point(8, 44)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(37, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Look in:"
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox1.EditValue = ""
			Me.textBox1.Location = New Point(8, 20)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(225, 20)
			Me.textBox1.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = Color.Transparent
			Me.label1.Location = New Point(8, 4)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(129, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "All or part of the file name:"
			' 
			' navBarGroupControlContainer3
			' 
			Me.navBarGroupControlContainer3.Controls.Add(Me.dateTimePicker2)
			Me.navBarGroupControlContainer3.Controls.Add(Me.label4)
			Me.navBarGroupControlContainer3.Controls.Add(Me.dateTimePicker1)
			Me.navBarGroupControlContainer3.Controls.Add(Me.label3)
			Me.navBarGroupControlContainer3.Controls.Add(Me.comboBox2)
			Me.navBarGroupControlContainer3.Controls.Add(Me.radioButton5)
			Me.navBarGroupControlContainer3.Controls.Add(Me.radioButton4)
			Me.navBarGroupControlContainer3.Controls.Add(Me.radioButton3)
			Me.navBarGroupControlContainer3.Controls.Add(Me.radioButton2)
			Me.navBarGroupControlContainer3.Controls.Add(Me.radioButton1)
			Me.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3"
			Me.navBarGroupControlContainer3.Size = New Size(238, 192)
			Me.navBarGroupControlContainer3.TabIndex = 2
			' 
			' dateTimePicker2
			' 
			Me.dateTimePicker2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.dateTimePicker2.EditValue = New Date(2006, 9, 28, 0, 0, 0, 0)
			Me.dateTimePicker2.Location = New Point(52, 160)
			Me.dateTimePicker2.Name = "dateTimePicker2"
			Me.dateTimePicker2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateTimePicker2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateTimePicker2.Size = New Size(181, 20)
			Me.dateTimePicker2.TabIndex = 9
			' 
			' label4
			' 
			Me.label4.Appearance.BackColor = Color.Transparent
			Me.label4.Location = New Point(16, 164)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(10, 13)
			Me.label4.TabIndex = 8
			Me.label4.Text = "to"
			' 
			' dateTimePicker1
			' 
			Me.dateTimePicker1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.dateTimePicker1.EditValue = New Date(2006, 9, 28, 0, 0, 0, 0)
			Me.dateTimePicker1.Location = New Point(52, 136)
			Me.dateTimePicker1.Name = "dateTimePicker1"
			Me.dateTimePicker1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateTimePicker1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateTimePicker1.Size = New Size(181, 20)
			Me.dateTimePicker1.TabIndex = 7
			' 
			' label3
			' 
			Me.label3.Appearance.BackColor = Color.Transparent
			Me.label3.Location = New Point(16, 140)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(22, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "from"
			' 
			' comboBox2
			' 
			Me.comboBox2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.comboBox2.Location = New Point(20, 108)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox2.Properties.Items.AddRange(New Object() { "Modified Date", "Created Date", "Accessed Date"})
			Me.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox2.Size = New Size(213, 20)
			Me.comboBox2.TabIndex = 5
			' 
			' radioButton5
			' 
			Me.radioButton5.Location = New Point(8, 84)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.Properties.Appearance.BackColor = Color.Transparent
			Me.radioButton5.Properties.Appearance.Options.UseBackColor = True
			Me.radioButton5.Properties.Caption = "Specify dates"
			Me.radioButton5.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton5.Properties.RadioGroupIndex = 0
			Me.radioButton5.Size = New Size(164, 19)
			Me.radioButton5.TabIndex = 4
			Me.radioButton5.TabStop = False
'			Me.radioButton5.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged)
			' 
			' radioButton4
			' 
			Me.radioButton4.Location = New Point(8, 64)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Properties.Appearance.BackColor = Color.Transparent
			Me.radioButton4.Properties.Appearance.Options.UseBackColor = True
			Me.radioButton4.Properties.Caption = "Within the past year"
			Me.radioButton4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton4.Properties.RadioGroupIndex = 0
			Me.radioButton4.Size = New Size(164, 19)
			Me.radioButton4.TabIndex = 3
			Me.radioButton4.TabStop = False
'			Me.radioButton4.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged)
			' 
			' radioButton3
			' 
			Me.radioButton3.Location = New Point(8, 44)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Properties.Appearance.BackColor = Color.Transparent
			Me.radioButton3.Properties.Appearance.Options.UseBackColor = True
			Me.radioButton3.Properties.Caption = "Past month"
			Me.radioButton3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton3.Properties.RadioGroupIndex = 0
			Me.radioButton3.Size = New Size(164, 19)
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.TabStop = False
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged)
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New Point(8, 24)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Properties.Appearance.BackColor = Color.Transparent
			Me.radioButton2.Properties.Appearance.Options.UseBackColor = True
			Me.radioButton2.Properties.Caption = "Within the last week"
			Me.radioButton2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton2.Properties.RadioGroupIndex = 0
			Me.radioButton2.Size = New Size(164, 19)
			Me.radioButton2.TabIndex = 1
			Me.radioButton2.TabStop = False
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged)
			' 
			' radioButton1
			' 
			Me.radioButton1.Location = New Point(8, 4)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Properties.Appearance.BackColor = Color.Transparent
			Me.radioButton1.Properties.Appearance.Options.UseBackColor = True
			Me.radioButton1.Properties.Caption = "Don't remember"
			Me.radioButton1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.radioButton1.Properties.RadioGroupIndex = 0
			Me.radioButton1.Size = New Size(164, 19)
			Me.radioButton1.TabIndex = 0
			Me.radioButton1.TabStop = False
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton_CheckedChanged)
			' 
			' navBarGroupControlContainer4
			' 
			Me.navBarGroupControlContainer4.Controls.Add(Me.checkBox5)
			Me.navBarGroupControlContainer4.Controls.Add(Me.checkBox4)
			Me.navBarGroupControlContainer4.Controls.Add(Me.checkBox3)
			Me.navBarGroupControlContainer4.Controls.Add(Me.checkBox2)
			Me.navBarGroupControlContainer4.Controls.Add(Me.checkBox1)
			Me.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4"
			Me.navBarGroupControlContainer4.Size = New Size(208, 89)
			Me.navBarGroupControlContainer4.TabIndex = 3
			' 
			' checkBox5
			' 
			Me.checkBox5.Location = New Point(8, 96)
			Me.checkBox5.Name = "checkBox5"
			Me.checkBox5.Properties.Appearance.BackColor = Color.Transparent
			Me.checkBox5.Properties.Appearance.Options.UseBackColor = True
			Me.checkBox5.Properties.Caption = "Search tape backup"
			Me.checkBox5.Size = New Size(184, 19)
			Me.checkBox5.TabIndex = 4
'			Me.checkBox5.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox4
			' 
			Me.checkBox4.Location = New Point(8, 73)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Properties.Appearance.BackColor = Color.Transparent
			Me.checkBox4.Properties.Appearance.Options.UseBackColor = True
			Me.checkBox4.Properties.Caption = "Case sensitive"
			Me.checkBox4.Size = New Size(184, 19)
			Me.checkBox4.TabIndex = 3
'			Me.checkBox4.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox3
			' 
			Me.checkBox3.Location = New Point(8, 50)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Properties.Appearance.BackColor = Color.Transparent
			Me.checkBox3.Properties.Appearance.Options.UseBackColor = True
			Me.checkBox3.Properties.Caption = "Search subfolders"
			Me.checkBox3.Size = New Size(184, 19)
			Me.checkBox3.TabIndex = 2
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox2
			' 
			Me.checkBox2.Location = New Point(8, 27)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Properties.Appearance.BackColor = Color.Transparent
			Me.checkBox2.Properties.Appearance.Options.UseBackColor = True
			Me.checkBox2.Properties.Caption = "Search hidden files and folders"
			Me.checkBox2.Size = New Size(184, 19)
			Me.checkBox2.TabIndex = 1
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New Point(8, 4)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Appearance.BackColor = Color.Transparent
			Me.checkBox1.Properties.Appearance.Options.UseBackColor = True
			Me.checkBox1.Properties.Caption = "Search system folders"
			Me.checkBox1.Size = New Size(184, 19)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged)
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "When was it modified?"
			Me.navBarGroup2.ControlContainer = Me.navBarGroupControlContainer3
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupClientHeight = 199
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup2.LargeImage = (CType(resources.GetObject("navBarGroup2.LargeImage"), Image))
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "More advanced options"
			Me.navBarGroup3.ControlContainer = Me.navBarGroupControlContainer4
			Me.navBarGroup3.GroupClientHeight = 124
			Me.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup3.LargeImage = (CType(resources.GetObject("navBarGroup3.LargeImage"), Image))
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' GroupContainer
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "GroupContainer"
			Me.Size = New Size(268, 507)
'			Me.Load += New System.EventHandler(Me.GroupContainer_Load)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarControl1.ResumeLayout(False)
			Me.navBarGroupControlContainer1.ResumeLayout(False)
			Me.navBarGroupControlContainer1.PerformLayout()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarGroupControlContainer3.ResumeLayout(False)
			Me.navBarGroupControlContainer3.PerformLayout()
			CType(Me.dateTimePicker2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateTimePicker2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateTimePicker1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateTimePicker1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButton1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarGroupControlContainer4.ResumeLayout(False)
			CType(Me.checkBox5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private navBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private textBox1 As DevExpress.XtraEditors.TextEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private comboBox1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents radioButton1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents radioButton5 As DevExpress.XtraEditors.CheckEdit
		Private comboBox2 As DevExpress.XtraEditors.ComboBoxEdit
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private dateTimePicker1 As DevExpress.XtraEditors.DateEdit
		Private dateTimePicker2 As DevExpress.XtraEditors.DateEdit
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkBox5 As DevExpress.XtraEditors.CheckEdit
		Private button1 As DevExpress.XtraEditors.SimpleButton
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
