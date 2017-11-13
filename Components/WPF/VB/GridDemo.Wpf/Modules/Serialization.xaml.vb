Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.IO
Imports System.Reflection
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers

Namespace GridDemo
    <CodeFile("ModuleResources/SerializationClasses.(cs)")>
    Partial Public Class Serialization
        Inherits GridDemoModule

        Private currentLayoutStream As MemoryStream
        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf Serialization_Loaded
        End Sub
        Private Sub Serialization_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim layoutSamples As New List(Of LayoutSampleBase)()
            layoutSamples.Add(New MemoryStreamLayoutSample("Original", SaveLayout()))
            Dim assembly As System.Reflection.Assembly = GetType(Serialization).Assembly
            layoutSamples.Add(New ResourceLayoutSample("Brief view", DemoHelper.GetPath("GridDemo.Data.LayoutSamples.", assembly) & "BriefView.xml"))
            layoutSamples.Add(New ResourceLayoutSample("Full view", DemoHelper.GetPath("GridDemo.Data.LayoutSamples.", assembly) & "FullView.xml"))
            layoutSamples.Add(New ResourceLayoutSample("Banded layout", DemoHelper.GetPath("GridDemo.Data.LayoutSamples.", assembly) & "BandedLayout.xml"))
            layoutSamplesComboBox.ItemsSource = layoutSamples
            layoutSamplesComboBox.SelectedIndex = 0
        End Sub

        Private Function SaveLayout() As MemoryStream
            Dim stream As New MemoryStream()
            grid.SaveLayoutToStream(stream)
            Return stream
        End Function
        Private Sub RestoreLayout(ByVal stream As Stream)
            If stream Is Nothing Then
                Return
            End If
            stream.Position = 0
            grid.RestoreLayoutFromStream(stream)
        End Sub
        Private Sub saveLayoutButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            currentLayoutStream = SaveLayout()
            restoreLayoutButton.IsEnabled = True
        End Sub

        Private Sub restoreLayoutButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RestoreLayout(currentLayoutStream)
        End Sub
        Private Sub loadSampleLayoutButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RestoreLayout(CType(layoutSamplesComboBox.SelectedItem, LayoutSampleBase).GetStream())
        End Sub
    End Class
End Namespace
