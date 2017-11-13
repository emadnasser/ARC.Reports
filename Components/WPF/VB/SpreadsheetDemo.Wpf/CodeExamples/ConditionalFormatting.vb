Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic
Imports Formatting = DevExpress.Spreadsheet.Formatting
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class ConditionalFormatting

        Private Sub New()
        End Sub

        Private Shared Sub AddAverageConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#AverageConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim conditionalFormattings As ConditionalFormattingCollection = worksheet.ConditionalFormattings
            Dim cfRule1 As AverageConditionalFormatting = conditionalFormattings.AddAverageConditionalFormatting(worksheet("$D$5:$D$18"), ConditionalFormattingAverageCondition.AboveOrEqual)
            cfRule1.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HFA, &HF7, &HAA)
            cfRule1.Formatting.Font.Color = Color.Red
            Dim cfRule2 As AverageConditionalFormatting = conditionalFormattings.AddAverageConditionalFormatting(worksheet("$E$5:$E$18"), ConditionalFormattingAverageCondition.BelowOrEqual, 1)
            cfRule2.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &H9F, &HFB, &H69)
            cfRule2.Formatting.Font.Color = Color.BlueViolet
            worksheet("B2").Value = "In the report below determine cost values that are above the average in the first quarter and one standard deviation below the average in the second quarter."
            worksheet.Visible = True
'            #End Region ' #AverageConditionalFormatting
        End Sub

        Private Shared Sub AddRangeConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#RangeConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As RangeConditionalFormatting = worksheet.ConditionalFormattings.AddRangeConditionalFormatting(worksheet("$G$5:$G$18"), ConditionalFormattingRangeCondition.Outside, "7", "19")
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HFA, &HF7, &HAA)
            cfRule.Formatting.Font.Color = Color.Red
            worksheet("B2").Value = "In the report below identify price values that are less than $7 and greater than $19."
            worksheet.Visible = True
'            #End Region ' #RangeConditionalFormatting
        End Sub

        Private Shared Sub AddRankConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#RankConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As RankConditionalFormatting = worksheet.ConditionalFormattings.AddRankConditionalFormatting(worksheet("$G$5:$G$18"), ConditionalFormattingRankCondition.TopByRank, 3)
            cfRule.Formatting.Fill.BackgroundColor = Color.DarkOrchid
            cfRule.Formatting.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin)
            cfRule.Formatting.Font.Color = Color.White
            worksheet("B2").Value = "In the report below identify the top three price values."
            worksheet.Visible = True
'            #End Region ' #RankConditionalFormatting
        End Sub

        Private Shared Sub AddTextConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#TextConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As TextConditionalFormatting = worksheet.ConditionalFormattings.AddTextConditionalFormatting(worksheet("$B$5:$B$18"), ConditionalFormattingTextCondition.Contains, "Bradbury")
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HE1, &H95, &HC2)
            worksheet("B2").Value = "Quickly find books written by Ray Bradbury in the report below."
            worksheet.Visible = True
'            #End Region ' #TextConditionalFormatting
        End Sub


        Private Shared Sub AddSpecialConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#SpecialConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As SpecialConditionalFormatting = worksheet.ConditionalFormattings.AddSpecialConditionalFormatting(worksheet("$B$5:$B$18"), ConditionalFormattingSpecialCondition.ContainUniqueValue)
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HFA, &HF7, &HAA)
            worksheet("B2").Value = "Quickly identify unique values in the list of authors."
            worksheet.Visible = True
'            #End Region ' #SpecialConditionalFormatting
        End Sub


        Private Shared Sub AddTimePeriodConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#TimePeriodConditionalFormatting"
            workbook.Calculate()
            Dim worksheet As Worksheet = workbook.Worksheets("cfTasks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As TimePeriodConditionalFormatting = worksheet.ConditionalFormattings.AddTimePeriodConditionalFormatting(worksheet("$C$5:$C$9"), ConditionalFormattingTimePeriod.Today)
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HF2, &HAE, &HE3)
            worksheet("B2").Value = "Determine the today's task in the TO DO list."
            worksheet.Visible = True
'            #End Region ' #TimePeriodConditionalFormatting
        End Sub


        Private Shared Sub AddExpressionConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#ExpressionConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As ExpressionConditionalFormatting = worksheet.ConditionalFormattings.AddExpressionConditionalFormatting(worksheet("$G$5:$G$18"), ConditionalFormattingExpressionCondition.GreaterThan, "=AVERAGE($G$5:$G$18)")
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HFA, &HF7, &HAA)
            cfRule.Formatting.Font.Color = Color.Red
            worksheet("B2").Value = "In the report below identify price values that are above the average."
            worksheet.Visible = True
'            #End Region ' #ExpressionConditionalFormatting
        End Sub


        Private Shared Sub AddFormulaExpressionConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#FormulaExpressionConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim cfRule As FormulaExpressionConditionalFormatting = worksheet.ConditionalFormattings.AddFormulaExpressionConditionalFormatting(worksheet.Range("$B$5:$H$18"), "=MOD(ROW(),2)=1")
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, &HBC, &HDA, &HF7)
            worksheet("B2").Value = "Shade alternate rows in light blue without applying a new style."
            worksheet.Visible = True
'            #End Region ' #FormulaExpressionConditionalFormatting
        End Sub


        Private Shared Sub AddColorScale2ConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#ColorScale2ConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim minPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Percent, "0")
            Dim maxPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Percent, "100")
            Dim cfRule As ColorScale2ConditionalFormatting = worksheet.ConditionalFormattings.AddColorScale2ConditionalFormatting(worksheet.Range("$D$5:$E$18"), minPoint, Color.FromArgb(255, &H9D, &HE9, &HFA), maxPoint, Color.FromArgb(255, &HFF, &HF6, &HA9))
            worksheet("B2").Value = "Examine cost distribution using a gradation of two colors. Blue represents the lower values and yellow represents the higher values."
            worksheet.Visible = True
'            #End Region ' #ColorScale2ConditionalFormatting
        End Sub


        Private Shared Sub AddColorScale2ConditionalFormatting_Extremum(ByVal workbook As IWorkbook)
'            #Region "#ColorScale2ConditionalFormatting_Extremum"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim minPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            Dim maxPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            Dim cfRule As ColorScale2ConditionalFormatting = worksheet.ConditionalFormattings.AddColorScale2ConditionalFormatting(worksheet.Range("$D$5:$E$18"), minPoint, Color.FromArgb(255, &H9D, &HE9, &HFA), maxPoint, Color.FromArgb(255, &HFF, &HF6, &HA9))
            worksheet("B2").Value = "Examine cost distribution using a gradation of two colors. Blue represents the lower values and yellow represents the higher values."
            worksheet.Visible = True
'            #End Region ' #ColorScale2ConditionalFormatting_Extremum
        End Sub


        Private Shared Sub AddColorScale3ConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#ColorScale3ConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim minPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Formula, "=MIN($E$5:$F$18)")
            Dim midPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Percentile, "50")
            Dim maxPoint As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Number, "=MAX($E$5:$F$18)")
            Dim cfRule As ColorScale3ConditionalFormatting = worksheet.ConditionalFormattings.AddColorScale3ConditionalFormatting(worksheet.Range("$D$5:$E$18"), minPoint, Color.Red, midPoint, Color.Yellow, maxPoint, Color.SkyBlue)
            worksheet("B2").Value = "Examine cost distribution using a gradation of three colors. Red represents the lower values, yellow represents the medium values and sky blue represents the higher values."
            worksheet.Visible = True
'            #End Region ' #ColorScale3ConditionalFormatting
        End Sub

        Private Shared Sub AddDataBarConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#DataBarConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim lowBound1 As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            Dim highBound1 As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax)
            Dim cfRule1 As DataBarConditionalFormatting = worksheet.ConditionalFormattings.AddDataBarConditionalFormatting(worksheet.Range("$F$5:$F$18"), lowBound1, highBound1, Color.Green)
            cfRule1.BorderColor = Color.Green
            cfRule1.NegativeBarColor = Color.Red
            cfRule1.NegativeBarBorderColor = Color.Red
            cfRule1.AxisPosition = ConditionalFormattingDataBarAxisPosition.Middle
            cfRule1.AxisColor = Color.DarkBlue
            Dim lowBound2 As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Percent, "0")
            Dim highBound2 As ConditionalFormattingValue = worksheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Percent, "100")
            Dim cfRule2 As DataBarConditionalFormatting = worksheet.ConditionalFormattings.AddDataBarConditionalFormatting(worksheet.Range("$H$5:$H$18"), lowBound2, highBound2, Color.SkyBlue)
            cfRule2.BorderColor = Color.SkyBlue
            cfRule2.GradientFill = False
            cfRule2.ShowValue = False
            worksheet("B2").Value = "Compare values in the ""Cost Trend"" and ""Markup"" columns using data bars."
            worksheet.Visible = True
'            #End Region ' #DataBarConditionalFormatting
        End Sub

        Private Shared Sub AddIconSetConditionalFormatting(ByVal workbook As IWorkbook)
'            #Region "#IconSetConditionalFormatting"
            Dim worksheet As Worksheet = workbook.Worksheets("cfBooks")
            workbook.Worksheets.ActiveWorksheet = worksheet
            Dim minPoint As ConditionalFormattingIconSetValue = worksheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Formula, "=MIN($F$5:$F$18)", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim midPoint As ConditionalFormattingIconSetValue = worksheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim maxPoint As ConditionalFormattingIconSetValue = worksheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0.01", ConditionalFormattingValueOperator.GreaterOrEqual)
            Dim cfRule As IconSetConditionalFormatting = worksheet.ConditionalFormattings.AddIconSetConditionalFormatting(worksheet.Range("$F$5:$F$18"), IconSetType.Arrows3, New ConditionalFormattingIconSetValue() { minPoint, midPoint, maxPoint })
            cfRule.IsCustom = True
            Dim cfCustomIcon As New ConditionalFormattingCustomIcon()
            cfCustomIcon.IconSet = IconSetType.TrafficLights13
            cfCustomIcon.IconIndex = 1
            cfRule.SetCustomIcon(1, cfCustomIcon)
            cfRule.ShowValue = False
            worksheet("B2").Value = "In the report below identify upward and downward cost trends."
            worksheet.Visible = True
'            #End Region ' #IconSetConditionalFormatting
        End Sub
    End Class
End Namespace
