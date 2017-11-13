Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.SpellChecker
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.SpellChecker
Imports System.Globalization
Imports DevExpress.XtraSpellChecker

Namespace SpellCheckerDemo
    Public Class SpellCheckerDemoModule
        Inherits DemoModule

        Public Shared ReadOnly SpellCheckerProperty As DependencyProperty

        Shared Sub New()
            RegisterRichEditControlController()
            RegisterRichEditControlUndoManager()
            SpellCheckerProperty = DependencyProperty.Register("SpellChecker", GetType(SpellChecker), GetType(SpellCheckerDemoModule), New PropertyMetadata(Nothing))
        End Sub
        Private Shared Sub RegisterRichEditControlController()
            SpellCheckTextControllersManager.Default.RegisterClass(GetType(RichEditControl), GetType(RichEditSpellCheckController))
        End Sub
        Private Shared Sub RegisterRichEditControlUndoManager()
            UndoControllerRepository.Default.Register(GetType(RichEditControl), GetType(RichEditUndoController))
        End Sub

        Public Sub New()

            Dim spellChecker_Renamed As SpellChecker = CreateSpellCheckerControl()
            If spellChecker_Renamed IsNot Nothing Then
                SpellChecker = spellChecker_Renamed
            Else
                SpellChecker = CreateDefaultSpellCheckerControl()
            End If
            DataContext = SpellChecker
        End Sub
        Public Property SpellChecker() As SpellChecker
            Get
                Return CType(GetValue(SpellCheckerProperty), SpellChecker)
            End Get
            Private Set(ByVal value As SpellChecker)
                SetValue(SpellCheckerProperty, value)
            End Set
        End Property
        Protected Overridable ReadOnly Property CheckingElements() As List(Of FrameworkElement)
            Get
                Return Nothing
            End Get
        End Property
        Protected Overrides ReadOnly Property XamlSuffix() As String
            Get
                Return ".xaml"
            End Get
        End Property
        Protected ReadOnly Property DefaultXamlSuffix() As String
            Get
                Return MyBase.XamlSuffix
            End Get
        End Property

        Private Sub CheckingElement_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ApplySpellCheckMode(True)
        End Sub
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If CheckingElements Is Nothing Then
                Return
            End If
            For Each element As FrameworkElement In CheckingElements
                If DirectCast(e.NewValue, Boolean) Then
                    element.Visibility = System.Windows.Visibility.Hidden
                Else
                    element.Visibility = System.Windows.Visibility.Visible
                End If
            Next element
        End Sub
        Protected Sub ApplySpellCheckMode(ByVal isAsYouType As Boolean)
            If isAsYouType Then
                SpellChecker.SpellCheckMode = SpellCheckMode.AsYouType
            Else
                SpellChecker.SpellCheckMode = SpellCheckMode.OnDemand
            End If
        End Sub
        Protected Overridable Function CreateSpellCheckerControl() As SpellChecker
            Return Nothing
        End Function
        Private Function CreateDefaultSpellCheckerControl() As SpellChecker
            Dim result As New SpellChecker()
            SpellCheckerHelper.RegisterDefaultDictionaries(result)
            result.Culture = New CultureInfo("en-US")
            Return result
        End Function
        Protected Overrides Function GetModuleDataContext() As Object
            Return SpellChecker
        End Function
    End Class
End Namespace
