using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.Themes;

namespace GridDemo {

    public partial class ScrollBarAnnotations : GridDemoModule {
        public ScrollBarAnnotations() {
            InitializeComponent();
            listAnnotaions.SelectAll();
        }

        private void view_ValidateCell(object sender, DevExpress.Xpf.Grid.GridCellValidationEventArgs e) {
            if(e.CellValue != null) {
                switch(e.Column.FieldName) {
                    case "Quantity":
                        int quantity = int.Parse(e.CellValue.ToString());
                        if(quantity >= 100) {
                            e.IsValid = false;
                            e.SetError("Quantity is greater than or equals to 100");
                        }
                        break;
                    case "Discount":
                        double discount = double.Parse(e.CellValue.ToString());
                        if(discount > 0.21) {
                            e.IsValid = false;
                            e.SetError("Discount is greater than 21%");
                        }
                        break;
                    case "UnitPrice":
                        double val = double.Parse(e.CellValue.ToString());
                        if(val < 2.5) {
                            e.IsValid = false;
                            e.SetError("Unit Price is less than 2.5");
                        }
                        break;
                    default:
                        return;
                }
            }
        }

        private HashSet<int> changedRows = new HashSet<int>();

        private void view_ScrollBarAnnotationsCreating(object sender, ScrollBarAnnotationsCreatingEventArgs e) {
            if(changedRows != null) {
                ScrollBarAnnotationInfo info = new ScrollBarAnnotationInfo(Brushes.Green, ScrollBarAnnotationAlignment.Left, 4, 3);
                e.CustomScrollBarAnnotations = new List<ScrollBarAnnotationRowInfo>(changedRows.Select(x => new ScrollBarAnnotationRowInfo(grid.GetRowHandleByListIndex(x), info)));
            }
        }

        private void view_RowUpdated(object sender, RowEventArgs e) {
            if (changedRows != null)
                changedRows.Add(grid.GetListIndexByRowHandle(e.RowHandle));
        }
    }


    public class ToScrollBarAnnotationsModeConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            var list = value as IEnumerable;
            if(list == null)
                return ScrollBarAnnotationMode.None;
            ScrollBarAnnotationMode result = ScrollBarAnnotationMode.None;
            foreach(var item in list)
                result |= ((AnnotationsDataContext.AnnotationsItem)item).Mode;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    public class ColorAnnotationConverter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            var key = values[0] as DevExpress.Xpf.Grid.Themes.TableViewThemeKeyExtension;
            if(key == null)
                return values[3];
            var treeWalker = values[1] as ThemeTreeWalker;
            var frameworkElement = values[2] as FrameworkElement;
            ThemeResourceConverter converter = new ThemeResourceConverter();
            return converter.Convert(new object[] { treeWalker, key, frameworkElement }, targetType, null, culture);
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    public class AnnotationsDataContext{
        public class AnnotationsItem {
            public string Name { get; set; }
            public ScrollBarAnnotationMode Mode { get; set; }
            public object ResourceKey { get; set; }
            public Brush CustomColor { get; set; }
        }

        public List<AnnotationsItem> AnnotationsItems { get; private set; }

        public AnnotationsDataContext() {
            AnnotationsItems = new List<AnnotationsItem>(){
                new AnnotationsItem(){
                    Name = "Focused Row",
                    Mode = ScrollBarAnnotationMode.FocusedRow,
                    ResourceKey = new TableViewThemeKeyExtension() {ResourceKey = TableViewThemeKeys.AnnotationFocusedRowBrush}
                },
                 new AnnotationsItem(){
                    Name = "Selected Rows",
                    Mode = ScrollBarAnnotationMode.Selected,
                    ResourceKey = new TableViewThemeKeyExtension() {ResourceKey = TableViewThemeKeys.AnnotationSelectionBrush}
                },
                 new AnnotationsItem(){
                    Name = "Search Results",
                    Mode = ScrollBarAnnotationMode.SearchResult,
                    ResourceKey = new TableViewThemeKeyExtension() {ResourceKey = TableViewThemeKeys.AnnotationSearchBrush}
                },
                 new AnnotationsItem(){
                    Name = "Invalid Cells",
                    Mode = ScrollBarAnnotationMode.InvalidCells,
                    ResourceKey = new TableViewThemeKeyExtension() {ResourceKey = TableViewThemeKeys.AnnotationErrorBrush}
                },
                  new AnnotationsItem(){
                    Name = "Modified Rows",
                    Mode = ScrollBarAnnotationMode.Custom,
                    ResourceKey = null,
                    CustomColor = Brushes.Green
                },
            };
        }
    }

}
