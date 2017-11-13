Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class DiagramTutorialControlBase
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.optionsPanel_Renamed = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.containerControl = New System.Windows.Forms.ContainerControl()
            Me.diagramControl = New DevExpress.XtraDiagram.DiagramControl()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.containerControl.SuspendLayout()
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.AllowResize = False
            Me.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False
            Me.navigationPane1.Controls.Add(Me.optionsPanel_Renamed)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.Location = New System.Drawing.Point(515, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.optionsPanel_Renamed})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(279, 441)
            Me.navigationPane1.SelectedPage = Me.optionsPanel_Renamed
            Me.navigationPane1.Size = New System.Drawing.Size(279, 441)
            Me.navigationPane1.TabIndex = 5
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' optionsPanel
            ' 
            Me.optionsPanel_Renamed.Caption = "Options"
            Me.optionsPanel_Renamed.ImageUri.Uri = "Properties;Size16x16;Office2013"
            Me.optionsPanel_Renamed.Name = "optionsPanel"
            Me.optionsPanel_Renamed.Size = New System.Drawing.Size(229, 381)
            ' 
            ' containerControl
            ' 
            Me.containerControl.Controls.Add(Me.diagramControl)
            Me.containerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.containerControl.Location = New System.Drawing.Point(0, 0)
            Me.containerControl.Margin = New System.Windows.Forms.Padding(0)
            Me.containerControl.Name = "containerControl"
            Me.containerControl.Size = New System.Drawing.Size(515, 441)
            Me.containerControl.TabIndex = 6
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl.Name = "diagramControl"
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(){})
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(515, 441)
            Me.diagramControl.TabIndex = 0
            ' 
            ' DiagramTutorialControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.containerControl)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "DiagramTutorialControl"
            Me.Size = New System.Drawing.Size(794, 441)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.containerControl.ResumeLayout(False)
            CType(Me.diagramControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Protected navigationPane1 As XtraBars.Navigation.NavigationPane

        Protected optionsPanel_Renamed As XtraBars.Navigation.NavigationPage
        Protected containerControl As System.Windows.Forms.ContainerControl
        Protected diagramControl As DiagramControl
        'private DiagramTutorialControlBase diagramTutorialControlBase;
    End Class
End Namespace
