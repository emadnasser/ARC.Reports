using System.Drawing;

namespace DevExpress.Web.Demos {
    public class TreeListAppearanceDemoHelper {
        public static Color GetBudgetColor(int value) {
            decimal coeff = value / 1000 - 22;
            int a = (int)(0.02165M * coeff);
            int b = (int)(0.09066M * coeff);
            return Color.FromArgb(255, 235 - a, 177 - b);
        }
    }
}
