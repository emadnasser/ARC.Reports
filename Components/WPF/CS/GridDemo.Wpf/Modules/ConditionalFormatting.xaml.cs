using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;
using System.Windows.Media;
using System.Windows.Controls;

namespace GridDemo {
    [CodeFile("ModuleResources/ConditionalFormatting/ConditionalFormattingViewModel.cs")]
    [CodeFile("ModuleResources/ConditionalFormatting/SaleOverviewData.cs")]
    public partial class ConditionalFormatting : GridDemoModule {
        public ConditionalFormatting() {
            InitializeComponent();
        }

        void CustomCellAppearance(object sender, CustomCellAppearanceEventArgs e) {
            ProcessCustomAppearanceEventArgs(e, e.CellSelectionState != SelectionState.None || e.RowSelectionState != SelectionState.None);
        }
        void CustomRowAppearance(object sender, CustomRowAppearanceEventArgs e) {
            ProcessCustomAppearanceEventArgs(e, e.RowSelectionState != SelectionState.None);
        }
        void ProcessCustomAppearanceEventArgs(CustomAppearanceEventArgs e, bool isSelected) {
            if(isSelected) {
                object result = e.ConditionalValue;
                if(e.Property == TextBlock.ForegroundProperty || e.Property == TextBlock.BackgroundProperty) {
                    SolidColorBrush original = e.OriginalValue as SolidColorBrush;
                    SolidColorBrush conditional = e.ConditionalValue as SolidColorBrush;
                    if(conditional != null && (original == null || original.Color != conditional.Color))
                        result = ShadeBrush(conditional);
                }
                e.Result = result;
                e.Handled = true;
            }
        }
        SolidColorBrush ShadeBrush(SolidColorBrush brush) {
            Color originalColor = brush.Color;
            float coefficient = 0.75f;
            byte a = originalColor.A;
            if(!grid.IsKeyboardFocusWithin)
                a = (byte)(originalColor.A / 2);
            byte r = (byte)(originalColor.R * coefficient);
            byte g = (byte)(originalColor.G * coefficient);
            byte b = (byte)(originalColor.B * coefficient);
            return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
    }
}
