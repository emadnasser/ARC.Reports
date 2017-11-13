Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler.Design
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Reporting.UI

Namespace DevExpress.XtraScheduler.Demos.Reporting
	Public Class ReportTemplateForm
		Inherits XtraForm
		#Region "inner classes"
		Public Class DirectionModeItem
			Private text_Renamed As String
			Private directionMode_Renamed As DirectionMode

			Public ReadOnly Property DirectionMode() As DirectionMode
				Get
					Return directionMode_Renamed
				End Get
			End Property
			Public ReadOnly Property Text() As String
				Get
					Return text_Renamed
				End Get
			End Property
			Public Sub New(ByVal directionMode As DirectionMode, ByVal text As String)
				Me.directionMode_Renamed = directionMode
				Me.text_Renamed = text
			End Sub
		End Class
		Public Class ViewModeItem
			Private viewMode_Renamed As ImageViewMode
			Private text_Renamed As String

			Public ReadOnly Property ViewMode() As ImageViewMode
				Get
					Return viewMode_Renamed
				End Get
			End Property
			Public ReadOnly Property Text() As String
				Get
					Return text_Renamed
				End Get
			End Property
			Public Sub New(ByVal viewMode As ImageViewMode, ByVal text As String)
				Me.viewMode_Renamed = viewMode
				Me.text_Renamed = text
			End Sub
		End Class
		Public Class ImageAlignItem
			Private text_Renamed As String
			Private alignment_Renamed As String

			Public ReadOnly Property Alignment() As String
				Get
					Return alignment_Renamed
				End Get
			End Property
			Public ReadOnly Property Text() As String
				Get
					Return text_Renamed
				End Get
			End Property
			Public Sub New(ByVal alignment As String, ByVal text As String)
				Me.alignment_Renamed = alignment
				Me.text_Renamed = text
			End Sub
		End Class
		Private Class MyPrintControl
			Inherits PrintControl
			Private ps As DevExpress.XtraPrinting.PrintingSystem
			Public Sub New()
				SetControlVisibility(New Control() { hScrollBar, sidePanel }, False)
				ps = New DevExpress.XtraPrinting.PrintingSystem()
				PrintingSystem = ps
				fMinZoom = 0.00001f
			End Sub
			Private Sub SetControlVisibility(ByVal controls() As Control, ByVal visible As Boolean)
				For Each control As Control In controls
					control.Visible = visible
				Next control
			End Sub
			Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
				MyBase.OnHandleCreated(e)
				CreateDocument()
				ViewWholePage()
			End Sub
			Private Sub CreateDocument()
				ps.Begin()
				ps.Graph.Modifier = BrickModifier.Detail
				Dim brick As New EmptyBrick()
				brick.Rect = New RectangleF(0, 0, 100, 100)
				ps.Graph.DrawBrick(brick)
				ps.End()
			End Sub
			Public Sub UpdateWatermark(ByVal watermark As Watermark)
				ps.Watermark.CopyFrom(watermark)
				ps.Watermark.PageRange = ""
				Invalidate(True)
			End Sub
			Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
				If disposing Then
					ps.Dispose()
				End If
				MyBase.Dispose(disposing)
			End Sub
		End Class
		#End Region

		#Region "Fields"
		Private xtraTabControl As DevExpress.XtraTab.XtraTabControl
		Private tpFormat As DevExpress.XtraTab.XtraTabPage
		Private tpResources As DevExpress.XtraTab.XtraTabPage
		Private labelControl1 As LabelControl
		Protected cbResourcesKind As ImageComboBoxEdit
		Protected lblResourcesKind As LabelControl
		Protected WithEvents chkPrintCustomCollection As CheckEdit
		Protected grpCustomCollection As GroupControl
		Protected lblAvailableResource As LabelControl
		Protected lblCustomResources As LabelControl
		Protected lbResources As ListBoxControl
		Protected WithEvents btnToCustomCollection As SimpleButton
		Protected WithEvents btnAllToCustomCollection As SimpleButton
		Protected WithEvents btnAllFromCustomCollection As SimpleButton
		Protected WithEvents btnFromCustomCollection As SimpleButton
		Protected WithEvents btnMoveUp As SimpleButton
		Protected WithEvents btnMoveDown As SimpleButton
		Protected lbCustomResources As ListBoxControl
		Private panelControl1 As PanelControl
		Private pc As ReportTemplateForm.MyPrintControl

		Private components As System.ComponentModel.IContainer = Nothing
		Private btnClose As DevExpress.XtraEditors.SimpleButton
		Private lbPageRangeComment As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As LabelControl
		Private WithEvents cbReportFile As ComboBoxEdit
		Protected edtEnd As DateEdit
		Protected edtStart As DateEdit
		Protected lblEnd As LabelControl
		Protected lblStart As LabelControl
		Private WithEvents btnPreview As DevExpress.XtraEditors.SimpleButton

		Private report As XtraSchedulerReport
		Private previewReport As XtraSchedulerReport
		Private printAdapter_Renamed As SchedulerControlPrintAdapter
		Private reportFileName As String = String.Empty
		Private WithEvents btnEdit As SimpleButton
		Private printResources_Renamed As New ResourceBaseCollection()
		#End Region

		#Region "Properties"
		Public ReadOnly Property PrintAdapter() As SchedulerControlPrintAdapter
			Get
				Return printAdapter_Renamed
			End Get
		End Property
		Public ReadOnly Property PrintResources() As ResourceBaseCollection
			Get
				Return printResources_Renamed
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
		Private ReadOnly Property ReportTemplateDirectoryInfo() As DirectoryInfo
			Get
				Return New DirectoryInfo(DemoUtils.GetFolderRelativePath("SchedulerReportTemplates"))
			End Get
		End Property
		#End Region

		Public Sub New(ByVal printAdapter As SchedulerControlPrintAdapter)
			Me.printAdapter_Renamed = printAdapter

			InitializeComponent()

			Me.edtStart.DateTime = DateTime.Today.AddDays(-2)
			Me.edtEnd.DateTime = DateTime.Today.AddDays(7)
			btnPreview.Enabled = False
			btnEdit.Enabled = False

			SubscribeIntervalControlsEvents()
			PopulateResourceKindItems()
			PopulateReportTemplates()
			PopulateAvailableResources()
			UpdateControlsVisibility()
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If

				If printAdapter_Renamed IsNot Nothing Then
					UnsubscribePrintAdapterEvents(printAdapter_Renamed)
				End If

				If report IsNot Nothing Then
					DisposeReport(report)
					report = Nothing
				End If
				If Me.pc IsNot Nothing Then
					Me.pc.Dispose()
					Me.pc = Nothing
				End If
				If previewReport IsNot Nothing Then
					DisposeReport(previewReport)
					previewReport = Nothing
				End If

			End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub DisposeReport(ByVal report As XtraSchedulerReport)
			UnsubscribePrintAdapterEvents(report.SchedulerAdapter)
			report.Dispose()
		End Sub

		#Region "Windows Form Designer generated code"
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReportTemplateForm))
			Me.btnPreview = New DevExpress.XtraEditors.SimpleButton()
			Me.lbPageRangeComment = New DevExpress.XtraEditors.LabelControl()
			Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabControl = New DevExpress.XtraTab.XtraTabControl()
			Me.tpFormat = New DevExpress.XtraTab.XtraTabPage()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
			Me.lblEnd = New DevExpress.XtraEditors.LabelControl()
			Me.lblStart = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.pc = New DevExpress.XtraScheduler.Demos.Reporting.ReportTemplateForm.MyPrintControl()
			Me.tpResources = New DevExpress.XtraTab.XtraTabPage()
			Me.cbResourcesKind = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lblResourcesKind = New DevExpress.XtraEditors.LabelControl()
			Me.chkPrintCustomCollection = New DevExpress.XtraEditors.CheckEdit()
			Me.grpCustomCollection = New DevExpress.XtraEditors.GroupControl()
			Me.lblAvailableResource = New DevExpress.XtraEditors.LabelControl()
			Me.lblCustomResources = New DevExpress.XtraEditors.LabelControl()
			Me.lbResources = New DevExpress.XtraEditors.ListBoxControl()
			Me.btnToCustomCollection = New DevExpress.XtraEditors.SimpleButton()
			Me.btnAllToCustomCollection = New DevExpress.XtraEditors.SimpleButton()
			Me.btnAllFromCustomCollection = New DevExpress.XtraEditors.SimpleButton()
			Me.btnFromCustomCollection = New DevExpress.XtraEditors.SimpleButton()
			Me.btnMoveUp = New DevExpress.XtraEditors.SimpleButton()
			Me.btnMoveDown = New DevExpress.XtraEditors.SimpleButton()
			Me.lbCustomResources = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbReportFile = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl.SuspendLayout()
			Me.tpFormat.SuspendLayout()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.tpResources.SuspendLayout()
			CType(Me.cbResourcesKind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkPrintCustomCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grpCustomCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpCustomCollection.SuspendLayout()
			CType(Me.lbResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbCustomResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReportFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnPreview
			' 
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click);
			' 
			' lbPageRangeComment
			' 
			resources.ApplyResources(Me.lbPageRangeComment, "lbPageRangeComment")
			Me.lbPageRangeComment.Name = "lbPageRangeComment"
			' 
			' btnClose
			' 
			Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			' 
			' xtraTabControl
			' 
			resources.ApplyResources(Me.xtraTabControl, "xtraTabControl")
			Me.xtraTabControl.Name = "xtraTabControl"
			Me.xtraTabControl.SelectedTabPage = Me.tpFormat
			Me.xtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tpFormat, Me.tpResources})
			' 
			' tpFormat
			' 
			Me.tpFormat.Controls.Add(Me.edtEnd)
			Me.tpFormat.Controls.Add(Me.edtStart)
			Me.tpFormat.Controls.Add(Me.lblEnd)
			Me.tpFormat.Controls.Add(Me.lblStart)
			Me.tpFormat.Controls.Add(Me.panelControl1)
			Me.tpFormat.Name = "tpFormat"
			resources.ApplyResources(Me.tpFormat, "tpFormat")
			' 
			' edtEnd
			' 
			resources.ApplyResources(Me.edtEnd, "edtEnd")
			Me.edtEnd.Name = "edtEnd"
			Me.edtEnd.Properties.AccessibleName = resources.GetString("edtEnd.Properties.AccessibleName")
			Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("edtEnd.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.edtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' edtStart
			' 
			resources.ApplyResources(Me.edtStart, "edtStart")
			Me.edtStart.Name = "edtStart"
			Me.edtStart.Properties.AccessibleName = resources.GetString("edtStart.Properties.AccessibleName")
			Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("edtStart.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.edtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' lblEnd
			' 
			resources.ApplyResources(Me.lblEnd, "lblEnd")
			Me.lblEnd.Name = "lblEnd"
			' 
			' lblStart
			' 
			resources.ApplyResources(Me.lblStart, "lblStart")
			Me.lblStart.Name = "lblStart"
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.panelControl1.Controls.Add(Me.pc)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' pc
			' 
			resources.ApplyResources(Me.pc, "pc")
			Me.pc.HorizontalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden
			Me.pc.Name = "pc"
			Me.pc.ShowPageMargins = False
			Me.pc.TabStop = False
			Me.pc.VerticalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden
			Me.pc.Zoom = 0.2310606F
			' 
			' tpResources
			' 
			Me.tpResources.Controls.Add(Me.cbResourcesKind)
			Me.tpResources.Controls.Add(Me.lblResourcesKind)
			Me.tpResources.Controls.Add(Me.chkPrintCustomCollection)
			Me.tpResources.Controls.Add(Me.grpCustomCollection)
			Me.tpResources.Name = "tpResources"
			resources.ApplyResources(Me.tpResources, "tpResources")
			' 
			' cbResourcesKind
			' 
			resources.ApplyResources(Me.cbResourcesKind, "cbResourcesKind")
			Me.cbResourcesKind.Name = "cbResourcesKind"
			Me.cbResourcesKind.Properties.AccessibleName = resources.GetString("cbResourcesKind.Properties.AccessibleName")
			Me.cbResourcesKind.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
			Me.cbResourcesKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("cbResourcesKind.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' lblResourcesKind
			' 
			resources.ApplyResources(Me.lblResourcesKind, "lblResourcesKind")
			Me.lblResourcesKind.Name = "lblResourcesKind"
			' 
			' chkPrintCustomCollection
			' 
			resources.ApplyResources(Me.chkPrintCustomCollection, "chkPrintCustomCollection")
			Me.chkPrintCustomCollection.Name = "chkPrintCustomCollection"
			Me.chkPrintCustomCollection.Properties.AutoWidth = True
			Me.chkPrintCustomCollection.Properties.Caption = resources.GetString("chkPrintCustomCollection.Properties.Caption")
'			Me.chkPrintCustomCollection.CheckedChanged += New System.EventHandler(Me.chkPrintCustomCollection_CheckedChanged);
			' 
			' grpCustomCollection
			' 
			Me.grpCustomCollection.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.grpCustomCollection.Controls.Add(Me.lblAvailableResource)
			Me.grpCustomCollection.Controls.Add(Me.lblCustomResources)
			Me.grpCustomCollection.Controls.Add(Me.lbResources)
			Me.grpCustomCollection.Controls.Add(Me.btnToCustomCollection)
			Me.grpCustomCollection.Controls.Add(Me.btnAllToCustomCollection)
			Me.grpCustomCollection.Controls.Add(Me.btnAllFromCustomCollection)
			Me.grpCustomCollection.Controls.Add(Me.btnFromCustomCollection)
			Me.grpCustomCollection.Controls.Add(Me.btnMoveUp)
			Me.grpCustomCollection.Controls.Add(Me.btnMoveDown)
			Me.grpCustomCollection.Controls.Add(Me.lbCustomResources)
			resources.ApplyResources(Me.grpCustomCollection, "grpCustomCollection")
			Me.grpCustomCollection.Name = "grpCustomCollection"
			' 
			' lblAvailableResource
			' 
			resources.ApplyResources(Me.lblAvailableResource, "lblAvailableResource")
			Me.lblAvailableResource.Name = "lblAvailableResource"
			' 
			' lblCustomResources
			' 
			resources.ApplyResources(Me.lblCustomResources, "lblCustomResources")
			Me.lblCustomResources.Name = "lblCustomResources"
			' 
			' lbResources
			' 
			resources.ApplyResources(Me.lbResources, "lbResources")
			Me.lbResources.AccessibleRole = System.Windows.Forms.AccessibleRole.List
			Me.lbResources.Name = "lbResources"
			Me.lbResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			' 
			' btnToCustomCollection
			' 
			resources.ApplyResources(Me.btnToCustomCollection, "btnToCustomCollection")
			Me.btnToCustomCollection.Name = "btnToCustomCollection"
'			Me.btnToCustomCollection.Click += New System.EventHandler(Me.btnToCustomCollection_Click);
			' 
			' btnAllToCustomCollection
			' 
			resources.ApplyResources(Me.btnAllToCustomCollection, "btnAllToCustomCollection")
			Me.btnAllToCustomCollection.Name = "btnAllToCustomCollection"
'			Me.btnAllToCustomCollection.Click += New System.EventHandler(Me.btnAllToCustomCollection_Click);
			' 
			' btnAllFromCustomCollection
			' 
			resources.ApplyResources(Me.btnAllFromCustomCollection, "btnAllFromCustomCollection")
			Me.btnAllFromCustomCollection.Name = "btnAllFromCustomCollection"
'			Me.btnAllFromCustomCollection.Click += New System.EventHandler(Me.btnAllFromCustomCollection_Click);
			' 
			' btnFromCustomCollection
			' 
			resources.ApplyResources(Me.btnFromCustomCollection, "btnFromCustomCollection")
			Me.btnFromCustomCollection.Name = "btnFromCustomCollection"
'			Me.btnFromCustomCollection.Click += New System.EventHandler(Me.btnFromCustomCollection_Click);
			' 
			' btnMoveUp
			' 
			resources.ApplyResources(Me.btnMoveUp, "btnMoveUp")
			Me.btnMoveUp.Name = "btnMoveUp"
'			Me.btnMoveUp.Click += New System.EventHandler(Me.btnMoveUp_Click);
			' 
			' btnMoveDown
			' 
			resources.ApplyResources(Me.btnMoveDown, "btnMoveDown")
			Me.btnMoveDown.Name = "btnMoveDown"
'			Me.btnMoveDown.Click += New System.EventHandler(Me.btnMoveDown_Click);
			' 
			' lbCustomResources
			' 
			resources.ApplyResources(Me.lbCustomResources, "lbCustomResources")
			Me.lbCustomResources.AccessibleRole = System.Windows.Forms.AccessibleRole.List
			Me.lbCustomResources.Name = "lbCustomResources"
			Me.lbCustomResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.LineVisible = True
			Me.labelControl1.Name = "labelControl1"
			' 
			' labelControl2
			' 
			resources.ApplyResources(Me.labelControl2, "labelControl2")
			Me.labelControl2.Name = "labelControl2"
			' 
			' cbReportFile
			' 
			resources.ApplyResources(Me.cbReportFile, "cbReportFile")
			Me.cbReportFile.Name = "cbReportFile"
			Me.cbReportFile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("cbReportFile.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.cbReportFile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
'			Me.cbReportFile.Properties.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_Properties_ButtonClick);
'			Me.cbReportFile.SelectedIndexChanged += New System.EventHandler(Me.cbReportFile_SelectedIndexChanged);
			' 
			' btnEdit
			' 
			resources.ApplyResources(Me.btnEdit, "btnEdit")
			Me.btnEdit.Name = "btnEdit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' ReportTemplateForm
			' 
			resources.ApplyResources(Me, "$this")
			Me.Controls.Add(Me.btnEdit)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.cbReportFile)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.btnPreview)
			Me.Controls.Add(Me.xtraTabControl)
			Me.Controls.Add(Me.btnClose)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ReportTemplateForm"
			Me.ShowInTaskbar = False
			CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl.ResumeLayout(False)
			Me.tpFormat.ResumeLayout(False)
			Me.tpFormat.PerformLayout()
			CType(Me.edtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.tpResources.ResumeLayout(False)
			Me.tpResources.PerformLayout()
			CType(Me.cbResourcesKind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkPrintCustomCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grpCustomCollection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpCustomCollection.ResumeLayout(False)
			Me.grpCustomCollection.PerformLayout()
			CType(Me.lbResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbCustomResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReportFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private Sub SubscribePrintAdapterEvents(ByVal adapter As SchedulerPrintAdapter)
			If adapter IsNot Nothing Then
				AddHandler adapter.ValidateResources, AddressOf PrintAdapter_ValidateResources
			End If
		End Sub
		Private Sub UnsubscribePrintAdapterEvents(ByVal adapter As SchedulerPrintAdapter)
			If adapter IsNot Nothing Then
				RemoveHandler adapter.ValidateResources, AddressOf PrintAdapter_ValidateResources
			End If
		End Sub
		Private Sub SubscribeIntervalControlsEvents()
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
		End Sub
		Private Sub UnsubscribeIntervalControlsEvents()
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
		End Sub

		Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeIntervalControlsEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtEnd.EditValue = StartDate
			End If
			SubscribeIntervalControlsEvents()
		End Sub
		Protected Friend Overridable Function IsValidInterval(ByVal start As DateTime, ByVal [end] As DateTime) As Boolean
			Return start <= [end]
		End Function
		Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeIntervalControlsEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtStart.EditValue = EndDate.AddDays(-1)
			End If
			SubscribeIntervalControlsEvents()
		End Sub

		Private Sub PrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs)
			e.Resources.Clear()
			e.Resources.AddRange(PrintResources)
		End Sub

		Private Sub PopulateResourceKindItems()
			cbResourcesKind.Properties.Items.Add(New ImageComboBoxItem() With {.Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_AllResources), .Value = ResourcesKind.All})
			cbResourcesKind.Properties.Items.Add(New ImageComboBoxItem() With {.Description = SchedulerLocalizer.GetString(SchedulerStringId.Caption_OnScreenResources), .Value = ResourcesKind.OnScreen})
			cbResourcesKind.SelectedIndex = 0
		End Sub

		Private Sub PopulateReportTemplates()
			Dim reportTemplates() As FileInfo = ReportTemplateDirectoryInfo.GetFiles("*.schrepx")
			cbReportFile.Properties.Buttons(0).Visible = reportTemplates.Length <> 0
			For Each reportFile As FileInfo In reportTemplates
				cbReportFile.Properties.Items.Add(New ReportTemplateInfo(reportFile.FullName))
			Next reportFile
			cbReportFile.SelectedIndex = 0
		End Sub

		Private Sub buttonEdit1_Properties_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbReportFile.Properties.ButtonClick
			If e.Button.Kind = ButtonPredefines.Ellipsis Then
				Dim dlg As New OpenFileDialog()
				Try
					dlg.CheckPathExists = True
					dlg.Filter = "Report template files (*.schrepx)|*.schrepx|All files (*.*)|*.*"
					dlg.InitialDirectory = ReportTemplateDirectoryInfo.FullName
					Dim result As DialogResult = dlg.ShowDialog()
					If result <> System.Windows.Forms.DialogResult.OK Then
						Return
					End If
					UpdateReport(New ReportTemplateInfo(dlg.FileName))
				Catch ex As Exception
					XtraMessageBox.Show(ex.Message, Application.ProductName)
				Finally
					dlg.Dispose()
				End Try
			End If
		End Sub

		Private Sub UpdatePreview()
			If previewReport Is Nothing Then
				Return
			End If
			pc.PrintingSystem = previewReport.PrintingSystem
			previewReport.ReportPrintOptions.DetailCount = 1
			UpdateReport(previewReport)
		End Sub

		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			UpdateReport(report)
			If report IsNot Nothing Then
				report.ShowPreview()
			End If
		End Sub
		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			UpdateReport(report)
			If report IsNot Nothing Then
				CType(New SchedulerReportDesignTool(report), SchedulerReportDesignTool).ShowDesignerDialog()
			End If
		End Sub
		Private Sub UpdateReport(ByVal report As XtraSchedulerReport)
			If report Is Nothing Then
				Return
			End If
			report.SchedulerAdapter.TimeInterval = New TimeInterval(StartDate, EndDate)
			UpdatePrintResources()
			report.PrintingSystem.ClearContent()
			report.CreateDocument(True)
		End Sub

		Private Sub UpdatePrintResources()
			PrintResources.Clear()
			Dim resources As ResourceBaseCollection = GetPrintResources()
			PrintResources.AddRange(resources)
		End Sub
		Private Function GetPrintResources() As ResourceBaseCollection
			If chkPrintCustomCollection.Checked Then
				Return GetCustomResources()
			End If

			Dim resourcesKind As ResourcesKind = CType(cbResourcesKind.EditValue, ResourcesKind)
			Select Case resourcesKind
				Case ResourcesKind.All
					Return GetAvailableResources()
				Case ResourcesKind.OnScreen
					Return GetOnScreenResources()
				Case Else
					Return New ResourceBaseCollection()
			End Select
		End Function
		Private Function GetAvailableResources() As ResourceBaseCollection
			Return PrintAdapter.SchedulerControl.DataStorage.Resources.Items
		End Function
		Private Function GetOnScreenResources() As ResourceBaseCollection
			Return PrintAdapter.SchedulerControl.ActiveView.GetResources()
		End Function
		Private Function GetCustomResources() As ResourceBaseCollection
			Dim result As New ResourceBaseCollection()
			Dim count As Integer = lbCustomResources.ItemCount
			For i As Integer = 0 To count - 1
				Dim objectWrapper As ObjectWrapper = CType(lbCustomResources.Items(i), ObjectWrapper)
				result.Add(CType(objectWrapper.Object, Resource))
			Next i
			Return result
		End Function

		Private Sub CreateReports()
			CreateReport()
			CreatePreviewReport()
		End Sub

		Private Sub CreateReport()
			If report IsNot Nothing Then
				DisposeReport(report)
			End If
			Me.report = CreateReportCore()
		End Sub
		Private Sub CreatePreviewReport()
			If previewReport IsNot Nothing Then
				DisposeReport(previewReport)
			End If
			Me.previewReport = CreateReportCore()
		End Sub
		Private Function CreateReportCore() As XtraSchedulerReport
			Dim report As New XtraSchedulerReport()
			report.LoadLayout(reportFileName)


			If report.SchedulerAdapter IsNot Nothing Then
				report.SchedulerAdapter.SetSourceObject(PrintAdapter.SchedulerControl)
			Else
				report.SchedulerAdapter = PrintAdapter
			End If

			report.SchedulerAdapter.EnableSmartSync = reportFileName.ToLower().Contains("trifold")
			SubscribePrintAdapterEvents(report.SchedulerAdapter)

			report.PrintColorSchema = DemoUtils.ReportPrintColorSchema
			Return report
		End Function

		Private Sub chkPrintCustomCollection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPrintCustomCollection.CheckedChanged
			UpdateControlsVisibility()
		End Sub
		Private Sub UpdateControlsVisibility()
			Dim isCustomResources As Boolean = chkPrintCustomCollection.Checked

			Me.lbCustomResources.Enabled = isCustomResources
			Me.lbResources.Enabled = isCustomResources
			Me.cbResourcesKind.Enabled = Not isCustomResources

			UpdateResourceButtonsVisibility(isCustomResources)
		End Sub
		Private Sub UpdateResourceButtonsVisibility(ByVal isCustomResources As Boolean)
			Me.btnAllToCustomCollection.Enabled = isCustomResources AndAlso lbResources.ItemCount > 0
			Me.btnToCustomCollection.Enabled = isCustomResources AndAlso lbResources.ItemCount > 0
			Me.btnAllFromCustomCollection.Enabled = isCustomResources AndAlso lbCustomResources.ItemCount > 0
			Me.btnFromCustomCollection.Enabled = isCustomResources AndAlso lbCustomResources.ItemCount > 0
			Me.btnMoveDown.Enabled = isCustomResources
			Me.btnMoveUp.Enabled = isCustomResources
		End Sub
		Private Sub PopulateAvailableResources()
			lbResources.Items.Clear()
			Dim resources As ResourceBaseCollection = GetAvailableResources()
			Dim count As Integer = resources.Count
			For i As Integer = 0 To count - 1
				lbResources.Items.Add(New ObjectWrapper(resources(i), resources(i).Caption))
			Next i

		End Sub

		Private Sub btnAllToCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllToCustomCollection.Click
			MoveAllItems(lbResources, lbCustomResources)

		End Sub
		Private Sub btnAllFromCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAllFromCustomCollection.Click
			MoveAllItems(lbCustomResources, lbResources)
		End Sub
		Private Sub btnToCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToCustomCollection.Click
			MoveSelectedItems(lbResources, lbCustomResources)
		End Sub
		Private Sub btnFromCustomCollection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFromCustomCollection.Click
			MoveSelectedItems(lbCustomResources, lbResources)
		End Sub
		Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveUp.Click
			MoveSelectedItems(lbCustomResources, True)
		End Sub
		Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveDown.Click
			MoveSelectedItems(lbCustomResources, False)
		End Sub
		Private Sub MoveAllItems(ByVal source As ListBoxControl, ByVal target As ListBoxControl)
			Dim count As Integer = source.ItemCount
			For i As Integer = 0 To count - 1
				target.Items.Add(source.Items(i))
			Next i
			source.Items.Clear()
			UpdateResourceButtonsVisibility(True)
		End Sub
		Private Sub MoveSelectedItems(ByVal source As ListBoxControl, ByVal target As ListBoxControl)
			Dim selectedItems As New List(Of Object)()
			Dim count As Integer = source.SelectedItems.Count
			For i As Integer = 0 To count - 1
				Dim item As Object = source.SelectedItems(i)
				target.Items.Add(item)
				selectedItems.Add(item)
			Next i

			For i As Integer = 0 To count - 1
				source.Items.Remove(selectedItems(i))
			Next i
			UpdateResourceButtonsVisibility(True)
		End Sub

		Private Sub MoveSelectedItems(ByVal listBox As ListBoxControl, ByVal moveUp As Boolean)
			If (Not CanMoveItems(listBox, moveUp)) Then
				Return
			End If
			Dim selectedIndices As List(Of Integer) = GetSelectedIndixes(listBox)
			Dim selectedItems As List(Of Object) = GetSelectedItems(listBox)

			If moveUp Then
				MoveSelectedItemsUp(listBox, selectedIndices)
			Else
				MoveSelectedItemsDown(listBox, selectedIndices)
			End If

			UpdateSelection(listBox, selectedItems)
			UpdateResourceButtonsVisibility(True)
		End Sub
		Private Sub MoveSelectedItemsUp(ByVal listBox As ListBoxControl, ByVal selectedIndices As List(Of Integer))
			Dim count As Integer = selectedIndices.Count
			For i As Integer = 0 To count - 1
				Dim index As Integer = selectedIndices(i)
				Dim item As Object = listBox.Items(index)
				listBox.Items.RemoveAt(index)
				listBox.Items.Insert(index - 1, item)
			Next i
		End Sub

		Private Sub MoveSelectedItemsDown(ByVal listBox As ListBoxControl, ByVal selectedIndices As List(Of Integer))
			Dim count As Integer = selectedIndices.Count
			For i As Integer = count - 1 To 0 Step -1
				Dim index As Integer = selectedIndices(i)
				Dim item As Object = listBox.Items(index)
				listBox.Items.RemoveAt(index)
				listBox.Items.Insert(index + 1, item)
			Next i
		End Sub
		Private Sub UpdateSelection(ByVal listBox As ListBoxControl, ByVal selectedItems As List(Of Object))
			Dim count As Integer = listBox.Items.Count
			For i As Integer = 0 To count - 1
				Dim selected As Boolean = selectedItems.Contains(listBox.Items(i))
				listBox.SetSelected(i, selected)
			Next i
		End Sub
		Private Function GetSelectedIndixes(ByVal listBox As ListBoxControl) As List(Of Integer)
			Dim result As New List(Of Integer)()
			Dim count As Integer = listBox.SelectedIndices.Count
			For i As Integer = 0 To count - 1
				result.Add(listBox.SelectedIndices(i))
			Next i
			Return result
		End Function
		Private Function GetSelectedItems(ByVal listBox As ListBoxControl) As List(Of Object)
			Dim result As New List(Of Object)()
			Dim count As Integer = listBox.SelectedItems.Count
			For i As Integer = 0 To count - 1
				result.Add(listBox.SelectedItems(i))
			Next i
			Return result
		End Function
		Private Function CanMoveItems(ByVal listBox As ListBoxControl, ByVal moveUp As Boolean) As Boolean
			Dim indices As BaseListBoxControl.SelectedIndexCollection = listBox.SelectedIndices
			Dim selectedIndexesCount As Integer = indices.Count
			If selectedIndexesCount = 0 Then
				Return False
			End If
			Return If(moveUp, indices(0) > 0, indices(selectedIndexesCount - 1) < listBox.ItemCount - 1)
		End Function

		Private Sub cbReportFile_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbReportFile.SelectedIndexChanged
			Try
				Dim templateInfo As ReportTemplateInfo = TryCast(cbReportFile.SelectedItem, ReportTemplateInfo)
				If templateInfo Is Nothing Then
					Return
				End If
				UpdateReport(templateInfo)

			Catch ex As Exception
				XtraMessageBox.Show(ex.Message, Application.ProductName)
			End Try
		End Sub
		Private Sub UpdateReport(ByVal templateInfo As ReportTemplateInfo)
			reportFileName = templateInfo.FullName
			cbReportFile.Text = templateInfo.Name
			cbReportFile.ToolTip = reportFileName

			CreateReports()
			UpdatePreview()

			btnPreview.Enabled = reportFileName IsNot String.Empty
			btnEdit.Enabled = reportFileName IsNot String.Empty
		End Sub
	End Class
	Public Enum ResourcesKind
		All
		OnScreen
	End Enum

	Public Class ReportTemplateInfo
		Private ReadOnly name_Renamed As String
		Private ReadOnly fullName_Renamed As String

		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public ReadOnly Property FullName() As String
			Get
				Return fullName_Renamed
			End Get
		End Property

		Public Sub New(ByVal fullName As String)
			Me.fullName_Renamed = fullName
			name_Renamed = Path.GetFileNameWithoutExtension(fullName)
		End Sub
		Public Overrides Function ToString() As String
			Return name_Renamed
		End Function
	End Class
End Namespace
