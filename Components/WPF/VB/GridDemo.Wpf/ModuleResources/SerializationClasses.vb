Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.IO
Imports System.Reflection

Namespace GridDemo
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
End Namespace
