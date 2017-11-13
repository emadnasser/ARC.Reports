Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private cmbFirstTimeScale As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected edtEnd As DevExpress.XtraEditors.DateEdit
		Protected edtStart As DevExpress.XtraEditors.DateEdit
		Private WithEvents spinIntervalCount As DevExpress.XtraEditors.SpinEdit
		Private cmbSecondTimeScale As DevExpress.XtraEditors.ComboBoxEdit

		Private printInterval As TimeInterval = TimeInterval.Empty
		Private visibleResourceCount As Integer
		Private visibleIntevalCount As Integer
		Private firstLevelTimeScale As String
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem6 As XtraLayout.LayoutControlItem
		Private layoutControlItem7 As XtraLayout.LayoutControlItem
		Private secondLevelTimeScale As String

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer. 
			InitializeComponent()
			PopulateFirstLevelScaleCombo()
			PopulateSecondLevelScaleCombo()
			InitializeControlValues()
			SubscribeEvents()
		End Sub
		Private Property EndDate() As DateTime
			Get
				Return edtEnd.DateTime.AddDays(1)
			End Get
			Set(ByVal value As DateTime)
				edtEnd.DateTime = value.AddDays(-1)
			End Set
		End Property
		Private Property StartDate() As DateTime
			Get
				Return edtStart.DateTime
			End Get
			Set(ByVal value As DateTime)
				edtStart.DateTime = value
			End Set
		End Property

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function

		Private Sub InitializeControlValues()
			visibleIntevalCount = Report.VisibleIntervalCount
			visibleResourceCount = Report.VisibleResourceCount

			firstLevelTimeScale = Report.FirstLevelTimeScale
			secondLevelTimeScale = Report.SecondLevelTimeScale
			cmbFirstTimeScale.EditValue = firstLevelTimeScale
			cmbSecondTimeScale.EditValue = secondLevelTimeScale

			spinIntervalCount.EditValue = visibleIntevalCount
			spinResourceCount.EditValue = visibleResourceCount

			printInterval = New TimeInterval(BaseDate.AddDays(-30), BaseDate.AddDays(30))
			StartDate = printInterval.Start
			EndDate = printInterval.End
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			StoragePrintAdapter.TimeInterval = printInterval

			MyBase.UpdateReportProperties(otherReport)
			Report.VisibleResourceCount = visibleResourceCount
			Report.VisibleIntervalCount = visibleIntevalCount
			Report.FirstLevelTimeScale = firstLevelTimeScale
			Report.SecondLevelTimeScale = secondLevelTimeScale
		End Sub
		Private Sub PopulateFirstLevelScaleCombo()
			cmbFirstTimeScale.Properties.Items.Clear()
			Dim scaleCount As Integer = Report.Scales.Count
			For i As Integer = 0 To scaleCount - 2
				cmbFirstTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
			Next i
			cmbFirstTimeScale.SelectedIndex = 0
			firstLevelTimeScale = CStr(cmbFirstTimeScale.SelectedItem)
		End Sub
		Private Sub PopulateSecondLevelScaleCombo()
			Dim index As Integer = cmbFirstTimeScale.SelectedIndex

			cmbSecondTimeScale.Properties.Items.Clear()
			For i As Integer = index + 1 To Report.Scales.Count - 1
				cmbSecondTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
			Next i
			cmbSecondTimeScale.SelectedIndex = 0
			secondLevelTimeScale = CStr(cmbSecondTimeScale.SelectedItem)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.cmbFirstTimeScale = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
			Me.spinIntervalCount = New DevExpress.XtraEditors.SpinEdit()
			Me.cmbSecondTimeScale = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPaneSettings.SuspendLayout()
			Me.navigationPageSettings.SuspendLayout()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlSettings.SuspendLayout()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()

			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(201, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(455, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(245, 396)
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.Size = New System.Drawing.Size(245, 396)
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(215, 352)
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.cmbSecondTimeScale)
			Me.layoutControlSettings.Controls.Add(Me.spinIntervalCount)
			Me.layoutControlSettings.Controls.Add(Me.edtEnd)
			Me.layoutControlSettings.Controls.Add(Me.edtStart)
			Me.layoutControlSettings.Controls.Add(Me.cmbFirstTimeScale)
			Me.layoutControlSettings.Controls.Add(Me.spinResourceCount)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbFirstTimeScale, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtStart, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinIntervalCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbSecondTimeScale, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "layoutControlGroup1"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7})
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(205, 26)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(205, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 180)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(205, 162)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' cmbFirstTimeScale
			' 
			Me.cmbFirstTimeScale.EditValue = ""
			Me.cmbFirstTimeScale.Location = New System.Drawing.Point(106, 139)
			Me.cmbFirstTimeScale.Name = "cmbFirstTimeScale"
			Me.cmbFirstTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbFirstTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbFirstTimeScale.Size = New System.Drawing.Size(102, 20)
			Me.cmbFirstTimeScale.StyleController = Me.layoutControlSettings
			Me.cmbFirstTimeScale.TabIndex = 5
			' 
			' spinResourceCount
			' 
			Me.spinResourceCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Location = New System.Drawing.Point(106, 43)
			Me.spinResourceCount.Name = "spinResourceCount"
			Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinResourceCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(102, 20)
			Me.spinResourceCount.StyleController = Me.layoutControlSettings
			Me.spinResourceCount.TabIndex = 46
'			Me.spinResourceCount.EditValueChanged += New System.EventHandler(Me.spinResourceCount_EditValueChanged);
			' 
			' edtEnd
			' 
			Me.edtEnd.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtEnd.Location = New System.Drawing.Point(106, 115)
			Me.edtEnd.Name = "edtEnd"
			Me.edtEnd.Properties.AccessibleName = "End date:"
			Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtEnd.Size = New System.Drawing.Size(102, 20)
			Me.edtEnd.StyleController = Me.layoutControlSettings
			Me.edtEnd.TabIndex = 43
			' 
			' edtStart
			' 
			Me.edtStart.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtStart.Location = New System.Drawing.Point(106, 91)
			Me.edtStart.Name = "edtStart"
			Me.edtStart.Properties.AccessibleName = "Start date:"
			Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtStart.Size = New System.Drawing.Size(102, 20)
			Me.edtStart.StyleController = Me.layoutControlSettings
			Me.edtStart.TabIndex = 42
			' 
			' spinIntervalCount
			' 
			Me.spinIntervalCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinIntervalCount.Location = New System.Drawing.Point(106, 67)
			Me.spinIntervalCount.Name = "spinIntervalCount"
			Me.spinIntervalCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinIntervalCount.Properties.IsFloatValue = False
			Me.spinIntervalCount.Properties.Mask.EditMask = "N00"
			Me.spinIntervalCount.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinIntervalCount.Size = New System.Drawing.Size(102, 20)
			Me.spinIntervalCount.StyleController = Me.layoutControlSettings
			Me.spinIntervalCount.TabIndex = 48
'			Me.spinIntervalCount.EditValueChanged += New System.EventHandler(Me.spinIntervalCount_EditValueChanged);
			' 
			' cmbSecondTimeScale
			' 
			Me.cmbSecondTimeScale.EditValue = ""
			Me.cmbSecondTimeScale.Location = New System.Drawing.Point(106, 163)
			Me.cmbSecondTimeScale.Name = "cmbSecondTimeScale"
			Me.cmbSecondTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbSecondTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbSecondTimeScale.Size = New System.Drawing.Size(102, 20)
			Me.cmbSecondTimeScale.StyleController = Me.layoutControlSettings
			Me.cmbSecondTimeScale.TabIndex = 51
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinResourceCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem2.Text = "Resource Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.spinIntervalCount
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 60)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem3.Text = "Interval Count:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(95, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.edtStart
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem4.Text = "Start Date:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(95, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.edtEnd
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 108)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem5.Text = "End Date:"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.cmbFirstTimeScale
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 132)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem6.Text = "First Level Scale:"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.cmbSecondTimeScale
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 156)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem7.Text = "Second Level Scale:"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(95, 13)
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "PreviewControl"
			Me.Controls.Add(Me.navigationPaneSettings)
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPaneSettings.ResumeLayout(False)
			Me.navigationPageSettings.ResumeLayout(False)
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlSettings.ResumeLayout(False)
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region
		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			Dim designForm As New CustomDesignForm()
			Dim report As XtraSchedulerReport = GetActiveReport()
			If report Is Nothing Then
				Return
			End If

			designForm.OpenReport(report)
			PreventUpdate = True
			Try
				ShowDesignerForm(designForm, Me.FindForm())
			Finally
				PreventUpdate = False
			End Try
			designForm.Dispose()

			CreateReports()
			UpdateActiveReport()
		End Sub
		Private Sub cmbFirstTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			firstLevelTimeScale = cmbFirstTimeScale.EditValue.ToString()

			PopulateSecondLevelScaleCombo()
			UpdateActiveReport()
		End Sub
		Private Sub cmbSecondTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			secondLevelTimeScale = cmbSecondTimeScale.EditValue.ToString()
			UpdateActiveReport()
		End Sub
		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinResourceCount.EditValueChanged
			visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
			UpdateActiveReport()
		End Sub

		Private Sub spinIntervalCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinIntervalCount.EditValueChanged
			visibleIntevalCount = Convert.ToInt32(spinIntervalCount.EditValue)
			UpdateActiveReport()
		End Sub
		Protected Friend Overridable Sub UnsubscribeEvents()
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			RemoveHandler cmbFirstTimeScale.SelectedIndexChanged, AddressOf cmbFirstTimeScale_SelectedIndexChanged
			RemoveHandler cmbSecondTimeScale.SelectedIndexChanged, AddressOf cmbSecondTimeScale_SelectedIndexChanged

		End Sub
		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			AddHandler cmbFirstTimeScale.SelectedIndexChanged, AddressOf cmbFirstTimeScale_SelectedIndexChanged
			AddHandler cmbSecondTimeScale.SelectedIndexChanged, AddressOf cmbSecondTimeScale_SelectedIndexChanged
		End Sub
		Protected Friend Overridable Function IsValidInterval(ByVal start As DateTime, ByVal [end] As DateTime) As Boolean
			Return start <= [end]
		End Function
		Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtEnd.EditValue = StartDate
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub

		Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtStart.EditValue = EndDate.AddDays(-1)
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub

	End Class
End Namespace

