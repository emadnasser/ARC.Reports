Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle


	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected chkCompressWeekend As DevExpress.XtraEditors.CheckEdit
		Protected chkPrintExactlyOneMonth As DevExpress.XtraEditors.CheckEdit
		Protected chkDontPrintWeekends As DevExpress.XtraEditors.CheckEdit
		Private cmbLayout As DevExpress.XtraEditors.ComboBoxEdit

		Private initialized As Boolean
		Private dontPrintWeekends As Boolean
		Private compressWeekend As Boolean
		Private printExactlyOneMonth As Boolean
		Private visibleResourceCount As Integer = 0
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
		Private pageLayout As Integer = 1

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
			SubscribeEvents()
		End Sub

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.cmbLayout = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.chkCompressWeekend = New DevExpress.XtraEditors.CheckEdit()
			Me.chkPrintExactlyOneMonth = New DevExpress.XtraEditors.CheckEdit()
			Me.chkDontPrintWeekends = New DevExpress.XtraEditors.CheckEdit()
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
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(201, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 5
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
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Controls.Add(Me.chkPrintExactlyOneMonth)
			Me.layoutControlSettings.Controls.Add(Me.chkCompressWeekend)
			Me.layoutControlSettings.Controls.Add(Me.chkDontPrintWeekends)
			Me.layoutControlSettings.Controls.Add(Me.cmbLayout)
			Me.layoutControlSettings.Controls.Add(Me.spinResourceCount)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkDontPrintWeekends, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkCompressWeekend, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.chkPrintExactlyOneMonth, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem6, Me.layoutControlItem5})
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
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 153)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(205, 189)
			' 
			' spinResourceCount
			' 
			Me.spinResourceCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Location = New System.Drawing.Point(92, 43)
			Me.spinResourceCount.Name = "spinResourceCount"
			Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(116, 20)
			Me.spinResourceCount.StyleController = Me.layoutControlSettings
			Me.spinResourceCount.TabIndex = 42
			' 
			' cmbLayout
			' 
			Me.cmbLayout.EditValue = "1 page/week"
			Me.cmbLayout.Location = New System.Drawing.Point(92, 67)
			Me.cmbLayout.Name = "cmbLayout"
			Me.cmbLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbLayout.Properties.Items.AddRange(New Object() { "1 page/week", "2 pages/week"})
			Me.cmbLayout.Size = New System.Drawing.Size(116, 20)
			Me.cmbLayout.StyleController = Me.layoutControlSettings
			Me.cmbLayout.TabIndex = 45
			' 
			' chkCompressWeekend
			' 
			Me.chkCompressWeekend.Location = New System.Drawing.Point(7, 91)
			Me.chkCompressWeekend.Name = "chkCompressWeekend"
			Me.chkCompressWeekend.Properties.AutoWidth = True
			Me.chkCompressWeekend.Properties.Caption = "Compress Weekend"
			Me.chkCompressWeekend.Size = New System.Drawing.Size(117, 19)
			Me.chkCompressWeekend.StyleController = Me.layoutControlSettings
			Me.chkCompressWeekend.TabIndex = 48
			' 
			' chkPrintExactlyOneMonth
			' 
			Me.chkPrintExactlyOneMonth.Location = New System.Drawing.Point(7, 137)
			Me.chkPrintExactlyOneMonth.Name = "chkPrintExactlyOneMonth"
			Me.chkPrintExactlyOneMonth.Properties.AutoWidth = True
			Me.chkPrintExactlyOneMonth.Properties.Caption = "Print Exactly One Month Per Page"
			Me.chkPrintExactlyOneMonth.Size = New System.Drawing.Size(184, 19)
			Me.chkPrintExactlyOneMonth.StyleController = Me.layoutControlSettings
			Me.chkPrintExactlyOneMonth.TabIndex = 47
			' 
			' chkDontPrintWeekends
			' 
			Me.chkDontPrintWeekends.Location = New System.Drawing.Point(7, 114)
			Me.chkDontPrintWeekends.Name = "chkDontPrintWeekends"
			Me.chkDontPrintWeekends.Properties.AutoWidth = True
			Me.chkDontPrintWeekends.Properties.Caption = "Don't Print &Weekends"
			Me.chkDontPrintWeekends.Size = New System.Drawing.Size(125, 19)
			Me.chkDontPrintWeekends.StyleController = Me.layoutControlSettings
			Me.chkDontPrintWeekends.TabIndex = 46
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinResourceCount
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem2.Text = "Resource Count:"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.cmbLayout
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 60)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(205, 24)
			Me.layoutControlItem3.Text = "Layout:"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkDontPrintWeekends
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 107)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(205, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkCompressWeekend
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 84)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(205, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.chkPrintExactlyOneMonth
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 130)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(205, 23)
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextVisible = False
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
			Me.layoutControlSettings.PerformLayout()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' 
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub SubscribeEvents()
			AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
			AddHandler chkPrintExactlyOneMonth.CheckedChanged, AddressOf chkPrintExactlyOneMonth_CheckedChanged
			AddHandler chkDontPrintWeekends.CheckedChanged, AddressOf chkDontPrintWeekends_CheckedChanged
			AddHandler chkCompressWeekend.CheckedChanged, AddressOf chkCompressWeekend_CheckedChanged
			AddHandler cmbLayout.SelectedIndexChanged, AddressOf cmbLayout_SelectedIndexChanged
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Private Sub InitializeControlValues()
			Me.dontPrintWeekends = Report.DontPrintWeekends
			Me.compressWeekend = Report.CompressWeekend
			Me.visibleResourceCount = Report.VisibleResourceCount
			Me.printExactlyOneMonth = Report.PrintExactlyOneMonth
			Me.pageLayout = Report.ColumnCount - 1
			Me.cmbLayout.SelectedIndex = Me.pageLayout
			Me.spinResourceCount.Value = Me.visibleResourceCount
			Me.spinResourceCount.Properties.MinValue = 1
			Me.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount
			Me.chkCompressWeekend.Checked = Me.compressWeekend
			Me.chkDontPrintWeekends.Checked = Me.dontPrintWeekends
			Me.chkPrintExactlyOneMonth.Checked = Me.printExactlyOneMonth
			Me.initialized = True
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Report.DontPrintWeekends = Me.dontPrintWeekends
			Report.VisibleResourceCount = Me.visibleResourceCount
			Report.ColumnCount = Me.cmbLayout.SelectedIndex + 1
			Report.CompressWeekend = Me.compressWeekend
			Report.DontPrintWeekends = Me.dontPrintWeekends
			Report.PrintExactlyOneMonth = Me.printExactlyOneMonth
		End Sub
		Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.pageLayout = Me.cmbLayout.SelectedIndex + 1
			UpdateActiveReport()
		End Sub
		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.initialized) Then
				Return
			End If
			Me.visibleResourceCount = Convert.ToInt32(spinResourceCount.Value)
			UpdateActiveReport()
		End Sub
		Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.compressWeekend = Me.chkCompressWeekend.Checked
			UpdateActiveReport()
		End Sub
		Private Sub chkDontPrintWeekends_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.dontPrintWeekends = Me.chkDontPrintWeekends.Checked
			UpdateActiveReport()
		End Sub
		Private Sub chkPrintExactlyOneMonth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.printExactlyOneMonth = Me.chkPrintExactlyOneMonth.Checked
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

