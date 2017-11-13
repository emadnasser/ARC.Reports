namespace DevExpress.VoteApp {
    partial class Map {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.MapOverlay mapOverlay1 = new DevExpress.XtraMap.MapOverlay();
            DevExpress.XtraMap.MapOverlayTextItem mapOverlayTextItem1 = new DevExpress.XtraMap.MapOverlayTextItem();
            this.colRepPercents = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGOP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repProgress = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.colDemPercents = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDem = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.demProgress = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.stateLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.mapTooltipController = new DevExpress.Utils.ToolTipController(this.components);
            this.tsElectionSimilutor = new DevExpress.XtraEditors.ToggleSwitch();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btCenter = new DevExpress.XtraEditors.SimpleButton();
            this.btBackToStates = new DevExpress.XtraEditors.SimpleButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.listVoteResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridTooltipController = new DevExpress.Utils.ToolTipController(this.components);
            this.votesPanelPeople = new DevExpress.VoteApp.VotesPanel();
            this.piRep = new DevExpress.XtraEditors.PictureEdit();
            this.votesPanelElectoral = new DevExpress.VoteApp.VotesPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.switchResults = new DevExpress.XtraEditors.SimpleButton();
            this.lbElection = new DevExpress.XtraEditors.LabelControl();
            this.piDem = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgStateResult = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMapControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciElectionLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgContent = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDemPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciElectoralVotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPeopleVotes = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVoteDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRepPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciShow2012 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSimulationMode = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSimulationMode = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.repProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsElectionSimilutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVoteResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piRep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgStateResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciElectionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciElectoralVotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPeopleVotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoteDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShow2012)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSimulationMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSimulationMode)).BeginInit();
            this.SuspendLayout();
            // 
            // colRepPercents
            // 
            this.colRepPercents.FieldName = "RepPercents";
            this.colRepPercents.Name = "colRepPercents";
            this.colRepPercents.Visible = true;
            // 
            // colGOP
            // 
            this.colGOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGOP.AppearanceHeader.Options.UseFont = true;
            this.colGOP.AutoFillDown = true;
            this.colGOP.Caption = "GOP";
            this.colGOP.ColumnEdit = this.repProgress;
            this.colGOP.FieldName = "IntRepPercents";
            this.colGOP.Name = "colGOP";
            this.colGOP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Excel;
            this.colGOP.RowIndex = 1;
            this.colGOP.Visible = true;
            this.colGOP.Width = 209;
            // 
            // repProgress
            // 
            this.repProgress.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.repProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.repProgress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repProgress.Name = "repProgress";
            this.repProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.repProgress.ShowTitle = true;
            this.repProgress.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            // 
            // colDemPercents
            // 
            this.colDemPercents.FieldName = "DemPercents";
            this.colDemPercents.Name = "colDemPercents";
            this.colDemPercents.Visible = true;
            // 
            // colDem
            // 
            this.colDem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDem.AppearanceHeader.Options.UseFont = true;
            this.colDem.Caption = "DEM";
            this.colDem.ColumnEdit = this.demProgress;
            this.colDem.FieldName = "IntDemPercents";
            this.colDem.Name = "colDem";
            this.colDem.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Excel;
            this.colDem.Visible = true;
            this.colDem.Width = 209;
            // 
            // demProgress
            // 
            this.demProgress.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(156)))), ((int)(((byte)(189)))));
            this.demProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.demProgress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.demProgress.Name = "demProgress";
            this.demProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.demProgress.ShowTitle = true;
            this.demProgress.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(156)))), ((int)(((byte)(189)))));
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(40D, -104D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.EnableScrolling = false;
            this.mapControl.Layers.Add(this.stateLayer);
            this.mapControl.Location = new System.Drawing.Point(2, 2);
            this.mapControl.MaxZoomLevel = 9D;
            this.mapControl.MinZoomLevel = 4D;
            this.mapControl.Name = "mapControl";
            this.mapControl.NavigationPanelOptions.Height = 40;
            this.mapControl.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl.NavigationPanelOptions.ShowScrollButtons = false;
            mapOverlay1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            mapOverlayTextItem1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            mapOverlayTextItem1.Text = "Source: United States Federal Election Commission; County-Level election data cou" +
    "rtesy of TheGuardian.com";
            mapOverlayTextItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            mapOverlayTextItem1.TextStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mapOverlay1.Items.Add(mapOverlayTextItem1);
            mapOverlay1.Location = new System.Drawing.Point(30, -30);
            this.mapControl.Overlays.Add(mapOverlay1);
            this.mapControl.Size = new System.Drawing.Size(579, 361);
            this.mapControl.TabIndex = 0;
            this.mapControl.ToolTipController = this.mapTooltipController;
            this.mapControl.ZoomLevel = 4D;
            this.mapControl.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl_MapItemClick);
            this.mapControl.MapItemDoubleClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl_MapItemClick);
            this.mapControl.DoubleClick += new System.EventHandler(this.mapControl_DoubleClick);
            // 
            // stateLayer
            // 
            this.stateLayer.Data = this.shapefileDataAdapter1;
            this.stateLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.stateLayer.ToolTipPattern = "%V0%";
            // 
            // mapTooltipController
            // 
            this.mapTooltipController.AllowHtmlText = true;
            this.mapTooltipController.AutoPopDelay = 500;
            this.mapTooltipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.mapTooltipController.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.mapTooltipController_BeforeShow);
            // 
            // tsElectionSimilutor
            // 
            this.tsElectionSimilutor.Location = new System.Drawing.Point(805, 18);
            this.tsElectionSimilutor.Name = "tsElectionSimilutor";
            this.tsElectionSimilutor.Properties.OffText = "Off";
            this.tsElectionSimilutor.Properties.OnText = "On";
            this.tsElectionSimilutor.Size = new System.Drawing.Size(90, 24);
            this.tsElectionSimilutor.StyleController = this.layoutControl;
            this.tsElectionSimilutor.TabIndex = 7;
            this.tsElectionSimilutor.Toggled += new System.EventHandler(this.tsElectionSimilutor_Toggled);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.panelControl1);
            this.layoutControl.Controls.Add(this.grid);
            this.layoutControl.Controls.Add(this.votesPanelPeople);
            this.layoutControl.Controls.Add(this.piRep);
            this.layoutControl.Controls.Add(this.votesPanelElectoral);
            this.layoutControl.Controls.Add(this.labelControl1);
            this.layoutControl.Controls.Add(this.tsElectionSimilutor);
            this.layoutControl.Controls.Add(this.switchResults);
            this.layoutControl.Controls.Add(this.lbElection);
            this.layoutControl.Controls.Add(this.piDem);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1013, 231, 650, 400);
            this.layoutControl.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(907, 568);
            this.layoutControl.TabIndex = 9;
            this.layoutControl.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btCenter);
            this.panelControl1.Controls.Add(this.btBackToStates);
            this.panelControl1.Controls.Add(this.mapControl);
            this.panelControl1.Location = new System.Drawing.Point(312, 191);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(583, 365);
            this.panelControl1.TabIndex = 9;
            // 
            // btCenter
            // 
            this.btCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCenter.Location = new System.Drawing.Point(487, 5);
            this.btCenter.Name = "btCenter";
            this.btCenter.Size = new System.Drawing.Size(91, 30);
            this.btCenter.TabIndex = 6;
            this.btCenter.Text = "Center Map";
            this.btCenter.Click += new System.EventHandler(this.btCenter_Click);
            // 
            // btBackToStates
            // 
            this.btBackToStates.Location = new System.Drawing.Point(5, 5);
            this.btBackToStates.Name = "btBackToStates";
            this.btBackToStates.Size = new System.Drawing.Size(91, 30);
            this.btBackToStates.TabIndex = 5;
            this.btBackToStates.Text = "Back to States";
            this.btBackToStates.Visible = false;
            this.btBackToStates.Click += new System.EventHandler(this.btBackToStates_Click);
            // 
            // grid
            // 
            this.grid.DataSource = this.listVoteResultsBindingSource;
            this.grid.Location = new System.Drawing.Point(12, 191);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.demProgress,
            this.repProgress});
            this.grid.Size = new System.Drawing.Size(296, 365);
            this.grid.TabIndex = 3;
            this.grid.ToolTipController = this.gridTooltipController;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // listVoteResultsBindingSource
            // 
            this.listVoteResultsBindingSource.DataSource = typeof(DevExpress.VoteApp.ListVoteResults);
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colArea,
            this.colGOP,
            this.colDem,
            this.colRepPercents,
            this.colDemPercents});
            this.gridView.GridControl = this.grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowBandMoving = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = true;
            this.gridView.OptionsView.ShowBands = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView_CustomDrawCell);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colArea);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 88;
            // 
            // colArea
            // 
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.Caption = "Area";
            this.colArea.FieldName = "Name";
            this.colArea.Name = "colArea";
            this.colArea.RowCount = 2;
            this.colArea.Visible = true;
            this.colArea.Width = 88;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colDem);
            this.gridBand2.Columns.Add(this.colGOP);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 209;
            // 
            // gridTooltipController
            // 
            this.gridTooltipController.AutoPopDelay = 500;
            this.gridTooltipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.gridTooltipController_GetActiveObjectInfo);
            this.gridTooltipController.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.gridTooltipController_BeforeShow);
            // 
            // votesPanelPeople
            // 
            this.votesPanelPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votesPanelPeople.BackColor = System.Drawing.Color.Silver;
            this.votesPanelPeople.ColorLeft = System.Drawing.Color.Empty;
            this.votesPanelPeople.ColorRight = System.Drawing.Color.Empty;
            this.votesPanelPeople.Location = new System.Drawing.Point(106, 134);
            this.votesPanelPeople.Name = "votesPanelPeople";
            this.votesPanelPeople.Size = new System.Drawing.Size(695, 20);
            this.votesPanelPeople.TabIndex = 8;
            this.votesPanelPeople.VotesTextLeft = "<b>50%</b> <i>Votes";
            this.votesPanelPeople.VotesTextRight = "Votes</size> <b>50%</b>";
            this.votesPanelPeople.VotesTextSize = 10F;
            // 
            // piRep
            // 
            this.piRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piRep.Cursor = System.Windows.Forms.Cursors.Default;
            this.piRep.Location = new System.Drawing.Point(805, 53);
            this.piRep.Name = "piRep";
            this.piRep.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.piRep.Properties.Appearance.Options.UseBackColor = true;
            this.piRep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.piRep.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect;
            this.piRep.Properties.OptionsMask.RectCornerRadius = 50;
            this.piRep.Properties.ReadOnly = true;
            this.piRep.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piRep.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piRep.Properties.ZoomAccelerationFactor = 1D;
            this.piRep.Size = new System.Drawing.Size(90, 118);
            this.piRep.StyleController = this.layoutControl;
            this.piRep.TabIndex = 1;
            // 
            // votesPanelElectoral
            // 
            this.votesPanelElectoral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votesPanelElectoral.BackColor = System.Drawing.Color.Silver;
            this.votesPanelElectoral.ColorLeft = System.Drawing.Color.Empty;
            this.votesPanelElectoral.ColorRight = System.Drawing.Color.Empty;
            this.votesPanelElectoral.Location = new System.Drawing.Point(106, 61);
            this.votesPanelElectoral.Name = "votesPanelElectoral";
            this.votesPanelElectoral.Size = new System.Drawing.Size(695, 69);
            this.votesPanelElectoral.TabIndex = 7;
            this.votesPanelElectoral.VotesTextLeft = "<b>100</b> <size=-5><i>Electoral Votes";
            this.votesPanelElectoral.VotesTextRight = "<size=-5>Electoral Votes</size> <b>100</b>";
            this.votesPanelElectoral.VotesTextSize = 15.75F;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(106, 171);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(695, 16);
            this.labelControl1.StyleController = this.layoutControl;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Candidates need 270 electoral votes to win the presidency";
            // 
            // switchResults
            // 
            this.switchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchResults.Location = new System.Drawing.Point(637, 12);
            this.switchResults.Name = "switchResults";
            this.switchResults.Size = new System.Drawing.Size(80, 37);
            this.switchResults.StyleController = this.layoutControl;
            this.switchResults.TabIndex = 6;
            this.switchResults.Text = "Show 2012";
            this.switchResults.Click += new System.EventHandler(this.switchResults_Click);
            // 
            // lbElection
            // 
            this.lbElection.AllowHtmlString = true;
            this.lbElection.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElection.Appearance.Options.UseFont = true;
            this.lbElection.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbElection.Location = new System.Drawing.Point(12, 12);
            this.lbElection.Name = "lbElection";
            this.lbElection.Size = new System.Drawing.Size(621, 37);
            this.lbElection.StyleController = this.layoutControl;
            this.lbElection.TabIndex = 0;
            this.lbElection.Text = "Election 2012";
            // 
            // piDem
            // 
            this.piDem.Cursor = System.Windows.Forms.Cursors.Default;
            this.piDem.Location = new System.Drawing.Point(12, 53);
            this.piDem.Name = "piDem";
            this.piDem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.piDem.Properties.Appearance.Options.UseBackColor = true;
            this.piDem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.piDem.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect;
            this.piDem.Properties.OptionsMask.RectCornerRadius = 50;
            this.piDem.Properties.ReadOnly = true;
            this.piDem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piDem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piDem.Properties.ZoomAccelerationFactor = 1D;
            this.piDem.Size = new System.Drawing.Size(90, 118);
            this.piDem.StyleController = this.layoutControl;
            this.piDem.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgStateResult,
            this.lciMapControl,
            this.lciElectionLabel,
            this.lcgContent,
            this.lciShow2012,
            this.lcgSimulationMode});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(907, 568);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgStateResult
            // 
            this.lcgStateResult.GroupBordersVisible = false;
            this.lcgStateResult.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid});
            this.lcgStateResult.Location = new System.Drawing.Point(0, 179);
            this.lcgStateResult.Name = "lcgStateResult";
            this.lcgStateResult.Size = new System.Drawing.Size(300, 369);
            this.lcgStateResult.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.grid;
            this.lciGrid.Location = new System.Drawing.Point(0, 0);
            this.lciGrid.MaxSize = new System.Drawing.Size(300, 0);
            this.lciGrid.MinSize = new System.Drawing.Size(300, 24);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(300, 369);
            this.lciGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // lciMapControl
            // 
            this.lciMapControl.Control = this.panelControl1;
            this.lciMapControl.Location = new System.Drawing.Point(300, 179);
            this.lciMapControl.Name = "lciMapControl";
            this.lciMapControl.Size = new System.Drawing.Size(587, 369);
            this.lciMapControl.TextSize = new System.Drawing.Size(0, 0);
            this.lciMapControl.TextVisible = false;
            // 
            // lciElectionLabel
            // 
            this.lciElectionLabel.Control = this.lbElection;
            this.lciElectionLabel.Location = new System.Drawing.Point(0, 0);
            this.lciElectionLabel.Name = "lciElectionLabel";
            this.lciElectionLabel.Size = new System.Drawing.Size(625, 41);
            this.lciElectionLabel.TextSize = new System.Drawing.Size(0, 0);
            this.lciElectionLabel.TextVisible = false;
            // 
            // lcgContent
            // 
            this.lcgContent.GroupBordersVisible = false;
            this.lcgContent.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDemPicture,
            this.lciElectoralVotes,
            this.lciPeopleVotes,
            this.lciVoteDescription,
            this.lciRepPicture});
            this.lcgContent.Location = new System.Drawing.Point(0, 41);
            this.lcgContent.Name = "lcgContent";
            this.lcgContent.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgContent.Size = new System.Drawing.Size(887, 138);
            this.lcgContent.TextVisible = false;
            // 
            // lciDemPicture
            // 
            this.lciDemPicture.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lciDemPicture.AppearanceItemCaption.Options.UseFont = true;
            this.lciDemPicture.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDemPicture.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciDemPicture.Control = this.piDem;
            this.lciDemPicture.Location = new System.Drawing.Point(0, 0);
            this.lciDemPicture.MaxSize = new System.Drawing.Size(94, 138);
            this.lciDemPicture.MinSize = new System.Drawing.Size(94, 138);
            this.lciDemPicture.Name = "lciDemPicture";
            this.lciDemPicture.Size = new System.Drawing.Size(94, 138);
            this.lciDemPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDemPicture.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciDemPicture.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lciElectoralVotes
            // 
            this.lciElectoralVotes.Control = this.votesPanelElectoral;
            this.lciElectoralVotes.Location = new System.Drawing.Point(94, 0);
            this.lciElectoralVotes.Name = "lciElectoralVotes";
            this.lciElectoralVotes.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.lciElectoralVotes.Size = new System.Drawing.Size(699, 81);
            this.lciElectoralVotes.TextSize = new System.Drawing.Size(0, 0);
            this.lciElectoralVotes.TextVisible = false;
            // 
            // lciPeopleVotes
            // 
            this.lciPeopleVotes.Control = this.votesPanelPeople;
            this.lciPeopleVotes.Location = new System.Drawing.Point(94, 81);
            this.lciPeopleVotes.Name = "lciPeopleVotes";
            this.lciPeopleVotes.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 15);
            this.lciPeopleVotes.Size = new System.Drawing.Size(699, 37);
            this.lciPeopleVotes.TextSize = new System.Drawing.Size(0, 0);
            this.lciPeopleVotes.TextVisible = false;
            // 
            // lciVoteDescription
            // 
            this.lciVoteDescription.Control = this.labelControl1;
            this.lciVoteDescription.Location = new System.Drawing.Point(94, 118);
            this.lciVoteDescription.Name = "lciVoteDescription";
            this.lciVoteDescription.Size = new System.Drawing.Size(699, 20);
            this.lciVoteDescription.TextSize = new System.Drawing.Size(0, 0);
            this.lciVoteDescription.TextVisible = false;
            // 
            // lciRepPicture
            // 
            this.lciRepPicture.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lciRepPicture.AppearanceItemCaption.Options.UseFont = true;
            this.lciRepPicture.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciRepPicture.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciRepPicture.Control = this.piRep;
            this.lciRepPicture.Location = new System.Drawing.Point(793, 0);
            this.lciRepPicture.MaxSize = new System.Drawing.Size(94, 138);
            this.lciRepPicture.MinSize = new System.Drawing.Size(94, 138);
            this.lciRepPicture.Name = "lciRepPicture";
            this.lciRepPicture.Size = new System.Drawing.Size(94, 138);
            this.lciRepPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRepPicture.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lciRepPicture.TextSize = new System.Drawing.Size(81, 13);
            // 
            // lciShow2012
            // 
            this.lciShow2012.Control = this.switchResults;
            this.lciShow2012.Location = new System.Drawing.Point(625, 0);
            this.lciShow2012.MaxSize = new System.Drawing.Size(84, 0);
            this.lciShow2012.MinSize = new System.Drawing.Size(84, 26);
            this.lciShow2012.Name = "lciShow2012";
            this.lciShow2012.Size = new System.Drawing.Size(84, 41);
            this.lciShow2012.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciShow2012.TextSize = new System.Drawing.Size(0, 0);
            this.lciShow2012.TextVisible = false;
            // 
            // lcgSimulationMode
            // 
            this.lcgSimulationMode.GroupBordersVisible = false;
            this.lcgSimulationMode.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSimulationMode});
            this.lcgSimulationMode.Location = new System.Drawing.Point(709, 0);
            this.lcgSimulationMode.Name = "lcgSimulationMode";
            this.lcgSimulationMode.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgSimulationMode.Size = new System.Drawing.Size(178, 41);
            this.lcgSimulationMode.TextVisible = false;
            // 
            // lciSimulationMode
            // 
            this.lciSimulationMode.Control = this.tsElectionSimilutor;
            this.lciSimulationMode.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lciSimulationMode.FillControlToClientArea = false;
            this.lciSimulationMode.Location = new System.Drawing.Point(0, 0);
            this.lciSimulationMode.MaxSize = new System.Drawing.Size(178, 35);
            this.lciSimulationMode.MinSize = new System.Drawing.Size(178, 35);
            this.lciSimulationMode.Name = "lciSimulationMode";
            this.lciSimulationMode.Size = new System.Drawing.Size(178, 41);
            this.lciSimulationMode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSimulationMode.Text = "Simulation mode:";
            this.lciSimulationMode.TextSize = new System.Drawing.Size(81, 13);
            this.lciSimulationMode.TrimClientAreaToControl = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(907, 568);
            this.Load += new System.EventHandler(this.Map_Load);
            this.SizeChanged += new System.EventHandler(this.Map_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.repProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsElectionSimilutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVoteResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piRep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgStateResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciElectionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciElectoralVotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPeopleVotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoteDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShow2012)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSimulationMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSimulationMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraMap.VectorItemsLayer stateLayer;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGOP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDem;
        private System.Windows.Forms.BindingSource listVoteResultsBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRepPercents;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDemPercents;
        private DevExpress.XtraEditors.LabelControl lbElection;
        private DevExpress.XtraEditors.PictureEdit piRep;
        private DevExpress.XtraEditors.PictureEdit piDem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btBackToStates;
        private DevExpress.XtraEditors.SimpleButton btCenter;
        private VotesPanel votesPanelElectoral;
        private VotesPanel votesPanelPeople;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar demProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repProgress;
        private DevExpress.Utils.ToolTipController mapTooltipController;
        private DevExpress.Utils.ToolTipController gridTooltipController;
        private DevExpress.XtraEditors.SimpleButton switchResults;
        private XtraEditors.ToggleSwitch tsElectionSimilutor;
        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.PanelControl panelControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem lciElectoralVotes;
        private XtraLayout.LayoutControlItem lciPeopleVotes;
        private XtraLayout.LayoutControlItem lciVoteDescription;
        private XtraLayout.LayoutControlItem lciRepPicture;
        private XtraLayout.LayoutControlGroup lcgStateResult;
        private XtraLayout.LayoutControlItem lciGrid;
        private XtraLayout.LayoutControlItem lciElectionLabel;
        private XtraLayout.LayoutControlItem lciShow2012;
        private XtraLayout.LayoutControlGroup lcgSimulationMode;
        private XtraLayout.LayoutControlItem lciSimulationMode;
        private XtraLayout.LayoutControlGroup lcgContent;
        private XtraLayout.LayoutControlItem lciDemPicture;
        private XtraLayout.LayoutControlItem lciMapControl;
    }
}
