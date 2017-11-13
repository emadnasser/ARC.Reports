using DevExpress.UI.Xaml.Controls;

namespace HybridApp.Views {
    public class LongMonthIntervalFactory : MonthIntervalFactory {
        protected override string DefaultTextFormat { get { return "{0:MM}/{0:yyyy}"; } }
    }
}
