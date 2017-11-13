Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Charts
Imports System.Windows.Media

Namespace ChartsDemo
    Public Class PaletteItem
        Inherits RadioButton

        Public Shared ReadOnly PaletteNameProperty As DependencyProperty = DependencyProperty.Register("PaletteName", GetType(String), GetType(PaletteItem), New PropertyMetadata(String.Empty))
        Public Shared ReadOnly Brush1Property As DependencyProperty = DependencyProperty.Register("Brush1", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))
        Public Shared ReadOnly Brush2Property As DependencyProperty = DependencyProperty.Register("Brush2", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))
        Public Shared ReadOnly Brush3Property As DependencyProperty = DependencyProperty.Register("Brush3", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))
        Public Shared ReadOnly Brush4Property As DependencyProperty = DependencyProperty.Register("Brush4", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))
        Public Shared ReadOnly Brush5Property As DependencyProperty = DependencyProperty.Register("Brush5", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))
        Public Shared ReadOnly Brush6Property As DependencyProperty = DependencyProperty.Register("Brush6", GetType(SolidColorBrush), GetType(PaletteItem), New PropertyMetadata(Nothing))


        Private palette_Renamed As Palette

        Public Property PaletteName() As String
            Get
                Return DirectCast(GetValue(PaletteNameProperty), String)
            End Get
            Set(ByVal value As String)
                SetValue(PaletteNameProperty, value)
            End Set
        End Property
        Public Property Brush1() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush1Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush1Property, value)
            End Set
        End Property
        Public Property Brush2() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush2Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush2Property, value)
            End Set
        End Property
        Public Property Brush3() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush3Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush3Property, value)
            End Set
        End Property
        Public Property Brush4() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush4Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush4Property, value)
            End Set
        End Property
        Public Property Brush5() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush5Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush5Property, value)
            End Set
        End Property
        Public Property Brush6() As SolidColorBrush
            Get
                Return DirectCast(GetValue(Brush6Property), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(Brush6Property, value)
            End Set
        End Property
        Public Property Palette() As Palette
            Get
                Return palette_Renamed
            End Get
            Set(ByVal value As Palette)
                palette_Renamed = value
                PaletteName = palette_Renamed.PaletteName
                Brush1 = New SolidColorBrush(palette_Renamed(0))
                Brush2 = New SolidColorBrush(palette_Renamed(1))
                Brush3 = New SolidColorBrush(palette_Renamed(2))
                Brush4 = New SolidColorBrush(palette_Renamed(3))
                Brush5 = New SolidColorBrush(palette_Renamed(4))
                Brush6 = New SolidColorBrush(palette_Renamed(5))
            End Set
        End Property

        Public Sub New()
            DefaultStyleKey = GetType(PaletteItem)
        End Sub
    End Class
End Namespace
