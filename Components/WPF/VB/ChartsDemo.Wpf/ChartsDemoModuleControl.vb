Imports System
Imports System.Reflection
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Mvvm.Native

Namespace ChartsDemo
    Public Class ChartsDemoModule
        Inherits DemoModule

        Protected Overrides Function GetModuleDataContext() As Object
            Return Nothing
        End Function
        Public Overridable ReadOnly Property ActualChart() As ChartControlBase
            Get
                Dim field As FieldInfo = Me.GetType().GetField("PART_ActualChart", BindingFlags.Instance Or BindingFlags.NonPublic)
                If field IsNot Nothing Then
                    Return DirectCast(field.GetValue(Me), ChartControl)
                End If
                Return Nothing
            End Get
        End Property
        Public Overrides Function SupportSidebarContent() As Boolean
            Return True
        End Function

        Public Overrides Function GetSidebarIcon() As ImageSource
            Return New BitmapImage(New Uri("/ChartsDemo;component/Images/Palette.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarIconSelected() As ImageSource
            Return New BitmapImage(New Uri("/ChartsDemo;component/Images/PaletteSelected.png", UriKind.Relative))
        End Function
        Public Overrides Function GetSidebarTag() As String
            Return "Palette"
        End Function
        Public Overrides Function GetSidebarContent() As Object
            Return New PaletteChooser(ActualChart)
        End Function
        Public Overrides Sub UpdateSidebarContent(ByVal sidebarContent As Object)
            MyBase.UpdateSidebarContent(sidebarContent)
            Dim _paletteChooser As PaletteChooser = TryCast(sidebarContent, PaletteChooser)
            If _paletteChooser IsNot Nothing AndAlso ActualChart IsNot Nothing Then
                _paletteChooser.UpdateChart(ActualChart)
            End If
        End Sub
    End Class
End Namespace
