Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.ConditionalFormatting
Imports System.Windows.Media
Imports System.Windows.Controls

Namespace GridDemo
    <CodeFile("ModuleResources/ConditionalFormatting/ConditionalFormattingViewModel.cs"), CodeFile("ModuleResources/ConditionalFormatting/SaleOverviewData.cs")>
    Partial Public Class ConditionalFormatting
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub CustomCellAppearance(ByVal sender As Object, ByVal e As CustomCellAppearanceEventArgs)
            ProcessCustomAppearanceEventArgs(e, e.CellSelectionState <> SelectionState.None OrElse e.RowSelectionState <> SelectionState.None)
        End Sub
        Private Sub CustomRowAppearance(ByVal sender As Object, ByVal e As CustomRowAppearanceEventArgs)
            ProcessCustomAppearanceEventArgs(e, e.RowSelectionState <> SelectionState.None)
        End Sub
        Private Sub ProcessCustomAppearanceEventArgs(ByVal e As CustomAppearanceEventArgs, ByVal isSelected As Boolean)
            If isSelected Then
                Dim result As Object = e.ConditionalValue
                If e.Property Is TextBlock.ForegroundProperty OrElse e.Property Is TextBlock.BackgroundProperty Then
                    Dim original As SolidColorBrush = TryCast(e.OriginalValue, SolidColorBrush)
                    Dim conditional As SolidColorBrush = TryCast(e.ConditionalValue, SolidColorBrush)
                    If conditional IsNot Nothing AndAlso (original Is Nothing OrElse original.Color <> conditional.Color) Then
                        result = ShadeBrush(conditional)
                    End If
                End If
                e.Result = result
                e.Handled = True
            End If
        End Sub
        Private Function ShadeBrush(ByVal brush As SolidColorBrush) As SolidColorBrush
            Dim originalColor As Color = brush.Color
            Dim coefficient As Single = 0.75F
            Dim a As Byte = originalColor.A
            If Not grid.IsKeyboardFocusWithin Then
                a = CByte(originalColor.A \ 2)
            End If
            Dim r As Byte = CByte(originalColor.R * coefficient)
            Dim g As Byte = CByte(originalColor.G * coefficient)
            Dim b As Byte = CByte(originalColor.B * coefficient)
            Return New SolidColorBrush(Color.FromArgb(a, r, g, b))
        End Function
    End Class
End Namespace
