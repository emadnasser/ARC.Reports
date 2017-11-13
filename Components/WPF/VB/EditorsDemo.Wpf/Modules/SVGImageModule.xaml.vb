Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Editors
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace EditorsDemo
    Partial Public Class SVGImageModule
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cmbGlyphSizesEditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            editor.EditValue = 1
        End Sub
    End Class

End Namespace
