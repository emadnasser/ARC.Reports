Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Windows.Forms
Imports System.IO

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

	Public Class PreviewControl
		Inherits ReportPreviewControlBase
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents rgrpView As DevExpress.XtraEditors.RadioGroup
		Private monthReport_Renamed As MonthReport
		Private WithEvents spinHeight As DevExpress.XtraEditors.SpinEdit
		Protected WithEvents chkCanGrow As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents chkCanShrink As DevExpress.XtraEditors.CheckEdit
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem3 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private timelineReport_Renamed As TimelineReport


		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			printControl.Zoom = 0.6f
			InitializeControlValues()
		End Sub

		Private ReadOnly Property MonthReport() As MonthReport
			Get
				Return monthReport_Renamed
			End Get
		End Property
		Private ReadOnly Property TimelineReport() As TimelineReport
			Get
				Return timelineReport_Renamed
			End Get
		End Property
		Private ReadOnly Property ViewType() As SchedulerViewType
			Get
				Return CType(rgrpView.EditValue, SchedulerViewType)
			End Get
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
		Protected Overrides Sub CreateReports()
			If monthReport_Renamed IsNot Nothing Then
				monthReport_Renamed.Dispose()
			End If
			Me.monthReport_Renamed = New MonthReport()
			If timelineReport_Renamed IsNot Nothing Then
				timelineReport_Renamed.Dispose()
			End If
			Me.timelineReport_Renamed = New TimelineReport()
		End Sub
		Protected Overrides Function GetActiveReport() As XtraSchedulerReport
			If ViewType.Equals(SchedulerViewType.Month) Then
				Return MonthReport
			Else
				Return TimelineReport
			End If
		End Function
		Protected Overrides Sub FillReportSourceData()
			DemoUtils.FillReportsStorageData(SchedulerStorage)
		End Sub
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date.AddDays(17), TimeSpan.FromDays(14))
		End Sub
		Private Sub InitializeControlValues()
			Dim report As IAutoHeightReport = CType(GetActiveReport(), IAutoHeightReport)
			chkCanShrink.Checked = report.CellsCanShrink
			chkCanGrow.Checked = report.CellsCanGrow
			spinHeight.Value = CDec(report.CellsHeight)
		End Sub

		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Dim autoHeightReport As IAutoHeightReport = CType(otherReport, IAutoHeightReport)
			autoHeightReport.CellsHeight = CSng(spinHeight.Value)
			autoHeightReport.CellsCanGrow = chkCanGrow.Checked
			autoHeightReport.CellsCanShrink = chkCanShrink.Checked
		End Sub


		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.rgrpView = New DevExpress.XtraEditors.RadioGroup()
			Me.spinHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.chkCanShrink = New DevExpress.XtraEditors.CheckEdit()
			Me.chkCanGrow = New DevExpress.XtraEditors.CheckEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
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
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(485, 396)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(171, 22)
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
			Me.navigationPaneSettings.Location = New System.Drawing.Point(485, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(215, 396)
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.Size = New System.Drawing.Size(215, 396)
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
			Me.navigationPageSettings.Size = New System.Drawing.Size(185, 352)
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.spinHeight)
			Me.layoutControlSettings.Controls.Add(Me.chkCanGrow)
			Me.layoutControlSettings.Controls.Add(Me.rgrpView)
			Me.layoutControlSettings.Controls.Add(Me.chkCanShrink)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Size = New System.Drawing.Size(185, 352)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkCanShrink, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.rgrpView, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkCanGrow, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinHeight, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1, Me.layoutControlGroup2, Me.emptySpaceItem3})
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(185, 352)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Size = New System.Drawing.Size(175, 26)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem1.Size = New System.Drawing.Size(175, 10)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 225)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(175, 117)
			' 
			' rgrpView
			' 
			Me.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.rgrpView.Location = New System.Drawing.Point(13, 67)
			Me.rgrpView.MaximumSize = New System.Drawing.Size(0, 45)
			Me.rgrpView.MinimumSize = New System.Drawing.Size(0, 45)
			Me.rgrpView.Name = "rgrpView"
			Me.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpView.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpView.Properties.Columns = 1
			Me.rgrpView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Timeline, "Timeline")})
			Me.rgrpView.Size = New System.Drawing.Size(159, 45)
			Me.rgrpView.StyleController = Me.layoutControlSettings
			Me.rgrpView.TabIndex = 5
'			Me.rgrpView.SelectedIndexChanged += New System.EventHandler(Me.rgrpView_SelectedIndexChanged);
			' 
			' spinHeight
			' 
			Me.spinHeight.EditValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.spinHeight.Location = New System.Drawing.Point(52, 156)
			Me.spinHeight.Name = "spinHeight"
			Me.spinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinHeight.Properties.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinHeight.Properties.IsFloatValue = False
			Me.spinHeight.Properties.Mask.EditMask = "N00"
			Me.spinHeight.Properties.MaxValue = New Decimal(New Integer() { 800, 0, 0, 0})
			Me.spinHeight.Properties.MinValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.spinHeight.Size = New System.Drawing.Size(120, 20)
			Me.spinHeight.StyleController = Me.layoutControlSettings
			Me.spinHeight.TabIndex = 39
'			Me.spinHeight.EditValueChanged += New System.EventHandler(Me.spinHeight_EditValueChanged);
			' 
			' chkCanShrink
			' 
			Me.chkCanShrink.Location = New System.Drawing.Point(13, 180)
			Me.chkCanShrink.Name = "chkCanShrink"
			Me.chkCanShrink.Properties.AutoWidth = True
			Me.chkCanShrink.Properties.Caption = "Can Shrink"
			Me.chkCanShrink.Size = New System.Drawing.Size(73, 19)
			Me.chkCanShrink.StyleController = Me.layoutControlSettings
			Me.chkCanShrink.TabIndex = 50
'			Me.chkCanShrink.CheckedChanged += New System.EventHandler(Me.chkCanShrink_CheckedChanged);
			' 
			' chkCanGrow
			' 
			Me.chkCanGrow.Location = New System.Drawing.Point(13, 203)
			Me.chkCanGrow.Name = "chkCanGrow"
			Me.chkCanGrow.Properties.AutoWidth = True
			Me.chkCanGrow.Properties.Caption = "Can Grow"
			Me.chkCanGrow.Size = New System.Drawing.Size(69, 19)
			Me.chkCanGrow.StyleController = Me.layoutControlSettings
			Me.chkCanGrow.TabIndex = 51
'			Me.chkCanGrow.CheckedChanged += New System.EventHandler(Me.chkCanGrow_CheckedChanged);
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.rgrpView
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(163, 49)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(175, 79)
			Me.layoutControlGroup1.Text = "Report Type"
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.spinHeight
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(163, 24)
			Me.layoutControlItem3.Text = "Height:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkCanShrink
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(163, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkCanGrow
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 47)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(163, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 125)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(175, 100)
			Me.layoutControlGroup2.Text = "Cells Options"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 115)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(175, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
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
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub rgrpView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpView.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

		Private Sub spinHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinHeight.EditValueChanged
			UpdateActiveReport()
		End Sub
		Private Sub chkCanShrink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCanShrink.CheckedChanged
			UpdateActiveReport()
		End Sub

		Private Sub chkCanGrow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCanGrow.CheckedChanged
			UpdateActiveReport()
		End Sub

		Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateActiveReport()
		End Sub

	End Class

	Public Interface IAutoHeightReport
		Property CellsCanShrink() As Boolean
		Property CellsCanGrow() As Boolean
		Property CellsHeight() As Single

	End Interface
End Namespace

