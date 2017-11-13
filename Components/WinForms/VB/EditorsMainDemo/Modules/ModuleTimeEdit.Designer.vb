Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTimeEdit
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.teMask = New DevExpress.XtraEditors.TextEdit()
			Me.label4 = New DevExpress.XtraEditors.LabelControl()
			Me.label3 = New DevExpress.XtraEditors.LabelControl()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxTimeFormat = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.comboBoxTimeEditStyle = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroupHourFormat = New DevExpress.XtraEditors.RadioGroup()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.timeEditSample = New DevExpress.XtraEditors.TimeEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.teMask.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxTimeFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxTimeEditStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroupHourFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.timeEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(837, 542)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(831, 536)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.teMask)
			Me.groupControl1.Controls.Add(Me.label4)
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Controls.Add(Me.comboBoxTimeFormat)
			Me.groupControl1.Controls.Add(Me.comboBoxTimeEditStyle)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.radioGroupHourFormat)
			Me.groupControl1.Location = New System.Drawing.Point(269, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(260, 238)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Edit value representation"
			' 
			' teMask
			' 
			Me.teMask.EditValue = ""
			Me.teMask.Location = New System.Drawing.Point(132, 123)
			Me.teMask.Name = "teMask"
			Me.teMask.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.teMask.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.teMask.Properties.Appearance.Options.UseBackColor = True
			Me.teMask.Properties.Appearance.Options.UseForeColor = True
			Me.teMask.Properties.ReadOnly = True
			Me.teMask.Size = New System.Drawing.Size(104, 20)
			Me.teMask.TabIndex = 5
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(20, 35)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(73, 13)
			Me.label4.TabIndex = 1
			Me.label4.Text = "Time edit style:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(20, 126)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(49, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Edit mask:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(20, 97)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(61, 13)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Time format:"
			' 
			' comboBoxTimeFormat
			' 
			Me.comboBoxTimeFormat.EditValue = "HourMinSec"
			Me.comboBoxTimeFormat.Location = New System.Drawing.Point(132, 94)
			Me.comboBoxTimeFormat.Name = "comboBoxTimeFormat"
			Me.comboBoxTimeFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxTimeFormat.Properties.Items.AddRange(New Object() { "HourMinSec", "HourMin", "Hour"})
			Me.comboBoxTimeFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxTimeFormat.Size = New System.Drawing.Size(104, 20)
			Me.comboBoxTimeFormat.TabIndex = 2
'			Me.comboBoxTimeFormat.SelectedIndexChanged += New System.EventHandler(Me.comboBoxTimeFormat_SelectedIndexChanged)
			' 
			' comboBoxTimeEditStyle
			' 
			Me.comboBoxTimeEditStyle.EditValue = "SpinButtons"
			Me.comboBoxTimeEditStyle.Location = New System.Drawing.Point(132, 32)
			Me.comboBoxTimeEditStyle.Name = "comboBoxTimeEditStyle"
			Me.comboBoxTimeEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxTimeEditStyle.Properties.Items.AddRange(New Object() { "SpinButtons", "TouchUI"})
			Me.comboBoxTimeEditStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxTimeEditStyle.Size = New System.Drawing.Size(104, 20)
			Me.comboBoxTimeEditStyle.TabIndex = 0
'			Me.comboBoxTimeEditStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBoxTimeEditStyle_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(20, 66)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(62, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Hour format:"
			' 
			' radioGroupHourFormat
			' 
			Me.radioGroupHourFormat.EditValue = "12"
			Me.radioGroupHourFormat.Location = New System.Drawing.Point(132, 61)
			Me.radioGroupHourFormat.Name = "radioGroupHourFormat"
			Me.radioGroupHourFormat.Properties.Columns = 2
			Me.radioGroupHourFormat.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem("12", "12"), New DevExpress.XtraEditors.Controls.RadioGroupItem("24", "24")})
			Me.radioGroupHourFormat.Size = New System.Drawing.Size(104, 24)
			Me.radioGroupHourFormat.TabIndex = 1
'			Me.radioGroupHourFormat.SelectedIndexChanged += New System.EventHandler(Me.radioGroupHourFormat_SelectedIndexChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.timeEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(208, 238)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' timeEditSample
			' 
			Me.timeEditSample.EditValue = New Date(2005, 5, 25, 0, 0, 0, 0)
			Me.timeEditSample.Location = New System.Drawing.Point(25, 80)
			Me.timeEditSample.Name = "timeEditSample"
            Me.timeEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.timeEditSample.Properties.Mask.EditMask = "hh:mm:ss tt"
			Me.timeEditSample.Size = New System.Drawing.Size(163, 20)
			Me.timeEditSample.TabIndex = 0
			' 
			' ModuleTimeEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleTimeEdit"
			Me.Size = New System.Drawing.Size(842, 547)
'			Me.Load += New System.EventHandler(Me.ModuleTimeEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.teMask.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxTimeFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxTimeEditStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroupHourFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.timeEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private timeEditSample As DevExpress.XtraEditors.TimeEdit
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxTimeFormat As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents comboBoxTimeEditStyle As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents radioGroupHourFormat As DevExpress.XtraEditors.RadioGroup
		Private label3 As DevExpress.XtraEditors.LabelControl
		Private label4 As DevExpress.XtraEditors.LabelControl
		Private teMask As DevExpress.XtraEditors.TextEdit
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
