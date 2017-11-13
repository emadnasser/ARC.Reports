Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents spinColumnCount As DevExpress.XtraEditors.SpinEdit
		Private WithEvents rgrpColumnArrangement As DevExpress.XtraEditors.RadioGroup

		Private visibleWeekDayColumnCount As Integer = 0
		Private navigationPaneSettings As XtraBars.Navigation.NavigationPane
		Private navigationPageSettings As XtraBars.Navigation.NavigationPage
		Private layoutControlSettings As XtraLayout.LayoutControl
		Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private columnArrangement As ColumnArrangementMode = ColumnArrangementMode.Ascending

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub
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
			visibleWeekDayColumnCount = Report.VisibleWeekDayColumnCount
			columnArrangement = Report.ColumnArrangement

			spinColumnCount.Value = visibleWeekDayColumnCount
			rgrpColumnArrangement.EditValue = columnArrangement
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Report.VisibleWeekDayColumnCount = visibleWeekDayColumnCount
			Report.ColumnArrangement = columnArrangement
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.spinColumnCount = New DevExpress.XtraEditors.SpinEdit()
			Me.rgrpColumnArrangement = New DevExpress.XtraEditors.RadioGroup()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
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
			CType(Me.spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.layoutControlSettings.Controls.Add(Me.rgrpColumnArrangement)
			Me.layoutControlSettings.Controls.Add(Me.spinColumnCount)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinColumnCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.rgrpColumnArrangement, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlGroup1, Me.emptySpaceItem3})
			Me.layoutControlGroupSettings.Name = "Root"
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
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 154)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(205, 188)
			' 
			' spinColumnCount
			' 
			Me.spinColumnCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumnCount.Location = New System.Drawing.Point(136, 43)
			Me.spinColumnCount.Name = "spinColumnCount"
			Me.spinColumnCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinColumnCount.Properties.IsFloatValue = False
			Me.spinColumnCount.Properties.Mask.EditMask = "N00"
			Me.spinColumnCount.Properties.MaxValue = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.spinColumnCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumnCount.Size = New System.Drawing.Size(72, 20)
			Me.spinColumnCount.StyleController = Me.layoutControlSettings
			Me.spinColumnCount.TabIndex = 3
'			Me.spinColumnCount.EditValueChanged += New System.EventHandler(Me.spinColumnPerPage_EditValueChanged);
			' 
			' rgrpColumnArrangement
			' 
			Me.rgrpColumnArrangement.Location = New System.Drawing.Point(13, 101)
			Me.rgrpColumnArrangement.MaximumSize = New System.Drawing.Size(0, 50)
			Me.rgrpColumnArrangement.MinimumSize = New System.Drawing.Size(0, 50)
			Me.rgrpColumnArrangement.Name = "rgrpColumnArrangement"
			Me.rgrpColumnArrangement.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpColumnArrangement.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpColumnArrangement.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpColumnArrangement.Properties.Columns = 1
			Me.rgrpColumnArrangement.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Ascending, "Ascending"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Descending, "Descending")})
			Me.rgrpColumnArrangement.Size = New System.Drawing.Size(189, 50)
			Me.rgrpColumnArrangement.StyleController = Me.layoutControlSettings
			Me.rgrpColumnArrangement.TabIndex = 7
'			Me.rgrpColumnArrangement.SelectedIndexChanged += New System.EventHandler(Me.rgrpColumnMode_SelectedIndexChanged);
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinColumnCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem2.Text = "WeekDays Column Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(125, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.rgrpColumnArrangement
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(193, 54)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 70)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(205, 84)
			Me.layoutControlGroup1.Text = "Column Arrangement"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 60)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(205, 10)
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
			CType(Me.spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private Sub spinColumnPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinColumnCount.EditValueChanged
			Me.visibleWeekDayColumnCount = Convert.ToInt32(spinColumnCount.Value)
			UpdateActiveReport()
		End Sub
		Private Sub rgrpColumnMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpColumnArrangement.SelectedIndexChanged
			Me.columnArrangement = CType(rgrpColumnArrangement.EditValue, ColumnArrangementMode)
			UpdateActiveReport()
		End Sub

		Private Sub lbResourceCount_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub labelControl1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace

