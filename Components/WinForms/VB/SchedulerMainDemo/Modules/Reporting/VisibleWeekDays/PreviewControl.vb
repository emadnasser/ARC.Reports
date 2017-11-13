Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

	Public Class PreviewControl
		Inherits ReportPreviewControlBase
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents weekDaysCheckEdit1 As DevExpress.XtraScheduler.UI.WeekDaysCheckEdit
		Private visibleWeekDays_Renamed As WeekDays = WeekDays.EveryDay
		Private monthReport_Renamed As MonthReport
		Private WithEvents rgrpView As DevExpress.XtraEditors.RadioGroup
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private dayReport_Renamed As DayReport

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub
		Private ReadOnly Property ViewType() As SchedulerViewType
			Get
				Return CType(rgrpView.EditValue, SchedulerViewType)
			End Get
		End Property
		Private ReadOnly Property MonthReport() As MonthReport
			Get
				Return monthReport_Renamed
			End Get
		End Property
		Private ReadOnly Property DayReport() As DayReport
			Get
				Return dayReport_Renamed
			End Get
		End Property
		Private Property VisibleWeekDays() As WeekDays
			Get
				Return visibleWeekDays_Renamed
			End Get
			Set(ByVal value As WeekDays)
				visibleWeekDays_Renamed = value
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
		Protected Overrides Sub CreateReports()
			If monthReport_Renamed IsNot Nothing Then
				monthReport_Renamed.Dispose()
			End If
			Me.monthReport_Renamed = New MonthReport()
			If dayReport_Renamed IsNot Nothing Then
				dayReport_Renamed.Dispose()
			End If
			Me.dayReport_Renamed = New DayReport()
		End Sub
		Protected Overrides Function GetActiveReport() As XtraSchedulerReport
			If ViewType.Equals(SchedulerViewType.Month) Then
				Return MonthReport
			Else
				Return DayReport
			End If
		End Function
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(7 * 8))
		End Sub
		Private Sub InitializeControlValues()
			Dim report As IVisibleWeekDaysReport = CType(GetActiveReport(), IVisibleWeekDaysReport)
			Me.VisibleWeekDays = report.VisibleWeekDays

		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			If ViewType.Equals(SchedulerViewType.Month) Then
				CType(otherReport, MonthReport).VisibleWeekDays = Me.VisibleWeekDays
			Else
				Dim dayReport As DayReport = CType(otherReport, DayReport)
				dayReport.VisibleWeekDays = Me.VisibleWeekDays
				dayReport.DayCount = CalculateDayCount()
			End If
			UpdateFormatServices()
		End Sub
		Private Function CalculateDayCount() As Integer
			Dim dayCount As Integer = DevExpress.XtraScheduler.Native.DateTimeHelper.ToDayOfWeeks(Me.VisibleWeekDays).Length
			Return If(dayCount = 0, 7, dayCount)
		End Function
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.weekDaysCheckEdit1 = New DevExpress.XtraScheduler.UI.WeekDaysCheckEdit()
			Me.rgrpView = New DevExpress.XtraEditors.RadioGroup()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlSettings.SuspendLayout()
			CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPaneSettings.SuspendLayout()
			Me.navigationPageSettings.SuspendLayout()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(495, 441)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(184, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.weekDaysCheckEdit1)
			Me.layoutControlSettings.Controls.Add(Me.rgrpView)
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1051, 187, 650, 400)
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.Size = New System.Drawing.Size(198, 397)
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			' 
			' weekDaysCheckEdit1
			' 
			Me.weekDaysCheckEdit1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.weekDaysCheckEdit1.Appearance.Options.UseBackColor = True
			Me.weekDaysCheckEdit1.Location = New System.Drawing.Point(13, 161)
			Me.weekDaysCheckEdit1.Margin = New System.Windows.Forms.Padding(0)
			Me.weekDaysCheckEdit1.MaximumSize = New System.Drawing.Size(0, 100)
			Me.weekDaysCheckEdit1.MinimumSize = New System.Drawing.Size(0, 100)
			Me.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1"
			Me.weekDaysCheckEdit1.Size = New System.Drawing.Size(172, 100)
			Me.weekDaysCheckEdit1.TabIndex = 6
'			Me.weekDaysCheckEdit1.WeekDaysChanged += New System.EventHandler(Me.weekDaysCheckEdit1_WeekDaysChanged_1);
			' 
			' rgrpView
			' 
			Me.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.rgrpView.Location = New System.Drawing.Point(13, 67)
			Me.rgrpView.MaximumSize = New System.Drawing.Size(0, 50)
			Me.rgrpView.MinimumSize = New System.Drawing.Size(0, 50)
			Me.rgrpView.Name = "rgrpView"
			Me.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpView.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpView.Properties.Columns = 1
			Me.rgrpView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Day, "Day"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month")})
			Me.rgrpView.Size = New System.Drawing.Size(172, 50)
			Me.rgrpView.StyleController = Me.layoutControlSettings
			Me.rgrpView.TabIndex = 81
'			Me.rgrpView.SelectedIndexChanged += New System.EventHandler(Me.rgrpView_SelectedIndexChanged_1);
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem2, Me.layoutControlGroup1, Me.layoutControlGroup2, Me.emptySpaceItem3, Me.emptySpaceItem1})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(198, 397)
			Me.layoutControlGroupSettings.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(188, 26)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 264)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(188, 123)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(188, 84)
			Me.layoutControlGroup1.Text = "Report Type"
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.rgrpView
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(176, 54)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 130)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(188, 134)
			Me.layoutControlGroup2.Text = "Visible Weekdays"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.weekDaysCheckEdit1
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(176, 104)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 120)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(188, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.AllowHotTrack = False
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
			Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(188, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(495, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(225, 441)
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.Size = New System.Drawing.Size(225, 441)
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(198, 397)
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.navigationPaneSettings)
			Me.Name = "PreviewControl"
			Me.Size = New System.Drawing.Size(720, 441)
			Me.Controls.SetChildIndex(Me.navigationPaneSettings, 0)
			Me.Controls.SetChildIndex(Me.printControl, 0)
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlSettings.ResumeLayout(False)
			CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPaneSettings.ResumeLayout(False)
			Me.navigationPageSettings.ResumeLayout(False)
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
		Private Sub weekDaysCheckEdit1_WeekDaysChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles weekDaysCheckEdit1.WeekDaysChanged
			Me.VisibleWeekDays = weekDaysCheckEdit1.WeekDays
			UpdateActiveReport()
		End Sub

		Private Sub rgrpView_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpView.SelectedIndexChanged
			Me.VisibleWeekDays = weekDaysCheckEdit1.WeekDays
			UpdateActiveReport()
		End Sub

		Public Sub UpdateFormatServices()
			StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
			Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService("MM/dd, ddd")
			StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)
		End Sub
	End Class
	Public Interface IVisibleWeekDaysReport
		Property VisibleWeekDays() As WeekDays
	End Interface
End Namespace

