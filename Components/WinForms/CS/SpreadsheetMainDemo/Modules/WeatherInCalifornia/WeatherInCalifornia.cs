using System;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public static class WeatherInCalifornia {
        public static void ApplyTemperatureConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Automatically set the minimum threshold to the lowest value in the range of cells.
            ConditionalFormattingValue minPoint = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax);
            // Set the midpoint threshold to the 50th percentile.
            ConditionalFormattingValue midPoint = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Percentile, "50");
            // Automatically set the maximum threshold to the highest value in the range of cells.
            ConditionalFormattingValue maxPoint = conditionalFormattings.CreateValue(ConditionalFormattingValueType.MinMax);
            // Create the three-color scale rule to determine how values in cells C4 through C60 vary.
            conditionalFormattings.AddColorScale3ConditionalFormatting(sheet.Range["$C$4:$C$60"], minPoint, Color.FromArgb(255, 0x65, 0x92, 0xAF), midPoint, Color.FromArgb(255, 0xF2, 0xA1, 0x6A), maxPoint, Color.FromArgb(255, 0xFF, 0xD5, 0x55));

            
            // Create the rule to identify values that are greater than 40F in cells C4 through C60.
            ExpressionConditionalFormatting cfRule = conditionalFormattings.AddExpressionConditionalFormatting(sheet.Range["$C$4:$C$60"], ConditionalFormattingExpressionCondition.GreaterThan, "40");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color to white.
            cfRule.Formatting.Font.Color = Color.White;
        }
        public static void ApplyHumidityConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
            ConditionalFormattingValue lowBound = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
            ConditionalFormattingValue highBound = conditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Create the rule to compare values in cells E4 through E60 using data bars.  
            DataBarConditionalFormatting cfRule = conditionalFormattings.AddDataBarConditionalFormatting(sheet.Range["$E$4:$E$60"], lowBound, highBound, Color.FromArgb(255, 0xD6, 0xD6, 0xD6));
            // Specify the solid fill type.
            cfRule.GradientFill = false;
        }
        public static void ApplyPressureConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the first threshold to -1.
            ConditionalFormattingIconSetValue minPoint = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "-1", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the second threshold to 0.
            ConditionalFormattingIconSetValue midPoint = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the third threshold to 1.
            ConditionalFormattingIconSetValue maxPoint = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Create the rule to apply a specific icon from the three triangle icon set to each cell in the range  I4:I60 based on its values.   
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(sheet.Range["$I$4:$I$60"], IconSetType.Triangles3, new ConditionalFormattingIconSetValue[] { minPoint, midPoint, maxPoint });
            cfRule.ShowValue = false;
        }
   }
}
