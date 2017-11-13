using System;
using DevExpress.Core;
using DevExpress.UI.Xaml.Editors;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace FeatureDemo.Common {
    public class OrientationComboBox : EnumComboBox<Orientation> { }
    public class PlacementComboBox : EnumComboBox<Dock> { }
    public class RatingPrecisionComboBox : EnumComboBox<RatingPrecision> { }
    public class CalendarSelectionModeComboBox : EnumComboBox<CalendarSelectionMode> { }

    [Bindable]
    public abstract class EnumComboBox<TEnum> : ComboBox {
        public EnumComboBox() {
            ItemsSource = Enum.GetValues(typeof(TEnum));
        }
    }
}
