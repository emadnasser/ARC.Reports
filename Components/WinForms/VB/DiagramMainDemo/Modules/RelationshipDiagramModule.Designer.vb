Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class RelationshipDiagramModule
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
            Me.components = New System.ComponentModel.Container()
            Me.diagramDataBindingController1 = New DevExpress.XtraDiagram.DiagramDataBindingController(Me.components)
            Me.relationshipInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelPhoneNumber = New DevExpress.XtraEditors.LabelControl()
            Me.labelBirthDate = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.labelName = New DevExpress.XtraEditors.LabelControl()
            Me.labelAddressLine = New DevExpress.XtraEditors.LabelControl()
            Me.labelFriends = New DevExpress.XtraEditors.LabelControl()
            Me.labelKnowEachOther = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.personInfoGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutPhoneNumber = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.selectPersonLabel = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape4 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramConnector3 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.diagramConnector4 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramImage1 = New DevExpress.XtraDiagram.DiagramImage()
            Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.diagramConnector2 = New DevExpress.XtraDiagram.DiagramConnector()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPanel_Renamed.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.diagramDataBindingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.diagramDataBindingController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.relationshipInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.personInfoGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutPhoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.selectPersonLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Location = New System.Drawing.Point(579, 0)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.RegularSize = New System.Drawing.Size(408, 505)
            Me.navigationPane1.Size = New System.Drawing.Size(408, 505)
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel_Renamed.Controls.Add(Me.layoutControl1)
            Me.optionsPanel_Renamed.Size = New System.Drawing.Size(358, 445)
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(579, 505)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramShape1, Me.diagramShape3, Me.diagramShape4, Me.diagramConnector3, Me.diagramConnector4})
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsCircularLayout.Order = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise
            Me.diagramControl.OptionsConnector.LineJumpPlacement = DevExpress.Diagram.Core.LineJumpPlacement.None
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(1000F, 1000F)
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.ShowPageBreaks = False
            Me.diagramControl.OptionsView.ShowRulers = False
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(573, 331)
            ' 
            ' diagramDataBindingController1
            ' 
            Me.diagramDataBindingController1.ClearExistingItems = False
            Me.diagramDataBindingController1.ConnectorFromMember = "Source"
            Me.diagramDataBindingController1.ConnectorsSource = Me.relationshipInfoBindingSource
            Me.diagramDataBindingController1.ConnectorToMember = "Target"
            Me.diagramDataBindingController1.DataSource = Me.employeeBindingSource
            Me.diagramDataBindingController1.Diagram = Me.diagramControl
            Me.diagramDataBindingController1.KeyMember = "Id"
            Me.diagramDataBindingController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.Circular
            ' 
            ' 
            ' 
            Me.diagramDataBindingController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramContainer1, Me.diagramConnector1, Me.diagramConnector2})
            Me.diagramDataBindingController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
            Me.diagramDataBindingController1.TemplateDiagram.Name = ""
            Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes", "TemplateDesigner"})
            Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.ShowQuickShapes = False
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PageSize = New System.Drawing.SizeF(162F, 258F)
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramDataBindingController1.TemplateDiagram.TabIndex = 0
            ' 
            ' relationshipInfoBindingSource
            ' 
            Me.relationshipInfoBindingSource.DataSource = GetType(DevExpress.Diagram.Demos.RelationshipInfo)
            ' 
            ' employeeBindingSource
            ' 
            Me.employeeBindingSource.DataSource = GetType(DevExpress.Diagram.Demos.Employee)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.labelPhoneNumber)
            Me.layoutControl1.Controls.Add(Me.labelBirthDate)
            Me.layoutControl1.Controls.Add(Me.pictureEdit)
            Me.layoutControl1.Controls.Add(Me.labelName)
            Me.layoutControl1.Controls.Add(Me.labelAddressLine)
            Me.layoutControl1.Controls.Add(Me.labelFriends)
            Me.layoutControl1.Controls.Add(Me.labelKnowEachOther)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(554, 343, 650, 555)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(358, 445)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelPhoneNumber
            ' 
            Me.labelPhoneNumber.Appearance.Options.UseTextOptions = True
            Me.labelPhoneNumber.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelPhoneNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelPhoneNumber.Location = New System.Drawing.Point(220, 63)
            Me.labelPhoneNumber.Name = "labelPhoneNumber"
            Me.labelPhoneNumber.Size = New System.Drawing.Size(126, 13)
            Me.labelPhoneNumber.StyleController = Me.layoutControl1
            Me.labelPhoneNumber.TabIndex = 7
            ' 
            ' labelBirthDate
            ' 
            Me.labelBirthDate.Appearance.Options.UseTextOptions = True
            Me.labelBirthDate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelBirthDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelBirthDate.Location = New System.Drawing.Point(220, 46)
            Me.labelBirthDate.Name = "labelBirthDate"
            Me.labelBirthDate.Size = New System.Drawing.Size(126, 13)
            Me.labelBirthDate.StyleController = Me.layoutControl1
            Me.labelBirthDate.TabIndex = 6
            ' 
            ' pictureEdit
            ' 
            Me.pictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.pictureEdit.Location = New System.Drawing.Point(12, 29)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit.Properties.ReadOnly = True
            Me.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit.Properties.ZoomAccelerationFactor = 1R
            Me.pictureEdit.Size = New System.Drawing.Size(116, 146)
            Me.pictureEdit.StyleController = Me.layoutControl1
            Me.pictureEdit.TabIndex = 5
            ' 
            ' labelName
            ' 
            Me.labelName.Appearance.Options.UseTextOptions = True
            Me.labelName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelName.Location = New System.Drawing.Point(220, 29)
            Me.labelName.Name = "labelName"
            Me.labelName.Size = New System.Drawing.Size(126, 13)
            Me.labelName.StyleController = Me.layoutControl1
            Me.labelName.TabIndex = 4
            Me.labelName.Text = " "
            ' 
            ' labelAddressLine
            ' 
            Me.labelAddressLine.Appearance.Options.UseTextOptions = True
            Me.labelAddressLine.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelAddressLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelAddressLine.Location = New System.Drawing.Point(220, 80)
            Me.labelAddressLine.Name = "labelAddressLine"
            Me.labelAddressLine.Size = New System.Drawing.Size(126, 13)
            Me.labelAddressLine.StyleController = Me.layoutControl1
            Me.labelAddressLine.TabIndex = 7
            ' 
            ' labelFriends
            ' 
            Me.labelFriends.Appearance.Options.UseTextOptions = True
            Me.labelFriends.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelFriends.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelFriends.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelFriends.Location = New System.Drawing.Point(12, 195)
            Me.labelFriends.Name = "labelFriends"
            Me.labelFriends.Size = New System.Drawing.Size(162, 238)
            Me.labelFriends.StyleController = Me.layoutControl1
            Me.labelFriends.TabIndex = 7
            ' 
            ' labelKnowEachOther
            ' 
            Me.labelKnowEachOther.Appearance.Options.UseTextOptions = True
            Me.labelKnowEachOther.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.labelKnowEachOther.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelKnowEachOther.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelKnowEachOther.Location = New System.Drawing.Point(178, 195)
            Me.labelKnowEachOther.Name = "labelKnowEachOther"
            Me.labelKnowEachOther.Size = New System.Drawing.Size(168, 238)
            Me.labelKnowEachOther.StyleController = Me.layoutControl1
            Me.labelKnowEachOther.TabIndex = 7
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.personInfoGroup, Me.selectPersonLabel})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(358, 445)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' personInfoGroup
            ' 
            Me.personInfoGroup.GroupBordersVisible = False
            Me.personInfoGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlGroup2})
            Me.personInfoGroup.Location = New System.Drawing.Point(0, 17)
            Me.personInfoGroup.Name = "personInfoGroup"
            Me.personInfoGroup.Size = New System.Drawing.Size(338, 408)
            Me.personInfoGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.pictureEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(120, 150)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(120, 150)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(120, 150)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutControlItem6.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem6.Control = Me.labelFriends
            Me.layoutControlItem6.CustomizationFormText = "Phone Number:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 150)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(92, 17)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(166, 258)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.Text = "Friends"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(201, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutControlItem7.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem7.Control = Me.labelKnowEachOther
            Me.layoutControlItem7.CustomizationFormText = "Phone Number:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(166, 150)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(92, 17)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(172, 258)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.Text = "Known Persons"
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(201, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutPhoneNumber, Me.layoutControlItem5, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(120, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
            Me.layoutControlGroup2.Size = New System.Drawing.Size(218, 150)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.layoutControlItem3.Control = Me.labelBirthDate
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(218, 17)
            Me.layoutControlItem3.Text = "Birth Date:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' layoutPhoneNumber
            ' 
            Me.layoutPhoneNumber.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutPhoneNumber.AppearanceItemCaption.Options.UseFont = True
            Me.layoutPhoneNumber.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutPhoneNumber.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.layoutPhoneNumber.Control = Me.labelPhoneNumber
            Me.layoutPhoneNumber.Location = New System.Drawing.Point(0, 34)
            Me.layoutPhoneNumber.Name = "layoutControlItem4"
            Me.layoutPhoneNumber.Size = New System.Drawing.Size(218, 17)
            Me.layoutPhoneNumber.Text = "Phone Number:"
            Me.layoutPhoneNumber.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.layoutControlItem5.Control = Me.labelAddressLine
            Me.layoutControlItem5.CustomizationFormText = "Phone Number:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 51)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(218, 99)
            Me.layoutControlItem5.Text = "Adress:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.layoutControlItem1.Control = Me.labelName
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(218, 17)
            Me.layoutControlItem1.Text = "Name:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' selectPersonLabel
            ' 
            Me.selectPersonLabel.AllowHotTrack = False
            Me.selectPersonLabel.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.selectPersonLabel.AppearanceItemCaption.Options.UseFont = True
            Me.selectPersonLabel.AppearanceItemCaption.Options.UseTextOptions = True
            Me.selectPersonLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.selectPersonLabel.Location = New System.Drawing.Point(0, 0)
            Me.selectPersonLabel.Name = "selectPersonLabel"
            Me.selectPersonLabel.Size = New System.Drawing.Size(338, 17)
            Me.selectPersonLabel.Text = "Select a person to see relationships"
            Me.selectPersonLabel.TextSize = New System.Drawing.Size(201, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.labelPhoneNumber
            Me.layoutControlItem4.Location = New System.Drawing.Point(126, 34)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(144, 389)
            Me.layoutControlItem4.Text = "Phone Number:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(74, 13)
            ' 
            ' diagramShape1
            ' 
            Me.diagramShape1.AffectedByLayoutAlgorithms = False
            Me.diagramShape1.Appearance.BorderSize = 0
            Me.diagramShape1.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape1.CanMove = False
            Me.diagramShape1.CanSelect = False
            Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(810F, 30F)
            Me.diagramShape1.Size = New System.Drawing.SizeF(160F, 80F)
            ' 
            ' diagramShape3
            ' 
            Me.diagramShape3.AffectedByLayoutAlgorithms = False
            Me.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.diagramShape3.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape3.CanMove = False
            Me.diagramShape3.CanSelect = False
            Me.diagramShape3.Content = "Know each other"
            Me.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_5
            Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(810F, 30F)
            Me.diagramShape3.Size = New System.Drawing.SizeF(160F, 30F)
            ' 
            ' diagramShape4
            ' 
            Me.diagramShape4.AffectedByLayoutAlgorithms = False
            Me.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.diagramShape4.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.diagramShape4.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape4.CanMove = False
            Me.diagramShape4.CanSelect = False
            Me.diagramShape4.Content = "Friends with"
            Me.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_5
            Me.diagramShape4.Position = New DevExpress.Utils.PointFloat(810F, 70F)
            Me.diagramShape4.Size = New System.Drawing.SizeF(160F, 30F)
            ' 
            ' diagramConnector3
            ' 
            Me.diagramConnector3.AffectedByLayoutAlgorithms = False
            Me.diagramConnector3.Appearance.BorderDashPattern = New DevExpress.Diagram.Core.DiagramDoubleCollection(New Double() { 4R, 8R})
            Me.diagramConnector3.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector3.BeginPoint = New DevExpress.Utils.PointFloat(820F, 100F)
            Me.diagramConnector3.CanMove = False
            Me.diagramConnector3.CanSelect = False
            Me.diagramConnector3.EndArrow = Nothing
            Me.diagramConnector3.EndPoint = New DevExpress.Utils.PointFloat(960F, 100F)
            Me.diagramConnector3.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
            Me.diagramConnector3.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense2
            ' 
            ' diagramConnector4
            ' 
            Me.diagramConnector4.AffectedByLayoutAlgorithms = False
            Me.diagramConnector4.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector4.BeginPoint = New DevExpress.Utils.PointFloat(820F, 60F)
            Me.diagramConnector4.CanMove = False
            Me.diagramConnector4.CanSelect = False
            Me.diagramConnector4.EndArrow = Nothing
            Me.diagramConnector4.EndPoint = New DevExpress.Utils.PointFloat(960F, 60F)
            Me.diagramConnector4.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
            Me.diagramConnector4.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense3
            ' 
            ' diagramContainer1
            ' 
            Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanCopy = False
            Me.diagramContainer1.CanDelete = False
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramImage1, Me.diagramShape2})
            Me.diagramContainer1.ItemsCanAttachConnectorBeginPoint = False
            Me.diagramContainer1.ItemsCanAttachConnectorEndPoint = False
            Me.diagramContainer1.ItemsCanChangeParent = False
            Me.diagramContainer1.ItemsCanCopyWithoutParent = False
            Me.diagramContainer1.ItemsCanDeleteWithoutParent = False
            Me.diagramContainer1.ItemsCanEdit = False
            Me.diagramContainer1.ItemsCanMove = False
            Me.diagramContainer1.ItemsCanResize = False
            Me.diagramContainer1.ItemsCanRotate = False
            Me.diagramContainer1.ItemsCanSelect = False
            Me.diagramContainer1.ItemsCanSnapToOtherItems = False
            Me.diagramContainer1.ItemsCanSnapToThisItem = False
            Me.diagramContainer1.Padding = New System.Windows.Forms.Padding(12)
            Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(24F, 15F)
            Me.diagramContainer1.Size = New System.Drawing.SizeF(114F, 171F)
            Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramImage1
            ' 
            Me.diagramImage1.Anchors = (CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top) Or DevExpress.Diagram.Core.Sides.Right), DevExpress.Diagram.Core.Sides))
            Me.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.diagramImage1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Image", "ImageData"))
            Me.diagramImage1.CanMove = False
            Me.diagramImage1.CanSelect = False
            Me.diagramImage1.Size = New System.Drawing.SizeF(90F, 120F)
            Me.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.UniformToFill
            ' 
            ' diagramShape2
            ' 
            Me.diagramShape2.Anchors = (CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top) Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom), DevExpress.Diagram.Core.Sides))
            Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.diagramShape2.Appearance.BorderSize = 0
            Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "FullName"))
            Me.diagramShape2.CanMove = False
            Me.diagramShape2.CanSelect = False
            Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(0F, 132F)
            Me.diagramShape2.Size = New System.Drawing.SizeF(90F, 15F)
            Me.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramConnector1
            ' 
            Me.diagramConnector1.Appearance.BorderDashPattern = New DevExpress.Diagram.Core.DiagramDoubleCollection(New Double() { 4R, 8R})
            Me.diagramConnector1.Appearance.BorderSize = 2
            Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(26F, 202F)
            Me.diagramConnector1.CanCopy = False
            Me.diagramConnector1.CanDelete = False
            Me.diagramConnector1.CanEdit = False
            Me.diagramConnector1.EndArrow = Nothing
            Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(138F, 202F)
            Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
            Me.diagramConnector1.TemplateName = "KnowEachOther"
            Me.diagramConnector1.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Subtle2
            Me.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight
            ' 
            ' diagramConnector2
            ' 
            Me.diagramConnector2.Appearance.BorderSize = 2
            Me.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector2.BeginPoint = New DevExpress.Utils.PointFloat(26F, 234F)
            Me.diagramConnector2.CanCopy = False
            Me.diagramConnector2.CanDelete = False
            Me.diagramConnector2.CanEdit = False
            Me.diagramConnector2.EndArrow = Nothing
            Me.diagramConnector2.EndPoint = New DevExpress.Utils.PointFloat(138F, 234F)
            Me.diagramConnector2.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
            Me.diagramConnector2.TemplateName = "Friends"
            Me.diagramConnector2.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Subtle3
            Me.diagramConnector2.Type = DevExpress.Diagram.Core.ConnectorType.Straight
            ' 
            ' RelationshipDiagramModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "RelationshipDiagramModule"
            Me.ShowOptionsPanel = True
            Me.Size = New System.Drawing.Size(987, 505)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPanel_Renamed.ResumeLayout(False)
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.diagramDataBindingController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.diagramDataBindingController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.relationshipInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.employeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.personInfoGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutPhoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.selectPersonLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents diagramDataBindingController1 As DiagramDataBindingController
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private labelName As XtraEditors.LabelControl
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private pictureEdit As XtraEditors.PictureEdit
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private labelPhoneNumber As XtraEditors.LabelControl
        Private labelBirthDate As XtraEditors.LabelControl
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutPhoneNumber As XtraLayout.LayoutControlItem
        Private labelAddressLine As XtraEditors.LabelControl
        Private labelFriends As XtraEditors.LabelControl
        Private labelKnowEachOther As XtraEditors.LabelControl
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private personInfoGroup As XtraLayout.LayoutControlGroup
        Private selectPersonLabel As XtraLayout.SimpleLabelItem
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private relationshipInfoBindingSource As System.Windows.Forms.BindingSource
        Private employeeBindingSource As System.Windows.Forms.BindingSource
        Private diagramShape1 As DiagramShape
        Private diagramShape3 As DiagramShape
        Private diagramShape4 As DiagramShape
        Private diagramConnector3 As DiagramConnector
        Private diagramConnector4 As DiagramConnector
        Private diagramContainer1 As DiagramContainer
        Private diagramImage1 As DiagramImage
        Private diagramShape2 As DiagramShape
        Private diagramConnector1 As DiagramConnector
        Private diagramConnector2 As DiagramConnector
    End Class
End Namespace
