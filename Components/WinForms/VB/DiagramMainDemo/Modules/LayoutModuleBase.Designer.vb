Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class LayoutModuleBase
        #Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Location = New System.Drawing.Point(510, 0)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.RegularSize = New System.Drawing.Size(279, 581)
            Me.navigationPane1.Size = New System.Drawing.Size(279, 581)
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel_Renamed.Size = New System.Drawing.Size(229, 521)
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(510, 581)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(800F, 600F)
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact
            Me.diagramControl.Size = New System.Drawing.Size(429, 407)
            ' 
            ' LayoutModuleBase
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "LayoutModuleBase"
            Me.ShowOptionsPanel = True
            Me.Size = New System.Drawing.Size(789, 581)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
    End Class
End Namespace
