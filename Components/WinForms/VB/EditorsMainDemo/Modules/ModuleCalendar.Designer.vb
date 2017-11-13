Namespace DevExpress.XtraEditors.Demos
    Partial Public Class ModuleCalendar
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
            Dim contextButton1 As New DevExpress.Utils.ContextButton()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.calendarControl1 = New DevExpress.XtraEditors.Controls.CalendarControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.icbFirstDayOfWeek = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.icbColumnCount = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbRowCount = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.icbShowInactiveDays = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowMonthName = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowFooter = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowHeader = New DevExpress.XtraEditors.CheckEdit()
            Me.icbShowVistaClock = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.icbVistaDisplayMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowWeekNumbers = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowToday = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowClear = New DevExpress.XtraEditors.CheckEdit()
            Me.icbWeekNumberRule = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.calendarControl2 = New DevExpress.XtraEditors.Controls.CalendarControl()
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.calendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            DirectCast(Me.icbFirstDayOfWeek.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbColumnCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbRowCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbShowInactiveDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowMonthName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbShowVistaClock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbVistaDisplayMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowToday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowClear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.calendarControl2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(1019, 732)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Tomato
            Me.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
            Me.xtraTabPage1.Controls.Add(Me.calendarControl1)
            Me.xtraTabPage1.Controls.Add(Me.groupControl2)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1013, 704)
            Me.xtraTabPage1.Text = "Sample"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl2.Appearance.Options.UseBackColor = True
            Me.groupControl2.Controls.Add(Me.listBoxControl1)
            Me.groupControl2.Location = New System.Drawing.Point(476, 444)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(289, 142)
            Me.groupControl2.TabIndex = 4
            Me.groupControl2.Text = "Selected Ranges"
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(2, 20)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(285, 120)
            Me.listBoxControl1.TabIndex = 0
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calendarControl1.Location = New System.Drawing.Point(17, 21)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple
            Me.calendarControl1.ShowMonthHeaders = False
            Me.calendarControl1.Size = New System.Drawing.Size(255, 214)
            Me.calendarControl1.SyncSelectionWithEditValue = False
            Me.calendarControl1.TabIndex = 0
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.labelControl6)
            Me.groupControl1.Controls.Add(Me.icbFirstDayOfWeek)
            Me.groupControl1.Controls.Add(Me.labelControl5)
            Me.groupControl1.Controls.Add(Me.labelControl4)
            Me.groupControl1.Controls.Add(Me.icbColumnCount)
            Me.groupControl1.Controls.Add(Me.icbRowCount)
            Me.groupControl1.Controls.Add(Me.labelControl3)
            Me.groupControl1.Controls.Add(Me.icbShowInactiveDays)
            Me.groupControl1.Controls.Add(Me.ceShowMonthName)
            Me.groupControl1.Controls.Add(Me.ceShowFooter)
            Me.groupControl1.Controls.Add(Me.ceShowHeader)
            Me.groupControl1.Controls.Add(Me.icbShowVistaClock)
            Me.groupControl1.Controls.Add(Me.labelControl2)
            Me.groupControl1.Controls.Add(Me.icbVistaDisplayMode)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.ceShowWeekNumbers)
            Me.groupControl1.Controls.Add(Me.ceShowToday)
            Me.groupControl1.Controls.Add(Me.ceShowClear)
            Me.groupControl1.Controls.Add(Me.icbWeekNumberRule)
            Me.groupControl1.Controls.Add(Me.label1)
            Me.groupControl1.Location = New System.Drawing.Point(476, 21)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(289, 417)
            Me.groupControl1.TabIndex = 3
            Me.groupControl1.Text = "Properties"
            ' 
            ' labelControl6
            ' 
            Me.labelControl6.Location = New System.Drawing.Point(20, 124)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(83, 13)
            Me.labelControl6.TabIndex = 30
            Me.labelControl6.Text = "First day of week"
            ' 
            ' icbFirstDayOfWeek
            ' 
            Me.icbFirstDayOfWeek.EditValue = "imageComboBoxEdit1"
            Me.icbFirstDayOfWeek.Location = New System.Drawing.Point(149, 121)
            Me.icbFirstDayOfWeek.Name = "icbFirstDayOfWeek"
            Me.icbFirstDayOfWeek.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbFirstDayOfWeek.Size = New System.Drawing.Size(112, 20)
            Me.icbFirstDayOfWeek.TabIndex = 29
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.Location = New System.Drawing.Point(20, 210)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(67, 13)
            Me.labelControl5.TabIndex = 28
            Me.labelControl5.Text = "Column Count"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(20, 182)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(53, 13)
            Me.labelControl4.TabIndex = 27
            Me.labelControl4.Text = "Row Count"
            ' 
            ' icbColumnCount
            ' 
            Me.icbColumnCount.EditValue = "imageComboBoxEdit1"
            Me.icbColumnCount.Location = New System.Drawing.Point(149, 207)
            Me.icbColumnCount.Name = "icbColumnCount"
            Me.icbColumnCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColumnCount.Size = New System.Drawing.Size(112, 20)
            Me.icbColumnCount.TabIndex = 26
            ' 
            ' icbRowCount
            ' 
            Me.icbRowCount.EditValue = "imageComboBoxEdit1"
            Me.icbRowCount.Location = New System.Drawing.Point(149, 179)
            Me.icbRowCount.Name = "icbRowCount"
            Me.icbRowCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbRowCount.Size = New System.Drawing.Size(112, 20)
            Me.icbRowCount.TabIndex = 25
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(20, 154)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(105, 13)
            Me.labelControl3.TabIndex = 24
            Me.labelControl3.Text = "Inactive days visibility"
            ' 
            ' icbShowInactiveDays
            ' 
            Me.icbShowInactiveDays.EditValue = "imageComboBoxEdit1"
            Me.icbShowInactiveDays.Location = New System.Drawing.Point(149, 151)
            Me.icbShowInactiveDays.Name = "icbShowInactiveDays"
            Me.icbShowInactiveDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowInactiveDays.Size = New System.Drawing.Size(112, 20)
            Me.icbShowInactiveDays.TabIndex = 23
            ' 
            ' ceShowMonthName
            ' 
            Me.ceShowMonthName.Location = New System.Drawing.Point(20, 301)
            Me.ceShowMonthName.Name = "ceShowMonthName"
            Me.ceShowMonthName.Properties.Caption = "Show month headers"
            Me.ceShowMonthName.Size = New System.Drawing.Size(168, 19)
            Me.ceShowMonthName.TabIndex = 22
            ' 
            ' ceShowFooter
            ' 
            Me.ceShowFooter.Location = New System.Drawing.Point(20, 276)
            Me.ceShowFooter.Name = "ceShowFooter"
            Me.ceShowFooter.Properties.Caption = "Show footer"
            Me.ceShowFooter.Size = New System.Drawing.Size(168, 19)
            Me.ceShowFooter.TabIndex = 21
            ' 
            ' ceShowHeader
            ' 
            Me.ceShowHeader.Location = New System.Drawing.Point(20, 251)
            Me.ceShowHeader.Name = "ceShowHeader"
            Me.ceShowHeader.Properties.Caption = "Show header"
            Me.ceShowHeader.Size = New System.Drawing.Size(168, 19)
            Me.ceShowHeader.TabIndex = 20
            ' 
            ' icbShowVistaClock
            ' 
            Me.icbShowVistaClock.EditValue = "imageComboBoxEdit1"
            Me.icbShowVistaClock.Location = New System.Drawing.Point(149, 61)
            Me.icbShowVistaClock.Name = "icbShowVistaClock"
            Me.icbShowVistaClock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowVistaClock.Size = New System.Drawing.Size(112, 20)
            Me.icbShowVistaClock.TabIndex = 18
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(20, 64)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(107, 13)
            Me.labelControl2.TabIndex = 19
            Me.labelControl2.Text = "Calendar Time Editing:"
            ' 
            ' icbVistaDisplayMode
            ' 
            Me.icbVistaDisplayMode.EditValue = "imageComboBoxEdit1"
            Me.icbVistaDisplayMode.Location = New System.Drawing.Point(149, 32)
            Me.icbVistaDisplayMode.Name = "icbVistaDisplayMode"
            Me.icbVistaDisplayMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbVistaDisplayMode.Size = New System.Drawing.Size(112, 20)
            Me.icbVistaDisplayMode.TabIndex = 0
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(20, 35)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(72, 13)
            Me.labelControl1.TabIndex = 17
            Me.labelControl1.Text = "Calendar View:"
            ' 
            ' ceShowWeekNumbers
            ' 
            Me.ceShowWeekNumbers.Location = New System.Drawing.Point(20, 376)
            Me.ceShowWeekNumbers.Name = "ceShowWeekNumbers"
            Me.ceShowWeekNumbers.Properties.Caption = "Show week numbers"
            Me.ceShowWeekNumbers.Size = New System.Drawing.Size(168, 19)
            Me.ceShowWeekNumbers.TabIndex = 5
            ' 
            ' ceShowToday
            ' 
            Me.ceShowToday.Location = New System.Drawing.Point(20, 351)
            Me.ceShowToday.Name = "ceShowToday"
            Me.ceShowToday.Properties.Caption = "Show Today button"
            Me.ceShowToday.Size = New System.Drawing.Size(168, 19)
            Me.ceShowToday.TabIndex = 4
            ' 
            ' ceShowClear
            ' 
            Me.ceShowClear.Location = New System.Drawing.Point(20, 326)
            Me.ceShowClear.Name = "ceShowClear"
            Me.ceShowClear.Properties.Caption = "Show Clear button"
            Me.ceShowClear.Size = New System.Drawing.Size(168, 19)
            Me.ceShowClear.TabIndex = 3
            ' 
            ' icbWeekNumberRule
            ' 
            Me.icbWeekNumberRule.EditValue = "imageComboBoxEdit1"
            Me.icbWeekNumberRule.Location = New System.Drawing.Point(149, 90)
            Me.icbWeekNumberRule.Name = "icbWeekNumberRule"
            Me.icbWeekNumberRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbWeekNumberRule.Size = New System.Drawing.Size(112, 20)
            Me.icbWeekNumberRule.TabIndex = 2
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(20, 93)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(91, 13)
            Me.label1.TabIndex = 15
            Me.label1.Text = "Week number rule:"
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.flyoutPanel1)
            Me.xtraTabPage2.Controls.Add(Me.calendarControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(1013, 704)
            Me.xtraTabPage2.Text = "Custom"
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Controls.Add(Me.memoEdit1)
            Me.flyoutPanel1.Location = New System.Drawing.Point(793, 74)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.Size = New System.Drawing.Size(207, 122)
            Me.flyoutPanel1.TabIndex = 2
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.memoEdit1.Size = New System.Drawing.Size(207, 122)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' calendarControl2
            ' 
            Me.calendarControl2.AllowClickInactiveDays = False
            Me.calendarControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.calendarControl2.CalendarAppearance.CalendarHeader.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.CalendarHeader.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.CalendarHeader.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.CalendarHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.calendarControl2.CalendarAppearance.DayCell.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCell.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCell.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.DayCellHighlighted.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCellHighlighted.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCellHighlighted.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCellHighlighted.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.DayCellHoliday.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCellHoliday.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCellHoliday.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCellHoliday.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.DayCellInactive.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCellInactive.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCellInactive.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCellInactive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.DayCellPressed.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCellPressed.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCellPressed.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCellPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.DayCellSelected.Font = New System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.DayCellSelected.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.DayCellSelected.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.DayCellSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.calendarControl2.CalendarAppearance.WeekDay.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.calendarControl2.CalendarAppearance.WeekDay.ForeColor = System.Drawing.Color.Gray
            Me.calendarControl2.CalendarAppearance.WeekDay.Options.UseFont = True
            Me.calendarControl2.CalendarAppearance.WeekDay.Options.UseForeColor = True
            Me.calendarControl2.CalendarAppearance.WeekDay.Options.UseTextOptions = True
            Me.calendarControl2.CalendarAppearance.WeekDay.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.calendarControl2.CalendarAppearance.WeekDay.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
            Me.calendarControl2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calendarControl2.CaseMonthNames = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase
            Me.calendarControl2.CellPadding = New System.Windows.Forms.Padding(2)
            Me.calendarControl2.CellSize = New System.Drawing.Size(80, 80)
            contextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar
            contextButton1.Id = New System.Guid("add60edd-5f9a-4d98-b09d-f716aaa46999")
            contextButton1.Name = "ContextButton"
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            Me.calendarControl2.ContextButtons.Add(contextButton1)
            Me.calendarControl2.DateTime = New Date(2015, 7, 1, 0, 0, 0, 0)
            Me.calendarControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.calendarControl2.DrawCellLines = True
            Me.calendarControl2.EditValue = New Date(2015, 7, 1, 0, 0, 0, 0)
            Me.calendarControl2.Location = New System.Drawing.Point(0, 0)
            Me.calendarControl2.Name = "calendarControl2"
            Me.calendarControl2.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.calendarControl2.ShowFooter = False
            Me.calendarControl2.ShowHeader = False
            Me.calendarControl2.ShowMonthHeaders = True
            Me.calendarControl2.Size = New System.Drawing.Size(1013, 574)
            Me.calendarControl2.TabIndex = 1
            Me.calendarControl2.WeekDayAbbreviationLength = 3
            ' 
            ' ModuleCalendar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleCalendar"
            Me.Size = New System.Drawing.Size(1024, 737)
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage1.PerformLayout()
            DirectCast(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.calendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            DirectCast(Me.icbFirstDayOfWeek.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbColumnCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbRowCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbShowInactiveDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowMonthName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbShowVistaClock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbVistaDisplayMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowToday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowClear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            Me.xtraTabPage2.PerformLayout()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.calendarControl2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private WithEvents xtraTabPage1 As XtraTab.XtraTabPage
        Private xtraTabPage2 As XtraTab.XtraTabPage
        Private WithEvents calendarControl1 As Controls.CalendarControl
        Private groupControl1 As GroupControl
        Private WithEvents icbShowVistaClock As ImageComboBoxEdit
        Private labelControl2 As LabelControl
        Private WithEvents icbVistaDisplayMode As ImageComboBoxEdit
        Private labelControl1 As LabelControl
        Private WithEvents ceShowWeekNumbers As CheckEdit
        Private WithEvents ceShowToday As CheckEdit
        Private WithEvents ceShowClear As CheckEdit
        Private WithEvents icbWeekNumberRule As ImageComboBoxEdit
        Private label1 As LabelControl
        Private WithEvents ceShowMonthName As CheckEdit
        Private WithEvents ceShowFooter As CheckEdit
        Private WithEvents ceShowHeader As CheckEdit
        Private labelControl3 As LabelControl
        Private WithEvents icbShowInactiveDays As ImageComboBoxEdit
        Private labelControl5 As LabelControl
        Private labelControl4 As LabelControl
        Private WithEvents icbColumnCount As ImageComboBoxEdit
        Private WithEvents icbRowCount As ImageComboBoxEdit
        Private labelControl6 As LabelControl
        Private WithEvents icbFirstDayOfWeek As ImageComboBoxEdit
        Private WithEvents calendarControl2 As Controls.CalendarControl
        Private flyoutPanel1 As Utils.FlyoutPanel
        Private memoEdit1 As MemoEdit
        Private groupControl2 As GroupControl
        Private listBoxControl1 As ListBoxControl

    End Class
End Namespace
