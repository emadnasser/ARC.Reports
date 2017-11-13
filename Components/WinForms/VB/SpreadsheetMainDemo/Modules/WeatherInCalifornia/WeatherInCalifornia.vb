Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos
	Public NotInheritable Class WeatherInCalifornia
		Private Sub New()
		End Sub
		Public Shared Sub ApplyTemperatureConditionalFormatting(ByVal sheet As Worksheet)
			Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
			' Automatically set the minimum threshold to the lowest value in the range of cells.
			Dim minPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
			' Set the midpoint threshold to the 50th percentile.
			Dim midPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Percentile, "50")
			' Automatically set the maximum threshold to the highest value in the range of cells.
			Dim maxPoint As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
			' Create the three-color scale rule to determine how values in cells C4 through C60 vary.
			conditionalFormattings.AddColorScale3ConditionalFormatting(sheet.Range("$C$4:$C$60"), minPoint, Color.FromArgb(255, &H65, &H92, &HAF), midPoint, Color.FromArgb(255, &HF2, &HA1, &H6A), maxPoint, Color.FromArgb(255, &HFF, &HD5, &H55))


			' Create the rule to identify values that are greater than 40F in cells C4 through C60.
			Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet.Range("$C$4:$C$60"), ConditionalFormattingExpressionCondition.GreaterThan, "40")
			' Specify formatting options to be applied to cells if the condition is true.
			' Set the font color to white.
			cfRule.Formatting.Font.Color = Color.White
		End Sub
		Public Shared Sub ApplyHumidityConditionalFormatting(ByVal sheet As Worksheet)
			Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
			' Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
			Dim lowBound As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
			' Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
			Dim highBound As ConditionalFormattingValue = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
			' Create the rule to compare values in cells E4 through E60 using data bars.  
			Dim cfRule As DataBarConditionalFormatting = conditionalFormattings.AddDataBarConditionalFormatting(sheet.Range("$E$4:$E$60"), lowBound, highBound, Color.FromArgb(255, &HD6, &HD6, &HD6))
			' Specify the solid fill type.
			cfRule.GradientFill = False
		End Sub
		Public Shared Sub ApplyPressureConditionalFormatting(ByVal sheet As Worksheet)
			Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
			' Set the first threshold to -1.
			Dim minPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "-1", ConditionalFormattingValueOperator.GreaterOrEqual)
			' Set the second threshold to 0.
			Dim midPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual)
			' Set the third threshold to 1.
			Dim maxPoint As ConditionalFormattingIconSetValue = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual)
			' Create the rule to apply a specific icon from the three triangle icon set to each cell in the range  I4:I60 based on its values.   
			Dim cfRule As IconSetConditionalFormatting = conditionalFormattings.AddIconSetConditionalFormatting(sheet.Range("$I$4:$I$60"), IconSetType.Triangles3, New ConditionalFormattingIconSetValue() { minPoint, midPoint, maxPoint })
			cfRule.ShowValue = False
		End Sub
	End Class
End Namespace
