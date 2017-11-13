Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents btnViewAppearance As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnResourceColorSchemas As DevExpress.XtraEditors.SimpleButton
		Private WithEvents cmbAppointmentSchema As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents cmbReportSchema As DevExpress.XtraEditors.ImageComboBoxEdit
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
		Private layoutControlItem5 As XtraLayout.LayoutControlItem
		Private layoutControlItem4 As XtraLayout.LayoutControlItem
		Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
		Private layoutControlItem3 As XtraLayout.LayoutControlItem

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
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(2))
		End Sub
		Private Sub InitializeControlValues()
			cmbReportSchema.EditValue = Report.ReportColorSchema
			cmbAppointmentSchema.EditValue = Report.AppointmentsColorSchema
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Report.ReportColorSchema = CType(cmbReportSchema.EditValue, PrintColorSchema)
			Report.AppointmentsColorSchema = CType(cmbAppointmentSchema.EditValue, PrintColorSchema)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
			Me.btnViewAppearance = New DevExpress.XtraEditors.SimpleButton()
			Me.btnResourceColorSchemas = New DevExpress.XtraEditors.SimpleButton()
			Me.cmbAppointmentSchema = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.cmbReportSchema = New DevExpress.XtraEditors.ImageComboBoxEdit()
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
			CType(Me.cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 34)
			Me.printControl.Size = New System.Drawing.Size(453, 362)
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(203, 22)
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
			Me.navigationPaneSettings.Location = New System.Drawing.Point(453, 34)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(247, 362)
			Me.navigationPaneSettings.Size = New System.Drawing.Size(247, 362)
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Image = (CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image))
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(217, 318)
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
			Me.layoutControlSettings.Controls.Add(Me.cmbAppointmentSchema)
			Me.layoutControlSettings.Controls.Add(Me.btnResourceColorSchemas)
			Me.layoutControlSettings.Controls.Add(Me.cmbReportSchema)
			Me.layoutControlSettings.Controls.Add(Me.btnViewAppearance)
			Me.layoutControlSettings.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 142, 650, 400)
			Me.layoutControlSettings.Size = New System.Drawing.Size(217, 318)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnViewAppearance, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbReportSchema, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnResourceColorSchemas, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.layoutControlSettings.Controls.SetChildIndex(Me.cmbAppointmentSchema, 0)
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.emptySpaceItem2})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.TextVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup1, Me.layoutControlItem3, Me.layoutControlItem2, Me.emptySpaceItem3})
			Me.layoutControlGroupSettings.Name = "Root"
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(217, 318)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			Me.layoutControlItem1.Size = New System.Drawing.Size(207, 26)
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
			Me.emptySpaceItem1.Size = New System.Drawing.Size(207, 10)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 176)
			Me.emptySpaceItem2.Size = New System.Drawing.Size(207, 132)
			' 
			' btnViewAppearance
			' 
			Me.btnViewAppearance.ImageIndex = 2
			Me.btnViewAppearance.Location = New System.Drawing.Point(7, 69)
			Me.btnViewAppearance.Name = "btnViewAppearance"
			Me.btnViewAppearance.Size = New System.Drawing.Size(203, 22)
			Me.btnViewAppearance.StyleController = Me.layoutControlSettings
			Me.btnViewAppearance.TabIndex = 0
			Me.btnViewAppearance.Text = "&Edit View Appearance..."
'			Me.btnViewAppearance.Click += New System.EventHandler(Me.btnEditAppearance_Click);
			' 
			' btnResourceColorSchemas
			' 
			Me.btnResourceColorSchemas.ImageIndex = 2
			Me.btnResourceColorSchemas.Location = New System.Drawing.Point(7, 43)
			Me.btnResourceColorSchemas.Name = "btnResourceColorSchemas"
			Me.btnResourceColorSchemas.Size = New System.Drawing.Size(203, 22)
			Me.btnResourceColorSchemas.StyleController = Me.layoutControlSettings
			Me.btnResourceColorSchemas.TabIndex = 1
			Me.btnResourceColorSchemas.Text = "&Edit Resource Color Schemas..."
'			Me.btnResourceColorSchemas.Click += New System.EventHandler(Me.btnResourceColorSchemas_Click);
			' 
			' cmbAppointmentSchema
			' 
			Me.cmbAppointmentSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default
			Me.cmbAppointmentSchema.Location = New System.Drawing.Point(83, 153)
			Me.cmbAppointmentSchema.Name = "cmbAppointmentSchema"
			Me.cmbAppointmentSchema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbAppointmentSchema.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)})
			Me.cmbAppointmentSchema.Size = New System.Drawing.Size(121, 20)
			Me.cmbAppointmentSchema.StyleController = Me.layoutControlSettings
			Me.cmbAppointmentSchema.TabIndex = 1
'			Me.cmbAppointmentSchema.SelectedIndexChanged += New System.EventHandler(Me.cmbAppointmentSchema_SelectedIndexChanged);
			' 
			' cmbReportSchema
			' 
			Me.cmbReportSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default
			Me.cmbReportSchema.Location = New System.Drawing.Point(83, 129)
			Me.cmbReportSchema.Name = "cmbReportSchema"
			Me.cmbReportSchema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbReportSchema.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)})
			Me.cmbReportSchema.Size = New System.Drawing.Size(121, 20)
			Me.cmbReportSchema.StyleController = Me.layoutControlSettings
			Me.cmbReportSchema.TabIndex = 0
'			Me.cmbReportSchema.SelectedIndexChanged += New System.EventHandler(Me.cmbReportSchema_SelectedIndexChanged);
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.btnViewAppearance
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 62)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(207, 26)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.btnResourceColorSchemas
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(207, 26)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.cmbReportSchema
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(195, 24)
			Me.layoutControlItem4.Text = "Report"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(66, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.cmbAppointmentSchema
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(195, 24)
			Me.layoutControlItem5.Text = "Appointments"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5, Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 98)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(207, 78)
			Me.layoutControlGroup1.Text = "Print Color Schema"
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.AllowHotTrack = False
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 88)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(207, 10)
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
			CType(Me.cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub btnEditAppearance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewAppearance.Click
		   AddHandler Report.Appearances.Changed, AddressOf Appearances_Changed
		   Try
			   Dim frm As New AppearancesEditForm(Report.Appearances, Me.FindForm())
			   frm.ShowDialog()
		   Finally
			   RemoveHandler Report.Appearances.Changed, AddressOf Appearances_Changed
		   End Try
		End Sub
		Private Sub Appearances_Changed(ByVal sender As Object, ByVal e As EventArgs)
			UpdateActiveReport()
		End Sub

		Private Sub btnResourceColorSchemas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResourceColorSchemas.Click
			AddHandler StoragePrintAdapter.ResourceColorsChanged, AddressOf StoragePrintAdapter_ResourceColorsChanged
			Try
				Dim frm As New ColorSchemasEditForm(StoragePrintAdapter.ResourceColorSchemas, Me.FindForm())
				frm.ShowDialog()
			Finally
				RemoveHandler StoragePrintAdapter.ResourceColorsChanged, AddressOf StoragePrintAdapter_ResourceColorsChanged
			End Try
		End Sub

		Private Sub StoragePrintAdapter_ResourceColorsChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateActiveReport()
		End Sub
		Public Sub ResourceColorSchemasChanged(ByVal sender As Object, ByVal e As CollectionChangedEventArgs(Of SchedulerColorSchema))
			UpdateActiveReport()
		End Sub

		Private Sub cmbAppointmentSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAppointmentSchema.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

		Private Sub cmbReportSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbReportSchema.SelectedIndexChanged
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

