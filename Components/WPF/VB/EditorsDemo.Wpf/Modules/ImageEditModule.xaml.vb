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
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Utils
Imports System.Reflection
Imports System.Collections.ObjectModel

Namespace EditorsDemo
    Partial Public Class ImageEditModule
        Inherits EditorsDemoModule

        Public Sub New()
            InitializeComponent()
               InitSources()
        End Sub
        Private Sub InitSources()
            InitStretchComboBox()
            InitLoadDialogModeComboBox()
        End Sub
        Private Sub InitStretchComboBox()
            Dim stretchModes As New List(Of Stretch)()
            stretchModes.Add(Stretch.Uniform)
            stretchModes.Add(Stretch.UniformToFill)
            stretchModes.Add(Stretch.Fill)
            cmbStretch.ItemsSource = stretchModes
        End Sub
        Private Sub InitLoadDialogModeComboBox()
            Dim loadDialogModes As New List(Of ShowLoadDialogOnClickMode)()
            loadDialogModes.Add(ShowLoadDialogOnClickMode.Always)
            loadDialogModes.Add(ShowLoadDialogOnClickMode.Never)
            loadDialogModes.Add(ShowLoadDialogOnClickMode.Empty)
            cmbLoadDialogMode.ItemsSource = loadDialogModes
        End Sub
    End Class

#Region "Helpers"
#End Region

End Namespace
