Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class ModuleTransitionManager
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim transition1 As New DevExpress.Utils.Animation.Transition()
            Dim pushTransition1 As New DevExpress.Utils.Animation.PushTransition()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleTransitionManager))
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.transitionManager = New DevExpress.Utils.Animation.TransitionManager()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbWaitingIndicatorType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.btnWaitingIndicator = New DevExpress.XtraEditors.SimpleButton()
            Me.cbTransitionType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceBackground = New DevExpress.XtraEditors.ColorEdit()
            Me.cbEasingFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.seStripeCount = New DevExpress.XtraEditors.SpinEdit()
            Me.checkUnCover = New DevExpress.XtraEditors.CheckEdit()
            Me.cbEasingMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seFrameInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.checkInward = New DevExpress.XtraEditors.CheckEdit()
            Me.cbEffectOptions = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seFrameCount = New DevExpress.XtraEditors.SpinEdit()
            Me.checkVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.cbShowWaitIndicator = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl1.SuspendLayout()
            Me.accordionContentContainer1.SuspendLayout()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.cbWaitingIndicatorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTransitionType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbEasingFunction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seStripeCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkUnCover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbEasingMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seFrameInterval.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkInward.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbEffectOptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seFrameCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkVertical.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbShowWaitIndicator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureEdit
            ' 
            Me.pictureEdit.Dock = System.Windows.Forms.DockStyle.Left
            Me.pictureEdit.Location = New System.Drawing.Point(5, 0)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.Padding = New System.Windows.Forms.Padding(15)
            Me.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit.Size = New System.Drawing.Size(753, 590)
            Me.pictureEdit.TabIndex = 4
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Location = New System.Drawing.Point(758, 0)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(5, 590)
            Me.splitterControl1.TabIndex = 5
            Me.splitterControl1.TabStop = False
            ' 
            ' transitionManager
            ' 
            transition1.Control = Me.pictureEdit
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5
            transition1.LineWaitingIndicatorProperties.Caption = ""
            transition1.LineWaitingIndicatorProperties.Description = ""
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5
            transition1.RingWaitingIndicatorProperties.Caption = ""
            transition1.RingWaitingIndicatorProperties.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            transition1.RingWaitingIndicatorProperties.Description = ""
            transition1.TransitionType = pushTransition1
            transition1.WaitingIndicatorProperties.Caption = ""
            transition1.WaitingIndicatorProperties.Description = ""
            transition1.WaitingIndicatorProperties.ShowCaption = False
            transition1.WaitingIndicatorProperties.ShowDescription = False
            Me.transitionManager.Transitions.Add(transition1)
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer1)
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement1})
            Me.accordionControl1.Location = New System.Drawing.Point(763, 0)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.accordionControl1.Size = New System.Drawing.Size(293, 590)
            Me.accordionControl1.TabIndex = 6
            Me.accordionControl1.Text = "accordionControl1"
            ' 
            ' accordionContentContainer1
            ' 
            Me.accordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer1.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer1.Controls.Add(Me.tabPane1)
            Me.accordionContentContainer1.Name = "accordionContentContainer1"
            Me.accordionContentContainer1.Padding = New System.Windows.Forms.Padding(14, -1, 14, -1)
            Me.accordionContentContainer1.Size = New System.Drawing.Size(293, 424)
            Me.accordionContentContainer1.TabIndex = 1
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(14, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1, Me.tabNavigationPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(265, 424)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage2
            Me.tabPane1.SelectedPageIndex = 0
            Me.tabPane1.Size = New System.Drawing.Size(265, 424)
            Me.tabPane1.TabIndex = 7
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "tabNavigationPage1"
            Me.tabNavigationPage1.Controls.Add(Me.galleryControl1)
            Me.tabNavigationPage1.Image = (DirectCast(resources.GetObject("tabNavigationPage1.Image"), System.Drawing.Image))
            Me.tabNavigationPage1.ImageUri.Uri = "New"
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(247, 360)
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' 
            ' 
            Me.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent
            galleryItemGroup1.CaptionControlSize = New System.Drawing.Size(154, 0)
            galleryItem1.Caption = "Item17"
            galleryItem1.Checked = True
            galleryItem2.Caption = "Item18"
            galleryItem3.Caption = "Item19"
            galleryItem4.Caption = "Item20"
            galleryItem5.Caption = "Item1"
            galleryItem6.Caption = "Item2"
            galleryItem7.Caption = "Item3"
            galleryItem8.Caption = "Item4"
            galleryItem9.Caption = "Item5"
            galleryItem10.Caption = "Item6"
            'galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10})
            Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(40, 40)
            Me.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Me.galleryControl1.Gallery.ShowGroupCaption = False
            Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
            Me.galleryControl1.Name = "galleryControl1"
            Me.galleryControl1.Size = New System.Drawing.Size(247, 360)
            Me.galleryControl1.TabIndex = 2
            Me.galleryControl1.Text = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
            Me.galleryControlClient1.Size = New System.Drawing.Size(245, 358)
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPage2.Caption = "tabNavigationPage2"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Image = (DirectCast(resources.GetObject("tabNavigationPage2.Image"), System.Drawing.Image))
            Me.tabNavigationPage2.ImageUri.Uri = "New"
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(247, 360)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbWaitingIndicatorType)
            Me.layoutControl1.Controls.Add(Me.btnWaitingIndicator)
            Me.layoutControl1.Controls.Add(Me.cbTransitionType)
            Me.layoutControl1.Controls.Add(Me.ceBackground)
            Me.layoutControl1.Controls.Add(Me.cbEasingFunction)
            Me.layoutControl1.Controls.Add(Me.seStripeCount)
            Me.layoutControl1.Controls.Add(Me.checkUnCover)
            Me.layoutControl1.Controls.Add(Me.cbEasingMode)
            Me.layoutControl1.Controls.Add(Me.seFrameInterval)
            Me.layoutControl1.Controls.Add(Me.checkInward)
            Me.layoutControl1.Controls.Add(Me.cbEffectOptions)
            Me.layoutControl1.Controls.Add(Me.seFrameCount)
            Me.layoutControl1.Controls.Add(Me.checkVertical)
            Me.layoutControl1.Controls.Add(Me.cbShowWaitIndicator)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(666, 408, 983, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(247, 360)
            Me.layoutControl1.TabIndex = 59
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbWaitingIndicatorType
            ' 
            Me.cbWaitingIndicatorType.Location = New System.Drawing.Point(115, 293)
            Me.cbWaitingIndicatorType.Name = "cbWaitingIndicatorType"
            Me.cbWaitingIndicatorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbWaitingIndicatorType.Size = New System.Drawing.Size(132, 20)
            Me.cbWaitingIndicatorType.StyleController = Me.layoutControl1
            Me.cbWaitingIndicatorType.TabIndex = 60
            ' 
            ' btnWaitingIndicator
            ' 
            Me.btnWaitingIndicator.Location = New System.Drawing.Point(0, 325)
            Me.btnWaitingIndicator.Name = "btnWaitingIndicator"
            Me.btnWaitingIndicator.Size = New System.Drawing.Size(247, 32)
            Me.btnWaitingIndicator.StyleController = Me.layoutControl1
            Me.btnWaitingIndicator.TabIndex = 59
            Me.btnWaitingIndicator.Text = "Show waiting indicator"
            ' 
            ' cbTransitionType
            ' 
            Me.cbTransitionType.EditValue = ""
            Me.cbTransitionType.Location = New System.Drawing.Point(115, 102)
            Me.cbTransitionType.Name = "cbTransitionType"
            Me.cbTransitionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTransitionType.Size = New System.Drawing.Size(132, 20)
            Me.cbTransitionType.StyleController = Me.layoutControl1
            Me.cbTransitionType.TabIndex = 56
            ' 
            ' ceBackground
            ' 
            Me.ceBackground.EditValue = System.Drawing.Color.Empty
            Me.ceBackground.Location = New System.Drawing.Point(115, 214)
            Me.ceBackground.Name = "ceBackground"
            Me.ceBackground.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ceBackground.Size = New System.Drawing.Size(132, 20)
            Me.ceBackground.StyleController = Me.layoutControl1
            Me.ceBackground.TabIndex = 49
            ' 
            ' cbEasingFunction
            ' 
            Me.cbEasingFunction.EditValue = ""
            Me.cbEasingFunction.Location = New System.Drawing.Point(115, 46)
            Me.cbEasingFunction.Name = "cbEasingFunction"
            Me.cbEasingFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEasingFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbEasingFunction.Size = New System.Drawing.Size(132, 20)
            Me.cbEasingFunction.StyleController = Me.layoutControl1
            Me.cbEasingFunction.TabIndex = 58
            ' 
            ' seStripeCount
            ' 
            Me.seStripeCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seStripeCount.Location = New System.Drawing.Point(115, 242)
            Me.seStripeCount.Name = "seStripeCount"
            Me.seStripeCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seStripeCount.Properties.IsFloatValue = False
            Me.seStripeCount.Properties.Mask.EditMask = "N00"
            Me.seStripeCount.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seStripeCount.Size = New System.Drawing.Size(132, 20)
            Me.seStripeCount.StyleController = Me.layoutControl1
            Me.seStripeCount.TabIndex = 46
            ' 
            ' checkUnCover
            ' 
            Me.checkUnCover.Location = New System.Drawing.Point(163, 268)
            Me.checkUnCover.Name = "checkUnCover"
            Me.checkUnCover.Properties.Caption = "Uncover"
            Me.checkUnCover.Size = New System.Drawing.Size(82, 19)
            Me.checkUnCover.StyleController = Me.layoutControl1
            Me.checkUnCover.TabIndex = 45
            ' 
            ' cbEasingMode
            ' 
            Me.cbEasingMode.EditValue = ""
            Me.cbEasingMode.Location = New System.Drawing.Point(115, 18)
            Me.cbEasingMode.Name = "cbEasingMode"
            Me.cbEasingMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEasingMode.Size = New System.Drawing.Size(132, 20)
            Me.cbEasingMode.StyleController = Me.layoutControl1
            Me.cbEasingMode.TabIndex = 55
            ' 
            ' seFrameInterval
            ' 
            Me.seFrameInterval.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFrameInterval.Location = New System.Drawing.Point(115, 130)
            Me.seFrameInterval.Name = "seFrameInterval"
            Me.seFrameInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFrameInterval.Properties.IsFloatValue = False
            Me.seFrameInterval.Properties.Mask.EditMask = "N00"
            Me.seFrameInterval.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seFrameInterval.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFrameInterval.Size = New System.Drawing.Size(132, 20)
            Me.seFrameInterval.StyleController = Me.layoutControl1
            Me.seFrameInterval.TabIndex = 48
            ' 
            ' checkInward
            ' 
            Me.checkInward.Location = New System.Drawing.Point(85, 268)
            Me.checkInward.Name = "checkInward"
            Me.checkInward.Properties.Caption = "Inward"
            Me.checkInward.Size = New System.Drawing.Size(74, 19)
            Me.checkInward.StyleController = Me.layoutControl1
            Me.checkInward.TabIndex = 44
            ' 
            ' cbEffectOptions
            ' 
            Me.cbEffectOptions.EditValue = ""
            Me.cbEffectOptions.Location = New System.Drawing.Point(115, 186)
            Me.cbEffectOptions.Name = "cbEffectOptions"
            Me.cbEffectOptions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEffectOptions.Size = New System.Drawing.Size(132, 20)
            Me.cbEffectOptions.StyleController = Me.layoutControl1
            Me.cbEffectOptions.TabIndex = 38
            ' 
            ' seFrameCount
            ' 
            Me.seFrameCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFrameCount.Location = New System.Drawing.Point(115, 158)
            Me.seFrameCount.Name = "seFrameCount"
            Me.seFrameCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFrameCount.Properties.IsFloatValue = False
            Me.seFrameCount.Properties.Mask.EditMask = "N00"
            Me.seFrameCount.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seFrameCount.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFrameCount.Size = New System.Drawing.Size(132, 20)
            Me.seFrameCount.StyleController = Me.layoutControl1
            Me.seFrameCount.TabIndex = 47
            ' 
            ' checkVertical
            ' 
            Me.checkVertical.Location = New System.Drawing.Point(2, 268)
            Me.checkVertical.Name = "checkVertical"
            Me.checkVertical.Properties.Caption = "Vertical"
            Me.checkVertical.Size = New System.Drawing.Size(79, 19)
            Me.checkVertical.StyleController = Me.layoutControl1
            Me.checkVertical.TabIndex = 43
            ' 
            ' cbShowWaitIndicator
            ' 
            Me.cbShowWaitIndicator.EditValue = ""
            Me.cbShowWaitIndicator.Location = New System.Drawing.Point(115, 74)
            Me.cbShowWaitIndicator.Name = "cbShowWaitIndicator"
            Me.cbShowWaitIndicator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbShowWaitIndicator.Size = New System.Drawing.Size(132, 20)
            Me.cbShowWaitIndicator.StyleController = Me.layoutControl1
            Me.cbShowWaitIndicator.TabIndex = 51
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem12, Me.layoutControlItem11, Me.layoutControlItem13, Me.layoutControlItem14, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 14, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(247, 375)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbEasingMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem2.Text = "Easing mode:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.cbEasingFunction
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 28)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem3.Text = "Easing function:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbShowWaitIndicator
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 56)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem1.Text = "Show wait indicator:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbTransitionType
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem4.Text = "Transition type:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seFrameInterval
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 112)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem5.Text = "Frame interval:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seFrameCount
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 140)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem6.Text = "Frame count:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbEffectOptions
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 168)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem7.Text = "Effect options:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceBackground
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 196)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem8.Text = "Background:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.seStripeCount
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem9.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem9.Text = "Stripe count:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.checkVertical
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 252)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(83, 23)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.checkUnCover
            Me.layoutControlItem12.Location = New System.Drawing.Point(161, 252)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(86, 23)
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.checkInward
            Me.layoutControlItem11.Location = New System.Drawing.Point(83, 252)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(78, 23)
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.btnWaitingIndicator
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 303)
            Me.layoutControlItem13.MaxSize = New System.Drawing.Size(0, 48)
            Me.layoutControlItem13.MinSize = New System.Drawing.Size(155, 48)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 8)
            Me.layoutControlItem13.Size = New System.Drawing.Size(247, 48)
            Me.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem13.TextVisible = False
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.cbWaitingIndicatorType
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 275)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
            Me.layoutControlItem14.Size = New System.Drawing.Size(247, 28)
            Me.layoutControlItem14.Text = " Waiting indicator type:"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(112, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 351)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(247, 10)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' accordionControlElement1
            ' 
            Me.accordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement2})
            Me.accordionControlElement1.Expanded = True
            Me.accordionControlElement1.Name = "accordionControlElement1"
            Me.accordionControlElement1.Text = "Presentation properties"
            ' 
            ' accordionControlElement2
            ' 
            Me.accordionControlElement2.ContentContainer = Me.accordionContentContainer1
            Me.accordionControlElement2.Expanded = True
            Me.accordionControlElement2.HeaderVisible = False
            Me.accordionControlElement2.Name = "accordionControlElement2"
            Me.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement2.Text = "Element2"
            ' 
            ' ModuleTransitionManager
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.accordionControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.pictureEdit)
            Me.Name = "ModuleTransitionManager"
            Me.Size = New System.Drawing.Size(1056, 595)
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl1.ResumeLayout(False)
            Me.accordionContentContainer1.ResumeLayout(False)
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.cbWaitingIndicatorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTransitionType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbEasingFunction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seStripeCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkUnCover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbEasingMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seFrameInterval.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkInward.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbEffectOptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seFrameCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkVertical.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbShowWaitIndicator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents transitionManager As Utils.Animation.TransitionManager
        Private splitterControl1 As XtraEditors.SplitterControl
        Private pictureEdit As XtraEditors.PictureEdit
        Private accordionControl1 As XtraBars.Navigation.AccordionControl
        Private tabPane1 As XtraBars.Navigation.TabPane
        Private tabNavigationPage1 As XtraBars.Navigation.TabNavigationPage
        Private WithEvents galleryControl1 As XtraBars.Ribbon.GalleryControl
        Private galleryControlClient1 As XtraBars.Ribbon.GalleryControlClient
        Private tabNavigationPage2 As XtraBars.Navigation.TabNavigationPage
        Private layoutControl1 As XtraLayout.LayoutControl
        Private WithEvents cbTransitionType As XtraEditors.ImageComboBoxEdit
        Private WithEvents ceBackground As XtraEditors.ColorEdit
        Private cbEasingFunction As XtraEditors.ComboBoxEdit
        Private WithEvents seStripeCount As XtraEditors.SpinEdit
        Private WithEvents checkUnCover As XtraEditors.CheckEdit
        Private WithEvents cbEasingMode As XtraEditors.ImageComboBoxEdit
        Private WithEvents seFrameInterval As XtraEditors.SpinEdit
        Private WithEvents checkInward As XtraEditors.CheckEdit
        Private WithEvents cbEffectOptions As XtraEditors.ImageComboBoxEdit
        Private WithEvents seFrameCount As XtraEditors.SpinEdit
        Private WithEvents checkVertical As XtraEditors.CheckEdit
        Private WithEvents cbShowWaitIndicator As XtraEditors.ImageComboBoxEdit
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private layoutControlItem8 As XtraLayout.LayoutControlItem
        Private layoutControlItem9 As XtraLayout.LayoutControlItem
        Private layoutControlItem10 As XtraLayout.LayoutControlItem
        Private layoutControlItem12 As XtraLayout.LayoutControlItem
        Private layoutControlItem11 As XtraLayout.LayoutControlItem
        Private accordionContentContainer1 As XtraBars.Navigation.AccordionContentContainer
        Private accordionControlElement1 As XtraBars.Navigation.AccordionControlElement
        Private accordionControlElement2 As XtraBars.Navigation.AccordionControlElement
        Private WithEvents btnWaitingIndicator As XtraEditors.SimpleButton
        Private layoutControlItem13 As XtraLayout.LayoutControlItem
        Private WithEvents cbWaitingIndicatorType As XtraEditors.ImageComboBoxEdit
        Private layoutControlItem14 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem


    End Class
End Namespace
