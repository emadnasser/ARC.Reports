Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents cmbLayout As DevExpress.XtraEditors.ComboBoxEdit
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected edtEnd As DevExpress.XtraEditors.DateEdit
		Protected edtStart As DevExpress.XtraEditors.DateEdit

		Private printInterval As TimeInterval = TimeInterval.Empty
		Private pagesPerWeek As Integer
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
		Private resourceCount As Integer

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property
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

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
			SubscribeEvents()
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
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(14))
		End Sub
		Private Sub InitializeControlValues()
			printInterval = New TimeInterval(BaseDate, BaseDate.AddDays(6))
			StartDate = printInterval.Start
			EndDate = printInterval.End

			Me.pagesPerWeek = Report.ColumnCount
			Me.cmbLayout.SelectedIndex = pagesPerWeek - 1
			InitializeResourceCount()
		End Sub
		Private Sub InitializeResourceCount()
			Me.spinResourceCount.Properties.MinValue = 1
			Me.spinResourceCount.Properties.MaxValue = SchedulerStorage.Resources.Count
			Me.resourceCount = Report.ResourceCount
			Me.spinResourceCount.Value = Me.resourceCount
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			StoragePrintAdapter.TimeInterval = printInterval
			MyBase.UpdateReportProperties(otherReport)
			Report.ColumnCount = pagesPerWeek
			Report.ResourceCount = resourceCount
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.cmbLayout = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
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
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(461, 396)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			Me.btnEdit.Size = New System.Drawing.Size(195, 22)
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			Me.navigationPaneSettings.Location = New System.Drawing.Point(461, 0)
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(239, 396)
			Me.navigationPaneSettings.Size = New System.Drawing.Size(239, 396)
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(209, 352)
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Controls.Add(Me.edtEnd)
			Me.layoutControlSettings.Controls.Add(Me.edtStart)
			Me.layoutControlSettings.Controls.Add(Me.cmbLayout)
			Me.layoutControlSettings.Controls.Add(Me.spinResourceCount)
			Me.layoutControlSettings.Size = New System.Drawing.Size(209, 352)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtStart, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "layoutControlGroup1"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(209, 352)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Size = New System.Drawing.Size(199, 26)
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
			Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 10)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 132)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(199, 210)
			' 
			' cmbLayout
			' 
			Me.cmbLayout.EditValue = "1 page/week"
			Me.cmbLayout.Location = New System.Drawing.Point(92, 67)
			Me.cmbLayout.Name = "cmbLayout"
			Me.cmbLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbLayout.Properties.Items.AddRange(New Object() { "1 page/week", "2 pages/week"})
			Me.cmbLayout.Size = New System.Drawing.Size(110, 20)
			Me.cmbLayout.StyleController = Me.layoutControlSettings
			Me.cmbLayout.TabIndex = 5
'			Me.cmbLayout.SelectedIndexChanged += New System.EventHandler(Me.cmbLayout_SelectedIndexChanged);
			' 
			' spinResourceCount
			' 
			Me.spinResourceCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Location = New System.Drawing.Point(92, 43)
			Me.spinResourceCount.Name = "spinResourceCount"
			Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinResourceCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(110, 20)
			Me.spinResourceCount.StyleController = Me.layoutControlSettings
			Me.spinResourceCount.TabIndex = 42
			' 
			' edtEnd
			' 
			Me.edtEnd.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtEnd.Location = New System.Drawing.Point(92, 115)
			Me.edtEnd.Name = "edtEnd"
			Me.edtEnd.Properties.AccessibleName = "End date:"
			Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtEnd.Size = New System.Drawing.Size(110, 20)
			Me.edtEnd.StyleController = Me.layoutControlSettings
			Me.edtEnd.TabIndex = 47
			' 
			' edtStart
			' 
			Me.edtStart.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtStart.Location = New System.Drawing.Point(92, 91)
			Me.edtStart.Name = "edtStart"
			Me.edtStart.Properties.AccessibleName = "Start date:"
			Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtStart.Size = New System.Drawing.Size(110, 20)
			Me.edtStart.StyleController = Me.layoutControlSettings
			Me.edtStart.TabIndex = 46
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinResourceCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(199, 24)
			Me.layoutControlItem2.Text = "Resource Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cmbLayout
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 60)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(199, 24)
			Me.layoutControlItem3.Text = "Layout:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.edtStart
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(199, 24)
			Me.layoutControlItem4.Text = "Start Date:"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.edtEnd
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 108)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(199, 24)
			Me.layoutControlItem5.Text = "End Date:"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
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
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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
		Protected Friend Overridable Sub UnsubscribeEvents()
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			RemoveHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
		End Sub
		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
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

		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.resourceCount = CInt(Fix(Me.spinResourceCount.Value))
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
		Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbLayout.SelectedIndexChanged
			Me.pagesPerWeek = cmbLayout.SelectedIndex + 1
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

