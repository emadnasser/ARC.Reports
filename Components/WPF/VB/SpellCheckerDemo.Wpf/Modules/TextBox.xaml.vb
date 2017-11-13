Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System
Imports System.Globalization
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports DevExpress.XtraSpellChecker
Imports System.Collections.Generic

Namespace SpellCheckerDemo
    Partial Public Class TextBox
        Inherits SpellCheckerDemoModule

        Private elements As List(Of FrameworkElement)

        Public Sub New()
            InitializeComponent()
            Me.elements = New List(Of FrameworkElement)() From {tb}
        End Sub

        Protected Overrides ReadOnly Property CheckingElements() As List(Of FrameworkElement)
            Get
                Return elements
            End Get
        End Property

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SpellChecker.Check(tb)
        End Sub
        Private Sub editCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            ApplySpellCheckMode(CBool(e.NewValue))
        End Sub
        Private Sub tb_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ApplySpellCheckMode(True)
        End Sub
    End Class
End Namespace
