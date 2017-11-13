using DevExpress.Data.Filtering;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace GridDemo {
    public class TextToCriteriaConverter : IValueConverter {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language) {
            FunctionOperator op = value as FunctionOperator;
            if(object.ReferenceEquals(op, null))
                return null;
            return ((OperandValue)op.Operands[1]).Value;
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language) {
            string text = value as string;
            if(string.IsNullOrEmpty(text))
                return null;
            return new FunctionOperator(FunctionOperatorType.StartsWith, new OperandProperty("City"), text);
        }
    }
    public class DoubleToCriteriaOperatorConverter : IValueConverter {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language) {
            BinaryOperator op = value as BinaryOperator;
            if(object.ReferenceEquals(op, null))
                return 0d;
            OperandValue operandValue = op.RightOperand as OperandValue;
            return operandValue.Value;
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language) {
            return new BinaryOperator("Quantity", Math.Round((double)value), BinaryOperatorType.Greater);
        }
    }
    public class RangeFilter : ContentControl {
        public static readonly DependencyProperty FilterProperty;
        public static readonly DependencyProperty FieldNameProperty;
        public static readonly DependencyProperty MinValueProperty;
        public static readonly DependencyProperty MaxValueProperty;
        static RangeFilter() {
            FilterProperty = DependencyProperty.Register("Filter", typeof(GroupOperator), typeof(RangeFilter), new PropertyMetadata(null, (d, e) => ((RangeFilter)d).OnFilterChanged()));
            FieldNameProperty = DependencyProperty.Register("FieldName", typeof(string), typeof(RangeFilter), new PropertyMetadata(null, (d, e) => ((RangeFilter)d).UpdateFilter()));
            MinValueProperty = DependencyProperty.Register("MinValue", typeof(object), typeof(RangeFilter), new PropertyMetadata(null, (d, e) => ((RangeFilter)d).UpdateFilter()));
            MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(object), typeof(RangeFilter), new PropertyMetadata(null, (d, e) => ((RangeFilter)d).UpdateFilter()));
        }

        public GroupOperator Filter {
            get { return (GroupOperator)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }
        public string FieldName {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }
        public object MinValue {
            get { return GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }
        public object MaxValue {
            get { return GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        bool updateFilterLocked = false;
        void OnFilterChanged() {
            updateFilterLocked = true;
            if(!Equals(Filter, null) && Filter.Operands.Count == 2) {
                BinaryOperator binaryFirstOperator = Filter.Operands[0] as BinaryOperator;
                BinaryOperator binarySecondOperator = Filter.Operands[1] as BinaryOperator;
                if (!ReferenceEquals(binaryFirstOperator, null) && !ReferenceEquals(binarySecondOperator, null)) {
                    MinValue = (binaryFirstOperator.RightOperand as OperandValue).Value;
                    MaxValue = (binarySecondOperator.RightOperand as OperandValue).Value;
                    updateFilterLocked = false;
                    return;
                }
            }
            MinValue = null;
            MaxValue = null;
            updateFilterLocked = false;
        }
        void UpdateFilter() {
            if(!updateFilterLocked)
                Filter = (GroupOperator)CriteriaOperator.And(new BinaryOperator(FieldName, MinValue, BinaryOperatorType.GreaterOrEqual), new BinaryOperator(FieldName, MaxValue, BinaryOperatorType.LessOrEqual));
        }
    }
}
