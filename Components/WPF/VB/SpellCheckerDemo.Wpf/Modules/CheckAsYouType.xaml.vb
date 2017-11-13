Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.Utils
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.SpellChecker
Imports DevExpress.XtraSpellChecker

Namespace SpellCheckerDemo
    Partial Public Class CheckAsYouType
        Inherits SpellCheckerDemoModule

        Private elements As List(Of FrameworkElement)

        Private cultures_Renamed() As CultureInfo

        Public Sub New()
            Me.cultures_Renamed = CultureInfo.GetCultures(CultureTypes.AllCultures)
            Array.Sort(Of CultureInfo)(Me.cultures_Renamed, New Comparison(Of CultureInfo)(Function(c1, c2) c1.Name.CompareTo(c2.Name)))
            InitializeComponent()
            Me.elements = New List(Of FrameworkElement)() From {textBox, richTextBox, textEdit}
        End Sub

        Protected Overrides ReadOnly Property CheckingElements() As List(Of FrameworkElement)
            Get
                Return elements
            End Get
        End Property
        Public Shared ReadOnly ActiveEditorProperty As DependencyProperty = DependencyProperty.Register("ActiveEditor", GetType(Control), GetType(CheckAsYouType), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnActiveEditorChanged)))
        Private Shared Sub OnActiveEditorChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Dim [module] As CheckAsYouType = CType(d, CheckAsYouType)
            Dim newControl As Control = DirectCast(e.NewValue, Control)
            [module].GroupSettingsHeader = String.Format("{0} Spelling Settings", newControl.GetType().Name)
        End Sub
        Public Property ActiveEditor() As Control
            Get
                Return CType(GetValue(ActiveEditorProperty), Control)
            End Get
            Set(ByVal value As Control)
                SetValue(ActiveEditorProperty, value)
            End Set
        End Property
        Public Shared ReadOnly GroupSettingsHederProperty As DependencyProperty = DependencyProperty.Register("GroupSettingsHeader", GetType(String), GetType(CheckAsYouType))
        Public Property GroupSettingsHeader() As String
            Get
                Return CStr(GetValue(GroupSettingsHederProperty))
            End Get
            Set(ByVal value As String)
                SetValue(GroupSettingsHederProperty, value)
            End Set
        End Property
        Public ReadOnly Property UnderlineStyles() As String()
            Get
                Return System.Enum.GetNames(GetType(UnderlineStyle))
            End Get
        End Property
        Public ReadOnly Property Cultures() As CultureInfo()
            Get
                Return cultures_Renamed
            End Get
        End Property

        Protected Overrides Function CreateSpellCheckerControl() As SpellChecker
            Dim result As New SpellChecker()
            Dim customDictionary As New SpellCheckerCustomDictionary(String.Empty, CultureInfo.InvariantCulture)
            result.Dictionaries.Add(customDictionary)
            result.SpellCheckMode = SpellCheckMode.AsYouType
            Return result
        End Function
        Private Sub ClearSettings(ByVal element As FrameworkElement)
            element.ClearValue(SpellingSettings.CheckAsYouTypeProperty)
            element.ClearValue(SpellingSettings.ShowSpellCheckMenuProperty)
            element.ClearValue(SpellingSettings.UnderlineColorProperty)
            element.ClearValue(SpellingSettings.UnderlineStyleProperty)
            element.ClearValue(SpellingSettings.IgnoreEmailsProperty)
            element.ClearValue(SpellingSettings.IgnoreMixedCaseWordsProperty)
            element.ClearValue(SpellingSettings.IgnoreRepeatedWordsProperty)
            element.ClearValue(SpellingSettings.IgnoreUpperCaseWordsProperty)
            element.ClearValue(SpellingSettings.IgnoreUriProperty)
            element.ClearValue(SpellingSettings.IgnoreWordsWithNumbersProperty)
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If ActiveEditor IsNot Nothing Then
                ClearSettings(ActiveEditor)
            End If
        End Sub
        Private Sub element_GotFocus(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ActiveEditor = TryCast(sender, Control)
        End Sub
        Private Sub CheckAsYouTypeModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ActiveEditor = textBox
            For Each element As FrameworkElement In CheckingElements
                AddHandler element.GotFocus, AddressOf element_GotFocus
            Next element
        End Sub
    End Class
    Public Class UnderlineStyleConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return value.ToString()
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Dim result As UnderlineStyle = Nothing
            System.Enum.TryParse(Of UnderlineStyle)(DirectCast(value, String), result)
            Return result
        End Function
    End Class
    Public Class DefaultBooleanConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim dbValue As DefaultBoolean = DirectCast(value, DefaultBoolean)
            Return If(dbValue.Equals(DefaultBoolean.True), True, False)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Dim boolValue As Boolean = DirectCast(value, Boolean)
            Return If(boolValue, DefaultBoolean.True, DefaultBoolean.False)
        End Function
    End Class
    Public Class OpacityConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim control As Control = DirectCast(value, Control)
            If control Is Nothing Then
                Return 1.0
            End If
            Return If(control.Name.Equals(parameter), 1.0, 0.5)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
