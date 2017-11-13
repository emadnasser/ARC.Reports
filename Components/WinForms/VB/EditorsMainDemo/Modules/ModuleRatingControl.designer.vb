Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleRatingControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleRatingControl))
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.popupContainerControlImages = New DevExpress.XtraEditors.PopupContainerControl()
            Me.btnDefault = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnApply = New DevExpress.XtraEditors.SimpleButton()
            Me.picEditChecked = New DevExpress.XtraEditors.PictureEdit()
            Me.picEditHover = New DevExpress.XtraEditors.PictureEdit()
            Me.picEditGlyph = New DevExpress.XtraEditors.PictureEdit()
            Me.lblCaption = New DevExpress.XtraEditors.LabelControl()
            Me.grpCtrlTextSupport = New DevExpress.XtraEditors.GroupControl()
            Me.lblShowText = New DevExpress.XtraEditors.LabelControl()
            Me.chEditHtmlDraw = New DevExpress.XtraEditors.CheckEdit()
            Me.spEditIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.chEditShowText = New DevExpress.XtraEditors.CheckEdit()
            Me.lblIndent = New DevExpress.XtraEditors.LabelControl()
            Me.cmbEditTextLocation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lbl = New DevExpress.XtraEditors.LabelControl()
            Me.grpCtrlSettings = New DevExpress.XtraEditors.GroupControl()
            Me.cmbEditRatingDirection = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblDirection = New DevExpress.XtraEditors.LabelControl()
            Me.popupContainerEditImages = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.lblCustomImages = New DevExpress.XtraEditors.LabelControl()
            Me.cmbEditFillPrecision = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblFillPrecision = New DevExpress.XtraEditors.LabelControl()
            Me.cmbEditRatingOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lblRatingOrientation = New DevExpress.XtraEditors.LabelControl()
            Me.spEditRating = New DevExpress.XtraEditors.SpinEdit()
            Me.lblRating = New DevExpress.XtraEditors.LabelControl()
            Me.spEditItemCount = New DevExpress.XtraEditors.SpinEdit()
            Me.lblItemCount = New DevExpress.XtraEditors.LabelControl()
            Me.grpCtlSample = New DevExpress.XtraEditors.GroupControl()
            Me.ratingControlSample = New DevExpress.XtraEditors.RatingControl()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.popupContainerControlImages, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControlImages.SuspendLayout()
            CType(Me.picEditChecked.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picEditHover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picEditGlyph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpCtrlTextSupport, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpCtrlTextSupport.SuspendLayout()
            CType(Me.chEditHtmlDraw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spEditIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chEditShowText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbEditTextLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpCtrlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpCtrlSettings.SuspendLayout()
            CType(Me.cmbEditRatingDirection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupContainerEditImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbEditFillPrecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbEditRatingOrientation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spEditRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spEditItemCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpCtlSample, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpCtlSample.SuspendLayout()
            CType(Me.ratingControlSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(1024, 687)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.popupContainerControlImages)
            Me.xtraTabPage1.Controls.Add(Me.grpCtrlTextSupport)
            Me.xtraTabPage1.Controls.Add(Me.grpCtrlSettings)
            Me.xtraTabPage1.Controls.Add(Me.grpCtlSample)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1018, 681)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            '
            'popupContainerControlImages
            '
            Me.popupContainerControlImages.Controls.Add(Me.btnDefault)
            Me.popupContainerControlImages.Controls.Add(Me.btnCancel)
            Me.popupContainerControlImages.Controls.Add(Me.btnApply)
            Me.popupContainerControlImages.Controls.Add(Me.picEditChecked)
            Me.popupContainerControlImages.Controls.Add(Me.picEditHover)
            Me.popupContainerControlImages.Controls.Add(Me.picEditGlyph)
            Me.popupContainerControlImages.Controls.Add(Me.lblCaption)
            Me.popupContainerControlImages.Location = New System.Drawing.Point(38, 550)
            Me.popupContainerControlImages.Name = "popupContainerControlImages"
            Me.popupContainerControlImages.Size = New System.Drawing.Size(238, 119)
            Me.popupContainerControlImages.TabIndex = 3
            '
            'btnDefault
            '
            Me.btnDefault.Location = New System.Drawing.Point(93, 92)
            Me.btnDefault.Name = "btnDefault"
            Me.btnDefault.Size = New System.Drawing.Size(52, 19)
            Me.btnDefault.TabIndex = 6
            Me.btnDefault.Text = "Default"
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(151, 92)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(52, 19)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            '
            'btnApply
            '
            Me.btnApply.Location = New System.Drawing.Point(35, 92)
            Me.btnApply.Name = "btnApply"
            Me.btnApply.Size = New System.Drawing.Size(52, 19)
            Me.btnApply.TabIndex = 4
            Me.btnApply.Text = "Apply"
            '
            'picEditChecked
            '
            Me.picEditChecked.EditValue = CType(resources.GetObject("picEditChecked.EditValue"), Object)
            Me.picEditChecked.Location = New System.Drawing.Point(140, 56)
            Me.picEditChecked.Name = "picEditChecked"
            Me.picEditChecked.Properties.AllowFocused = False
            Me.picEditChecked.Size = New System.Drawing.Size(30, 30)
            Me.picEditChecked.TabIndex = 3
            '
            'picEditHover
            '
            Me.picEditHover.EditValue = CType(resources.GetObject("picEditHover.EditValue"), Object)
            Me.picEditHover.Location = New System.Drawing.Point(104, 56)
            Me.picEditHover.Name = "picEditHover"
            Me.picEditHover.Properties.AllowFocused = False
            Me.picEditHover.Size = New System.Drawing.Size(30, 30)
            Me.picEditHover.TabIndex = 2
            '
            'picEditGlyph
            '
            Me.picEditGlyph.EditValue = CType(resources.GetObject("picEditGlyph.EditValue"), Object)
            Me.picEditGlyph.Location = New System.Drawing.Point(68, 56)
            Me.picEditGlyph.Name = "picEditGlyph"
            Me.picEditGlyph.Properties.AllowFocused = False
            Me.picEditGlyph.Size = New System.Drawing.Size(30, 30)
            Me.picEditGlyph.TabIndex = 1
            '
            'lblCaption
            '
            Me.lblCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblCaption.Location = New System.Drawing.Point(10, 8)
            Me.lblCaption.Name = "lblCaption"
            Me.lblCaption.Size = New System.Drawing.Size(218, 42)
            Me.lblCaption.TabIndex = 0
            Me.lblCaption.Text = "Click the 'Apply' button to choose the custom image set or the 'Default' button t" & _
        "o reset rating images."
            '
            'grpCtrlTextSupport
            '
            Me.grpCtrlTextSupport.Controls.Add(Me.lblShowText)
            Me.grpCtrlTextSupport.Controls.Add(Me.chEditHtmlDraw)
            Me.grpCtrlTextSupport.Controls.Add(Me.spEditIndent)
            Me.grpCtrlTextSupport.Controls.Add(Me.chEditShowText)
            Me.grpCtrlTextSupport.Controls.Add(Me.lblIndent)
            Me.grpCtrlTextSupport.Controls.Add(Me.cmbEditTextLocation)
            Me.grpCtrlTextSupport.Controls.Add(Me.lbl)
            Me.grpCtrlTextSupport.Location = New System.Drawing.Point(560, 390)
            Me.grpCtrlTextSupport.Name = "grpCtrlTextSupport"
            Me.grpCtrlTextSupport.Size = New System.Drawing.Size(277, 170)
            Me.grpCtrlTextSupport.TabIndex = 2
            Me.grpCtrlTextSupport.Text = "Text support"
            '
            'lblShowText
            '
            Me.lblShowText.Location = New System.Drawing.Point(24, 44)
            Me.lblShowText.Name = "lblShowText"
            Me.lblShowText.Size = New System.Drawing.Size(53, 13)
            Me.lblShowText.TabIndex = 6
            Me.lblShowText.Text = "Show text:"
            '
            'chEditHtmlDraw
            '
            Me.chEditHtmlDraw.Enabled = False
            Me.chEditHtmlDraw.Location = New System.Drawing.Point(24, 128)
            Me.chEditHtmlDraw.Name = "chEditHtmlDraw"
            Me.chEditHtmlDraw.Properties.AutoWidth = True
            Me.chEditHtmlDraw.Properties.Caption = "Allow Html Draw"
            Me.chEditHtmlDraw.Size = New System.Drawing.Size(99, 19)
            Me.chEditHtmlDraw.TabIndex = 5
            '
            'spEditIndent
            '
            Me.spEditIndent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spEditIndent.Enabled = False
            Me.spEditIndent.Location = New System.Drawing.Point(149, 98)
            Me.spEditIndent.Name = "spEditIndent"
            Me.spEditIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spEditIndent.Properties.IsFloatValue = False
            Me.spEditIndent.Properties.Mask.EditMask = "N00"
            Me.spEditIndent.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spEditIndent.Size = New System.Drawing.Size(100, 20)
            Me.spEditIndent.TabIndex = 4
            '
            'chEditShowText
            '
            Me.chEditShowText.Location = New System.Drawing.Point(149, 44)
            Me.chEditShowText.Name = "chEditShowText"
            Me.chEditShowText.Properties.AutoWidth = True
            Me.chEditShowText.Properties.Caption = ""
            Me.chEditShowText.Size = New System.Drawing.Size(19, 19)
            Me.chEditShowText.TabIndex = 0
            '
            'lblIndent
            '
            Me.lblIndent.Location = New System.Drawing.Point(24, 101)
            Me.lblIndent.Name = "lblIndent"
            Me.lblIndent.Size = New System.Drawing.Size(103, 13)
            Me.lblIndent.TabIndex = 3
            Me.lblIndent.Text = "Text to rating indent:"
            '
            'cmbEditTextLocation
            '
            Me.cmbEditTextLocation.EditValue = "Default"
            Me.cmbEditTextLocation.Enabled = False
            Me.cmbEditTextLocation.Location = New System.Drawing.Point(149, 68)
            Me.cmbEditTextLocation.Name = "cmbEditTextLocation"
            Me.cmbEditTextLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbEditTextLocation.Properties.Items.AddRange(New Object() {"Bottom", "Default", "Left", "None", "Right", "Top"})
            Me.cmbEditTextLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbEditTextLocation.Size = New System.Drawing.Size(100, 20)
            Me.cmbEditTextLocation.TabIndex = 2
            '
            'lbl
            '
            Me.lbl.Location = New System.Drawing.Point(24, 71)
            Me.lbl.Name = "lbl"
            Me.lbl.Size = New System.Drawing.Size(66, 13)
            Me.lbl.TabIndex = 1
            Me.lbl.Text = "Text location:"
            '
            'grpCtrlSettings
            '
            Me.grpCtrlSettings.Controls.Add(Me.cmbEditRatingDirection)
            Me.grpCtrlSettings.Controls.Add(Me.lblDirection)
            Me.grpCtrlSettings.Controls.Add(Me.popupContainerEditImages)
            Me.grpCtrlSettings.Controls.Add(Me.lblCustomImages)
            Me.grpCtrlSettings.Controls.Add(Me.cmbEditFillPrecision)
            Me.grpCtrlSettings.Controls.Add(Me.lblFillPrecision)
            Me.grpCtrlSettings.Controls.Add(Me.cmbEditRatingOrientation)
            Me.grpCtrlSettings.Controls.Add(Me.lblRatingOrientation)
            Me.grpCtrlSettings.Controls.Add(Me.spEditRating)
            Me.grpCtrlSettings.Controls.Add(Me.lblRating)
            Me.grpCtrlSettings.Controls.Add(Me.spEditItemCount)
            Me.grpCtrlSettings.Controls.Add(Me.lblItemCount)
            Me.grpCtrlSettings.Location = New System.Drawing.Point(560, 131)
            Me.grpCtrlSettings.Name = "grpCtrlSettings"
            Me.grpCtrlSettings.Size = New System.Drawing.Size(277, 242)
            Me.grpCtrlSettings.TabIndex = 1
            Me.grpCtrlSettings.Text = "Settings"
            '
            'cmbEditRatingDirection
            '
            Me.cmbEditRatingDirection.EditValue = "Standard"
            Me.cmbEditRatingDirection.Location = New System.Drawing.Point(149, 165)
            Me.cmbEditRatingDirection.Name = "cmbEditRatingDirection"
            Me.cmbEditRatingDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbEditRatingDirection.Properties.Items.AddRange(New Object() {"Standard", "Reversed"})
            Me.cmbEditRatingDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbEditRatingDirection.Size = New System.Drawing.Size(100, 20)
            Me.cmbEditRatingDirection.TabIndex = 11
            '
            'lblDirection
            '
            Me.lblDirection.Location = New System.Drawing.Point(24, 168)
            Me.lblDirection.Name = "lblDirection"
            Me.lblDirection.Size = New System.Drawing.Size(79, 13)
            Me.lblDirection.TabIndex = 10
            Me.lblDirection.Text = "Rating direction:"
            '
            'popupContainerEditImages
            '
            Me.popupContainerEditImages.EditValue = "Choose images..."
            Me.popupContainerEditImages.Location = New System.Drawing.Point(149, 195)
            Me.popupContainerEditImages.Name = "popupContainerEditImages"
            Me.popupContainerEditImages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEditImages.Properties.PopupControl = Me.popupContainerControlImages
            Me.popupContainerEditImages.Properties.PopupSizeable = False
            Me.popupContainerEditImages.Properties.ShowPopupCloseButton = False
            Me.popupContainerEditImages.Size = New System.Drawing.Size(100, 20)
            Me.popupContainerEditImages.TabIndex = 9
            '
            'lblCustomImages
            '
            Me.lblCustomImages.Location = New System.Drawing.Point(24, 196)
            Me.lblCustomImages.Name = "lblCustomImages"
            Me.lblCustomImages.Size = New System.Drawing.Size(76, 13)
            Me.lblCustomImages.TabIndex = 8
            Me.lblCustomImages.Text = "Custom images:"
            '
            'cmbEditFillPrecision
            '
            Me.cmbEditFillPrecision.EditValue = "Full"
            Me.cmbEditFillPrecision.Location = New System.Drawing.Point(149, 135)
            Me.cmbEditFillPrecision.Name = "cmbEditFillPrecision"
            Me.cmbEditFillPrecision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbEditFillPrecision.Properties.Items.AddRange(New Object() {"Full", "Half", "Exact"})
            Me.cmbEditFillPrecision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbEditFillPrecision.Size = New System.Drawing.Size(100, 20)
            Me.cmbEditFillPrecision.TabIndex = 7
            '
            'lblFillPrecision
            '
            Me.lblFillPrecision.Location = New System.Drawing.Point(24, 138)
            Me.lblFillPrecision.Name = "lblFillPrecision"
            Me.lblFillPrecision.Size = New System.Drawing.Size(61, 13)
            Me.lblFillPrecision.TabIndex = 6
            Me.lblFillPrecision.Text = "Fill precision:"
            '
            'cmbEditRatingOrientation
            '
            Me.cmbEditRatingOrientation.EditValue = "Horizontal"
            Me.cmbEditRatingOrientation.Location = New System.Drawing.Point(149, 105)
            Me.cmbEditRatingOrientation.Name = "cmbEditRatingOrientation"
            Me.cmbEditRatingOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbEditRatingOrientation.Properties.Items.AddRange(New Object() {"Horizontal", "Vertical"})
            Me.cmbEditRatingOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbEditRatingOrientation.Size = New System.Drawing.Size(100, 20)
            Me.cmbEditRatingOrientation.TabIndex = 5
            '
            'lblRatingOrientation
            '
            Me.lblRatingOrientation.Location = New System.Drawing.Point(24, 108)
            Me.lblRatingOrientation.Name = "lblRatingOrientation"
            Me.lblRatingOrientation.Size = New System.Drawing.Size(90, 13)
            Me.lblRatingOrientation.TabIndex = 4
            Me.lblRatingOrientation.Text = "Rating orientation:"
            '
            'spEditRating
            '
            Me.spEditRating.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spEditRating.Location = New System.Drawing.Point(149, 45)
            Me.spEditRating.Name = "spEditRating"
            Me.spEditRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spEditRating.Properties.IsFloatValue = False
            Me.spEditRating.Properties.Mask.EditMask = "N00"
            Me.spEditRating.Size = New System.Drawing.Size(100, 20)
            Me.spEditRating.TabIndex = 3
            '
            'lblRating
            '
            Me.lblRating.Location = New System.Drawing.Point(24, 48)
            Me.lblRating.Name = "lblRating"
            Me.lblRating.Size = New System.Drawing.Size(35, 13)
            Me.lblRating.TabIndex = 2
            Me.lblRating.Text = "Rating:"
            '
            'spEditItemCount
            '
            Me.spEditItemCount.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spEditItemCount.Location = New System.Drawing.Point(149, 75)
            Me.spEditItemCount.Name = "spEditItemCount"
            Me.spEditItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spEditItemCount.Properties.IsFloatValue = False
            Me.spEditItemCount.Properties.Mask.EditMask = "N00"
            Me.spEditItemCount.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.spEditItemCount.Properties.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spEditItemCount.Size = New System.Drawing.Size(100, 20)
            Me.spEditItemCount.TabIndex = 1
            '
            'lblItemCount
            '
            Me.lblItemCount.Location = New System.Drawing.Point(24, 78)
            Me.lblItemCount.Name = "lblItemCount"
            Me.lblItemCount.Size = New System.Drawing.Size(56, 13)
            Me.lblItemCount.TabIndex = 0
            Me.lblItemCount.Text = "Item count:"
            '
            'grpCtlSample
            '
            Me.grpCtlSample.Controls.Add(Me.ratingControlSample)
            Me.grpCtlSample.Location = New System.Drawing.Point(140, 131)
            Me.grpCtlSample.Name = "grpCtlSample"
            Me.grpCtlSample.Size = New System.Drawing.Size(400, 429)
            Me.grpCtlSample.TabIndex = 0
            Me.grpCtlSample.Text = "Sample"
            '
            'ratingControlSample
            '
            Me.ratingControlSample.Location = New System.Drawing.Point(161, 213)
            Me.ratingControlSample.MaximumSize = New System.Drawing.Size(400, 0)
            Me.ratingControlSample.Name = "ratingControlSample"
            Me.ratingControlSample.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
            Me.ratingControlSample.Properties.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
            Me.ratingControlSample.Rating = New Decimal(New Integer() {0, 0, 0, 0})
            Me.ratingControlSample.Size = New System.Drawing.Size(87, 16)
            Me.ratingControlSample.TabIndex = 0
            Me.ratingControlSample.Text = "ratingControl1"
            '
            'ModuleRatingControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleRatingControl"
            Me.Size = New System.Drawing.Size(1029, 692)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.popupContainerControlImages, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControlImages.ResumeLayout(False)
            CType(Me.picEditChecked.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picEditHover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picEditGlyph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpCtrlTextSupport, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpCtrlTextSupport.ResumeLayout(False)
            Me.grpCtrlTextSupport.PerformLayout()
            CType(Me.chEditHtmlDraw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spEditIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chEditShowText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbEditTextLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpCtrlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpCtrlSettings.ResumeLayout(False)
            Me.grpCtrlSettings.PerformLayout()
            CType(Me.cmbEditRatingDirection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupContainerEditImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbEditFillPrecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbEditRatingOrientation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spEditRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spEditItemCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpCtlSample, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpCtlSample.ResumeLayout(False)
            Me.grpCtlSample.PerformLayout()
            CType(Me.ratingControlSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private xtraTabControl1 As XtraTab.XtraTabControl
        Private grpCtlSample As GroupControl
        Private xtraTabPage1 As XtraTab.XtraTabPage
        Private WithEvents ratingControlSample As RatingControl
        Private grpCtrlSettings As GroupControl
        Private lblItemCount As LabelControl
        Private WithEvents spEditItemCount As SpinEdit
        Private lblRating As LabelControl
        Private WithEvents spEditRating As SpinEdit
        Private WithEvents cmbEditRatingOrientation As ComboBoxEdit
        Private lblRatingOrientation As LabelControl
        Private WithEvents cmbEditFillPrecision As ComboBoxEdit
        Private lblFillPrecision As LabelControl
        Private grpCtrlTextSupport As GroupControl
        Private WithEvents chEditShowText As CheckEdit
        Private WithEvents cmbEditTextLocation As ComboBoxEdit
		Private lbl As LabelControl
		Private WithEvents spEditIndent As SpinEdit
		Private lblIndent As LabelControl
		Private WithEvents chEditHtmlDraw As CheckEdit
		Private lblCustomImages As LabelControl
		Private popupContainerEditImages As PopupContainerEdit
		Private popupContainerControlImages As PopupContainerControl
		Private lblCaption As LabelControl
		Private WithEvents btnCancel As SimpleButton
		Private WithEvents btnApply As SimpleButton
		Private picEditChecked As PictureEdit
		Private picEditHover As PictureEdit
		Private picEditGlyph As PictureEdit
		Private WithEvents cmbEditRatingDirection As ComboBoxEdit
		Private lblDirection As LabelControl
        Private lblShowText As LabelControl
        Private WithEvents btnDefault As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace
