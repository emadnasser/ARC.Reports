Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraDiagram.Demos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Diagram.Core
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils
Imports DevExpress.XtraDiagram.Utils
Imports DevExpress.Diagram.Core.Layout
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class LayeredLayoutModule
        Inherits LayoutModuleBase

        Public Sub New()
            InitializeComponent()
            LoadDocument("LayeredLayoutDiagram.xml")
        End Sub
        Protected Overrides Sub RelayoutDiagramCore()
            Diagram.ApplySugiyamaLayout()
        End Sub
        Protected Overridable Sub RadioGroupSelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles directionRadioGroup.SelectedIndexChanged
            RelayoutDiagram()
        End Sub
        Protected Overridable Sub TrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles layerSpacingTrackBar.ValueChanged, columnSpacingTrackBar.ValueChanged
            RelayoutDiagram()
        End Sub
    End Class
End Namespace
