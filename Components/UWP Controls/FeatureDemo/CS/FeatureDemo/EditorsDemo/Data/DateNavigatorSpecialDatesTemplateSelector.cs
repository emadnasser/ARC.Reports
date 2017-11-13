using DevExpress.UI.Xaml.Editors;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EditorsDemo {
    public class DateNavigatorSpecialDatesTemplateSelector : DataTemplateSelector {
        public DataTemplate SpecialDateTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) {
            ICalendarCell cell = item as ICalendarCell;
            return cell != null && cell.State.HasFlag(CalendarCellState.Special) ? SpecialDateTemplate : null;
        }
    }
}
