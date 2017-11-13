Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class CircularLayoutModule
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
            Me.startAngleTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.circularOrderRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
            Me.nodesSpacingTrackBar = New DevExpress.XtraEditors.TrackBarControl()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPanel_Renamed.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl6.SuspendLayout()
            CType(Me.startAngleTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.startAngleTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularOrderRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl4.SuspendLayout()
            CType(Me.nodesSpacingTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nodesSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            bindingSource.DataMember = "OptionsCircularLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' groupControl6
            ' 
            Me.groupControl6.AutoSize = True
            Me.groupControl6.Controls.Add(Me.startAngleTrackBar)
            Me.groupControl6.Location = New System.Drawing.Point(4, 148)
            Me.groupControl6.Name = "groupControl6"
            Me.groupControl6.Size = New System.Drawing.Size(214, 50)
            Me.groupControl6.TabIndex = 0
            Me.groupControl6.Text = "Start Angle"
            ' 
            ' startAngleTrackBar
            ' 
            Me.startAngleTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "StartAngle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.startAngleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.startAngleTrackBar.EditValue = Nothing
            Me.startAngleTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.startAngleTrackBar.Name = "startAngleTrackBar"
            Me.startAngleTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.startAngleTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.startAngleTrackBar.Properties.Maximum = 360
            Me.startAngleTrackBar.Properties.ShowValueToolTip = True
            Me.startAngleTrackBar.Properties.SmallChange = 15
            Me.startAngleTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.startAngleTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.startAngleTrackBar.TabIndex = 1
            ' 
            ' circularOrderRadioGroup
            ' 
            Me.circularOrderRadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Order", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.circularOrderRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.circularOrderRadioGroup.Location = New System.Drawing.Point(2, 20)
            Me.circularOrderRadioGroup.Name = "circularOrderRadioGroup"
            Me.circularOrderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.circularOrderRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.circularOrderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.circularOrderRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal, "Optimal"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise, "Clockwise"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Counterclockwise, "Counterclockwise")
            })
            Me.circularOrderRadioGroup.Size = New System.Drawing.Size(210, 68)
            Me.circularOrderRadioGroup.TabIndex = 2
            ' 
            ' groupControl4
            ' 
            Me.groupControl4.AutoSize = True
            Me.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl4.Controls.Add(Me.circularOrderRadioGroup)
            Me.groupControl4.Location = New System.Drawing.Point(4, 0)
            Me.groupControl4.Name = "groupControl4"
            Me.groupControl4.Size = New System.Drawing.Size(214, 90)
            Me.groupControl4.TabIndex = 0
            Me.groupControl4.Text = "Circular Order"
            ' 
            ' nodesSpacingTrackBar
            ' 
            Me.nodesSpacingTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "NodesSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.nodesSpacingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.nodesSpacingTrackBar.EditValue = Nothing
            Me.nodesSpacingTrackBar.Location = New System.Drawing.Point(2, 20)
            Me.nodesSpacingTrackBar.Name = "nodesSpacingTrackBar"
            Me.nodesSpacingTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.nodesSpacingTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.nodesSpacingTrackBar.Properties.Maximum = 150
            Me.nodesSpacingTrackBar.Properties.ShowValueToolTip = True
            Me.nodesSpacingTrackBar.Properties.SmallChange = 15
            Me.nodesSpacingTrackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.nodesSpacingTrackBar.Size = New System.Drawing.Size(210, 28)
            Me.nodesSpacingTrackBar.TabIndex = 0
            ' 
            ' groupControl5
            ' 
            Me.groupControl5.AutoSize = True
            Me.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.groupControl5.Controls.Add(Me.nodesSpacingTrackBar)
            Me.groupControl5.Location = New System.Drawing.Point(4, 94)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Size = New System.Drawing.Size(214, 50)
            Me.groupControl5.TabIndex = 0
            Me.groupControl5.Text = "Nodes Spacing"
            ' 
            ' CircularLayoutModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Name = "CircularLayoutModule"
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPanel_Renamed.ResumeLayout(False)
            Me.optionsPanel_Renamed.PerformLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl6.ResumeLayout(False)
            Me.groupControl6.PerformLayout()
            CType(Me.startAngleTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.startAngleTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularOrderRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl4.ResumeLayout(False)
            CType(Me.nodesSpacingTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nodesSpacingTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            Me.groupControl5.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private groupControl6 As XtraEditors.GroupControl
        Private WithEvents startAngleTrackBar As XtraEditors.TrackBarControl
        Private WithEvents circularOrderRadioGroup As XtraEditors.RadioGroup
        Private groupControl4 As XtraEditors.GroupControl
        Private WithEvents nodesSpacingTrackBar As XtraEditors.TrackBarControl
        Private groupControl5 As XtraEditors.GroupControl
    End Class
End Namespace
