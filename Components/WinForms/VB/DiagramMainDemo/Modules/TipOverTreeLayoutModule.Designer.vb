Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class TipOverTreeLayoutModule
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
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.offsetTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.tipOverOffsetModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.tipOverDirectionRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
            Me.verticalSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPanel_Renamed.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType(Me.offsetTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.offsetTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.tipOverOffsetModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.tipOverDirectionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.verticalSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.verticalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
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
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(800F, 600F)
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(504, 407)
            ' 
            ' bindingSource
            ' 
            bindingSource.DataMember = "OptionsTipOverTreeLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.AutoSize = True
            Me.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl2.Controls.Add(Me.offsetTrackBar)
            Me.groupControl2.Location = New System.Drawing.Point(3, 155)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(214, 50)
            Me.groupControl2.TabIndex = 13
            Me.groupControl2.Text = "Offset"
            ' 
            ' offsetTrackBar
            ' 
            Me.offsetTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Offset", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.offsetTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.offsetTrackBar.EditValue = 30
            Me.offsetTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.offsetTrackBar.Name = "offsetTrackBar"
            Me.offsetTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.offsetTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.offsetTrackBar.Properties.Maximum = 150
            Me.offsetTrackBar.Properties.Minimum = 30
            Me.offsetTrackBar.Properties.ShowValueToolTip = True
            Me.offsetTrackBar.Properties.SmallChange = 15
            Me.offsetTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.offsetTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.offsetTrackBar.TabIndex = 0
            Me.offsetTrackBar.Value = 30
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.AutoSize = True
            Me.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl1.Controls.Add(Me.tipOverOffsetModeRadioGroup)
            Me.groupControl1.Location = New System.Drawing.Point(3, 78)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(214, 73)
            Me.groupControl1.TabIndex = 12
            Me.groupControl1.Text = "Tip Over Offset Mode"
            ' 
            ' tipOverOffsetModeRadioGroup
            ' 
            Me.tipOverOffsetModeRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "OffsetMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverOffsetModeRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tipOverOffsetModeRadioGroup.Location = New System.Drawing.Point(2, 20)
            Me.tipOverOffsetModeRadioGroup.Name = "tipOverOffsetModeRadioGroup"
            Me.tipOverOffsetModeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.tipOverOffsetModeRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.tipOverOffsetModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tipOverOffsetModeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")
            })
            Me.tipOverOffsetModeRadioGroup.Size = New System.Drawing.Size(210, 51)
            Me.tipOverOffsetModeRadioGroup.TabIndex = 2
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.AutoSize = True
            Me.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl4.Controls.Add(Me.tipOverDirectionRadioGroup)
            Me.groupControl4.Location = New System.Drawing.Point(3, 1)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(214, 73)
            Me.groupControl4.TabIndex = 10
            Me.groupControl4.Text = "Tip Over Direction"
            ' 
            ' tipOverDirectionRadioGroup
            ' 
            Me.tipOverDirectionRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverDirectionRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tipOverDirectionRadioGroup.Location = New System.Drawing.Point(2, 20)
            Me.tipOverDirectionRadioGroup.Name = "tipOverDirectionRadioGroup"
            Me.tipOverDirectionRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.tipOverDirectionRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.tipOverDirectionRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tipOverDirectionRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "LeftToRight"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "RightToLeft")
            })
            Me.tipOverDirectionRadioGroup.Size = New System.Drawing.Size(210, 51)
            Me.tipOverDirectionRadioGroup.TabIndex = 2
            ' 
            ' groupControl6
            ' 
            Me.groupControl6.AutoSize = True
            Me.groupControl6.Controls.Add(Me.verticalSpacingTrackBar)
            Me.groupControl6.Location = New System.Drawing.Point(3, 209)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(214, 50)
            Me.groupControl6.TabIndex = 11
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
            ' TipOverTreeLayoutModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TipOverTreeLayoutModule"
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPanel_Renamed.ResumeLayout(False)
            Me.optionsPanel_Renamed.PerformLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            Me.groupControl2.PerformLayout()
            CType(Me.offsetTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.offsetTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType(Me.tipOverOffsetModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.tipOverDirectionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            Me.groupControl6.PerformLayout()
            CType(Me.verticalSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.verticalSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents offsetTrackBar As XtraEditors.TrackBarControl
        Private WithEvents tipOverOffsetModeRadioGroup As XtraEditors.RadioGroup
        Private WithEvents tipOverDirectionRadioGroup As XtraEditors.RadioGroup
        Private WithEvents verticalSpacingTrackBar As XtraEditors.TrackBarControl
        Private groupControl6 As XtraEditors.GroupControl
        Private groupControl4 As XtraEditors.GroupControl
        Private groupControl1 As XtraEditors.GroupControl
        Private groupControl2 As XtraEditors.GroupControl
    End Class
End Namespace
