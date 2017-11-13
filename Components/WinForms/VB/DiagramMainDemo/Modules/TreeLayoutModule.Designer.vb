Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class TreeLayoutModule
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
            Dim bindingSource As System.Windows.Forms.BindingSource
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.directionRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
            Me.verticalSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.alignmentRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.horizontalSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPanel_Renamed.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.directionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.verticalSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.verticalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.alignmentRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.horizontalSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.horizontalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Location = New System.Drawing.Point(514, 0)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl2)
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl1)
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl4)
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl6)
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(514, 581)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(800F, 600F)
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(508, 407)
            ' 
            ' bindingSource
            ' 
            bindingSource.DataMember = "OptionsTreeLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.AutoSize = True
            Me.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl4.Controls.Add(Me.directionRadioGroup)
            Me.groupControl4.Location = New System.Drawing.Point(4, 3)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(214, 120)
            Me.groupControl4.TabIndex = 1
            Me.groupControl4.Text = "Direction"
            ' 
            ' directionRadioGroup
            ' 
            Me.directionRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.directionRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.directionRadioGroup.Location = New System.Drawing.Point(2, 20)
            Me.directionRadioGroup.Name = "directionRadioGroup"
            Me.directionRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.directionRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.directionRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.directionRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom, "TopToBottom"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.BottomToTop, "BottomToTop"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.LeftToRight, "LeftToRight"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft, "RightToLeft")
            })
            Me.directionRadioGroup.Size = New System.Drawing.Size(210, 98)
            Me.directionRadioGroup.TabIndex = 1
            ' 
            ' groupControl6
            ' 
            Me.groupControl6.AutoSize = True
            Me.groupControl6.Controls.Add(Me.verticalSpacingTrackBar)
            Me.groupControl6.Location = New System.Drawing.Point(4, 275)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(214, 50)
            Me.groupControl6.TabIndex = 2
            Me.groupControl6.Text = "Vertical Spacing"
            ' 
            ' verticalSpacingTrackBar
            ' 
            Me.verticalSpacingTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "VerticalSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.verticalSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.verticalSpacingTrackBar.EditValue = 20
            Me.verticalSpacingTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.verticalSpacingTrackBar.Name = "verticalSpacingTrackBar"
            Me.verticalSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.verticalSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.verticalSpacingTrackBar.Properties.Maximum = 150
            Me.verticalSpacingTrackBar.Properties.Minimum = 20
            Me.verticalSpacingTrackBar.Properties.ShowValueToolTip = True
            Me.verticalSpacingTrackBar.Properties.SmallChange = 15
            Me.verticalSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.verticalSpacingTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.verticalSpacingTrackBar.TabIndex = 1
            Me.verticalSpacingTrackBar.Value = 20
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.AutoSize = True
            Me.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl1.Controls.Add(Me.alignmentRadioGroup)
            Me.groupControl1.Location = New System.Drawing.Point(4, 127)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(214, 90)
            Me.groupControl1.TabIndex = 3
            Me.groupControl1.Text = "Alignment"
            ' 
            ' alignmentRadioGroup
            ' 
            Me.alignmentRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Alignment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.alignmentRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alignmentRadioGroup.Location = New System.Drawing.Point(2, 20)
            Me.alignmentRadioGroup.Name = "alignmentRadioGroup"
            Me.alignmentRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.alignmentRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.alignmentRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.alignmentRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")
            })
            Me.alignmentRadioGroup.Size = New System.Drawing.Size(210, 68)
            Me.alignmentRadioGroup.TabIndex = 2
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.AutoSize = True
            Me.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl2.Controls.Add(Me.horizontalSpacingTrackBar)
            Me.groupControl2.Location = New System.Drawing.Point(4, 221)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(214, 50)
            Me.groupControl2.TabIndex = 4
            Me.groupControl2.Text = " Horizontal Spacing"
            ' 
            ' horizontalSpacingTrackBar
            ' 
            Me.horizontalSpacingTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "HorizontalSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.horizontalSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.horizontalSpacingTrackBar.EditValue = 20
            Me.horizontalSpacingTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.horizontalSpacingTrackBar.Name = "horizontalSpacingTrackBar"
            Me.horizontalSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.horizontalSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.horizontalSpacingTrackBar.Properties.Maximum = 150
            Me.horizontalSpacingTrackBar.Properties.Minimum = 20
            Me.horizontalSpacingTrackBar.Properties.ShowValueToolTip = True
            Me.horizontalSpacingTrackBar.Properties.SmallChange = 15
            Me.horizontalSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.horizontalSpacingTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.horizontalSpacingTrackBar.TabIndex = 0
            Me.horizontalSpacingTrackBar.Value = 20
            ' 
            ' TreeLayoutModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TreeLayoutModule"
            Me.Size = New System.Drawing.Size(793, 581)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPanel_Renamed.ResumeLayout(False)
            Me.optionsPanel_Renamed.PerformLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.directionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            Me.groupControl6.PerformLayout()
            CType(Me.verticalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.verticalSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType(Me.alignmentRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            Me.groupControl2.PerformLayout()
            CType(Me.horizontalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.horizontalSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private groupControl4 As XtraEditors.GroupControl
        Private WithEvents directionRadioGroup As XtraEditors.RadioGroup
        Private groupControl6 As XtraEditors.GroupControl
        Private WithEvents verticalSpacingTrackBar As XtraEditors.TrackBarControl
        Private groupControl1 As XtraEditors.GroupControl
        Private WithEvents alignmentRadioGroup As XtraEditors.RadioGroup
        Private WithEvents horizontalSpacingTrackBar As XtraEditors.TrackBarControl
        Private groupControl2 As XtraEditors.GroupControl
    End Class
End Namespace
