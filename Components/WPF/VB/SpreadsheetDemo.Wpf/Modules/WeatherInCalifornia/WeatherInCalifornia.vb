Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos
    Public NotInheritable Class WeatherInCalifornia

        Private Sub New()
        End Sub

        Public Shared Sub ApplyTemperatureConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            Dim minPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            Dim midPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Percentile, "50")
            Dim maxPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            conditionalFormattings.AddColorScale3ConditionalFormatting(sheet.Range("$C$4:$C$60"), minPoint, Color.FromArgb(255, &H65, &H92, &HAF), midPoint, Color.FromArgb(255, &HF2, &HA1, &H6A), maxPoint, Color.FromArgb(255, &HFF, &HD5, &H55))
            Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet.Range("$C$4:$C$60"), ConditionalFormattingExpressionCondition.GreaterThan, "40")
            cfRule.Formatting.Font.Color = Color.White
        End Sub
        Public Shared Sub ApplyHumidityConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            Dim lowBound As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            Dim highBound As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            Dim cfRule As DataBarConditionalFormatting = conditionalFormattings.AddDataBarConditionalFormatting(sheet.Range("$E$4:$E$60"), lowBound, highBound, Color.FromArgb(255, &HD6, &HD6, &HD6))
            cfRule.GradientFill = False
        End Sub
        Public Shared Sub ApplyPressureConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            Dim minPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "-1", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim midPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim maxPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim cfRule As IconSetConditionalFormatting = conditionalFormattings.AddIconSetConditionalFormatting(sheet.Range("$I$4:$I$60"), IconSetType.Triangles3, New ConditionalFormattingIconSetValue() { minPoint, midPoint, maxPoint })
            cfRule.ShowValue = False
        End Sub
    End Class
End Namespace
