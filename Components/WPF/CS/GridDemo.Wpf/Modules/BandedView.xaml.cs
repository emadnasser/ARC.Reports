using System.Linq;
using DevExpress.DemoData.Models.Vehicles;

namespace GridDemo {
    public partial class BandedView : GridDemoModule {
        public BandedView() {
            InitializeComponent();
            grid.ItemsSource = new VehiclesContext().Models.ToList();
        }
    }
}
