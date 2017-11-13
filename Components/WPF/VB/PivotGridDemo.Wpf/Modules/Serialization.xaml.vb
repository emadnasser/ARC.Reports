Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Partial Public Class Serialization
        Inherits PivotGridDemoModule

        Private currentLayoutStream As MemoryStream

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().CustomerReports.ToList()
        End Sub

        Private Sub LoadSampleButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RestoreLayout(CType(layoutSamplesComboBox.SelectedItem, LayoutSampleBase).GetStream())
            pivotGrid.BestFit(FieldArea.RowArea, True, False)
            pivotGrid.BestFitColumn(pivotGrid.ColumnCount - 1)
        End Sub

        Private Sub SaveLayoutButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            currentLayoutStream = SaveLayout()
            restoreLayoutButton.IsEnabled = True
        End Sub

        Private Sub RestoreLayoutButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RestoreLayout(currentLayoutStream)
        End Sub


        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim layoutSamples As New List(Of LayoutSampleBase)()
            layoutSamples.Add(New MemoryStreamLayoutSample("Original", SaveLayout()))
            Dim assembly As System.Reflection.Assembly = GetType(Serialization).Assembly
            layoutSamples.Add(New ResourceLayoutSample("Brief view", DemoHelper.GetPath("PivotGridDemo.Data.LayoutSamples.", assembly) & "BriefView.xml"))
            layoutSamples.Add(New ResourceLayoutSample("Full view", DemoHelper.GetPath("PivotGridDemo.Data.LayoutSamples.", assembly) & "FullView.xml"))
            layoutSamplesComboBox.ItemsSource = layoutSamples
            layoutSamplesComboBox.SelectedIndex = 0
        End Sub

        Private Function SaveLayout() As MemoryStream
            Dim stream As New MemoryStream()
            pivotGrid.SaveLayoutToStream(stream)
            Return stream
        End Function
        Private Sub RestoreLayout(ByVal stream As Stream)
            If stream Is Nothing Then
                Return
            End If
            stream.Position = 0
            pivotGrid.RestoreLayoutFromStream(stream)
        End Sub

        Public MustInherit Class LayoutSampleBase
            Private ReadOnly description As String
            Public Sub New(ByVal description As String)
                Me.description = description
            End Sub
            Public MustOverride Function GetStream() As Stream
            Public Overrides Function ToString() As String
                Return description
            End Function
        End Class
        Public Class ResourceLayoutSample
            Inherits LayoutSampleBase

            Private ReadOnly resourcePath As String
            Public Sub New(ByVal description As String, ByVal resourcePath As String)
                MyBase.New(description)
                Me.resourcePath = resourcePath
            End Sub
            Public Overrides Function GetStream() As Stream
                Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath)
            End Function
        End Class
        Public Class MemoryStreamLayoutSample
            Inherits LayoutSampleBase

            Private ReadOnly stream As MemoryStream
            Public Sub New(ByVal description As String, ByVal stream As MemoryStream)
                MyBase.New(description)
                Me.stream = stream
            End Sub
            Public Overrides Function GetStream() As Stream
                Return stream
            End Function
        End Class


    End Class
End Namespace
