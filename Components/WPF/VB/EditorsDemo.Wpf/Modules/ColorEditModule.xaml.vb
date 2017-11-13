﻿Imports System
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
Imports EditorsDemo.Utils
Imports DevExpress.Xpf.Editors
Imports System.Windows.Markup
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase

Namespace EditorsDemo
    Partial Public Class ColorEditModule
        Inherits EditorsDemoModule

        Public Sub New()
            InitializeComponent()
            InitSources()
        End Sub
        Private Sub InitSources()
            Dim chipSizeSource As New List(Of ChipSize)()
            chipSizeSource.Add(ChipSize.Default)
            chipSizeSource.Add(ChipSize.Large)
            chipSizeSource.Add(ChipSize.Medium)
            chipSizeSource.Add(ChipSize.Small)
            chkChipSize.ItemsSource = chipSizeSource
        End Sub
    End Class
End Namespace