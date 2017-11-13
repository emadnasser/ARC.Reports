Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System
Imports System.Globalization
Imports DevExpress.Xpf.Editors
Imports DevExpress.XtraSpellChecker
Imports System.Windows.Media.Imaging
Imports System.Collections.Generic

Namespace SpellCheckerDemo
    Partial Public Class RichTextBox
        Inherits SpellCheckerDemoModule

        Private elements As List(Of FrameworkElement)

        Public Sub New()
            InitializeComponent()
            Me.imgDiagram.Source = DemoUtils.GetBitmapImage("Diagram.png")
            Me.elements = New List(Of FrameworkElement)() From {richTextBox}
        End Sub

        Protected Overrides ReadOnly Property XamlSuffix() As String
            Get
                Return DefaultXamlSuffix
            End Get
        End Property
        Protected Overrides ReadOnly Property CheckingElements() As List(Of FrameworkElement)
            Get
                Return elements
            End Get
        End Property

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.Check(richTextBox)
        End Sub
        Private Sub editCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            ApplySpellCheckMode(CBool(e.NewValue))
        End Sub
        Private Sub richTextBox_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ApplySpellCheckMode(True)
        End Sub
    End Class
End Namespace
