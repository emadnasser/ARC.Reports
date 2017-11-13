Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.XtraRichEdit.Commands

Namespace SpellCheckerDemo
    Partial Public Class TextEdit
        Inherits SpellCheckerDemoModule

        Private elements As List(Of FrameworkElement)

        Public Sub New()
            InitializeComponent()
            Me.elements = New List(Of FrameworkElement)() From {textEdit}
        End Sub

        Protected Overrides ReadOnly Property CheckingElements() As List(Of FrameworkElement)
            Get
                Return elements
            End Get
        End Property

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.Check(textEdit)
        End Sub
        Private Sub editCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            ApplySpellCheckMode(CBool(e.NewValue))
        End Sub
        Private Sub textEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ApplySpellCheckMode(True)
        End Sub
    End Class
End Namespace
