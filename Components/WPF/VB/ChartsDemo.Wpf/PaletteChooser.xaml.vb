Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Input
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Charts

Namespace ChartsDemo
    Partial Public Class PaletteChooser
        Inherits UserControl

        Private chart As ChartControlBase

        Public Sub New(ByVal chart As ChartControlBase)
            InitializeComponent()
            Me.chart = chart
            Dim count As Integer = 0
            If chart IsNot Nothing Then
                chart.Palette = PaletteSelectorHelper.ActualPalette
            End If
            For Each paletteKind As PaletteKind In Palette.GetPredefinedKinds()
                Dim rowDefenition As New RowDefinition()
                rowDefenition.Height = GridLength.Auto
                grPalettes.RowDefinitions.Add(rowDefenition)

                Dim paletteItem_Renamed As New PaletteItem()
                paletteItem_Renamed.Palette = TryCast(Activator.CreateInstance(paletteKind.Type), Palette)
                If chart IsNot Nothing AndAlso chart.Palette.PaletteName = paletteItem_Renamed.Palette.PaletteName Then
                    paletteItem_Renamed.IsChecked = True
                End If
                AddHandler paletteItem_Renamed.Checked, AddressOf paletteItem_Checked
                AddHandler paletteItem_Renamed.GotMouseCapture, AddressOf PaletteItem_ReleaseMouseCapture
                paletteItem_Renamed.ClickMode = ClickMode.Press
                Grid.SetRow(paletteItem_Renamed, count)
                grPalettes.Children.Add(paletteItem_Renamed)
                count += 1
            Next paletteKind
        End Sub
        Private Sub PaletteItem_ReleaseMouseCapture(ByVal sender As Object, ByVal e As MouseEventArgs)

            Dim paletteItem_Renamed As PaletteItem = TryCast(sender, PaletteItem)
            paletteItem_Renamed.ReleaseMouseCapture()
        End Sub
        Private Sub paletteItem_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Dim paletteItem_Renamed As PaletteItem = TryCast(sender, PaletteItem)
            If chart IsNot Nothing AndAlso paletteItem_Renamed IsNot Nothing Then
                chart.Palette = paletteItem_Renamed.Palette
                PaletteSelectorHelper.ActualPalette = paletteItem_Renamed.Palette
            End If
        End Sub
        Public Sub UpdateChart(ByVal chart As ChartControlBase)
            Me.chart = chart
            chart.Palette = PaletteSelectorHelper.ActualPalette
        End Sub
    End Class
End Namespace
