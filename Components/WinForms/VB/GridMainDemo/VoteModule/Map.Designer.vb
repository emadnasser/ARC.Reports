Namespace DevExpress.VoteApp
	Partial Public Class Map
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim mapOverlay1 As New DevExpress.XtraMap.MapOverlay()
			Dim mapOverlayTextItem1 As New DevExpress.XtraMap.MapOverlayTextItem()
			Me.colRepPercents = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colGOP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repProgress = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.colDemPercents = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDem = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.demProgress = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.mapControl = New DevExpress.XtraMap.MapControl()
			Me.stateLayer = New DevExpress.XtraMap.VectorItemsLayer()
			Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
			Me.mapTooltipController = New DevExpress.Utils.ToolTipController(Me.components)
			Me.tsElectionSimilutor = New DevExpress.XtraEditors.ToggleSwitch()
			Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btCenter = New DevExpress.XtraEditors.SimpleButton()
			Me.btBackToStates = New DevExpress.XtraEditors.SimpleButton()
			Me.grid = New DevExpress.XtraGrid.GridControl()
			Me.listVoteResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colArea = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridTooltipController = New DevExpress.Utils.ToolTipController(Me.components)
			Me.votesPanelPeople = New DevExpress.VoteApp.VotesPanel()
			Me.piRep = New DevExpress.XtraEditors.PictureEdit()
			Me.votesPanelElectoral = New DevExpress.VoteApp.VotesPanel()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.switchResults = New DevExpress.XtraEditors.SimpleButton()
			Me.lbElection = New DevExpress.XtraEditors.LabelControl()
			Me.piDem = New DevExpress.XtraEditors.PictureEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcgStateResult = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciGrid = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciMapControl = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciElectionLabel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgContent = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciDemPicture = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciElectoralVotes = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPeopleVotes = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciVoteDescription = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRepPicture = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciShow2012 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgSimulationMode = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciSimulationMode = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.repProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.demProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.tsElectionSimilutor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl.SuspendLayout()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			DirectCast(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.listVoteResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.piRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.piDem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lcgStateResult, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciMapControl, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciElectionLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lcgContent, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciDemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciElectoralVotes, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciPeopleVotes, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciVoteDescription, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciRepPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciShow2012, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lcgSimulationMode, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.lciSimulationMode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colRepPercents
			' 
			Me.colRepPercents.FieldName = "RepPercents"
			Me.colRepPercents.Name = "colRepPercents"
			Me.colRepPercents.Visible = True
			' 
			' colGOP
			' 
			Me.colGOP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colGOP.AppearanceHeader.Options.UseFont = True
			Me.colGOP.AutoFillDown = True
			Me.colGOP.Caption = "GOP"
			Me.colGOP.ColumnEdit = Me.repProgress
			Me.colGOP.FieldName = "IntRepPercents"
			Me.colGOP.Name = "colGOP"
			Me.colGOP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Excel
			Me.colGOP.RowIndex = 1
			Me.colGOP.Visible = True
			Me.colGOP.Width = 209
			' 
			' repProgress
			' 
			Me.repProgress.EndColor = System.Drawing.Color.FromArgb((CInt((CByte(207)))), (CInt((CByte(64)))), (CInt((CByte(76)))))
			Me.repProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.repProgress.LookAndFeel.UseDefaultLookAndFeel = False
			Me.repProgress.Name = "repProgress"
			Me.repProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
			Me.repProgress.ShowTitle = True
			Me.repProgress.StartColor = System.Drawing.Color.FromArgb((CInt((CByte(207)))), (CInt((CByte(64)))), (CInt((CByte(76)))))
			' 
			' colDemPercents
			' 
			Me.colDemPercents.FieldName = "DemPercents"
			Me.colDemPercents.Name = "colDemPercents"
			Me.colDemPercents.Visible = True
			' 
			' colDem
			' 
			Me.colDem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colDem.AppearanceHeader.Options.UseFont = True
			Me.colDem.Caption = "DEM"
			Me.colDem.ColumnEdit = Me.demProgress
			Me.colDem.FieldName = "IntDemPercents"
			Me.colDem.Name = "colDem"
			Me.colDem.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Excel
			Me.colDem.Visible = True
			Me.colDem.Width = 209
			' 
			' demProgress
			' 
			Me.demProgress.EndColor = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(156)))), (CInt((CByte(189)))))
			Me.demProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.demProgress.LookAndFeel.UseDefaultLookAndFeel = False
			Me.demProgress.Name = "demProgress"
			Me.demProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
			Me.demProgress.ShowTitle = True
			Me.demProgress.StartColor = System.Drawing.Color.FromArgb((CInt((CByte(84)))), (CInt((CByte(156)))), (CInt((CByte(189)))))
			' 
			' mapControl
			' 
			Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.mapControl.CenterPoint = New DevExpress.XtraMap.GeoPoint(40R, -104R)
			Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl.EnableScrolling = False
			Me.mapControl.Layers.Add(Me.stateLayer)
			Me.mapControl.Location = New System.Drawing.Point(2, 2)
			Me.mapControl.MaxZoomLevel = 9R
			Me.mapControl.MinZoomLevel = 4R
			Me.mapControl.Name = "mapControl"
			Me.mapControl.NavigationPanelOptions.Height = 40
			Me.mapControl.NavigationPanelOptions.ShowCoordinates = False
			Me.mapControl.NavigationPanelOptions.ShowKilometersScale = False
			Me.mapControl.NavigationPanelOptions.ShowScrollButtons = False
			mapOverlay1.Alignment = System.Drawing.ContentAlignment.BottomCenter
			mapOverlayTextItem1.Alignment = System.Drawing.ContentAlignment.BottomCenter
			mapOverlayTextItem1.Text = "Source: United States Federal Election Commission; County-Level election data cou" & "rtesy of TheGuardian.com"
			mapOverlayTextItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			mapOverlayTextItem1.TextStyle.Font = New System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			mapOverlay1.Items.Add(mapOverlayTextItem1)
			mapOverlay1.Location = New System.Drawing.Point(30, -30)
			Me.mapControl.Overlays.Add(mapOverlay1)
			Me.mapControl.Size = New System.Drawing.Size(579, 361)
			Me.mapControl.TabIndex = 0
			Me.mapControl.ToolTipController = Me.mapTooltipController
			Me.mapControl.ZoomLevel = 4R
'			Me.mapControl.MapItemClick += New DevExpress.XtraMap.MapItemClickEventHandler(Me.mapControl_MapItemClick)
'			Me.mapControl.MapItemDoubleClick += New DevExpress.XtraMap.MapItemClickEventHandler(Me.mapControl_MapItemClick)
'			Me.mapControl.DoubleClick += New System.EventHandler(Me.mapControl_DoubleClick)
			' 
			' stateLayer
			' 
			Me.stateLayer.Data = Me.shapefileDataAdapter1
			Me.stateLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Visible
			Me.stateLayer.ToolTipPattern = "%V0%"
			' 
			' mapTooltipController
			' 
			Me.mapTooltipController.AllowHtmlText = True
			Me.mapTooltipController.AutoPopDelay = 500
			Me.mapTooltipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
'			Me.mapTooltipController.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.mapTooltipController_BeforeShow)
			' 
			' tsElectionSimilutor
			' 
			Me.tsElectionSimilutor.Location = New System.Drawing.Point(805, 18)
			Me.tsElectionSimilutor.Name = "tsElectionSimilutor"
			Me.tsElectionSimilutor.Properties.OffText = "Off"
			Me.tsElectionSimilutor.Properties.OnText = "On"
			Me.tsElectionSimilutor.Size = New System.Drawing.Size(90, 24)
			Me.tsElectionSimilutor.StyleController = Me.layoutControl
			Me.tsElectionSimilutor.TabIndex = 7
'			Me.tsElectionSimilutor.Toggled += New System.EventHandler(Me.tsElectionSimilutor_Toggled)
			' 
			' layoutControl
			' 
			Me.layoutControl.AllowCustomization = False
			Me.layoutControl.Controls.Add(Me.panelControl1)
			Me.layoutControl.Controls.Add(Me.grid)
			Me.layoutControl.Controls.Add(Me.votesPanelPeople)
			Me.layoutControl.Controls.Add(Me.piRep)
			Me.layoutControl.Controls.Add(Me.votesPanelElectoral)
			Me.layoutControl.Controls.Add(Me.labelControl1)
			Me.layoutControl.Controls.Add(Me.tsElectionSimilutor)
			Me.layoutControl.Controls.Add(Me.switchResults)
			Me.layoutControl.Controls.Add(Me.lbElection)
			Me.layoutControl.Controls.Add(Me.piDem)
			Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl.Name = "layoutControl"
			Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1013, 231, 650, 400)
			Me.layoutControl.OptionsView.UseParentAutoScaleFactor = True
			Me.layoutControl.Root = Me.layoutControlGroup1
			Me.layoutControl.Size = New System.Drawing.Size(907, 568)
			Me.layoutControl.TabIndex = 9
			Me.layoutControl.Text = "layoutControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btCenter)
			Me.panelControl1.Controls.Add(Me.btBackToStates)
			Me.panelControl1.Controls.Add(Me.mapControl)
			Me.panelControl1.Location = New System.Drawing.Point(312, 191)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(583, 365)
			Me.panelControl1.TabIndex = 9
			' 
			' btCenter
			' 
			Me.btCenter.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btCenter.Location = New System.Drawing.Point(487, 5)
			Me.btCenter.Name = "btCenter"
			Me.btCenter.Size = New System.Drawing.Size(91, 30)
			Me.btCenter.TabIndex = 6
			Me.btCenter.Text = "Center Map"
'			Me.btCenter.Click += New System.EventHandler(Me.btCenter_Click)
			' 
			' btBackToStates
			' 
			Me.btBackToStates.Location = New System.Drawing.Point(5, 5)
			Me.btBackToStates.Name = "btBackToStates"
			Me.btBackToStates.Size = New System.Drawing.Size(91, 30)
			Me.btBackToStates.TabIndex = 5
			Me.btBackToStates.Text = "Back to States"
			Me.btBackToStates.Visible = False
'			Me.btBackToStates.Click += New System.EventHandler(Me.btBackToStates_Click)
			' 
			' grid
			' 
			Me.grid.DataSource = Me.listVoteResultsBindingSource
			Me.grid.Location = New System.Drawing.Point(12, 191)
			Me.grid.MainView = Me.gridView
			Me.grid.Name = "grid"
			Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.demProgress, Me.repProgress})
			Me.grid.Size = New System.Drawing.Size(296, 365)
			Me.grid.TabIndex = 3
			Me.grid.ToolTipController = Me.gridTooltipController
			Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' listVoteResultsBindingSource
			' 
			Me.listVoteResultsBindingSource.DataSource = GetType(DevExpress.VoteApp.ListVoteResults)
			' 
			' gridView
			' 
			Me.gridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colArea, Me.colGOP, Me.colDem, Me.colRepPercents, Me.colDemPercents})
			Me.gridView.GridControl = Me.grid
			Me.gridView.Name = "gridView"
			Me.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
			Me.gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True
			Me.gridView.OptionsBehavior.Editable = False
			Me.gridView.OptionsCustomization.AllowBandMoving = False
			Me.gridView.OptionsCustomization.AllowColumnMoving = False
			Me.gridView.OptionsCustomization.AllowGroup = False
			Me.gridView.OptionsCustomization.AllowQuickHideColumns = False
			Me.gridView.OptionsDetail.EnableMasterViewMode = False
			Me.gridView.OptionsMenu.EnableGroupPanelMenu = False
			Me.gridView.OptionsView.ColumnAutoWidth = True
			Me.gridView.OptionsView.ShowBands = False
			Me.gridView.OptionsView.ShowGroupPanel = False
			Me.gridView.OptionsView.ShowIndicator = False
'			Me.gridView.RowClick += New DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(Me.gridView_RowClick)
'			Me.gridView.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView_CustomDrawCell)
'			Me.gridView.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView_FocusedRowChanged)
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.colArea)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.VisibleIndex = 0
			Me.gridBand1.Width = 88
			' 
			' colArea
			' 
			Me.colArea.AppearanceHeader.Options.UseTextOptions = True
			Me.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colArea.Caption = "Area"
			Me.colArea.FieldName = "Name"
			Me.colArea.Name = "colArea"
			Me.colArea.RowCount = 2
			Me.colArea.Visible = True
			Me.colArea.Width = 88
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.colDem)
			Me.gridBand2.Columns.Add(Me.colGOP)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.VisibleIndex = 1
			Me.gridBand2.Width = 209
			' 
			' gridTooltipController
			' 
			Me.gridTooltipController.AutoPopDelay = 500
'			Me.gridTooltipController.GetActiveObjectInfo += New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(Me.gridTooltipController_GetActiveObjectInfo)
'			Me.gridTooltipController.BeforeShow += New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(Me.gridTooltipController_BeforeShow)
			' 
			' votesPanelPeople
			' 
			Me.votesPanelPeople.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.votesPanelPeople.BackColor = System.Drawing.Color.Silver
			Me.votesPanelPeople.ColorLeft = System.Drawing.Color.Empty
			Me.votesPanelPeople.ColorRight = System.Drawing.Color.Empty
			Me.votesPanelPeople.Location = New System.Drawing.Point(106, 134)
			Me.votesPanelPeople.Name = "votesPanelPeople"
			Me.votesPanelPeople.Size = New System.Drawing.Size(695, 20)
			Me.votesPanelPeople.TabIndex = 8
			Me.votesPanelPeople.VotesTextLeft = "<b>50%</b> <i>Votes"
			Me.votesPanelPeople.VotesTextRight = "Votes</size> <b>50%</b>"
			Me.votesPanelPeople.VotesTextSize = 10F
			' 
			' piRep
			' 
			Me.piRep.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.piRep.Cursor = System.Windows.Forms.Cursors.Default
			Me.piRep.Location = New System.Drawing.Point(805, 53)
			Me.piRep.Name = "piRep"
			Me.piRep.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.piRep.Properties.Appearance.Options.UseBackColor = True
			Me.piRep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.piRep.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect
			Me.piRep.Properties.OptionsMask.RectCornerRadius = 50
			Me.piRep.Properties.ReadOnly = True
			Me.piRep.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
			Me.piRep.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.piRep.Properties.ZoomAccelerationFactor = 1R
			Me.piRep.Size = New System.Drawing.Size(90, 118)
			Me.piRep.StyleController = Me.layoutControl
			Me.piRep.TabIndex = 1
			' 
			' votesPanelElectoral
			' 
			Me.votesPanelElectoral.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.votesPanelElectoral.BackColor = System.Drawing.Color.Silver
			Me.votesPanelElectoral.ColorLeft = System.Drawing.Color.Empty
			Me.votesPanelElectoral.ColorRight = System.Drawing.Color.Empty
			Me.votesPanelElectoral.Location = New System.Drawing.Point(106, 61)
			Me.votesPanelElectoral.Name = "votesPanelElectoral"
			Me.votesPanelElectoral.Size = New System.Drawing.Size(695, 69)
			Me.votesPanelElectoral.TabIndex = 7
			Me.votesPanelElectoral.VotesTextLeft = "<b>100</b> <size=-5><i>Electoral Votes"
			Me.votesPanelElectoral.VotesTextRight = "<size=-5>Electoral Votes</size> <b>100</b>"
			Me.votesPanelElectoral.VotesTextSize = 15.75F
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.Appearance.Options.UseTextOptions = True
			Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl1.Location = New System.Drawing.Point(106, 171)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(695, 16)
			Me.labelControl1.StyleController = Me.layoutControl
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Candidates need 270 electoral votes to win the presidency"
			' 
			' switchResults
			' 
			Me.switchResults.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.switchResults.Location = New System.Drawing.Point(637, 12)
			Me.switchResults.Name = "switchResults"
			Me.switchResults.Size = New System.Drawing.Size(80, 37)
			Me.switchResults.StyleController = Me.layoutControl
			Me.switchResults.TabIndex = 6
			Me.switchResults.Text = "Show 2012"
'			Me.switchResults.Click += New System.EventHandler(Me.switchResults_Click)
			' 
			' lbElection
			' 
			Me.lbElection.AllowHtmlString = True
			Me.lbElection.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lbElection.Appearance.Options.UseFont = True
			Me.lbElection.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbElection.Location = New System.Drawing.Point(12, 12)
			Me.lbElection.Name = "lbElection"
			Me.lbElection.Size = New System.Drawing.Size(621, 37)
			Me.lbElection.StyleController = Me.layoutControl
			Me.lbElection.TabIndex = 0
			Me.lbElection.Text = "Election 2012"
			' 
			' piDem
			' 
			Me.piDem.Cursor = System.Windows.Forms.Cursors.Default
			Me.piDem.Location = New System.Drawing.Point(12, 53)
			Me.piDem.Name = "piDem"
			Me.piDem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.piDem.Properties.Appearance.Options.UseBackColor = True
			Me.piDem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.piDem.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect
			Me.piDem.Properties.OptionsMask.RectCornerRadius = 50
			Me.piDem.Properties.ReadOnly = True
			Me.piDem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
			Me.piDem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.piDem.Properties.ZoomAccelerationFactor = 1R
			Me.piDem.Size = New System.Drawing.Size(90, 118)
			Me.piDem.StyleController = Me.layoutControl
			Me.piDem.TabIndex = 0
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgStateResult, Me.lciMapControl, Me.lciElectionLabel, Me.lcgContent, Me.lciShow2012, Me.lcgSimulationMode})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(907, 568)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' lcgStateResult
			' 
			Me.lcgStateResult.GroupBordersVisible = False
			Me.lcgStateResult.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciGrid})
			Me.lcgStateResult.Location = New System.Drawing.Point(0, 179)
			Me.lcgStateResult.Name = "lcgStateResult"
			Me.lcgStateResult.Size = New System.Drawing.Size(300, 369)
			Me.lcgStateResult.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
			' 
			' lciGrid
			' 
			Me.lciGrid.Control = Me.grid
			Me.lciGrid.Location = New System.Drawing.Point(0, 0)
			Me.lciGrid.MaxSize = New System.Drawing.Size(300, 0)
			Me.lciGrid.MinSize = New System.Drawing.Size(300, 24)
			Me.lciGrid.Name = "lciGrid"
			Me.lciGrid.Size = New System.Drawing.Size(300, 369)
			Me.lciGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciGrid.TextSize = New System.Drawing.Size(0, 0)
			Me.lciGrid.TextVisible = False
			' 
			' lciMapControl
			' 
			Me.lciMapControl.Control = Me.panelControl1
			Me.lciMapControl.Location = New System.Drawing.Point(300, 179)
			Me.lciMapControl.Name = "lciMapControl"
			Me.lciMapControl.Size = New System.Drawing.Size(587, 369)
			Me.lciMapControl.TextSize = New System.Drawing.Size(0, 0)
			Me.lciMapControl.TextVisible = False
			' 
			' lciElectionLabel
			' 
			Me.lciElectionLabel.Control = Me.lbElection
			Me.lciElectionLabel.Location = New System.Drawing.Point(0, 0)
			Me.lciElectionLabel.Name = "lciElectionLabel"
			Me.lciElectionLabel.Size = New System.Drawing.Size(625, 41)
			Me.lciElectionLabel.TextSize = New System.Drawing.Size(0, 0)
			Me.lciElectionLabel.TextVisible = False
			' 
			' lcgContent
			' 
			Me.lcgContent.GroupBordersVisible = False
			Me.lcgContent.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciDemPicture, Me.lciElectoralVotes, Me.lciPeopleVotes, Me.lciVoteDescription, Me.lciRepPicture})
			Me.lcgContent.Location = New System.Drawing.Point(0, 41)
			Me.lcgContent.Name = "lcgContent"
			Me.lcgContent.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgContent.Size = New System.Drawing.Size(887, 138)
			Me.lcgContent.TextVisible = False
			' 
			' lciDemPicture
			' 
			Me.lciDemPicture.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lciDemPicture.AppearanceItemCaption.Options.UseFont = True
			Me.lciDemPicture.Control = Me.piDem
			Me.lciDemPicture.Location = New System.Drawing.Point(0, 0)
			Me.lciDemPicture.MaxSize = New System.Drawing.Size(94, 138)
			Me.lciDemPicture.MinSize = New System.Drawing.Size(94, 138)
			Me.lciDemPicture.Name = "lciDemPicture"
			Me.lciDemPicture.Size = New System.Drawing.Size(94, 138)
			Me.lciDemPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciDemPicture.TextLocation = DevExpress.Utils.Locations.Bottom
			Me.lciDemPicture.TextSize = New System.Drawing.Size(81, 13)
			' 
			' lciElectoralVotes
			' 
			Me.lciElectoralVotes.Control = Me.votesPanelElectoral
			Me.lciElectoralVotes.Location = New System.Drawing.Point(94, 0)
			Me.lciElectoralVotes.Name = "lciElectoralVotes"
			Me.lciElectoralVotes.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
			Me.lciElectoralVotes.Size = New System.Drawing.Size(699, 81)
			Me.lciElectoralVotes.TextSize = New System.Drawing.Size(0, 0)
			Me.lciElectoralVotes.TextVisible = False
			' 
			' lciPeopleVotes
			' 
			Me.lciPeopleVotes.Control = Me.votesPanelPeople
			Me.lciPeopleVotes.Location = New System.Drawing.Point(94, 81)
			Me.lciPeopleVotes.Name = "lciPeopleVotes"
			Me.lciPeopleVotes.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 15)
			Me.lciPeopleVotes.Size = New System.Drawing.Size(699, 37)
			Me.lciPeopleVotes.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPeopleVotes.TextVisible = False
			' 
			' lciVoteDescription
			' 
			Me.lciVoteDescription.Control = Me.labelControl1
			Me.lciVoteDescription.Location = New System.Drawing.Point(94, 118)
			Me.lciVoteDescription.Name = "lciVoteDescription"
			Me.lciVoteDescription.Size = New System.Drawing.Size(699, 20)
			Me.lciVoteDescription.TextSize = New System.Drawing.Size(0, 0)
			Me.lciVoteDescription.TextVisible = False
			' 
			' lciRepPicture
			' 
			Me.lciRepPicture.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.lciRepPicture.AppearanceItemCaption.Options.UseFont = True
			Me.lciRepPicture.Control = Me.piRep
			Me.lciRepPicture.Location = New System.Drawing.Point(793, 0)
			Me.lciRepPicture.MaxSize = New System.Drawing.Size(94, 138)
			Me.lciRepPicture.MinSize = New System.Drawing.Size(94, 138)
			Me.lciRepPicture.Name = "lciRepPicture"
			Me.lciRepPicture.Size = New System.Drawing.Size(94, 138)
			Me.lciRepPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciRepPicture.TextLocation = DevExpress.Utils.Locations.Bottom
			Me.lciRepPicture.TextSize = New System.Drawing.Size(81, 13)
			' 
			' lciShow2012
			' 
			Me.lciShow2012.Control = Me.switchResults
			Me.lciShow2012.Location = New System.Drawing.Point(625, 0)
			Me.lciShow2012.MaxSize = New System.Drawing.Size(84, 0)
			Me.lciShow2012.MinSize = New System.Drawing.Size(84, 26)
			Me.lciShow2012.Name = "lciShow2012"
			Me.lciShow2012.Size = New System.Drawing.Size(84, 41)
			Me.lciShow2012.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciShow2012.TextSize = New System.Drawing.Size(0, 0)
			Me.lciShow2012.TextVisible = False
			' 
			' lcgSimulationMode
			' 
			Me.lcgSimulationMode.GroupBordersVisible = False
			Me.lcgSimulationMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciSimulationMode})
			Me.lcgSimulationMode.Location = New System.Drawing.Point(709, 0)
			Me.lcgSimulationMode.Name = "lcgSimulationMode"
			Me.lcgSimulationMode.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgSimulationMode.Size = New System.Drawing.Size(178, 41)
			Me.lcgSimulationMode.TextVisible = False
			' 
			' lciSimulationMode
			' 
			Me.lciSimulationMode.Control = Me.tsElectionSimilutor
			Me.lciSimulationMode.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.lciSimulationMode.FillControlToClientArea = False
			Me.lciSimulationMode.Location = New System.Drawing.Point(0, 0)
			Me.lciSimulationMode.MaxSize = New System.Drawing.Size(178, 35)
			Me.lciSimulationMode.MinSize = New System.Drawing.Size(178, 35)
			Me.lciSimulationMode.Name = "lciSimulationMode"
			Me.lciSimulationMode.Size = New System.Drawing.Size(178, 41)
			Me.lciSimulationMode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciSimulationMode.Text = "Simulation mode:"
			Me.lciSimulationMode.TextSize = New System.Drawing.Size(81, 13)
			Me.lciSimulationMode.TrimClientAreaToControl = False
			' 
			' Map
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl)
			Me.Name = "Map"
			Me.Size = New System.Drawing.Size(907, 568)
'			Me.Load += New System.EventHandler(Me.Map_Load)
'			Me.SizeChanged += New System.EventHandler(Me.Map_SizeChanged)
			DirectCast(Me.repProgress, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.demProgress, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.tsElectionSimilutor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl.ResumeLayout(False)
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			DirectCast(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.listVoteResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.piRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.piDem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lcgStateResult, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciGrid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciMapControl, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciElectionLabel, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lcgContent, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciDemPicture, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciElectoralVotes, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciPeopleVotes, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciVoteDescription, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciRepPicture, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciShow2012, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lcgSimulationMode, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.lciSimulationMode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents mapControl As DevExpress.XtraMap.MapControl
		Private stateLayer As DevExpress.XtraMap.VectorItemsLayer
		Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter
		Private grid As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colArea As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colGOP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDem As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private listVoteResultsBindingSource As System.Windows.Forms.BindingSource
		Private colRepPercents As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDemPercents As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private lbElection As DevExpress.XtraEditors.LabelControl
		Private piRep As DevExpress.XtraEditors.PictureEdit
		Private piDem As DevExpress.XtraEditors.PictureEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents btBackToStates As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btCenter As DevExpress.XtraEditors.SimpleButton
		Private votesPanelElectoral As VotesPanel
		Private votesPanelPeople As VotesPanel
		Private demProgress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private repProgress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private WithEvents mapTooltipController As DevExpress.Utils.ToolTipController
		Private WithEvents gridTooltipController As DevExpress.Utils.ToolTipController
		Private WithEvents switchResults As DevExpress.XtraEditors.SimpleButton
		Private WithEvents tsElectionSimilutor As XtraEditors.ToggleSwitch
		Private layoutControl As XtraLayout.LayoutControl
		Private panelControl1 As XtraEditors.PanelControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private lciElectoralVotes As XtraLayout.LayoutControlItem
		Private lciPeopleVotes As XtraLayout.LayoutControlItem
		Private lciVoteDescription As XtraLayout.LayoutControlItem
		Private lciRepPicture As XtraLayout.LayoutControlItem
		Private lcgStateResult As XtraLayout.LayoutControlGroup
		Private lciGrid As XtraLayout.LayoutControlItem
		Private lciElectionLabel As XtraLayout.LayoutControlItem
		Private lciShow2012 As XtraLayout.LayoutControlItem
		Private lcgSimulationMode As XtraLayout.LayoutControlGroup
		Private lciSimulationMode As XtraLayout.LayoutControlItem
		Private lcgContent As XtraLayout.LayoutControlGroup
		Private lciDemPicture As XtraLayout.LayoutControlItem
		Private lciMapControl As XtraLayout.LayoutControlItem
	End Class
End Namespace
