using DevExpress.Xpf.Grid;
using System.Windows.Controls;

namespace DevExpress.MailClient.View {
    public partial class NavBarMailView : UserControl {
        public NavBarMailView() {
            InitializeComponent();
            TreeListControl.AllowInfiniteGridSize = true;
        }
    }
}
