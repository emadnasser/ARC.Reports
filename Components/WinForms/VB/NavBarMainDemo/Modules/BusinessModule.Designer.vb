Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class AccordionControlBusinessModule
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
            Dim TrackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim TrackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim TrackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim TrackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim TrackBarLabel5 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim TrackBarLabel6 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.acPriceContainer = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.rTBPrice = New DevExpress.XtraEditors.RangeTrackBarControl()
            Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.accTrademark = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.chLBMark = New NavBarMainDemo.Modules.CustomCheckedListBoxControl()
            Me.accTransmissionType = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.rgTransmissionType = New DevExpress.XtraEditors.RadioGroup()
            Me.accBodyStyle = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.clbBodyStyle = New NavBarMainDemo.Modules.CustomCheckedListBoxControl()
            Me.accDoorsCount = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.rgDoorsCount = New DevExpress.XtraEditors.RadioGroup()
            Me.accMPGCity = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.rtbMPGCity = New DevExpress.XtraEditors.RangeTrackBarControl()
            Me.accordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.rtbMPGHighway = New DevExpress.XtraEditors.RangeTrackBarControl()
            Me.aceMainParameters = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.acePrice = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceTrademark = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceTransmissionType = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceInStock = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceBody = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceBodyStyle = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceDoors = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceEngine = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceMPGCity = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aceMPGHighway = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel_Renamed.SuspendLayout()
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl1.SuspendLayout()
            Me.acPriceContainer.SuspendLayout()
            CType(Me.rTBPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rTBPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accTrademark.SuspendLayout()
            CType(Me.chLBMark, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accTransmissionType.SuspendLayout()
            CType(Me.rgTransmissionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accBodyStyle.SuspendLayout()
            CType(Me.clbBodyStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accDoorsCount.SuspendLayout()
            CType(Me.rgDoorsCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accMPGCity.SuspendLayout()
            CType(Me.rtbMPGCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rtbMPGCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer2.SuspendLayout()
            CType(Me.rtbMPGHighway, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rtbMPGHighway.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'contentPanel_Renamed
            '
            Me.contentPanel_Renamed.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.contentPanel_Renamed.Controls.Add(Me.gridControl1)
            Me.contentPanel_Renamed.Controls.Add(Me.LabelControl1)
            Me.contentPanel_Renamed.Padding = New System.Windows.Forms.Padding(0)
            Me.contentPanel_Renamed.Size = New System.Drawing.Size(811, 770)
            '
            'accordionControl1
            '
            Me.accordionControl1.ExpandElementMode = XtraBars.Navigation.ExpandElementMode.Multiple
            Me.accordionControl1.ContextButtonsOptions.BottomPanelColor = System.Drawing.Color.Empty
            Me.accordionControl1.ContextButtonsOptions.BottomPanelPadding = New System.Windows.Forms.Padding(5)
            Me.accordionControl1.ContextButtonsOptions.CenterPanelColor = System.Drawing.Color.Empty
            Me.accordionControl1.ContextButtonsOptions.FarPanelColor = System.Drawing.Color.Empty
            Me.accordionControl1.ContextButtonsOptions.FarPanelPadding = New System.Windows.Forms.Padding(5)
            Me.accordionControl1.ContextButtonsOptions.NearPanelColor = System.Drawing.Color.Empty
            Me.accordionControl1.ContextButtonsOptions.NearPanelPadding = New System.Windows.Forms.Padding(5)
            Me.accordionControl1.ContextButtonsOptions.TopPanelColor = System.Drawing.Color.Empty
            Me.accordionControl1.ContextButtonsOptions.TopPanelPadding = New System.Windows.Forms.Padding(5)
            Me.accordionControl1.Controls.Add(Me.acPriceContainer)
            Me.accordionControl1.Controls.Add(Me.accTrademark)
            Me.accordionControl1.Controls.Add(Me.accTransmissionType)
            Me.accordionControl1.Controls.Add(Me.accBodyStyle)
            Me.accordionControl1.Controls.Add(Me.accDoorsCount)
            Me.accordionControl1.Controls.Add(Me.accMPGCity)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer2)
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceMainParameters, Me.aceBody, Me.aceEngine})
            Me.accordionControl1.Location = New System.Drawing.Point(811, 0)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
            Me.accordionControl1.Size = New System.Drawing.Size(318, 770)
            Me.accordionControl1.TabIndex = 0
            Me.accordionControl1.Text = "accordionControl1"
            '
            'acPriceContainer
            '
            Me.acPriceContainer.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.acPriceContainer.Appearance.Options.UseBackColor = True
            Me.acPriceContainer.Controls.Add(Me.rTBPrice)
            Me.acPriceContainer.Name = "acPriceContainer"
            Me.acPriceContainer.Padding = New System.Windows.Forms.Padding(-1)
            Me.acPriceContainer.Size = New System.Drawing.Size(301, 71)
            Me.acPriceContainer.TabIndex = 1
            '
            'rTBPrice
            '
            Me.rTBPrice.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rTBPrice.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 200000)
            Me.rTBPrice.Location = New System.Drawing.Point(25, 4)
            Me.rTBPrice.Margin = New System.Windows.Forms.Padding(0)
            Me.rTBPrice.Name = "rTBPrice"
            Me.rTBPrice.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rTBPrice.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            TrackBarLabel1.Label = "200000"
            TrackBarLabel1.Value = 200000
            TrackBarLabel2.Label = "0"
            Me.rTBPrice.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {TrackBarLabel1, TrackBarLabel2})
            Me.rTBPrice.Properties.Maximum = 200000
            Me.rTBPrice.Properties.ShowLabels = True
            Me.rTBPrice.Properties.ShowValueToolTip = True
            Me.rTBPrice.Properties.TickFrequency = 10000
            Me.rTBPrice.Size = New System.Drawing.Size(264, 51)
            Me.rTBPrice.TabIndex = 5
            Me.rTBPrice.ToolTipController = Me.ToolTipController1
            Me.rTBPrice.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 200000)
            '
            'accTrademark
            '
            Me.accTrademark.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accTrademark.Appearance.Options.UseBackColor = True
            Me.accTrademark.Controls.Add(Me.chLBMark)
            Me.accTrademark.Name = "accTrademark"
            Me.accTrademark.Padding = New System.Windows.Forms.Padding(-1)
            Me.accTrademark.Size = New System.Drawing.Size(301, 209)
            Me.accTrademark.TabIndex = 3
            '
            'chLBMark
            '
            Me.chLBMark.Appearance.BackColor = System.Drawing.Color.White
            Me.chLBMark.Appearance.Options.UseBackColor = True
            Me.chLBMark.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.chLBMark.CheckOnClick = True
            Me.chLBMark.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chLBMark.Location = New System.Drawing.Point(25, 4)
            Me.chLBMark.MultiColumn = True
            Me.chLBMark.Name = "chLBMark"
            Me.chLBMark.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.chLBMark.ShowFocusRect = False
            Me.chLBMark.Size = New System.Drawing.Size(264, 189)
            Me.chLBMark.TabIndex = 0
            '
            'accTransmissionType
            '
            Me.accTransmissionType.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accTransmissionType.Appearance.Options.UseBackColor = True
            Me.accTransmissionType.Controls.Add(Me.rgTransmissionType)
            Me.accTransmissionType.Name = "accTransmissionType"
            Me.accTransmissionType.Padding = New System.Windows.Forms.Padding(-1)
            Me.accTransmissionType.Size = New System.Drawing.Size(301, 96)
            Me.accTransmissionType.TabIndex = 5
            '
            'rgTransmissionType
            '
            Me.rgTransmissionType.BackColor = System.Drawing.Color.Transparent
            Me.rgTransmissionType.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rgTransmissionType.Location = New System.Drawing.Point(25, 4)
            Me.rgTransmissionType.Margin = New System.Windows.Forms.Padding(0)
            Me.rgTransmissionType.Name = "rgTransmissionType"
            Me.rgTransmissionType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgTransmissionType.Properties.Columns = 1
            Me.rgTransmissionType.Size = New System.Drawing.Size(264, 76)
            Me.rgTransmissionType.TabIndex = 0
            '
            'accBodyStyle
            '
            Me.accBodyStyle.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accBodyStyle.Appearance.Options.UseBackColor = True
            Me.accBodyStyle.Controls.Add(Me.clbBodyStyle)
            Me.accBodyStyle.Name = "accBodyStyle"
            Me.accBodyStyle.Padding = New System.Windows.Forms.Padding(-1)
            Me.accBodyStyle.Size = New System.Drawing.Size(301, 105)
            Me.accBodyStyle.TabIndex = 9
            '
            'clbBodyStyle
            '
            Me.clbBodyStyle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.clbBodyStyle.CheckOnClick = True
            Me.clbBodyStyle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clbBodyStyle.Location = New System.Drawing.Point(25, 4)
            Me.clbBodyStyle.MultiColumn = True
            Me.clbBodyStyle.Name = "clbBodyStyle"
            Me.clbBodyStyle.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.clbBodyStyle.ShowFocusRect = False
            Me.clbBodyStyle.Size = New System.Drawing.Size(264, 85)
            Me.clbBodyStyle.TabIndex = 0
            '
            'accDoorsCount
            '
            Me.accDoorsCount.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accDoorsCount.Appearance.Options.UseBackColor = True
            Me.accDoorsCount.Controls.Add(Me.rgDoorsCount)
            Me.accDoorsCount.Name = "accDoorsCount"
            Me.accDoorsCount.Padding = New System.Windows.Forms.Padding(-1)
            Me.accDoorsCount.Size = New System.Drawing.Size(301, 104)
            Me.accDoorsCount.TabIndex = 10
            '
            'rgDoorsCount
            '
            Me.rgDoorsCount.BackColor = System.Drawing.Color.Transparent
            Me.rgDoorsCount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rgDoorsCount.Location = New System.Drawing.Point(25, 4)
            Me.rgDoorsCount.Name = "rgDoorsCount"
            Me.rgDoorsCount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgDoorsCount.Properties.Columns = 1
            Me.rgDoorsCount.Size = New System.Drawing.Size(264, 84)
            Me.rgDoorsCount.TabIndex = 0
            '
            'accMPGCity
            '
            Me.accMPGCity.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accMPGCity.Appearance.Options.UseBackColor = True
            Me.accMPGCity.Controls.Add(Me.rtbMPGCity)
            Me.accMPGCity.Name = "accMPGCity"
            Me.accMPGCity.Padding = New System.Windows.Forms.Padding(-1)
            Me.accMPGCity.Size = New System.Drawing.Size(301, 74)
            Me.accMPGCity.TabIndex = 11
            '
            'rtbMPGCity
            '
            Me.rtbMPGCity.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rtbMPGCity.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 50)
            Me.rtbMPGCity.Location = New System.Drawing.Point(25, 4)
            Me.rtbMPGCity.Name = "rtbMPGCity"
            Me.rtbMPGCity.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rtbMPGCity.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            TrackBarLabel3.Label = ""
            TrackBarLabel4.Label = "50"
            TrackBarLabel4.Value = 50
            Me.rtbMPGCity.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {TrackBarLabel3, TrackBarLabel4})
            Me.rtbMPGCity.Properties.Maximum = 50
            Me.rtbMPGCity.Properties.ShowLabels = True
            Me.rtbMPGCity.Size = New System.Drawing.Size(264, 54)
            Me.rtbMPGCity.TabIndex = 5
            Me.rtbMPGCity.ToolTipController = Me.ToolTipController1
            Me.rtbMPGCity.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 50)
            '
            'accordionContentContainer2
            '
            Me.accordionContentContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer2.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer2.Controls.Add(Me.rtbMPGHighway)
            Me.accordionContentContainer2.Name = "accordionContentContainer2"
            Me.accordionContentContainer2.Padding = New System.Windows.Forms.Padding(-1)
            Me.accordionContentContainer2.Size = New System.Drawing.Size(301, 77)
            Me.accordionContentContainer2.TabIndex = 13
            '
            'rtbMPGHighway
            '
            Me.rtbMPGHighway.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rtbMPGHighway.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 50)
            Me.rtbMPGHighway.Location = New System.Drawing.Point(25, 4)
            Me.rtbMPGHighway.Name = "rtbMPGHighway"
            Me.rtbMPGHighway.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.rtbMPGHighway.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            TrackBarLabel5.Label = ""
            TrackBarLabel6.Label = "50"
            TrackBarLabel6.Value = 50
            Me.rtbMPGHighway.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {TrackBarLabel5, TrackBarLabel6})
            Me.rtbMPGHighway.Properties.Maximum = 50
            Me.rtbMPGHighway.Properties.ShowLabels = True
            Me.rtbMPGHighway.Size = New System.Drawing.Size(264, 57)
            Me.rtbMPGHighway.TabIndex = 5
            Me.rtbMPGHighway.ToolTipController = Me.ToolTipController1
            Me.rtbMPGHighway.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 50)
            '
            'aceMainParameters
            '
            Me.aceMainParameters.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acePrice, Me.aceTrademark, Me.aceTransmissionType, Me.aceInStock})
            Me.aceMainParameters.Expanded = True
            Me.aceMainParameters.Text = "Main parameters"
            '
            'acePrice
            '
            Me.acePrice.ContentContainer = Me.acPriceContainer
            Me.acePrice.Expanded = True
            Me.acePrice.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.acePrice.Text = "Price ($)"
            '
            'aceTrademark
            '
            Me.aceTrademark.ContentContainer = Me.accTrademark
            Me.aceTrademark.Expanded = True
            Me.aceTrademark.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceTrademark.Text = "Trademark"
            '
            'aceTransmissionType
            '
            Me.aceTransmissionType.ContentContainer = Me.accTransmissionType
            Me.aceTransmissionType.Expanded = True
            Me.aceTransmissionType.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceTransmissionType.Text = "Transmission type"
            '
            'aceInStock
            '
            Me.aceInStock.Expanded = True
            Me.aceInStock.HeaderVisible = False
            Me.aceInStock.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceInStock.Text = "accordionControlElement3"
            '
            'aceBody
            '
            Me.aceBody.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceBodyStyle, Me.aceDoors})
            Me.aceBody.Expanded = True
            Me.aceBody.Text = "Body"
            '
            'aceBodyStyle
            '
            Me.aceBodyStyle.ContentContainer = Me.accBodyStyle
            Me.aceBodyStyle.Expanded = True
            Me.aceBodyStyle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceBodyStyle.Text = "Body Style"
            '
            'aceDoors
            '
            Me.aceDoors.ContentContainer = Me.accDoorsCount
            Me.aceDoors.Expanded = True
            Me.aceDoors.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceDoors.Text = "Doors"
            '
            'aceEngine
            '
            Me.aceEngine.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceMPGCity, Me.aceMPGHighway})
            Me.aceEngine.Expanded = True
            Me.aceEngine.Text = "Engine"
            '
            'aceMPGCity
            '
            Me.aceMPGCity.ContentContainer = Me.accMPGCity
            Me.aceMPGCity.Expanded = True
            Me.aceMPGCity.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceMPGCity.Text = "MPG City"
            '
            'aceMPGHighway
            '
            Me.aceMPGHighway.ContentContainer = Me.accordionContentContainer2
            Me.aceMPGHighway.Expanded = True
            Me.aceMPGHighway.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aceMPGHighway.Text = "MPG Highway"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.winExplorerView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(795, 770)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            '
            'winExplorerView1
            '
            Me.winExplorerView1.Appearance.ItemDescriptionHovered.Font = New System.Drawing.Font("Tahoma", 18.0!)
            Me.winExplorerView1.Appearance.ItemDescriptionHovered.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemDescriptionNormal.Font = New System.Drawing.Font("Tahoma", 18.0!)
            Me.winExplorerView1.Appearance.ItemDescriptionNormal.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemDescriptionPressed.Font = New System.Drawing.Font("Tahoma", 18.0!)
            Me.winExplorerView1.Appearance.ItemDescriptionPressed.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemHovered.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.winExplorerView1.Appearance.ItemHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
            Me.winExplorerView1.Appearance.ItemHovered.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemHovered.Options.UseForeColor = True
            Me.winExplorerView1.Appearance.ItemNormal.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.winExplorerView1.Appearance.ItemNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
            Me.winExplorerView1.Appearance.ItemNormal.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemNormal.Options.UseForeColor = True
            Me.winExplorerView1.Appearance.ItemPressed.Font = New System.Drawing.Font("Tahoma", 11.0!)
            Me.winExplorerView1.Appearance.ItemPressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
            Me.winExplorerView1.Appearance.ItemPressed.Options.UseFont = True
            Me.winExplorerView1.Appearance.ItemPressed.Options.UseForeColor = True
            Me.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView1.GridControl = Me.gridControl1
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = New System.Drawing.Size(181, 98)
            Me.winExplorerView1.OptionsViewStyles.ExtraLarge.ShowDescription = DevExpress.Utils.DefaultBoolean.[True]
            '
            'LabelControl1
            '
            Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
            Me.LabelControl1.LineVisible = True
            Me.LabelControl1.Location = New System.Drawing.Point(795, 0)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(16, 770)
            Me.LabelControl1.TabIndex = 1
            '
            'AccordionControlBusinessModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.accordionControl1)
            Me.Name = "AccordionControlBusinessModule"
            Me.Size = New System.Drawing.Size(1129, 770)
            Me.Controls.SetChildIndex(Me.accordionControl1, 0)
            Me.Controls.SetChildIndex(Me.contentPanel_Renamed, 0)
            CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel_Renamed.ResumeLayout(False)
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl1.ResumeLayout(False)
            Me.acPriceContainer.ResumeLayout(False)
            Me.acPriceContainer.PerformLayout()
            CType(Me.rTBPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rTBPrice, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accTrademark.ResumeLayout(False)
            CType(Me.chLBMark, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accTransmissionType.ResumeLayout(False)
            CType(Me.rgTransmissionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accBodyStyle.ResumeLayout(False)
            CType(Me.clbBodyStyle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accDoorsCount.ResumeLayout(False)
            CType(Me.rgDoorsCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accMPGCity.ResumeLayout(False)
            Me.accMPGCity.PerformLayout()
            CType(Me.rtbMPGCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rtbMPGCity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer2.ResumeLayout(False)
            Me.accordionContentContainer2.PerformLayout()
            CType(Me.rtbMPGHighway.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rtbMPGHighway, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.winExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
		Private aceMainParameters As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private acPriceContainer As DevExpress.XtraBars.Navigation.AccordionContentContainer
		Private acePrice As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private aceBody As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accTrademark As DevExpress.XtraBars.Navigation.AccordionContentContainer
        Private WithEvents chLBMark As NavBarMainDemo.Modules.CustomCheckedListBoxControl
		Private aceTrademark As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private aceEngine As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accTransmissionType As DevExpress.XtraBars.Navigation.AccordionContentContainer
		Private WithEvents rgTransmissionType As DevExpress.XtraEditors.RadioGroup
		Private aceTransmissionType As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private aceInStock As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accBodyStyle As DevExpress.XtraBars.Navigation.AccordionContentContainer
        Private WithEvents clbBodyStyle As NavBarMainDemo.Modules.CustomCheckedListBoxControl
		Private aceBodyStyle As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accDoorsCount As DevExpress.XtraBars.Navigation.AccordionContentContainer
		Private WithEvents rgDoorsCount As DevExpress.XtraEditors.RadioGroup
		Private aceDoors As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accMPGCity As DevExpress.XtraBars.Navigation.AccordionContentContainer
		Private aceMPGCity As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private accordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer
		Private aceMPGHighway As DevExpress.XtraBars.Navigation.AccordionControlElement
		Private gridControl1 As XtraGrid.GridControl
		Private winExplorerView1 As XtraGrid.Views.WinExplorer.WinExplorerView
		Private WithEvents rTBPrice As XtraEditors.RangeTrackBarControl
		Private WithEvents rtbMPGCity As XtraEditors.RangeTrackBarControl
        Private WithEvents rtbMPGHighway As XtraEditors.RangeTrackBarControl
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace

