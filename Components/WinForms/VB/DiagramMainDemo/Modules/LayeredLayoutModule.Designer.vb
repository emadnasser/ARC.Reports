Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class LayeredLayoutModule
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
            Me.groupControl6 = New DevExpress.XtraEditors.GroupControl()
            Me.layerSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.directionRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.columnSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPanel_Renamed.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.layerSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layerSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.directionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.columnSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.columnSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl4)
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl6)
            Me.optionsPanel_Renamed.Controls.Add(Me.groupControl5)
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
            bindingSource.DataMember = "OptionsSugiyamaLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' groupControl6
            ' 
            Me.groupControl6.AutoSize = True
            Me.groupControl6.Controls.Add(Me.layerSpacingTrackBar)
            Me.groupControl6.Location = New System.Drawing.Point(4, 178)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(214, 50)
            Me.groupControl6.TabIndex = 0
            Me.groupControl6.Text = "Layer Spacing"
            ' 
            ' layerSpacingTrackBar
            ' 
            Me.layerSpacingTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "LayerSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.layerSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layerSpacingTrackBar.EditValue = 30
            Me.layerSpacingTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.layerSpacingTrackBar.Name = "layerSpacingTrackBar"
            Me.layerSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.layerSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layerSpacingTrackBar.Properties.Maximum = 150
            Me.layerSpacingTrackBar.Properties.Minimum = 30
            Me.layerSpacingTrackBar.Properties.ShowValueToolTip = True
            Me.layerSpacingTrackBar.Properties.SmallChange = 15
            Me.layerSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.layerSpacingTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.layerSpacingTrackBar.TabIndex = 1
            Me.layerSpacingTrackBar.Value = 30
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
            Me.directionRadioGroup.TabIndex = 2
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.AutoSize = True
            Me.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl4.Controls.Add(Me.directionRadioGroup)
            Me.groupControl4.Location = New System.Drawing.Point(4, 0)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(214, 120)
            Me.groupControl4.TabIndex = 0
            Me.groupControl4.Text = "Direction"
            ' 
            ' columnSpacingTrackBar
            ' 
            Me.columnSpacingTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "ColumnSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.columnSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.columnSpacingTrackBar.EditValue = 20
            Me.columnSpacingTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.columnSpacingTrackBar.Name = "columnSpacingTrackBar"
            Me.columnSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.columnSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.columnSpacingTrackBar.Properties.Maximum = 150
            Me.columnSpacingTrackBar.Properties.Minimum = 20
            Me.columnSpacingTrackBar.Properties.ShowValueToolTip = True
            Me.columnSpacingTrackBar.Properties.SmallChange = 15
            Me.columnSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.columnSpacingTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.columnSpacingTrackBar.TabIndex = 0
            Me.columnSpacingTrackBar.Value = 20
            ' 
            ' groupControl5
            ' 
            Me.groupControl5.AutoSize = True
            Me.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl5.Controls.Add(Me.columnSpacingTrackBar)
            Me.groupControl5.Location = New System.Drawing.Point(4, 124)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Size = New System.Drawing.Size(214, 50)
            Me.groupControl5.TabIndex = 0
            Me.groupControl5.Text = "Column Spacing"
            ' 
            ' LayeredLayoutModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Name = "LayeredLayoutModule"
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPanel_Renamed.ResumeLayout(False)
            Me.optionsPanel_Renamed.PerformLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            Me.groupControl6.PerformLayout()
            CType(Me.layerSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layerSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.directionRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.columnSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.columnSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            Me.groupControl5.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private groupControl6 As XtraEditors.GroupControl
        Private WithEvents layerSpacingTrackBar As XtraEditors.TrackBarControl
        Private WithEvents directionRadioGroup As XtraEditors.RadioGroup
        Private groupControl4 As XtraEditors.GroupControl
        Private WithEvents columnSpacingTrackBar As XtraEditors.TrackBarControl
        Private groupControl5 As XtraEditors.GroupControl
    End Class
End Namespace
