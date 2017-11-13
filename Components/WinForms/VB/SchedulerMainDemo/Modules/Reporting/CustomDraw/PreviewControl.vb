Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing

		Private allowCustomDrawDayHeader As Boolean
		Private allowCustomDrawResourceHeader As Boolean
		Private allowCustomDrawAllDayArea As Boolean
		Private allowCustomDrawTimeCell As Boolean
		Private allowCustomDrawTimeRuler As Boolean
		Private allowCustomDrawAppointment As Boolean
		Private WithEvents chkTimeRuler As CheckEdit
		Private WithEvents chkAppointmentBackground As CheckEdit
		Private WithEvents chkAppointment As CheckEdit
		Private WithEvents chkDayViewAllDayArea As CheckEdit
		Private WithEvents chkTimeCell As CheckEdit
		Private WithEvents chkDayHeader As CheckEdit
		Private WithEvents chkResourceHeader As CheckEdit
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
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private allowCustomDrawAppointmentBackground As Boolean


		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
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
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(7))
		End Sub
		Private Sub InitializeControlValues()
			allowCustomDrawDayHeader = chkDayHeader.Checked
			allowCustomDrawResourceHeader = chkResourceHeader.Checked
			allowCustomDrawAllDayArea = chkDayViewAllDayArea.Checked
			allowCustomDrawTimeCell = chkTimeCell.Checked
			allowCustomDrawTimeRuler = chkTimeRuler.Checked
			allowCustomDrawAppointment = chkAppointment.Checked
			allowCustomDrawAppointmentBackground = chkAppointmentBackground.Checked
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
			MyBase.UpdateReportProperties(otherReport)
			Report.AllowCustomDrawAllDayArea = allowCustomDrawAllDayArea
			Report.AllowCustomDrawAppointment = allowCustomDrawAppointment
			Report.AllowCustomDrawAppointmentBackground = allowCustomDrawAppointmentBackground
			Report.AllowCustomDrawDayHeader = allowCustomDrawDayHeader
			Report.AllowCustomDrawResourceHeader = allowCustomDrawResourceHeader
			Report.AllowCustomDrawTimeCell = allowCustomDrawTimeCell
			Report.AllowCustomDrawTimeRuler = allowCustomDrawTimeRuler
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.chkTimeRuler = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkDayViewAllDayArea = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkDayHeader = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkResourceHeader = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkTimeCell = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkAppointment = New DevExpress.XtraEditors.CheckEdit()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chkAppointmentBackground = New DevExpress.XtraEditors.CheckEdit()
			Me.navigationPaneSettings = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPageSettings = New DevExpress.XtraBars.Navigation.NavigationPage()
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlSettings.SuspendLayout()
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPaneSettings.SuspendLayout()
			Me.navigationPageSettings.SuspendLayout()
			Me.SuspendLayout()
			' 
			' printControl
			' 
			Me.printControl.Size = New System.Drawing.Size(496, 396)
			' 
			' chkTimeRuler
			' 
			Me.chkTimeRuler.EditValue = True
			Me.chkTimeRuler.Location = New System.Drawing.Point(7, 43)
			Me.chkTimeRuler.Name = "chkTimeRuler"
			Me.chkTimeRuler.Properties.Caption = "Time Ruler"
			Me.chkTimeRuler.Size = New System.Drawing.Size(163, 19)
			Me.chkTimeRuler.StyleController = Me.layoutControlSettings
			Me.chkTimeRuler.TabIndex = 101
'			Me.chkTimeRuler.CheckedChanged += New System.EventHandler(Me.chkTimeRuler_CheckedChanged);
			' 
			' layoutControlSettings
			' 
			Me.layoutControlSettings.Controls.Add(Me.chkAppointmentBackground)
			Me.layoutControlSettings.Controls.Add(Me.chkTimeRuler)
			Me.layoutControlSettings.Controls.Add(Me.chkAppointment)
			Me.layoutControlSettings.Controls.Add(Me.chkTimeCell)
			Me.layoutControlSettings.Controls.Add(Me.chkDayViewAllDayArea)
			Me.layoutControlSettings.Controls.Add(Me.chkResourceHeader)
			Me.layoutControlSettings.Controls.Add(Me.chkDayHeader)
			Me.layoutControlSettings.Controls.Add(Me.btnEdit)
			Me.layoutControlSettings.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControlSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlSettings.Name = "layoutControlSettings"
			Me.layoutControlSettings.Root = Me.layoutControlGroupSettings
			Me.layoutControlSettings.Size = New System.Drawing.Size(177, 352)
			Me.layoutControlSettings.TabIndex = 0
			Me.layoutControlSettings.Text = "layoutControl1"
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(7, 7)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(163, 22)
			Me.btnEdit.StyleController = Me.layoutControlSettings
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' layoutControlGroupSettings
			' 
			Me.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroupSettings.GroupBordersVisible = False
			Me.layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem2, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.emptySpaceItem1})
			Me.layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroupSettings.Name = "layoutControlGroup1"
			Me.layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlGroupSettings.Size = New System.Drawing.Size(177, 352)
			Me.layoutControlGroupSettings.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.btnEdit
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(167, 26)
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
			Me.emptySpaceItem1.Size = New System.Drawing.Size(167, 10)
			Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.AllowHotTrack = False
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 197)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(167, 145)
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.chkTimeRuler
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 36)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.chkDayViewAllDayArea
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 59)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' chkDayViewAllDayArea
			' 
			Me.chkDayViewAllDayArea.EditValue = True
			Me.chkDayViewAllDayArea.Location = New System.Drawing.Point(7, 66)
			Me.chkDayViewAllDayArea.Name = "chkDayViewAllDayArea"
			Me.chkDayViewAllDayArea.Properties.Caption = "All-Day Area"
			Me.chkDayViewAllDayArea.Size = New System.Drawing.Size(163, 19)
			Me.chkDayViewAllDayArea.StyleController = Me.layoutControlSettings
			Me.chkDayViewAllDayArea.TabIndex = 98
'			Me.chkDayViewAllDayArea.CheckedChanged += New System.EventHandler(Me.chkDayViewAllDayArea_CheckedChanged);
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.chkDayHeader
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 82)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' chkDayHeader
			' 
			Me.chkDayHeader.EditValue = True
			Me.chkDayHeader.Location = New System.Drawing.Point(7, 89)
			Me.chkDayHeader.Name = "chkDayHeader"
			Me.chkDayHeader.Properties.Caption = "Day Header"
			Me.chkDayHeader.Size = New System.Drawing.Size(163, 19)
			Me.chkDayHeader.StyleController = Me.layoutControlSettings
			Me.chkDayHeader.TabIndex = 96
'			Me.chkDayHeader.CheckedChanged += New System.EventHandler(Me.chkDayHeader_CheckedChanged);
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.chkResourceHeader
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 105)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' chkResourceHeader
			' 
			Me.chkResourceHeader.EditValue = True
			Me.chkResourceHeader.Location = New System.Drawing.Point(7, 112)
			Me.chkResourceHeader.Name = "chkResourceHeader"
			Me.chkResourceHeader.Properties.Caption = "Resource Header"
			Me.chkResourceHeader.Size = New System.Drawing.Size(163, 19)
			Me.chkResourceHeader.StyleController = Me.layoutControlSettings
			Me.chkResourceHeader.TabIndex = 95
'			Me.chkResourceHeader.CheckedChanged += New System.EventHandler(Me.chkResourceHeader_CheckedChanged);
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.chkTimeCell
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 128)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextVisible = False
			' 
			' chkTimeCell
			' 
			Me.chkTimeCell.EditValue = True
			Me.chkTimeCell.Location = New System.Drawing.Point(7, 135)
			Me.chkTimeCell.Name = "chkTimeCell"
			Me.chkTimeCell.Properties.Caption = "Time Cell"
			Me.chkTimeCell.Size = New System.Drawing.Size(163, 19)
			Me.chkTimeCell.StyleController = Me.layoutControlSettings
			Me.chkTimeCell.TabIndex = 97
'			Me.chkTimeCell.CheckedChanged += New System.EventHandler(Me.chkTimeCell_CheckedChanged);
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.chkAppointment
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 151)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextVisible = False
			' 
			' chkAppointment
			' 
			Me.chkAppointment.EditValue = True
			Me.chkAppointment.Location = New System.Drawing.Point(7, 158)
			Me.chkAppointment.Name = "chkAppointment"
			Me.chkAppointment.Properties.Caption = "Appointment"
			Me.chkAppointment.Size = New System.Drawing.Size(163, 19)
			Me.chkAppointment.StyleController = Me.layoutControlSettings
			Me.chkAppointment.TabIndex = 99
'			Me.chkAppointment.CheckedChanged += New System.EventHandler(Me.chkAppointment_CheckedChanged);
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.chkAppointmentBackground
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 174)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(167, 23)
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextVisible = False
			' 
			' chkAppointmentBackground
			' 
			Me.chkAppointmentBackground.EditValue = True
			Me.chkAppointmentBackground.Location = New System.Drawing.Point(7, 181)
			Me.chkAppointmentBackground.Name = "chkAppointmentBackground"
			Me.chkAppointmentBackground.Properties.Caption = "Appointment Background"
			Me.chkAppointmentBackground.Size = New System.Drawing.Size(163, 19)
			Me.chkAppointmentBackground.StyleController = Me.layoutControlSettings
			Me.chkAppointmentBackground.TabIndex = 100
'			Me.chkAppointmentBackground.CheckedChanged += New System.EventHandler(Me.chkAppointmentBackground_CheckedChanged);
			' 
			' navigationPaneSettings
			' 
			Me.navigationPaneSettings.Controls.Add(Me.navigationPageSettings)
			Me.navigationPaneSettings.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPaneSettings.ItemOrientation = System.Windows.Forms.Orientation.Vertical
			Me.navigationPaneSettings.Location = New System.Drawing.Point(496, 0)
			Me.navigationPaneSettings.Name = "navigationPaneSettings"
			Me.navigationPaneSettings.PageProperties.ShowExpandButton = False
			Me.navigationPaneSettings.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPageSettings})
			Me.navigationPaneSettings.RegularSize = New System.Drawing.Size(204, 396)
			Me.navigationPaneSettings.SelectedPage = Me.navigationPageSettings
			Me.navigationPaneSettings.Size = New System.Drawing.Size(204, 396)
			Me.navigationPaneSettings.TabIndex = 11
			Me.navigationPaneSettings.Text = "navigationPane1"
			' 
			' navigationPageSettings
			' 
			Me.navigationPageSettings.BackgroundPadding = New System.Windows.Forms.Padding(0)
			Me.navigationPageSettings.Caption = "Options"
			Me.navigationPageSettings.Controls.Add(Me.layoutControlSettings)
			Me.navigationPageSettings.Name = "navigationPageSettings"
			Me.navigationPageSettings.Size = New System.Drawing.Size(177, 352)
			' 
			' PreviewControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.navigationPaneSettings)
			Me.Name = "PreviewControl"
			Me.Controls.SetChildIndex(Me.navigationPaneSettings, 0)
			Me.Controls.SetChildIndex(Me.printControl, 0)
			CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlSettings.ResumeLayout(False)
			CType(Me.layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub chkDayHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDayHeader.CheckedChanged
			Me.allowCustomDrawDayHeader = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkResourceHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkResourceHeader.CheckedChanged
			Me.allowCustomDrawResourceHeader = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkTimeCell_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTimeCell.CheckedChanged
			Me.allowCustomDrawTimeCell = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()

		End Sub

		Private Sub chkDayViewAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDayViewAllDayArea.CheckedChanged
			Me.allowCustomDrawAllDayArea = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment.CheckedChanged
			Me.allowCustomDrawAppointment = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()

		End Sub

		Private Sub chkAppointmentBackground_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointmentBackground.CheckedChanged
			Me.allowCustomDrawAppointmentBackground = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTimeRuler.CheckedChanged
			Me.allowCustomDrawTimeRuler = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub
	End Class

End Namespace

