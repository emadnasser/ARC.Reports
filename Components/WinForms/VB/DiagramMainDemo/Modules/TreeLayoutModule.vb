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
Imports Alignment = DevExpress.Diagram.Core.Alignment

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class TreeLayoutModule
        Inherits LayoutModuleBase

        Public Sub New()
            InitializeComponent()
            LoadDocument("TreeLayoutDiagram.xml")
        End Sub
        Protected Overrides Sub RelayoutDiagramCore()
            Diagram.ApplyTreeLayout()
        End Sub
        Protected Overridable Sub RadioGroupSelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles directionRadioGroup.SelectedIndexChanged, alignmentRadioGroup.SelectedIndexChanged
            RelayoutDiagram()
        End Sub
        Protected Overridable Sub TrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles verticalSpacingTrackBar.ValueChanged, horizontalSpacingTrackBar.ValueChanged
            RelayoutDiagram()
        End Sub
    End Class
End Namespace
