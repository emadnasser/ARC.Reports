Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTimeSpanEdit
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
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.tabPageDisplayFormat = New DevExpress.XtraTab.XtraTabPage()
            Me.teDisplayFormatString = New DevExpress.XtraEditors.TextEdit()
            Me.cbDisplayFormat = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.tabPageEditFormat = New DevExpress.XtraTab.XtraTabPage()
            Me.teEditFormatString = New DevExpress.XtraEditors.TextEdit()
            Me.cbEditFormat = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label7 = New DevExpress.XtraEditors.LabelControl()
            Me.label8 = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.lbValue = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.ceReadOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowEditSeconds = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowEditMinutes = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowEditHours = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowEditDays = New DevExpress.XtraEditors.CheckEdit()
            Me.seMaxSeconds = New DevExpress.XtraEditors.SpinEdit()
            Me.label6 = New DevExpress.XtraEditors.LabelControl()
            Me.seMaxMinutes = New DevExpress.XtraEditors.SpinEdit()
            Me.label5 = New DevExpress.XtraEditors.LabelControl()
            Me.seMaxHours = New DevExpress.XtraEditors.SpinEdit()
            Me.label4 = New DevExpress.XtraEditors.LabelControl()
            Me.seMaxDays = New DevExpress.XtraEditors.SpinEdit()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.timeSpanEdit_Renamed = New DevExpress.XtraEditors.TimeSpanEdit()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl.SuspendLayout()
            Me.tabPageDisplayFormat.SuspendLayout()
            CType(Me.teDisplayFormatString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbDisplayFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageEditFormat.SuspendLayout()
            CType(Me.teEditFormatString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbEditFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.ceReadOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowEditSeconds.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowEditMinutes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowEditHours.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceAllowEditDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seMaxSeconds.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seMaxMinutes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seMaxHours.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seMaxDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.timeSpanEdit_Renamed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.xtraTabControl)
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Controls.Add(Me.panelControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(946, 590)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'xtraTabControl
            '
            Me.xtraTabControl.Location = New System.Drawing.Point(269, 340)
            Me.xtraTabControl.Name = "xtraTabControl"
            Me.xtraTabControl.SelectedTabPage = Me.tabPageDisplayFormat
            Me.xtraTabControl.Size = New System.Drawing.Size(260, 111)
            Me.xtraTabControl.TabIndex = 8
            Me.xtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPageDisplayFormat, Me.tabPageEditFormat})
            '
            'tabPageDisplayFormat
            '
            Me.tabPageDisplayFormat.Controls.Add(Me.teDisplayFormatString)
            Me.tabPageDisplayFormat.Controls.Add(Me.cbDisplayFormat)
            Me.tabPageDisplayFormat.Controls.Add(Me.label2)
            Me.tabPageDisplayFormat.Controls.Add(Me.label1)
            Me.tabPageDisplayFormat.Name = "tabPageDisplayFormat"
            Me.tabPageDisplayFormat.Size = New System.Drawing.Size(254, 83)
            Me.tabPageDisplayFormat.Text = "Display Format"
            '
            'teDisplayFormatString
            '
            Me.teDisplayFormatString.EditValue = ""
            Me.teDisplayFormatString.Location = New System.Drawing.Point(100, 48)
            Me.teDisplayFormatString.Name = "teDisplayFormatString"
            Me.teDisplayFormatString.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.teDisplayFormatString.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.teDisplayFormatString.Properties.Appearance.Options.UseBackColor = True
            Me.teDisplayFormatString.Properties.Appearance.Options.UseForeColor = True
            Me.teDisplayFormatString.Properties.ReadOnly = True
            Me.teDisplayFormatString.Size = New System.Drawing.Size(138, 20)
            Me.teDisplayFormatString.TabIndex = 5
            '
            'cbDisplayFormat
            '
            Me.cbDisplayFormat.EditValue = "Automatic"
            Me.cbDisplayFormat.Location = New System.Drawing.Point(100, 18)
            Me.cbDisplayFormat.Name = "cbDisplayFormat"
            Me.cbDisplayFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbDisplayFormat.Properties.Items.AddRange(New Object() {"Automatic", "Days Hours Minutes Seconds", "Days Hours Minutes", "Hours Minutes Seconds", "Hours Minutes", "Minutes Seconds", "Days", "Hours", "Minutes", "Seconds"})
            Me.cbDisplayFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbDisplayFormat.Size = New System.Drawing.Size(138, 20)
            Me.cbDisplayFormat.TabIndex = 2
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(19, 51)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(69, 13)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Format String:"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(19, 21)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(38, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Format:"
            '
            'tabPageEditFormat
            '
            Me.tabPageEditFormat.Controls.Add(Me.teEditFormatString)
            Me.tabPageEditFormat.Controls.Add(Me.cbEditFormat)
            Me.tabPageEditFormat.Controls.Add(Me.label7)
            Me.tabPageEditFormat.Controls.Add(Me.label8)
            Me.tabPageEditFormat.Name = "tabPageEditFormat"
            Me.tabPageEditFormat.Size = New System.Drawing.Size(254, 83)
            Me.tabPageEditFormat.Text = "Edit Format"
            '
            'teEditFormatString
            '
            Me.teEditFormatString.EditValue = ""
            Me.teEditFormatString.Location = New System.Drawing.Point(100, 48)
            Me.teEditFormatString.Name = "teEditFormatString"
            Me.teEditFormatString.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.teEditFormatString.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.teEditFormatString.Properties.Appearance.Options.UseBackColor = True
            Me.teEditFormatString.Properties.Appearance.Options.UseForeColor = True
            Me.teEditFormatString.Properties.ReadOnly = True
            Me.teEditFormatString.Size = New System.Drawing.Size(138, 20)
            Me.teEditFormatString.TabIndex = 9
            '
            'cbEditFormat
            '
            Me.cbEditFormat.EditValue = "Automatic"
            Me.cbEditFormat.Location = New System.Drawing.Point(100, 18)
            Me.cbEditFormat.Name = "cbEditFormat"
            Me.cbEditFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEditFormat.Properties.Items.AddRange(New Object() {"Automatic", "Days Hours Minutes Seconds", "Days Hours Minutes", "Hours Minutes Seconds", "Hours Minutes", "Minutes Seconds", "Days", "Hours", "Minutes", "Seconds"})
            Me.cbEditFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbEditFormat.Size = New System.Drawing.Size(138, 20)
            Me.cbEditFormat.TabIndex = 7
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(19, 51)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(69, 13)
            Me.label7.TabIndex = 10
            Me.label7.Text = "Format String:"
            '
            'label8
            '
            Me.label8.Location = New System.Drawing.Point(19, 21)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(38, 13)
            Me.label8.TabIndex = 8
            Me.label8.Text = "Format:"
            '
            'groupControl2
            '
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.CaptionImage = Global.My.Resources.Resources.info_16x16
            Me.groupControl2.Controls.Add(Me.lbValue)
            Me.groupControl2.Location = New System.Drawing.Point(30, 340)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(208, 111)
            Me.groupControl2.TabIndex = 6
            Me.groupControl2.Text = "Value"
            '
            'lbValue
            '
            Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lbValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbValue.Location = New System.Drawing.Point(16, 54)
            Me.lbValue.Name = "lbValue"
            Me.lbValue.Size = New System.Drawing.Size(178, 22)
            Me.lbValue.TabIndex = 0
            '
            'groupControl1
            '
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.ceReadOnly)
            Me.groupControl1.Controls.Add(Me.ceAllowEditSeconds)
            Me.groupControl1.Controls.Add(Me.ceAllowEditMinutes)
            Me.groupControl1.Controls.Add(Me.ceAllowEditHours)
            Me.groupControl1.Controls.Add(Me.ceAllowEditDays)
            Me.groupControl1.Controls.Add(Me.seMaxSeconds)
            Me.groupControl1.Controls.Add(Me.label6)
            Me.groupControl1.Controls.Add(Me.seMaxMinutes)
            Me.groupControl1.Controls.Add(Me.label5)
            Me.groupControl1.Controls.Add(Me.seMaxHours)
            Me.groupControl1.Controls.Add(Me.label4)
            Me.groupControl1.Controls.Add(Me.seMaxDays)
            Me.groupControl1.Controls.Add(Me.label3)
            Me.groupControl1.Location = New System.Drawing.Point(269, 30)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(260, 281)
            Me.groupControl1.TabIndex = 2
            Me.groupControl1.Text = "Properties"
            '
            'ceReadOnly
            '
            Me.ceReadOnly.Location = New System.Drawing.Point(20, 27)
            Me.ceReadOnly.Name = "ceReadOnly"
            Me.ceReadOnly.Properties.Caption = "Read Only"
            Me.ceReadOnly.Size = New System.Drawing.Size(219, 19)
            Me.ceReadOnly.TabIndex = 19
            '
            'ceAllowEditSeconds
            '
            Me.ceAllowEditSeconds.EditValue = True
            Me.ceAllowEditSeconds.Location = New System.Drawing.Point(20, 244)
            Me.ceAllowEditSeconds.Name = "ceAllowEditSeconds"
            Me.ceAllowEditSeconds.Properties.Caption = "Allow Editing Seconds"
            Me.ceAllowEditSeconds.Size = New System.Drawing.Size(219, 19)
            Me.ceAllowEditSeconds.TabIndex = 18
            '
            'ceAllowEditMinutes
            '
            Me.ceAllowEditMinutes.EditValue = True
            Me.ceAllowEditMinutes.Location = New System.Drawing.Point(20, 219)
            Me.ceAllowEditMinutes.Name = "ceAllowEditMinutes"
            Me.ceAllowEditMinutes.Properties.Caption = "Allow Editing Minutes"
            Me.ceAllowEditMinutes.Size = New System.Drawing.Size(219, 19)
            Me.ceAllowEditMinutes.TabIndex = 17
            '
            'ceAllowEditHours
            '
            Me.ceAllowEditHours.EditValue = True
            Me.ceAllowEditHours.Location = New System.Drawing.Point(20, 194)
            Me.ceAllowEditHours.Name = "ceAllowEditHours"
            Me.ceAllowEditHours.Properties.Caption = "Allow Editing Hours"
            Me.ceAllowEditHours.Size = New System.Drawing.Size(219, 19)
            Me.ceAllowEditHours.TabIndex = 16
            '
            'ceAllowEditDays
            '
            Me.ceAllowEditDays.EditValue = True
            Me.ceAllowEditDays.Location = New System.Drawing.Point(20, 169)
            Me.ceAllowEditDays.Name = "ceAllowEditDays"
            Me.ceAllowEditDays.Properties.Caption = "Allow Editing Days"
            Me.ceAllowEditDays.Size = New System.Drawing.Size(219, 19)
            Me.ceAllowEditDays.TabIndex = 15
            '
            'seMaxSeconds
            '
            Me.seMaxSeconds.EditValue = New Decimal(New Integer() {60, 0, 0, 0})
            Me.seMaxSeconds.Location = New System.Drawing.Point(135, 140)
            Me.seMaxSeconds.Name = "seMaxSeconds"
            Me.seMaxSeconds.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seMaxSeconds.Properties.IsFloatValue = False
            Me.seMaxSeconds.Properties.Mask.EditMask = "N00"
            Me.seMaxSeconds.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seMaxSeconds.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxSeconds.Size = New System.Drawing.Size(104, 20)
            Me.seMaxSeconds.TabIndex = 14
            '
            'label6
            '
            Me.label6.Location = New System.Drawing.Point(22, 143)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(67, 13)
            Me.label6.TabIndex = 13
            Me.label6.Text = "Max Seconds:"
            '
            'seMaxMinutes
            '
            Me.seMaxMinutes.EditValue = New Decimal(New Integer() {60, 0, 0, 0})
            Me.seMaxMinutes.Location = New System.Drawing.Point(135, 111)
            Me.seMaxMinutes.Name = "seMaxMinutes"
            Me.seMaxMinutes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seMaxMinutes.Properties.IsFloatValue = False
            Me.seMaxMinutes.Properties.Mask.EditMask = "N00"
            Me.seMaxMinutes.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seMaxMinutes.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxMinutes.Size = New System.Drawing.Size(104, 20)
            Me.seMaxMinutes.TabIndex = 12
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(22, 114)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(64, 13)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Max Minutes:"
            '
            'seMaxHours
            '
            Me.seMaxHours.EditValue = New Decimal(New Integer() {24, 0, 0, 0})
            Me.seMaxHours.Location = New System.Drawing.Point(135, 82)
            Me.seMaxHours.Name = "seMaxHours"
            Me.seMaxHours.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seMaxHours.Properties.IsFloatValue = False
            Me.seMaxHours.Properties.Mask.EditMask = "N00"
            Me.seMaxHours.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seMaxHours.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxHours.Size = New System.Drawing.Size(104, 20)
            Me.seMaxHours.TabIndex = 10
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(22, 85)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(55, 13)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Max Hours:"
            '
            'seMaxDays
            '
            Me.seMaxDays.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seMaxDays.Location = New System.Drawing.Point(135, 53)
            Me.seMaxDays.Name = "seMaxDays"
            Me.seMaxDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seMaxDays.Properties.IsFloatValue = False
            Me.seMaxDays.Properties.Mask.EditMask = "N00"
            Me.seMaxDays.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seMaxDays.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.seMaxDays.Size = New System.Drawing.Size(104, 20)
            Me.seMaxDays.TabIndex = 8
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(22, 56)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(51, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Max Days:"
            '
            'panelControl1
            '
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.timeSpanEdit_Renamed)
            Me.panelControl1.Location = New System.Drawing.Point(30, 30)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(208, 281)
            Me.panelControl1.TabIndex = 1
            Me.panelControl1.Text = "Sample"
            '
            'timeSpanEdit_Renamed
            '
            Me.timeSpanEdit_Renamed.EditValue = System.TimeSpan.Parse("00:00:00")
            Me.timeSpanEdit_Renamed.Location = New System.Drawing.Point(16, 136)
            Me.timeSpanEdit_Renamed.Name = "timeSpanEdit_Renamed"
            Me.timeSpanEdit_Renamed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.timeSpanEdit_Renamed.Properties.Mask.EditMask = "dd.HH:mm:ss"
            Me.timeSpanEdit_Renamed.Size = New System.Drawing.Size(178, 20)
            Me.timeSpanEdit_Renamed.TabIndex = 0
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(952, 596)
            Me.xtraTabControl1.TabIndex = 1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            '
            'ModuleTimeSpanEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleTimeSpanEdit"
            Me.Size = New System.Drawing.Size(957, 601)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl.ResumeLayout(False)
            Me.tabPageDisplayFormat.ResumeLayout(False)
            Me.tabPageDisplayFormat.PerformLayout()
            CType(Me.teDisplayFormatString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbDisplayFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageEditFormat.ResumeLayout(False)
            Me.tabPageEditFormat.PerformLayout()
            CType(Me.teEditFormatString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbEditFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.ceReadOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowEditSeconds.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowEditMinutes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowEditHours.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceAllowEditDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seMaxSeconds.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seMaxMinutes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seMaxHours.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seMaxDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.timeSpanEdit_Renamed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private xtraTabPage1 As XtraTab.XtraTabPage
        Private groupControl1 As GroupControl
        Private teDisplayFormatString As TextEdit
        Private label2 As LabelControl
        Private label1 As LabelControl
        Private WithEvents cbDisplayFormat As ComboBoxEdit
        Private panelControl1 As GroupControl
        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private WithEvents seMaxDays As SpinEdit
        Private label3 As LabelControl
        Private groupControl2 As GroupControl
        Private lbValue As LabelControl
        Private WithEvents seMaxSeconds As SpinEdit
        Private label6 As LabelControl
        Private WithEvents seMaxMinutes As SpinEdit
        Private label5 As LabelControl
        Private WithEvents seMaxHours As SpinEdit
        Private label4 As LabelControl
        Private WithEvents ceAllowEditSeconds As CheckEdit
        Private WithEvents ceAllowEditMinutes As CheckEdit
        Private WithEvents ceAllowEditHours As CheckEdit
        Private WithEvents ceAllowEditDays As CheckEdit
        Private xtraTabControl As XtraTab.XtraTabControl
        Private tabPageDisplayFormat As XtraTab.XtraTabPage
		Private tabPageEditFormat As XtraTab.XtraTabPage
		Private teEditFormatString As TextEdit
		Private WithEvents cbEditFormat As ComboBoxEdit
		Private label7 As LabelControl
		Private label8 As LabelControl
		Private WithEvents ceReadOnly As CheckEdit
		Private WithEvents timeSpanEdit_Renamed As TimeSpanEdit

	End Class
End Namespace
